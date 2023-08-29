// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Trusted_server20200613.Models;

namespace AlibabaCloud.SDK.Trusted_server20200613
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._signatureAlgorithm = "v2";
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("trusted-server", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public DescribeBootResponse DescribeBootWithOptions(DescribeBootRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PropertyUuid))
            {
                query["PropertyUuid"] = request.PropertyUuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBoot",
                Version = "2020-06-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBootResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeBootResponse> DescribeBootWithOptionsAsync(DescribeBootRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PropertyUuid))
            {
                query["PropertyUuid"] = request.PropertyUuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBoot",
                Version = "2020-06-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBootResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeBootResponse DescribeBoot(DescribeBootRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBootWithOptions(request, runtime);
        }

        public async Task<DescribeBootResponse> DescribeBootAsync(DescribeBootRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBootWithOptionsAsync(request, runtime);
        }

        public DescribeEventsResponse DescribeEventsWithOptions(DescribeEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateEndDate))
            {
                query["CreateEndDate"] = request.CreateEndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateStartDate))
            {
                query["CreateStartDate"] = request.CreateStartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventAffiliation))
            {
                query["EventAffiliation"] = request.EventAffiliation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventLevel))
            {
                query["EventLevel"] = request.EventLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventStatus))
            {
                query["EventStatus"] = request.EventStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventType))
            {
                query["EventType"] = request.EventType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HandleEndDate))
            {
                query["HandleEndDate"] = request.HandleEndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HandleStartDate))
            {
                query["HandleStartDate"] = request.HandleStartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HandleType))
            {
                query["HandleType"] = request.HandleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PropertyName))
            {
                query["PropertyName"] = request.PropertyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PropertyPrivateIp))
            {
                query["PropertyPrivateIp"] = request.PropertyPrivateIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PropertyPublicIp))
            {
                query["PropertyPublicIp"] = request.PropertyPublicIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PropertyUuid))
            {
                query["PropertyUuid"] = request.PropertyUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Suspect))
            {
                query["Suspect"] = request.Suspect;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuspectSig))
            {
                query["SuspectSig"] = request.SuspectSig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeEvents",
                Version = "2020-06-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEventsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeEventsResponse> DescribeEventsWithOptionsAsync(DescribeEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateEndDate))
            {
                query["CreateEndDate"] = request.CreateEndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateStartDate))
            {
                query["CreateStartDate"] = request.CreateStartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventAffiliation))
            {
                query["EventAffiliation"] = request.EventAffiliation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventLevel))
            {
                query["EventLevel"] = request.EventLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventStatus))
            {
                query["EventStatus"] = request.EventStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventType))
            {
                query["EventType"] = request.EventType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HandleEndDate))
            {
                query["HandleEndDate"] = request.HandleEndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HandleStartDate))
            {
                query["HandleStartDate"] = request.HandleStartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HandleType))
            {
                query["HandleType"] = request.HandleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PropertyName))
            {
                query["PropertyName"] = request.PropertyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PropertyPrivateIp))
            {
                query["PropertyPrivateIp"] = request.PropertyPrivateIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PropertyPublicIp))
            {
                query["PropertyPublicIp"] = request.PropertyPublicIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PropertyUuid))
            {
                query["PropertyUuid"] = request.PropertyUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Suspect))
            {
                query["Suspect"] = request.Suspect;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuspectSig))
            {
                query["SuspectSig"] = request.SuspectSig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeEvents",
                Version = "2020-06-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEventsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeEventsResponse DescribeEvents(DescribeEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEventsWithOptions(request, runtime);
        }

        public async Task<DescribeEventsResponse> DescribeEventsAsync(DescribeEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEventsWithOptionsAsync(request, runtime);
        }

        public DescribeInstanceResponse DescribeInstanceWithOptions(DescribeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PropertyUuid))
            {
                query["PropertyUuid"] = request.PropertyUuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstance",
                Version = "2020-06-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeInstanceResponse> DescribeInstanceWithOptionsAsync(DescribeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PropertyUuid))
            {
                query["PropertyUuid"] = request.PropertyUuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstance",
                Version = "2020-06-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeInstanceResponse DescribeInstance(DescribeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceWithOptions(request, runtime);
        }

        public async Task<DescribeInstanceResponse> DescribeInstanceAsync(DescribeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceWithOptionsAsync(request, runtime);
        }

        public GenerateAikcertResponse GenerateAikcertWithOptions(GenerateAikcertRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AikName))
            {
                query["AikName"] = request.AikName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AikPub))
            {
                query["AikPub"] = request.AikPub;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EkCert))
            {
                query["EkCert"] = request.EkCert;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EkPub))
            {
                query["EkPub"] = request.EkPub;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NonceDigest))
            {
                query["NonceDigest"] = request.NonceDigest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PropertyUuid))
            {
                query["PropertyUuid"] = request.PropertyUuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateAikcert",
                Version = "2020-06-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateAikcertResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GenerateAikcertResponse> GenerateAikcertWithOptionsAsync(GenerateAikcertRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AikName))
            {
                query["AikName"] = request.AikName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AikPub))
            {
                query["AikPub"] = request.AikPub;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EkCert))
            {
                query["EkCert"] = request.EkCert;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EkPub))
            {
                query["EkPub"] = request.EkPub;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NonceDigest))
            {
                query["NonceDigest"] = request.NonceDigest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PropertyUuid))
            {
                query["PropertyUuid"] = request.PropertyUuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateAikcert",
                Version = "2020-06-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateAikcertResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GenerateAikcertResponse GenerateAikcert(GenerateAikcertRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateAikcertWithOptions(request, runtime);
        }

        public async Task<GenerateAikcertResponse> GenerateAikcertAsync(GenerateAikcertRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateAikcertWithOptionsAsync(request, runtime);
        }

        public GenerateNonceResponse GenerateNonceWithOptions(GenerateNonceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AikName))
            {
                query["AikName"] = request.AikName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EkCert))
            {
                query["EkCert"] = request.EkCert;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EkPub))
            {
                query["EkPub"] = request.EkPub;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PropertyUuid))
            {
                query["PropertyUuid"] = request.PropertyUuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateNonce",
                Version = "2020-06-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateNonceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GenerateNonceResponse> GenerateNonceWithOptionsAsync(GenerateNonceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AikName))
            {
                query["AikName"] = request.AikName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EkCert))
            {
                query["EkCert"] = request.EkCert;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EkPub))
            {
                query["EkPub"] = request.EkPub;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PropertyUuid))
            {
                query["PropertyUuid"] = request.PropertyUuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateNonce",
                Version = "2020-06-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateNonceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GenerateNonceResponse GenerateNonce(GenerateNonceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateNonceWithOptions(request, runtime);
        }

        public async Task<GenerateNonceResponse> GenerateNonceAsync(GenerateNonceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateNonceWithOptionsAsync(request, runtime);
        }

        public IgnoreEventsResponse IgnoreEventsWithOptions(IgnoreEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventUuids))
            {
                query["EventUuids"] = request.EventUuids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HandleStyle))
            {
                query["HandleStyle"] = request.HandleStyle;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "IgnoreEvents",
                Version = "2020-06-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<IgnoreEventsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<IgnoreEventsResponse> IgnoreEventsWithOptionsAsync(IgnoreEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventUuids))
            {
                query["EventUuids"] = request.EventUuids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HandleStyle))
            {
                query["HandleStyle"] = request.HandleStyle;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "IgnoreEvents",
                Version = "2020-06-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<IgnoreEventsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public IgnoreEventsResponse IgnoreEvents(IgnoreEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return IgnoreEventsWithOptions(request, runtime);
        }

        public async Task<IgnoreEventsResponse> IgnoreEventsAsync(IgnoreEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await IgnoreEventsWithOptionsAsync(request, runtime);
        }

        public ProduceAikcertResponse ProduceAikcertWithOptions(ProduceAikcertRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AikName))
            {
                query["AikName"] = request.AikName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertRequest))
            {
                query["CertRequest"] = request.CertRequest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EkCert))
            {
                query["EkCert"] = request.EkCert;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EkPubKey))
            {
                query["EkPubKey"] = request.EkPubKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeCertChain))
            {
                query["IncludeCertChain"] = request.IncludeCertChain;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ProduceAikcert",
                Version = "2020-06-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ProduceAikcertResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ProduceAikcertResponse> ProduceAikcertWithOptionsAsync(ProduceAikcertRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AikName))
            {
                query["AikName"] = request.AikName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertRequest))
            {
                query["CertRequest"] = request.CertRequest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EkCert))
            {
                query["EkCert"] = request.EkCert;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EkPubKey))
            {
                query["EkPubKey"] = request.EkPubKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeCertChain))
            {
                query["IncludeCertChain"] = request.IncludeCertChain;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ProduceAikcert",
                Version = "2020-06-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ProduceAikcertResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ProduceAikcertResponse ProduceAikcert(ProduceAikcertRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ProduceAikcertWithOptions(request, runtime);
        }

        public async Task<ProduceAikcertResponse> ProduceAikcertAsync(ProduceAikcertRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ProduceAikcertWithOptionsAsync(request, runtime);
        }

        public PutMessageResponse PutMessageWithOptions(PutMessageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileData))
            {
                query["FileData"] = request.FileData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PropertyUuid))
            {
                query["PropertyUuid"] = request.PropertyUuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutMessage",
                Version = "2020-06-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutMessageResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PutMessageResponse> PutMessageWithOptionsAsync(PutMessageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileData))
            {
                query["FileData"] = request.FileData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PropertyUuid))
            {
                query["PropertyUuid"] = request.PropertyUuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutMessage",
                Version = "2020-06-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutMessageResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PutMessageResponse PutMessage(PutMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PutMessageWithOptions(request, runtime);
        }

        public async Task<PutMessageResponse> PutMessageAsync(PutMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PutMessageWithOptionsAsync(request, runtime);
        }

        public RegisterMessageResponse RegisterMessageWithOptions(RegisterMessageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extensions))
            {
                query["Extensions"] = request.Extensions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PropertyAffiliation))
            {
                query["PropertyAffiliation"] = request.PropertyAffiliation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PropertyName))
            {
                query["PropertyName"] = request.PropertyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PropertyPrivateIp))
            {
                query["PropertyPrivateIp"] = request.PropertyPrivateIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PropertyPublicIp))
            {
                query["PropertyPublicIp"] = request.PropertyPublicIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PropertyUuid))
            {
                query["PropertyUuid"] = request.PropertyUuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RegisterMessage",
                Version = "2020-06-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegisterMessageResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RegisterMessageResponse> RegisterMessageWithOptionsAsync(RegisterMessageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extensions))
            {
                query["Extensions"] = request.Extensions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PropertyAffiliation))
            {
                query["PropertyAffiliation"] = request.PropertyAffiliation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PropertyName))
            {
                query["PropertyName"] = request.PropertyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PropertyPrivateIp))
            {
                query["PropertyPrivateIp"] = request.PropertyPrivateIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PropertyPublicIp))
            {
                query["PropertyPublicIp"] = request.PropertyPublicIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PropertyUuid))
            {
                query["PropertyUuid"] = request.PropertyUuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RegisterMessage",
                Version = "2020-06-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegisterMessageResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RegisterMessageResponse RegisterMessage(RegisterMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RegisterMessageWithOptions(request, runtime);
        }

        public async Task<RegisterMessageResponse> RegisterMessageAsync(RegisterMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RegisterMessageWithOptionsAsync(request, runtime);
        }

        public TrustEventsResponse TrustEventsWithOptions(TrustEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventUuids))
            {
                query["EventUuids"] = request.EventUuids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HandleStyle))
            {
                query["HandleStyle"] = request.HandleStyle;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TrustEvents",
                Version = "2020-06-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TrustEventsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<TrustEventsResponse> TrustEventsWithOptionsAsync(TrustEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventUuids))
            {
                query["EventUuids"] = request.EventUuids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HandleStyle))
            {
                query["HandleStyle"] = request.HandleStyle;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TrustEvents",
                Version = "2020-06-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TrustEventsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public TrustEventsResponse TrustEvents(TrustEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TrustEventsWithOptions(request, runtime);
        }

        public async Task<TrustEventsResponse> TrustEventsAsync(TrustEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TrustEventsWithOptionsAsync(request, runtime);
        }

        public UnregisterMessageResponse UnregisterMessageWithOptions(UnregisterMessageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Properties))
            {
                query["Properties"] = request.Properties;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnregisterMessage",
                Version = "2020-06-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnregisterMessageResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UnregisterMessageResponse> UnregisterMessageWithOptionsAsync(UnregisterMessageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Properties))
            {
                query["Properties"] = request.Properties;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnregisterMessage",
                Version = "2020-06-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnregisterMessageResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UnregisterMessageResponse UnregisterMessage(UnregisterMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnregisterMessageWithOptions(request, runtime);
        }

        public async Task<UnregisterMessageResponse> UnregisterMessageAsync(UnregisterMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnregisterMessageWithOptionsAsync(request, runtime);
        }

        public VerifyMessageResponse VerifyMessageWithOptions(VerifyMessageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileData))
            {
                body["FileData"] = request.FileData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VerifyMessage",
                Version = "2020-06-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VerifyMessageResponse>(CallApi(params_, req, runtime));
        }

        public async Task<VerifyMessageResponse> VerifyMessageWithOptionsAsync(VerifyMessageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileData))
            {
                body["FileData"] = request.FileData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VerifyMessage",
                Version = "2020-06-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VerifyMessageResponse>(await CallApiAsync(params_, req, runtime));
        }

        public VerifyMessageResponse VerifyMessage(VerifyMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VerifyMessageWithOptions(request, runtime);
        }

        public async Task<VerifyMessageResponse> VerifyMessageAsync(VerifyMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VerifyMessageWithOptionsAsync(request, runtime);
        }

    }
}
