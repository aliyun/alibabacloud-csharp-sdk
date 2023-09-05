// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Sgx_dcap_server20200726.Models;

namespace AlibabaCloud.SDK.Sgx_dcap_server20200726
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._signatureAlgorithm = "v2";
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("sgx-dcap-server", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public GetQeIdentityResponse GetQeIdentityWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQeIdentity",
                Version = "2020-07-26",
                Protocol = "HTTPS",
                Pathname = "/sgx/certification/v3/qe/identity",
                Method = "GET",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "string",
            };
            return TeaModel.ToObject<GetQeIdentityResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetQeIdentityResponse> GetQeIdentityWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQeIdentity",
                Version = "2020-07-26",
                Protocol = "HTTPS",
                Pathname = "/sgx/certification/v3/qe/identity",
                Method = "GET",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "string",
            };
            return TeaModel.ToObject<GetQeIdentityResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetQeIdentityResponse GetQeIdentity()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetQeIdentityWithOptions(headers, runtime);
        }

        public async Task<GetQeIdentityResponse> GetQeIdentityAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetQeIdentityWithOptionsAsync(headers, runtime);
        }

        public GetQveIdentityResponse GetQveIdentityWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQveIdentity",
                Version = "2020-07-26",
                Protocol = "HTTPS",
                Pathname = "/sgx/certification/v3/qve/identity",
                Method = "GET",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "string",
            };
            return TeaModel.ToObject<GetQveIdentityResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetQveIdentityResponse> GetQveIdentityWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQveIdentity",
                Version = "2020-07-26",
                Protocol = "HTTPS",
                Pathname = "/sgx/certification/v3/qve/identity",
                Method = "GET",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "string",
            };
            return TeaModel.ToObject<GetQveIdentityResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetQveIdentityResponse GetQveIdentity()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetQveIdentityWithOptions(headers, runtime);
        }

        public async Task<GetQveIdentityResponse> GetQveIdentityAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetQveIdentityWithOptionsAsync(headers, runtime);
        }

        public GetTcbInfoResponse GetTcbInfoWithOptions(GetTcbInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fmspc))
            {
                query["fmspc"] = request.Fmspc;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTcbInfo",
                Version = "2020-07-26",
                Protocol = "HTTPS",
                Pathname = "/sgx/certification/v3/tcb",
                Method = "GET",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "string",
            };
            return TeaModel.ToObject<GetTcbInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetTcbInfoResponse> GetTcbInfoWithOptionsAsync(GetTcbInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fmspc))
            {
                query["fmspc"] = request.Fmspc;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTcbInfo",
                Version = "2020-07-26",
                Protocol = "HTTPS",
                Pathname = "/sgx/certification/v3/tcb",
                Method = "GET",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "string",
            };
            return TeaModel.ToObject<GetTcbInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetTcbInfoResponse GetTcbInfo(GetTcbInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTcbInfoWithOptions(request, headers, runtime);
        }

        public async Task<GetTcbInfoResponse> GetTcbInfoAsync(GetTcbInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTcbInfoWithOptionsAsync(request, headers, runtime);
        }

        public PckCrlResponse PckCrlWithOptions(PckCrlRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ca))
            {
                query["ca"] = request.Ca;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PckCrl",
                Version = "2020-07-26",
                Protocol = "HTTPS",
                Pathname = "/sgx/certification/v3/pckcrl",
                Method = "GET",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "string",
            };
            return TeaModel.ToObject<PckCrlResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PckCrlResponse> PckCrlWithOptionsAsync(PckCrlRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ca))
            {
                query["ca"] = request.Ca;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PckCrl",
                Version = "2020-07-26",
                Protocol = "HTTPS",
                Pathname = "/sgx/certification/v3/pckcrl",
                Method = "GET",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "string",
            };
            return TeaModel.ToObject<PckCrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PckCrlResponse PckCrl(PckCrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PckCrlWithOptions(request, headers, runtime);
        }

        public async Task<PckCrlResponse> PckCrlAsync(PckCrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PckCrlWithOptionsAsync(request, headers, runtime);
        }

        public RootCaCrlResponse RootCaCrlWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RootCaCrl",
                Version = "2020-07-26",
                Protocol = "HTTPS",
                Pathname = "/sgx/certification/v3/rootcacrl",
                Method = "GET",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "string",
            };
            return TeaModel.ToObject<RootCaCrlResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RootCaCrlResponse> RootCaCrlWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RootCaCrl",
                Version = "2020-07-26",
                Protocol = "HTTPS",
                Pathname = "/sgx/certification/v3/rootcacrl",
                Method = "GET",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "string",
            };
            return TeaModel.ToObject<RootCaCrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RootCaCrlResponse RootCaCrl()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RootCaCrlWithOptions(headers, runtime);
        }

        public async Task<RootCaCrlResponse> RootCaCrlAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RootCaCrlWithOptionsAsync(headers, runtime);
        }

        public SimplePackagePckCertResponse SimplePackagePckCertWithOptions(SimplePackagePckCertRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cpusvn))
            {
                query["cpusvn"] = request.Cpusvn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptedPpid))
            {
                query["encrypted_ppid"] = request.EncryptedPpid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pceid))
            {
                query["pceid"] = request.Pceid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pcesvn))
            {
                query["pcesvn"] = request.Pcesvn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qeid))
            {
                query["qeid"] = request.Qeid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SimplePackagePckCert",
                Version = "2020-07-26",
                Protocol = "HTTPS",
                Pathname = "/sgx/certification/v3/pckcert",
                Method = "GET",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "string",
            };
            return TeaModel.ToObject<SimplePackagePckCertResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SimplePackagePckCertResponse> SimplePackagePckCertWithOptionsAsync(SimplePackagePckCertRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cpusvn))
            {
                query["cpusvn"] = request.Cpusvn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptedPpid))
            {
                query["encrypted_ppid"] = request.EncryptedPpid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pceid))
            {
                query["pceid"] = request.Pceid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pcesvn))
            {
                query["pcesvn"] = request.Pcesvn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Qeid))
            {
                query["qeid"] = request.Qeid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SimplePackagePckCert",
                Version = "2020-07-26",
                Protocol = "HTTPS",
                Pathname = "/sgx/certification/v3/pckcert",
                Method = "GET",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "string",
            };
            return TeaModel.ToObject<SimplePackagePckCertResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SimplePackagePckCertResponse SimplePackagePckCert(SimplePackagePckCertRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SimplePackagePckCertWithOptions(request, headers, runtime);
        }

        public async Task<SimplePackagePckCertResponse> SimplePackagePckCertAsync(SimplePackagePckCertRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SimplePackagePckCertWithOptionsAsync(request, headers, runtime);
        }

    }
}
