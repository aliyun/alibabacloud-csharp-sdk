// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.BaasDis20200509.Models;

namespace AlibabaCloud.SDK.BaasDis20200509
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("baasdis", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
         * @param request CreateEenterpriseDIDRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateEenterpriseDIDResponse
         */
        public CreateEenterpriseDIDResponse CreateEenterpriseDIDWithOptions(CreateEenterpriseDIDRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerUniqueID))
            {
                body["OwnerUniqueID"] = request.OwnerUniqueID;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEenterpriseDID",
                Version = "2020-05-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEenterpriseDIDResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request CreateEenterpriseDIDRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateEenterpriseDIDResponse
         */
        public async Task<CreateEenterpriseDIDResponse> CreateEenterpriseDIDWithOptionsAsync(CreateEenterpriseDIDRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerUniqueID))
            {
                body["OwnerUniqueID"] = request.OwnerUniqueID;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEenterpriseDID",
                Version = "2020-05-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEenterpriseDIDResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request CreateEenterpriseDIDRequest
         * @return CreateEenterpriseDIDResponse
         */
        public CreateEenterpriseDIDResponse CreateEenterpriseDID(CreateEenterpriseDIDRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateEenterpriseDIDWithOptions(request, runtime);
        }

        /**
         * @param request CreateEenterpriseDIDRequest
         * @return CreateEenterpriseDIDResponse
         */
        public async Task<CreateEenterpriseDIDResponse> CreateEenterpriseDIDAsync(CreateEenterpriseDIDRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateEenterpriseDIDWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CreatePersonalDIDRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreatePersonalDIDResponse
         */
        public CreatePersonalDIDResponse CreatePersonalDIDWithOptions(CreatePersonalDIDRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerUniqueID))
            {
                body["OwnerUniqueID"] = request.OwnerUniqueID;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePersonalDID",
                Version = "2020-05-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePersonalDIDResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request CreatePersonalDIDRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreatePersonalDIDResponse
         */
        public async Task<CreatePersonalDIDResponse> CreatePersonalDIDWithOptionsAsync(CreatePersonalDIDRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerUniqueID))
            {
                body["OwnerUniqueID"] = request.OwnerUniqueID;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePersonalDID",
                Version = "2020-05-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePersonalDIDResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request CreatePersonalDIDRequest
         * @return CreatePersonalDIDResponse
         */
        public CreatePersonalDIDResponse CreatePersonalDID(CreatePersonalDIDRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreatePersonalDIDWithOptions(request, runtime);
        }

        /**
         * @param request CreatePersonalDIDRequest
         * @return CreatePersonalDIDResponse
         */
        public async Task<CreatePersonalDIDResponse> CreatePersonalDIDAsync(CreatePersonalDIDRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreatePersonalDIDWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CreateTenantDIDRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTenantDIDResponse
         */
        public CreateTenantDIDResponse CreateTenantDIDWithOptions(CreateTenantDIDRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTenantDID",
                Version = "2020-05-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTenantDIDResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request CreateTenantDIDRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTenantDIDResponse
         */
        public async Task<CreateTenantDIDResponse> CreateTenantDIDWithOptionsAsync(CreateTenantDIDRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTenantDID",
                Version = "2020-05-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTenantDIDResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request CreateTenantDIDRequest
         * @return CreateTenantDIDResponse
         */
        public CreateTenantDIDResponse CreateTenantDID(CreateTenantDIDRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTenantDIDWithOptions(request, runtime);
        }

        /**
         * @param request CreateTenantDIDRequest
         * @return CreateTenantDIDResponse
         */
        public async Task<CreateTenantDIDResponse> CreateTenantDIDAsync(CreateTenantDIDRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTenantDIDWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GetDIDRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDIDResponse
         */
        public GetDIDResponse GetDIDWithOptions(GetDIDRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DID))
            {
                body["DID"] = request.DID;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDID",
                Version = "2020-05-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDIDResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request GetDIDRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDIDResponse
         */
        public async Task<GetDIDResponse> GetDIDWithOptionsAsync(GetDIDRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DID))
            {
                body["DID"] = request.DID;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDID",
                Version = "2020-05-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDIDResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request GetDIDRequest
         * @return GetDIDResponse
         */
        public GetDIDResponse GetDID(GetDIDRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDIDWithOptions(request, runtime);
        }

        /**
         * @param request GetDIDRequest
         * @return GetDIDResponse
         */
        public async Task<GetDIDResponse> GetDIDAsync(GetDIDRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDIDWithOptionsAsync(request, runtime);
        }

        /**
         * @param request IssueNormalVerifiableVCRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return IssueNormalVerifiableVCResponse
         */
        public IssueNormalVerifiableVCResponse IssueNormalVerifiableVCWithOptions(IssueNormalVerifiableVCRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BareClaimStructBody))
            {
                body["BareClaimStructBody"] = request.BareClaimStructBody;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Expiration))
            {
                body["Expiration"] = request.Expiration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Issuer))
            {
                body["Issuer"] = request.Issuer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Subject))
            {
                body["Subject"] = request.Subject;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "IssueNormalVerifiableVC",
                Version = "2020-05-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<IssueNormalVerifiableVCResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request IssueNormalVerifiableVCRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return IssueNormalVerifiableVCResponse
         */
        public async Task<IssueNormalVerifiableVCResponse> IssueNormalVerifiableVCWithOptionsAsync(IssueNormalVerifiableVCRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BareClaimStructBody))
            {
                body["BareClaimStructBody"] = request.BareClaimStructBody;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Expiration))
            {
                body["Expiration"] = request.Expiration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Issuer))
            {
                body["Issuer"] = request.Issuer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Subject))
            {
                body["Subject"] = request.Subject;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "IssueNormalVerifiableVC",
                Version = "2020-05-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<IssueNormalVerifiableVCResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request IssueNormalVerifiableVCRequest
         * @return IssueNormalVerifiableVCResponse
         */
        public IssueNormalVerifiableVCResponse IssueNormalVerifiableVC(IssueNormalVerifiableVCRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return IssueNormalVerifiableVCWithOptions(request, runtime);
        }

        /**
         * @param request IssueNormalVerifiableVCRequest
         * @return IssueNormalVerifiableVCResponse
         */
        public async Task<IssueNormalVerifiableVCResponse> IssueNormalVerifiableVCAsync(IssueNormalVerifiableVCRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await IssueNormalVerifiableVCWithOptionsAsync(request, runtime);
        }

        /**
         * @param request UpdateVCRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateVCResponse
         */
        public UpdateVCResponse UpdateVCWithOptions(UpdateVCRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IssuerDid))
            {
                body["IssuerDid"] = request.IssuerDid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VCId))
            {
                body["VCId"] = request.VCId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VCStatus))
            {
                body["VCStatus"] = request.VCStatus;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateVC",
                Version = "2020-05-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateVCResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request UpdateVCRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateVCResponse
         */
        public async Task<UpdateVCResponse> UpdateVCWithOptionsAsync(UpdateVCRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IssuerDid))
            {
                body["IssuerDid"] = request.IssuerDid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VCId))
            {
                body["VCId"] = request.VCId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VCStatus))
            {
                body["VCStatus"] = request.VCStatus;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateVC",
                Version = "2020-05-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateVCResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request UpdateVCRequest
         * @return UpdateVCResponse
         */
        public UpdateVCResponse UpdateVC(UpdateVCRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateVCWithOptions(request, runtime);
        }

        /**
         * @param request UpdateVCRequest
         * @return UpdateVCResponse
         */
        public async Task<UpdateVCResponse> UpdateVCAsync(UpdateVCRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateVCWithOptionsAsync(request, runtime);
        }

        /**
         * @param request VerifyVerifiableClaimRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return VerifyVerifiableClaimResponse
         */
        public VerifyVerifiableClaimResponse VerifyVerifiableClaimWithOptions(VerifyVerifiableClaimRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VCContent))
            {
                body["VCContent"] = request.VCContent;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VerifyVerifiableClaim",
                Version = "2020-05-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VerifyVerifiableClaimResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request VerifyVerifiableClaimRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return VerifyVerifiableClaimResponse
         */
        public async Task<VerifyVerifiableClaimResponse> VerifyVerifiableClaimWithOptionsAsync(VerifyVerifiableClaimRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VCContent))
            {
                body["VCContent"] = request.VCContent;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VerifyVerifiableClaim",
                Version = "2020-05-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VerifyVerifiableClaimResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request VerifyVerifiableClaimRequest
         * @return VerifyVerifiableClaimResponse
         */
        public VerifyVerifiableClaimResponse VerifyVerifiableClaim(VerifyVerifiableClaimRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VerifyVerifiableClaimWithOptions(request, runtime);
        }

        /**
         * @param request VerifyVerifiableClaimRequest
         * @return VerifyVerifiableClaimResponse
         */
        public async Task<VerifyVerifiableClaimResponse> VerifyVerifiableClaimAsync(VerifyVerifiableClaimRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VerifyVerifiableClaimWithOptionsAsync(request, runtime);
        }

    }
}
