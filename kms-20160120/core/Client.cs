// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Kms20160120.Models;

namespace AlibabaCloud.SDK.Kms20160120
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("kms", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public AsymmetricDecryptResponse AsymmetricDecryptWithOptions(AsymmetricDecryptRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AsymmetricDecryptResponse>(DoRPCRequest("AsymmetricDecrypt", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AsymmetricDecryptResponse> AsymmetricDecryptWithOptionsAsync(AsymmetricDecryptRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AsymmetricDecryptResponse>(await DoRPCRequestAsync("AsymmetricDecrypt", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AsymmetricDecryptResponse AsymmetricDecrypt(AsymmetricDecryptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AsymmetricDecryptWithOptions(request, runtime);
        }

        public async Task<AsymmetricDecryptResponse> AsymmetricDecryptAsync(AsymmetricDecryptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AsymmetricDecryptWithOptionsAsync(request, runtime);
        }

        public AsymmetricEncryptResponse AsymmetricEncryptWithOptions(AsymmetricEncryptRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AsymmetricEncryptResponse>(DoRPCRequest("AsymmetricEncrypt", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AsymmetricEncryptResponse> AsymmetricEncryptWithOptionsAsync(AsymmetricEncryptRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AsymmetricEncryptResponse>(await DoRPCRequestAsync("AsymmetricEncrypt", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AsymmetricEncryptResponse AsymmetricEncrypt(AsymmetricEncryptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AsymmetricEncryptWithOptions(request, runtime);
        }

        public async Task<AsymmetricEncryptResponse> AsymmetricEncryptAsync(AsymmetricEncryptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AsymmetricEncryptWithOptionsAsync(request, runtime);
        }

        public AsymmetricSignResponse AsymmetricSignWithOptions(AsymmetricSignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AsymmetricSignResponse>(DoRPCRequest("AsymmetricSign", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AsymmetricSignResponse> AsymmetricSignWithOptionsAsync(AsymmetricSignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AsymmetricSignResponse>(await DoRPCRequestAsync("AsymmetricSign", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AsymmetricSignResponse AsymmetricSign(AsymmetricSignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AsymmetricSignWithOptions(request, runtime);
        }

        public async Task<AsymmetricSignResponse> AsymmetricSignAsync(AsymmetricSignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AsymmetricSignWithOptionsAsync(request, runtime);
        }

        public AsymmetricVerifyResponse AsymmetricVerifyWithOptions(AsymmetricVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AsymmetricVerifyResponse>(DoRPCRequest("AsymmetricVerify", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AsymmetricVerifyResponse> AsymmetricVerifyWithOptionsAsync(AsymmetricVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AsymmetricVerifyResponse>(await DoRPCRequestAsync("AsymmetricVerify", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AsymmetricVerifyResponse AsymmetricVerify(AsymmetricVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AsymmetricVerifyWithOptions(request, runtime);
        }

        public async Task<AsymmetricVerifyResponse> AsymmetricVerifyAsync(AsymmetricVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AsymmetricVerifyWithOptionsAsync(request, runtime);
        }

        public CancelKeyDeletionResponse CancelKeyDeletionWithOptions(CancelKeyDeletionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CancelKeyDeletionResponse>(DoRPCRequest("CancelKeyDeletion", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CancelKeyDeletionResponse> CancelKeyDeletionWithOptionsAsync(CancelKeyDeletionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CancelKeyDeletionResponse>(await DoRPCRequestAsync("CancelKeyDeletion", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CancelKeyDeletionResponse CancelKeyDeletion(CancelKeyDeletionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelKeyDeletionWithOptions(request, runtime);
        }

        public async Task<CancelKeyDeletionResponse> CancelKeyDeletionAsync(CancelKeyDeletionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelKeyDeletionWithOptionsAsync(request, runtime);
        }

        public CertificatePrivateKeyDecryptResponse CertificatePrivateKeyDecryptWithOptions(CertificatePrivateKeyDecryptRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CertificatePrivateKeyDecryptResponse>(DoRPCRequest("CertificatePrivateKeyDecrypt", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CertificatePrivateKeyDecryptResponse> CertificatePrivateKeyDecryptWithOptionsAsync(CertificatePrivateKeyDecryptRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CertificatePrivateKeyDecryptResponse>(await DoRPCRequestAsync("CertificatePrivateKeyDecrypt", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CertificatePrivateKeyDecryptResponse CertificatePrivateKeyDecrypt(CertificatePrivateKeyDecryptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CertificatePrivateKeyDecryptWithOptions(request, runtime);
        }

        public async Task<CertificatePrivateKeyDecryptResponse> CertificatePrivateKeyDecryptAsync(CertificatePrivateKeyDecryptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CertificatePrivateKeyDecryptWithOptionsAsync(request, runtime);
        }

        public CertificatePrivateKeySignResponse CertificatePrivateKeySignWithOptions(CertificatePrivateKeySignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CertificatePrivateKeySignResponse>(DoRPCRequest("CertificatePrivateKeySign", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CertificatePrivateKeySignResponse> CertificatePrivateKeySignWithOptionsAsync(CertificatePrivateKeySignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CertificatePrivateKeySignResponse>(await DoRPCRequestAsync("CertificatePrivateKeySign", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CertificatePrivateKeySignResponse CertificatePrivateKeySign(CertificatePrivateKeySignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CertificatePrivateKeySignWithOptions(request, runtime);
        }

        public async Task<CertificatePrivateKeySignResponse> CertificatePrivateKeySignAsync(CertificatePrivateKeySignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CertificatePrivateKeySignWithOptionsAsync(request, runtime);
        }

        public CertificatePublicKeyEncryptResponse CertificatePublicKeyEncryptWithOptions(CertificatePublicKeyEncryptRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CertificatePublicKeyEncryptResponse>(DoRPCRequest("CertificatePublicKeyEncrypt", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CertificatePublicKeyEncryptResponse> CertificatePublicKeyEncryptWithOptionsAsync(CertificatePublicKeyEncryptRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CertificatePublicKeyEncryptResponse>(await DoRPCRequestAsync("CertificatePublicKeyEncrypt", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CertificatePublicKeyEncryptResponse CertificatePublicKeyEncrypt(CertificatePublicKeyEncryptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CertificatePublicKeyEncryptWithOptions(request, runtime);
        }

        public async Task<CertificatePublicKeyEncryptResponse> CertificatePublicKeyEncryptAsync(CertificatePublicKeyEncryptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CertificatePublicKeyEncryptWithOptionsAsync(request, runtime);
        }

        public CertificatePublicKeyVerifyResponse CertificatePublicKeyVerifyWithOptions(CertificatePublicKeyVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CertificatePublicKeyVerifyResponse>(DoRPCRequest("CertificatePublicKeyVerify", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CertificatePublicKeyVerifyResponse> CertificatePublicKeyVerifyWithOptionsAsync(CertificatePublicKeyVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CertificatePublicKeyVerifyResponse>(await DoRPCRequestAsync("CertificatePublicKeyVerify", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CertificatePublicKeyVerifyResponse CertificatePublicKeyVerify(CertificatePublicKeyVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CertificatePublicKeyVerifyWithOptions(request, runtime);
        }

        public async Task<CertificatePublicKeyVerifyResponse> CertificatePublicKeyVerifyAsync(CertificatePublicKeyVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CertificatePublicKeyVerifyWithOptionsAsync(request, runtime);
        }

        public CreateAliasResponse CreateAliasWithOptions(CreateAliasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAliasResponse>(DoRPCRequest("CreateAlias", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateAliasResponse> CreateAliasWithOptionsAsync(CreateAliasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAliasResponse>(await DoRPCRequestAsync("CreateAlias", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateAliasResponse CreateAlias(CreateAliasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAliasWithOptions(request, runtime);
        }

        public async Task<CreateAliasResponse> CreateAliasAsync(CreateAliasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAliasWithOptionsAsync(request, runtime);
        }

        public CreateCertificateResponse CreateCertificateWithOptions(CreateCertificateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateCertificateShrinkRequest request = new CreateCertificateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SubjectAlternativeNames))
            {
                request.SubjectAlternativeNamesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SubjectAlternativeNames, "SubjectAlternativeNames", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateCertificateResponse>(DoRPCRequest("CreateCertificate", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateCertificateResponse> CreateCertificateWithOptionsAsync(CreateCertificateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateCertificateShrinkRequest request = new CreateCertificateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SubjectAlternativeNames))
            {
                request.SubjectAlternativeNamesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SubjectAlternativeNames, "SubjectAlternativeNames", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateCertificateResponse>(await DoRPCRequestAsync("CreateCertificate", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateCertificateResponse CreateCertificate(CreateCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCertificateWithOptions(request, runtime);
        }

        public async Task<CreateCertificateResponse> CreateCertificateAsync(CreateCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCertificateWithOptionsAsync(request, runtime);
        }

        public CreateKeyResponse CreateKeyWithOptions(CreateKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateKeyResponse>(DoRPCRequest("CreateKey", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateKeyResponse> CreateKeyWithOptionsAsync(CreateKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateKeyResponse>(await DoRPCRequestAsync("CreateKey", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateKeyResponse CreateKey(CreateKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateKeyWithOptions(request, runtime);
        }

        public async Task<CreateKeyResponse> CreateKeyAsync(CreateKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateKeyWithOptionsAsync(request, runtime);
        }

        public CreateKeyVersionResponse CreateKeyVersionWithOptions(CreateKeyVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateKeyVersionResponse>(DoRPCRequest("CreateKeyVersion", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateKeyVersionResponse> CreateKeyVersionWithOptionsAsync(CreateKeyVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateKeyVersionResponse>(await DoRPCRequestAsync("CreateKeyVersion", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateKeyVersionResponse CreateKeyVersion(CreateKeyVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateKeyVersionWithOptions(request, runtime);
        }

        public async Task<CreateKeyVersionResponse> CreateKeyVersionAsync(CreateKeyVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateKeyVersionWithOptionsAsync(request, runtime);
        }

        public CreateSecretResponse CreateSecretWithOptions(CreateSecretRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateSecretShrinkRequest request = new CreateSecretShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExtendedConfig))
            {
                request.ExtendedConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExtendedConfig, "ExtendedConfig", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSecretResponse>(DoRPCRequest("CreateSecret", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateSecretResponse> CreateSecretWithOptionsAsync(CreateSecretRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateSecretShrinkRequest request = new CreateSecretShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExtendedConfig))
            {
                request.ExtendedConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExtendedConfig, "ExtendedConfig", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSecretResponse>(await DoRPCRequestAsync("CreateSecret", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateSecretResponse CreateSecret(CreateSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSecretWithOptions(request, runtime);
        }

        public async Task<CreateSecretResponse> CreateSecretAsync(CreateSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSecretWithOptionsAsync(request, runtime);
        }

        public DecryptResponse DecryptWithOptions(DecryptRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DecryptShrinkRequest request = new DecryptShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EncryptionContext))
            {
                request.EncryptionContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EncryptionContext, "EncryptionContext", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DecryptResponse>(DoRPCRequest("Decrypt", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DecryptResponse> DecryptWithOptionsAsync(DecryptRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DecryptShrinkRequest request = new DecryptShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EncryptionContext))
            {
                request.EncryptionContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EncryptionContext, "EncryptionContext", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DecryptResponse>(await DoRPCRequestAsync("Decrypt", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DecryptResponse Decrypt(DecryptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DecryptWithOptions(request, runtime);
        }

        public async Task<DecryptResponse> DecryptAsync(DecryptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DecryptWithOptionsAsync(request, runtime);
        }

        public DeleteAliasResponse DeleteAliasWithOptions(DeleteAliasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAliasResponse>(DoRPCRequest("DeleteAlias", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteAliasResponse> DeleteAliasWithOptionsAsync(DeleteAliasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAliasResponse>(await DoRPCRequestAsync("DeleteAlias", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteAliasResponse DeleteAlias(DeleteAliasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAliasWithOptions(request, runtime);
        }

        public async Task<DeleteAliasResponse> DeleteAliasAsync(DeleteAliasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAliasWithOptionsAsync(request, runtime);
        }

        public DeleteCertificateResponse DeleteCertificateWithOptions(DeleteCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteCertificateResponse>(DoRPCRequest("DeleteCertificate", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteCertificateResponse> DeleteCertificateWithOptionsAsync(DeleteCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteCertificateResponse>(await DoRPCRequestAsync("DeleteCertificate", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteCertificateResponse DeleteCertificate(DeleteCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCertificateWithOptions(request, runtime);
        }

        public async Task<DeleteCertificateResponse> DeleteCertificateAsync(DeleteCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCertificateWithOptionsAsync(request, runtime);
        }

        public DeleteKeyMaterialResponse DeleteKeyMaterialWithOptions(DeleteKeyMaterialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteKeyMaterialResponse>(DoRPCRequest("DeleteKeyMaterial", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteKeyMaterialResponse> DeleteKeyMaterialWithOptionsAsync(DeleteKeyMaterialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteKeyMaterialResponse>(await DoRPCRequestAsync("DeleteKeyMaterial", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteKeyMaterialResponse DeleteKeyMaterial(DeleteKeyMaterialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteKeyMaterialWithOptions(request, runtime);
        }

        public async Task<DeleteKeyMaterialResponse> DeleteKeyMaterialAsync(DeleteKeyMaterialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteKeyMaterialWithOptionsAsync(request, runtime);
        }

        public DeleteSecretResponse DeleteSecretWithOptions(DeleteSecretRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSecretResponse>(DoRPCRequest("DeleteSecret", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteSecretResponse> DeleteSecretWithOptionsAsync(DeleteSecretRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSecretResponse>(await DoRPCRequestAsync("DeleteSecret", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteSecretResponse DeleteSecret(DeleteSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSecretWithOptions(request, runtime);
        }

        public async Task<DeleteSecretResponse> DeleteSecretAsync(DeleteSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSecretWithOptionsAsync(request, runtime);
        }

        public DescribeAccountKmsStatusResponse DescribeAccountKmsStatusWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<DescribeAccountKmsStatusResponse>(DoRPCRequest("DescribeAccountKmsStatus", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAccountKmsStatusResponse> DescribeAccountKmsStatusWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<DescribeAccountKmsStatusResponse>(await DoRPCRequestAsync("DescribeAccountKmsStatus", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAccountKmsStatusResponse DescribeAccountKmsStatus()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAccountKmsStatusWithOptions(runtime);
        }

        public async Task<DescribeAccountKmsStatusResponse> DescribeAccountKmsStatusAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAccountKmsStatusWithOptionsAsync(runtime);
        }

        public DescribeCertificateResponse DescribeCertificateWithOptions(DescribeCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCertificateResponse>(DoRPCRequest("DescribeCertificate", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCertificateResponse> DescribeCertificateWithOptionsAsync(DescribeCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCertificateResponse>(await DoRPCRequestAsync("DescribeCertificate", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCertificateResponse DescribeCertificate(DescribeCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCertificateWithOptions(request, runtime);
        }

        public async Task<DescribeCertificateResponse> DescribeCertificateAsync(DescribeCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCertificateWithOptionsAsync(request, runtime);
        }

        public DescribeKeyResponse DescribeKeyWithOptions(DescribeKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeKeyResponse>(DoRPCRequest("DescribeKey", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeKeyResponse> DescribeKeyWithOptionsAsync(DescribeKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeKeyResponse>(await DoRPCRequestAsync("DescribeKey", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeKeyResponse DescribeKey(DescribeKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeKeyWithOptions(request, runtime);
        }

        public async Task<DescribeKeyResponse> DescribeKeyAsync(DescribeKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeKeyWithOptionsAsync(request, runtime);
        }

        public DescribeKeyVersionResponse DescribeKeyVersionWithOptions(DescribeKeyVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeKeyVersionResponse>(DoRPCRequest("DescribeKeyVersion", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeKeyVersionResponse> DescribeKeyVersionWithOptionsAsync(DescribeKeyVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeKeyVersionResponse>(await DoRPCRequestAsync("DescribeKeyVersion", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeKeyVersionResponse DescribeKeyVersion(DescribeKeyVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeKeyVersionWithOptions(request, runtime);
        }

        public async Task<DescribeKeyVersionResponse> DescribeKeyVersionAsync(DescribeKeyVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeKeyVersionWithOptionsAsync(request, runtime);
        }

        public DescribeRegionsResponse DescribeRegionsWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<DescribeRegionsResponse>(DoRPCRequest("DescribeRegions", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<DescribeRegionsResponse>(await DoRPCRequestAsync("DescribeRegions", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRegionsResponse DescribeRegions()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRegionsWithOptions(runtime);
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRegionsWithOptionsAsync(runtime);
        }

        public DescribeSecretResponse DescribeSecretWithOptions(DescribeSecretRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSecretResponse>(DoRPCRequest("DescribeSecret", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSecretResponse> DescribeSecretWithOptionsAsync(DescribeSecretRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSecretResponse>(await DoRPCRequestAsync("DescribeSecret", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSecretResponse DescribeSecret(DescribeSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSecretWithOptions(request, runtime);
        }

        public async Task<DescribeSecretResponse> DescribeSecretAsync(DescribeSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSecretWithOptionsAsync(request, runtime);
        }

        public DescribeServiceResponse DescribeServiceWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<DescribeServiceResponse>(DoRPCRequest("DescribeService", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeServiceResponse> DescribeServiceWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<DescribeServiceResponse>(await DoRPCRequestAsync("DescribeService", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeServiceResponse DescribeService()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeServiceWithOptions(runtime);
        }

        public async Task<DescribeServiceResponse> DescribeServiceAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeServiceWithOptionsAsync(runtime);
        }

        public DisableKeyResponse DisableKeyWithOptions(DisableKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableKeyResponse>(DoRPCRequest("DisableKey", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DisableKeyResponse> DisableKeyWithOptionsAsync(DisableKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableKeyResponse>(await DoRPCRequestAsync("DisableKey", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DisableKeyResponse DisableKey(DisableKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableKeyWithOptions(request, runtime);
        }

        public async Task<DisableKeyResponse> DisableKeyAsync(DisableKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableKeyWithOptionsAsync(request, runtime);
        }

        public EnableKeyResponse EnableKeyWithOptions(EnableKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableKeyResponse>(DoRPCRequest("EnableKey", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<EnableKeyResponse> EnableKeyWithOptionsAsync(EnableKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableKeyResponse>(await DoRPCRequestAsync("EnableKey", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public EnableKeyResponse EnableKey(EnableKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableKeyWithOptions(request, runtime);
        }

        public async Task<EnableKeyResponse> EnableKeyAsync(EnableKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableKeyWithOptionsAsync(request, runtime);
        }

        public EncryptResponse EncryptWithOptions(EncryptRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            EncryptShrinkRequest request = new EncryptShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EncryptionContext))
            {
                request.EncryptionContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EncryptionContext, "EncryptionContext", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EncryptResponse>(DoRPCRequest("Encrypt", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<EncryptResponse> EncryptWithOptionsAsync(EncryptRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            EncryptShrinkRequest request = new EncryptShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EncryptionContext))
            {
                request.EncryptionContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EncryptionContext, "EncryptionContext", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EncryptResponse>(await DoRPCRequestAsync("Encrypt", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public EncryptResponse Encrypt(EncryptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EncryptWithOptions(request, runtime);
        }

        public async Task<EncryptResponse> EncryptAsync(EncryptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EncryptWithOptionsAsync(request, runtime);
        }

        public ExportCertificateResponse ExportCertificateWithOptions(ExportCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ExportCertificateResponse>(DoRPCRequest("ExportCertificate", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ExportCertificateResponse> ExportCertificateWithOptionsAsync(ExportCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ExportCertificateResponse>(await DoRPCRequestAsync("ExportCertificate", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ExportCertificateResponse ExportCertificate(ExportCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExportCertificateWithOptions(request, runtime);
        }

        public async Task<ExportCertificateResponse> ExportCertificateAsync(ExportCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExportCertificateWithOptionsAsync(request, runtime);
        }

        public ExportDataKeyResponse ExportDataKeyWithOptions(ExportDataKeyRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ExportDataKeyShrinkRequest request = new ExportDataKeyShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EncryptionContext))
            {
                request.EncryptionContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EncryptionContext, "EncryptionContext", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ExportDataKeyResponse>(DoRPCRequest("ExportDataKey", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ExportDataKeyResponse> ExportDataKeyWithOptionsAsync(ExportDataKeyRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ExportDataKeyShrinkRequest request = new ExportDataKeyShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EncryptionContext))
            {
                request.EncryptionContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EncryptionContext, "EncryptionContext", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ExportDataKeyResponse>(await DoRPCRequestAsync("ExportDataKey", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ExportDataKeyResponse ExportDataKey(ExportDataKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExportDataKeyWithOptions(request, runtime);
        }

        public async Task<ExportDataKeyResponse> ExportDataKeyAsync(ExportDataKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExportDataKeyWithOptionsAsync(request, runtime);
        }

        public GenerateAndExportDataKeyResponse GenerateAndExportDataKeyWithOptions(GenerateAndExportDataKeyRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GenerateAndExportDataKeyShrinkRequest request = new GenerateAndExportDataKeyShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EncryptionContext))
            {
                request.EncryptionContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EncryptionContext, "EncryptionContext", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GenerateAndExportDataKeyResponse>(DoRPCRequest("GenerateAndExportDataKey", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GenerateAndExportDataKeyResponse> GenerateAndExportDataKeyWithOptionsAsync(GenerateAndExportDataKeyRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GenerateAndExportDataKeyShrinkRequest request = new GenerateAndExportDataKeyShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EncryptionContext))
            {
                request.EncryptionContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EncryptionContext, "EncryptionContext", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GenerateAndExportDataKeyResponse>(await DoRPCRequestAsync("GenerateAndExportDataKey", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GenerateAndExportDataKeyResponse GenerateAndExportDataKey(GenerateAndExportDataKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateAndExportDataKeyWithOptions(request, runtime);
        }

        public async Task<GenerateAndExportDataKeyResponse> GenerateAndExportDataKeyAsync(GenerateAndExportDataKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateAndExportDataKeyWithOptionsAsync(request, runtime);
        }

        public GenerateDataKeyResponse GenerateDataKeyWithOptions(GenerateDataKeyRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GenerateDataKeyShrinkRequest request = new GenerateDataKeyShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EncryptionContext))
            {
                request.EncryptionContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EncryptionContext, "EncryptionContext", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GenerateDataKeyResponse>(DoRPCRequest("GenerateDataKey", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GenerateDataKeyResponse> GenerateDataKeyWithOptionsAsync(GenerateDataKeyRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GenerateDataKeyShrinkRequest request = new GenerateDataKeyShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EncryptionContext))
            {
                request.EncryptionContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EncryptionContext, "EncryptionContext", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GenerateDataKeyResponse>(await DoRPCRequestAsync("GenerateDataKey", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GenerateDataKeyResponse GenerateDataKey(GenerateDataKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateDataKeyWithOptions(request, runtime);
        }

        public async Task<GenerateDataKeyResponse> GenerateDataKeyAsync(GenerateDataKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateDataKeyWithOptionsAsync(request, runtime);
        }

        public GenerateDataKeyWithoutPlaintextResponse GenerateDataKeyWithoutPlaintextWithOptions(GenerateDataKeyWithoutPlaintextRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GenerateDataKeyWithoutPlaintextShrinkRequest request = new GenerateDataKeyWithoutPlaintextShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EncryptionContext))
            {
                request.EncryptionContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EncryptionContext, "EncryptionContext", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GenerateDataKeyWithoutPlaintextResponse>(DoRPCRequest("GenerateDataKeyWithoutPlaintext", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GenerateDataKeyWithoutPlaintextResponse> GenerateDataKeyWithoutPlaintextWithOptionsAsync(GenerateDataKeyWithoutPlaintextRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GenerateDataKeyWithoutPlaintextShrinkRequest request = new GenerateDataKeyWithoutPlaintextShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EncryptionContext))
            {
                request.EncryptionContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EncryptionContext, "EncryptionContext", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GenerateDataKeyWithoutPlaintextResponse>(await DoRPCRequestAsync("GenerateDataKeyWithoutPlaintext", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GenerateDataKeyWithoutPlaintextResponse GenerateDataKeyWithoutPlaintext(GenerateDataKeyWithoutPlaintextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateDataKeyWithoutPlaintextWithOptions(request, runtime);
        }

        public async Task<GenerateDataKeyWithoutPlaintextResponse> GenerateDataKeyWithoutPlaintextAsync(GenerateDataKeyWithoutPlaintextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateDataKeyWithoutPlaintextWithOptionsAsync(request, runtime);
        }

        public GetCertificateResponse GetCertificateWithOptions(GetCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetCertificateResponse>(DoRPCRequest("GetCertificate", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetCertificateResponse> GetCertificateWithOptionsAsync(GetCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetCertificateResponse>(await DoRPCRequestAsync("GetCertificate", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetCertificateResponse GetCertificate(GetCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCertificateWithOptions(request, runtime);
        }

        public async Task<GetCertificateResponse> GetCertificateAsync(GetCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCertificateWithOptionsAsync(request, runtime);
        }

        public GetParametersForImportResponse GetParametersForImportWithOptions(GetParametersForImportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetParametersForImportResponse>(DoRPCRequest("GetParametersForImport", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetParametersForImportResponse> GetParametersForImportWithOptionsAsync(GetParametersForImportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetParametersForImportResponse>(await DoRPCRequestAsync("GetParametersForImport", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetParametersForImportResponse GetParametersForImport(GetParametersForImportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetParametersForImportWithOptions(request, runtime);
        }

        public async Task<GetParametersForImportResponse> GetParametersForImportAsync(GetParametersForImportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetParametersForImportWithOptionsAsync(request, runtime);
        }

        public GetPublicKeyResponse GetPublicKeyWithOptions(GetPublicKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetPublicKeyResponse>(DoRPCRequest("GetPublicKey", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetPublicKeyResponse> GetPublicKeyWithOptionsAsync(GetPublicKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetPublicKeyResponse>(await DoRPCRequestAsync("GetPublicKey", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetPublicKeyResponse GetPublicKey(GetPublicKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPublicKeyWithOptions(request, runtime);
        }

        public async Task<GetPublicKeyResponse> GetPublicKeyAsync(GetPublicKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPublicKeyWithOptionsAsync(request, runtime);
        }

        public GetRandomPasswordResponse GetRandomPasswordWithOptions(GetRandomPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetRandomPasswordResponse>(DoRPCRequest("GetRandomPassword", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetRandomPasswordResponse> GetRandomPasswordWithOptionsAsync(GetRandomPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetRandomPasswordResponse>(await DoRPCRequestAsync("GetRandomPassword", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetRandomPasswordResponse GetRandomPassword(GetRandomPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRandomPasswordWithOptions(request, runtime);
        }

        public async Task<GetRandomPasswordResponse> GetRandomPasswordAsync(GetRandomPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRandomPasswordWithOptionsAsync(request, runtime);
        }

        public GetSecretValueResponse GetSecretValueWithOptions(GetSecretValueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetSecretValueResponse>(DoRPCRequest("GetSecretValue", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetSecretValueResponse> GetSecretValueWithOptionsAsync(GetSecretValueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetSecretValueResponse>(await DoRPCRequestAsync("GetSecretValue", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetSecretValueResponse GetSecretValue(GetSecretValueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSecretValueWithOptions(request, runtime);
        }

        public async Task<GetSecretValueResponse> GetSecretValueAsync(GetSecretValueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSecretValueWithOptionsAsync(request, runtime);
        }

        public ImportCertificateResponse ImportCertificateWithOptions(ImportCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ImportCertificateResponse>(DoRPCRequest("ImportCertificate", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ImportCertificateResponse> ImportCertificateWithOptionsAsync(ImportCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ImportCertificateResponse>(await DoRPCRequestAsync("ImportCertificate", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ImportCertificateResponse ImportCertificate(ImportCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ImportCertificateWithOptions(request, runtime);
        }

        public async Task<ImportCertificateResponse> ImportCertificateAsync(ImportCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ImportCertificateWithOptionsAsync(request, runtime);
        }

        public ImportEncryptionCertificateResponse ImportEncryptionCertificateWithOptions(ImportEncryptionCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ImportEncryptionCertificateResponse>(DoRPCRequest("ImportEncryptionCertificate", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ImportEncryptionCertificateResponse> ImportEncryptionCertificateWithOptionsAsync(ImportEncryptionCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ImportEncryptionCertificateResponse>(await DoRPCRequestAsync("ImportEncryptionCertificate", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ImportEncryptionCertificateResponse ImportEncryptionCertificate(ImportEncryptionCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ImportEncryptionCertificateWithOptions(request, runtime);
        }

        public async Task<ImportEncryptionCertificateResponse> ImportEncryptionCertificateAsync(ImportEncryptionCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ImportEncryptionCertificateWithOptionsAsync(request, runtime);
        }

        public ImportKeyMaterialResponse ImportKeyMaterialWithOptions(ImportKeyMaterialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ImportKeyMaterialResponse>(DoRPCRequest("ImportKeyMaterial", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ImportKeyMaterialResponse> ImportKeyMaterialWithOptionsAsync(ImportKeyMaterialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ImportKeyMaterialResponse>(await DoRPCRequestAsync("ImportKeyMaterial", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ImportKeyMaterialResponse ImportKeyMaterial(ImportKeyMaterialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ImportKeyMaterialWithOptions(request, runtime);
        }

        public async Task<ImportKeyMaterialResponse> ImportKeyMaterialAsync(ImportKeyMaterialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ImportKeyMaterialWithOptionsAsync(request, runtime);
        }

        public ListAliasesResponse ListAliasesWithOptions(ListAliasesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListAliasesResponse>(DoRPCRequest("ListAliases", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListAliasesResponse> ListAliasesWithOptionsAsync(ListAliasesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListAliasesResponse>(await DoRPCRequestAsync("ListAliases", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListAliasesResponse ListAliases(ListAliasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAliasesWithOptions(request, runtime);
        }

        public async Task<ListAliasesResponse> ListAliasesAsync(ListAliasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAliasesWithOptionsAsync(request, runtime);
        }

        public ListAliasesByKeyIdResponse ListAliasesByKeyIdWithOptions(ListAliasesByKeyIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListAliasesByKeyIdResponse>(DoRPCRequest("ListAliasesByKeyId", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListAliasesByKeyIdResponse> ListAliasesByKeyIdWithOptionsAsync(ListAliasesByKeyIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListAliasesByKeyIdResponse>(await DoRPCRequestAsync("ListAliasesByKeyId", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListAliasesByKeyIdResponse ListAliasesByKeyId(ListAliasesByKeyIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAliasesByKeyIdWithOptions(request, runtime);
        }

        public async Task<ListAliasesByKeyIdResponse> ListAliasesByKeyIdAsync(ListAliasesByKeyIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAliasesByKeyIdWithOptionsAsync(request, runtime);
        }

        public ListCertificatesResponse ListCertificatesWithOptions(ListCertificatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListCertificatesResponse>(DoRPCRequest("ListCertificates", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListCertificatesResponse> ListCertificatesWithOptionsAsync(ListCertificatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListCertificatesResponse>(await DoRPCRequestAsync("ListCertificates", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListCertificatesResponse ListCertificates(ListCertificatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCertificatesWithOptions(request, runtime);
        }

        public async Task<ListCertificatesResponse> ListCertificatesAsync(ListCertificatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCertificatesWithOptionsAsync(request, runtime);
        }

        public ListKeysResponse ListKeysWithOptions(ListKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListKeysResponse>(DoRPCRequest("ListKeys", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListKeysResponse> ListKeysWithOptionsAsync(ListKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListKeysResponse>(await DoRPCRequestAsync("ListKeys", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListKeysResponse ListKeys(ListKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListKeysWithOptions(request, runtime);
        }

        public async Task<ListKeysResponse> ListKeysAsync(ListKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListKeysWithOptionsAsync(request, runtime);
        }

        public ListKeyVersionsResponse ListKeyVersionsWithOptions(ListKeyVersionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListKeyVersionsResponse>(DoRPCRequest("ListKeyVersions", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListKeyVersionsResponse> ListKeyVersionsWithOptionsAsync(ListKeyVersionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListKeyVersionsResponse>(await DoRPCRequestAsync("ListKeyVersions", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListKeyVersionsResponse ListKeyVersions(ListKeyVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListKeyVersionsWithOptions(request, runtime);
        }

        public async Task<ListKeyVersionsResponse> ListKeyVersionsAsync(ListKeyVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListKeyVersionsWithOptionsAsync(request, runtime);
        }

        public ListResourceTagsResponse ListResourceTagsWithOptions(ListResourceTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListResourceTagsResponse>(DoRPCRequest("ListResourceTags", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListResourceTagsResponse> ListResourceTagsWithOptionsAsync(ListResourceTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListResourceTagsResponse>(await DoRPCRequestAsync("ListResourceTags", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListResourceTagsResponse ListResourceTags(ListResourceTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListResourceTagsWithOptions(request, runtime);
        }

        public async Task<ListResourceTagsResponse> ListResourceTagsAsync(ListResourceTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListResourceTagsWithOptionsAsync(request, runtime);
        }

        public ListSecretsResponse ListSecretsWithOptions(ListSecretsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListSecretsResponse>(DoRPCRequest("ListSecrets", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListSecretsResponse> ListSecretsWithOptionsAsync(ListSecretsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListSecretsResponse>(await DoRPCRequestAsync("ListSecrets", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListSecretsResponse ListSecrets(ListSecretsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSecretsWithOptions(request, runtime);
        }

        public async Task<ListSecretsResponse> ListSecretsAsync(ListSecretsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSecretsWithOptionsAsync(request, runtime);
        }

        public ListSecretVersionIdsResponse ListSecretVersionIdsWithOptions(ListSecretVersionIdsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListSecretVersionIdsResponse>(DoRPCRequest("ListSecretVersionIds", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListSecretVersionIdsResponse> ListSecretVersionIdsWithOptionsAsync(ListSecretVersionIdsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListSecretVersionIdsResponse>(await DoRPCRequestAsync("ListSecretVersionIds", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListSecretVersionIdsResponse ListSecretVersionIds(ListSecretVersionIdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSecretVersionIdsWithOptions(request, runtime);
        }

        public async Task<ListSecretVersionIdsResponse> ListSecretVersionIdsAsync(ListSecretVersionIdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSecretVersionIdsWithOptionsAsync(request, runtime);
        }

        public OpenKmsServiceResponse OpenKmsServiceWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<OpenKmsServiceResponse>(DoRPCRequest("OpenKmsService", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<OpenKmsServiceResponse> OpenKmsServiceWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<OpenKmsServiceResponse>(await DoRPCRequestAsync("OpenKmsService", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public OpenKmsServiceResponse OpenKmsService()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OpenKmsServiceWithOptions(runtime);
        }

        public async Task<OpenKmsServiceResponse> OpenKmsServiceAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OpenKmsServiceWithOptionsAsync(runtime);
        }

        public PutSecretValueResponse PutSecretValueWithOptions(PutSecretValueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PutSecretValueResponse>(DoRPCRequest("PutSecretValue", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PutSecretValueResponse> PutSecretValueWithOptionsAsync(PutSecretValueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PutSecretValueResponse>(await DoRPCRequestAsync("PutSecretValue", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PutSecretValueResponse PutSecretValue(PutSecretValueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PutSecretValueWithOptions(request, runtime);
        }

        public async Task<PutSecretValueResponse> PutSecretValueAsync(PutSecretValueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PutSecretValueWithOptionsAsync(request, runtime);
        }

        public ReEncryptResponse ReEncryptWithOptions(ReEncryptRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ReEncryptShrinkRequest request = new ReEncryptShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceEncryptionContext))
            {
                request.SourceEncryptionContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceEncryptionContext, "SourceEncryptionContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DestinationEncryptionContext))
            {
                request.DestinationEncryptionContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DestinationEncryptionContext, "DestinationEncryptionContext", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReEncryptResponse>(DoRPCRequest("ReEncrypt", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ReEncryptResponse> ReEncryptWithOptionsAsync(ReEncryptRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ReEncryptShrinkRequest request = new ReEncryptShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceEncryptionContext))
            {
                request.SourceEncryptionContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceEncryptionContext, "SourceEncryptionContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DestinationEncryptionContext))
            {
                request.DestinationEncryptionContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DestinationEncryptionContext, "DestinationEncryptionContext", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReEncryptResponse>(await DoRPCRequestAsync("ReEncrypt", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ReEncryptResponse ReEncrypt(ReEncryptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReEncryptWithOptions(request, runtime);
        }

        public async Task<ReEncryptResponse> ReEncryptAsync(ReEncryptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReEncryptWithOptionsAsync(request, runtime);
        }

        public RestoreSecretResponse RestoreSecretWithOptions(RestoreSecretRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RestoreSecretResponse>(DoRPCRequest("RestoreSecret", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RestoreSecretResponse> RestoreSecretWithOptionsAsync(RestoreSecretRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RestoreSecretResponse>(await DoRPCRequestAsync("RestoreSecret", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RestoreSecretResponse RestoreSecret(RestoreSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RestoreSecretWithOptions(request, runtime);
        }

        public async Task<RestoreSecretResponse> RestoreSecretAsync(RestoreSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RestoreSecretWithOptionsAsync(request, runtime);
        }

        public RotateSecretResponse RotateSecretWithOptions(RotateSecretRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RotateSecretResponse>(DoRPCRequest("RotateSecret", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RotateSecretResponse> RotateSecretWithOptionsAsync(RotateSecretRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RotateSecretResponse>(await DoRPCRequestAsync("RotateSecret", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RotateSecretResponse RotateSecret(RotateSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RotateSecretWithOptions(request, runtime);
        }

        public async Task<RotateSecretResponse> RotateSecretAsync(RotateSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RotateSecretWithOptionsAsync(request, runtime);
        }

        public ScheduleKeyDeletionResponse ScheduleKeyDeletionWithOptions(ScheduleKeyDeletionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ScheduleKeyDeletionResponse>(DoRPCRequest("ScheduleKeyDeletion", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ScheduleKeyDeletionResponse> ScheduleKeyDeletionWithOptionsAsync(ScheduleKeyDeletionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ScheduleKeyDeletionResponse>(await DoRPCRequestAsync("ScheduleKeyDeletion", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ScheduleKeyDeletionResponse ScheduleKeyDeletion(ScheduleKeyDeletionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ScheduleKeyDeletionWithOptions(request, runtime);
        }

        public async Task<ScheduleKeyDeletionResponse> ScheduleKeyDeletionAsync(ScheduleKeyDeletionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ScheduleKeyDeletionWithOptionsAsync(request, runtime);
        }

        public TagResourceResponse TagResourceWithOptions(TagResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TagResourceResponse>(DoRPCRequest("TagResource", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<TagResourceResponse> TagResourceWithOptionsAsync(TagResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TagResourceResponse>(await DoRPCRequestAsync("TagResource", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public TagResourceResponse TagResource(TagResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TagResourceWithOptions(request, runtime);
        }

        public async Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TagResourceWithOptionsAsync(request, runtime);
        }

        public UntagResourceResponse UntagResourceWithOptions(UntagResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UntagResourceResponse>(DoRPCRequest("UntagResource", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UntagResourceResponse> UntagResourceWithOptionsAsync(UntagResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UntagResourceResponse>(await DoRPCRequestAsync("UntagResource", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UntagResourceWithOptions(request, runtime);
        }

        public async Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UntagResourceWithOptionsAsync(request, runtime);
        }

        public UpdateAliasResponse UpdateAliasWithOptions(UpdateAliasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateAliasResponse>(DoRPCRequest("UpdateAlias", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateAliasResponse> UpdateAliasWithOptionsAsync(UpdateAliasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateAliasResponse>(await DoRPCRequestAsync("UpdateAlias", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateAliasResponse UpdateAlias(UpdateAliasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAliasWithOptions(request, runtime);
        }

        public async Task<UpdateAliasResponse> UpdateAliasAsync(UpdateAliasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAliasWithOptionsAsync(request, runtime);
        }

        public UpdateCertificateStatusResponse UpdateCertificateStatusWithOptions(UpdateCertificateStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateCertificateStatusResponse>(DoRPCRequest("UpdateCertificateStatus", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateCertificateStatusResponse> UpdateCertificateStatusWithOptionsAsync(UpdateCertificateStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateCertificateStatusResponse>(await DoRPCRequestAsync("UpdateCertificateStatus", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateCertificateStatusResponse UpdateCertificateStatus(UpdateCertificateStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateCertificateStatusWithOptions(request, runtime);
        }

        public async Task<UpdateCertificateStatusResponse> UpdateCertificateStatusAsync(UpdateCertificateStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateCertificateStatusWithOptionsAsync(request, runtime);
        }

        public UpdateKeyDescriptionResponse UpdateKeyDescriptionWithOptions(UpdateKeyDescriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateKeyDescriptionResponse>(DoRPCRequest("UpdateKeyDescription", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateKeyDescriptionResponse> UpdateKeyDescriptionWithOptionsAsync(UpdateKeyDescriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateKeyDescriptionResponse>(await DoRPCRequestAsync("UpdateKeyDescription", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateKeyDescriptionResponse UpdateKeyDescription(UpdateKeyDescriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateKeyDescriptionWithOptions(request, runtime);
        }

        public async Task<UpdateKeyDescriptionResponse> UpdateKeyDescriptionAsync(UpdateKeyDescriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateKeyDescriptionWithOptionsAsync(request, runtime);
        }

        public UpdateRotationPolicyResponse UpdateRotationPolicyWithOptions(UpdateRotationPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateRotationPolicyResponse>(DoRPCRequest("UpdateRotationPolicy", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateRotationPolicyResponse> UpdateRotationPolicyWithOptionsAsync(UpdateRotationPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateRotationPolicyResponse>(await DoRPCRequestAsync("UpdateRotationPolicy", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateRotationPolicyResponse UpdateRotationPolicy(UpdateRotationPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateRotationPolicyWithOptions(request, runtime);
        }

        public async Task<UpdateRotationPolicyResponse> UpdateRotationPolicyAsync(UpdateRotationPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateRotationPolicyWithOptionsAsync(request, runtime);
        }

        public UpdateSecretRotationPolicyResponse UpdateSecretRotationPolicyWithOptions(UpdateSecretRotationPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateSecretRotationPolicyResponse>(DoRPCRequest("UpdateSecretRotationPolicy", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateSecretRotationPolicyResponse> UpdateSecretRotationPolicyWithOptionsAsync(UpdateSecretRotationPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateSecretRotationPolicyResponse>(await DoRPCRequestAsync("UpdateSecretRotationPolicy", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateSecretRotationPolicyResponse UpdateSecretRotationPolicy(UpdateSecretRotationPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateSecretRotationPolicyWithOptions(request, runtime);
        }

        public async Task<UpdateSecretRotationPolicyResponse> UpdateSecretRotationPolicyAsync(UpdateSecretRotationPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateSecretRotationPolicyWithOptionsAsync(request, runtime);
        }

        public UpdateSecretVersionStageResponse UpdateSecretVersionStageWithOptions(UpdateSecretVersionStageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateSecretVersionStageResponse>(DoRPCRequest("UpdateSecretVersionStage", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateSecretVersionStageResponse> UpdateSecretVersionStageWithOptionsAsync(UpdateSecretVersionStageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateSecretVersionStageResponse>(await DoRPCRequestAsync("UpdateSecretVersionStage", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateSecretVersionStageResponse UpdateSecretVersionStage(UpdateSecretVersionStageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateSecretVersionStageWithOptions(request, runtime);
        }

        public async Task<UpdateSecretVersionStageResponse> UpdateSecretVersionStageAsync(UpdateSecretVersionStageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateSecretVersionStageWithOptionsAsync(request, runtime);
        }

        public UploadCertificateResponse UploadCertificateWithOptions(UploadCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UploadCertificateResponse>(DoRPCRequest("UploadCertificate", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UploadCertificateResponse> UploadCertificateWithOptionsAsync(UploadCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UploadCertificateResponse>(await DoRPCRequestAsync("UploadCertificate", "2016-01-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UploadCertificateResponse UploadCertificate(UploadCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UploadCertificateWithOptions(request, runtime);
        }

        public async Task<UploadCertificateResponse> UploadCertificateAsync(UploadCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UploadCertificateWithOptionsAsync(request, runtime);
        }

    }
}
