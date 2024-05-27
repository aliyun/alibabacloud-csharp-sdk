// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Alidns20150109.Models;

namespace AlibabaCloud.SDK.Alidns20150109
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "central";
            CheckConfig(config);
            this._endpoint = GetEndpoint("alidns", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
         * @summary Adds a custom line.
         *
         * @description In each CIDR block, the end IP address must be greater than or equal to the start IP address.\\
         * The CIDR blocks that are specified for all custom lines of a domain name cannot be overlapped.
         *
         * @param request AddCustomLineRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddCustomLineResponse
         */
        public AddCustomLineResponse AddCustomLineWithOptions(AddCustomLineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpSegment))
            {
                query["IpSegment"] = request.IpSegment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LineName))
            {
                query["LineName"] = request.LineName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddCustomLine",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddCustomLineResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Adds a custom line.
         *
         * @description In each CIDR block, the end IP address must be greater than or equal to the start IP address.\\
         * The CIDR blocks that are specified for all custom lines of a domain name cannot be overlapped.
         *
         * @param request AddCustomLineRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddCustomLineResponse
         */
        public async Task<AddCustomLineResponse> AddCustomLineWithOptionsAsync(AddCustomLineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpSegment))
            {
                query["IpSegment"] = request.IpSegment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LineName))
            {
                query["LineName"] = request.LineName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddCustomLine",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddCustomLineResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Adds a custom line.
         *
         * @description In each CIDR block, the end IP address must be greater than or equal to the start IP address.\\
         * The CIDR blocks that are specified for all custom lines of a domain name cannot be overlapped.
         *
         * @param request AddCustomLineRequest
         * @return AddCustomLineResponse
         */
        public AddCustomLineResponse AddCustomLine(AddCustomLineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddCustomLineWithOptions(request, runtime);
        }

        /**
         * @summary Adds a custom line.
         *
         * @description In each CIDR block, the end IP address must be greater than or equal to the start IP address.\\
         * The CIDR blocks that are specified for all custom lines of a domain name cannot be overlapped.
         *
         * @param request AddCustomLineRequest
         * @return AddCustomLineResponse
         */
        public async Task<AddCustomLineResponse> AddCustomLineAsync(AddCustomLineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddCustomLineWithOptionsAsync(request, runtime);
        }

        /**
         * @param request AddDnsCacheDomainRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddDnsCacheDomainResponse
         */
        public AddDnsCacheDomainResponse AddDnsCacheDomainWithOptions(AddDnsCacheDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CacheTtlMax))
            {
                query["CacheTtlMax"] = request.CacheTtlMax;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CacheTtlMin))
            {
                query["CacheTtlMin"] = request.CacheTtlMin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceDnsServer))
            {
                query["SourceDnsServer"] = request.SourceDnsServer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEdns))
            {
                query["SourceEdns"] = request.SourceEdns;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceProtocol))
            {
                query["SourceProtocol"] = request.SourceProtocol;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddDnsCacheDomain",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddDnsCacheDomainResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request AddDnsCacheDomainRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddDnsCacheDomainResponse
         */
        public async Task<AddDnsCacheDomainResponse> AddDnsCacheDomainWithOptionsAsync(AddDnsCacheDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CacheTtlMax))
            {
                query["CacheTtlMax"] = request.CacheTtlMax;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CacheTtlMin))
            {
                query["CacheTtlMin"] = request.CacheTtlMin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceDnsServer))
            {
                query["SourceDnsServer"] = request.SourceDnsServer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEdns))
            {
                query["SourceEdns"] = request.SourceEdns;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceProtocol))
            {
                query["SourceProtocol"] = request.SourceProtocol;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddDnsCacheDomain",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddDnsCacheDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request AddDnsCacheDomainRequest
         * @return AddDnsCacheDomainResponse
         */
        public AddDnsCacheDomainResponse AddDnsCacheDomain(AddDnsCacheDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddDnsCacheDomainWithOptions(request, runtime);
        }

        /**
         * @param request AddDnsCacheDomainRequest
         * @return AddDnsCacheDomainResponse
         */
        public async Task<AddDnsCacheDomainResponse> AddDnsCacheDomainAsync(AddDnsCacheDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddDnsCacheDomainWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates an access policy.
         *
         * @param request AddDnsGtmAccessStrategyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddDnsGtmAccessStrategyResponse
         */
        public AddDnsGtmAccessStrategyResponse AddDnsGtmAccessStrategyWithOptions(AddDnsGtmAccessStrategyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultAddrPool))
            {
                query["DefaultAddrPool"] = request.DefaultAddrPool;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultAddrPoolType))
            {
                query["DefaultAddrPoolType"] = request.DefaultAddrPoolType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultLatencyOptimization))
            {
                query["DefaultLatencyOptimization"] = request.DefaultLatencyOptimization;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultLbaStrategy))
            {
                query["DefaultLbaStrategy"] = request.DefaultLbaStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultMaxReturnAddrNum))
            {
                query["DefaultMaxReturnAddrNum"] = request.DefaultMaxReturnAddrNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultMinAvailableAddrNum))
            {
                query["DefaultMinAvailableAddrNum"] = request.DefaultMinAvailableAddrNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FailoverAddrPool))
            {
                query["FailoverAddrPool"] = request.FailoverAddrPool;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FailoverAddrPoolType))
            {
                query["FailoverAddrPoolType"] = request.FailoverAddrPoolType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FailoverLatencyOptimization))
            {
                query["FailoverLatencyOptimization"] = request.FailoverLatencyOptimization;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FailoverLbaStrategy))
            {
                query["FailoverLbaStrategy"] = request.FailoverLbaStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FailoverMaxReturnAddrNum))
            {
                query["FailoverMaxReturnAddrNum"] = request.FailoverMaxReturnAddrNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FailoverMinAvailableAddrNum))
            {
                query["FailoverMinAvailableAddrNum"] = request.FailoverMinAvailableAddrNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lines))
            {
                query["Lines"] = request.Lines;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyMode))
            {
                query["StrategyMode"] = request.StrategyMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyName))
            {
                query["StrategyName"] = request.StrategyName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddDnsGtmAccessStrategy",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddDnsGtmAccessStrategyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates an access policy.
         *
         * @param request AddDnsGtmAccessStrategyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddDnsGtmAccessStrategyResponse
         */
        public async Task<AddDnsGtmAccessStrategyResponse> AddDnsGtmAccessStrategyWithOptionsAsync(AddDnsGtmAccessStrategyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultAddrPool))
            {
                query["DefaultAddrPool"] = request.DefaultAddrPool;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultAddrPoolType))
            {
                query["DefaultAddrPoolType"] = request.DefaultAddrPoolType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultLatencyOptimization))
            {
                query["DefaultLatencyOptimization"] = request.DefaultLatencyOptimization;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultLbaStrategy))
            {
                query["DefaultLbaStrategy"] = request.DefaultLbaStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultMaxReturnAddrNum))
            {
                query["DefaultMaxReturnAddrNum"] = request.DefaultMaxReturnAddrNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultMinAvailableAddrNum))
            {
                query["DefaultMinAvailableAddrNum"] = request.DefaultMinAvailableAddrNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FailoverAddrPool))
            {
                query["FailoverAddrPool"] = request.FailoverAddrPool;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FailoverAddrPoolType))
            {
                query["FailoverAddrPoolType"] = request.FailoverAddrPoolType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FailoverLatencyOptimization))
            {
                query["FailoverLatencyOptimization"] = request.FailoverLatencyOptimization;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FailoverLbaStrategy))
            {
                query["FailoverLbaStrategy"] = request.FailoverLbaStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FailoverMaxReturnAddrNum))
            {
                query["FailoverMaxReturnAddrNum"] = request.FailoverMaxReturnAddrNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FailoverMinAvailableAddrNum))
            {
                query["FailoverMinAvailableAddrNum"] = request.FailoverMinAvailableAddrNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lines))
            {
                query["Lines"] = request.Lines;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyMode))
            {
                query["StrategyMode"] = request.StrategyMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyName))
            {
                query["StrategyName"] = request.StrategyName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddDnsGtmAccessStrategy",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddDnsGtmAccessStrategyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates an access policy.
         *
         * @param request AddDnsGtmAccessStrategyRequest
         * @return AddDnsGtmAccessStrategyResponse
         */
        public AddDnsGtmAccessStrategyResponse AddDnsGtmAccessStrategy(AddDnsGtmAccessStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddDnsGtmAccessStrategyWithOptions(request, runtime);
        }

        /**
         * @summary Creates an access policy.
         *
         * @param request AddDnsGtmAccessStrategyRequest
         * @return AddDnsGtmAccessStrategyResponse
         */
        public async Task<AddDnsGtmAccessStrategyResponse> AddDnsGtmAccessStrategyAsync(AddDnsGtmAccessStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddDnsGtmAccessStrategyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates an address pool.
         *
         * @param request AddDnsGtmAddressPoolRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddDnsGtmAddressPoolResponse
         */
        public AddDnsGtmAddressPoolResponse AddDnsGtmAddressPoolWithOptions(AddDnsGtmAddressPoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Addr))
            {
                query["Addr"] = request.Addr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EvaluationCount))
            {
                query["EvaluationCount"] = request.EvaluationCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IspCityNode))
            {
                query["IspCityNode"] = request.IspCityNode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LbaStrategy))
            {
                query["LbaStrategy"] = request.LbaStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MonitorExtendInfo))
            {
                query["MonitorExtendInfo"] = request.MonitorExtendInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MonitorStatus))
            {
                query["MonitorStatus"] = request.MonitorStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProtocolType))
            {
                query["ProtocolType"] = request.ProtocolType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                query["Timeout"] = request.Timeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddDnsGtmAddressPool",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddDnsGtmAddressPoolResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates an address pool.
         *
         * @param request AddDnsGtmAddressPoolRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddDnsGtmAddressPoolResponse
         */
        public async Task<AddDnsGtmAddressPoolResponse> AddDnsGtmAddressPoolWithOptionsAsync(AddDnsGtmAddressPoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Addr))
            {
                query["Addr"] = request.Addr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EvaluationCount))
            {
                query["EvaluationCount"] = request.EvaluationCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IspCityNode))
            {
                query["IspCityNode"] = request.IspCityNode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LbaStrategy))
            {
                query["LbaStrategy"] = request.LbaStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MonitorExtendInfo))
            {
                query["MonitorExtendInfo"] = request.MonitorExtendInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MonitorStatus))
            {
                query["MonitorStatus"] = request.MonitorStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProtocolType))
            {
                query["ProtocolType"] = request.ProtocolType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                query["Timeout"] = request.Timeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddDnsGtmAddressPool",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddDnsGtmAddressPoolResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates an address pool.
         *
         * @param request AddDnsGtmAddressPoolRequest
         * @return AddDnsGtmAddressPoolResponse
         */
        public AddDnsGtmAddressPoolResponse AddDnsGtmAddressPool(AddDnsGtmAddressPoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddDnsGtmAddressPoolWithOptions(request, runtime);
        }

        /**
         * @summary Creates an address pool.
         *
         * @param request AddDnsGtmAddressPoolRequest
         * @return AddDnsGtmAddressPoolResponse
         */
        public async Task<AddDnsGtmAddressPoolResponse> AddDnsGtmAddressPoolAsync(AddDnsGtmAddressPoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddDnsGtmAddressPoolWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a health check task.
         *
         * @description ***
         *
         * @param request AddDnsGtmMonitorRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddDnsGtmMonitorResponse
         */
        public AddDnsGtmMonitorResponse AddDnsGtmMonitorWithOptions(AddDnsGtmMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddrPoolId))
            {
                query["AddrPoolId"] = request.AddrPoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EvaluationCount))
            {
                query["EvaluationCount"] = request.EvaluationCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IspCityNode))
            {
                query["IspCityNode"] = request.IspCityNode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MonitorExtendInfo))
            {
                query["MonitorExtendInfo"] = request.MonitorExtendInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProtocolType))
            {
                query["ProtocolType"] = request.ProtocolType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                query["Timeout"] = request.Timeout;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddDnsGtmMonitor",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddDnsGtmMonitorResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates a health check task.
         *
         * @description ***
         *
         * @param request AddDnsGtmMonitorRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddDnsGtmMonitorResponse
         */
        public async Task<AddDnsGtmMonitorResponse> AddDnsGtmMonitorWithOptionsAsync(AddDnsGtmMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddrPoolId))
            {
                query["AddrPoolId"] = request.AddrPoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EvaluationCount))
            {
                query["EvaluationCount"] = request.EvaluationCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IspCityNode))
            {
                query["IspCityNode"] = request.IspCityNode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MonitorExtendInfo))
            {
                query["MonitorExtendInfo"] = request.MonitorExtendInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProtocolType))
            {
                query["ProtocolType"] = request.ProtocolType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                query["Timeout"] = request.Timeout;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddDnsGtmMonitor",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddDnsGtmMonitorResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a health check task.
         *
         * @description ***
         *
         * @param request AddDnsGtmMonitorRequest
         * @return AddDnsGtmMonitorResponse
         */
        public AddDnsGtmMonitorResponse AddDnsGtmMonitor(AddDnsGtmMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddDnsGtmMonitorWithOptions(request, runtime);
        }

        /**
         * @summary Creates a health check task.
         *
         * @description ***
         *
         * @param request AddDnsGtmMonitorRequest
         * @return AddDnsGtmMonitorResponse
         */
        public async Task<AddDnsGtmMonitorResponse> AddDnsGtmMonitorAsync(AddDnsGtmMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddDnsGtmMonitorWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Adds a domain name based on the specified parameters.
         *
         * @description For more information about how to check whether a domain name is valid, see
         * [Domain name validity](https://www.alibabacloud.com/help/zh/doc-detail/67788.htm).
         *
         * @param request AddDomainRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddDomainResponse
         */
        public AddDomainResponse AddDomainWithOptions(AddDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddDomain",
                Version = "2015-01-09",
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

        /**
         * @summary Adds a domain name based on the specified parameters.
         *
         * @description For more information about how to check whether a domain name is valid, see
         * [Domain name validity](https://www.alibabacloud.com/help/zh/doc-detail/67788.htm).
         *
         * @param request AddDomainRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddDomainResponse
         */
        public async Task<AddDomainResponse> AddDomainWithOptionsAsync(AddDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddDomain",
                Version = "2015-01-09",
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

        /**
         * @summary Adds a domain name based on the specified parameters.
         *
         * @description For more information about how to check whether a domain name is valid, see
         * [Domain name validity](https://www.alibabacloud.com/help/zh/doc-detail/67788.htm).
         *
         * @param request AddDomainRequest
         * @return AddDomainResponse
         */
        public AddDomainResponse AddDomain(AddDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddDomainWithOptions(request, runtime);
        }

        /**
         * @summary Adds a domain name based on the specified parameters.
         *
         * @description For more information about how to check whether a domain name is valid, see
         * [Domain name validity](https://www.alibabacloud.com/help/zh/doc-detail/67788.htm).
         *
         * @param request AddDomainRequest
         * @return AddDomainResponse
         */
        public async Task<AddDomainResponse> AddDomainAsync(AddDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddDomainWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a backup task for a domain name.
         *
         * @param request AddDomainBackupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddDomainBackupResponse
         */
        public AddDomainBackupResponse AddDomainBackupWithOptions(AddDomainBackupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodType))
            {
                query["PeriodType"] = request.PeriodType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddDomainBackup",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddDomainBackupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates a backup task for a domain name.
         *
         * @param request AddDomainBackupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddDomainBackupResponse
         */
        public async Task<AddDomainBackupResponse> AddDomainBackupWithOptionsAsync(AddDomainBackupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodType))
            {
                query["PeriodType"] = request.PeriodType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddDomainBackup",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddDomainBackupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a backup task for a domain name.
         *
         * @param request AddDomainBackupRequest
         * @return AddDomainBackupResponse
         */
        public AddDomainBackupResponse AddDomainBackup(AddDomainBackupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddDomainBackupWithOptions(request, runtime);
        }

        /**
         * @summary Creates a backup task for a domain name.
         *
         * @param request AddDomainBackupRequest
         * @return AddDomainBackupResponse
         */
        public async Task<AddDomainBackupResponse> AddDomainBackupAsync(AddDomainBackupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddDomainBackupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a domain name group based on the specified parameters.
         *
         * @param request AddDomainGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddDomainGroupResponse
         */
        public AddDomainGroupResponse AddDomainGroupWithOptions(AddDomainGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddDomainGroup",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddDomainGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates a domain name group based on the specified parameters.
         *
         * @param request AddDomainGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddDomainGroupResponse
         */
        public async Task<AddDomainGroupResponse> AddDomainGroupWithOptionsAsync(AddDomainGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddDomainGroup",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddDomainGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a domain name group based on the specified parameters.
         *
         * @param request AddDomainGroupRequest
         * @return AddDomainGroupResponse
         */
        public AddDomainGroupResponse AddDomainGroup(AddDomainGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddDomainGroupWithOptions(request, runtime);
        }

        /**
         * @summary Creates a domain name group based on the specified parameters.
         *
         * @param request AddDomainGroupRequest
         * @return AddDomainGroupResponse
         */
        public async Task<AddDomainGroupResponse> AddDomainGroupAsync(AddDomainGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddDomainGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Adds a Domain Name System (DNS) record based on the specified parameters.
         *
         * @param request AddDomainRecordRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddDomainRecordResponse
         */
        public AddDomainRecordResponse AddDomainRecordWithOptions(AddDomainRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Line))
            {
                query["Line"] = request.Line;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                query["Priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RR))
            {
                query["RR"] = request.RR;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TTL))
            {
                query["TTL"] = request.TTL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                query["Value"] = request.Value;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddDomainRecord",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddDomainRecordResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Adds a Domain Name System (DNS) record based on the specified parameters.
         *
         * @param request AddDomainRecordRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddDomainRecordResponse
         */
        public async Task<AddDomainRecordResponse> AddDomainRecordWithOptionsAsync(AddDomainRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Line))
            {
                query["Line"] = request.Line;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                query["Priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RR))
            {
                query["RR"] = request.RR;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TTL))
            {
                query["TTL"] = request.TTL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                query["Value"] = request.Value;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddDomainRecord",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddDomainRecordResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Adds a Domain Name System (DNS) record based on the specified parameters.
         *
         * @param request AddDomainRecordRequest
         * @return AddDomainRecordResponse
         */
        public AddDomainRecordResponse AddDomainRecord(AddDomainRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddDomainRecordWithOptions(request, runtime);
        }

        /**
         * @summary Adds a Domain Name System (DNS) record based on the specified parameters.
         *
         * @param request AddDomainRecordRequest
         * @return AddDomainRecordResponse
         */
        public async Task<AddDomainRecordResponse> AddDomainRecordAsync(AddDomainRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddDomainRecordWithOptionsAsync(request, runtime);
        }

        /**
         * @param request AddGtmAccessStrategyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddGtmAccessStrategyResponse
         */
        public AddGtmAccessStrategyResponse AddGtmAccessStrategyWithOptions(AddGtmAccessStrategyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessLines))
            {
                query["AccessLines"] = request.AccessLines;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultAddrPoolId))
            {
                query["DefaultAddrPoolId"] = request.DefaultAddrPoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FailoverAddrPoolId))
            {
                query["FailoverAddrPoolId"] = request.FailoverAddrPoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyName))
            {
                query["StrategyName"] = request.StrategyName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddGtmAccessStrategy",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddGtmAccessStrategyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request AddGtmAccessStrategyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddGtmAccessStrategyResponse
         */
        public async Task<AddGtmAccessStrategyResponse> AddGtmAccessStrategyWithOptionsAsync(AddGtmAccessStrategyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessLines))
            {
                query["AccessLines"] = request.AccessLines;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultAddrPoolId))
            {
                query["DefaultAddrPoolId"] = request.DefaultAddrPoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FailoverAddrPoolId))
            {
                query["FailoverAddrPoolId"] = request.FailoverAddrPoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyName))
            {
                query["StrategyName"] = request.StrategyName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddGtmAccessStrategy",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddGtmAccessStrategyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request AddGtmAccessStrategyRequest
         * @return AddGtmAccessStrategyResponse
         */
        public AddGtmAccessStrategyResponse AddGtmAccessStrategy(AddGtmAccessStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddGtmAccessStrategyWithOptions(request, runtime);
        }

        /**
         * @param request AddGtmAccessStrategyRequest
         * @return AddGtmAccessStrategyResponse
         */
        public async Task<AddGtmAccessStrategyResponse> AddGtmAccessStrategyAsync(AddGtmAccessStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddGtmAccessStrategyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates an address pool.
         *
         * @param request AddGtmAddressPoolRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddGtmAddressPoolResponse
         */
        public AddGtmAddressPoolResponse AddGtmAddressPoolWithOptions(AddGtmAddressPoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Addr))
            {
                query["Addr"] = request.Addr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EvaluationCount))
            {
                query["EvaluationCount"] = request.EvaluationCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IspCityNode))
            {
                query["IspCityNode"] = request.IspCityNode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinAvailableAddrNum))
            {
                query["MinAvailableAddrNum"] = request.MinAvailableAddrNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MonitorExtendInfo))
            {
                query["MonitorExtendInfo"] = request.MonitorExtendInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MonitorStatus))
            {
                query["MonitorStatus"] = request.MonitorStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProtocolType))
            {
                query["ProtocolType"] = request.ProtocolType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                query["Timeout"] = request.Timeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddGtmAddressPool",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddGtmAddressPoolResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates an address pool.
         *
         * @param request AddGtmAddressPoolRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddGtmAddressPoolResponse
         */
        public async Task<AddGtmAddressPoolResponse> AddGtmAddressPoolWithOptionsAsync(AddGtmAddressPoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Addr))
            {
                query["Addr"] = request.Addr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EvaluationCount))
            {
                query["EvaluationCount"] = request.EvaluationCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IspCityNode))
            {
                query["IspCityNode"] = request.IspCityNode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinAvailableAddrNum))
            {
                query["MinAvailableAddrNum"] = request.MinAvailableAddrNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MonitorExtendInfo))
            {
                query["MonitorExtendInfo"] = request.MonitorExtendInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MonitorStatus))
            {
                query["MonitorStatus"] = request.MonitorStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProtocolType))
            {
                query["ProtocolType"] = request.ProtocolType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                query["Timeout"] = request.Timeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddGtmAddressPool",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddGtmAddressPoolResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates an address pool.
         *
         * @param request AddGtmAddressPoolRequest
         * @return AddGtmAddressPoolResponse
         */
        public AddGtmAddressPoolResponse AddGtmAddressPool(AddGtmAddressPoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddGtmAddressPoolWithOptions(request, runtime);
        }

        /**
         * @summary Creates an address pool.
         *
         * @param request AddGtmAddressPoolRequest
         * @return AddGtmAddressPoolResponse
         */
        public async Task<AddGtmAddressPoolResponse> AddGtmAddressPoolAsync(AddGtmAddressPoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddGtmAddressPoolWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a health check task.
         *
         * @param request AddGtmMonitorRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddGtmMonitorResponse
         */
        public AddGtmMonitorResponse AddGtmMonitorWithOptions(AddGtmMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddrPoolId))
            {
                query["AddrPoolId"] = request.AddrPoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EvaluationCount))
            {
                query["EvaluationCount"] = request.EvaluationCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IspCityNode))
            {
                query["IspCityNode"] = request.IspCityNode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MonitorExtendInfo))
            {
                query["MonitorExtendInfo"] = request.MonitorExtendInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProtocolType))
            {
                query["ProtocolType"] = request.ProtocolType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                query["Timeout"] = request.Timeout;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddGtmMonitor",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddGtmMonitorResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates a health check task.
         *
         * @param request AddGtmMonitorRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddGtmMonitorResponse
         */
        public async Task<AddGtmMonitorResponse> AddGtmMonitorWithOptionsAsync(AddGtmMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddrPoolId))
            {
                query["AddrPoolId"] = request.AddrPoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EvaluationCount))
            {
                query["EvaluationCount"] = request.EvaluationCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IspCityNode))
            {
                query["IspCityNode"] = request.IspCityNode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MonitorExtendInfo))
            {
                query["MonitorExtendInfo"] = request.MonitorExtendInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProtocolType))
            {
                query["ProtocolType"] = request.ProtocolType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                query["Timeout"] = request.Timeout;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddGtmMonitor",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddGtmMonitorResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a health check task.
         *
         * @param request AddGtmMonitorRequest
         * @return AddGtmMonitorResponse
         */
        public AddGtmMonitorResponse AddGtmMonitor(AddGtmMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddGtmMonitorWithOptions(request, runtime);
        }

        /**
         * @summary Creates a health check task.
         *
         * @param request AddGtmMonitorRequest
         * @return AddGtmMonitorResponse
         */
        public async Task<AddGtmMonitorResponse> AddGtmMonitorAsync(AddGtmMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddGtmMonitorWithOptionsAsync(request, runtime);
        }

        /**
         * @param request AddGtmRecoveryPlanRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddGtmRecoveryPlanResponse
         */
        public AddGtmRecoveryPlanResponse AddGtmRecoveryPlanWithOptions(AddGtmRecoveryPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaultAddrPool))
            {
                query["FaultAddrPool"] = request.FaultAddrPool;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddGtmRecoveryPlan",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddGtmRecoveryPlanResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request AddGtmRecoveryPlanRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddGtmRecoveryPlanResponse
         */
        public async Task<AddGtmRecoveryPlanResponse> AddGtmRecoveryPlanWithOptionsAsync(AddGtmRecoveryPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaultAddrPool))
            {
                query["FaultAddrPool"] = request.FaultAddrPool;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddGtmRecoveryPlan",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddGtmRecoveryPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request AddGtmRecoveryPlanRequest
         * @return AddGtmRecoveryPlanResponse
         */
        public AddGtmRecoveryPlanResponse AddGtmRecoveryPlan(AddGtmRecoveryPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddGtmRecoveryPlanWithOptions(request, runtime);
        }

        /**
         * @param request AddGtmRecoveryPlanRequest
         * @return AddGtmRecoveryPlanResponse
         */
        public async Task<AddGtmRecoveryPlanResponse> AddGtmRecoveryPlanAsync(AddGtmRecoveryPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddGtmRecoveryPlanWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Binds one or more domain names to a paid Alibaba Cloud DNS instance.
         *
         * @description A paid Alibaba Cloud DNS instance whose ID starts with dns is an instance of the new version. You can call this API operation to bind multiple domain names to the instance. If the upper limit is exceeded, an error message is returned.\\
         * A paid Alibaba Cloud DNS instance whose ID does not start with dns is an instance of the old version. You can call this API operation to bind only one domain name to the instance. However, if the instance is already bound to a domain name, you must unbind the original domain name from the instance and bind the desired domain name to the instance.
         *
         * @param request BindInstanceDomainsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BindInstanceDomainsResponse
         */
        public BindInstanceDomainsResponse BindInstanceDomainsWithOptions(BindInstanceDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainNames))
            {
                query["DomainNames"] = request.DomainNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindInstanceDomains",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindInstanceDomainsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Binds one or more domain names to a paid Alibaba Cloud DNS instance.
         *
         * @description A paid Alibaba Cloud DNS instance whose ID starts with dns is an instance of the new version. You can call this API operation to bind multiple domain names to the instance. If the upper limit is exceeded, an error message is returned.\\
         * A paid Alibaba Cloud DNS instance whose ID does not start with dns is an instance of the old version. You can call this API operation to bind only one domain name to the instance. However, if the instance is already bound to a domain name, you must unbind the original domain name from the instance and bind the desired domain name to the instance.
         *
         * @param request BindInstanceDomainsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BindInstanceDomainsResponse
         */
        public async Task<BindInstanceDomainsResponse> BindInstanceDomainsWithOptionsAsync(BindInstanceDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainNames))
            {
                query["DomainNames"] = request.DomainNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindInstanceDomains",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindInstanceDomainsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Binds one or more domain names to a paid Alibaba Cloud DNS instance.
         *
         * @description A paid Alibaba Cloud DNS instance whose ID starts with dns is an instance of the new version. You can call this API operation to bind multiple domain names to the instance. If the upper limit is exceeded, an error message is returned.\\
         * A paid Alibaba Cloud DNS instance whose ID does not start with dns is an instance of the old version. You can call this API operation to bind only one domain name to the instance. However, if the instance is already bound to a domain name, you must unbind the original domain name from the instance and bind the desired domain name to the instance.
         *
         * @param request BindInstanceDomainsRequest
         * @return BindInstanceDomainsResponse
         */
        public BindInstanceDomainsResponse BindInstanceDomains(BindInstanceDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindInstanceDomainsWithOptions(request, runtime);
        }

        /**
         * @summary Binds one or more domain names to a paid Alibaba Cloud DNS instance.
         *
         * @description A paid Alibaba Cloud DNS instance whose ID starts with dns is an instance of the new version. You can call this API operation to bind multiple domain names to the instance. If the upper limit is exceeded, an error message is returned.\\
         * A paid Alibaba Cloud DNS instance whose ID does not start with dns is an instance of the old version. You can call this API operation to bind only one domain name to the instance. However, if the instance is already bound to a domain name, you must unbind the original domain name from the instance and bind the desired domain name to the instance.
         *
         * @param request BindInstanceDomainsRequest
         * @return BindInstanceDomainsResponse
         */
        public async Task<BindInstanceDomainsResponse> BindInstanceDomainsAsync(BindInstanceDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindInstanceDomainsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Moves a domain name from the original group to the new group based on the specified parameters.
         *
         * @description You can specify GroupId to move a domain name to a specific domain name group. You can move the domain name to the group that contains all domain names or the default group.
         *
         * @param request ChangeDomainGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChangeDomainGroupResponse
         */
        public ChangeDomainGroupResponse ChangeDomainGroupWithOptions(ChangeDomainGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeDomainGroup",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeDomainGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Moves a domain name from the original group to the new group based on the specified parameters.
         *
         * @description You can specify GroupId to move a domain name to a specific domain name group. You can move the domain name to the group that contains all domain names or the default group.
         *
         * @param request ChangeDomainGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChangeDomainGroupResponse
         */
        public async Task<ChangeDomainGroupResponse> ChangeDomainGroupWithOptionsAsync(ChangeDomainGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeDomainGroup",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeDomainGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Moves a domain name from the original group to the new group based on the specified parameters.
         *
         * @description You can specify GroupId to move a domain name to a specific domain name group. You can move the domain name to the group that contains all domain names or the default group.
         *
         * @param request ChangeDomainGroupRequest
         * @return ChangeDomainGroupResponse
         */
        public ChangeDomainGroupResponse ChangeDomainGroup(ChangeDomainGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChangeDomainGroupWithOptions(request, runtime);
        }

        /**
         * @summary Moves a domain name from the original group to the new group based on the specified parameters.
         *
         * @description You can specify GroupId to move a domain name to a specific domain name group. You can move the domain name to the group that contains all domain names or the default group.
         *
         * @param request ChangeDomainGroupRequest
         * @return ChangeDomainGroupResponse
         */
        public async Task<ChangeDomainGroupResponse> ChangeDomainGroupAsync(ChangeDomainGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChangeDomainGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Changes the domain name bound to an Alibaba Cloud DNS instance.
         *
         * @description >  You can call this operation to change the domain name for an Alibaba Cloud DNS instance to which a domain name is bound. You can also call this operation to bind a domain name to an Alibaba Cloud DNS instance to which no domain name is bound. If you need to unbind a domain name from an Alibaba Cloud DNS instance, you can call this operation. In this case, the NewDomain parameter must not be specified.
         *
         * @param request ChangeDomainOfDnsProductRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChangeDomainOfDnsProductResponse
         */
        public ChangeDomainOfDnsProductResponse ChangeDomainOfDnsProductWithOptions(ChangeDomainOfDnsProductRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                query["Force"] = request.Force;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewDomain))
            {
                query["NewDomain"] = request.NewDomain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeDomainOfDnsProduct",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeDomainOfDnsProductResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Changes the domain name bound to an Alibaba Cloud DNS instance.
         *
         * @description >  You can call this operation to change the domain name for an Alibaba Cloud DNS instance to which a domain name is bound. You can also call this operation to bind a domain name to an Alibaba Cloud DNS instance to which no domain name is bound. If you need to unbind a domain name from an Alibaba Cloud DNS instance, you can call this operation. In this case, the NewDomain parameter must not be specified.
         *
         * @param request ChangeDomainOfDnsProductRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChangeDomainOfDnsProductResponse
         */
        public async Task<ChangeDomainOfDnsProductResponse> ChangeDomainOfDnsProductWithOptionsAsync(ChangeDomainOfDnsProductRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                query["Force"] = request.Force;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewDomain))
            {
                query["NewDomain"] = request.NewDomain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeDomainOfDnsProduct",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeDomainOfDnsProductResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Changes the domain name bound to an Alibaba Cloud DNS instance.
         *
         * @description >  You can call this operation to change the domain name for an Alibaba Cloud DNS instance to which a domain name is bound. You can also call this operation to bind a domain name to an Alibaba Cloud DNS instance to which no domain name is bound. If you need to unbind a domain name from an Alibaba Cloud DNS instance, you can call this operation. In this case, the NewDomain parameter must not be specified.
         *
         * @param request ChangeDomainOfDnsProductRequest
         * @return ChangeDomainOfDnsProductResponse
         */
        public ChangeDomainOfDnsProductResponse ChangeDomainOfDnsProduct(ChangeDomainOfDnsProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChangeDomainOfDnsProductWithOptions(request, runtime);
        }

        /**
         * @summary Changes the domain name bound to an Alibaba Cloud DNS instance.
         *
         * @description >  You can call this operation to change the domain name for an Alibaba Cloud DNS instance to which a domain name is bound. You can also call this operation to bind a domain name to an Alibaba Cloud DNS instance to which no domain name is bound. If you need to unbind a domain name from an Alibaba Cloud DNS instance, you can call this operation. In this case, the NewDomain parameter must not be specified.
         *
         * @param request ChangeDomainOfDnsProductRequest
         * @return ChangeDomainOfDnsProductResponse
         */
        public async Task<ChangeDomainOfDnsProductResponse> ChangeDomainOfDnsProductAsync(ChangeDomainOfDnsProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChangeDomainOfDnsProductWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CopyGtmConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CopyGtmConfigResponse
         */
        public CopyGtmConfigResponse CopyGtmConfigWithOptions(CopyGtmConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CopyType))
            {
                query["CopyType"] = request.CopyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                query["SourceId"] = request.SourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetId))
            {
                query["TargetId"] = request.TargetId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CopyGtmConfig",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CopyGtmConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request CopyGtmConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CopyGtmConfigResponse
         */
        public async Task<CopyGtmConfigResponse> CopyGtmConfigWithOptionsAsync(CopyGtmConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CopyType))
            {
                query["CopyType"] = request.CopyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                query["SourceId"] = request.SourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetId))
            {
                query["TargetId"] = request.TargetId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CopyGtmConfig",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CopyGtmConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request CopyGtmConfigRequest
         * @return CopyGtmConfigResponse
         */
        public CopyGtmConfigResponse CopyGtmConfig(CopyGtmConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CopyGtmConfigWithOptions(request, runtime);
        }

        /**
         * @param request CopyGtmConfigRequest
         * @return CopyGtmConfigResponse
         */
        public async Task<CopyGtmConfigResponse> CopyGtmConfigAsync(CopyGtmConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CopyGtmConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建公共DNS AppKey
         *
         * @param request CreatePdnsAppKeyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreatePdnsAppKeyResponse
         */
        public CreatePdnsAppKeyResponse CreatePdnsAppKeyWithOptions(CreatePdnsAppKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePdnsAppKey",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePdnsAppKeyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建公共DNS AppKey
         *
         * @param request CreatePdnsAppKeyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreatePdnsAppKeyResponse
         */
        public async Task<CreatePdnsAppKeyResponse> CreatePdnsAppKeyWithOptionsAsync(CreatePdnsAppKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePdnsAppKey",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePdnsAppKeyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建公共DNS AppKey
         *
         * @param request CreatePdnsAppKeyRequest
         * @return CreatePdnsAppKeyResponse
         */
        public CreatePdnsAppKeyResponse CreatePdnsAppKey(CreatePdnsAppKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreatePdnsAppKeyWithOptions(request, runtime);
        }

        /**
         * @summary 创建公共DNS AppKey
         *
         * @param request CreatePdnsAppKeyRequest
         * @return CreatePdnsAppKeyResponse
         */
        public async Task<CreatePdnsAppKeyResponse> CreatePdnsAppKeyAsync(CreatePdnsAppKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreatePdnsAppKeyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建公共DNS Udp Ip地址段
         *
         * @param request CreatePdnsUdpIpSegmentRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreatePdnsUdpIpSegmentResponse
         */
        public CreatePdnsUdpIpSegmentResponse CreatePdnsUdpIpSegmentWithOptions(CreatePdnsUdpIpSegmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePdnsUdpIpSegment",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePdnsUdpIpSegmentResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建公共DNS Udp Ip地址段
         *
         * @param request CreatePdnsUdpIpSegmentRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreatePdnsUdpIpSegmentResponse
         */
        public async Task<CreatePdnsUdpIpSegmentResponse> CreatePdnsUdpIpSegmentWithOptionsAsync(CreatePdnsUdpIpSegmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePdnsUdpIpSegment",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePdnsUdpIpSegmentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建公共DNS Udp Ip地址段
         *
         * @param request CreatePdnsUdpIpSegmentRequest
         * @return CreatePdnsUdpIpSegmentResponse
         */
        public CreatePdnsUdpIpSegmentResponse CreatePdnsUdpIpSegment(CreatePdnsUdpIpSegmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreatePdnsUdpIpSegmentWithOptions(request, runtime);
        }

        /**
         * @summary 创建公共DNS Udp Ip地址段
         *
         * @param request CreatePdnsUdpIpSegmentRequest
         * @return CreatePdnsUdpIpSegmentResponse
         */
        public async Task<CreatePdnsUdpIpSegmentResponse> CreatePdnsUdpIpSegmentAsync(CreatePdnsUdpIpSegmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreatePdnsUdpIpSegmentWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes multiple custom lines at a time.
         *
         * @param request DeleteCustomLinesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteCustomLinesResponse
         */
        public DeleteCustomLinesResponse DeleteCustomLinesWithOptions(DeleteCustomLinesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LineIds))
            {
                query["LineIds"] = request.LineIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCustomLines",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCustomLinesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes multiple custom lines at a time.
         *
         * @param request DeleteCustomLinesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteCustomLinesResponse
         */
        public async Task<DeleteCustomLinesResponse> DeleteCustomLinesWithOptionsAsync(DeleteCustomLinesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LineIds))
            {
                query["LineIds"] = request.LineIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCustomLines",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCustomLinesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes multiple custom lines at a time.
         *
         * @param request DeleteCustomLinesRequest
         * @return DeleteCustomLinesResponse
         */
        public DeleteCustomLinesResponse DeleteCustomLines(DeleteCustomLinesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCustomLinesWithOptions(request, runtime);
        }

        /**
         * @summary Deletes multiple custom lines at a time.
         *
         * @param request DeleteCustomLinesRequest
         * @return DeleteCustomLinesResponse
         */
        public async Task<DeleteCustomLinesResponse> DeleteCustomLinesAsync(DeleteCustomLinesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCustomLinesWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DeleteDnsCacheDomainRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDnsCacheDomainResponse
         */
        public DeleteDnsCacheDomainResponse DeleteDnsCacheDomainWithOptions(DeleteDnsCacheDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDnsCacheDomain",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDnsCacheDomainResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DeleteDnsCacheDomainRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDnsCacheDomainResponse
         */
        public async Task<DeleteDnsCacheDomainResponse> DeleteDnsCacheDomainWithOptionsAsync(DeleteDnsCacheDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDnsCacheDomain",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDnsCacheDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DeleteDnsCacheDomainRequest
         * @return DeleteDnsCacheDomainResponse
         */
        public DeleteDnsCacheDomainResponse DeleteDnsCacheDomain(DeleteDnsCacheDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDnsCacheDomainWithOptions(request, runtime);
        }

        /**
         * @param request DeleteDnsCacheDomainRequest
         * @return DeleteDnsCacheDomainResponse
         */
        public async Task<DeleteDnsCacheDomainResponse> DeleteDnsCacheDomainAsync(DeleteDnsCacheDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDnsCacheDomainWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DeleteDnsGtmAccessStrategyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDnsGtmAccessStrategyResponse
         */
        public DeleteDnsGtmAccessStrategyResponse DeleteDnsGtmAccessStrategyWithOptions(DeleteDnsGtmAccessStrategyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyId))
            {
                query["StrategyId"] = request.StrategyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDnsGtmAccessStrategy",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDnsGtmAccessStrategyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DeleteDnsGtmAccessStrategyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDnsGtmAccessStrategyResponse
         */
        public async Task<DeleteDnsGtmAccessStrategyResponse> DeleteDnsGtmAccessStrategyWithOptionsAsync(DeleteDnsGtmAccessStrategyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyId))
            {
                query["StrategyId"] = request.StrategyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDnsGtmAccessStrategy",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDnsGtmAccessStrategyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DeleteDnsGtmAccessStrategyRequest
         * @return DeleteDnsGtmAccessStrategyResponse
         */
        public DeleteDnsGtmAccessStrategyResponse DeleteDnsGtmAccessStrategy(DeleteDnsGtmAccessStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDnsGtmAccessStrategyWithOptions(request, runtime);
        }

        /**
         * @param request DeleteDnsGtmAccessStrategyRequest
         * @return DeleteDnsGtmAccessStrategyResponse
         */
        public async Task<DeleteDnsGtmAccessStrategyResponse> DeleteDnsGtmAccessStrategyAsync(DeleteDnsGtmAccessStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDnsGtmAccessStrategyWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DeleteDnsGtmAddressPoolRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDnsGtmAddressPoolResponse
         */
        public DeleteDnsGtmAddressPoolResponse DeleteDnsGtmAddressPoolWithOptions(DeleteDnsGtmAddressPoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddrPoolId))
            {
                query["AddrPoolId"] = request.AddrPoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDnsGtmAddressPool",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDnsGtmAddressPoolResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DeleteDnsGtmAddressPoolRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDnsGtmAddressPoolResponse
         */
        public async Task<DeleteDnsGtmAddressPoolResponse> DeleteDnsGtmAddressPoolWithOptionsAsync(DeleteDnsGtmAddressPoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddrPoolId))
            {
                query["AddrPoolId"] = request.AddrPoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDnsGtmAddressPool",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDnsGtmAddressPoolResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DeleteDnsGtmAddressPoolRequest
         * @return DeleteDnsGtmAddressPoolResponse
         */
        public DeleteDnsGtmAddressPoolResponse DeleteDnsGtmAddressPool(DeleteDnsGtmAddressPoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDnsGtmAddressPoolWithOptions(request, runtime);
        }

        /**
         * @param request DeleteDnsGtmAddressPoolRequest
         * @return DeleteDnsGtmAddressPoolResponse
         */
        public async Task<DeleteDnsGtmAddressPoolResponse> DeleteDnsGtmAddressPoolAsync(DeleteDnsGtmAddressPoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDnsGtmAddressPoolWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes a domain name based on the specified parameters.
         *
         * @param request DeleteDomainRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDomainResponse
         */
        public DeleteDomainResponse DeleteDomainWithOptions(DeleteDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDomain",
                Version = "2015-01-09",
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

        /**
         * @summary Deletes a domain name based on the specified parameters.
         *
         * @param request DeleteDomainRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDomainResponse
         */
        public async Task<DeleteDomainResponse> DeleteDomainWithOptionsAsync(DeleteDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDomain",
                Version = "2015-01-09",
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

        /**
         * @summary Deletes a domain name based on the specified parameters.
         *
         * @param request DeleteDomainRequest
         * @return DeleteDomainResponse
         */
        public DeleteDomainResponse DeleteDomain(DeleteDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDomainWithOptions(request, runtime);
        }

        /**
         * @summary Deletes a domain name based on the specified parameters.
         *
         * @param request DeleteDomainRequest
         * @return DeleteDomainResponse
         */
        public async Task<DeleteDomainResponse> DeleteDomainAsync(DeleteDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDomainWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes a domain name group. After you delete the domain name group, the domain names in the group are moved to the default group.
         *
         * @description >  The default group cannot be deleted.
         *
         * @param request DeleteDomainGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDomainGroupResponse
         */
        public DeleteDomainGroupResponse DeleteDomainGroupWithOptions(DeleteDomainGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDomainGroup",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDomainGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes a domain name group. After you delete the domain name group, the domain names in the group are moved to the default group.
         *
         * @description >  The default group cannot be deleted.
         *
         * @param request DeleteDomainGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDomainGroupResponse
         */
        public async Task<DeleteDomainGroupResponse> DeleteDomainGroupWithOptionsAsync(DeleteDomainGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDomainGroup",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDomainGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes a domain name group. After you delete the domain name group, the domain names in the group are moved to the default group.
         *
         * @description >  The default group cannot be deleted.
         *
         * @param request DeleteDomainGroupRequest
         * @return DeleteDomainGroupResponse
         */
        public DeleteDomainGroupResponse DeleteDomainGroup(DeleteDomainGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDomainGroupWithOptions(request, runtime);
        }

        /**
         * @summary Deletes a domain name group. After you delete the domain name group, the domain names in the group are moved to the default group.
         *
         * @description >  The default group cannot be deleted.
         *
         * @param request DeleteDomainGroupRequest
         * @return DeleteDomainGroupResponse
         */
        public async Task<DeleteDomainGroupResponse> DeleteDomainGroupAsync(DeleteDomainGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDomainGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes a Domain Name System (DNS) record based on the specified parameters.
         *
         * @param request DeleteDomainRecordRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDomainRecordResponse
         */
        public DeleteDomainRecordResponse DeleteDomainRecordWithOptions(DeleteDomainRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordId))
            {
                query["RecordId"] = request.RecordId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDomainRecord",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDomainRecordResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes a Domain Name System (DNS) record based on the specified parameters.
         *
         * @param request DeleteDomainRecordRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDomainRecordResponse
         */
        public async Task<DeleteDomainRecordResponse> DeleteDomainRecordWithOptionsAsync(DeleteDomainRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordId))
            {
                query["RecordId"] = request.RecordId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDomainRecord",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDomainRecordResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes a Domain Name System (DNS) record based on the specified parameters.
         *
         * @param request DeleteDomainRecordRequest
         * @return DeleteDomainRecordResponse
         */
        public DeleteDomainRecordResponse DeleteDomainRecord(DeleteDomainRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDomainRecordWithOptions(request, runtime);
        }

        /**
         * @summary Deletes a Domain Name System (DNS) record based on the specified parameters.
         *
         * @param request DeleteDomainRecordRequest
         * @return DeleteDomainRecordResponse
         */
        public async Task<DeleteDomainRecordResponse> DeleteDomainRecordAsync(DeleteDomainRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDomainRecordWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DeleteGtmAccessStrategyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteGtmAccessStrategyResponse
         */
        public DeleteGtmAccessStrategyResponse DeleteGtmAccessStrategyWithOptions(DeleteGtmAccessStrategyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyId))
            {
                query["StrategyId"] = request.StrategyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteGtmAccessStrategy",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGtmAccessStrategyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DeleteGtmAccessStrategyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteGtmAccessStrategyResponse
         */
        public async Task<DeleteGtmAccessStrategyResponse> DeleteGtmAccessStrategyWithOptionsAsync(DeleteGtmAccessStrategyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyId))
            {
                query["StrategyId"] = request.StrategyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteGtmAccessStrategy",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGtmAccessStrategyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DeleteGtmAccessStrategyRequest
         * @return DeleteGtmAccessStrategyResponse
         */
        public DeleteGtmAccessStrategyResponse DeleteGtmAccessStrategy(DeleteGtmAccessStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteGtmAccessStrategyWithOptions(request, runtime);
        }

        /**
         * @param request DeleteGtmAccessStrategyRequest
         * @return DeleteGtmAccessStrategyResponse
         */
        public async Task<DeleteGtmAccessStrategyResponse> DeleteGtmAccessStrategyAsync(DeleteGtmAccessStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteGtmAccessStrategyWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DeleteGtmAddressPoolRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteGtmAddressPoolResponse
         */
        public DeleteGtmAddressPoolResponse DeleteGtmAddressPoolWithOptions(DeleteGtmAddressPoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddrPoolId))
            {
                query["AddrPoolId"] = request.AddrPoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteGtmAddressPool",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGtmAddressPoolResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DeleteGtmAddressPoolRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteGtmAddressPoolResponse
         */
        public async Task<DeleteGtmAddressPoolResponse> DeleteGtmAddressPoolWithOptionsAsync(DeleteGtmAddressPoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddrPoolId))
            {
                query["AddrPoolId"] = request.AddrPoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteGtmAddressPool",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGtmAddressPoolResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DeleteGtmAddressPoolRequest
         * @return DeleteGtmAddressPoolResponse
         */
        public DeleteGtmAddressPoolResponse DeleteGtmAddressPool(DeleteGtmAddressPoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteGtmAddressPoolWithOptions(request, runtime);
        }

        /**
         * @param request DeleteGtmAddressPoolRequest
         * @return DeleteGtmAddressPoolResponse
         */
        public async Task<DeleteGtmAddressPoolResponse> DeleteGtmAddressPoolAsync(DeleteGtmAddressPoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteGtmAddressPoolWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DeleteGtmRecoveryPlanRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteGtmRecoveryPlanResponse
         */
        public DeleteGtmRecoveryPlanResponse DeleteGtmRecoveryPlanWithOptions(DeleteGtmRecoveryPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryPlanId))
            {
                query["RecoveryPlanId"] = request.RecoveryPlanId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteGtmRecoveryPlan",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGtmRecoveryPlanResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DeleteGtmRecoveryPlanRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteGtmRecoveryPlanResponse
         */
        public async Task<DeleteGtmRecoveryPlanResponse> DeleteGtmRecoveryPlanWithOptionsAsync(DeleteGtmRecoveryPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryPlanId))
            {
                query["RecoveryPlanId"] = request.RecoveryPlanId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteGtmRecoveryPlan",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGtmRecoveryPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DeleteGtmRecoveryPlanRequest
         * @return DeleteGtmRecoveryPlanResponse
         */
        public DeleteGtmRecoveryPlanResponse DeleteGtmRecoveryPlan(DeleteGtmRecoveryPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteGtmRecoveryPlanWithOptions(request, runtime);
        }

        /**
         * @param request DeleteGtmRecoveryPlanRequest
         * @return DeleteGtmRecoveryPlanResponse
         */
        public async Task<DeleteGtmRecoveryPlanResponse> DeleteGtmRecoveryPlanAsync(DeleteGtmRecoveryPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteGtmRecoveryPlanWithOptionsAsync(request, runtime);
        }

        /**
         * @description If the DNS records to be deleted contain locked DNS records, locked DNS records will not be deleted.
         *
         * @param request DeleteSubDomainRecordsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteSubDomainRecordsResponse
         */
        public DeleteSubDomainRecordsResponse DeleteSubDomainRecordsWithOptions(DeleteSubDomainRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RR))
            {
                query["RR"] = request.RR;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSubDomainRecords",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSubDomainRecordsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @description If the DNS records to be deleted contain locked DNS records, locked DNS records will not be deleted.
         *
         * @param request DeleteSubDomainRecordsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteSubDomainRecordsResponse
         */
        public async Task<DeleteSubDomainRecordsResponse> DeleteSubDomainRecordsWithOptionsAsync(DeleteSubDomainRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RR))
            {
                query["RR"] = request.RR;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSubDomainRecords",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSubDomainRecordsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @description If the DNS records to be deleted contain locked DNS records, locked DNS records will not be deleted.
         *
         * @param request DeleteSubDomainRecordsRequest
         * @return DeleteSubDomainRecordsResponse
         */
        public DeleteSubDomainRecordsResponse DeleteSubDomainRecords(DeleteSubDomainRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSubDomainRecordsWithOptions(request, runtime);
        }

        /**
         * @description If the DNS records to be deleted contain locked DNS records, locked DNS records will not be deleted.
         *
         * @param request DeleteSubDomainRecordsRequest
         * @return DeleteSubDomainRecordsResponse
         */
        public async Task<DeleteSubDomainRecordsResponse> DeleteSubDomainRecordsAsync(DeleteSubDomainRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSubDomainRecordsWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeBatchResultCountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeBatchResultCountResponse
         */
        public DescribeBatchResultCountResponse DescribeBatchResultCountWithOptions(DescribeBatchResultCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchType))
            {
                query["BatchType"] = request.BatchType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
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
                Action = "DescribeBatchResultCount",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBatchResultCountResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeBatchResultCountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeBatchResultCountResponse
         */
        public async Task<DescribeBatchResultCountResponse> DescribeBatchResultCountWithOptionsAsync(DescribeBatchResultCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchType))
            {
                query["BatchType"] = request.BatchType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
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
                Action = "DescribeBatchResultCount",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBatchResultCountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeBatchResultCountRequest
         * @return DescribeBatchResultCountResponse
         */
        public DescribeBatchResultCountResponse DescribeBatchResultCount(DescribeBatchResultCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBatchResultCountWithOptions(request, runtime);
        }

        /**
         * @param request DescribeBatchResultCountRequest
         * @return DescribeBatchResultCountResponse
         */
        public async Task<DescribeBatchResultCountResponse> DescribeBatchResultCountAsync(DescribeBatchResultCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBatchResultCountWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the detailed results of a batch operation task.
         *
         * @description Before you call this operation, make sure that the batch operation task is complete.
         *
         * @param request DescribeBatchResultDetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeBatchResultDetailResponse
         */
        public DescribeBatchResultDetailResponse DescribeBatchResultDetailWithOptions(DescribeBatchResultDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchType))
            {
                query["BatchType"] = request.BatchType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
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
                Action = "DescribeBatchResultDetail",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBatchResultDetailResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the detailed results of a batch operation task.
         *
         * @description Before you call this operation, make sure that the batch operation task is complete.
         *
         * @param request DescribeBatchResultDetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeBatchResultDetailResponse
         */
        public async Task<DescribeBatchResultDetailResponse> DescribeBatchResultDetailWithOptionsAsync(DescribeBatchResultDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchType))
            {
                query["BatchType"] = request.BatchType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
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
                Action = "DescribeBatchResultDetail",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBatchResultDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the detailed results of a batch operation task.
         *
         * @description Before you call this operation, make sure that the batch operation task is complete.
         *
         * @param request DescribeBatchResultDetailRequest
         * @return DescribeBatchResultDetailResponse
         */
        public DescribeBatchResultDetailResponse DescribeBatchResultDetail(DescribeBatchResultDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBatchResultDetailWithOptions(request, runtime);
        }

        /**
         * @summary Queries the detailed results of a batch operation task.
         *
         * @description Before you call this operation, make sure that the batch operation task is complete.
         *
         * @param request DescribeBatchResultDetailRequest
         * @return DescribeBatchResultDetailResponse
         */
        public async Task<DescribeBatchResultDetailResponse> DescribeBatchResultDetailAsync(DescribeBatchResultDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBatchResultDetailWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeCloudGtmAddressPoolRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeCloudGtmAddressPoolResponse
         */
        public DescribeCloudGtmAddressPoolResponse DescribeCloudGtmAddressPoolWithOptions(DescribeCloudGtmAddressPoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                query["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressPoolId))
            {
                query["AddressPoolId"] = request.AddressPoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCloudGtmAddressPool",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCloudGtmAddressPoolResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeCloudGtmAddressPoolRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeCloudGtmAddressPoolResponse
         */
        public async Task<DescribeCloudGtmAddressPoolResponse> DescribeCloudGtmAddressPoolWithOptionsAsync(DescribeCloudGtmAddressPoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                query["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressPoolId))
            {
                query["AddressPoolId"] = request.AddressPoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCloudGtmAddressPool",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCloudGtmAddressPoolResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeCloudGtmAddressPoolRequest
         * @return DescribeCloudGtmAddressPoolResponse
         */
        public DescribeCloudGtmAddressPoolResponse DescribeCloudGtmAddressPool(DescribeCloudGtmAddressPoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCloudGtmAddressPoolWithOptions(request, runtime);
        }

        /**
         * @param request DescribeCloudGtmAddressPoolRequest
         * @return DescribeCloudGtmAddressPoolResponse
         */
        public async Task<DescribeCloudGtmAddressPoolResponse> DescribeCloudGtmAddressPoolAsync(DescribeCloudGtmAddressPoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCloudGtmAddressPoolWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries a custom line.
         *
         * @param request DescribeCustomLineRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeCustomLineResponse
         */
        public DescribeCustomLineResponse DescribeCustomLineWithOptions(DescribeCustomLineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LineId))
            {
                query["LineId"] = request.LineId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCustomLine",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCustomLineResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries a custom line.
         *
         * @param request DescribeCustomLineRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeCustomLineResponse
         */
        public async Task<DescribeCustomLineResponse> DescribeCustomLineWithOptionsAsync(DescribeCustomLineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LineId))
            {
                query["LineId"] = request.LineId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCustomLine",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCustomLineResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries a custom line.
         *
         * @param request DescribeCustomLineRequest
         * @return DescribeCustomLineResponse
         */
        public DescribeCustomLineResponse DescribeCustomLine(DescribeCustomLineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCustomLineWithOptions(request, runtime);
        }

        /**
         * @summary Queries a custom line.
         *
         * @param request DescribeCustomLineRequest
         * @return DescribeCustomLineResponse
         */
        public async Task<DescribeCustomLineResponse> DescribeCustomLineAsync(DescribeCustomLineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCustomLineWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries custom lines.
         *
         * @param request DescribeCustomLinesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeCustomLinesResponse
         */
        public DescribeCustomLinesResponse DescribeCustomLinesWithOptions(DescribeCustomLinesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
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
                Action = "DescribeCustomLines",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCustomLinesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries custom lines.
         *
         * @param request DescribeCustomLinesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeCustomLinesResponse
         */
        public async Task<DescribeCustomLinesResponse> DescribeCustomLinesWithOptionsAsync(DescribeCustomLinesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
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
                Action = "DescribeCustomLines",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCustomLinesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries custom lines.
         *
         * @param request DescribeCustomLinesRequest
         * @return DescribeCustomLinesResponse
         */
        public DescribeCustomLinesResponse DescribeCustomLines(DescribeCustomLinesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCustomLinesWithOptions(request, runtime);
        }

        /**
         * @summary Queries custom lines.
         *
         * @param request DescribeCustomLinesRequest
         * @return DescribeCustomLinesResponse
         */
        public async Task<DescribeCustomLinesResponse> DescribeCustomLinesAsync(DescribeCustomLinesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCustomLinesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the subdomains for which weighted round-robin is enabled based on the specified parameters.
         *
         * @param request DescribeDNSSLBSubDomainsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDNSSLBSubDomainsResponse
         */
        public DescribeDNSSLBSubDomainsResponse DescribeDNSSLBSubDomainsWithOptions(DescribeDNSSLBSubDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rr))
            {
                query["Rr"] = request.Rr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDNSSLBSubDomains",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDNSSLBSubDomainsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the subdomains for which weighted round-robin is enabled based on the specified parameters.
         *
         * @param request DescribeDNSSLBSubDomainsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDNSSLBSubDomainsResponse
         */
        public async Task<DescribeDNSSLBSubDomainsResponse> DescribeDNSSLBSubDomainsWithOptionsAsync(DescribeDNSSLBSubDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rr))
            {
                query["Rr"] = request.Rr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDNSSLBSubDomains",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDNSSLBSubDomainsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the subdomains for which weighted round-robin is enabled based on the specified parameters.
         *
         * @param request DescribeDNSSLBSubDomainsRequest
         * @return DescribeDNSSLBSubDomainsResponse
         */
        public DescribeDNSSLBSubDomainsResponse DescribeDNSSLBSubDomains(DescribeDNSSLBSubDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDNSSLBSubDomainsWithOptions(request, runtime);
        }

        /**
         * @summary Queries the subdomains for which weighted round-robin is enabled based on the specified parameters.
         *
         * @param request DescribeDNSSLBSubDomainsRequest
         * @return DescribeDNSSLBSubDomainsResponse
         */
        public async Task<DescribeDNSSLBSubDomainsResponse> DescribeDNSSLBSubDomainsAsync(DescribeDNSSLBSubDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDNSSLBSubDomainsWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeDnsCacheDomainsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDnsCacheDomainsResponse
         */
        public DescribeDnsCacheDomainsResponse DescribeDnsCacheDomainsWithOptions(DescribeDnsCacheDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
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
                Action = "DescribeDnsCacheDomains",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDnsCacheDomainsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeDnsCacheDomainsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDnsCacheDomainsResponse
         */
        public async Task<DescribeDnsCacheDomainsResponse> DescribeDnsCacheDomainsWithOptionsAsync(DescribeDnsCacheDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
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
                Action = "DescribeDnsCacheDomains",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDnsCacheDomainsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeDnsCacheDomainsRequest
         * @return DescribeDnsCacheDomainsResponse
         */
        public DescribeDnsCacheDomainsResponse DescribeDnsCacheDomains(DescribeDnsCacheDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDnsCacheDomainsWithOptions(request, runtime);
        }

        /**
         * @param request DescribeDnsCacheDomainsRequest
         * @return DescribeDnsCacheDomainsResponse
         */
        public async Task<DescribeDnsCacheDomainsResponse> DescribeDnsCacheDomainsAsync(DescribeDnsCacheDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDnsCacheDomainsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries access policies of a Global Traffic Manager (GTM) instance.
         *
         * @param request DescribeDnsGtmAccessStrategiesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDnsGtmAccessStrategiesResponse
         */
        public DescribeDnsGtmAccessStrategiesResponse DescribeDnsGtmAccessStrategiesWithOptions(DescribeDnsGtmAccessStrategiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyMode))
            {
                query["StrategyMode"] = request.StrategyMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDnsGtmAccessStrategies",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDnsGtmAccessStrategiesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries access policies of a Global Traffic Manager (GTM) instance.
         *
         * @param request DescribeDnsGtmAccessStrategiesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDnsGtmAccessStrategiesResponse
         */
        public async Task<DescribeDnsGtmAccessStrategiesResponse> DescribeDnsGtmAccessStrategiesWithOptionsAsync(DescribeDnsGtmAccessStrategiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyMode))
            {
                query["StrategyMode"] = request.StrategyMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDnsGtmAccessStrategies",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDnsGtmAccessStrategiesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries access policies of a Global Traffic Manager (GTM) instance.
         *
         * @param request DescribeDnsGtmAccessStrategiesRequest
         * @return DescribeDnsGtmAccessStrategiesResponse
         */
        public DescribeDnsGtmAccessStrategiesResponse DescribeDnsGtmAccessStrategies(DescribeDnsGtmAccessStrategiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDnsGtmAccessStrategiesWithOptions(request, runtime);
        }

        /**
         * @summary Queries access policies of a Global Traffic Manager (GTM) instance.
         *
         * @param request DescribeDnsGtmAccessStrategiesRequest
         * @return DescribeDnsGtmAccessStrategiesResponse
         */
        public async Task<DescribeDnsGtmAccessStrategiesResponse> DescribeDnsGtmAccessStrategiesAsync(DescribeDnsGtmAccessStrategiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDnsGtmAccessStrategiesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries detailed information about an access policy of a Global Traffic Manager (GTM) instance.
         *
         * @param request DescribeDnsGtmAccessStrategyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDnsGtmAccessStrategyResponse
         */
        public DescribeDnsGtmAccessStrategyResponse DescribeDnsGtmAccessStrategyWithOptions(DescribeDnsGtmAccessStrategyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyId))
            {
                query["StrategyId"] = request.StrategyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDnsGtmAccessStrategy",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDnsGtmAccessStrategyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries detailed information about an access policy of a Global Traffic Manager (GTM) instance.
         *
         * @param request DescribeDnsGtmAccessStrategyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDnsGtmAccessStrategyResponse
         */
        public async Task<DescribeDnsGtmAccessStrategyResponse> DescribeDnsGtmAccessStrategyWithOptionsAsync(DescribeDnsGtmAccessStrategyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyId))
            {
                query["StrategyId"] = request.StrategyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDnsGtmAccessStrategy",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDnsGtmAccessStrategyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries detailed information about an access policy of a Global Traffic Manager (GTM) instance.
         *
         * @param request DescribeDnsGtmAccessStrategyRequest
         * @return DescribeDnsGtmAccessStrategyResponse
         */
        public DescribeDnsGtmAccessStrategyResponse DescribeDnsGtmAccessStrategy(DescribeDnsGtmAccessStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDnsGtmAccessStrategyWithOptions(request, runtime);
        }

        /**
         * @summary Queries detailed information about an access policy of a Global Traffic Manager (GTM) instance.
         *
         * @param request DescribeDnsGtmAccessStrategyRequest
         * @return DescribeDnsGtmAccessStrategyResponse
         */
        public async Task<DescribeDnsGtmAccessStrategyResponse> DescribeDnsGtmAccessStrategyAsync(DescribeDnsGtmAccessStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDnsGtmAccessStrategyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the available configurations of an access policy of a Global Traffic Manager (GTM) instance.
         *
         * @param request DescribeDnsGtmAccessStrategyAvailableConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDnsGtmAccessStrategyAvailableConfigResponse
         */
        public DescribeDnsGtmAccessStrategyAvailableConfigResponse DescribeDnsGtmAccessStrategyAvailableConfigWithOptions(DescribeDnsGtmAccessStrategyAvailableConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyMode))
            {
                query["StrategyMode"] = request.StrategyMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDnsGtmAccessStrategyAvailableConfig",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDnsGtmAccessStrategyAvailableConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the available configurations of an access policy of a Global Traffic Manager (GTM) instance.
         *
         * @param request DescribeDnsGtmAccessStrategyAvailableConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDnsGtmAccessStrategyAvailableConfigResponse
         */
        public async Task<DescribeDnsGtmAccessStrategyAvailableConfigResponse> DescribeDnsGtmAccessStrategyAvailableConfigWithOptionsAsync(DescribeDnsGtmAccessStrategyAvailableConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyMode))
            {
                query["StrategyMode"] = request.StrategyMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDnsGtmAccessStrategyAvailableConfig",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDnsGtmAccessStrategyAvailableConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the available configurations of an access policy of a Global Traffic Manager (GTM) instance.
         *
         * @param request DescribeDnsGtmAccessStrategyAvailableConfigRequest
         * @return DescribeDnsGtmAccessStrategyAvailableConfigResponse
         */
        public DescribeDnsGtmAccessStrategyAvailableConfigResponse DescribeDnsGtmAccessStrategyAvailableConfig(DescribeDnsGtmAccessStrategyAvailableConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDnsGtmAccessStrategyAvailableConfigWithOptions(request, runtime);
        }

        /**
         * @summary Queries the available configurations of an access policy of a Global Traffic Manager (GTM) instance.
         *
         * @param request DescribeDnsGtmAccessStrategyAvailableConfigRequest
         * @return DescribeDnsGtmAccessStrategyAvailableConfigResponse
         */
        public async Task<DescribeDnsGtmAccessStrategyAvailableConfigResponse> DescribeDnsGtmAccessStrategyAvailableConfigAsync(DescribeDnsGtmAccessStrategyAvailableConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDnsGtmAccessStrategyAvailableConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeDnsGtmAddrAttributeInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDnsGtmAddrAttributeInfoResponse
         */
        public DescribeDnsGtmAddrAttributeInfoResponse DescribeDnsGtmAddrAttributeInfoWithOptions(DescribeDnsGtmAddrAttributeInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Addrs))
            {
                query["Addrs"] = request.Addrs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDnsGtmAddrAttributeInfo",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDnsGtmAddrAttributeInfoResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeDnsGtmAddrAttributeInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDnsGtmAddrAttributeInfoResponse
         */
        public async Task<DescribeDnsGtmAddrAttributeInfoResponse> DescribeDnsGtmAddrAttributeInfoWithOptionsAsync(DescribeDnsGtmAddrAttributeInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Addrs))
            {
                query["Addrs"] = request.Addrs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDnsGtmAddrAttributeInfo",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDnsGtmAddrAttributeInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeDnsGtmAddrAttributeInfoRequest
         * @return DescribeDnsGtmAddrAttributeInfoResponse
         */
        public DescribeDnsGtmAddrAttributeInfoResponse DescribeDnsGtmAddrAttributeInfo(DescribeDnsGtmAddrAttributeInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDnsGtmAddrAttributeInfoWithOptions(request, runtime);
        }

        /**
         * @param request DescribeDnsGtmAddrAttributeInfoRequest
         * @return DescribeDnsGtmAddrAttributeInfoResponse
         */
        public async Task<DescribeDnsGtmAddrAttributeInfoResponse> DescribeDnsGtmAddrAttributeInfoAsync(DescribeDnsGtmAddrAttributeInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDnsGtmAddrAttributeInfoWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the available configurations of an address pool of a Global Traffic Manager (GTM) instance.
         *
         * @param request DescribeDnsGtmAddressPoolAvailableConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDnsGtmAddressPoolAvailableConfigResponse
         */
        public DescribeDnsGtmAddressPoolAvailableConfigResponse DescribeDnsGtmAddressPoolAvailableConfigWithOptions(DescribeDnsGtmAddressPoolAvailableConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDnsGtmAddressPoolAvailableConfig",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDnsGtmAddressPoolAvailableConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the available configurations of an address pool of a Global Traffic Manager (GTM) instance.
         *
         * @param request DescribeDnsGtmAddressPoolAvailableConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDnsGtmAddressPoolAvailableConfigResponse
         */
        public async Task<DescribeDnsGtmAddressPoolAvailableConfigResponse> DescribeDnsGtmAddressPoolAvailableConfigWithOptionsAsync(DescribeDnsGtmAddressPoolAvailableConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDnsGtmAddressPoolAvailableConfig",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDnsGtmAddressPoolAvailableConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the available configurations of an address pool of a Global Traffic Manager (GTM) instance.
         *
         * @param request DescribeDnsGtmAddressPoolAvailableConfigRequest
         * @return DescribeDnsGtmAddressPoolAvailableConfigResponse
         */
        public DescribeDnsGtmAddressPoolAvailableConfigResponse DescribeDnsGtmAddressPoolAvailableConfig(DescribeDnsGtmAddressPoolAvailableConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDnsGtmAddressPoolAvailableConfigWithOptions(request, runtime);
        }

        /**
         * @summary Queries the available configurations of an address pool of a Global Traffic Manager (GTM) instance.
         *
         * @param request DescribeDnsGtmAddressPoolAvailableConfigRequest
         * @return DescribeDnsGtmAddressPoolAvailableConfigResponse
         */
        public async Task<DescribeDnsGtmAddressPoolAvailableConfigResponse> DescribeDnsGtmAddressPoolAvailableConfigAsync(DescribeDnsGtmAddressPoolAvailableConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDnsGtmAddressPoolAvailableConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeDnsGtmAvailableAlertGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDnsGtmAvailableAlertGroupResponse
         */
        public DescribeDnsGtmAvailableAlertGroupResponse DescribeDnsGtmAvailableAlertGroupWithOptions(DescribeDnsGtmAvailableAlertGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDnsGtmAvailableAlertGroup",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDnsGtmAvailableAlertGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeDnsGtmAvailableAlertGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDnsGtmAvailableAlertGroupResponse
         */
        public async Task<DescribeDnsGtmAvailableAlertGroupResponse> DescribeDnsGtmAvailableAlertGroupWithOptionsAsync(DescribeDnsGtmAvailableAlertGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDnsGtmAvailableAlertGroup",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDnsGtmAvailableAlertGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeDnsGtmAvailableAlertGroupRequest
         * @return DescribeDnsGtmAvailableAlertGroupResponse
         */
        public DescribeDnsGtmAvailableAlertGroupResponse DescribeDnsGtmAvailableAlertGroup(DescribeDnsGtmAvailableAlertGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDnsGtmAvailableAlertGroupWithOptions(request, runtime);
        }

        /**
         * @param request DescribeDnsGtmAvailableAlertGroupRequest
         * @return DescribeDnsGtmAvailableAlertGroupResponse
         */
        public async Task<DescribeDnsGtmAvailableAlertGroupResponse> DescribeDnsGtmAvailableAlertGroupAsync(DescribeDnsGtmAvailableAlertGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDnsGtmAvailableAlertGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries detailed information about a Global Traffic Manager (GTM) instance.
         *
         * @param request DescribeDnsGtmInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDnsGtmInstanceResponse
         */
        public DescribeDnsGtmInstanceResponse DescribeDnsGtmInstanceWithOptions(DescribeDnsGtmInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDnsGtmInstance",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDnsGtmInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries detailed information about a Global Traffic Manager (GTM) instance.
         *
         * @param request DescribeDnsGtmInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDnsGtmInstanceResponse
         */
        public async Task<DescribeDnsGtmInstanceResponse> DescribeDnsGtmInstanceWithOptionsAsync(DescribeDnsGtmInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDnsGtmInstance",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDnsGtmInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries detailed information about a Global Traffic Manager (GTM) instance.
         *
         * @param request DescribeDnsGtmInstanceRequest
         * @return DescribeDnsGtmInstanceResponse
         */
        public DescribeDnsGtmInstanceResponse DescribeDnsGtmInstance(DescribeDnsGtmInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDnsGtmInstanceWithOptions(request, runtime);
        }

        /**
         * @summary Queries detailed information about a Global Traffic Manager (GTM) instance.
         *
         * @param request DescribeDnsGtmInstanceRequest
         * @return DescribeDnsGtmInstanceResponse
         */
        public async Task<DescribeDnsGtmInstanceResponse> DescribeDnsGtmInstanceAsync(DescribeDnsGtmInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDnsGtmInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries detailed information about an address pool of a Global Traffic Manager (GTM) instance.
         *
         * @param request DescribeDnsGtmInstanceAddressPoolRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDnsGtmInstanceAddressPoolResponse
         */
        public DescribeDnsGtmInstanceAddressPoolResponse DescribeDnsGtmInstanceAddressPoolWithOptions(DescribeDnsGtmInstanceAddressPoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddrPoolId))
            {
                query["AddrPoolId"] = request.AddrPoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDnsGtmInstanceAddressPool",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDnsGtmInstanceAddressPoolResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries detailed information about an address pool of a Global Traffic Manager (GTM) instance.
         *
         * @param request DescribeDnsGtmInstanceAddressPoolRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDnsGtmInstanceAddressPoolResponse
         */
        public async Task<DescribeDnsGtmInstanceAddressPoolResponse> DescribeDnsGtmInstanceAddressPoolWithOptionsAsync(DescribeDnsGtmInstanceAddressPoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddrPoolId))
            {
                query["AddrPoolId"] = request.AddrPoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDnsGtmInstanceAddressPool",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDnsGtmInstanceAddressPoolResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries detailed information about an address pool of a Global Traffic Manager (GTM) instance.
         *
         * @param request DescribeDnsGtmInstanceAddressPoolRequest
         * @return DescribeDnsGtmInstanceAddressPoolResponse
         */
        public DescribeDnsGtmInstanceAddressPoolResponse DescribeDnsGtmInstanceAddressPool(DescribeDnsGtmInstanceAddressPoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDnsGtmInstanceAddressPoolWithOptions(request, runtime);
        }

        /**
         * @summary Queries detailed information about an address pool of a Global Traffic Manager (GTM) instance.
         *
         * @param request DescribeDnsGtmInstanceAddressPoolRequest
         * @return DescribeDnsGtmInstanceAddressPoolResponse
         */
        public async Task<DescribeDnsGtmInstanceAddressPoolResponse> DescribeDnsGtmInstanceAddressPoolAsync(DescribeDnsGtmInstanceAddressPoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDnsGtmInstanceAddressPoolWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the address pools of a Global Traffic Manager (GTM) instance.
         *
         * @param request DescribeDnsGtmInstanceAddressPoolsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDnsGtmInstanceAddressPoolsResponse
         */
        public DescribeDnsGtmInstanceAddressPoolsResponse DescribeDnsGtmInstanceAddressPoolsWithOptions(DescribeDnsGtmInstanceAddressPoolsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
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
                Action = "DescribeDnsGtmInstanceAddressPools",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDnsGtmInstanceAddressPoolsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the address pools of a Global Traffic Manager (GTM) instance.
         *
         * @param request DescribeDnsGtmInstanceAddressPoolsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDnsGtmInstanceAddressPoolsResponse
         */
        public async Task<DescribeDnsGtmInstanceAddressPoolsResponse> DescribeDnsGtmInstanceAddressPoolsWithOptionsAsync(DescribeDnsGtmInstanceAddressPoolsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
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
                Action = "DescribeDnsGtmInstanceAddressPools",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDnsGtmInstanceAddressPoolsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the address pools of a Global Traffic Manager (GTM) instance.
         *
         * @param request DescribeDnsGtmInstanceAddressPoolsRequest
         * @return DescribeDnsGtmInstanceAddressPoolsResponse
         */
        public DescribeDnsGtmInstanceAddressPoolsResponse DescribeDnsGtmInstanceAddressPools(DescribeDnsGtmInstanceAddressPoolsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDnsGtmInstanceAddressPoolsWithOptions(request, runtime);
        }

        /**
         * @summary Queries the address pools of a Global Traffic Manager (GTM) instance.
         *
         * @param request DescribeDnsGtmInstanceAddressPoolsRequest
         * @return DescribeDnsGtmInstanceAddressPoolsResponse
         */
        public async Task<DescribeDnsGtmInstanceAddressPoolsResponse> DescribeDnsGtmInstanceAddressPoolsAsync(DescribeDnsGtmInstanceAddressPoolsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDnsGtmInstanceAddressPoolsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the status of a Global Traffic Manager (GTM) instance.
         *
         * @param request DescribeDnsGtmInstanceStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDnsGtmInstanceStatusResponse
         */
        public DescribeDnsGtmInstanceStatusResponse DescribeDnsGtmInstanceStatusWithOptions(DescribeDnsGtmInstanceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDnsGtmInstanceStatus",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDnsGtmInstanceStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the status of a Global Traffic Manager (GTM) instance.
         *
         * @param request DescribeDnsGtmInstanceStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDnsGtmInstanceStatusResponse
         */
        public async Task<DescribeDnsGtmInstanceStatusResponse> DescribeDnsGtmInstanceStatusWithOptionsAsync(DescribeDnsGtmInstanceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDnsGtmInstanceStatus",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDnsGtmInstanceStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the status of a Global Traffic Manager (GTM) instance.
         *
         * @param request DescribeDnsGtmInstanceStatusRequest
         * @return DescribeDnsGtmInstanceStatusResponse
         */
        public DescribeDnsGtmInstanceStatusResponse DescribeDnsGtmInstanceStatus(DescribeDnsGtmInstanceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDnsGtmInstanceStatusWithOptions(request, runtime);
        }

        /**
         * @summary Queries the status of a Global Traffic Manager (GTM) instance.
         *
         * @param request DescribeDnsGtmInstanceStatusRequest
         * @return DescribeDnsGtmInstanceStatusResponse
         */
        public async Task<DescribeDnsGtmInstanceStatusResponse> DescribeDnsGtmInstanceStatusAsync(DescribeDnsGtmInstanceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDnsGtmInstanceStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the CNAME domain name assigned by the system for a Global Traffic Manager (GTM) instance.
         *
         * @param request DescribeDnsGtmInstanceSystemCnameRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDnsGtmInstanceSystemCnameResponse
         */
        public DescribeDnsGtmInstanceSystemCnameResponse DescribeDnsGtmInstanceSystemCnameWithOptions(DescribeDnsGtmInstanceSystemCnameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDnsGtmInstanceSystemCname",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDnsGtmInstanceSystemCnameResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the CNAME domain name assigned by the system for a Global Traffic Manager (GTM) instance.
         *
         * @param request DescribeDnsGtmInstanceSystemCnameRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDnsGtmInstanceSystemCnameResponse
         */
        public async Task<DescribeDnsGtmInstanceSystemCnameResponse> DescribeDnsGtmInstanceSystemCnameWithOptionsAsync(DescribeDnsGtmInstanceSystemCnameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDnsGtmInstanceSystemCname",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDnsGtmInstanceSystemCnameResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the CNAME domain name assigned by the system for a Global Traffic Manager (GTM) instance.
         *
         * @param request DescribeDnsGtmInstanceSystemCnameRequest
         * @return DescribeDnsGtmInstanceSystemCnameResponse
         */
        public DescribeDnsGtmInstanceSystemCnameResponse DescribeDnsGtmInstanceSystemCname(DescribeDnsGtmInstanceSystemCnameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDnsGtmInstanceSystemCnameWithOptions(request, runtime);
        }

        /**
         * @summary Queries the CNAME domain name assigned by the system for a Global Traffic Manager (GTM) instance.
         *
         * @param request DescribeDnsGtmInstanceSystemCnameRequest
         * @return DescribeDnsGtmInstanceSystemCnameResponse
         */
        public async Task<DescribeDnsGtmInstanceSystemCnameResponse> DescribeDnsGtmInstanceSystemCnameAsync(DescribeDnsGtmInstanceSystemCnameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDnsGtmInstanceSystemCnameWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeDnsGtmInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDnsGtmInstancesResponse
         */
        public DescribeDnsGtmInstancesResponse DescribeDnsGtmInstancesWithOptions(DescribeDnsGtmInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDnsGtmInstances",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDnsGtmInstancesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeDnsGtmInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDnsGtmInstancesResponse
         */
        public async Task<DescribeDnsGtmInstancesResponse> DescribeDnsGtmInstancesWithOptionsAsync(DescribeDnsGtmInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDnsGtmInstances",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDnsGtmInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeDnsGtmInstancesRequest
         * @return DescribeDnsGtmInstancesResponse
         */
        public DescribeDnsGtmInstancesResponse DescribeDnsGtmInstances(DescribeDnsGtmInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDnsGtmInstancesWithOptions(request, runtime);
        }

        /**
         * @param request DescribeDnsGtmInstancesRequest
         * @return DescribeDnsGtmInstancesResponse
         */
        public async Task<DescribeDnsGtmInstancesResponse> DescribeDnsGtmInstancesAsync(DescribeDnsGtmInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDnsGtmInstancesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries operation logs of a Global Traffic Manager (GTM) instance.
         *
         * @param request DescribeDnsGtmLogsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDnsGtmLogsResponse
         */
        public DescribeDnsGtmLogsResponse DescribeDnsGtmLogsWithOptions(DescribeDnsGtmLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTimestamp))
            {
                query["EndTimestamp"] = request.EndTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTimestamp))
            {
                query["StartTimestamp"] = request.StartTimestamp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDnsGtmLogs",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDnsGtmLogsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries operation logs of a Global Traffic Manager (GTM) instance.
         *
         * @param request DescribeDnsGtmLogsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDnsGtmLogsResponse
         */
        public async Task<DescribeDnsGtmLogsResponse> DescribeDnsGtmLogsWithOptionsAsync(DescribeDnsGtmLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTimestamp))
            {
                query["EndTimestamp"] = request.EndTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTimestamp))
            {
                query["StartTimestamp"] = request.StartTimestamp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDnsGtmLogs",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDnsGtmLogsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries operation logs of a Global Traffic Manager (GTM) instance.
         *
         * @param request DescribeDnsGtmLogsRequest
         * @return DescribeDnsGtmLogsResponse
         */
        public DescribeDnsGtmLogsResponse DescribeDnsGtmLogs(DescribeDnsGtmLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDnsGtmLogsWithOptions(request, runtime);
        }

        /**
         * @summary Queries operation logs of a Global Traffic Manager (GTM) instance.
         *
         * @param request DescribeDnsGtmLogsRequest
         * @return DescribeDnsGtmLogsResponse
         */
        public async Task<DescribeDnsGtmLogsResponse> DescribeDnsGtmLogsAsync(DescribeDnsGtmLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDnsGtmLogsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries available monitored nodes.
         *
         * @param request DescribeDnsGtmMonitorAvailableConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDnsGtmMonitorAvailableConfigResponse
         */
        public DescribeDnsGtmMonitorAvailableConfigResponse DescribeDnsGtmMonitorAvailableConfigWithOptions(DescribeDnsGtmMonitorAvailableConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDnsGtmMonitorAvailableConfig",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDnsGtmMonitorAvailableConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries available monitored nodes.
         *
         * @param request DescribeDnsGtmMonitorAvailableConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDnsGtmMonitorAvailableConfigResponse
         */
        public async Task<DescribeDnsGtmMonitorAvailableConfigResponse> DescribeDnsGtmMonitorAvailableConfigWithOptionsAsync(DescribeDnsGtmMonitorAvailableConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDnsGtmMonitorAvailableConfig",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDnsGtmMonitorAvailableConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries available monitored nodes.
         *
         * @param request DescribeDnsGtmMonitorAvailableConfigRequest
         * @return DescribeDnsGtmMonitorAvailableConfigResponse
         */
        public DescribeDnsGtmMonitorAvailableConfigResponse DescribeDnsGtmMonitorAvailableConfig(DescribeDnsGtmMonitorAvailableConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDnsGtmMonitorAvailableConfigWithOptions(request, runtime);
        }

        /**
         * @summary Queries available monitored nodes.
         *
         * @param request DescribeDnsGtmMonitorAvailableConfigRequest
         * @return DescribeDnsGtmMonitorAvailableConfigResponse
         */
        public async Task<DescribeDnsGtmMonitorAvailableConfigResponse> DescribeDnsGtmMonitorAvailableConfigAsync(DescribeDnsGtmMonitorAvailableConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDnsGtmMonitorAvailableConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the health check configurations of an address pool of a Global Traffic Manager (GTM) instance.
         *
         * @param request DescribeDnsGtmMonitorConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDnsGtmMonitorConfigResponse
         */
        public DescribeDnsGtmMonitorConfigResponse DescribeDnsGtmMonitorConfigWithOptions(DescribeDnsGtmMonitorConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MonitorConfigId))
            {
                query["MonitorConfigId"] = request.MonitorConfigId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDnsGtmMonitorConfig",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDnsGtmMonitorConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the health check configurations of an address pool of a Global Traffic Manager (GTM) instance.
         *
         * @param request DescribeDnsGtmMonitorConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDnsGtmMonitorConfigResponse
         */
        public async Task<DescribeDnsGtmMonitorConfigResponse> DescribeDnsGtmMonitorConfigWithOptionsAsync(DescribeDnsGtmMonitorConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MonitorConfigId))
            {
                query["MonitorConfigId"] = request.MonitorConfigId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDnsGtmMonitorConfig",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDnsGtmMonitorConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the health check configurations of an address pool of a Global Traffic Manager (GTM) instance.
         *
         * @param request DescribeDnsGtmMonitorConfigRequest
         * @return DescribeDnsGtmMonitorConfigResponse
         */
        public DescribeDnsGtmMonitorConfigResponse DescribeDnsGtmMonitorConfig(DescribeDnsGtmMonitorConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDnsGtmMonitorConfigWithOptions(request, runtime);
        }

        /**
         * @summary Queries the health check configurations of an address pool of a Global Traffic Manager (GTM) instance.
         *
         * @param request DescribeDnsGtmMonitorConfigRequest
         * @return DescribeDnsGtmMonitorConfigResponse
         */
        public async Task<DescribeDnsGtmMonitorConfigResponse> DescribeDnsGtmMonitorConfigAsync(DescribeDnsGtmMonitorConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDnsGtmMonitorConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the details about a paid Alibaba Cloud DNS instance based on the instance ID.
         *
         * @param request DescribeDnsProductInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDnsProductInstanceResponse
         */
        public DescribeDnsProductInstanceResponse DescribeDnsProductInstanceWithOptions(DescribeDnsProductInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDnsProductInstance",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDnsProductInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the details about a paid Alibaba Cloud DNS instance based on the instance ID.
         *
         * @param request DescribeDnsProductInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDnsProductInstanceResponse
         */
        public async Task<DescribeDnsProductInstanceResponse> DescribeDnsProductInstanceWithOptionsAsync(DescribeDnsProductInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDnsProductInstance",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDnsProductInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the details about a paid Alibaba Cloud DNS instance based on the instance ID.
         *
         * @param request DescribeDnsProductInstanceRequest
         * @return DescribeDnsProductInstanceResponse
         */
        public DescribeDnsProductInstanceResponse DescribeDnsProductInstance(DescribeDnsProductInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDnsProductInstanceWithOptions(request, runtime);
        }

        /**
         * @summary Queries the details about a paid Alibaba Cloud DNS instance based on the instance ID.
         *
         * @param request DescribeDnsProductInstanceRequest
         * @return DescribeDnsProductInstanceResponse
         */
        public async Task<DescribeDnsProductInstanceResponse> DescribeDnsProductInstanceAsync(DescribeDnsProductInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDnsProductInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Calls the DescribeDnsProductInstances operation to query the list of paid Alibaba Cloud DNS instances based on input parameters.
         *
         * @description >  If the response parameters of an Alibaba Cloud DNS instance do not contain domain names, no domain names are bound to the instance.
         *
         * @param request DescribeDnsProductInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDnsProductInstancesResponse
         */
        public DescribeDnsProductInstancesResponse DescribeDnsProductInstancesWithOptions(DescribeDnsProductInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainType))
            {
                query["DomainType"] = request.DomainType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionCode))
            {
                query["VersionCode"] = request.VersionCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDnsProductInstances",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDnsProductInstancesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Calls the DescribeDnsProductInstances operation to query the list of paid Alibaba Cloud DNS instances based on input parameters.
         *
         * @description >  If the response parameters of an Alibaba Cloud DNS instance do not contain domain names, no domain names are bound to the instance.
         *
         * @param request DescribeDnsProductInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDnsProductInstancesResponse
         */
        public async Task<DescribeDnsProductInstancesResponse> DescribeDnsProductInstancesWithOptionsAsync(DescribeDnsProductInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainType))
            {
                query["DomainType"] = request.DomainType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionCode))
            {
                query["VersionCode"] = request.VersionCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDnsProductInstances",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDnsProductInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Calls the DescribeDnsProductInstances operation to query the list of paid Alibaba Cloud DNS instances based on input parameters.
         *
         * @description >  If the response parameters of an Alibaba Cloud DNS instance do not contain domain names, no domain names are bound to the instance.
         *
         * @param request DescribeDnsProductInstancesRequest
         * @return DescribeDnsProductInstancesResponse
         */
        public DescribeDnsProductInstancesResponse DescribeDnsProductInstances(DescribeDnsProductInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDnsProductInstancesWithOptions(request, runtime);
        }

        /**
         * @summary Calls the DescribeDnsProductInstances operation to query the list of paid Alibaba Cloud DNS instances based on input parameters.
         *
         * @description >  If the response parameters of an Alibaba Cloud DNS instance do not contain domain names, no domain names are bound to the instance.
         *
         * @param request DescribeDnsProductInstancesRequest
         * @return DescribeDnsProductInstancesResponse
         */
        public async Task<DescribeDnsProductInstancesResponse> DescribeDnsProductInstancesAsync(DescribeDnsProductInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDnsProductInstancesWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeDohAccountStatisticsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDohAccountStatisticsResponse
         */
        public DescribeDohAccountStatisticsResponse DescribeDohAccountStatisticsWithOptions(DescribeDohAccountStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
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
                Action = "DescribeDohAccountStatistics",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDohAccountStatisticsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeDohAccountStatisticsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDohAccountStatisticsResponse
         */
        public async Task<DescribeDohAccountStatisticsResponse> DescribeDohAccountStatisticsWithOptionsAsync(DescribeDohAccountStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
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
                Action = "DescribeDohAccountStatistics",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDohAccountStatisticsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeDohAccountStatisticsRequest
         * @return DescribeDohAccountStatisticsResponse
         */
        public DescribeDohAccountStatisticsResponse DescribeDohAccountStatistics(DescribeDohAccountStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDohAccountStatisticsWithOptions(request, runtime);
        }

        /**
         * @param request DescribeDohAccountStatisticsRequest
         * @return DescribeDohAccountStatisticsResponse
         */
        public async Task<DescribeDohAccountStatisticsResponse> DescribeDohAccountStatisticsAsync(DescribeDohAccountStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDohAccountStatisticsWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeDohDomainStatisticsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDohDomainStatisticsResponse
         */
        public DescribeDohDomainStatisticsResponse DescribeDohDomainStatisticsWithOptions(DescribeDohDomainStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
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
                Action = "DescribeDohDomainStatistics",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDohDomainStatisticsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeDohDomainStatisticsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDohDomainStatisticsResponse
         */
        public async Task<DescribeDohDomainStatisticsResponse> DescribeDohDomainStatisticsWithOptionsAsync(DescribeDohDomainStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
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
                Action = "DescribeDohDomainStatistics",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDohDomainStatisticsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeDohDomainStatisticsRequest
         * @return DescribeDohDomainStatisticsResponse
         */
        public DescribeDohDomainStatisticsResponse DescribeDohDomainStatistics(DescribeDohDomainStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDohDomainStatisticsWithOptions(request, runtime);
        }

        /**
         * @param request DescribeDohDomainStatisticsRequest
         * @return DescribeDohDomainStatisticsResponse
         */
        public async Task<DescribeDohDomainStatisticsResponse> DescribeDohDomainStatisticsAsync(DescribeDohDomainStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDohDomainStatisticsWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeDohDomainStatisticsSummaryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDohDomainStatisticsSummaryResponse
         */
        public DescribeDohDomainStatisticsSummaryResponse DescribeDohDomainStatisticsSummaryWithOptions(DescribeDohDomainStatisticsSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
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
                Action = "DescribeDohDomainStatisticsSummary",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDohDomainStatisticsSummaryResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeDohDomainStatisticsSummaryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDohDomainStatisticsSummaryResponse
         */
        public async Task<DescribeDohDomainStatisticsSummaryResponse> DescribeDohDomainStatisticsSummaryWithOptionsAsync(DescribeDohDomainStatisticsSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
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
                Action = "DescribeDohDomainStatisticsSummary",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDohDomainStatisticsSummaryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeDohDomainStatisticsSummaryRequest
         * @return DescribeDohDomainStatisticsSummaryResponse
         */
        public DescribeDohDomainStatisticsSummaryResponse DescribeDohDomainStatisticsSummary(DescribeDohDomainStatisticsSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDohDomainStatisticsSummaryWithOptions(request, runtime);
        }

        /**
         * @param request DescribeDohDomainStatisticsSummaryRequest
         * @return DescribeDohDomainStatisticsSummaryResponse
         */
        public async Task<DescribeDohDomainStatisticsSummaryResponse> DescribeDohDomainStatisticsSummaryAsync(DescribeDohDomainStatisticsSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDohDomainStatisticsSummaryWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeDohSubDomainStatisticsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDohSubDomainStatisticsResponse
         */
        public DescribeDohSubDomainStatisticsResponse DescribeDohSubDomainStatisticsWithOptions(DescribeDohSubDomainStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubDomain))
            {
                query["SubDomain"] = request.SubDomain;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDohSubDomainStatistics",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDohSubDomainStatisticsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeDohSubDomainStatisticsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDohSubDomainStatisticsResponse
         */
        public async Task<DescribeDohSubDomainStatisticsResponse> DescribeDohSubDomainStatisticsWithOptionsAsync(DescribeDohSubDomainStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubDomain))
            {
                query["SubDomain"] = request.SubDomain;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDohSubDomainStatistics",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDohSubDomainStatisticsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeDohSubDomainStatisticsRequest
         * @return DescribeDohSubDomainStatisticsResponse
         */
        public DescribeDohSubDomainStatisticsResponse DescribeDohSubDomainStatistics(DescribeDohSubDomainStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDohSubDomainStatisticsWithOptions(request, runtime);
        }

        /**
         * @param request DescribeDohSubDomainStatisticsRequest
         * @return DescribeDohSubDomainStatisticsResponse
         */
        public async Task<DescribeDohSubDomainStatisticsResponse> DescribeDohSubDomainStatisticsAsync(DescribeDohSubDomainStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDohSubDomainStatisticsWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeDohSubDomainStatisticsSummaryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDohSubDomainStatisticsSummaryResponse
         */
        public DescribeDohSubDomainStatisticsSummaryResponse DescribeDohSubDomainStatisticsSummaryWithOptions(DescribeDohSubDomainStatisticsSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubDomain))
            {
                query["SubDomain"] = request.SubDomain;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDohSubDomainStatisticsSummary",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDohSubDomainStatisticsSummaryResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeDohSubDomainStatisticsSummaryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDohSubDomainStatisticsSummaryResponse
         */
        public async Task<DescribeDohSubDomainStatisticsSummaryResponse> DescribeDohSubDomainStatisticsSummaryWithOptionsAsync(DescribeDohSubDomainStatisticsSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubDomain))
            {
                query["SubDomain"] = request.SubDomain;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDohSubDomainStatisticsSummary",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDohSubDomainStatisticsSummaryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeDohSubDomainStatisticsSummaryRequest
         * @return DescribeDohSubDomainStatisticsSummaryResponse
         */
        public DescribeDohSubDomainStatisticsSummaryResponse DescribeDohSubDomainStatisticsSummary(DescribeDohSubDomainStatisticsSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDohSubDomainStatisticsSummaryWithOptions(request, runtime);
        }

        /**
         * @param request DescribeDohSubDomainStatisticsSummaryRequest
         * @return DescribeDohSubDomainStatisticsSummaryResponse
         */
        public async Task<DescribeDohSubDomainStatisticsSummaryResponse> DescribeDohSubDomainStatisticsSummaryAsync(DescribeDohSubDomainStatisticsSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDohSubDomainStatisticsSummaryWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the numbers of accessed domains and subdomains by using DNS over HTTPS (DoH).
         *
         * @param request DescribeDohUserInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDohUserInfoResponse
         */
        public DescribeDohUserInfoResponse DescribeDohUserInfoWithOptions(DescribeDohUserInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
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
                Action = "DescribeDohUserInfo",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDohUserInfoResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the numbers of accessed domains and subdomains by using DNS over HTTPS (DoH).
         *
         * @param request DescribeDohUserInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDohUserInfoResponse
         */
        public async Task<DescribeDohUserInfoResponse> DescribeDohUserInfoWithOptionsAsync(DescribeDohUserInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
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
                Action = "DescribeDohUserInfo",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDohUserInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the numbers of accessed domains and subdomains by using DNS over HTTPS (DoH).
         *
         * @param request DescribeDohUserInfoRequest
         * @return DescribeDohUserInfoResponse
         */
        public DescribeDohUserInfoResponse DescribeDohUserInfo(DescribeDohUserInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDohUserInfoWithOptions(request, runtime);
        }

        /**
         * @summary Queries the numbers of accessed domains and subdomains by using DNS over HTTPS (DoH).
         *
         * @param request DescribeDohUserInfoRequest
         * @return DescribeDohUserInfoResponse
         */
        public async Task<DescribeDohUserInfoResponse> DescribeDohUserInfoAsync(DescribeDohUserInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDohUserInfoWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the Domain Name System Security Extensions (DNSSEC) configurations of a domain name based on the specified parameters.
         *
         * @param request DescribeDomainDnssecInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDomainDnssecInfoResponse
         */
        public DescribeDomainDnssecInfoResponse DescribeDomainDnssecInfoWithOptions(DescribeDomainDnssecInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomainDnssecInfo",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainDnssecInfoResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the Domain Name System Security Extensions (DNSSEC) configurations of a domain name based on the specified parameters.
         *
         * @param request DescribeDomainDnssecInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDomainDnssecInfoResponse
         */
        public async Task<DescribeDomainDnssecInfoResponse> DescribeDomainDnssecInfoWithOptionsAsync(DescribeDomainDnssecInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomainDnssecInfo",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainDnssecInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the Domain Name System Security Extensions (DNSSEC) configurations of a domain name based on the specified parameters.
         *
         * @param request DescribeDomainDnssecInfoRequest
         * @return DescribeDomainDnssecInfoResponse
         */
        public DescribeDomainDnssecInfoResponse DescribeDomainDnssecInfo(DescribeDomainDnssecInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainDnssecInfoWithOptions(request, runtime);
        }

        /**
         * @summary Queries the Domain Name System Security Extensions (DNSSEC) configurations of a domain name based on the specified parameters.
         *
         * @param request DescribeDomainDnssecInfoRequest
         * @return DescribeDomainDnssecInfoResponse
         */
        public async Task<DescribeDomainDnssecInfoResponse> DescribeDomainDnssecInfoAsync(DescribeDomainDnssecInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainDnssecInfoWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries all domain name groups based on the specified parameters.
         *
         * @param request DescribeDomainGroupsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDomainGroupsResponse
         */
        public DescribeDomainGroupsResponse DescribeDomainGroupsWithOptions(DescribeDomainGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyWord))
            {
                query["KeyWord"] = request.KeyWord;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
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
                Action = "DescribeDomainGroups",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainGroupsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries all domain name groups based on the specified parameters.
         *
         * @param request DescribeDomainGroupsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDomainGroupsResponse
         */
        public async Task<DescribeDomainGroupsResponse> DescribeDomainGroupsWithOptionsAsync(DescribeDomainGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyWord))
            {
                query["KeyWord"] = request.KeyWord;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
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
                Action = "DescribeDomainGroups",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries all domain name groups based on the specified parameters.
         *
         * @param request DescribeDomainGroupsRequest
         * @return DescribeDomainGroupsResponse
         */
        public DescribeDomainGroupsResponse DescribeDomainGroups(DescribeDomainGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainGroupsWithOptions(request, runtime);
        }

        /**
         * @summary Queries all domain name groups based on the specified parameters.
         *
         * @param request DescribeDomainGroupsRequest
         * @return DescribeDomainGroupsResponse
         */
        public async Task<DescribeDomainGroupsResponse> DescribeDomainGroupsAsync(DescribeDomainGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainGroupsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the information about a domain name based on specified parameters.
         *
         * @description In this example, the domain name is bound to an instance of Alibaba Cloud DNS Enterprise Ultimate Edition. For more information about valid Domain Name System (DNS) request lines, see the return values of the RecordLines parameter.
         *
         * @param request DescribeDomainInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDomainInfoResponse
         */
        public DescribeDomainInfoResponse DescribeDomainInfoWithOptions(DescribeDomainInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedDetailAttributes))
            {
                query["NeedDetailAttributes"] = request.NeedDetailAttributes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomainInfo",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainInfoResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the information about a domain name based on specified parameters.
         *
         * @description In this example, the domain name is bound to an instance of Alibaba Cloud DNS Enterprise Ultimate Edition. For more information about valid Domain Name System (DNS) request lines, see the return values of the RecordLines parameter.
         *
         * @param request DescribeDomainInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDomainInfoResponse
         */
        public async Task<DescribeDomainInfoResponse> DescribeDomainInfoWithOptionsAsync(DescribeDomainInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedDetailAttributes))
            {
                query["NeedDetailAttributes"] = request.NeedDetailAttributes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomainInfo",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the information about a domain name based on specified parameters.
         *
         * @description In this example, the domain name is bound to an instance of Alibaba Cloud DNS Enterprise Ultimate Edition. For more information about valid Domain Name System (DNS) request lines, see the return values of the RecordLines parameter.
         *
         * @param request DescribeDomainInfoRequest
         * @return DescribeDomainInfoResponse
         */
        public DescribeDomainInfoResponse DescribeDomainInfo(DescribeDomainInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainInfoWithOptions(request, runtime);
        }

        /**
         * @summary Queries the information about a domain name based on specified parameters.
         *
         * @description In this example, the domain name is bound to an instance of Alibaba Cloud DNS Enterprise Ultimate Edition. For more information about valid Domain Name System (DNS) request lines, see the return values of the RecordLines parameter.
         *
         * @param request DescribeDomainInfoRequest
         * @return DescribeDomainInfoResponse
         */
        public async Task<DescribeDomainInfoResponse> DescribeDomainInfoAsync(DescribeDomainInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainInfoWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the operation logs of domain names based on the specified parameters.
         *
         * @param request DescribeDomainLogsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDomainLogsResponse
         */
        public DescribeDomainLogsResponse DescribeDomainLogsWithOptions(DescribeDomainLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyWord))
            {
                query["KeyWord"] = request.KeyWord;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["endDate"] = request.EndDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomainLogs",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainLogsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the operation logs of domain names based on the specified parameters.
         *
         * @param request DescribeDomainLogsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDomainLogsResponse
         */
        public async Task<DescribeDomainLogsResponse> DescribeDomainLogsWithOptionsAsync(DescribeDomainLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyWord))
            {
                query["KeyWord"] = request.KeyWord;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["endDate"] = request.EndDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomainLogs",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainLogsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the operation logs of domain names based on the specified parameters.
         *
         * @param request DescribeDomainLogsRequest
         * @return DescribeDomainLogsResponse
         */
        public DescribeDomainLogsResponse DescribeDomainLogs(DescribeDomainLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainLogsWithOptions(request, runtime);
        }

        /**
         * @summary Queries the operation logs of domain names based on the specified parameters.
         *
         * @param request DescribeDomainLogsRequest
         * @return DescribeDomainLogsResponse
         */
        public async Task<DescribeDomainLogsResponse> DescribeDomainLogsAsync(DescribeDomainLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainLogsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the name servers configured for a specified domain name and checks whether all the name servers are Alibaba Cloud Domain Name System (DNS) servers.
         *
         * @description >  You can call this operation to query the authoritative servers of a domain name registry to obtain the name servers for a domain name. If the domain name is in an invalid state, such as serverHold or clientHold, an error may be returned.
         *
         * @param request DescribeDomainNsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDomainNsResponse
         */
        public DescribeDomainNsResponse DescribeDomainNsWithOptions(DescribeDomainNsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomainNs",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainNsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the name servers configured for a specified domain name and checks whether all the name servers are Alibaba Cloud Domain Name System (DNS) servers.
         *
         * @description >  You can call this operation to query the authoritative servers of a domain name registry to obtain the name servers for a domain name. If the domain name is in an invalid state, such as serverHold or clientHold, an error may be returned.
         *
         * @param request DescribeDomainNsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDomainNsResponse
         */
        public async Task<DescribeDomainNsResponse> DescribeDomainNsWithOptionsAsync(DescribeDomainNsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomainNs",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainNsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the name servers configured for a specified domain name and checks whether all the name servers are Alibaba Cloud Domain Name System (DNS) servers.
         *
         * @description >  You can call this operation to query the authoritative servers of a domain name registry to obtain the name servers for a domain name. If the domain name is in an invalid state, such as serverHold or clientHold, an error may be returned.
         *
         * @param request DescribeDomainNsRequest
         * @return DescribeDomainNsResponse
         */
        public DescribeDomainNsResponse DescribeDomainNs(DescribeDomainNsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainNsWithOptions(request, runtime);
        }

        /**
         * @summary Queries the name servers configured for a specified domain name and checks whether all the name servers are Alibaba Cloud Domain Name System (DNS) servers.
         *
         * @description >  You can call this operation to query the authoritative servers of a domain name registry to obtain the name servers for a domain name. If the domain name is in an invalid state, such as serverHold or clientHold, an error may be returned.
         *
         * @param request DescribeDomainNsRequest
         * @return DescribeDomainNsResponse
         */
        public async Task<DescribeDomainNsResponse> DescribeDomainNsAsync(DescribeDomainNsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainNsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the information about a Domain Name System (DNS) record.
         *
         * @description ## Debugging
         * [OpenAPI Explorer automatically calculates the signature value. For your convenience, we recommend that you call this operation in OpenAPI Explorer. OpenAPI Explorer dynamically generates the sample code of the operation for different SDKs.](https://api.aliyun.com/#product=Alidns\\&api=DescribeDomainRecordInfo\\&type=RPC\\&version=2015-01-09)
         *
         * @param request DescribeDomainRecordInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDomainRecordInfoResponse
         */
        public DescribeDomainRecordInfoResponse DescribeDomainRecordInfoWithOptions(DescribeDomainRecordInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordId))
            {
                query["RecordId"] = request.RecordId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomainRecordInfo",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainRecordInfoResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the information about a Domain Name System (DNS) record.
         *
         * @description ## Debugging
         * [OpenAPI Explorer automatically calculates the signature value. For your convenience, we recommend that you call this operation in OpenAPI Explorer. OpenAPI Explorer dynamically generates the sample code of the operation for different SDKs.](https://api.aliyun.com/#product=Alidns\\&api=DescribeDomainRecordInfo\\&type=RPC\\&version=2015-01-09)
         *
         * @param request DescribeDomainRecordInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDomainRecordInfoResponse
         */
        public async Task<DescribeDomainRecordInfoResponse> DescribeDomainRecordInfoWithOptionsAsync(DescribeDomainRecordInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordId))
            {
                query["RecordId"] = request.RecordId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomainRecordInfo",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainRecordInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the information about a Domain Name System (DNS) record.
         *
         * @description ## Debugging
         * [OpenAPI Explorer automatically calculates the signature value. For your convenience, we recommend that you call this operation in OpenAPI Explorer. OpenAPI Explorer dynamically generates the sample code of the operation for different SDKs.](https://api.aliyun.com/#product=Alidns\\&api=DescribeDomainRecordInfo\\&type=RPC\\&version=2015-01-09)
         *
         * @param request DescribeDomainRecordInfoRequest
         * @return DescribeDomainRecordInfoResponse
         */
        public DescribeDomainRecordInfoResponse DescribeDomainRecordInfo(DescribeDomainRecordInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainRecordInfoWithOptions(request, runtime);
        }

        /**
         * @summary Queries the information about a Domain Name System (DNS) record.
         *
         * @description ## Debugging
         * [OpenAPI Explorer automatically calculates the signature value. For your convenience, we recommend that you call this operation in OpenAPI Explorer. OpenAPI Explorer dynamically generates the sample code of the operation for different SDKs.](https://api.aliyun.com/#product=Alidns\\&api=DescribeDomainRecordInfo\\&type=RPC\\&version=2015-01-09)
         *
         * @param request DescribeDomainRecordInfoRequest
         * @return DescribeDomainRecordInfoResponse
         */
        public async Task<DescribeDomainRecordInfoResponse> DescribeDomainRecordInfoAsync(DescribeDomainRecordInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainRecordInfoWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries all Domain Name System (DNS) records of the specified primary domain names based on the specified parameters.
         *
         * @description *   You can specify DomainName, PageNumber, and PageSize to query the DNS records of the specified domain names.
         * *   You can also specify RRKeyWord, TypeKeyWord, or ValueKeyWord to query the DNS records that contain the specified keyword.
         * *   By default, the DNS records are sorted in reverse chronological order based on the time when they were added.
         * *   You can specify GroupId to query the DNS records of the specified domain names based on the group ID. You can query the DNS records of all domain names and the domain names in the default group.
         *
         * @param request DescribeDomainRecordsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDomainRecordsResponse
         */
        public DescribeDomainRecordsResponse DescribeDomainRecordsWithOptions(DescribeDomainRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyWord))
            {
                query["KeyWord"] = request.KeyWord;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Line))
            {
                query["Line"] = request.Line;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RRKeyWord))
            {
                query["RRKeyWord"] = request.RRKeyWord;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchMode))
            {
                query["SearchMode"] = request.SearchMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TypeKeyWord))
            {
                query["TypeKeyWord"] = request.TypeKeyWord;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValueKeyWord))
            {
                query["ValueKeyWord"] = request.ValueKeyWord;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomainRecords",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainRecordsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries all Domain Name System (DNS) records of the specified primary domain names based on the specified parameters.
         *
         * @description *   You can specify DomainName, PageNumber, and PageSize to query the DNS records of the specified domain names.
         * *   You can also specify RRKeyWord, TypeKeyWord, or ValueKeyWord to query the DNS records that contain the specified keyword.
         * *   By default, the DNS records are sorted in reverse chronological order based on the time when they were added.
         * *   You can specify GroupId to query the DNS records of the specified domain names based on the group ID. You can query the DNS records of all domain names and the domain names in the default group.
         *
         * @param request DescribeDomainRecordsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDomainRecordsResponse
         */
        public async Task<DescribeDomainRecordsResponse> DescribeDomainRecordsWithOptionsAsync(DescribeDomainRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyWord))
            {
                query["KeyWord"] = request.KeyWord;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Line))
            {
                query["Line"] = request.Line;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RRKeyWord))
            {
                query["RRKeyWord"] = request.RRKeyWord;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchMode))
            {
                query["SearchMode"] = request.SearchMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TypeKeyWord))
            {
                query["TypeKeyWord"] = request.TypeKeyWord;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValueKeyWord))
            {
                query["ValueKeyWord"] = request.ValueKeyWord;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomainRecords",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainRecordsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries all Domain Name System (DNS) records of the specified primary domain names based on the specified parameters.
         *
         * @description *   You can specify DomainName, PageNumber, and PageSize to query the DNS records of the specified domain names.
         * *   You can also specify RRKeyWord, TypeKeyWord, or ValueKeyWord to query the DNS records that contain the specified keyword.
         * *   By default, the DNS records are sorted in reverse chronological order based on the time when they were added.
         * *   You can specify GroupId to query the DNS records of the specified domain names based on the group ID. You can query the DNS records of all domain names and the domain names in the default group.
         *
         * @param request DescribeDomainRecordsRequest
         * @return DescribeDomainRecordsResponse
         */
        public DescribeDomainRecordsResponse DescribeDomainRecords(DescribeDomainRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainRecordsWithOptions(request, runtime);
        }

        /**
         * @summary Queries all Domain Name System (DNS) records of the specified primary domain names based on the specified parameters.
         *
         * @description *   You can specify DomainName, PageNumber, and PageSize to query the DNS records of the specified domain names.
         * *   You can also specify RRKeyWord, TypeKeyWord, or ValueKeyWord to query the DNS records that contain the specified keyword.
         * *   By default, the DNS records are sorted in reverse chronological order based on the time when they were added.
         * *   You can specify GroupId to query the DNS records of the specified domain names based on the group ID. You can query the DNS records of all domain names and the domain names in the default group.
         *
         * @param request DescribeDomainRecordsRequest
         * @return DescribeDomainRecordsResponse
         */
        public async Task<DescribeDomainRecordsResponse> DescribeDomainRecordsAsync(DescribeDomainRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainRecordsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the resolution requests of all paid domain names within your account.
         *
         * @param request DescribeDomainResolveStatisticsSummaryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDomainResolveStatisticsSummaryResponse
         */
        public DescribeDomainResolveStatisticsSummaryResponse DescribeDomainResolveStatisticsSummaryWithOptions(DescribeDomainResolveStatisticsSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchMode))
            {
                query["SearchMode"] = request.SearchMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Threshold))
            {
                query["Threshold"] = request.Threshold;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomainResolveStatisticsSummary",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainResolveStatisticsSummaryResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the resolution requests of all paid domain names within your account.
         *
         * @param request DescribeDomainResolveStatisticsSummaryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDomainResolveStatisticsSummaryResponse
         */
        public async Task<DescribeDomainResolveStatisticsSummaryResponse> DescribeDomainResolveStatisticsSummaryWithOptionsAsync(DescribeDomainResolveStatisticsSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchMode))
            {
                query["SearchMode"] = request.SearchMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Threshold))
            {
                query["Threshold"] = request.Threshold;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomainResolveStatisticsSummary",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainResolveStatisticsSummaryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the resolution requests of all paid domain names within your account.
         *
         * @param request DescribeDomainResolveStatisticsSummaryRequest
         * @return DescribeDomainResolveStatisticsSummaryResponse
         */
        public DescribeDomainResolveStatisticsSummaryResponse DescribeDomainResolveStatisticsSummary(DescribeDomainResolveStatisticsSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainResolveStatisticsSummaryWithOptions(request, runtime);
        }

        /**
         * @summary Queries the resolution requests of all paid domain names within your account.
         *
         * @param request DescribeDomainResolveStatisticsSummaryRequest
         * @return DescribeDomainResolveStatisticsSummaryResponse
         */
        public async Task<DescribeDomainResolveStatisticsSummaryResponse> DescribeDomainResolveStatisticsSummaryAsync(DescribeDomainResolveStatisticsSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainResolveStatisticsSummaryWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the real-time statistics on the Domain Name System (DNS) requests for a primary domain name.
         *
         * @description Real-time data is collected per hour.
         *
         * @param request DescribeDomainStatisticsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDomainStatisticsResponse
         */
        public DescribeDomainStatisticsResponse DescribeDomainStatisticsWithOptions(DescribeDomainStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainType))
            {
                query["DomainType"] = request.DomainType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
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
                Action = "DescribeDomainStatistics",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainStatisticsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the real-time statistics on the Domain Name System (DNS) requests for a primary domain name.
         *
         * @description Real-time data is collected per hour.
         *
         * @param request DescribeDomainStatisticsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDomainStatisticsResponse
         */
        public async Task<DescribeDomainStatisticsResponse> DescribeDomainStatisticsWithOptionsAsync(DescribeDomainStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainType))
            {
                query["DomainType"] = request.DomainType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
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
                Action = "DescribeDomainStatistics",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainStatisticsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the real-time statistics on the Domain Name System (DNS) requests for a primary domain name.
         *
         * @description Real-time data is collected per hour.
         *
         * @param request DescribeDomainStatisticsRequest
         * @return DescribeDomainStatisticsResponse
         */
        public DescribeDomainStatisticsResponse DescribeDomainStatistics(DescribeDomainStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainStatisticsWithOptions(request, runtime);
        }

        /**
         * @summary Queries the real-time statistics on the Domain Name System (DNS) requests for a primary domain name.
         *
         * @description Real-time data is collected per hour.
         *
         * @param request DescribeDomainStatisticsRequest
         * @return DescribeDomainStatisticsResponse
         */
        public async Task<DescribeDomainStatisticsResponse> DescribeDomainStatisticsAsync(DescribeDomainStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainStatisticsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Calls the DescribeDomainStatisticsSummary operation to obtain the query volume of all paid domain names under your account.
         *
         * @param request DescribeDomainStatisticsSummaryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDomainStatisticsSummaryResponse
         */
        public DescribeDomainStatisticsSummaryResponse DescribeDomainStatisticsSummaryWithOptions(DescribeDomainStatisticsSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchMode))
            {
                query["SearchMode"] = request.SearchMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Threshold))
            {
                query["Threshold"] = request.Threshold;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomainStatisticsSummary",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainStatisticsSummaryResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Calls the DescribeDomainStatisticsSummary operation to obtain the query volume of all paid domain names under your account.
         *
         * @param request DescribeDomainStatisticsSummaryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDomainStatisticsSummaryResponse
         */
        public async Task<DescribeDomainStatisticsSummaryResponse> DescribeDomainStatisticsSummaryWithOptionsAsync(DescribeDomainStatisticsSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchMode))
            {
                query["SearchMode"] = request.SearchMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Threshold))
            {
                query["Threshold"] = request.Threshold;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomainStatisticsSummary",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainStatisticsSummaryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Calls the DescribeDomainStatisticsSummary operation to obtain the query volume of all paid domain names under your account.
         *
         * @param request DescribeDomainStatisticsSummaryRequest
         * @return DescribeDomainStatisticsSummaryResponse
         */
        public DescribeDomainStatisticsSummaryResponse DescribeDomainStatisticsSummary(DescribeDomainStatisticsSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainStatisticsSummaryWithOptions(request, runtime);
        }

        /**
         * @summary Calls the DescribeDomainStatisticsSummary operation to obtain the query volume of all paid domain names under your account.
         *
         * @param request DescribeDomainStatisticsSummaryRequest
         * @return DescribeDomainStatisticsSummaryResponse
         */
        public async Task<DescribeDomainStatisticsSummaryResponse> DescribeDomainStatisticsSummaryAsync(DescribeDomainStatisticsSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainStatisticsSummaryWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Calls the DescribeDomains operation to query domain names of a user based on input parameters.
         *
         * @description *   You can specify the PageNumber and PageSize parameters to query domain names.
         * *   You can specify the KeyWord parameter to query domain names that contain the specified keyword.
         * *   By default, the domain names in a list are sorted in descending order of the time they were added.
         * *   You can specify the GroupId parameter. If you do not specify this parameter, all domain names are queried by default.
         *
         * @param request DescribeDomainsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDomainsResponse
         */
        public DescribeDomainsResponse DescribeDomainsWithOptions(DescribeDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyWord))
            {
                query["KeyWord"] = request.KeyWord;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchMode))
            {
                query["SearchMode"] = request.SearchMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Starmark))
            {
                query["Starmark"] = request.Starmark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomains",
                Version = "2015-01-09",
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

        /**
         * @summary Calls the DescribeDomains operation to query domain names of a user based on input parameters.
         *
         * @description *   You can specify the PageNumber and PageSize parameters to query domain names.
         * *   You can specify the KeyWord parameter to query domain names that contain the specified keyword.
         * *   By default, the domain names in a list are sorted in descending order of the time they were added.
         * *   You can specify the GroupId parameter. If you do not specify this parameter, all domain names are queried by default.
         *
         * @param request DescribeDomainsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDomainsResponse
         */
        public async Task<DescribeDomainsResponse> DescribeDomainsWithOptionsAsync(DescribeDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyWord))
            {
                query["KeyWord"] = request.KeyWord;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchMode))
            {
                query["SearchMode"] = request.SearchMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Starmark))
            {
                query["Starmark"] = request.Starmark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomains",
                Version = "2015-01-09",
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

        /**
         * @summary Calls the DescribeDomains operation to query domain names of a user based on input parameters.
         *
         * @description *   You can specify the PageNumber and PageSize parameters to query domain names.
         * *   You can specify the KeyWord parameter to query domain names that contain the specified keyword.
         * *   By default, the domain names in a list are sorted in descending order of the time they were added.
         * *   You can specify the GroupId parameter. If you do not specify this parameter, all domain names are queried by default.
         *
         * @param request DescribeDomainsRequest
         * @return DescribeDomainsResponse
         */
        public DescribeDomainsResponse DescribeDomains(DescribeDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainsWithOptions(request, runtime);
        }

        /**
         * @summary Calls the DescribeDomains operation to query domain names of a user based on input parameters.
         *
         * @description *   You can specify the PageNumber and PageSize parameters to query domain names.
         * *   You can specify the KeyWord parameter to query domain names that contain the specified keyword.
         * *   By default, the domain names in a list are sorted in descending order of the time they were added.
         * *   You can specify the GroupId parameter. If you do not specify this parameter, all domain names are queried by default.
         *
         * @param request DescribeDomainsRequest
         * @return DescribeDomainsResponse
         */
        public async Task<DescribeDomainsResponse> DescribeDomainsAsync(DescribeDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary You can call this operation to query the access policies of a Global Traffic Manager (GTM) instance.
         *
         * @param request DescribeGtmAccessStrategiesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeGtmAccessStrategiesResponse
         */
        public DescribeGtmAccessStrategiesResponse DescribeGtmAccessStrategiesWithOptions(DescribeGtmAccessStrategiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
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
                Action = "DescribeGtmAccessStrategies",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGtmAccessStrategiesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to query the access policies of a Global Traffic Manager (GTM) instance.
         *
         * @param request DescribeGtmAccessStrategiesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeGtmAccessStrategiesResponse
         */
        public async Task<DescribeGtmAccessStrategiesResponse> DescribeGtmAccessStrategiesWithOptionsAsync(DescribeGtmAccessStrategiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
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
                Action = "DescribeGtmAccessStrategies",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGtmAccessStrategiesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to query the access policies of a Global Traffic Manager (GTM) instance.
         *
         * @param request DescribeGtmAccessStrategiesRequest
         * @return DescribeGtmAccessStrategiesResponse
         */
        public DescribeGtmAccessStrategiesResponse DescribeGtmAccessStrategies(DescribeGtmAccessStrategiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGtmAccessStrategiesWithOptions(request, runtime);
        }

        /**
         * @summary You can call this operation to query the access policies of a Global Traffic Manager (GTM) instance.
         *
         * @param request DescribeGtmAccessStrategiesRequest
         * @return DescribeGtmAccessStrategiesResponse
         */
        public async Task<DescribeGtmAccessStrategiesResponse> DescribeGtmAccessStrategiesAsync(DescribeGtmAccessStrategiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGtmAccessStrategiesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary You can call this operation to query the details about an access policy of a Global Traffic Manager (GTM) instance based on the policy ID.
         *
         * @param request DescribeGtmAccessStrategyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeGtmAccessStrategyResponse
         */
        public DescribeGtmAccessStrategyResponse DescribeGtmAccessStrategyWithOptions(DescribeGtmAccessStrategyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyId))
            {
                query["StrategyId"] = request.StrategyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGtmAccessStrategy",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGtmAccessStrategyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to query the details about an access policy of a Global Traffic Manager (GTM) instance based on the policy ID.
         *
         * @param request DescribeGtmAccessStrategyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeGtmAccessStrategyResponse
         */
        public async Task<DescribeGtmAccessStrategyResponse> DescribeGtmAccessStrategyWithOptionsAsync(DescribeGtmAccessStrategyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyId))
            {
                query["StrategyId"] = request.StrategyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGtmAccessStrategy",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGtmAccessStrategyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to query the details about an access policy of a Global Traffic Manager (GTM) instance based on the policy ID.
         *
         * @param request DescribeGtmAccessStrategyRequest
         * @return DescribeGtmAccessStrategyResponse
         */
        public DescribeGtmAccessStrategyResponse DescribeGtmAccessStrategy(DescribeGtmAccessStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGtmAccessStrategyWithOptions(request, runtime);
        }

        /**
         * @summary You can call this operation to query the details about an access policy of a Global Traffic Manager (GTM) instance based on the policy ID.
         *
         * @param request DescribeGtmAccessStrategyRequest
         * @return DescribeGtmAccessStrategyResponse
         */
        public async Task<DescribeGtmAccessStrategyResponse> DescribeGtmAccessStrategyAsync(DescribeGtmAccessStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGtmAccessStrategyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the configuration items that can be set for an access policy.
         *
         * @param request DescribeGtmAccessStrategyAvailableConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeGtmAccessStrategyAvailableConfigResponse
         */
        public DescribeGtmAccessStrategyAvailableConfigResponse DescribeGtmAccessStrategyAvailableConfigWithOptions(DescribeGtmAccessStrategyAvailableConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGtmAccessStrategyAvailableConfig",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGtmAccessStrategyAvailableConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the configuration items that can be set for an access policy.
         *
         * @param request DescribeGtmAccessStrategyAvailableConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeGtmAccessStrategyAvailableConfigResponse
         */
        public async Task<DescribeGtmAccessStrategyAvailableConfigResponse> DescribeGtmAccessStrategyAvailableConfigWithOptionsAsync(DescribeGtmAccessStrategyAvailableConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGtmAccessStrategyAvailableConfig",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGtmAccessStrategyAvailableConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the configuration items that can be set for an access policy.
         *
         * @param request DescribeGtmAccessStrategyAvailableConfigRequest
         * @return DescribeGtmAccessStrategyAvailableConfigResponse
         */
        public DescribeGtmAccessStrategyAvailableConfigResponse DescribeGtmAccessStrategyAvailableConfig(DescribeGtmAccessStrategyAvailableConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGtmAccessStrategyAvailableConfigWithOptions(request, runtime);
        }

        /**
         * @summary Queries the configuration items that can be set for an access policy.
         *
         * @param request DescribeGtmAccessStrategyAvailableConfigRequest
         * @return DescribeGtmAccessStrategyAvailableConfigResponse
         */
        public async Task<DescribeGtmAccessStrategyAvailableConfigResponse> DescribeGtmAccessStrategyAvailableConfigAsync(DescribeGtmAccessStrategyAvailableConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGtmAccessStrategyAvailableConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeGtmAvailableAlertGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeGtmAvailableAlertGroupResponse
         */
        public DescribeGtmAvailableAlertGroupResponse DescribeGtmAvailableAlertGroupWithOptions(DescribeGtmAvailableAlertGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGtmAvailableAlertGroup",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGtmAvailableAlertGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeGtmAvailableAlertGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeGtmAvailableAlertGroupResponse
         */
        public async Task<DescribeGtmAvailableAlertGroupResponse> DescribeGtmAvailableAlertGroupWithOptionsAsync(DescribeGtmAvailableAlertGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGtmAvailableAlertGroup",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGtmAvailableAlertGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeGtmAvailableAlertGroupRequest
         * @return DescribeGtmAvailableAlertGroupResponse
         */
        public DescribeGtmAvailableAlertGroupResponse DescribeGtmAvailableAlertGroup(DescribeGtmAvailableAlertGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGtmAvailableAlertGroupWithOptions(request, runtime);
        }

        /**
         * @param request DescribeGtmAvailableAlertGroupRequest
         * @return DescribeGtmAvailableAlertGroupResponse
         */
        public async Task<DescribeGtmAvailableAlertGroupResponse> DescribeGtmAvailableAlertGroupAsync(DescribeGtmAvailableAlertGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGtmAvailableAlertGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the details about a Global Traffic Manager (GTM) instance.
         *
         * @param request DescribeGtmInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeGtmInstanceResponse
         */
        public DescribeGtmInstanceResponse DescribeGtmInstanceWithOptions(DescribeGtmInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedDetailAttributes))
            {
                query["NeedDetailAttributes"] = request.NeedDetailAttributes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGtmInstance",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGtmInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the details about a Global Traffic Manager (GTM) instance.
         *
         * @param request DescribeGtmInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeGtmInstanceResponse
         */
        public async Task<DescribeGtmInstanceResponse> DescribeGtmInstanceWithOptionsAsync(DescribeGtmInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedDetailAttributes))
            {
                query["NeedDetailAttributes"] = request.NeedDetailAttributes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGtmInstance",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGtmInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the details about a Global Traffic Manager (GTM) instance.
         *
         * @param request DescribeGtmInstanceRequest
         * @return DescribeGtmInstanceResponse
         */
        public DescribeGtmInstanceResponse DescribeGtmInstance(DescribeGtmInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGtmInstanceWithOptions(request, runtime);
        }

        /**
         * @summary Queries the details about a Global Traffic Manager (GTM) instance.
         *
         * @param request DescribeGtmInstanceRequest
         * @return DescribeGtmInstanceResponse
         */
        public async Task<DescribeGtmInstanceResponse> DescribeGtmInstanceAsync(DescribeGtmInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGtmInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary You can call this operation to query the details about an address pool of a Global Traffic Manager (GTM) instance.
         *
         * @param request DescribeGtmInstanceAddressPoolRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeGtmInstanceAddressPoolResponse
         */
        public DescribeGtmInstanceAddressPoolResponse DescribeGtmInstanceAddressPoolWithOptions(DescribeGtmInstanceAddressPoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddrPoolId))
            {
                query["AddrPoolId"] = request.AddrPoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGtmInstanceAddressPool",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGtmInstanceAddressPoolResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to query the details about an address pool of a Global Traffic Manager (GTM) instance.
         *
         * @param request DescribeGtmInstanceAddressPoolRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeGtmInstanceAddressPoolResponse
         */
        public async Task<DescribeGtmInstanceAddressPoolResponse> DescribeGtmInstanceAddressPoolWithOptionsAsync(DescribeGtmInstanceAddressPoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddrPoolId))
            {
                query["AddrPoolId"] = request.AddrPoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGtmInstanceAddressPool",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGtmInstanceAddressPoolResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to query the details about an address pool of a Global Traffic Manager (GTM) instance.
         *
         * @param request DescribeGtmInstanceAddressPoolRequest
         * @return DescribeGtmInstanceAddressPoolResponse
         */
        public DescribeGtmInstanceAddressPoolResponse DescribeGtmInstanceAddressPool(DescribeGtmInstanceAddressPoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGtmInstanceAddressPoolWithOptions(request, runtime);
        }

        /**
         * @summary You can call this operation to query the details about an address pool of a Global Traffic Manager (GTM) instance.
         *
         * @param request DescribeGtmInstanceAddressPoolRequest
         * @return DescribeGtmInstanceAddressPoolResponse
         */
        public async Task<DescribeGtmInstanceAddressPoolResponse> DescribeGtmInstanceAddressPoolAsync(DescribeGtmInstanceAddressPoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGtmInstanceAddressPoolWithOptionsAsync(request, runtime);
        }

        /**
         * @summary You can call this operation to query the address pools of a Global Traffic Manager (GTM) instance.
         *
         * @param request DescribeGtmInstanceAddressPoolsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeGtmInstanceAddressPoolsResponse
         */
        public DescribeGtmInstanceAddressPoolsResponse DescribeGtmInstanceAddressPoolsWithOptions(DescribeGtmInstanceAddressPoolsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
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
                Action = "DescribeGtmInstanceAddressPools",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGtmInstanceAddressPoolsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to query the address pools of a Global Traffic Manager (GTM) instance.
         *
         * @param request DescribeGtmInstanceAddressPoolsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeGtmInstanceAddressPoolsResponse
         */
        public async Task<DescribeGtmInstanceAddressPoolsResponse> DescribeGtmInstanceAddressPoolsWithOptionsAsync(DescribeGtmInstanceAddressPoolsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
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
                Action = "DescribeGtmInstanceAddressPools",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGtmInstanceAddressPoolsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to query the address pools of a Global Traffic Manager (GTM) instance.
         *
         * @param request DescribeGtmInstanceAddressPoolsRequest
         * @return DescribeGtmInstanceAddressPoolsResponse
         */
        public DescribeGtmInstanceAddressPoolsResponse DescribeGtmInstanceAddressPools(DescribeGtmInstanceAddressPoolsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGtmInstanceAddressPoolsWithOptions(request, runtime);
        }

        /**
         * @summary You can call this operation to query the address pools of a Global Traffic Manager (GTM) instance.
         *
         * @param request DescribeGtmInstanceAddressPoolsRequest
         * @return DescribeGtmInstanceAddressPoolsResponse
         */
        public async Task<DescribeGtmInstanceAddressPoolsResponse> DescribeGtmInstanceAddressPoolsAsync(DescribeGtmInstanceAddressPoolsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGtmInstanceAddressPoolsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the current status of a Global Traffic Manager (GTM) instance.
         *
         * @param request DescribeGtmInstanceStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeGtmInstanceStatusResponse
         */
        public DescribeGtmInstanceStatusResponse DescribeGtmInstanceStatusWithOptions(DescribeGtmInstanceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGtmInstanceStatus",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGtmInstanceStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the current status of a Global Traffic Manager (GTM) instance.
         *
         * @param request DescribeGtmInstanceStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeGtmInstanceStatusResponse
         */
        public async Task<DescribeGtmInstanceStatusResponse> DescribeGtmInstanceStatusWithOptionsAsync(DescribeGtmInstanceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGtmInstanceStatus",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGtmInstanceStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the current status of a Global Traffic Manager (GTM) instance.
         *
         * @param request DescribeGtmInstanceStatusRequest
         * @return DescribeGtmInstanceStatusResponse
         */
        public DescribeGtmInstanceStatusResponse DescribeGtmInstanceStatus(DescribeGtmInstanceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGtmInstanceStatusWithOptions(request, runtime);
        }

        /**
         * @summary Queries the current status of a Global Traffic Manager (GTM) instance.
         *
         * @param request DescribeGtmInstanceStatusRequest
         * @return DescribeGtmInstanceStatusResponse
         */
        public async Task<DescribeGtmInstanceStatusResponse> DescribeGtmInstanceStatusAsync(DescribeGtmInstanceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGtmInstanceStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeGtmInstanceSystemCnameRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeGtmInstanceSystemCnameResponse
         */
        public DescribeGtmInstanceSystemCnameResponse DescribeGtmInstanceSystemCnameWithOptions(DescribeGtmInstanceSystemCnameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGtmInstanceSystemCname",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGtmInstanceSystemCnameResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeGtmInstanceSystemCnameRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeGtmInstanceSystemCnameResponse
         */
        public async Task<DescribeGtmInstanceSystemCnameResponse> DescribeGtmInstanceSystemCnameWithOptionsAsync(DescribeGtmInstanceSystemCnameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGtmInstanceSystemCname",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGtmInstanceSystemCnameResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeGtmInstanceSystemCnameRequest
         * @return DescribeGtmInstanceSystemCnameResponse
         */
        public DescribeGtmInstanceSystemCnameResponse DescribeGtmInstanceSystemCname(DescribeGtmInstanceSystemCnameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGtmInstanceSystemCnameWithOptions(request, runtime);
        }

        /**
         * @param request DescribeGtmInstanceSystemCnameRequest
         * @return DescribeGtmInstanceSystemCnameResponse
         */
        public async Task<DescribeGtmInstanceSystemCnameResponse> DescribeGtmInstanceSystemCnameAsync(DescribeGtmInstanceSystemCnameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGtmInstanceSystemCnameWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the Global Traffic Manager (GTM) instances under your account.
         *
         * @param request DescribeGtmInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeGtmInstancesResponse
         */
        public DescribeGtmInstancesResponse DescribeGtmInstancesWithOptions(DescribeGtmInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedDetailAttributes))
            {
                query["NeedDetailAttributes"] = request.NeedDetailAttributes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGtmInstances",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGtmInstancesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the Global Traffic Manager (GTM) instances under your account.
         *
         * @param request DescribeGtmInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeGtmInstancesResponse
         */
        public async Task<DescribeGtmInstancesResponse> DescribeGtmInstancesWithOptionsAsync(DescribeGtmInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedDetailAttributes))
            {
                query["NeedDetailAttributes"] = request.NeedDetailAttributes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGtmInstances",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGtmInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the Global Traffic Manager (GTM) instances under your account.
         *
         * @param request DescribeGtmInstancesRequest
         * @return DescribeGtmInstancesResponse
         */
        public DescribeGtmInstancesResponse DescribeGtmInstances(DescribeGtmInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGtmInstancesWithOptions(request, runtime);
        }

        /**
         * @summary Queries the Global Traffic Manager (GTM) instances under your account.
         *
         * @param request DescribeGtmInstancesRequest
         * @return DescribeGtmInstancesResponse
         */
        public async Task<DescribeGtmInstancesResponse> DescribeGtmInstancesAsync(DescribeGtmInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGtmInstancesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary You can call this operation to query logs of a Global Traffic Manager (GTM) instance.
         *
         * @param request DescribeGtmLogsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeGtmLogsResponse
         */
        public DescribeGtmLogsResponse DescribeGtmLogsWithOptions(DescribeGtmLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTimestamp))
            {
                query["EndTimestamp"] = request.EndTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTimestamp))
            {
                query["StartTimestamp"] = request.StartTimestamp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGtmLogs",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGtmLogsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to query logs of a Global Traffic Manager (GTM) instance.
         *
         * @param request DescribeGtmLogsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeGtmLogsResponse
         */
        public async Task<DescribeGtmLogsResponse> DescribeGtmLogsWithOptionsAsync(DescribeGtmLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTimestamp))
            {
                query["EndTimestamp"] = request.EndTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTimestamp))
            {
                query["StartTimestamp"] = request.StartTimestamp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGtmLogs",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGtmLogsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to query logs of a Global Traffic Manager (GTM) instance.
         *
         * @param request DescribeGtmLogsRequest
         * @return DescribeGtmLogsResponse
         */
        public DescribeGtmLogsResponse DescribeGtmLogs(DescribeGtmLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGtmLogsWithOptions(request, runtime);
        }

        /**
         * @summary You can call this operation to query logs of a Global Traffic Manager (GTM) instance.
         *
         * @param request DescribeGtmLogsRequest
         * @return DescribeGtmLogsResponse
         */
        public async Task<DescribeGtmLogsResponse> DescribeGtmLogsAsync(DescribeGtmLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGtmLogsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries available monitored nodes.
         *
         * @param request DescribeGtmMonitorAvailableConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeGtmMonitorAvailableConfigResponse
         */
        public DescribeGtmMonitorAvailableConfigResponse DescribeGtmMonitorAvailableConfigWithOptions(DescribeGtmMonitorAvailableConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGtmMonitorAvailableConfig",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGtmMonitorAvailableConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries available monitored nodes.
         *
         * @param request DescribeGtmMonitorAvailableConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeGtmMonitorAvailableConfigResponse
         */
        public async Task<DescribeGtmMonitorAvailableConfigResponse> DescribeGtmMonitorAvailableConfigWithOptionsAsync(DescribeGtmMonitorAvailableConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGtmMonitorAvailableConfig",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGtmMonitorAvailableConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries available monitored nodes.
         *
         * @param request DescribeGtmMonitorAvailableConfigRequest
         * @return DescribeGtmMonitorAvailableConfigResponse
         */
        public DescribeGtmMonitorAvailableConfigResponse DescribeGtmMonitorAvailableConfig(DescribeGtmMonitorAvailableConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGtmMonitorAvailableConfigWithOptions(request, runtime);
        }

        /**
         * @summary Queries available monitored nodes.
         *
         * @param request DescribeGtmMonitorAvailableConfigRequest
         * @return DescribeGtmMonitorAvailableConfigResponse
         */
        public async Task<DescribeGtmMonitorAvailableConfigResponse> DescribeGtmMonitorAvailableConfigAsync(DescribeGtmMonitorAvailableConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGtmMonitorAvailableConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the health check configuration of an address pool of a Global Traffic Manager (GTM) instance.
         *
         * @param request DescribeGtmMonitorConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeGtmMonitorConfigResponse
         */
        public DescribeGtmMonitorConfigResponse DescribeGtmMonitorConfigWithOptions(DescribeGtmMonitorConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MonitorConfigId))
            {
                query["MonitorConfigId"] = request.MonitorConfigId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGtmMonitorConfig",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGtmMonitorConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the health check configuration of an address pool of a Global Traffic Manager (GTM) instance.
         *
         * @param request DescribeGtmMonitorConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeGtmMonitorConfigResponse
         */
        public async Task<DescribeGtmMonitorConfigResponse> DescribeGtmMonitorConfigWithOptionsAsync(DescribeGtmMonitorConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MonitorConfigId))
            {
                query["MonitorConfigId"] = request.MonitorConfigId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGtmMonitorConfig",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGtmMonitorConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the health check configuration of an address pool of a Global Traffic Manager (GTM) instance.
         *
         * @param request DescribeGtmMonitorConfigRequest
         * @return DescribeGtmMonitorConfigResponse
         */
        public DescribeGtmMonitorConfigResponse DescribeGtmMonitorConfig(DescribeGtmMonitorConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGtmMonitorConfigWithOptions(request, runtime);
        }

        /**
         * @summary Queries the health check configuration of an address pool of a Global Traffic Manager (GTM) instance.
         *
         * @param request DescribeGtmMonitorConfigRequest
         * @return DescribeGtmMonitorConfigResponse
         */
        public async Task<DescribeGtmMonitorConfigResponse> DescribeGtmMonitorConfigAsync(DescribeGtmMonitorConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGtmMonitorConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @summary You can call this operation to query the detailed information of a disaster recovery plan for a Global Traffic Manager (GTM) instance.
         *
         * @param request DescribeGtmRecoveryPlanRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeGtmRecoveryPlanResponse
         */
        public DescribeGtmRecoveryPlanResponse DescribeGtmRecoveryPlanWithOptions(DescribeGtmRecoveryPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryPlanId))
            {
                query["RecoveryPlanId"] = request.RecoveryPlanId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGtmRecoveryPlan",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGtmRecoveryPlanResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to query the detailed information of a disaster recovery plan for a Global Traffic Manager (GTM) instance.
         *
         * @param request DescribeGtmRecoveryPlanRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeGtmRecoveryPlanResponse
         */
        public async Task<DescribeGtmRecoveryPlanResponse> DescribeGtmRecoveryPlanWithOptionsAsync(DescribeGtmRecoveryPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryPlanId))
            {
                query["RecoveryPlanId"] = request.RecoveryPlanId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGtmRecoveryPlan",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGtmRecoveryPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to query the detailed information of a disaster recovery plan for a Global Traffic Manager (GTM) instance.
         *
         * @param request DescribeGtmRecoveryPlanRequest
         * @return DescribeGtmRecoveryPlanResponse
         */
        public DescribeGtmRecoveryPlanResponse DescribeGtmRecoveryPlan(DescribeGtmRecoveryPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGtmRecoveryPlanWithOptions(request, runtime);
        }

        /**
         * @summary You can call this operation to query the detailed information of a disaster recovery plan for a Global Traffic Manager (GTM) instance.
         *
         * @param request DescribeGtmRecoveryPlanRequest
         * @return DescribeGtmRecoveryPlanResponse
         */
        public async Task<DescribeGtmRecoveryPlanResponse> DescribeGtmRecoveryPlanAsync(DescribeGtmRecoveryPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGtmRecoveryPlanWithOptionsAsync(request, runtime);
        }

        /**
         * @summary You can call this operation to query the available configurations of a disaster recovery plan of a Global Traffic Manager (GTM) instance.
         *
         * @param request DescribeGtmRecoveryPlanAvailableConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeGtmRecoveryPlanAvailableConfigResponse
         */
        public DescribeGtmRecoveryPlanAvailableConfigResponse DescribeGtmRecoveryPlanAvailableConfigWithOptions(DescribeGtmRecoveryPlanAvailableConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGtmRecoveryPlanAvailableConfig",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGtmRecoveryPlanAvailableConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to query the available configurations of a disaster recovery plan of a Global Traffic Manager (GTM) instance.
         *
         * @param request DescribeGtmRecoveryPlanAvailableConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeGtmRecoveryPlanAvailableConfigResponse
         */
        public async Task<DescribeGtmRecoveryPlanAvailableConfigResponse> DescribeGtmRecoveryPlanAvailableConfigWithOptionsAsync(DescribeGtmRecoveryPlanAvailableConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGtmRecoveryPlanAvailableConfig",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGtmRecoveryPlanAvailableConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to query the available configurations of a disaster recovery plan of a Global Traffic Manager (GTM) instance.
         *
         * @param request DescribeGtmRecoveryPlanAvailableConfigRequest
         * @return DescribeGtmRecoveryPlanAvailableConfigResponse
         */
        public DescribeGtmRecoveryPlanAvailableConfigResponse DescribeGtmRecoveryPlanAvailableConfig(DescribeGtmRecoveryPlanAvailableConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGtmRecoveryPlanAvailableConfigWithOptions(request, runtime);
        }

        /**
         * @summary You can call this operation to query the available configurations of a disaster recovery plan of a Global Traffic Manager (GTM) instance.
         *
         * @param request DescribeGtmRecoveryPlanAvailableConfigRequest
         * @return DescribeGtmRecoveryPlanAvailableConfigResponse
         */
        public async Task<DescribeGtmRecoveryPlanAvailableConfigResponse> DescribeGtmRecoveryPlanAvailableConfigAsync(DescribeGtmRecoveryPlanAvailableConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGtmRecoveryPlanAvailableConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the disaster recovery plans for a Global Traffic Manager (GTM) instance.
         *
         * @param request DescribeGtmRecoveryPlansRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeGtmRecoveryPlansResponse
         */
        public DescribeGtmRecoveryPlansResponse DescribeGtmRecoveryPlansWithOptions(DescribeGtmRecoveryPlansRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
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
                Action = "DescribeGtmRecoveryPlans",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGtmRecoveryPlansResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the disaster recovery plans for a Global Traffic Manager (GTM) instance.
         *
         * @param request DescribeGtmRecoveryPlansRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeGtmRecoveryPlansResponse
         */
        public async Task<DescribeGtmRecoveryPlansResponse> DescribeGtmRecoveryPlansWithOptionsAsync(DescribeGtmRecoveryPlansRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
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
                Action = "DescribeGtmRecoveryPlans",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGtmRecoveryPlansResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the disaster recovery plans for a Global Traffic Manager (GTM) instance.
         *
         * @param request DescribeGtmRecoveryPlansRequest
         * @return DescribeGtmRecoveryPlansResponse
         */
        public DescribeGtmRecoveryPlansResponse DescribeGtmRecoveryPlans(DescribeGtmRecoveryPlansRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGtmRecoveryPlansWithOptions(request, runtime);
        }

        /**
         * @summary Queries the disaster recovery plans for a Global Traffic Manager (GTM) instance.
         *
         * @param request DescribeGtmRecoveryPlansRequest
         * @return DescribeGtmRecoveryPlansResponse
         */
        public async Task<DescribeGtmRecoveryPlansResponse> DescribeGtmRecoveryPlansAsync(DescribeGtmRecoveryPlansRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGtmRecoveryPlansWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the domain names that are bound to an Alibaba Cloud DNS instance.
         *
         * @param request DescribeInstanceDomainsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeInstanceDomainsResponse
         */
        public DescribeInstanceDomainsResponse DescribeInstanceDomainsWithOptions(DescribeInstanceDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
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
                Action = "DescribeInstanceDomains",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceDomainsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the domain names that are bound to an Alibaba Cloud DNS instance.
         *
         * @param request DescribeInstanceDomainsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeInstanceDomainsResponse
         */
        public async Task<DescribeInstanceDomainsResponse> DescribeInstanceDomainsWithOptionsAsync(DescribeInstanceDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
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
                Action = "DescribeInstanceDomains",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceDomainsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the domain names that are bound to an Alibaba Cloud DNS instance.
         *
         * @param request DescribeInstanceDomainsRequest
         * @return DescribeInstanceDomainsResponse
         */
        public DescribeInstanceDomainsResponse DescribeInstanceDomains(DescribeInstanceDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceDomainsWithOptions(request, runtime);
        }

        /**
         * @summary Queries the domain names that are bound to an Alibaba Cloud DNS instance.
         *
         * @param request DescribeInstanceDomainsRequest
         * @return DescribeInstanceDomainsResponse
         */
        public async Task<DescribeInstanceDomainsResponse> DescribeInstanceDomainsAsync(DescribeInstanceDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceDomainsWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeInternetDnsLogsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeInternetDnsLogsResponse
         */
        public DescribeInternetDnsLogsResponse DescribeInternetDnsLogsWithOptions(DescribeInternetDnsLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTimestamp))
            {
                query["EndTimestamp"] = request.EndTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Module))
            {
                query["Module"] = request.Module;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryCondition))
            {
                query["QueryCondition"] = request.QueryCondition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTimestamp))
            {
                query["StartTimestamp"] = request.StartTimestamp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInternetDnsLogs",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInternetDnsLogsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeInternetDnsLogsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeInternetDnsLogsResponse
         */
        public async Task<DescribeInternetDnsLogsResponse> DescribeInternetDnsLogsWithOptionsAsync(DescribeInternetDnsLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTimestamp))
            {
                query["EndTimestamp"] = request.EndTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Module))
            {
                query["Module"] = request.Module;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryCondition))
            {
                query["QueryCondition"] = request.QueryCondition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTimestamp))
            {
                query["StartTimestamp"] = request.StartTimestamp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInternetDnsLogs",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInternetDnsLogsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeInternetDnsLogsRequest
         * @return DescribeInternetDnsLogsResponse
         */
        public DescribeInternetDnsLogsResponse DescribeInternetDnsLogs(DescribeInternetDnsLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInternetDnsLogsWithOptions(request, runtime);
        }

        /**
         * @param request DescribeInternetDnsLogsRequest
         * @return DescribeInternetDnsLogsResponse
         */
        public async Task<DescribeInternetDnsLogsResponse> DescribeInternetDnsLogsAsync(DescribeInternetDnsLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInternetDnsLogsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取缓存刷新套餐包列表
         *
         * @param request DescribeIspFlushCacheInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeIspFlushCacheInstancesResponse
         */
        public DescribeIspFlushCacheInstancesResponse DescribeIspFlushCacheInstancesWithOptions(DescribeIspFlushCacheInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Isp))
            {
                query["Isp"] = request.Isp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeIspFlushCacheInstances",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeIspFlushCacheInstancesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取缓存刷新套餐包列表
         *
         * @param request DescribeIspFlushCacheInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeIspFlushCacheInstancesResponse
         */
        public async Task<DescribeIspFlushCacheInstancesResponse> DescribeIspFlushCacheInstancesWithOptionsAsync(DescribeIspFlushCacheInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Isp))
            {
                query["Isp"] = request.Isp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeIspFlushCacheInstances",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeIspFlushCacheInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取缓存刷新套餐包列表
         *
         * @param request DescribeIspFlushCacheInstancesRequest
         * @return DescribeIspFlushCacheInstancesResponse
         */
        public DescribeIspFlushCacheInstancesResponse DescribeIspFlushCacheInstances(DescribeIspFlushCacheInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeIspFlushCacheInstancesWithOptions(request, runtime);
        }

        /**
         * @summary 获取缓存刷新套餐包列表
         *
         * @param request DescribeIspFlushCacheInstancesRequest
         * @return DescribeIspFlushCacheInstancesResponse
         */
        public async Task<DescribeIspFlushCacheInstancesResponse> DescribeIspFlushCacheInstancesAsync(DescribeIspFlushCacheInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeIspFlushCacheInstancesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取剩余可缓存刷新次数
         *
         * @param request DescribeIspFlushCacheRemainQuotaRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeIspFlushCacheRemainQuotaResponse
         */
        public DescribeIspFlushCacheRemainQuotaResponse DescribeIspFlushCacheRemainQuotaWithOptions(DescribeIspFlushCacheRemainQuotaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeIspFlushCacheRemainQuota",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeIspFlushCacheRemainQuotaResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取剩余可缓存刷新次数
         *
         * @param request DescribeIspFlushCacheRemainQuotaRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeIspFlushCacheRemainQuotaResponse
         */
        public async Task<DescribeIspFlushCacheRemainQuotaResponse> DescribeIspFlushCacheRemainQuotaWithOptionsAsync(DescribeIspFlushCacheRemainQuotaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeIspFlushCacheRemainQuota",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeIspFlushCacheRemainQuotaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取剩余可缓存刷新次数
         *
         * @param request DescribeIspFlushCacheRemainQuotaRequest
         * @return DescribeIspFlushCacheRemainQuotaResponse
         */
        public DescribeIspFlushCacheRemainQuotaResponse DescribeIspFlushCacheRemainQuota(DescribeIspFlushCacheRemainQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeIspFlushCacheRemainQuotaWithOptions(request, runtime);
        }

        /**
         * @summary 获取剩余可缓存刷新次数
         *
         * @param request DescribeIspFlushCacheRemainQuotaRequest
         * @return DescribeIspFlushCacheRemainQuotaResponse
         */
        public async Task<DescribeIspFlushCacheRemainQuotaResponse> DescribeIspFlushCacheRemainQuotaAsync(DescribeIspFlushCacheRemainQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeIspFlushCacheRemainQuotaWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取缓存刷新任务详情
         *
         * @param request DescribeIspFlushCacheTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeIspFlushCacheTaskResponse
         */
        public DescribeIspFlushCacheTaskResponse DescribeIspFlushCacheTaskWithOptions(DescribeIspFlushCacheTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
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
                Action = "DescribeIspFlushCacheTask",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeIspFlushCacheTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取缓存刷新任务详情
         *
         * @param request DescribeIspFlushCacheTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeIspFlushCacheTaskResponse
         */
        public async Task<DescribeIspFlushCacheTaskResponse> DescribeIspFlushCacheTaskWithOptionsAsync(DescribeIspFlushCacheTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
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
                Action = "DescribeIspFlushCacheTask",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeIspFlushCacheTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取缓存刷新任务详情
         *
         * @param request DescribeIspFlushCacheTaskRequest
         * @return DescribeIspFlushCacheTaskResponse
         */
        public DescribeIspFlushCacheTaskResponse DescribeIspFlushCacheTask(DescribeIspFlushCacheTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeIspFlushCacheTaskWithOptions(request, runtime);
        }

        /**
         * @summary 获取缓存刷新任务详情
         *
         * @param request DescribeIspFlushCacheTaskRequest
         * @return DescribeIspFlushCacheTaskResponse
         */
        public async Task<DescribeIspFlushCacheTaskResponse> DescribeIspFlushCacheTaskAsync(DescribeIspFlushCacheTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeIspFlushCacheTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取缓存刷新任务列表
         *
         * @param request DescribeIspFlushCacheTasksRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeIspFlushCacheTasksResponse
         */
        public DescribeIspFlushCacheTasksResponse DescribeIspFlushCacheTasksWithOptions(DescribeIspFlushCacheTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Isp))
            {
                query["Isp"] = request.Isp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
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
                Action = "DescribeIspFlushCacheTasks",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeIspFlushCacheTasksResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取缓存刷新任务列表
         *
         * @param request DescribeIspFlushCacheTasksRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeIspFlushCacheTasksResponse
         */
        public async Task<DescribeIspFlushCacheTasksResponse> DescribeIspFlushCacheTasksWithOptionsAsync(DescribeIspFlushCacheTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Isp))
            {
                query["Isp"] = request.Isp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
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
                Action = "DescribeIspFlushCacheTasks",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeIspFlushCacheTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取缓存刷新任务列表
         *
         * @param request DescribeIspFlushCacheTasksRequest
         * @return DescribeIspFlushCacheTasksResponse
         */
        public DescribeIspFlushCacheTasksResponse DescribeIspFlushCacheTasks(DescribeIspFlushCacheTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeIspFlushCacheTasksWithOptions(request, runtime);
        }

        /**
         * @summary 获取缓存刷新任务列表
         *
         * @param request DescribeIspFlushCacheTasksRequest
         * @return DescribeIspFlushCacheTasksResponse
         */
        public async Task<DescribeIspFlushCacheTasksResponse> DescribeIspFlushCacheTasksAsync(DescribeIspFlushCacheTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeIspFlushCacheTasksWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取公共DNS用户数据概览
         *
         * @param request DescribePdnsAccountSummaryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePdnsAccountSummaryResponse
         */
        public DescribePdnsAccountSummaryResponse DescribePdnsAccountSummaryWithOptions(DescribePdnsAccountSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
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
                Action = "DescribePdnsAccountSummary",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePdnsAccountSummaryResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取公共DNS用户数据概览
         *
         * @param request DescribePdnsAccountSummaryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePdnsAccountSummaryResponse
         */
        public async Task<DescribePdnsAccountSummaryResponse> DescribePdnsAccountSummaryWithOptionsAsync(DescribePdnsAccountSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
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
                Action = "DescribePdnsAccountSummary",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePdnsAccountSummaryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取公共DNS用户数据概览
         *
         * @param request DescribePdnsAccountSummaryRequest
         * @return DescribePdnsAccountSummaryResponse
         */
        public DescribePdnsAccountSummaryResponse DescribePdnsAccountSummary(DescribePdnsAccountSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePdnsAccountSummaryWithOptions(request, runtime);
        }

        /**
         * @summary 获取公共DNS用户数据概览
         *
         * @param request DescribePdnsAccountSummaryRequest
         * @return DescribePdnsAccountSummaryResponse
         */
        public async Task<DescribePdnsAccountSummaryResponse> DescribePdnsAccountSummaryAsync(DescribePdnsAccountSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePdnsAccountSummaryWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取公共DNS AppKey 详情
         *
         * @param request DescribePdnsAppKeyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePdnsAppKeyResponse
         */
        public DescribePdnsAppKeyResponse DescribePdnsAppKeyWithOptions(DescribePdnsAppKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKeyId))
            {
                query["AppKeyId"] = request.AppKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["AuthCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePdnsAppKey",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePdnsAppKeyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取公共DNS AppKey 详情
         *
         * @param request DescribePdnsAppKeyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePdnsAppKeyResponse
         */
        public async Task<DescribePdnsAppKeyResponse> DescribePdnsAppKeyWithOptionsAsync(DescribePdnsAppKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKeyId))
            {
                query["AppKeyId"] = request.AppKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                query["AuthCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePdnsAppKey",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePdnsAppKeyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取公共DNS AppKey 详情
         *
         * @param request DescribePdnsAppKeyRequest
         * @return DescribePdnsAppKeyResponse
         */
        public DescribePdnsAppKeyResponse DescribePdnsAppKey(DescribePdnsAppKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePdnsAppKeyWithOptions(request, runtime);
        }

        /**
         * @summary 获取公共DNS AppKey 详情
         *
         * @param request DescribePdnsAppKeyRequest
         * @return DescribePdnsAppKeyResponse
         */
        public async Task<DescribePdnsAppKeyResponse> DescribePdnsAppKeyAsync(DescribePdnsAppKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePdnsAppKeyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取公共DNS AppKey 列表
         *
         * @param request DescribePdnsAppKeysRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePdnsAppKeysResponse
         */
        public DescribePdnsAppKeysResponse DescribePdnsAppKeysWithOptions(DescribePdnsAppKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePdnsAppKeys",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePdnsAppKeysResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取公共DNS AppKey 列表
         *
         * @param request DescribePdnsAppKeysRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePdnsAppKeysResponse
         */
        public async Task<DescribePdnsAppKeysResponse> DescribePdnsAppKeysWithOptionsAsync(DescribePdnsAppKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePdnsAppKeys",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePdnsAppKeysResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取公共DNS AppKey 列表
         *
         * @param request DescribePdnsAppKeysRequest
         * @return DescribePdnsAppKeysResponse
         */
        public DescribePdnsAppKeysResponse DescribePdnsAppKeys(DescribePdnsAppKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePdnsAppKeysWithOptions(request, runtime);
        }

        /**
         * @summary 获取公共DNS AppKey 列表
         *
         * @param request DescribePdnsAppKeysRequest
         * @return DescribePdnsAppKeysResponse
         */
        public async Task<DescribePdnsAppKeysResponse> DescribePdnsAppKeysAsync(DescribePdnsAppKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePdnsAppKeysWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取公共DNS 操作日志列表
         *
         * @param request DescribePdnsOperateLogsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePdnsOperateLogsResponse
         */
        public DescribePdnsOperateLogsResponse DescribePdnsOperateLogsWithOptions(DescribePdnsOperateLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionType))
            {
                query["ActionType"] = request.ActionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
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
                Action = "DescribePdnsOperateLogs",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePdnsOperateLogsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取公共DNS 操作日志列表
         *
         * @param request DescribePdnsOperateLogsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePdnsOperateLogsResponse
         */
        public async Task<DescribePdnsOperateLogsResponse> DescribePdnsOperateLogsWithOptionsAsync(DescribePdnsOperateLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionType))
            {
                query["ActionType"] = request.ActionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
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
                Action = "DescribePdnsOperateLogs",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePdnsOperateLogsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取公共DNS 操作日志列表
         *
         * @param request DescribePdnsOperateLogsRequest
         * @return DescribePdnsOperateLogsResponse
         */
        public DescribePdnsOperateLogsResponse DescribePdnsOperateLogs(DescribePdnsOperateLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePdnsOperateLogsWithOptions(request, runtime);
        }

        /**
         * @summary 获取公共DNS 操作日志列表
         *
         * @param request DescribePdnsOperateLogsRequest
         * @return DescribePdnsOperateLogsResponse
         */
        public async Task<DescribePdnsOperateLogsResponse> DescribePdnsOperateLogsAsync(DescribePdnsOperateLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePdnsOperateLogsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取公共DNS 请求统计
         *
         * @param request DescribePdnsRequestStatisticRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePdnsRequestStatisticResponse
         */
        public DescribePdnsRequestStatisticResponse DescribePdnsRequestStatisticWithOptions(DescribePdnsRequestStatisticRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubDomain))
            {
                query["SubDomain"] = request.SubDomain;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePdnsRequestStatistic",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePdnsRequestStatisticResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取公共DNS 请求统计
         *
         * @param request DescribePdnsRequestStatisticRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePdnsRequestStatisticResponse
         */
        public async Task<DescribePdnsRequestStatisticResponse> DescribePdnsRequestStatisticWithOptionsAsync(DescribePdnsRequestStatisticRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubDomain))
            {
                query["SubDomain"] = request.SubDomain;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePdnsRequestStatistic",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePdnsRequestStatisticResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取公共DNS 请求统计
         *
         * @param request DescribePdnsRequestStatisticRequest
         * @return DescribePdnsRequestStatisticResponse
         */
        public DescribePdnsRequestStatisticResponse DescribePdnsRequestStatistic(DescribePdnsRequestStatisticRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePdnsRequestStatisticWithOptions(request, runtime);
        }

        /**
         * @summary 获取公共DNS 请求统计
         *
         * @param request DescribePdnsRequestStatisticRequest
         * @return DescribePdnsRequestStatisticResponse
         */
        public async Task<DescribePdnsRequestStatisticResponse> DescribePdnsRequestStatisticAsync(DescribePdnsRequestStatisticRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePdnsRequestStatisticWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取公共DNS 请求统计列表
         *
         * @param request DescribePdnsRequestStatisticsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePdnsRequestStatisticsResponse
         */
        public DescribePdnsRequestStatisticsResponse DescribePdnsRequestStatisticsWithOptions(DescribePdnsRequestStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubDomain))
            {
                query["SubDomain"] = request.SubDomain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePdnsRequestStatistics",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePdnsRequestStatisticsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取公共DNS 请求统计列表
         *
         * @param request DescribePdnsRequestStatisticsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePdnsRequestStatisticsResponse
         */
        public async Task<DescribePdnsRequestStatisticsResponse> DescribePdnsRequestStatisticsWithOptionsAsync(DescribePdnsRequestStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubDomain))
            {
                query["SubDomain"] = request.SubDomain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePdnsRequestStatistics",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePdnsRequestStatisticsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取公共DNS 请求统计列表
         *
         * @param request DescribePdnsRequestStatisticsRequest
         * @return DescribePdnsRequestStatisticsResponse
         */
        public DescribePdnsRequestStatisticsResponse DescribePdnsRequestStatistics(DescribePdnsRequestStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePdnsRequestStatisticsWithOptions(request, runtime);
        }

        /**
         * @summary 获取公共DNS 请求统计列表
         *
         * @param request DescribePdnsRequestStatisticsRequest
         * @return DescribePdnsRequestStatisticsResponse
         */
        public async Task<DescribePdnsRequestStatisticsResponse> DescribePdnsRequestStatisticsAsync(DescribePdnsRequestStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePdnsRequestStatisticsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取公共DNS 威胁日志列表
         *
         * @param request DescribePdnsThreatLogsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePdnsThreatLogsResponse
         */
        public DescribePdnsThreatLogsResponse DescribePdnsThreatLogsWithOptions(DescribePdnsThreatLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThreatLevel))
            {
                query["ThreatLevel"] = request.ThreatLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThreatSourceIp))
            {
                query["ThreatSourceIp"] = request.ThreatSourceIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThreatType))
            {
                query["ThreatType"] = request.ThreatType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePdnsThreatLogs",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePdnsThreatLogsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取公共DNS 威胁日志列表
         *
         * @param request DescribePdnsThreatLogsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePdnsThreatLogsResponse
         */
        public async Task<DescribePdnsThreatLogsResponse> DescribePdnsThreatLogsWithOptionsAsync(DescribePdnsThreatLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThreatLevel))
            {
                query["ThreatLevel"] = request.ThreatLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThreatSourceIp))
            {
                query["ThreatSourceIp"] = request.ThreatSourceIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThreatType))
            {
                query["ThreatType"] = request.ThreatType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePdnsThreatLogs",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePdnsThreatLogsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取公共DNS 威胁日志列表
         *
         * @param request DescribePdnsThreatLogsRequest
         * @return DescribePdnsThreatLogsResponse
         */
        public DescribePdnsThreatLogsResponse DescribePdnsThreatLogs(DescribePdnsThreatLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePdnsThreatLogsWithOptions(request, runtime);
        }

        /**
         * @summary 获取公共DNS 威胁日志列表
         *
         * @param request DescribePdnsThreatLogsRequest
         * @return DescribePdnsThreatLogsResponse
         */
        public async Task<DescribePdnsThreatLogsResponse> DescribePdnsThreatLogsAsync(DescribePdnsThreatLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePdnsThreatLogsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取公共DNS 威胁统计
         *
         * @param request DescribePdnsThreatStatisticRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePdnsThreatStatisticResponse
         */
        public DescribePdnsThreatStatisticResponse DescribePdnsThreatStatisticWithOptions(DescribePdnsThreatStatisticRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThreatSourceIp))
            {
                query["ThreatSourceIp"] = request.ThreatSourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePdnsThreatStatistic",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePdnsThreatStatisticResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取公共DNS 威胁统计
         *
         * @param request DescribePdnsThreatStatisticRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePdnsThreatStatisticResponse
         */
        public async Task<DescribePdnsThreatStatisticResponse> DescribePdnsThreatStatisticWithOptionsAsync(DescribePdnsThreatStatisticRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThreatSourceIp))
            {
                query["ThreatSourceIp"] = request.ThreatSourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePdnsThreatStatistic",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePdnsThreatStatisticResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取公共DNS 威胁统计
         *
         * @param request DescribePdnsThreatStatisticRequest
         * @return DescribePdnsThreatStatisticResponse
         */
        public DescribePdnsThreatStatisticResponse DescribePdnsThreatStatistic(DescribePdnsThreatStatisticRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePdnsThreatStatisticWithOptions(request, runtime);
        }

        /**
         * @summary 获取公共DNS 威胁统计
         *
         * @param request DescribePdnsThreatStatisticRequest
         * @return DescribePdnsThreatStatisticResponse
         */
        public async Task<DescribePdnsThreatStatisticResponse> DescribePdnsThreatStatisticAsync(DescribePdnsThreatStatisticRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePdnsThreatStatisticWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取公共DNS 威胁统计列表
         *
         * @param request DescribePdnsThreatStatisticsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePdnsThreatStatisticsResponse
         */
        public DescribePdnsThreatStatisticsResponse DescribePdnsThreatStatisticsWithOptions(DescribePdnsThreatStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubDomain))
            {
                query["SubDomain"] = request.SubDomain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThreatLevel))
            {
                query["ThreatLevel"] = request.ThreatLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThreatSourceIp))
            {
                query["ThreatSourceIp"] = request.ThreatSourceIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThreatType))
            {
                query["ThreatType"] = request.ThreatType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePdnsThreatStatistics",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePdnsThreatStatisticsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取公共DNS 威胁统计列表
         *
         * @param request DescribePdnsThreatStatisticsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePdnsThreatStatisticsResponse
         */
        public async Task<DescribePdnsThreatStatisticsResponse> DescribePdnsThreatStatisticsWithOptionsAsync(DescribePdnsThreatStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubDomain))
            {
                query["SubDomain"] = request.SubDomain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThreatLevel))
            {
                query["ThreatLevel"] = request.ThreatLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThreatSourceIp))
            {
                query["ThreatSourceIp"] = request.ThreatSourceIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThreatType))
            {
                query["ThreatType"] = request.ThreatType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePdnsThreatStatistics",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePdnsThreatStatisticsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取公共DNS 威胁统计列表
         *
         * @param request DescribePdnsThreatStatisticsRequest
         * @return DescribePdnsThreatStatisticsResponse
         */
        public DescribePdnsThreatStatisticsResponse DescribePdnsThreatStatistics(DescribePdnsThreatStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePdnsThreatStatisticsWithOptions(request, runtime);
        }

        /**
         * @summary 获取公共DNS 威胁统计列表
         *
         * @param request DescribePdnsThreatStatisticsRequest
         * @return DescribePdnsThreatStatisticsResponse
         */
        public async Task<DescribePdnsThreatStatisticsResponse> DescribePdnsThreatStatisticsAsync(DescribePdnsThreatStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePdnsThreatStatisticsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取公共DNS Udp IP段列表
         *
         * @param request DescribePdnsUdpIpSegmentsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePdnsUdpIpSegmentsResponse
         */
        public DescribePdnsUdpIpSegmentsResponse DescribePdnsUdpIpSegmentsWithOptions(DescribePdnsUdpIpSegmentsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
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
                Action = "DescribePdnsUdpIpSegments",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePdnsUdpIpSegmentsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取公共DNS Udp IP段列表
         *
         * @param request DescribePdnsUdpIpSegmentsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePdnsUdpIpSegmentsResponse
         */
        public async Task<DescribePdnsUdpIpSegmentsResponse> DescribePdnsUdpIpSegmentsWithOptionsAsync(DescribePdnsUdpIpSegmentsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
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
                Action = "DescribePdnsUdpIpSegments",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePdnsUdpIpSegmentsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取公共DNS Udp IP段列表
         *
         * @param request DescribePdnsUdpIpSegmentsRequest
         * @return DescribePdnsUdpIpSegmentsResponse
         */
        public DescribePdnsUdpIpSegmentsResponse DescribePdnsUdpIpSegments(DescribePdnsUdpIpSegmentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePdnsUdpIpSegmentsWithOptions(request, runtime);
        }

        /**
         * @summary 获取公共DNS Udp IP段列表
         *
         * @param request DescribePdnsUdpIpSegmentsRequest
         * @return DescribePdnsUdpIpSegmentsResponse
         */
        public async Task<DescribePdnsUdpIpSegmentsResponse> DescribePdnsUdpIpSegmentsAsync(DescribePdnsUdpIpSegmentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePdnsUdpIpSegmentsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取公共DNS用户信息
         *
         * @param request DescribePdnsUserInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePdnsUserInfoResponse
         */
        public DescribePdnsUserInfoResponse DescribePdnsUserInfoWithOptions(DescribePdnsUserInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePdnsUserInfo",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePdnsUserInfoResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取公共DNS用户信息
         *
         * @param request DescribePdnsUserInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePdnsUserInfoResponse
         */
        public async Task<DescribePdnsUserInfoResponse> DescribePdnsUserInfoWithOptionsAsync(DescribePdnsUserInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePdnsUserInfo",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePdnsUserInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取公共DNS用户信息
         *
         * @param request DescribePdnsUserInfoRequest
         * @return DescribePdnsUserInfoResponse
         */
        public DescribePdnsUserInfoResponse DescribePdnsUserInfo(DescribePdnsUserInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePdnsUserInfoWithOptions(request, runtime);
        }

        /**
         * @summary 获取公共DNS用户信息
         *
         * @param request DescribePdnsUserInfoRequest
         * @return DescribePdnsUserInfoResponse
         */
        public async Task<DescribePdnsUserInfoResponse> DescribePdnsUserInfoAsync(DescribePdnsUserInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePdnsUserInfoWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the operation logs of a domain name based on the specified parameters.
         *
         * @param request DescribeRecordLogsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRecordLogsResponse
         */
        public DescribeRecordLogsResponse DescribeRecordLogsWithOptions(DescribeRecordLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyWord))
            {
                query["KeyWord"] = request.KeyWord;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["endDate"] = request.EndDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRecordLogs",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRecordLogsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the operation logs of a domain name based on the specified parameters.
         *
         * @param request DescribeRecordLogsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRecordLogsResponse
         */
        public async Task<DescribeRecordLogsResponse> DescribeRecordLogsWithOptionsAsync(DescribeRecordLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyWord))
            {
                query["KeyWord"] = request.KeyWord;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["endDate"] = request.EndDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRecordLogs",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRecordLogsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the operation logs of a domain name based on the specified parameters.
         *
         * @param request DescribeRecordLogsRequest
         * @return DescribeRecordLogsResponse
         */
        public DescribeRecordLogsResponse DescribeRecordLogs(DescribeRecordLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRecordLogsWithOptions(request, runtime);
        }

        /**
         * @summary Queries the operation logs of a domain name based on the specified parameters.
         *
         * @param request DescribeRecordLogsRequest
         * @return DescribeRecordLogsResponse
         */
        public async Task<DescribeRecordLogsResponse> DescribeRecordLogsAsync(DescribeRecordLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRecordLogsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the number of resolution requests for all subdomain names of a specified domain name.
         *
         * @param request DescribeRecordResolveStatisticsSummaryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRecordResolveStatisticsSummaryResponse
         */
        public DescribeRecordResolveStatisticsSummaryResponse DescribeRecordResolveStatisticsSummaryWithOptions(DescribeRecordResolveStatisticsSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainType))
            {
                query["DomainType"] = request.DomainType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchMode))
            {
                query["SearchMode"] = request.SearchMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Threshold))
            {
                query["Threshold"] = request.Threshold;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRecordResolveStatisticsSummary",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRecordResolveStatisticsSummaryResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the number of resolution requests for all subdomain names of a specified domain name.
         *
         * @param request DescribeRecordResolveStatisticsSummaryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRecordResolveStatisticsSummaryResponse
         */
        public async Task<DescribeRecordResolveStatisticsSummaryResponse> DescribeRecordResolveStatisticsSummaryWithOptionsAsync(DescribeRecordResolveStatisticsSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainType))
            {
                query["DomainType"] = request.DomainType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchMode))
            {
                query["SearchMode"] = request.SearchMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Threshold))
            {
                query["Threshold"] = request.Threshold;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRecordResolveStatisticsSummary",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRecordResolveStatisticsSummaryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the number of resolution requests for all subdomain names of a specified domain name.
         *
         * @param request DescribeRecordResolveStatisticsSummaryRequest
         * @return DescribeRecordResolveStatisticsSummaryResponse
         */
        public DescribeRecordResolveStatisticsSummaryResponse DescribeRecordResolveStatisticsSummary(DescribeRecordResolveStatisticsSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRecordResolveStatisticsSummaryWithOptions(request, runtime);
        }

        /**
         * @summary Queries the number of resolution requests for all subdomain names of a specified domain name.
         *
         * @param request DescribeRecordResolveStatisticsSummaryRequest
         * @return DescribeRecordResolveStatisticsSummaryResponse
         */
        public async Task<DescribeRecordResolveStatisticsSummaryResponse> DescribeRecordResolveStatisticsSummaryAsync(DescribeRecordResolveStatisticsSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRecordResolveStatisticsSummaryWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the real-time statistics on the Domain Name System (DNS) requests for a subdomain name.
         *
         * @description Real-time data is collected per hour.
         *
         * @param request DescribeRecordStatisticsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRecordStatisticsResponse
         */
        public DescribeRecordStatisticsResponse DescribeRecordStatisticsWithOptions(DescribeRecordStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainType))
            {
                query["DomainType"] = request.DomainType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rr))
            {
                query["Rr"] = request.Rr;
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
                Action = "DescribeRecordStatistics",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRecordStatisticsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the real-time statistics on the Domain Name System (DNS) requests for a subdomain name.
         *
         * @description Real-time data is collected per hour.
         *
         * @param request DescribeRecordStatisticsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRecordStatisticsResponse
         */
        public async Task<DescribeRecordStatisticsResponse> DescribeRecordStatisticsWithOptionsAsync(DescribeRecordStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainType))
            {
                query["DomainType"] = request.DomainType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rr))
            {
                query["Rr"] = request.Rr;
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
                Action = "DescribeRecordStatistics",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRecordStatisticsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the real-time statistics on the Domain Name System (DNS) requests for a subdomain name.
         *
         * @description Real-time data is collected per hour.
         *
         * @param request DescribeRecordStatisticsRequest
         * @return DescribeRecordStatisticsResponse
         */
        public DescribeRecordStatisticsResponse DescribeRecordStatistics(DescribeRecordStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRecordStatisticsWithOptions(request, runtime);
        }

        /**
         * @summary Queries the real-time statistics on the Domain Name System (DNS) requests for a subdomain name.
         *
         * @description Real-time data is collected per hour.
         *
         * @param request DescribeRecordStatisticsRequest
         * @return DescribeRecordStatisticsResponse
         */
        public async Task<DescribeRecordStatisticsResponse> DescribeRecordStatisticsAsync(DescribeRecordStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRecordStatisticsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the number of Domain Name System (DNS) requests for all subdomain names of a specified domain name.
         *
         * @param request DescribeRecordStatisticsSummaryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRecordStatisticsSummaryResponse
         */
        public DescribeRecordStatisticsSummaryResponse DescribeRecordStatisticsSummaryWithOptions(DescribeRecordStatisticsSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainType))
            {
                query["DomainType"] = request.DomainType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchMode))
            {
                query["SearchMode"] = request.SearchMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Threshold))
            {
                query["Threshold"] = request.Threshold;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRecordStatisticsSummary",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRecordStatisticsSummaryResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the number of Domain Name System (DNS) requests for all subdomain names of a specified domain name.
         *
         * @param request DescribeRecordStatisticsSummaryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRecordStatisticsSummaryResponse
         */
        public async Task<DescribeRecordStatisticsSummaryResponse> DescribeRecordStatisticsSummaryWithOptionsAsync(DescribeRecordStatisticsSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainType))
            {
                query["DomainType"] = request.DomainType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchMode))
            {
                query["SearchMode"] = request.SearchMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Threshold))
            {
                query["Threshold"] = request.Threshold;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRecordStatisticsSummary",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRecordStatisticsSummaryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the number of Domain Name System (DNS) requests for all subdomain names of a specified domain name.
         *
         * @param request DescribeRecordStatisticsSummaryRequest
         * @return DescribeRecordStatisticsSummaryResponse
         */
        public DescribeRecordStatisticsSummaryResponse DescribeRecordStatisticsSummary(DescribeRecordStatisticsSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRecordStatisticsSummaryWithOptions(request, runtime);
        }

        /**
         * @summary Queries the number of Domain Name System (DNS) requests for all subdomain names of a specified domain name.
         *
         * @param request DescribeRecordStatisticsSummaryRequest
         * @return DescribeRecordStatisticsSummaryResponse
         */
        public async Task<DescribeRecordStatisticsSummaryResponse> DescribeRecordStatisticsSummaryAsync(DescribeRecordStatisticsSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRecordStatisticsSummaryWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries all Domain Name System (DNS) records of a subdomain name based on the specified parameters.
         *
         * @param request DescribeSubDomainRecordsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSubDomainRecordsResponse
         */
        public DescribeSubDomainRecordsResponse DescribeSubDomainRecordsWithOptions(DescribeSubDomainRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Line))
            {
                query["Line"] = request.Line;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubDomain))
            {
                query["SubDomain"] = request.SubDomain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSubDomainRecords",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSubDomainRecordsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries all Domain Name System (DNS) records of a subdomain name based on the specified parameters.
         *
         * @param request DescribeSubDomainRecordsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSubDomainRecordsResponse
         */
        public async Task<DescribeSubDomainRecordsResponse> DescribeSubDomainRecordsWithOptionsAsync(DescribeSubDomainRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Line))
            {
                query["Line"] = request.Line;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubDomain))
            {
                query["SubDomain"] = request.SubDomain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSubDomainRecords",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSubDomainRecordsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries all Domain Name System (DNS) records of a subdomain name based on the specified parameters.
         *
         * @param request DescribeSubDomainRecordsRequest
         * @return DescribeSubDomainRecordsResponse
         */
        public DescribeSubDomainRecordsResponse DescribeSubDomainRecords(DescribeSubDomainRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSubDomainRecordsWithOptions(request, runtime);
        }

        /**
         * @summary Queries all Domain Name System (DNS) records of a subdomain name based on the specified parameters.
         *
         * @param request DescribeSubDomainRecordsRequest
         * @return DescribeSubDomainRecordsResponse
         */
        public async Task<DescribeSubDomainRecordsResponse> DescribeSubDomainRecordsAsync(DescribeSubDomainRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSubDomainRecordsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询云解析支持的所有线路列表。
         *
         * @param request DescribeSupportLinesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSupportLinesResponse
         */
        public DescribeSupportLinesResponse DescribeSupportLinesWithOptions(DescribeSupportLinesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSupportLines",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSupportLinesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询云解析支持的所有线路列表。
         *
         * @param request DescribeSupportLinesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSupportLinesResponse
         */
        public async Task<DescribeSupportLinesResponse> DescribeSupportLinesWithOptionsAsync(DescribeSupportLinesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSupportLines",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSupportLinesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询云解析支持的所有线路列表。
         *
         * @param request DescribeSupportLinesRequest
         * @return DescribeSupportLinesResponse
         */
        public DescribeSupportLinesResponse DescribeSupportLines(DescribeSupportLinesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSupportLinesWithOptions(request, runtime);
        }

        /**
         * @summary 查询云解析支持的所有线路列表。
         *
         * @param request DescribeSupportLinesRequest
         * @return DescribeSupportLinesResponse
         */
        public async Task<DescribeSupportLinesResponse> DescribeSupportLinesAsync(DescribeSupportLinesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSupportLinesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries existing tags.
         *
         * @param request DescribeTagsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeTagsResponse
         */
        public DescribeTagsResponse DescribeTagsWithOptions(DescribeTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTags",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTagsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries existing tags.
         *
         * @param request DescribeTagsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeTagsResponse
         */
        public async Task<DescribeTagsResponse> DescribeTagsWithOptionsAsync(DescribeTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTags",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTagsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries existing tags.
         *
         * @param request DescribeTagsRequest
         * @return DescribeTagsResponse
         */
        public DescribeTagsResponse DescribeTags(DescribeTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTagsWithOptions(request, runtime);
        }

        /**
         * @summary Queries existing tags.
         *
         * @param request DescribeTagsRequest
         * @return DescribeTagsResponse
         */
        public async Task<DescribeTagsResponse> DescribeTagsAsync(DescribeTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTagsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the domain names that were transferred between the current account and another account based on the specified parameters.
         *
         * @param request DescribeTransferDomainsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeTransferDomainsResponse
         */
        public DescribeTransferDomainsResponse DescribeTransferDomainsWithOptions(DescribeTransferDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromUserId))
            {
                query["FromUserId"] = request.FromUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetUserId))
            {
                query["TargetUserId"] = request.TargetUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransferType))
            {
                query["TransferType"] = request.TransferType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTransferDomains",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTransferDomainsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the domain names that were transferred between the current account and another account based on the specified parameters.
         *
         * @param request DescribeTransferDomainsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeTransferDomainsResponse
         */
        public async Task<DescribeTransferDomainsResponse> DescribeTransferDomainsWithOptionsAsync(DescribeTransferDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromUserId))
            {
                query["FromUserId"] = request.FromUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetUserId))
            {
                query["TargetUserId"] = request.TargetUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransferType))
            {
                query["TransferType"] = request.TransferType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTransferDomains",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTransferDomainsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the domain names that were transferred between the current account and another account based on the specified parameters.
         *
         * @param request DescribeTransferDomainsRequest
         * @return DescribeTransferDomainsResponse
         */
        public DescribeTransferDomainsResponse DescribeTransferDomains(DescribeTransferDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTransferDomainsWithOptions(request, runtime);
        }

        /**
         * @summary Queries the domain names that were transferred between the current account and another account based on the specified parameters.
         *
         * @param request DescribeTransferDomainsRequest
         * @return DescribeTransferDomainsResponse
         */
        public async Task<DescribeTransferDomainsResponse> DescribeTransferDomainsAsync(DescribeTransferDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTransferDomainsWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ExecuteGtmRecoveryPlanRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ExecuteGtmRecoveryPlanResponse
         */
        public ExecuteGtmRecoveryPlanResponse ExecuteGtmRecoveryPlanWithOptions(ExecuteGtmRecoveryPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryPlanId))
            {
                query["RecoveryPlanId"] = request.RecoveryPlanId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecuteGtmRecoveryPlan",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteGtmRecoveryPlanResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ExecuteGtmRecoveryPlanRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ExecuteGtmRecoveryPlanResponse
         */
        public async Task<ExecuteGtmRecoveryPlanResponse> ExecuteGtmRecoveryPlanWithOptionsAsync(ExecuteGtmRecoveryPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryPlanId))
            {
                query["RecoveryPlanId"] = request.RecoveryPlanId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecuteGtmRecoveryPlan",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteGtmRecoveryPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ExecuteGtmRecoveryPlanRequest
         * @return ExecuteGtmRecoveryPlanResponse
         */
        public ExecuteGtmRecoveryPlanResponse ExecuteGtmRecoveryPlan(ExecuteGtmRecoveryPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExecuteGtmRecoveryPlanWithOptions(request, runtime);
        }

        /**
         * @param request ExecuteGtmRecoveryPlanRequest
         * @return ExecuteGtmRecoveryPlanResponse
         */
        public async Task<ExecuteGtmRecoveryPlanResponse> ExecuteGtmRecoveryPlanAsync(ExecuteGtmRecoveryPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExecuteGtmRecoveryPlanWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries a primary domain name based on the specified parameters.
         *
         * @description For more information about the difference between primary domain names and subdomain names, see
         * [Subdomain levels](https://www.alibabacloud.com/help/zh/faq-detail/39803.htm). For example, if you enter `www.abc.com`, abc.com is obtained.
         *
         * @param request GetMainDomainNameRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMainDomainNameResponse
         */
        public GetMainDomainNameResponse GetMainDomainNameWithOptions(GetMainDomainNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputString))
            {
                query["InputString"] = request.InputString;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMainDomainName",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMainDomainNameResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries a primary domain name based on the specified parameters.
         *
         * @description For more information about the difference between primary domain names and subdomain names, see
         * [Subdomain levels](https://www.alibabacloud.com/help/zh/faq-detail/39803.htm). For example, if you enter `www.abc.com`, abc.com is obtained.
         *
         * @param request GetMainDomainNameRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMainDomainNameResponse
         */
        public async Task<GetMainDomainNameResponse> GetMainDomainNameWithOptionsAsync(GetMainDomainNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputString))
            {
                query["InputString"] = request.InputString;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMainDomainName",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMainDomainNameResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries a primary domain name based on the specified parameters.
         *
         * @description For more information about the difference between primary domain names and subdomain names, see
         * [Subdomain levels](https://www.alibabacloud.com/help/zh/faq-detail/39803.htm). For example, if you enter `www.abc.com`, abc.com is obtained.
         *
         * @param request GetMainDomainNameRequest
         * @return GetMainDomainNameResponse
         */
        public GetMainDomainNameResponse GetMainDomainName(GetMainDomainNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMainDomainNameWithOptions(request, runtime);
        }

        /**
         * @summary Queries a primary domain name based on the specified parameters.
         *
         * @description For more information about the difference between primary domain names and subdomain names, see
         * [Subdomain levels](https://www.alibabacloud.com/help/zh/faq-detail/39803.htm). For example, if you enter `www.abc.com`, abc.com is obtained.
         *
         * @param request GetMainDomainNameRequest
         * @return GetMainDomainNameResponse
         */
        public async Task<GetMainDomainNameResponse> GetMainDomainNameAsync(GetMainDomainNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMainDomainNameWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Generates a text (TXT) record. TXT records are used to retrieve domain names and subdomain names, enable the subdomain name verification feature, and perform batch retrievals.
         *
         * @param request GetTxtRecordForVerifyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTxtRecordForVerifyResponse
         */
        public GetTxtRecordForVerifyResponse GetTxtRecordForVerifyWithOptions(GetTxtRecordForVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTxtRecordForVerify",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTxtRecordForVerifyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Generates a text (TXT) record. TXT records are used to retrieve domain names and subdomain names, enable the subdomain name verification feature, and perform batch retrievals.
         *
         * @param request GetTxtRecordForVerifyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTxtRecordForVerifyResponse
         */
        public async Task<GetTxtRecordForVerifyResponse> GetTxtRecordForVerifyWithOptionsAsync(GetTxtRecordForVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTxtRecordForVerify",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTxtRecordForVerifyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Generates a text (TXT) record. TXT records are used to retrieve domain names and subdomain names, enable the subdomain name verification feature, and perform batch retrievals.
         *
         * @param request GetTxtRecordForVerifyRequest
         * @return GetTxtRecordForVerifyResponse
         */
        public GetTxtRecordForVerifyResponse GetTxtRecordForVerify(GetTxtRecordForVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTxtRecordForVerifyWithOptions(request, runtime);
        }

        /**
         * @summary Generates a text (TXT) record. TXT records are used to retrieve domain names and subdomain names, enable the subdomain name verification feature, and perform batch retrievals.
         *
         * @param request GetTxtRecordForVerifyRequest
         * @return GetTxtRecordForVerifyResponse
         */
        public async Task<GetTxtRecordForVerifyResponse> GetTxtRecordForVerifyAsync(GetTxtRecordForVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTxtRecordForVerifyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the tags that are added to a specified resource.
         *
         * @description *   Set ResourceId.N or Tag.N that consists of Tag.N.Key and Tag.N.Value in the request to specify the object to be queried.
         * *   Tag.N is a resource tag that consists of a key-value pair. If you set only Tag.N.Key, all tag values that are assigned to the specified key are returned. If you set only Tag.N.Value, an error message is returned.
         * *   If you set both Tag.N and ResourceId.N to filter tags, ResourceId.N must match all specified key-value pairs.
         * *   If you specify multiple key-value pairs, resources that contain these key-value pairs are returned.
         *
         * @param request ListTagResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTagResourcesResponse
         */
        public ListTagResourcesResponse ListTagResourcesWithOptions(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagResources",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the tags that are added to a specified resource.
         *
         * @description *   Set ResourceId.N or Tag.N that consists of Tag.N.Key and Tag.N.Value in the request to specify the object to be queried.
         * *   Tag.N is a resource tag that consists of a key-value pair. If you set only Tag.N.Key, all tag values that are assigned to the specified key are returned. If you set only Tag.N.Value, an error message is returned.
         * *   If you set both Tag.N and ResourceId.N to filter tags, ResourceId.N must match all specified key-value pairs.
         * *   If you specify multiple key-value pairs, resources that contain these key-value pairs are returned.
         *
         * @param request ListTagResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTagResourcesResponse
         */
        public async Task<ListTagResourcesResponse> ListTagResourcesWithOptionsAsync(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagResources",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the tags that are added to a specified resource.
         *
         * @description *   Set ResourceId.N or Tag.N that consists of Tag.N.Key and Tag.N.Value in the request to specify the object to be queried.
         * *   Tag.N is a resource tag that consists of a key-value pair. If you set only Tag.N.Key, all tag values that are assigned to the specified key are returned. If you set only Tag.N.Value, an error message is returned.
         * *   If you set both Tag.N and ResourceId.N to filter tags, ResourceId.N must match all specified key-value pairs.
         * *   If you specify multiple key-value pairs, resources that contain these key-value pairs are returned.
         *
         * @param request ListTagResourcesRequest
         * @return ListTagResourcesResponse
         */
        public ListTagResourcesResponse ListTagResources(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTagResourcesWithOptions(request, runtime);
        }

        /**
         * @summary Queries the tags that are added to a specified resource.
         *
         * @description *   Set ResourceId.N or Tag.N that consists of Tag.N.Key and Tag.N.Value in the request to specify the object to be queried.
         * *   Tag.N is a resource tag that consists of a key-value pair. If you set only Tag.N.Key, all tag values that are assigned to the specified key are returned. If you set only Tag.N.Value, an error message is returned.
         * *   If you set both Tag.N and ResourceId.N to filter tags, ResourceId.N must match all specified key-value pairs.
         * *   If you specify multiple key-value pairs, resources that contain these key-value pairs are returned.
         *
         * @param request ListTagResourcesRequest
         * @return ListTagResourcesResponse
         */
        public async Task<ListTagResourcesResponse> ListTagResourcesAsync(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTagResourcesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Calls the ModifyHichinaDomainDNS operation to change the name of a DNS server based on input parameters.
         *
         * @description If the operation succeeds, the name of the DNS server changes to that of an Alibaba Cloud DNS server (ending with hichina.com).
         * >  Before you call this operation, make sure that your domain name has been registered with Alibaba Cloud and the DNS server in use is not an Alibaba Cloud DNS server.
         *
         * @param request ModifyHichinaDomainDNSRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyHichinaDomainDNSResponse
         */
        public ModifyHichinaDomainDNSResponse ModifyHichinaDomainDNSWithOptions(ModifyHichinaDomainDNSRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyHichinaDomainDNS",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyHichinaDomainDNSResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Calls the ModifyHichinaDomainDNS operation to change the name of a DNS server based on input parameters.
         *
         * @description If the operation succeeds, the name of the DNS server changes to that of an Alibaba Cloud DNS server (ending with hichina.com).
         * >  Before you call this operation, make sure that your domain name has been registered with Alibaba Cloud and the DNS server in use is not an Alibaba Cloud DNS server.
         *
         * @param request ModifyHichinaDomainDNSRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyHichinaDomainDNSResponse
         */
        public async Task<ModifyHichinaDomainDNSResponse> ModifyHichinaDomainDNSWithOptionsAsync(ModifyHichinaDomainDNSRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyHichinaDomainDNS",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyHichinaDomainDNSResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Calls the ModifyHichinaDomainDNS operation to change the name of a DNS server based on input parameters.
         *
         * @description If the operation succeeds, the name of the DNS server changes to that of an Alibaba Cloud DNS server (ending with hichina.com).
         * >  Before you call this operation, make sure that your domain name has been registered with Alibaba Cloud and the DNS server in use is not an Alibaba Cloud DNS server.
         *
         * @param request ModifyHichinaDomainDNSRequest
         * @return ModifyHichinaDomainDNSResponse
         */
        public ModifyHichinaDomainDNSResponse ModifyHichinaDomainDNS(ModifyHichinaDomainDNSRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyHichinaDomainDNSWithOptions(request, runtime);
        }

        /**
         * @summary Calls the ModifyHichinaDomainDNS operation to change the name of a DNS server based on input parameters.
         *
         * @description If the operation succeeds, the name of the DNS server changes to that of an Alibaba Cloud DNS server (ending with hichina.com).
         * >  Before you call this operation, make sure that your domain name has been registered with Alibaba Cloud and the DNS server in use is not an Alibaba Cloud DNS server.
         *
         * @param request ModifyHichinaDomainDNSRequest
         * @return ModifyHichinaDomainDNSResponse
         */
        public async Task<ModifyHichinaDomainDNSResponse> ModifyHichinaDomainDNSAsync(ModifyHichinaDomainDNSRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyHichinaDomainDNSWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Moves a domain name to another resource group.
         *
         * @param request MoveDomainResourceGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return MoveDomainResourceGroupResponse
         */
        public MoveDomainResourceGroupResponse MoveDomainResourceGroupWithOptions(MoveDomainResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewResourceGroupId))
            {
                query["NewResourceGroupId"] = request.NewResourceGroupId;
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
                Action = "MoveDomainResourceGroup",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MoveDomainResourceGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Moves a domain name to another resource group.
         *
         * @param request MoveDomainResourceGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return MoveDomainResourceGroupResponse
         */
        public async Task<MoveDomainResourceGroupResponse> MoveDomainResourceGroupWithOptionsAsync(MoveDomainResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewResourceGroupId))
            {
                query["NewResourceGroupId"] = request.NewResourceGroupId;
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
                Action = "MoveDomainResourceGroup",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MoveDomainResourceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Moves a domain name to another resource group.
         *
         * @param request MoveDomainResourceGroupRequest
         * @return MoveDomainResourceGroupResponse
         */
        public MoveDomainResourceGroupResponse MoveDomainResourceGroup(MoveDomainResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MoveDomainResourceGroupWithOptions(request, runtime);
        }

        /**
         * @summary Moves a domain name to another resource group.
         *
         * @param request MoveDomainResourceGroupRequest
         * @return MoveDomainResourceGroupResponse
         */
        public async Task<MoveDomainResourceGroupResponse> MoveDomainResourceGroupAsync(MoveDomainResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MoveDomainResourceGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @param request MoveGtmResourceGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return MoveGtmResourceGroupResponse
         */
        public MoveGtmResourceGroupResponse MoveGtmResourceGroupWithOptions(MoveGtmResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewResourceGroupId))
            {
                query["NewResourceGroupId"] = request.NewResourceGroupId;
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
                Action = "MoveGtmResourceGroup",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MoveGtmResourceGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request MoveGtmResourceGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return MoveGtmResourceGroupResponse
         */
        public async Task<MoveGtmResourceGroupResponse> MoveGtmResourceGroupWithOptionsAsync(MoveGtmResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewResourceGroupId))
            {
                query["NewResourceGroupId"] = request.NewResourceGroupId;
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
                Action = "MoveGtmResourceGroup",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MoveGtmResourceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request MoveGtmResourceGroupRequest
         * @return MoveGtmResourceGroupResponse
         */
        public MoveGtmResourceGroupResponse MoveGtmResourceGroup(MoveGtmResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MoveGtmResourceGroupWithOptions(request, runtime);
        }

        /**
         * @param request MoveGtmResourceGroupRequest
         * @return MoveGtmResourceGroupResponse
         */
        public async Task<MoveGtmResourceGroupResponse> MoveGtmResourceGroupAsync(MoveGtmResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MoveGtmResourceGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Submits a batch operation task to add or delete multiple domain names or multiple Domain Name System (DNS) records at a time.
         *
         * @description Scenario: You need to execute a large number of tasks related to DNS resolution and you do not have high requirements for efficiency.
         *
         * @param request OperateBatchDomainRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return OperateBatchDomainResponse
         */
        public OperateBatchDomainResponse OperateBatchDomainWithOptions(OperateBatchDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainRecordInfo))
            {
                query["DomainRecordInfo"] = request.DomainRecordInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OperateBatchDomain",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OperateBatchDomainResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Submits a batch operation task to add or delete multiple domain names or multiple Domain Name System (DNS) records at a time.
         *
         * @description Scenario: You need to execute a large number of tasks related to DNS resolution and you do not have high requirements for efficiency.
         *
         * @param request OperateBatchDomainRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return OperateBatchDomainResponse
         */
        public async Task<OperateBatchDomainResponse> OperateBatchDomainWithOptionsAsync(OperateBatchDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainRecordInfo))
            {
                query["DomainRecordInfo"] = request.DomainRecordInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OperateBatchDomain",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OperateBatchDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Submits a batch operation task to add or delete multiple domain names or multiple Domain Name System (DNS) records at a time.
         *
         * @description Scenario: You need to execute a large number of tasks related to DNS resolution and you do not have high requirements for efficiency.
         *
         * @param request OperateBatchDomainRequest
         * @return OperateBatchDomainResponse
         */
        public OperateBatchDomainResponse OperateBatchDomain(OperateBatchDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OperateBatchDomainWithOptions(request, runtime);
        }

        /**
         * @summary Submits a batch operation task to add or delete multiple domain names or multiple Domain Name System (DNS) records at a time.
         *
         * @description Scenario: You need to execute a large number of tasks related to DNS resolution and you do not have high requirements for efficiency.
         *
         * @param request OperateBatchDomainRequest
         * @return OperateBatchDomainResponse
         */
        public async Task<OperateBatchDomainResponse> OperateBatchDomainAsync(OperateBatchDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OperateBatchDomainWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 暂停公共DNS服务
         *
         * @param request PausePdnsServiceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return PausePdnsServiceResponse
         */
        public PausePdnsServiceResponse PausePdnsServiceWithOptions(PausePdnsServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceType))
            {
                query["ServiceType"] = request.ServiceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PausePdnsService",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PausePdnsServiceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 暂停公共DNS服务
         *
         * @param request PausePdnsServiceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return PausePdnsServiceResponse
         */
        public async Task<PausePdnsServiceResponse> PausePdnsServiceWithOptionsAsync(PausePdnsServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceType))
            {
                query["ServiceType"] = request.ServiceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PausePdnsService",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PausePdnsServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 暂停公共DNS服务
         *
         * @param request PausePdnsServiceRequest
         * @return PausePdnsServiceResponse
         */
        public PausePdnsServiceResponse PausePdnsService(PausePdnsServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PausePdnsServiceWithOptions(request, runtime);
        }

        /**
         * @summary 暂停公共DNS服务
         *
         * @param request PausePdnsServiceRequest
         * @return PausePdnsServiceResponse
         */
        public async Task<PausePdnsServiceResponse> PausePdnsServiceAsync(PausePdnsServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PausePdnsServiceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary You can call this operation to preview a disaster recovery plan of a Global Traffic Manager (GTM) instance.
         *
         * @param request PreviewGtmRecoveryPlanRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return PreviewGtmRecoveryPlanResponse
         */
        public PreviewGtmRecoveryPlanResponse PreviewGtmRecoveryPlanWithOptions(PreviewGtmRecoveryPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryPlanId))
            {
                query["RecoveryPlanId"] = request.RecoveryPlanId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PreviewGtmRecoveryPlan",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PreviewGtmRecoveryPlanResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to preview a disaster recovery plan of a Global Traffic Manager (GTM) instance.
         *
         * @param request PreviewGtmRecoveryPlanRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return PreviewGtmRecoveryPlanResponse
         */
        public async Task<PreviewGtmRecoveryPlanResponse> PreviewGtmRecoveryPlanWithOptionsAsync(PreviewGtmRecoveryPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryPlanId))
            {
                query["RecoveryPlanId"] = request.RecoveryPlanId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PreviewGtmRecoveryPlan",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PreviewGtmRecoveryPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to preview a disaster recovery plan of a Global Traffic Manager (GTM) instance.
         *
         * @param request PreviewGtmRecoveryPlanRequest
         * @return PreviewGtmRecoveryPlanResponse
         */
        public PreviewGtmRecoveryPlanResponse PreviewGtmRecoveryPlan(PreviewGtmRecoveryPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PreviewGtmRecoveryPlanWithOptions(request, runtime);
        }

        /**
         * @summary You can call this operation to preview a disaster recovery plan of a Global Traffic Manager (GTM) instance.
         *
         * @param request PreviewGtmRecoveryPlanRequest
         * @return PreviewGtmRecoveryPlanResponse
         */
        public async Task<PreviewGtmRecoveryPlanResponse> PreviewGtmRecoveryPlanAsync(PreviewGtmRecoveryPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PreviewGtmRecoveryPlanWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除公共DNS AppKey
         *
         * @param request RemovePdnsAppKeyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemovePdnsAppKeyResponse
         */
        public RemovePdnsAppKeyResponse RemovePdnsAppKeyWithOptions(RemovePdnsAppKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKeyId))
            {
                query["AppKeyId"] = request.AppKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemovePdnsAppKey",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemovePdnsAppKeyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除公共DNS AppKey
         *
         * @param request RemovePdnsAppKeyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemovePdnsAppKeyResponse
         */
        public async Task<RemovePdnsAppKeyResponse> RemovePdnsAppKeyWithOptionsAsync(RemovePdnsAppKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKeyId))
            {
                query["AppKeyId"] = request.AppKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemovePdnsAppKey",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemovePdnsAppKeyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除公共DNS AppKey
         *
         * @param request RemovePdnsAppKeyRequest
         * @return RemovePdnsAppKeyResponse
         */
        public RemovePdnsAppKeyResponse RemovePdnsAppKey(RemovePdnsAppKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemovePdnsAppKeyWithOptions(request, runtime);
        }

        /**
         * @summary 删除公共DNS AppKey
         *
         * @param request RemovePdnsAppKeyRequest
         * @return RemovePdnsAppKeyResponse
         */
        public async Task<RemovePdnsAppKeyResponse> RemovePdnsAppKeyAsync(RemovePdnsAppKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemovePdnsAppKeyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除公共DNS Udp Ip地址段
         *
         * @param request RemovePdnsUdpIpSegmentRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemovePdnsUdpIpSegmentResponse
         */
        public RemovePdnsUdpIpSegmentResponse RemovePdnsUdpIpSegmentWithOptions(RemovePdnsUdpIpSegmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemovePdnsUdpIpSegment",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemovePdnsUdpIpSegmentResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除公共DNS Udp Ip地址段
         *
         * @param request RemovePdnsUdpIpSegmentRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemovePdnsUdpIpSegmentResponse
         */
        public async Task<RemovePdnsUdpIpSegmentResponse> RemovePdnsUdpIpSegmentWithOptionsAsync(RemovePdnsUdpIpSegmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemovePdnsUdpIpSegment",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemovePdnsUdpIpSegmentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除公共DNS Udp Ip地址段
         *
         * @param request RemovePdnsUdpIpSegmentRequest
         * @return RemovePdnsUdpIpSegmentResponse
         */
        public RemovePdnsUdpIpSegmentResponse RemovePdnsUdpIpSegment(RemovePdnsUdpIpSegmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemovePdnsUdpIpSegmentWithOptions(request, runtime);
        }

        /**
         * @summary 删除公共DNS Udp Ip地址段
         *
         * @param request RemovePdnsUdpIpSegmentRequest
         * @return RemovePdnsUdpIpSegmentResponse
         */
        public async Task<RemovePdnsUdpIpSegmentResponse> RemovePdnsUdpIpSegmentAsync(RemovePdnsUdpIpSegmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemovePdnsUdpIpSegmentWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 恢复公共DNS服务
         *
         * @param request ResumePdnsServiceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ResumePdnsServiceResponse
         */
        public ResumePdnsServiceResponse ResumePdnsServiceWithOptions(ResumePdnsServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceType))
            {
                query["ServiceType"] = request.ServiceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResumePdnsService",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResumePdnsServiceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 恢复公共DNS服务
         *
         * @param request ResumePdnsServiceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ResumePdnsServiceResponse
         */
        public async Task<ResumePdnsServiceResponse> ResumePdnsServiceWithOptionsAsync(ResumePdnsServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceType))
            {
                query["ServiceType"] = request.ServiceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResumePdnsService",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResumePdnsServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 恢复公共DNS服务
         *
         * @param request ResumePdnsServiceRequest
         * @return ResumePdnsServiceResponse
         */
        public ResumePdnsServiceResponse ResumePdnsService(ResumePdnsServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResumePdnsServiceWithOptions(request, runtime);
        }

        /**
         * @summary 恢复公共DNS服务
         *
         * @param request ResumePdnsServiceRequest
         * @return ResumePdnsServiceResponse
         */
        public async Task<ResumePdnsServiceResponse> ResumePdnsServiceAsync(ResumePdnsServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResumePdnsServiceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Retrieves a domain name.
         *
         * @description To retrieve a domain name, you must verify a text (TXT) record. Therefore, before you call this API operation to retrieve a domain name, call the [GetTxtRecordForVerify](https://www.alibabacloud.com/help/zh/alibaba-cloud-dns/latest/generating-a-txt-record) operation to generate a TXT record.
         *
         * @param request RetrieveDomainRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RetrieveDomainResponse
         */
        public RetrieveDomainResponse RetrieveDomainWithOptions(RetrieveDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RetrieveDomain",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RetrieveDomainResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Retrieves a domain name.
         *
         * @description To retrieve a domain name, you must verify a text (TXT) record. Therefore, before you call this API operation to retrieve a domain name, call the [GetTxtRecordForVerify](https://www.alibabacloud.com/help/zh/alibaba-cloud-dns/latest/generating-a-txt-record) operation to generate a TXT record.
         *
         * @param request RetrieveDomainRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RetrieveDomainResponse
         */
        public async Task<RetrieveDomainResponse> RetrieveDomainWithOptionsAsync(RetrieveDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RetrieveDomain",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RetrieveDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Retrieves a domain name.
         *
         * @description To retrieve a domain name, you must verify a text (TXT) record. Therefore, before you call this API operation to retrieve a domain name, call the [GetTxtRecordForVerify](https://www.alibabacloud.com/help/zh/alibaba-cloud-dns/latest/generating-a-txt-record) operation to generate a TXT record.
         *
         * @param request RetrieveDomainRequest
         * @return RetrieveDomainResponse
         */
        public RetrieveDomainResponse RetrieveDomain(RetrieveDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RetrieveDomainWithOptions(request, runtime);
        }

        /**
         * @summary Retrieves a domain name.
         *
         * @description To retrieve a domain name, you must verify a text (TXT) record. Therefore, before you call this API operation to retrieve a domain name, call the [GetTxtRecordForVerify](https://www.alibabacloud.com/help/zh/alibaba-cloud-dns/latest/generating-a-txt-record) operation to generate a TXT record.
         *
         * @param request RetrieveDomainRequest
         * @return RetrieveDomainResponse
         */
        public async Task<RetrieveDomainResponse> RetrieveDomainAsync(RetrieveDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RetrieveDomainWithOptionsAsync(request, runtime);
        }

        /**
         * @param request RollbackGtmRecoveryPlanRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RollbackGtmRecoveryPlanResponse
         */
        public RollbackGtmRecoveryPlanResponse RollbackGtmRecoveryPlanWithOptions(RollbackGtmRecoveryPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryPlanId))
            {
                query["RecoveryPlanId"] = request.RecoveryPlanId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RollbackGtmRecoveryPlan",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RollbackGtmRecoveryPlanResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request RollbackGtmRecoveryPlanRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RollbackGtmRecoveryPlanResponse
         */
        public async Task<RollbackGtmRecoveryPlanResponse> RollbackGtmRecoveryPlanWithOptionsAsync(RollbackGtmRecoveryPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryPlanId))
            {
                query["RecoveryPlanId"] = request.RecoveryPlanId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RollbackGtmRecoveryPlan",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RollbackGtmRecoveryPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request RollbackGtmRecoveryPlanRequest
         * @return RollbackGtmRecoveryPlanResponse
         */
        public RollbackGtmRecoveryPlanResponse RollbackGtmRecoveryPlan(RollbackGtmRecoveryPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RollbackGtmRecoveryPlanWithOptions(request, runtime);
        }

        /**
         * @param request RollbackGtmRecoveryPlanRequest
         * @return RollbackGtmRecoveryPlanResponse
         */
        public async Task<RollbackGtmRecoveryPlanResponse> RollbackGtmRecoveryPlanAsync(RollbackGtmRecoveryPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RollbackGtmRecoveryPlanWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Enables or disables weighted round-robin based on the specified parameters.
         *
         * @param request SetDNSSLBStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetDNSSLBStatusResponse
         */
        public SetDNSSLBStatusResponse SetDNSSLBStatusWithOptions(SetDNSSLBStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Line))
            {
                query["Line"] = request.Line;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Open))
            {
                query["Open"] = request.Open;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubDomain))
            {
                query["SubDomain"] = request.SubDomain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetDNSSLBStatus",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetDNSSLBStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Enables or disables weighted round-robin based on the specified parameters.
         *
         * @param request SetDNSSLBStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetDNSSLBStatusResponse
         */
        public async Task<SetDNSSLBStatusResponse> SetDNSSLBStatusWithOptionsAsync(SetDNSSLBStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Line))
            {
                query["Line"] = request.Line;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Open))
            {
                query["Open"] = request.Open;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubDomain))
            {
                query["SubDomain"] = request.SubDomain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetDNSSLBStatus",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetDNSSLBStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Enables or disables weighted round-robin based on the specified parameters.
         *
         * @param request SetDNSSLBStatusRequest
         * @return SetDNSSLBStatusResponse
         */
        public SetDNSSLBStatusResponse SetDNSSLBStatus(SetDNSSLBStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetDNSSLBStatusWithOptions(request, runtime);
        }

        /**
         * @summary Enables or disables weighted round-robin based on the specified parameters.
         *
         * @param request SetDNSSLBStatusRequest
         * @return SetDNSSLBStatusResponse
         */
        public async Task<SetDNSSLBStatusResponse> SetDNSSLBStatusAsync(SetDNSSLBStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetDNSSLBStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @description ****
         *
         * @param request SetDnsGtmAccessModeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetDnsGtmAccessModeResponse
         */
        public SetDnsGtmAccessModeResponse SetDnsGtmAccessModeWithOptions(SetDnsGtmAccessModeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessMode))
            {
                query["AccessMode"] = request.AccessMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyId))
            {
                query["StrategyId"] = request.StrategyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetDnsGtmAccessMode",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetDnsGtmAccessModeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @description ****
         *
         * @param request SetDnsGtmAccessModeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetDnsGtmAccessModeResponse
         */
        public async Task<SetDnsGtmAccessModeResponse> SetDnsGtmAccessModeWithOptionsAsync(SetDnsGtmAccessModeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessMode))
            {
                query["AccessMode"] = request.AccessMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyId))
            {
                query["StrategyId"] = request.StrategyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetDnsGtmAccessMode",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetDnsGtmAccessModeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @description ****
         *
         * @param request SetDnsGtmAccessModeRequest
         * @return SetDnsGtmAccessModeResponse
         */
        public SetDnsGtmAccessModeResponse SetDnsGtmAccessMode(SetDnsGtmAccessModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetDnsGtmAccessModeWithOptions(request, runtime);
        }

        /**
         * @description ****
         *
         * @param request SetDnsGtmAccessModeRequest
         * @return SetDnsGtmAccessModeResponse
         */
        public async Task<SetDnsGtmAccessModeResponse> SetDnsGtmAccessModeAsync(SetDnsGtmAccessModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetDnsGtmAccessModeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Specifies the health check status of an address pool.
         *
         * @param request SetDnsGtmMonitorStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetDnsGtmMonitorStatusResponse
         */
        public SetDnsGtmMonitorStatusResponse SetDnsGtmMonitorStatusWithOptions(SetDnsGtmMonitorStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MonitorConfigId))
            {
                query["MonitorConfigId"] = request.MonitorConfigId;
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
                Action = "SetDnsGtmMonitorStatus",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetDnsGtmMonitorStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Specifies the health check status of an address pool.
         *
         * @param request SetDnsGtmMonitorStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetDnsGtmMonitorStatusResponse
         */
        public async Task<SetDnsGtmMonitorStatusResponse> SetDnsGtmMonitorStatusWithOptionsAsync(SetDnsGtmMonitorStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MonitorConfigId))
            {
                query["MonitorConfigId"] = request.MonitorConfigId;
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
                Action = "SetDnsGtmMonitorStatus",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetDnsGtmMonitorStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Specifies the health check status of an address pool.
         *
         * @param request SetDnsGtmMonitorStatusRequest
         * @return SetDnsGtmMonitorStatusResponse
         */
        public SetDnsGtmMonitorStatusResponse SetDnsGtmMonitorStatus(SetDnsGtmMonitorStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetDnsGtmMonitorStatusWithOptions(request, runtime);
        }

        /**
         * @summary Specifies the health check status of an address pool.
         *
         * @param request SetDnsGtmMonitorStatusRequest
         * @return SetDnsGtmMonitorStatusResponse
         */
        public async Task<SetDnsGtmMonitorStatusResponse> SetDnsGtmMonitorStatusAsync(SetDnsGtmMonitorStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetDnsGtmMonitorStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Sets the Domain Name System Security Extensions (DNSSEC) status of a domain name.
         *
         * @param request SetDomainDnssecStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetDomainDnssecStatusResponse
         */
        public SetDomainDnssecStatusResponse SetDomainDnssecStatusWithOptions(SetDomainDnssecStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
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
                Action = "SetDomainDnssecStatus",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetDomainDnssecStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Sets the Domain Name System Security Extensions (DNSSEC) status of a domain name.
         *
         * @param request SetDomainDnssecStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetDomainDnssecStatusResponse
         */
        public async Task<SetDomainDnssecStatusResponse> SetDomainDnssecStatusWithOptionsAsync(SetDomainDnssecStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
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
                Action = "SetDomainDnssecStatus",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetDomainDnssecStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Sets the Domain Name System Security Extensions (DNSSEC) status of a domain name.
         *
         * @param request SetDomainDnssecStatusRequest
         * @return SetDomainDnssecStatusResponse
         */
        public SetDomainDnssecStatusResponse SetDomainDnssecStatus(SetDomainDnssecStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetDomainDnssecStatusWithOptions(request, runtime);
        }

        /**
         * @summary Sets the Domain Name System Security Extensions (DNSSEC) status of a domain name.
         *
         * @param request SetDomainDnssecStatusRequest
         * @return SetDomainDnssecStatusResponse
         */
        public async Task<SetDomainDnssecStatusResponse> SetDomainDnssecStatusAsync(SetDomainDnssecStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetDomainDnssecStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Specifies the status of a Domain Name System (DNS) record based on the specified parameters.
         *
         * @param request SetDomainRecordStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetDomainRecordStatusResponse
         */
        public SetDomainRecordStatusResponse SetDomainRecordStatusWithOptions(SetDomainRecordStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordId))
            {
                query["RecordId"] = request.RecordId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetDomainRecordStatus",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetDomainRecordStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Specifies the status of a Domain Name System (DNS) record based on the specified parameters.
         *
         * @param request SetDomainRecordStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetDomainRecordStatusResponse
         */
        public async Task<SetDomainRecordStatusResponse> SetDomainRecordStatusWithOptionsAsync(SetDomainRecordStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordId))
            {
                query["RecordId"] = request.RecordId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetDomainRecordStatus",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetDomainRecordStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Specifies the status of a Domain Name System (DNS) record based on the specified parameters.
         *
         * @param request SetDomainRecordStatusRequest
         * @return SetDomainRecordStatusResponse
         */
        public SetDomainRecordStatusResponse SetDomainRecordStatus(SetDomainRecordStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetDomainRecordStatusWithOptions(request, runtime);
        }

        /**
         * @summary Specifies the status of a Domain Name System (DNS) record based on the specified parameters.
         *
         * @param request SetDomainRecordStatusRequest
         * @return SetDomainRecordStatusResponse
         */
        public async Task<SetDomainRecordStatusResponse> SetDomainRecordStatusAsync(SetDomainRecordStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetDomainRecordStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @param request SetGtmAccessModeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetGtmAccessModeResponse
         */
        public SetGtmAccessModeResponse SetGtmAccessModeWithOptions(SetGtmAccessModeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessMode))
            {
                query["AccessMode"] = request.AccessMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyId))
            {
                query["StrategyId"] = request.StrategyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetGtmAccessMode",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetGtmAccessModeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request SetGtmAccessModeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetGtmAccessModeResponse
         */
        public async Task<SetGtmAccessModeResponse> SetGtmAccessModeWithOptionsAsync(SetGtmAccessModeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessMode))
            {
                query["AccessMode"] = request.AccessMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyId))
            {
                query["StrategyId"] = request.StrategyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetGtmAccessMode",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetGtmAccessModeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request SetGtmAccessModeRequest
         * @return SetGtmAccessModeResponse
         */
        public SetGtmAccessModeResponse SetGtmAccessMode(SetGtmAccessModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetGtmAccessModeWithOptions(request, runtime);
        }

        /**
         * @param request SetGtmAccessModeRequest
         * @return SetGtmAccessModeResponse
         */
        public async Task<SetGtmAccessModeResponse> SetGtmAccessModeAsync(SetGtmAccessModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetGtmAccessModeWithOptionsAsync(request, runtime);
        }

        /**
         * @param request SetGtmMonitorStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetGtmMonitorStatusResponse
         */
        public SetGtmMonitorStatusResponse SetGtmMonitorStatusWithOptions(SetGtmMonitorStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MonitorConfigId))
            {
                query["MonitorConfigId"] = request.MonitorConfigId;
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
                Action = "SetGtmMonitorStatus",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetGtmMonitorStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request SetGtmMonitorStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetGtmMonitorStatusResponse
         */
        public async Task<SetGtmMonitorStatusResponse> SetGtmMonitorStatusWithOptionsAsync(SetGtmMonitorStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MonitorConfigId))
            {
                query["MonitorConfigId"] = request.MonitorConfigId;
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
                Action = "SetGtmMonitorStatus",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetGtmMonitorStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request SetGtmMonitorStatusRequest
         * @return SetGtmMonitorStatusResponse
         */
        public SetGtmMonitorStatusResponse SetGtmMonitorStatus(SetGtmMonitorStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetGtmMonitorStatusWithOptions(request, runtime);
        }

        /**
         * @param request SetGtmMonitorStatusRequest
         * @return SetGtmMonitorStatusResponse
         */
        public async Task<SetGtmMonitorStatusResponse> SetGtmMonitorStatusAsync(SetGtmMonitorStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetGtmMonitorStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 提交缓存刷新任务
         *
         * @param request SubmitIspFlushCacheTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitIspFlushCacheTaskResponse
         */
        public SubmitIspFlushCacheTaskResponse SubmitIspFlushCacheTaskWithOptions(SubmitIspFlushCacheTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Isp))
            {
                query["Isp"] = request.Isp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitIspFlushCacheTask",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitIspFlushCacheTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 提交缓存刷新任务
         *
         * @param request SubmitIspFlushCacheTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitIspFlushCacheTaskResponse
         */
        public async Task<SubmitIspFlushCacheTaskResponse> SubmitIspFlushCacheTaskWithOptionsAsync(SubmitIspFlushCacheTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Isp))
            {
                query["Isp"] = request.Isp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitIspFlushCacheTask",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitIspFlushCacheTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 提交缓存刷新任务
         *
         * @param request SubmitIspFlushCacheTaskRequest
         * @return SubmitIspFlushCacheTaskResponse
         */
        public SubmitIspFlushCacheTaskResponse SubmitIspFlushCacheTask(SubmitIspFlushCacheTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitIspFlushCacheTaskWithOptions(request, runtime);
        }

        /**
         * @summary 提交缓存刷新任务
         *
         * @param request SubmitIspFlushCacheTaskRequest
         * @return SubmitIspFlushCacheTaskResponse
         */
        public async Task<SubmitIspFlushCacheTaskResponse> SubmitIspFlushCacheTaskAsync(SubmitIspFlushCacheTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitIspFlushCacheTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Changes the access policy type for a Global Traffic Manager (GTM) instance.
         *
         * @param request SwitchDnsGtmInstanceStrategyModeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SwitchDnsGtmInstanceStrategyModeResponse
         */
        public SwitchDnsGtmInstanceStrategyModeResponse SwitchDnsGtmInstanceStrategyModeWithOptions(SwitchDnsGtmInstanceStrategyModeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyMode))
            {
                query["StrategyMode"] = request.StrategyMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SwitchDnsGtmInstanceStrategyMode",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SwitchDnsGtmInstanceStrategyModeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Changes the access policy type for a Global Traffic Manager (GTM) instance.
         *
         * @param request SwitchDnsGtmInstanceStrategyModeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SwitchDnsGtmInstanceStrategyModeResponse
         */
        public async Task<SwitchDnsGtmInstanceStrategyModeResponse> SwitchDnsGtmInstanceStrategyModeWithOptionsAsync(SwitchDnsGtmInstanceStrategyModeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyMode))
            {
                query["StrategyMode"] = request.StrategyMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SwitchDnsGtmInstanceStrategyMode",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SwitchDnsGtmInstanceStrategyModeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Changes the access policy type for a Global Traffic Manager (GTM) instance.
         *
         * @param request SwitchDnsGtmInstanceStrategyModeRequest
         * @return SwitchDnsGtmInstanceStrategyModeResponse
         */
        public SwitchDnsGtmInstanceStrategyModeResponse SwitchDnsGtmInstanceStrategyMode(SwitchDnsGtmInstanceStrategyModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SwitchDnsGtmInstanceStrategyModeWithOptions(request, runtime);
        }

        /**
         * @summary Changes the access policy type for a Global Traffic Manager (GTM) instance.
         *
         * @param request SwitchDnsGtmInstanceStrategyModeRequest
         * @return SwitchDnsGtmInstanceStrategyModeResponse
         */
        public async Task<SwitchDnsGtmInstanceStrategyModeResponse> SwitchDnsGtmInstanceStrategyModeAsync(SwitchDnsGtmInstanceStrategyModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SwitchDnsGtmInstanceStrategyModeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Adds and modifies a tag for a resource.
         *
         * @param request TagResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return TagResourcesResponse
         */
        public TagResourcesResponse TagResourcesWithOptions(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagResources",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TagResourcesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Adds and modifies a tag for a resource.
         *
         * @param request TagResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return TagResourcesResponse
         */
        public async Task<TagResourcesResponse> TagResourcesWithOptionsAsync(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagResources",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TagResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Adds and modifies a tag for a resource.
         *
         * @param request TagResourcesRequest
         * @return TagResourcesResponse
         */
        public TagResourcesResponse TagResources(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TagResourcesWithOptions(request, runtime);
        }

        /**
         * @summary Adds and modifies a tag for a resource.
         *
         * @param request TagResourcesRequest
         * @return TagResourcesResponse
         */
        public async Task<TagResourcesResponse> TagResourcesAsync(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TagResourcesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Transfers multiple domain names from the current account to another account at a time.
         *
         * @param request TransferDomainRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return TransferDomainResponse
         */
        public TransferDomainResponse TransferDomainWithOptions(TransferDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainNames))
            {
                query["DomainNames"] = request.DomainNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetUserId))
            {
                query["TargetUserId"] = request.TargetUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TransferDomain",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TransferDomainResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Transfers multiple domain names from the current account to another account at a time.
         *
         * @param request TransferDomainRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return TransferDomainResponse
         */
        public async Task<TransferDomainResponse> TransferDomainWithOptionsAsync(TransferDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainNames))
            {
                query["DomainNames"] = request.DomainNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetUserId))
            {
                query["TargetUserId"] = request.TargetUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TransferDomain",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TransferDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Transfers multiple domain names from the current account to another account at a time.
         *
         * @param request TransferDomainRequest
         * @return TransferDomainResponse
         */
        public TransferDomainResponse TransferDomain(TransferDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TransferDomainWithOptions(request, runtime);
        }

        /**
         * @summary Transfers multiple domain names from the current account to another account at a time.
         *
         * @param request TransferDomainRequest
         * @return TransferDomainResponse
         */
        public async Task<TransferDomainResponse> TransferDomainAsync(TransferDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TransferDomainWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Unbinds one or more domain names from a paid Alibaba Cloud DNS instance based on the instance ID.
         *
         * @description A paid Alibaba Cloud DNS instance whose ID starts with dns is an instance of the new version. You can call an API operation to bind multiple domain names to the instance. If the upper limit is exceeded, an error message is returned.\\
         * A paid Alibaba Cloud DNS instance whose ID does not start with dns is an instance of the old version. You can call an API operation to bind only one domain name to the instance. However, if the instance that you want to bind to the desired domain name is already bound to a domain name, you can call this operation to unbind the original domain name from the instance and then bind the desired domain name to the instance.
         *
         * @param request UnbindInstanceDomainsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UnbindInstanceDomainsResponse
         */
        public UnbindInstanceDomainsResponse UnbindInstanceDomainsWithOptions(UnbindInstanceDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainNames))
            {
                query["DomainNames"] = request.DomainNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnbindInstanceDomains",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindInstanceDomainsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Unbinds one or more domain names from a paid Alibaba Cloud DNS instance based on the instance ID.
         *
         * @description A paid Alibaba Cloud DNS instance whose ID starts with dns is an instance of the new version. You can call an API operation to bind multiple domain names to the instance. If the upper limit is exceeded, an error message is returned.\\
         * A paid Alibaba Cloud DNS instance whose ID does not start with dns is an instance of the old version. You can call an API operation to bind only one domain name to the instance. However, if the instance that you want to bind to the desired domain name is already bound to a domain name, you can call this operation to unbind the original domain name from the instance and then bind the desired domain name to the instance.
         *
         * @param request UnbindInstanceDomainsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UnbindInstanceDomainsResponse
         */
        public async Task<UnbindInstanceDomainsResponse> UnbindInstanceDomainsWithOptionsAsync(UnbindInstanceDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainNames))
            {
                query["DomainNames"] = request.DomainNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnbindInstanceDomains",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindInstanceDomainsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Unbinds one or more domain names from a paid Alibaba Cloud DNS instance based on the instance ID.
         *
         * @description A paid Alibaba Cloud DNS instance whose ID starts with dns is an instance of the new version. You can call an API operation to bind multiple domain names to the instance. If the upper limit is exceeded, an error message is returned.\\
         * A paid Alibaba Cloud DNS instance whose ID does not start with dns is an instance of the old version. You can call an API operation to bind only one domain name to the instance. However, if the instance that you want to bind to the desired domain name is already bound to a domain name, you can call this operation to unbind the original domain name from the instance and then bind the desired domain name to the instance.
         *
         * @param request UnbindInstanceDomainsRequest
         * @return UnbindInstanceDomainsResponse
         */
        public UnbindInstanceDomainsResponse UnbindInstanceDomains(UnbindInstanceDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnbindInstanceDomainsWithOptions(request, runtime);
        }

        /**
         * @summary Unbinds one or more domain names from a paid Alibaba Cloud DNS instance based on the instance ID.
         *
         * @description A paid Alibaba Cloud DNS instance whose ID starts with dns is an instance of the new version. You can call an API operation to bind multiple domain names to the instance. If the upper limit is exceeded, an error message is returned.\\
         * A paid Alibaba Cloud DNS instance whose ID does not start with dns is an instance of the old version. You can call an API operation to bind only one domain name to the instance. However, if the instance that you want to bind to the desired domain name is already bound to a domain name, you can call this operation to unbind the original domain name from the instance and then bind the desired domain name to the instance.
         *
         * @param request UnbindInstanceDomainsRequest
         * @return UnbindInstanceDomainsResponse
         */
        public async Task<UnbindInstanceDomainsResponse> UnbindInstanceDomainsAsync(UnbindInstanceDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnbindInstanceDomainsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Removes tags from resources.
         *
         * @param request UntagResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UntagResourcesResponse
         */
        public UntagResourcesResponse UntagResourcesWithOptions(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["All"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKey))
            {
                query["TagKey"] = request.TagKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UntagResources",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UntagResourcesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Removes tags from resources.
         *
         * @param request UntagResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UntagResourcesResponse
         */
        public async Task<UntagResourcesResponse> UntagResourcesWithOptionsAsync(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["All"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKey))
            {
                query["TagKey"] = request.TagKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UntagResources",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UntagResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Removes tags from resources.
         *
         * @param request UntagResourcesRequest
         * @return UntagResourcesResponse
         */
        public UntagResourcesResponse UntagResources(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UntagResourcesWithOptions(request, runtime);
        }

        /**
         * @summary Removes tags from resources.
         *
         * @param request UntagResourcesRequest
         * @return UntagResourcesResponse
         */
        public async Task<UntagResourcesResponse> UntagResourcesAsync(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UntagResourcesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 修改 AppKey 状态
         *
         * @param request UpdateAppKeyStateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateAppKeyStateResponse
         */
        public UpdateAppKeyStateResponse UpdateAppKeyStateWithOptions(UpdateAppKeyStateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKeyId))
            {
                query["AppKeyId"] = request.AppKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                query["State"] = request.State;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAppKeyState",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAppKeyStateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 修改 AppKey 状态
         *
         * @param request UpdateAppKeyStateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateAppKeyStateResponse
         */
        public async Task<UpdateAppKeyStateResponse> UpdateAppKeyStateWithOptionsAsync(UpdateAppKeyStateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKeyId))
            {
                query["AppKeyId"] = request.AppKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                query["State"] = request.State;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAppKeyState",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAppKeyStateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 修改 AppKey 状态
         *
         * @param request UpdateAppKeyStateRequest
         * @return UpdateAppKeyStateResponse
         */
        public UpdateAppKeyStateResponse UpdateAppKeyState(UpdateAppKeyStateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAppKeyStateWithOptions(request, runtime);
        }

        /**
         * @summary 修改 AppKey 状态
         *
         * @param request UpdateAppKeyStateRequest
         * @return UpdateAppKeyStateResponse
         */
        public async Task<UpdateAppKeyStateResponse> UpdateAppKeyStateAsync(UpdateAppKeyStateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAppKeyStateWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies a custom line.
         *
         * @description In each CIDR block, the end IP address must be greater than or equal to the start IP address.\\
         * The CIDR blocks that are specified for all custom lines of a domain name cannot be overlapped.
         *
         * @param request UpdateCustomLineRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateCustomLineResponse
         */
        public UpdateCustomLineResponse UpdateCustomLineWithOptions(UpdateCustomLineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpSegment))
            {
                query["IpSegment"] = request.IpSegment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LineId))
            {
                query["LineId"] = request.LineId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LineName))
            {
                query["LineName"] = request.LineName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateCustomLine",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCustomLineResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies a custom line.
         *
         * @description In each CIDR block, the end IP address must be greater than or equal to the start IP address.\\
         * The CIDR blocks that are specified for all custom lines of a domain name cannot be overlapped.
         *
         * @param request UpdateCustomLineRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateCustomLineResponse
         */
        public async Task<UpdateCustomLineResponse> UpdateCustomLineWithOptionsAsync(UpdateCustomLineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpSegment))
            {
                query["IpSegment"] = request.IpSegment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LineId))
            {
                query["LineId"] = request.LineId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LineName))
            {
                query["LineName"] = request.LineName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateCustomLine",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCustomLineResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies a custom line.
         *
         * @description In each CIDR block, the end IP address must be greater than or equal to the start IP address.\\
         * The CIDR blocks that are specified for all custom lines of a domain name cannot be overlapped.
         *
         * @param request UpdateCustomLineRequest
         * @return UpdateCustomLineResponse
         */
        public UpdateCustomLineResponse UpdateCustomLine(UpdateCustomLineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateCustomLineWithOptions(request, runtime);
        }

        /**
         * @summary Modifies a custom line.
         *
         * @description In each CIDR block, the end IP address must be greater than or equal to the start IP address.\\
         * The CIDR blocks that are specified for all custom lines of a domain name cannot be overlapped.
         *
         * @param request UpdateCustomLineRequest
         * @return UpdateCustomLineResponse
         */
        public async Task<UpdateCustomLineResponse> UpdateCustomLineAsync(UpdateCustomLineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateCustomLineWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the weight of a Domain Name System (DNS) record based on the specified parameters.
         *
         * @param request UpdateDNSSLBWeightRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateDNSSLBWeightResponse
         */
        public UpdateDNSSLBWeightResponse UpdateDNSSLBWeightWithOptions(UpdateDNSSLBWeightRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordId))
            {
                query["RecordId"] = request.RecordId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Weight))
            {
                query["Weight"] = request.Weight;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDNSSLBWeight",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDNSSLBWeightResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies the weight of a Domain Name System (DNS) record based on the specified parameters.
         *
         * @param request UpdateDNSSLBWeightRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateDNSSLBWeightResponse
         */
        public async Task<UpdateDNSSLBWeightResponse> UpdateDNSSLBWeightWithOptionsAsync(UpdateDNSSLBWeightRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordId))
            {
                query["RecordId"] = request.RecordId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Weight))
            {
                query["Weight"] = request.Weight;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDNSSLBWeight",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDNSSLBWeightResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies the weight of a Domain Name System (DNS) record based on the specified parameters.
         *
         * @param request UpdateDNSSLBWeightRequest
         * @return UpdateDNSSLBWeightResponse
         */
        public UpdateDNSSLBWeightResponse UpdateDNSSLBWeight(UpdateDNSSLBWeightRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDNSSLBWeightWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the weight of a Domain Name System (DNS) record based on the specified parameters.
         *
         * @param request UpdateDNSSLBWeightRequest
         * @return UpdateDNSSLBWeightResponse
         */
        public async Task<UpdateDNSSLBWeightResponse> UpdateDNSSLBWeightAsync(UpdateDNSSLBWeightRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDNSSLBWeightWithOptionsAsync(request, runtime);
        }

        /**
         * @param request UpdateDnsCacheDomainRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateDnsCacheDomainResponse
         */
        public UpdateDnsCacheDomainResponse UpdateDnsCacheDomainWithOptions(UpdateDnsCacheDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CacheTtlMax))
            {
                query["CacheTtlMax"] = request.CacheTtlMax;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CacheTtlMin))
            {
                query["CacheTtlMin"] = request.CacheTtlMin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceDnsServer))
            {
                query["SourceDnsServer"] = request.SourceDnsServer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEdns))
            {
                query["SourceEdns"] = request.SourceEdns;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceProtocol))
            {
                query["SourceProtocol"] = request.SourceProtocol;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDnsCacheDomain",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDnsCacheDomainResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request UpdateDnsCacheDomainRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateDnsCacheDomainResponse
         */
        public async Task<UpdateDnsCacheDomainResponse> UpdateDnsCacheDomainWithOptionsAsync(UpdateDnsCacheDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CacheTtlMax))
            {
                query["CacheTtlMax"] = request.CacheTtlMax;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CacheTtlMin))
            {
                query["CacheTtlMin"] = request.CacheTtlMin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceDnsServer))
            {
                query["SourceDnsServer"] = request.SourceDnsServer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEdns))
            {
                query["SourceEdns"] = request.SourceEdns;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceProtocol))
            {
                query["SourceProtocol"] = request.SourceProtocol;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDnsCacheDomain",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDnsCacheDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request UpdateDnsCacheDomainRequest
         * @return UpdateDnsCacheDomainResponse
         */
        public UpdateDnsCacheDomainResponse UpdateDnsCacheDomain(UpdateDnsCacheDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDnsCacheDomainWithOptions(request, runtime);
        }

        /**
         * @param request UpdateDnsCacheDomainRequest
         * @return UpdateDnsCacheDomainResponse
         */
        public async Task<UpdateDnsCacheDomainResponse> UpdateDnsCacheDomainAsync(UpdateDnsCacheDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDnsCacheDomainWithOptionsAsync(request, runtime);
        }

        /**
         * @param request UpdateDnsCacheDomainRemarkRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateDnsCacheDomainRemarkResponse
         */
        public UpdateDnsCacheDomainRemarkResponse UpdateDnsCacheDomainRemarkWithOptions(UpdateDnsCacheDomainRemarkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDnsCacheDomainRemark",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDnsCacheDomainRemarkResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request UpdateDnsCacheDomainRemarkRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateDnsCacheDomainRemarkResponse
         */
        public async Task<UpdateDnsCacheDomainRemarkResponse> UpdateDnsCacheDomainRemarkWithOptionsAsync(UpdateDnsCacheDomainRemarkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDnsCacheDomainRemark",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDnsCacheDomainRemarkResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request UpdateDnsCacheDomainRemarkRequest
         * @return UpdateDnsCacheDomainRemarkResponse
         */
        public UpdateDnsCacheDomainRemarkResponse UpdateDnsCacheDomainRemark(UpdateDnsCacheDomainRemarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDnsCacheDomainRemarkWithOptions(request, runtime);
        }

        /**
         * @param request UpdateDnsCacheDomainRemarkRequest
         * @return UpdateDnsCacheDomainRemarkResponse
         */
        public async Task<UpdateDnsCacheDomainRemarkResponse> UpdateDnsCacheDomainRemarkAsync(UpdateDnsCacheDomainRemarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDnsCacheDomainRemarkWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies an access policy.
         *
         * @param request UpdateDnsGtmAccessStrategyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateDnsGtmAccessStrategyResponse
         */
        public UpdateDnsGtmAccessStrategyResponse UpdateDnsGtmAccessStrategyWithOptions(UpdateDnsGtmAccessStrategyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessMode))
            {
                query["AccessMode"] = request.AccessMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultAddrPool))
            {
                query["DefaultAddrPool"] = request.DefaultAddrPool;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultAddrPoolType))
            {
                query["DefaultAddrPoolType"] = request.DefaultAddrPoolType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultLatencyOptimization))
            {
                query["DefaultLatencyOptimization"] = request.DefaultLatencyOptimization;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultLbaStrategy))
            {
                query["DefaultLbaStrategy"] = request.DefaultLbaStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultMaxReturnAddrNum))
            {
                query["DefaultMaxReturnAddrNum"] = request.DefaultMaxReturnAddrNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultMinAvailableAddrNum))
            {
                query["DefaultMinAvailableAddrNum"] = request.DefaultMinAvailableAddrNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FailoverAddrPool))
            {
                query["FailoverAddrPool"] = request.FailoverAddrPool;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FailoverAddrPoolType))
            {
                query["FailoverAddrPoolType"] = request.FailoverAddrPoolType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FailoverLatencyOptimization))
            {
                query["FailoverLatencyOptimization"] = request.FailoverLatencyOptimization;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FailoverLbaStrategy))
            {
                query["FailoverLbaStrategy"] = request.FailoverLbaStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FailoverMaxReturnAddrNum))
            {
                query["FailoverMaxReturnAddrNum"] = request.FailoverMaxReturnAddrNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FailoverMinAvailableAddrNum))
            {
                query["FailoverMinAvailableAddrNum"] = request.FailoverMinAvailableAddrNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lines))
            {
                query["Lines"] = request.Lines;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyId))
            {
                query["StrategyId"] = request.StrategyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyName))
            {
                query["StrategyName"] = request.StrategyName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDnsGtmAccessStrategy",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDnsGtmAccessStrategyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies an access policy.
         *
         * @param request UpdateDnsGtmAccessStrategyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateDnsGtmAccessStrategyResponse
         */
        public async Task<UpdateDnsGtmAccessStrategyResponse> UpdateDnsGtmAccessStrategyWithOptionsAsync(UpdateDnsGtmAccessStrategyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessMode))
            {
                query["AccessMode"] = request.AccessMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultAddrPool))
            {
                query["DefaultAddrPool"] = request.DefaultAddrPool;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultAddrPoolType))
            {
                query["DefaultAddrPoolType"] = request.DefaultAddrPoolType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultLatencyOptimization))
            {
                query["DefaultLatencyOptimization"] = request.DefaultLatencyOptimization;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultLbaStrategy))
            {
                query["DefaultLbaStrategy"] = request.DefaultLbaStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultMaxReturnAddrNum))
            {
                query["DefaultMaxReturnAddrNum"] = request.DefaultMaxReturnAddrNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultMinAvailableAddrNum))
            {
                query["DefaultMinAvailableAddrNum"] = request.DefaultMinAvailableAddrNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FailoverAddrPool))
            {
                query["FailoverAddrPool"] = request.FailoverAddrPool;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FailoverAddrPoolType))
            {
                query["FailoverAddrPoolType"] = request.FailoverAddrPoolType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FailoverLatencyOptimization))
            {
                query["FailoverLatencyOptimization"] = request.FailoverLatencyOptimization;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FailoverLbaStrategy))
            {
                query["FailoverLbaStrategy"] = request.FailoverLbaStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FailoverMaxReturnAddrNum))
            {
                query["FailoverMaxReturnAddrNum"] = request.FailoverMaxReturnAddrNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FailoverMinAvailableAddrNum))
            {
                query["FailoverMinAvailableAddrNum"] = request.FailoverMinAvailableAddrNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lines))
            {
                query["Lines"] = request.Lines;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyId))
            {
                query["StrategyId"] = request.StrategyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyName))
            {
                query["StrategyName"] = request.StrategyName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDnsGtmAccessStrategy",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDnsGtmAccessStrategyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies an access policy.
         *
         * @param request UpdateDnsGtmAccessStrategyRequest
         * @return UpdateDnsGtmAccessStrategyResponse
         */
        public UpdateDnsGtmAccessStrategyResponse UpdateDnsGtmAccessStrategy(UpdateDnsGtmAccessStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDnsGtmAccessStrategyWithOptions(request, runtime);
        }

        /**
         * @summary Modifies an access policy.
         *
         * @param request UpdateDnsGtmAccessStrategyRequest
         * @return UpdateDnsGtmAccessStrategyResponse
         */
        public async Task<UpdateDnsGtmAccessStrategyResponse> UpdateDnsGtmAccessStrategyAsync(UpdateDnsGtmAccessStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDnsGtmAccessStrategyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the configurations of address pools for a GTM instance.
         *
         * @param request UpdateDnsGtmAddressPoolRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateDnsGtmAddressPoolResponse
         */
        public UpdateDnsGtmAddressPoolResponse UpdateDnsGtmAddressPoolWithOptions(UpdateDnsGtmAddressPoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Addr))
            {
                query["Addr"] = request.Addr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddrPoolId))
            {
                query["AddrPoolId"] = request.AddrPoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LbaStrategy))
            {
                query["LbaStrategy"] = request.LbaStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDnsGtmAddressPool",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDnsGtmAddressPoolResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies the configurations of address pools for a GTM instance.
         *
         * @param request UpdateDnsGtmAddressPoolRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateDnsGtmAddressPoolResponse
         */
        public async Task<UpdateDnsGtmAddressPoolResponse> UpdateDnsGtmAddressPoolWithOptionsAsync(UpdateDnsGtmAddressPoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Addr))
            {
                query["Addr"] = request.Addr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddrPoolId))
            {
                query["AddrPoolId"] = request.AddrPoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LbaStrategy))
            {
                query["LbaStrategy"] = request.LbaStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDnsGtmAddressPool",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDnsGtmAddressPoolResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies the configurations of address pools for a GTM instance.
         *
         * @param request UpdateDnsGtmAddressPoolRequest
         * @return UpdateDnsGtmAddressPoolResponse
         */
        public UpdateDnsGtmAddressPoolResponse UpdateDnsGtmAddressPool(UpdateDnsGtmAddressPoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDnsGtmAddressPoolWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the configurations of address pools for a GTM instance.
         *
         * @param request UpdateDnsGtmAddressPoolRequest
         * @return UpdateDnsGtmAddressPoolResponse
         */
        public async Task<UpdateDnsGtmAddressPoolResponse> UpdateDnsGtmAddressPoolAsync(UpdateDnsGtmAddressPoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDnsGtmAddressPoolWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the configurations of a Global Traffic Manager (GTM) instance.
         *
         * @param request UpdateDnsGtmInstanceGlobalConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateDnsGtmInstanceGlobalConfigResponse
         */
        public UpdateDnsGtmInstanceGlobalConfigResponse UpdateDnsGtmInstanceGlobalConfigWithOptions(UpdateDnsGtmInstanceGlobalConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertConfig))
            {
                query["AlertConfig"] = request.AlertConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertGroup))
            {
                query["AlertGroup"] = request.AlertGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CnameType))
            {
                query["CnameType"] = request.CnameType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceUpdate))
            {
                query["ForceUpdate"] = request.ForceUpdate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublicCnameMode))
            {
                query["PublicCnameMode"] = request.PublicCnameMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublicRr))
            {
                query["PublicRr"] = request.PublicRr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublicUserDomainName))
            {
                query["PublicUserDomainName"] = request.PublicUserDomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublicZoneName))
            {
                query["PublicZoneName"] = request.PublicZoneName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ttl))
            {
                query["Ttl"] = request.Ttl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDnsGtmInstanceGlobalConfig",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDnsGtmInstanceGlobalConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies the configurations of a Global Traffic Manager (GTM) instance.
         *
         * @param request UpdateDnsGtmInstanceGlobalConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateDnsGtmInstanceGlobalConfigResponse
         */
        public async Task<UpdateDnsGtmInstanceGlobalConfigResponse> UpdateDnsGtmInstanceGlobalConfigWithOptionsAsync(UpdateDnsGtmInstanceGlobalConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertConfig))
            {
                query["AlertConfig"] = request.AlertConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertGroup))
            {
                query["AlertGroup"] = request.AlertGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CnameType))
            {
                query["CnameType"] = request.CnameType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceUpdate))
            {
                query["ForceUpdate"] = request.ForceUpdate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublicCnameMode))
            {
                query["PublicCnameMode"] = request.PublicCnameMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublicRr))
            {
                query["PublicRr"] = request.PublicRr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublicUserDomainName))
            {
                query["PublicUserDomainName"] = request.PublicUserDomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublicZoneName))
            {
                query["PublicZoneName"] = request.PublicZoneName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ttl))
            {
                query["Ttl"] = request.Ttl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDnsGtmInstanceGlobalConfig",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDnsGtmInstanceGlobalConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies the configurations of a Global Traffic Manager (GTM) instance.
         *
         * @param request UpdateDnsGtmInstanceGlobalConfigRequest
         * @return UpdateDnsGtmInstanceGlobalConfigResponse
         */
        public UpdateDnsGtmInstanceGlobalConfigResponse UpdateDnsGtmInstanceGlobalConfig(UpdateDnsGtmInstanceGlobalConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDnsGtmInstanceGlobalConfigWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the configurations of a Global Traffic Manager (GTM) instance.
         *
         * @param request UpdateDnsGtmInstanceGlobalConfigRequest
         * @return UpdateDnsGtmInstanceGlobalConfigResponse
         */
        public async Task<UpdateDnsGtmInstanceGlobalConfigResponse> UpdateDnsGtmInstanceGlobalConfigAsync(UpdateDnsGtmInstanceGlobalConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDnsGtmInstanceGlobalConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies a health check task.
         *
         * @param request UpdateDnsGtmMonitorRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateDnsGtmMonitorResponse
         */
        public UpdateDnsGtmMonitorResponse UpdateDnsGtmMonitorWithOptions(UpdateDnsGtmMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EvaluationCount))
            {
                query["EvaluationCount"] = request.EvaluationCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IspCityNode))
            {
                query["IspCityNode"] = request.IspCityNode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MonitorConfigId))
            {
                query["MonitorConfigId"] = request.MonitorConfigId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MonitorExtendInfo))
            {
                query["MonitorExtendInfo"] = request.MonitorExtendInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProtocolType))
            {
                query["ProtocolType"] = request.ProtocolType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                query["Timeout"] = request.Timeout;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDnsGtmMonitor",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDnsGtmMonitorResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies a health check task.
         *
         * @param request UpdateDnsGtmMonitorRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateDnsGtmMonitorResponse
         */
        public async Task<UpdateDnsGtmMonitorResponse> UpdateDnsGtmMonitorWithOptionsAsync(UpdateDnsGtmMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EvaluationCount))
            {
                query["EvaluationCount"] = request.EvaluationCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IspCityNode))
            {
                query["IspCityNode"] = request.IspCityNode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MonitorConfigId))
            {
                query["MonitorConfigId"] = request.MonitorConfigId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MonitorExtendInfo))
            {
                query["MonitorExtendInfo"] = request.MonitorExtendInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProtocolType))
            {
                query["ProtocolType"] = request.ProtocolType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                query["Timeout"] = request.Timeout;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDnsGtmMonitor",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDnsGtmMonitorResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies a health check task.
         *
         * @param request UpdateDnsGtmMonitorRequest
         * @return UpdateDnsGtmMonitorResponse
         */
        public UpdateDnsGtmMonitorResponse UpdateDnsGtmMonitor(UpdateDnsGtmMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDnsGtmMonitorWithOptions(request, runtime);
        }

        /**
         * @summary Modifies a health check task.
         *
         * @param request UpdateDnsGtmMonitorRequest
         * @return UpdateDnsGtmMonitorResponse
         */
        public async Task<UpdateDnsGtmMonitorResponse> UpdateDnsGtmMonitorAsync(UpdateDnsGtmMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDnsGtmMonitorWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the name of a domain name group based on the specified parameters.
         *
         * @param request UpdateDomainGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateDomainGroupResponse
         */
        public UpdateDomainGroupResponse UpdateDomainGroupWithOptions(UpdateDomainGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDomainGroup",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDomainGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies the name of a domain name group based on the specified parameters.
         *
         * @param request UpdateDomainGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateDomainGroupResponse
         */
        public async Task<UpdateDomainGroupResponse> UpdateDomainGroupWithOptionsAsync(UpdateDomainGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDomainGroup",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDomainGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies the name of a domain name group based on the specified parameters.
         *
         * @param request UpdateDomainGroupRequest
         * @return UpdateDomainGroupResponse
         */
        public UpdateDomainGroupResponse UpdateDomainGroup(UpdateDomainGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDomainGroupWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the name of a domain name group based on the specified parameters.
         *
         * @param request UpdateDomainGroupRequest
         * @return UpdateDomainGroupResponse
         */
        public async Task<UpdateDomainGroupResponse> UpdateDomainGroupAsync(UpdateDomainGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDomainGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies a Domain Name System (DNS) record based on the specified parameters.
         *
         * @param request UpdateDomainRecordRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateDomainRecordResponse
         */
        public UpdateDomainRecordResponse UpdateDomainRecordWithOptions(UpdateDomainRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Line))
            {
                query["Line"] = request.Line;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                query["Priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RR))
            {
                query["RR"] = request.RR;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordId))
            {
                query["RecordId"] = request.RecordId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TTL))
            {
                query["TTL"] = request.TTL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                query["Value"] = request.Value;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDomainRecord",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDomainRecordResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies a Domain Name System (DNS) record based on the specified parameters.
         *
         * @param request UpdateDomainRecordRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateDomainRecordResponse
         */
        public async Task<UpdateDomainRecordResponse> UpdateDomainRecordWithOptionsAsync(UpdateDomainRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Line))
            {
                query["Line"] = request.Line;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                query["Priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RR))
            {
                query["RR"] = request.RR;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordId))
            {
                query["RecordId"] = request.RecordId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TTL))
            {
                query["TTL"] = request.TTL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                query["Value"] = request.Value;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDomainRecord",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDomainRecordResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies a Domain Name System (DNS) record based on the specified parameters.
         *
         * @param request UpdateDomainRecordRequest
         * @return UpdateDomainRecordResponse
         */
        public UpdateDomainRecordResponse UpdateDomainRecord(UpdateDomainRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDomainRecordWithOptions(request, runtime);
        }

        /**
         * @summary Modifies a Domain Name System (DNS) record based on the specified parameters.
         *
         * @param request UpdateDomainRecordRequest
         * @return UpdateDomainRecordResponse
         */
        public async Task<UpdateDomainRecordResponse> UpdateDomainRecordAsync(UpdateDomainRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDomainRecordWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the description of a Domain Name System (DNS) record based on the specified parameters.
         *
         * @param request UpdateDomainRecordRemarkRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateDomainRecordRemarkResponse
         */
        public UpdateDomainRecordRemarkResponse UpdateDomainRecordRemarkWithOptions(UpdateDomainRecordRemarkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordId))
            {
                query["RecordId"] = request.RecordId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDomainRecordRemark",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDomainRecordRemarkResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies the description of a Domain Name System (DNS) record based on the specified parameters.
         *
         * @param request UpdateDomainRecordRemarkRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateDomainRecordRemarkResponse
         */
        public async Task<UpdateDomainRecordRemarkResponse> UpdateDomainRecordRemarkWithOptionsAsync(UpdateDomainRecordRemarkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecordId))
            {
                query["RecordId"] = request.RecordId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDomainRecordRemark",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDomainRecordRemarkResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies the description of a Domain Name System (DNS) record based on the specified parameters.
         *
         * @param request UpdateDomainRecordRemarkRequest
         * @return UpdateDomainRecordRemarkResponse
         */
        public UpdateDomainRecordRemarkResponse UpdateDomainRecordRemark(UpdateDomainRecordRemarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDomainRecordRemarkWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the description of a Domain Name System (DNS) record based on the specified parameters.
         *
         * @param request UpdateDomainRecordRemarkRequest
         * @return UpdateDomainRecordRemarkResponse
         */
        public async Task<UpdateDomainRecordRemarkResponse> UpdateDomainRecordRemarkAsync(UpdateDomainRecordRemarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDomainRecordRemarkWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the description of a domain name based on the specified parameters.
         *
         * @param request UpdateDomainRemarkRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateDomainRemarkResponse
         */
        public UpdateDomainRemarkResponse UpdateDomainRemarkWithOptions(UpdateDomainRemarkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDomainRemark",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDomainRemarkResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies the description of a domain name based on the specified parameters.
         *
         * @param request UpdateDomainRemarkRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateDomainRemarkResponse
         */
        public async Task<UpdateDomainRemarkResponse> UpdateDomainRemarkWithOptionsAsync(UpdateDomainRemarkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDomainRemark",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDomainRemarkResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies the description of a domain name based on the specified parameters.
         *
         * @param request UpdateDomainRemarkRequest
         * @return UpdateDomainRemarkResponse
         */
        public UpdateDomainRemarkResponse UpdateDomainRemark(UpdateDomainRemarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDomainRemarkWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the description of a domain name based on the specified parameters.
         *
         * @param request UpdateDomainRemarkRequest
         * @return UpdateDomainRemarkResponse
         */
        public async Task<UpdateDomainRemarkResponse> UpdateDomainRemarkAsync(UpdateDomainRemarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDomainRemarkWithOptionsAsync(request, runtime);
        }

        /**
         * @param request UpdateGtmAccessStrategyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateGtmAccessStrategyResponse
         */
        public UpdateGtmAccessStrategyResponse UpdateGtmAccessStrategyWithOptions(UpdateGtmAccessStrategyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessLines))
            {
                query["AccessLines"] = request.AccessLines;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultAddrPoolId))
            {
                query["DefaultAddrPoolId"] = request.DefaultAddrPoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FailoverAddrPoolId))
            {
                query["FailoverAddrPoolId"] = request.FailoverAddrPoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyId))
            {
                query["StrategyId"] = request.StrategyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyName))
            {
                query["StrategyName"] = request.StrategyName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateGtmAccessStrategy",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateGtmAccessStrategyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request UpdateGtmAccessStrategyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateGtmAccessStrategyResponse
         */
        public async Task<UpdateGtmAccessStrategyResponse> UpdateGtmAccessStrategyWithOptionsAsync(UpdateGtmAccessStrategyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessLines))
            {
                query["AccessLines"] = request.AccessLines;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultAddrPoolId))
            {
                query["DefaultAddrPoolId"] = request.DefaultAddrPoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FailoverAddrPoolId))
            {
                query["FailoverAddrPoolId"] = request.FailoverAddrPoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyId))
            {
                query["StrategyId"] = request.StrategyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyName))
            {
                query["StrategyName"] = request.StrategyName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateGtmAccessStrategy",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateGtmAccessStrategyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request UpdateGtmAccessStrategyRequest
         * @return UpdateGtmAccessStrategyResponse
         */
        public UpdateGtmAccessStrategyResponse UpdateGtmAccessStrategy(UpdateGtmAccessStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateGtmAccessStrategyWithOptions(request, runtime);
        }

        /**
         * @param request UpdateGtmAccessStrategyRequest
         * @return UpdateGtmAccessStrategyResponse
         */
        public async Task<UpdateGtmAccessStrategyResponse> UpdateGtmAccessStrategyAsync(UpdateGtmAccessStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateGtmAccessStrategyWithOptionsAsync(request, runtime);
        }

        /**
         * @param request UpdateGtmAddressPoolRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateGtmAddressPoolResponse
         */
        public UpdateGtmAddressPoolResponse UpdateGtmAddressPoolWithOptions(UpdateGtmAddressPoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Addr))
            {
                query["Addr"] = request.Addr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddrPoolId))
            {
                query["AddrPoolId"] = request.AddrPoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinAvailableAddrNum))
            {
                query["MinAvailableAddrNum"] = request.MinAvailableAddrNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateGtmAddressPool",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateGtmAddressPoolResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request UpdateGtmAddressPoolRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateGtmAddressPoolResponse
         */
        public async Task<UpdateGtmAddressPoolResponse> UpdateGtmAddressPoolWithOptionsAsync(UpdateGtmAddressPoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Addr))
            {
                query["Addr"] = request.Addr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddrPoolId))
            {
                query["AddrPoolId"] = request.AddrPoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinAvailableAddrNum))
            {
                query["MinAvailableAddrNum"] = request.MinAvailableAddrNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateGtmAddressPool",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateGtmAddressPoolResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request UpdateGtmAddressPoolRequest
         * @return UpdateGtmAddressPoolResponse
         */
        public UpdateGtmAddressPoolResponse UpdateGtmAddressPool(UpdateGtmAddressPoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateGtmAddressPoolWithOptions(request, runtime);
        }

        /**
         * @param request UpdateGtmAddressPoolRequest
         * @return UpdateGtmAddressPoolResponse
         */
        public async Task<UpdateGtmAddressPoolResponse> UpdateGtmAddressPoolAsync(UpdateGtmAddressPoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateGtmAddressPoolWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the configurations of a Global Traffic Manager (GTM) instance based on the specified parameters.
         *
         * @param request UpdateGtmInstanceGlobalConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateGtmInstanceGlobalConfigResponse
         */
        public UpdateGtmInstanceGlobalConfigResponse UpdateGtmInstanceGlobalConfigWithOptions(UpdateGtmInstanceGlobalConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertGroup))
            {
                query["AlertGroup"] = request.AlertGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CnameCustomDomainName))
            {
                query["CnameCustomDomainName"] = request.CnameCustomDomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CnameMode))
            {
                query["CnameMode"] = request.CnameMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LbaStrategy))
            {
                query["LbaStrategy"] = request.LbaStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ttl))
            {
                query["Ttl"] = request.Ttl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserDomainName))
            {
                query["UserDomainName"] = request.UserDomainName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateGtmInstanceGlobalConfig",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateGtmInstanceGlobalConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies the configurations of a Global Traffic Manager (GTM) instance based on the specified parameters.
         *
         * @param request UpdateGtmInstanceGlobalConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateGtmInstanceGlobalConfigResponse
         */
        public async Task<UpdateGtmInstanceGlobalConfigResponse> UpdateGtmInstanceGlobalConfigWithOptionsAsync(UpdateGtmInstanceGlobalConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertGroup))
            {
                query["AlertGroup"] = request.AlertGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CnameCustomDomainName))
            {
                query["CnameCustomDomainName"] = request.CnameCustomDomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CnameMode))
            {
                query["CnameMode"] = request.CnameMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LbaStrategy))
            {
                query["LbaStrategy"] = request.LbaStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ttl))
            {
                query["Ttl"] = request.Ttl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserDomainName))
            {
                query["UserDomainName"] = request.UserDomainName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateGtmInstanceGlobalConfig",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateGtmInstanceGlobalConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies the configurations of a Global Traffic Manager (GTM) instance based on the specified parameters.
         *
         * @param request UpdateGtmInstanceGlobalConfigRequest
         * @return UpdateGtmInstanceGlobalConfigResponse
         */
        public UpdateGtmInstanceGlobalConfigResponse UpdateGtmInstanceGlobalConfig(UpdateGtmInstanceGlobalConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateGtmInstanceGlobalConfigWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the configurations of a Global Traffic Manager (GTM) instance based on the specified parameters.
         *
         * @param request UpdateGtmInstanceGlobalConfigRequest
         * @return UpdateGtmInstanceGlobalConfigResponse
         */
        public async Task<UpdateGtmInstanceGlobalConfigResponse> UpdateGtmInstanceGlobalConfigAsync(UpdateGtmInstanceGlobalConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateGtmInstanceGlobalConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the health check configuration for an address pool of a Global Traffic Manager (GTM) instance.
         *
         * @param request UpdateGtmMonitorRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateGtmMonitorResponse
         */
        public UpdateGtmMonitorResponse UpdateGtmMonitorWithOptions(UpdateGtmMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EvaluationCount))
            {
                query["EvaluationCount"] = request.EvaluationCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IspCityNode))
            {
                query["IspCityNode"] = request.IspCityNode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MonitorConfigId))
            {
                query["MonitorConfigId"] = request.MonitorConfigId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MonitorExtendInfo))
            {
                query["MonitorExtendInfo"] = request.MonitorExtendInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProtocolType))
            {
                query["ProtocolType"] = request.ProtocolType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                query["Timeout"] = request.Timeout;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateGtmMonitor",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateGtmMonitorResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies the health check configuration for an address pool of a Global Traffic Manager (GTM) instance.
         *
         * @param request UpdateGtmMonitorRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateGtmMonitorResponse
         */
        public async Task<UpdateGtmMonitorResponse> UpdateGtmMonitorWithOptionsAsync(UpdateGtmMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EvaluationCount))
            {
                query["EvaluationCount"] = request.EvaluationCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IspCityNode))
            {
                query["IspCityNode"] = request.IspCityNode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MonitorConfigId))
            {
                query["MonitorConfigId"] = request.MonitorConfigId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MonitorExtendInfo))
            {
                query["MonitorExtendInfo"] = request.MonitorExtendInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProtocolType))
            {
                query["ProtocolType"] = request.ProtocolType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                query["Timeout"] = request.Timeout;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateGtmMonitor",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateGtmMonitorResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies the health check configuration for an address pool of a Global Traffic Manager (GTM) instance.
         *
         * @param request UpdateGtmMonitorRequest
         * @return UpdateGtmMonitorResponse
         */
        public UpdateGtmMonitorResponse UpdateGtmMonitor(UpdateGtmMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateGtmMonitorWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the health check configuration for an address pool of a Global Traffic Manager (GTM) instance.
         *
         * @param request UpdateGtmMonitorRequest
         * @return UpdateGtmMonitorResponse
         */
        public async Task<UpdateGtmMonitorResponse> UpdateGtmMonitorAsync(UpdateGtmMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateGtmMonitorWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies a disaster recovery plan for a Global Traffic Manager (GTM) instance.
         *
         * @param request UpdateGtmRecoveryPlanRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateGtmRecoveryPlanResponse
         */
        public UpdateGtmRecoveryPlanResponse UpdateGtmRecoveryPlanWithOptions(UpdateGtmRecoveryPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaultAddrPool))
            {
                query["FaultAddrPool"] = request.FaultAddrPool;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryPlanId))
            {
                query["RecoveryPlanId"] = request.RecoveryPlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateGtmRecoveryPlan",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateGtmRecoveryPlanResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies a disaster recovery plan for a Global Traffic Manager (GTM) instance.
         *
         * @param request UpdateGtmRecoveryPlanRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateGtmRecoveryPlanResponse
         */
        public async Task<UpdateGtmRecoveryPlanResponse> UpdateGtmRecoveryPlanWithOptionsAsync(UpdateGtmRecoveryPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaultAddrPool))
            {
                query["FaultAddrPool"] = request.FaultAddrPool;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryPlanId))
            {
                query["RecoveryPlanId"] = request.RecoveryPlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateGtmRecoveryPlan",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateGtmRecoveryPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies a disaster recovery plan for a Global Traffic Manager (GTM) instance.
         *
         * @param request UpdateGtmRecoveryPlanRequest
         * @return UpdateGtmRecoveryPlanResponse
         */
        public UpdateGtmRecoveryPlanResponse UpdateGtmRecoveryPlan(UpdateGtmRecoveryPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateGtmRecoveryPlanWithOptions(request, runtime);
        }

        /**
         * @summary Modifies a disaster recovery plan for a Global Traffic Manager (GTM) instance.
         *
         * @param request UpdateGtmRecoveryPlanRequest
         * @return UpdateGtmRecoveryPlanResponse
         */
        public async Task<UpdateGtmRecoveryPlanResponse> UpdateGtmRecoveryPlanAsync(UpdateGtmRecoveryPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateGtmRecoveryPlanWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 修改缓存刷新套餐包配置
         *
         * @param request UpdateIspFlushCacheInstanceConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateIspFlushCacheInstanceConfigResponse
         */
        public UpdateIspFlushCacheInstanceConfigResponse UpdateIspFlushCacheInstanceConfigWithOptions(UpdateIspFlushCacheInstanceConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateIspFlushCacheInstanceConfig",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateIspFlushCacheInstanceConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 修改缓存刷新套餐包配置
         *
         * @param request UpdateIspFlushCacheInstanceConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateIspFlushCacheInstanceConfigResponse
         */
        public async Task<UpdateIspFlushCacheInstanceConfigResponse> UpdateIspFlushCacheInstanceConfigWithOptionsAsync(UpdateIspFlushCacheInstanceConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateIspFlushCacheInstanceConfig",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateIspFlushCacheInstanceConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 修改缓存刷新套餐包配置
         *
         * @param request UpdateIspFlushCacheInstanceConfigRequest
         * @return UpdateIspFlushCacheInstanceConfigResponse
         */
        public UpdateIspFlushCacheInstanceConfigResponse UpdateIspFlushCacheInstanceConfig(UpdateIspFlushCacheInstanceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateIspFlushCacheInstanceConfigWithOptions(request, runtime);
        }

        /**
         * @summary 修改缓存刷新套餐包配置
         *
         * @param request UpdateIspFlushCacheInstanceConfigRequest
         * @return UpdateIspFlushCacheInstanceConfigResponse
         */
        public async Task<UpdateIspFlushCacheInstanceConfigResponse> UpdateIspFlushCacheInstanceConfigAsync(UpdateIspFlushCacheInstanceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateIspFlushCacheInstanceConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 检查实例主机名是否可添加
         *
         * @param request ValidateDnsGtmCnameRrCanUseRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ValidateDnsGtmCnameRrCanUseResponse
         */
        public ValidateDnsGtmCnameRrCanUseResponse ValidateDnsGtmCnameRrCanUseWithOptions(ValidateDnsGtmCnameRrCanUseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CnameMode))
            {
                query["CnameMode"] = request.CnameMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CnameRr))
            {
                query["CnameRr"] = request.CnameRr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CnameType))
            {
                query["CnameType"] = request.CnameType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CnameZone))
            {
                query["CnameZone"] = request.CnameZone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ValidateDnsGtmCnameRrCanUse",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ValidateDnsGtmCnameRrCanUseResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 检查实例主机名是否可添加
         *
         * @param request ValidateDnsGtmCnameRrCanUseRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ValidateDnsGtmCnameRrCanUseResponse
         */
        public async Task<ValidateDnsGtmCnameRrCanUseResponse> ValidateDnsGtmCnameRrCanUseWithOptionsAsync(ValidateDnsGtmCnameRrCanUseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CnameMode))
            {
                query["CnameMode"] = request.CnameMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CnameRr))
            {
                query["CnameRr"] = request.CnameRr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CnameType))
            {
                query["CnameType"] = request.CnameType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CnameZone))
            {
                query["CnameZone"] = request.CnameZone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ValidateDnsGtmCnameRrCanUse",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ValidateDnsGtmCnameRrCanUseResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 检查实例主机名是否可添加
         *
         * @param request ValidateDnsGtmCnameRrCanUseRequest
         * @return ValidateDnsGtmCnameRrCanUseResponse
         */
        public ValidateDnsGtmCnameRrCanUseResponse ValidateDnsGtmCnameRrCanUse(ValidateDnsGtmCnameRrCanUseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ValidateDnsGtmCnameRrCanUseWithOptions(request, runtime);
        }

        /**
         * @summary 检查实例主机名是否可添加
         *
         * @param request ValidateDnsGtmCnameRrCanUseRequest
         * @return ValidateDnsGtmCnameRrCanUseResponse
         */
        public async Task<ValidateDnsGtmCnameRrCanUseResponse> ValidateDnsGtmCnameRrCanUseAsync(ValidateDnsGtmCnameRrCanUseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ValidateDnsGtmCnameRrCanUseWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 验证公共DNS Udp Ip地址段
         *
         * @param request ValidatePdnsUdpIpSegmentRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ValidatePdnsUdpIpSegmentResponse
         */
        public ValidatePdnsUdpIpSegmentResponse ValidatePdnsUdpIpSegmentWithOptions(ValidatePdnsUdpIpSegmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ValidatePdnsUdpIpSegment",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ValidatePdnsUdpIpSegmentResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 验证公共DNS Udp Ip地址段
         *
         * @param request ValidatePdnsUdpIpSegmentRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ValidatePdnsUdpIpSegmentResponse
         */
        public async Task<ValidatePdnsUdpIpSegmentResponse> ValidatePdnsUdpIpSegmentWithOptionsAsync(ValidatePdnsUdpIpSegmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ValidatePdnsUdpIpSegment",
                Version = "2015-01-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ValidatePdnsUdpIpSegmentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 验证公共DNS Udp Ip地址段
         *
         * @param request ValidatePdnsUdpIpSegmentRequest
         * @return ValidatePdnsUdpIpSegmentResponse
         */
        public ValidatePdnsUdpIpSegmentResponse ValidatePdnsUdpIpSegment(ValidatePdnsUdpIpSegmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ValidatePdnsUdpIpSegmentWithOptions(request, runtime);
        }

        /**
         * @summary 验证公共DNS Udp Ip地址段
         *
         * @param request ValidatePdnsUdpIpSegmentRequest
         * @return ValidatePdnsUdpIpSegmentResponse
         */
        public async Task<ValidatePdnsUdpIpSegmentResponse> ValidatePdnsUdpIpSegmentAsync(ValidatePdnsUdpIpSegmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ValidatePdnsUdpIpSegmentWithOptionsAsync(request, runtime);
        }

    }
}
