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
            this._productId = "Kms";
            AlibabaCloud.GatewayPop.Client gatewayClient = new AlibabaCloud.GatewayPop.Client();
            this._spi = gatewayClient;
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

        /**
         * @summary Decrypts data by using an asymmetric key.
         *
         * @description This operation supports only asymmetric keys for which the **Usage** parameter is set to **ENCRYPT/DECRYPT**. The following table lists supported encryption algorithms. 
         * | KeySpec | Algorithm | Description | Maximum length in bytes |
         * | ------- | --------- | ----------- | ----------------------- |
         * | RSA_2048 | RSAES_OAEP_SHA_256 | RSAES-OAEP using SHA-256 and MGF1 with SHA-256 | 256 |
         * | RSA_2048 | RSAES_OAEP_SHA_1 | RSAES-OAEP using SHA1 and MGF1 with SHA1 | 256 |
         * | RSA_3072 | RSAES_OAEP_SHA_256 | RSAES-OAEP using SHA-256 and MGF1 with SHA-256 | 384 |
         * | RSA_3072 | RSAES_OAEP_SHA_1 | RSAES-OAEP using SHA1 and MGF1 with SHA1 | 384 |
         * | EC_SM2 | SM2PKE | SM2 public key encryption algorithm based on elliptic curves | 6144 |
         * In this example, the asymmetric key whose ID is `5c438b18-05be-40ad-b6c2-3be6752c****` and version ID is `2ab1a983-7072-4bbc-a582-584b5bd8****` and the decryption algorithm `RSAES_OAEP_SHA_1` are used to decrypt the ciphertext `BQKP+1zK6+ZEMxTP5qaVzcsgXtWplYBKm0NXdSnB5FzliFxE1bSiu4dnEIlca2JpeH7yz1/S6fed630H+hIH6DoM25fTLNcKj+mFB0Xnh9m2+HN59Mn4qyTfcUeadnfCXSWcGBouhXFwcdd2rJ3n337bzTf4jm659gZu3L0i6PLuxM9p7mqdwO0cKJPfGVfhnfMz+f4alMg79WB/NNyE2lyX7/qxvV49ObNrrJbKSFiz8Djocaf0IESNLMbfYI5bXjWkJlX92DQbKhibtQW8ZOJ//ZC6t0AWcUoKL6QDm/dg5koQalcleRinpB+QadFm894sLbVZ9+N4GVsv1W****==`.
         *
         * @param request AsymmetricDecryptRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AsymmetricDecryptResponse
         */
        public AsymmetricDecryptResponse AsymmetricDecryptWithOptions(AsymmetricDecryptRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Algorithm))
            {
                query["Algorithm"] = request.Algorithm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CiphertextBlob))
            {
                query["CiphertextBlob"] = request.CiphertextBlob;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyId))
            {
                query["KeyId"] = request.KeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyVersionId))
            {
                query["KeyVersionId"] = request.KeyVersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AsymmetricDecrypt",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<AsymmetricDecryptResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<AsymmetricDecryptResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @summary Decrypts data by using an asymmetric key.
         *
         * @description This operation supports only asymmetric keys for which the **Usage** parameter is set to **ENCRYPT/DECRYPT**. The following table lists supported encryption algorithms. 
         * | KeySpec | Algorithm | Description | Maximum length in bytes |
         * | ------- | --------- | ----------- | ----------------------- |
         * | RSA_2048 | RSAES_OAEP_SHA_256 | RSAES-OAEP using SHA-256 and MGF1 with SHA-256 | 256 |
         * | RSA_2048 | RSAES_OAEP_SHA_1 | RSAES-OAEP using SHA1 and MGF1 with SHA1 | 256 |
         * | RSA_3072 | RSAES_OAEP_SHA_256 | RSAES-OAEP using SHA-256 and MGF1 with SHA-256 | 384 |
         * | RSA_3072 | RSAES_OAEP_SHA_1 | RSAES-OAEP using SHA1 and MGF1 with SHA1 | 384 |
         * | EC_SM2 | SM2PKE | SM2 public key encryption algorithm based on elliptic curves | 6144 |
         * In this example, the asymmetric key whose ID is `5c438b18-05be-40ad-b6c2-3be6752c****` and version ID is `2ab1a983-7072-4bbc-a582-584b5bd8****` and the decryption algorithm `RSAES_OAEP_SHA_1` are used to decrypt the ciphertext `BQKP+1zK6+ZEMxTP5qaVzcsgXtWplYBKm0NXdSnB5FzliFxE1bSiu4dnEIlca2JpeH7yz1/S6fed630H+hIH6DoM25fTLNcKj+mFB0Xnh9m2+HN59Mn4qyTfcUeadnfCXSWcGBouhXFwcdd2rJ3n337bzTf4jm659gZu3L0i6PLuxM9p7mqdwO0cKJPfGVfhnfMz+f4alMg79WB/NNyE2lyX7/qxvV49ObNrrJbKSFiz8Djocaf0IESNLMbfYI5bXjWkJlX92DQbKhibtQW8ZOJ//ZC6t0AWcUoKL6QDm/dg5koQalcleRinpB+QadFm894sLbVZ9+N4GVsv1W****==`.
         *
         * @param request AsymmetricDecryptRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AsymmetricDecryptResponse
         */
        public async Task<AsymmetricDecryptResponse> AsymmetricDecryptWithOptionsAsync(AsymmetricDecryptRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Algorithm))
            {
                query["Algorithm"] = request.Algorithm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CiphertextBlob))
            {
                query["CiphertextBlob"] = request.CiphertextBlob;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyId))
            {
                query["KeyId"] = request.KeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyVersionId))
            {
                query["KeyVersionId"] = request.KeyVersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AsymmetricDecrypt",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<AsymmetricDecryptResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<AsymmetricDecryptResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @summary Decrypts data by using an asymmetric key.
         *
         * @description This operation supports only asymmetric keys for which the **Usage** parameter is set to **ENCRYPT/DECRYPT**. The following table lists supported encryption algorithms. 
         * | KeySpec | Algorithm | Description | Maximum length in bytes |
         * | ------- | --------- | ----------- | ----------------------- |
         * | RSA_2048 | RSAES_OAEP_SHA_256 | RSAES-OAEP using SHA-256 and MGF1 with SHA-256 | 256 |
         * | RSA_2048 | RSAES_OAEP_SHA_1 | RSAES-OAEP using SHA1 and MGF1 with SHA1 | 256 |
         * | RSA_3072 | RSAES_OAEP_SHA_256 | RSAES-OAEP using SHA-256 and MGF1 with SHA-256 | 384 |
         * | RSA_3072 | RSAES_OAEP_SHA_1 | RSAES-OAEP using SHA1 and MGF1 with SHA1 | 384 |
         * | EC_SM2 | SM2PKE | SM2 public key encryption algorithm based on elliptic curves | 6144 |
         * In this example, the asymmetric key whose ID is `5c438b18-05be-40ad-b6c2-3be6752c****` and version ID is `2ab1a983-7072-4bbc-a582-584b5bd8****` and the decryption algorithm `RSAES_OAEP_SHA_1` are used to decrypt the ciphertext `BQKP+1zK6+ZEMxTP5qaVzcsgXtWplYBKm0NXdSnB5FzliFxE1bSiu4dnEIlca2JpeH7yz1/S6fed630H+hIH6DoM25fTLNcKj+mFB0Xnh9m2+HN59Mn4qyTfcUeadnfCXSWcGBouhXFwcdd2rJ3n337bzTf4jm659gZu3L0i6PLuxM9p7mqdwO0cKJPfGVfhnfMz+f4alMg79WB/NNyE2lyX7/qxvV49ObNrrJbKSFiz8Djocaf0IESNLMbfYI5bXjWkJlX92DQbKhibtQW8ZOJ//ZC6t0AWcUoKL6QDm/dg5koQalcleRinpB+QadFm894sLbVZ9+N4GVsv1W****==`.
         *
         * @param request AsymmetricDecryptRequest
         * @return AsymmetricDecryptResponse
         */
        public AsymmetricDecryptResponse AsymmetricDecrypt(AsymmetricDecryptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AsymmetricDecryptWithOptions(request, runtime);
        }

        /**
         * @summary Decrypts data by using an asymmetric key.
         *
         * @description This operation supports only asymmetric keys for which the **Usage** parameter is set to **ENCRYPT/DECRYPT**. The following table lists supported encryption algorithms. 
         * | KeySpec | Algorithm | Description | Maximum length in bytes |
         * | ------- | --------- | ----------- | ----------------------- |
         * | RSA_2048 | RSAES_OAEP_SHA_256 | RSAES-OAEP using SHA-256 and MGF1 with SHA-256 | 256 |
         * | RSA_2048 | RSAES_OAEP_SHA_1 | RSAES-OAEP using SHA1 and MGF1 with SHA1 | 256 |
         * | RSA_3072 | RSAES_OAEP_SHA_256 | RSAES-OAEP using SHA-256 and MGF1 with SHA-256 | 384 |
         * | RSA_3072 | RSAES_OAEP_SHA_1 | RSAES-OAEP using SHA1 and MGF1 with SHA1 | 384 |
         * | EC_SM2 | SM2PKE | SM2 public key encryption algorithm based on elliptic curves | 6144 |
         * In this example, the asymmetric key whose ID is `5c438b18-05be-40ad-b6c2-3be6752c****` and version ID is `2ab1a983-7072-4bbc-a582-584b5bd8****` and the decryption algorithm `RSAES_OAEP_SHA_1` are used to decrypt the ciphertext `BQKP+1zK6+ZEMxTP5qaVzcsgXtWplYBKm0NXdSnB5FzliFxE1bSiu4dnEIlca2JpeH7yz1/S6fed630H+hIH6DoM25fTLNcKj+mFB0Xnh9m2+HN59Mn4qyTfcUeadnfCXSWcGBouhXFwcdd2rJ3n337bzTf4jm659gZu3L0i6PLuxM9p7mqdwO0cKJPfGVfhnfMz+f4alMg79WB/NNyE2lyX7/qxvV49ObNrrJbKSFiz8Djocaf0IESNLMbfYI5bXjWkJlX92DQbKhibtQW8ZOJ//ZC6t0AWcUoKL6QDm/dg5koQalcleRinpB+QadFm894sLbVZ9+N4GVsv1W****==`.
         *
         * @param request AsymmetricDecryptRequest
         * @return AsymmetricDecryptResponse
         */
        public async Task<AsymmetricDecryptResponse> AsymmetricDecryptAsync(AsymmetricDecryptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AsymmetricDecryptWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Encrypts data by using an asymmetric customer master key (CMK).
         *
         * @description This operation is supported only for asymmetric keys for which the **Usage** parameter is set to **ENCRYPT/DECRYPT**. The following table lists the supported encryption algorithms: 
         * | KeySpec | Algorithm | Description | Maximum number of bytes that can be encrypted |
         * | ------- | --------- | ----------- | --------------------------------------------- |
         * | RSA_2048 | RSAES_OAEP_SHA_256 | RSAES-OAEP using SHA-256 and MGF1 with SHA-256 | 190 |
         * | RSA_2048 | RSAES_OAEP_SHA_1 | RSAES-OAEP using SHA1 and MGF1 with SHA1 | 214 |
         * | RSA_3072 | RSAES_OAEP_SHA_256 | RSAES-OAEP using SHA-256 and MGF1 with SHA-256 | 318 |
         * | RSA_3072 | RSAES_OAEP_SHA_1 | RSAES-OAEP using SHA1 and MGF1 with SHA1 | 342 |
         * | EC_SM2 | SM2PKE | SM2 public key encryption algorithm based on elliptic curves | 6047 |
         * You can use the asymmetric CMK whose ID is `5c438b18-05be-40ad-b6c2-3be6752c****` and version ID is `2ab1a983-7072-4bbc-a582-584b5bd8****` and the algorithm `RSAES_OAEP_SHA_1` to encrypt the plaintext `SGVsbG8gd29ybGQ=` based on the parameter settings provided in this topic.
         *
         * @param request AsymmetricEncryptRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AsymmetricEncryptResponse
         */
        public AsymmetricEncryptResponse AsymmetricEncryptWithOptions(AsymmetricEncryptRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Algorithm))
            {
                query["Algorithm"] = request.Algorithm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyId))
            {
                query["KeyId"] = request.KeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyVersionId))
            {
                query["KeyVersionId"] = request.KeyVersionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Plaintext))
            {
                query["Plaintext"] = request.Plaintext;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AsymmetricEncrypt",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<AsymmetricEncryptResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<AsymmetricEncryptResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @summary Encrypts data by using an asymmetric customer master key (CMK).
         *
         * @description This operation is supported only for asymmetric keys for which the **Usage** parameter is set to **ENCRYPT/DECRYPT**. The following table lists the supported encryption algorithms: 
         * | KeySpec | Algorithm | Description | Maximum number of bytes that can be encrypted |
         * | ------- | --------- | ----------- | --------------------------------------------- |
         * | RSA_2048 | RSAES_OAEP_SHA_256 | RSAES-OAEP using SHA-256 and MGF1 with SHA-256 | 190 |
         * | RSA_2048 | RSAES_OAEP_SHA_1 | RSAES-OAEP using SHA1 and MGF1 with SHA1 | 214 |
         * | RSA_3072 | RSAES_OAEP_SHA_256 | RSAES-OAEP using SHA-256 and MGF1 with SHA-256 | 318 |
         * | RSA_3072 | RSAES_OAEP_SHA_1 | RSAES-OAEP using SHA1 and MGF1 with SHA1 | 342 |
         * | EC_SM2 | SM2PKE | SM2 public key encryption algorithm based on elliptic curves | 6047 |
         * You can use the asymmetric CMK whose ID is `5c438b18-05be-40ad-b6c2-3be6752c****` and version ID is `2ab1a983-7072-4bbc-a582-584b5bd8****` and the algorithm `RSAES_OAEP_SHA_1` to encrypt the plaintext `SGVsbG8gd29ybGQ=` based on the parameter settings provided in this topic.
         *
         * @param request AsymmetricEncryptRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AsymmetricEncryptResponse
         */
        public async Task<AsymmetricEncryptResponse> AsymmetricEncryptWithOptionsAsync(AsymmetricEncryptRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Algorithm))
            {
                query["Algorithm"] = request.Algorithm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyId))
            {
                query["KeyId"] = request.KeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyVersionId))
            {
                query["KeyVersionId"] = request.KeyVersionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Plaintext))
            {
                query["Plaintext"] = request.Plaintext;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AsymmetricEncrypt",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<AsymmetricEncryptResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<AsymmetricEncryptResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @summary Encrypts data by using an asymmetric customer master key (CMK).
         *
         * @description This operation is supported only for asymmetric keys for which the **Usage** parameter is set to **ENCRYPT/DECRYPT**. The following table lists the supported encryption algorithms: 
         * | KeySpec | Algorithm | Description | Maximum number of bytes that can be encrypted |
         * | ------- | --------- | ----------- | --------------------------------------------- |
         * | RSA_2048 | RSAES_OAEP_SHA_256 | RSAES-OAEP using SHA-256 and MGF1 with SHA-256 | 190 |
         * | RSA_2048 | RSAES_OAEP_SHA_1 | RSAES-OAEP using SHA1 and MGF1 with SHA1 | 214 |
         * | RSA_3072 | RSAES_OAEP_SHA_256 | RSAES-OAEP using SHA-256 and MGF1 with SHA-256 | 318 |
         * | RSA_3072 | RSAES_OAEP_SHA_1 | RSAES-OAEP using SHA1 and MGF1 with SHA1 | 342 |
         * | EC_SM2 | SM2PKE | SM2 public key encryption algorithm based on elliptic curves | 6047 |
         * You can use the asymmetric CMK whose ID is `5c438b18-05be-40ad-b6c2-3be6752c****` and version ID is `2ab1a983-7072-4bbc-a582-584b5bd8****` and the algorithm `RSAES_OAEP_SHA_1` to encrypt the plaintext `SGVsbG8gd29ybGQ=` based on the parameter settings provided in this topic.
         *
         * @param request AsymmetricEncryptRequest
         * @return AsymmetricEncryptResponse
         */
        public AsymmetricEncryptResponse AsymmetricEncrypt(AsymmetricEncryptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AsymmetricEncryptWithOptions(request, runtime);
        }

        /**
         * @summary Encrypts data by using an asymmetric customer master key (CMK).
         *
         * @description This operation is supported only for asymmetric keys for which the **Usage** parameter is set to **ENCRYPT/DECRYPT**. The following table lists the supported encryption algorithms: 
         * | KeySpec | Algorithm | Description | Maximum number of bytes that can be encrypted |
         * | ------- | --------- | ----------- | --------------------------------------------- |
         * | RSA_2048 | RSAES_OAEP_SHA_256 | RSAES-OAEP using SHA-256 and MGF1 with SHA-256 | 190 |
         * | RSA_2048 | RSAES_OAEP_SHA_1 | RSAES-OAEP using SHA1 and MGF1 with SHA1 | 214 |
         * | RSA_3072 | RSAES_OAEP_SHA_256 | RSAES-OAEP using SHA-256 and MGF1 with SHA-256 | 318 |
         * | RSA_3072 | RSAES_OAEP_SHA_1 | RSAES-OAEP using SHA1 and MGF1 with SHA1 | 342 |
         * | EC_SM2 | SM2PKE | SM2 public key encryption algorithm based on elliptic curves | 6047 |
         * You can use the asymmetric CMK whose ID is `5c438b18-05be-40ad-b6c2-3be6752c****` and version ID is `2ab1a983-7072-4bbc-a582-584b5bd8****` and the algorithm `RSAES_OAEP_SHA_1` to encrypt the plaintext `SGVsbG8gd29ybGQ=` based on the parameter settings provided in this topic.
         *
         * @param request AsymmetricEncryptRequest
         * @return AsymmetricEncryptResponse
         */
        public async Task<AsymmetricEncryptResponse> AsymmetricEncryptAsync(AsymmetricEncryptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AsymmetricEncryptWithOptionsAsync(request, runtime);
        }

        /**
         * @summary AsymmetricSign
         *
         * @description Generates a signature by using an asymmetric key.
         *
         * @param request AsymmetricSignRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AsymmetricSignResponse
         */
        public AsymmetricSignResponse AsymmetricSignWithOptions(AsymmetricSignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Algorithm))
            {
                query["Algorithm"] = request.Algorithm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Digest))
            {
                query["Digest"] = request.Digest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyId))
            {
                query["KeyId"] = request.KeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyVersionId))
            {
                query["KeyVersionId"] = request.KeyVersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AsymmetricSign",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<AsymmetricSignResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<AsymmetricSignResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @summary AsymmetricSign
         *
         * @description Generates a signature by using an asymmetric key.
         *
         * @param request AsymmetricSignRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AsymmetricSignResponse
         */
        public async Task<AsymmetricSignResponse> AsymmetricSignWithOptionsAsync(AsymmetricSignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Algorithm))
            {
                query["Algorithm"] = request.Algorithm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Digest))
            {
                query["Digest"] = request.Digest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyId))
            {
                query["KeyId"] = request.KeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyVersionId))
            {
                query["KeyVersionId"] = request.KeyVersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AsymmetricSign",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<AsymmetricSignResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<AsymmetricSignResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @summary AsymmetricSign
         *
         * @description Generates a signature by using an asymmetric key.
         *
         * @param request AsymmetricSignRequest
         * @return AsymmetricSignResponse
         */
        public AsymmetricSignResponse AsymmetricSign(AsymmetricSignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AsymmetricSignWithOptions(request, runtime);
        }

        /**
         * @summary AsymmetricSign
         *
         * @description Generates a signature by using an asymmetric key.
         *
         * @param request AsymmetricSignRequest
         * @return AsymmetricSignResponse
         */
        public async Task<AsymmetricSignResponse> AsymmetricSignAsync(AsymmetricSignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AsymmetricSignWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Verifies a signature by using an asymmetric key.
         *
         * @description This operation supports only asymmetric keys for which the **Usage** parameter is set to **SIGN/VERIFY**. The following table describes the supported signature algorithms. 
         * | KeySpec | Algorithm | Description |
         * | ------- | --------- | ----------- |
         * | RSA_2048 | RSA_PSS_SHA_256 | RSASSA-PSS using SHA-256 and MGF1 with SHA-256 |
         * | RSA_2048 | RSA_PKCS1_SHA_256 | RSASSA-PKCS1-v1_5 using SHA-256 |
         * | RSA_3072 | RSA_PSS_SHA_256 | RSASSA-PSS using SHA-256 and MGF1 with SHA-256 |
         * | RSA_3072 | RSA_PKCS1_SHA_256 | RSASSA-PKCS1-v1_5 using SHA-256 |
         * | EC_P256 | ECDSA_SHA_256 | ECDSA on the P-256 Curve(secp256r1) with a SHA-256 digest |
         * | EC_P256K | ECDSA_SHA_256 | ECDSA on the P-256K Curve(secp256k1) with a SHA-256 digest |
         * | EC_SM2 | SM2DSA | SM2 elliptic curve public key encryption algorithm |
         * >  When you calculate the SM2 signature based on GB/T 32918, the **Digest** parameter is used to calculate the digest value of the combination of Z(A) and M, rather than the SM3 digest value. M indicates the original message to be signed. Z(A) indicates the hash value for User A. The hash value is defined in GB/T 32918.  In this example, the asymmetric key whose ID is `5c438b18-05be-40ad-b6c2-3be6752c****` and version ID is `2ab1a983-7072-4bbc-a582-584b5bd8****` and the signature algorithm RSA_PSS_SHA_256 are used to verify the signature `M2CceNZH00ZgL9ED/ZHFp21YRAvYeZHknJUc207OCZ0N9wNn9As4z2bON3FF3je+1Nu+2+/8Zj50HpMTpzYpMp2R93cYmACCmhaYoKydxylbyGzJR8y9likZRCrkD38lRoS40aBBvv/6iRKzQuo9EGYVcel36cMNg00VmYNBy3pa1rwg3gA4l3cy6kjayZja1WGPkVhrVKsrJMdbpl0ApLjXKuD8rw1n1XLCwCUEL5eLPljTZaAveqdOFQOiZnZEGI27qIiZe7I1fN8tcz6anS/gTM7xRKE++5egEvRWlTQQTJeApnPSiUPA+8ZykNdelQsOQh5SrGoyI4A5pq****==` of the digest `ZOyIygCyaOW6GjVnihtTFtIS9PNmskdyMlNKiuyjfzw=`.
         *
         * @param request AsymmetricVerifyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AsymmetricVerifyResponse
         */
        public AsymmetricVerifyResponse AsymmetricVerifyWithOptions(AsymmetricVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Algorithm))
            {
                query["Algorithm"] = request.Algorithm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Digest))
            {
                query["Digest"] = request.Digest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyId))
            {
                query["KeyId"] = request.KeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyVersionId))
            {
                query["KeyVersionId"] = request.KeyVersionId;
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
                Action = "AsymmetricVerify",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<AsymmetricVerifyResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<AsymmetricVerifyResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @summary Verifies a signature by using an asymmetric key.
         *
         * @description This operation supports only asymmetric keys for which the **Usage** parameter is set to **SIGN/VERIFY**. The following table describes the supported signature algorithms. 
         * | KeySpec | Algorithm | Description |
         * | ------- | --------- | ----------- |
         * | RSA_2048 | RSA_PSS_SHA_256 | RSASSA-PSS using SHA-256 and MGF1 with SHA-256 |
         * | RSA_2048 | RSA_PKCS1_SHA_256 | RSASSA-PKCS1-v1_5 using SHA-256 |
         * | RSA_3072 | RSA_PSS_SHA_256 | RSASSA-PSS using SHA-256 and MGF1 with SHA-256 |
         * | RSA_3072 | RSA_PKCS1_SHA_256 | RSASSA-PKCS1-v1_5 using SHA-256 |
         * | EC_P256 | ECDSA_SHA_256 | ECDSA on the P-256 Curve(secp256r1) with a SHA-256 digest |
         * | EC_P256K | ECDSA_SHA_256 | ECDSA on the P-256K Curve(secp256k1) with a SHA-256 digest |
         * | EC_SM2 | SM2DSA | SM2 elliptic curve public key encryption algorithm |
         * >  When you calculate the SM2 signature based on GB/T 32918, the **Digest** parameter is used to calculate the digest value of the combination of Z(A) and M, rather than the SM3 digest value. M indicates the original message to be signed. Z(A) indicates the hash value for User A. The hash value is defined in GB/T 32918.  In this example, the asymmetric key whose ID is `5c438b18-05be-40ad-b6c2-3be6752c****` and version ID is `2ab1a983-7072-4bbc-a582-584b5bd8****` and the signature algorithm RSA_PSS_SHA_256 are used to verify the signature `M2CceNZH00ZgL9ED/ZHFp21YRAvYeZHknJUc207OCZ0N9wNn9As4z2bON3FF3je+1Nu+2+/8Zj50HpMTpzYpMp2R93cYmACCmhaYoKydxylbyGzJR8y9likZRCrkD38lRoS40aBBvv/6iRKzQuo9EGYVcel36cMNg00VmYNBy3pa1rwg3gA4l3cy6kjayZja1WGPkVhrVKsrJMdbpl0ApLjXKuD8rw1n1XLCwCUEL5eLPljTZaAveqdOFQOiZnZEGI27qIiZe7I1fN8tcz6anS/gTM7xRKE++5egEvRWlTQQTJeApnPSiUPA+8ZykNdelQsOQh5SrGoyI4A5pq****==` of the digest `ZOyIygCyaOW6GjVnihtTFtIS9PNmskdyMlNKiuyjfzw=`.
         *
         * @param request AsymmetricVerifyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AsymmetricVerifyResponse
         */
        public async Task<AsymmetricVerifyResponse> AsymmetricVerifyWithOptionsAsync(AsymmetricVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Algorithm))
            {
                query["Algorithm"] = request.Algorithm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Digest))
            {
                query["Digest"] = request.Digest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyId))
            {
                query["KeyId"] = request.KeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyVersionId))
            {
                query["KeyVersionId"] = request.KeyVersionId;
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
                Action = "AsymmetricVerify",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<AsymmetricVerifyResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<AsymmetricVerifyResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @summary Verifies a signature by using an asymmetric key.
         *
         * @description This operation supports only asymmetric keys for which the **Usage** parameter is set to **SIGN/VERIFY**. The following table describes the supported signature algorithms. 
         * | KeySpec | Algorithm | Description |
         * | ------- | --------- | ----------- |
         * | RSA_2048 | RSA_PSS_SHA_256 | RSASSA-PSS using SHA-256 and MGF1 with SHA-256 |
         * | RSA_2048 | RSA_PKCS1_SHA_256 | RSASSA-PKCS1-v1_5 using SHA-256 |
         * | RSA_3072 | RSA_PSS_SHA_256 | RSASSA-PSS using SHA-256 and MGF1 with SHA-256 |
         * | RSA_3072 | RSA_PKCS1_SHA_256 | RSASSA-PKCS1-v1_5 using SHA-256 |
         * | EC_P256 | ECDSA_SHA_256 | ECDSA on the P-256 Curve(secp256r1) with a SHA-256 digest |
         * | EC_P256K | ECDSA_SHA_256 | ECDSA on the P-256K Curve(secp256k1) with a SHA-256 digest |
         * | EC_SM2 | SM2DSA | SM2 elliptic curve public key encryption algorithm |
         * >  When you calculate the SM2 signature based on GB/T 32918, the **Digest** parameter is used to calculate the digest value of the combination of Z(A) and M, rather than the SM3 digest value. M indicates the original message to be signed. Z(A) indicates the hash value for User A. The hash value is defined in GB/T 32918.  In this example, the asymmetric key whose ID is `5c438b18-05be-40ad-b6c2-3be6752c****` and version ID is `2ab1a983-7072-4bbc-a582-584b5bd8****` and the signature algorithm RSA_PSS_SHA_256 are used to verify the signature `M2CceNZH00ZgL9ED/ZHFp21YRAvYeZHknJUc207OCZ0N9wNn9As4z2bON3FF3je+1Nu+2+/8Zj50HpMTpzYpMp2R93cYmACCmhaYoKydxylbyGzJR8y9likZRCrkD38lRoS40aBBvv/6iRKzQuo9EGYVcel36cMNg00VmYNBy3pa1rwg3gA4l3cy6kjayZja1WGPkVhrVKsrJMdbpl0ApLjXKuD8rw1n1XLCwCUEL5eLPljTZaAveqdOFQOiZnZEGI27qIiZe7I1fN8tcz6anS/gTM7xRKE++5egEvRWlTQQTJeApnPSiUPA+8ZykNdelQsOQh5SrGoyI4A5pq****==` of the digest `ZOyIygCyaOW6GjVnihtTFtIS9PNmskdyMlNKiuyjfzw=`.
         *
         * @param request AsymmetricVerifyRequest
         * @return AsymmetricVerifyResponse
         */
        public AsymmetricVerifyResponse AsymmetricVerify(AsymmetricVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AsymmetricVerifyWithOptions(request, runtime);
        }

        /**
         * @summary Verifies a signature by using an asymmetric key.
         *
         * @description This operation supports only asymmetric keys for which the **Usage** parameter is set to **SIGN/VERIFY**. The following table describes the supported signature algorithms. 
         * | KeySpec | Algorithm | Description |
         * | ------- | --------- | ----------- |
         * | RSA_2048 | RSA_PSS_SHA_256 | RSASSA-PSS using SHA-256 and MGF1 with SHA-256 |
         * | RSA_2048 | RSA_PKCS1_SHA_256 | RSASSA-PKCS1-v1_5 using SHA-256 |
         * | RSA_3072 | RSA_PSS_SHA_256 | RSASSA-PSS using SHA-256 and MGF1 with SHA-256 |
         * | RSA_3072 | RSA_PKCS1_SHA_256 | RSASSA-PKCS1-v1_5 using SHA-256 |
         * | EC_P256 | ECDSA_SHA_256 | ECDSA on the P-256 Curve(secp256r1) with a SHA-256 digest |
         * | EC_P256K | ECDSA_SHA_256 | ECDSA on the P-256K Curve(secp256k1) with a SHA-256 digest |
         * | EC_SM2 | SM2DSA | SM2 elliptic curve public key encryption algorithm |
         * >  When you calculate the SM2 signature based on GB/T 32918, the **Digest** parameter is used to calculate the digest value of the combination of Z(A) and M, rather than the SM3 digest value. M indicates the original message to be signed. Z(A) indicates the hash value for User A. The hash value is defined in GB/T 32918.  In this example, the asymmetric key whose ID is `5c438b18-05be-40ad-b6c2-3be6752c****` and version ID is `2ab1a983-7072-4bbc-a582-584b5bd8****` and the signature algorithm RSA_PSS_SHA_256 are used to verify the signature `M2CceNZH00ZgL9ED/ZHFp21YRAvYeZHknJUc207OCZ0N9wNn9As4z2bON3FF3je+1Nu+2+/8Zj50HpMTpzYpMp2R93cYmACCmhaYoKydxylbyGzJR8y9likZRCrkD38lRoS40aBBvv/6iRKzQuo9EGYVcel36cMNg00VmYNBy3pa1rwg3gA4l3cy6kjayZja1WGPkVhrVKsrJMdbpl0ApLjXKuD8rw1n1XLCwCUEL5eLPljTZaAveqdOFQOiZnZEGI27qIiZe7I1fN8tcz6anS/gTM7xRKE++5egEvRWlTQQTJeApnPSiUPA+8ZykNdelQsOQh5SrGoyI4A5pq****==` of the digest `ZOyIygCyaOW6GjVnihtTFtIS9PNmskdyMlNKiuyjfzw=`.
         *
         * @param request AsymmetricVerifyRequest
         * @return AsymmetricVerifyResponse
         */
        public async Task<AsymmetricVerifyResponse> AsymmetricVerifyAsync(AsymmetricVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AsymmetricVerifyWithOptionsAsync(request, runtime);
        }

        /**
         * @description If the deletion task of a CMK is canceled, the CMK returns to the Enabled state.
         *
         * @param request CancelKeyDeletionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelKeyDeletionResponse
         */
        public CancelKeyDeletionResponse CancelKeyDeletionWithOptions(CancelKeyDeletionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyId))
            {
                query["KeyId"] = request.KeyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelKeyDeletion",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<CancelKeyDeletionResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CancelKeyDeletionResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @description If the deletion task of a CMK is canceled, the CMK returns to the Enabled state.
         *
         * @param request CancelKeyDeletionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelKeyDeletionResponse
         */
        public async Task<CancelKeyDeletionResponse> CancelKeyDeletionWithOptionsAsync(CancelKeyDeletionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyId))
            {
                query["KeyId"] = request.KeyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelKeyDeletion",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<CancelKeyDeletionResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CancelKeyDeletionResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @description If the deletion task of a CMK is canceled, the CMK returns to the Enabled state.
         *
         * @param request CancelKeyDeletionRequest
         * @return CancelKeyDeletionResponse
         */
        public CancelKeyDeletionResponse CancelKeyDeletion(CancelKeyDeletionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelKeyDeletionWithOptions(request, runtime);
        }

        /**
         * @description If the deletion task of a CMK is canceled, the CMK returns to the Enabled state.
         *
         * @param request CancelKeyDeletionRequest
         * @return CancelKeyDeletionResponse
         */
        public async Task<CancelKeyDeletionResponse> CancelKeyDeletionAsync(CancelKeyDeletionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelKeyDeletionWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Decrypts data by using a specific certificate.
         *
         * @description Limit: The encryption algorithm in the request parameters must match the key type. 
         * The following table describes the mapping between encryption algorithms and key types.
         * | Algorithm | Key Spec |
         * | --------- | -------- |
         * | RSAES_OAEP_SHA_1 | RSA_2048 |
         * | RSAES_OAEP_SHA_256 | RSA_2048 |
         * | SM2PKE | EC_SM2 |
         * In this example, the certificate whose ID is `12345678-1234-1234-1234-12345678****` and the encryption algorithm `RSAES_OAEP_SHA_256` are used to decrypt the data `ZOyIygCyaOW6Gj****MlNKiuyjfzw=`.
         *
         * @param request CertificatePrivateKeyDecryptRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CertificatePrivateKeyDecryptResponse
         */
        public CertificatePrivateKeyDecryptResponse CertificatePrivateKeyDecryptWithOptions(CertificatePrivateKeyDecryptRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Algorithm))
            {
                query["Algorithm"] = request.Algorithm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertificateId))
            {
                query["CertificateId"] = request.CertificateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CiphertextBlob))
            {
                query["CiphertextBlob"] = request.CiphertextBlob;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CertificatePrivateKeyDecrypt",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<CertificatePrivateKeyDecryptResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CertificatePrivateKeyDecryptResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @summary Decrypts data by using a specific certificate.
         *
         * @description Limit: The encryption algorithm in the request parameters must match the key type. 
         * The following table describes the mapping between encryption algorithms and key types.
         * | Algorithm | Key Spec |
         * | --------- | -------- |
         * | RSAES_OAEP_SHA_1 | RSA_2048 |
         * | RSAES_OAEP_SHA_256 | RSA_2048 |
         * | SM2PKE | EC_SM2 |
         * In this example, the certificate whose ID is `12345678-1234-1234-1234-12345678****` and the encryption algorithm `RSAES_OAEP_SHA_256` are used to decrypt the data `ZOyIygCyaOW6Gj****MlNKiuyjfzw=`.
         *
         * @param request CertificatePrivateKeyDecryptRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CertificatePrivateKeyDecryptResponse
         */
        public async Task<CertificatePrivateKeyDecryptResponse> CertificatePrivateKeyDecryptWithOptionsAsync(CertificatePrivateKeyDecryptRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Algorithm))
            {
                query["Algorithm"] = request.Algorithm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertificateId))
            {
                query["CertificateId"] = request.CertificateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CiphertextBlob))
            {
                query["CiphertextBlob"] = request.CiphertextBlob;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CertificatePrivateKeyDecrypt",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<CertificatePrivateKeyDecryptResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CertificatePrivateKeyDecryptResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @summary Decrypts data by using a specific certificate.
         *
         * @description Limit: The encryption algorithm in the request parameters must match the key type. 
         * The following table describes the mapping between encryption algorithms and key types.
         * | Algorithm | Key Spec |
         * | --------- | -------- |
         * | RSAES_OAEP_SHA_1 | RSA_2048 |
         * | RSAES_OAEP_SHA_256 | RSA_2048 |
         * | SM2PKE | EC_SM2 |
         * In this example, the certificate whose ID is `12345678-1234-1234-1234-12345678****` and the encryption algorithm `RSAES_OAEP_SHA_256` are used to decrypt the data `ZOyIygCyaOW6Gj****MlNKiuyjfzw=`.
         *
         * @param request CertificatePrivateKeyDecryptRequest
         * @return CertificatePrivateKeyDecryptResponse
         */
        public CertificatePrivateKeyDecryptResponse CertificatePrivateKeyDecrypt(CertificatePrivateKeyDecryptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CertificatePrivateKeyDecryptWithOptions(request, runtime);
        }

        /**
         * @summary Decrypts data by using a specific certificate.
         *
         * @description Limit: The encryption algorithm in the request parameters must match the key type. 
         * The following table describes the mapping between encryption algorithms and key types.
         * | Algorithm | Key Spec |
         * | --------- | -------- |
         * | RSAES_OAEP_SHA_1 | RSA_2048 |
         * | RSAES_OAEP_SHA_256 | RSA_2048 |
         * | SM2PKE | EC_SM2 |
         * In this example, the certificate whose ID is `12345678-1234-1234-1234-12345678****` and the encryption algorithm `RSAES_OAEP_SHA_256` are used to decrypt the data `ZOyIygCyaOW6Gj****MlNKiuyjfzw=`.
         *
         * @param request CertificatePrivateKeyDecryptRequest
         * @return CertificatePrivateKeyDecryptResponse
         */
        public async Task<CertificatePrivateKeyDecryptResponse> CertificatePrivateKeyDecryptAsync(CertificatePrivateKeyDecryptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CertificatePrivateKeyDecryptWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Generates a signature by using a specified certificate.
         *
         * @description The signature algorithm in the request parameters must match the key type. The following table describes the mapping between signature algorithms and key types.  
         * | Algorithm | Key Spec |
         * | --------- | -------- |
         * | RSA_PKCS1_SHA_256 | RSA_2048 |
         * | RSA_PSS_SHA_256 | RSA_2048 |
         * | ECDSA_SHA_256 | EC_P256 |
         * | SM2DSA | EC_SM2 |
         * In this example, the certificate whose ID is `12345678-1234-1234-1234-12345678****` and the signature algorithm `ECDSA_SHA_256` are used to generate a signature for the raw data `VGhlIHF1aWNrIGJyb3duIGZveCBqdW1wcyBvdmVyIHRoZSBsYXp5IGRvZy4=`.
         *
         * @param request CertificatePrivateKeySignRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CertificatePrivateKeySignResponse
         */
        public CertificatePrivateKeySignResponse CertificatePrivateKeySignWithOptions(CertificatePrivateKeySignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Algorithm))
            {
                query["Algorithm"] = request.Algorithm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertificateId))
            {
                query["CertificateId"] = request.CertificateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                query["Message"] = request.Message;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageType))
            {
                query["MessageType"] = request.MessageType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CertificatePrivateKeySign",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<CertificatePrivateKeySignResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CertificatePrivateKeySignResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @summary Generates a signature by using a specified certificate.
         *
         * @description The signature algorithm in the request parameters must match the key type. The following table describes the mapping between signature algorithms and key types.  
         * | Algorithm | Key Spec |
         * | --------- | -------- |
         * | RSA_PKCS1_SHA_256 | RSA_2048 |
         * | RSA_PSS_SHA_256 | RSA_2048 |
         * | ECDSA_SHA_256 | EC_P256 |
         * | SM2DSA | EC_SM2 |
         * In this example, the certificate whose ID is `12345678-1234-1234-1234-12345678****` and the signature algorithm `ECDSA_SHA_256` are used to generate a signature for the raw data `VGhlIHF1aWNrIGJyb3duIGZveCBqdW1wcyBvdmVyIHRoZSBsYXp5IGRvZy4=`.
         *
         * @param request CertificatePrivateKeySignRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CertificatePrivateKeySignResponse
         */
        public async Task<CertificatePrivateKeySignResponse> CertificatePrivateKeySignWithOptionsAsync(CertificatePrivateKeySignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Algorithm))
            {
                query["Algorithm"] = request.Algorithm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertificateId))
            {
                query["CertificateId"] = request.CertificateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                query["Message"] = request.Message;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageType))
            {
                query["MessageType"] = request.MessageType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CertificatePrivateKeySign",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<CertificatePrivateKeySignResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CertificatePrivateKeySignResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @summary Generates a signature by using a specified certificate.
         *
         * @description The signature algorithm in the request parameters must match the key type. The following table describes the mapping between signature algorithms and key types.  
         * | Algorithm | Key Spec |
         * | --------- | -------- |
         * | RSA_PKCS1_SHA_256 | RSA_2048 |
         * | RSA_PSS_SHA_256 | RSA_2048 |
         * | ECDSA_SHA_256 | EC_P256 |
         * | SM2DSA | EC_SM2 |
         * In this example, the certificate whose ID is `12345678-1234-1234-1234-12345678****` and the signature algorithm `ECDSA_SHA_256` are used to generate a signature for the raw data `VGhlIHF1aWNrIGJyb3duIGZveCBqdW1wcyBvdmVyIHRoZSBsYXp5IGRvZy4=`.
         *
         * @param request CertificatePrivateKeySignRequest
         * @return CertificatePrivateKeySignResponse
         */
        public CertificatePrivateKeySignResponse CertificatePrivateKeySign(CertificatePrivateKeySignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CertificatePrivateKeySignWithOptions(request, runtime);
        }

        /**
         * @summary Generates a signature by using a specified certificate.
         *
         * @description The signature algorithm in the request parameters must match the key type. The following table describes the mapping between signature algorithms and key types.  
         * | Algorithm | Key Spec |
         * | --------- | -------- |
         * | RSA_PKCS1_SHA_256 | RSA_2048 |
         * | RSA_PSS_SHA_256 | RSA_2048 |
         * | ECDSA_SHA_256 | EC_P256 |
         * | SM2DSA | EC_SM2 |
         * In this example, the certificate whose ID is `12345678-1234-1234-1234-12345678****` and the signature algorithm `ECDSA_SHA_256` are used to generate a signature for the raw data `VGhlIHF1aWNrIGJyb3duIGZveCBqdW1wcyBvdmVyIHRoZSBsYXp5IGRvZy4=`.
         *
         * @param request CertificatePrivateKeySignRequest
         * @return CertificatePrivateKeySignResponse
         */
        public async Task<CertificatePrivateKeySignResponse> CertificatePrivateKeySignAsync(CertificatePrivateKeySignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CertificatePrivateKeySignWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Encrypts data by using a specific certificate.
         *
         * @description Limit: The encryption algorithm in the request parameters must match the key type. 
         * The following table describes the mapping between encryption algorithms and key types.
         * | Algorithm | Key Spec |
         * | --------- | -------- |
         * | RSAES_OAEP_SHA_1 | RSA_2048 |
         * | RSAES_OAEP_SHA_256 | RSA_2048 |
         * | SM2PKE | EC_SM2 |
         * In this example, the certificate whose ID is `12345678-1234-1234-1234-12345678****` and the encryption algorithm `RSAES_OAEP_SHA_256` are used to encrypt the data `VGhlIHF1aWNrIGJyb3duIGZveCBqdW1wcyBvdmVyIHRoZSBsYXp5IGRvZy4=`.
         *
         * @param request CertificatePublicKeyEncryptRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CertificatePublicKeyEncryptResponse
         */
        public CertificatePublicKeyEncryptResponse CertificatePublicKeyEncryptWithOptions(CertificatePublicKeyEncryptRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Algorithm))
            {
                query["Algorithm"] = request.Algorithm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertificateId))
            {
                query["CertificateId"] = request.CertificateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Plaintext))
            {
                query["Plaintext"] = request.Plaintext;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CertificatePublicKeyEncrypt",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<CertificatePublicKeyEncryptResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CertificatePublicKeyEncryptResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @summary Encrypts data by using a specific certificate.
         *
         * @description Limit: The encryption algorithm in the request parameters must match the key type. 
         * The following table describes the mapping between encryption algorithms and key types.
         * | Algorithm | Key Spec |
         * | --------- | -------- |
         * | RSAES_OAEP_SHA_1 | RSA_2048 |
         * | RSAES_OAEP_SHA_256 | RSA_2048 |
         * | SM2PKE | EC_SM2 |
         * In this example, the certificate whose ID is `12345678-1234-1234-1234-12345678****` and the encryption algorithm `RSAES_OAEP_SHA_256` are used to encrypt the data `VGhlIHF1aWNrIGJyb3duIGZveCBqdW1wcyBvdmVyIHRoZSBsYXp5IGRvZy4=`.
         *
         * @param request CertificatePublicKeyEncryptRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CertificatePublicKeyEncryptResponse
         */
        public async Task<CertificatePublicKeyEncryptResponse> CertificatePublicKeyEncryptWithOptionsAsync(CertificatePublicKeyEncryptRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Algorithm))
            {
                query["Algorithm"] = request.Algorithm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertificateId))
            {
                query["CertificateId"] = request.CertificateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Plaintext))
            {
                query["Plaintext"] = request.Plaintext;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CertificatePublicKeyEncrypt",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<CertificatePublicKeyEncryptResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CertificatePublicKeyEncryptResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @summary Encrypts data by using a specific certificate.
         *
         * @description Limit: The encryption algorithm in the request parameters must match the key type. 
         * The following table describes the mapping between encryption algorithms and key types.
         * | Algorithm | Key Spec |
         * | --------- | -------- |
         * | RSAES_OAEP_SHA_1 | RSA_2048 |
         * | RSAES_OAEP_SHA_256 | RSA_2048 |
         * | SM2PKE | EC_SM2 |
         * In this example, the certificate whose ID is `12345678-1234-1234-1234-12345678****` and the encryption algorithm `RSAES_OAEP_SHA_256` are used to encrypt the data `VGhlIHF1aWNrIGJyb3duIGZveCBqdW1wcyBvdmVyIHRoZSBsYXp5IGRvZy4=`.
         *
         * @param request CertificatePublicKeyEncryptRequest
         * @return CertificatePublicKeyEncryptResponse
         */
        public CertificatePublicKeyEncryptResponse CertificatePublicKeyEncrypt(CertificatePublicKeyEncryptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CertificatePublicKeyEncryptWithOptions(request, runtime);
        }

        /**
         * @summary Encrypts data by using a specific certificate.
         *
         * @description Limit: The encryption algorithm in the request parameters must match the key type. 
         * The following table describes the mapping between encryption algorithms and key types.
         * | Algorithm | Key Spec |
         * | --------- | -------- |
         * | RSAES_OAEP_SHA_1 | RSA_2048 |
         * | RSAES_OAEP_SHA_256 | RSA_2048 |
         * | SM2PKE | EC_SM2 |
         * In this example, the certificate whose ID is `12345678-1234-1234-1234-12345678****` and the encryption algorithm `RSAES_OAEP_SHA_256` are used to encrypt the data `VGhlIHF1aWNrIGJyb3duIGZveCBqdW1wcyBvdmVyIHRoZSBsYXp5IGRvZy4=`.
         *
         * @param request CertificatePublicKeyEncryptRequest
         * @return CertificatePublicKeyEncryptResponse
         */
        public async Task<CertificatePublicKeyEncryptResponse> CertificatePublicKeyEncryptAsync(CertificatePublicKeyEncryptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CertificatePublicKeyEncryptWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Verifies a digital signature by using a specified certificate.
         *
         * @description The signature algorithm in the request parameters must match the key type. The following table describes the mapping between signature algorithms and key types.  
         * | Algorithm | Key Spec |
         * | --------- | -------- |
         * | RSA_PKCS1_SHA_256 | RSA_2048 |
         * | RSA_PSS_SHA_256 | RSA_2048 |
         * | ECDSA_SHA_256 | EC_P256 |
         * | SM2DSA | EC_SM2 |
         * In this example, the certificate whose ID is `12345678-1234-1234-1234-12345678****` and the signature algorithm `ECDSA_SHA_256` are used to verify the digital signature `ZOyIygCyaOW6Gj****MlNKiuyjfzw=` of the raw data `VGhlIHF1aWNrIGJyb3duIGZveCBqdW1wcyBvdmVyIHRoZSBsYXp5IGRvZy4=`.
         *
         * @param request CertificatePublicKeyVerifyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CertificatePublicKeyVerifyResponse
         */
        public CertificatePublicKeyVerifyResponse CertificatePublicKeyVerifyWithOptions(CertificatePublicKeyVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Algorithm))
            {
                query["Algorithm"] = request.Algorithm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertificateId))
            {
                query["CertificateId"] = request.CertificateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                query["Message"] = request.Message;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageType))
            {
                query["MessageType"] = request.MessageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignatureValue))
            {
                query["SignatureValue"] = request.SignatureValue;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CertificatePublicKeyVerify",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<CertificatePublicKeyVerifyResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CertificatePublicKeyVerifyResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @summary Verifies a digital signature by using a specified certificate.
         *
         * @description The signature algorithm in the request parameters must match the key type. The following table describes the mapping between signature algorithms and key types.  
         * | Algorithm | Key Spec |
         * | --------- | -------- |
         * | RSA_PKCS1_SHA_256 | RSA_2048 |
         * | RSA_PSS_SHA_256 | RSA_2048 |
         * | ECDSA_SHA_256 | EC_P256 |
         * | SM2DSA | EC_SM2 |
         * In this example, the certificate whose ID is `12345678-1234-1234-1234-12345678****` and the signature algorithm `ECDSA_SHA_256` are used to verify the digital signature `ZOyIygCyaOW6Gj****MlNKiuyjfzw=` of the raw data `VGhlIHF1aWNrIGJyb3duIGZveCBqdW1wcyBvdmVyIHRoZSBsYXp5IGRvZy4=`.
         *
         * @param request CertificatePublicKeyVerifyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CertificatePublicKeyVerifyResponse
         */
        public async Task<CertificatePublicKeyVerifyResponse> CertificatePublicKeyVerifyWithOptionsAsync(CertificatePublicKeyVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Algorithm))
            {
                query["Algorithm"] = request.Algorithm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertificateId))
            {
                query["CertificateId"] = request.CertificateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                query["Message"] = request.Message;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageType))
            {
                query["MessageType"] = request.MessageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignatureValue))
            {
                query["SignatureValue"] = request.SignatureValue;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CertificatePublicKeyVerify",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<CertificatePublicKeyVerifyResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CertificatePublicKeyVerifyResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @summary Verifies a digital signature by using a specified certificate.
         *
         * @description The signature algorithm in the request parameters must match the key type. The following table describes the mapping between signature algorithms and key types.  
         * | Algorithm | Key Spec |
         * | --------- | -------- |
         * | RSA_PKCS1_SHA_256 | RSA_2048 |
         * | RSA_PSS_SHA_256 | RSA_2048 |
         * | ECDSA_SHA_256 | EC_P256 |
         * | SM2DSA | EC_SM2 |
         * In this example, the certificate whose ID is `12345678-1234-1234-1234-12345678****` and the signature algorithm `ECDSA_SHA_256` are used to verify the digital signature `ZOyIygCyaOW6Gj****MlNKiuyjfzw=` of the raw data `VGhlIHF1aWNrIGJyb3duIGZveCBqdW1wcyBvdmVyIHRoZSBsYXp5IGRvZy4=`.
         *
         * @param request CertificatePublicKeyVerifyRequest
         * @return CertificatePublicKeyVerifyResponse
         */
        public CertificatePublicKeyVerifyResponse CertificatePublicKeyVerify(CertificatePublicKeyVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CertificatePublicKeyVerifyWithOptions(request, runtime);
        }

        /**
         * @summary Verifies a digital signature by using a specified certificate.
         *
         * @description The signature algorithm in the request parameters must match the key type. The following table describes the mapping between signature algorithms and key types.  
         * | Algorithm | Key Spec |
         * | --------- | -------- |
         * | RSA_PKCS1_SHA_256 | RSA_2048 |
         * | RSA_PSS_SHA_256 | RSA_2048 |
         * | ECDSA_SHA_256 | EC_P256 |
         * | SM2DSA | EC_SM2 |
         * In this example, the certificate whose ID is `12345678-1234-1234-1234-12345678****` and the signature algorithm `ECDSA_SHA_256` are used to verify the digital signature `ZOyIygCyaOW6Gj****MlNKiuyjfzw=` of the raw data `VGhlIHF1aWNrIGJyb3duIGZveCBqdW1wcyBvdmVyIHRoZSBsYXp5IGRvZy4=`.
         *
         * @param request CertificatePublicKeyVerifyRequest
         * @return CertificatePublicKeyVerifyResponse
         */
        public async Task<CertificatePublicKeyVerifyResponse> CertificatePublicKeyVerifyAsync(CertificatePublicKeyVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CertificatePublicKeyVerifyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Enables a Key Management Service (KMS) instance.
         *
         * @description ### [](#)Limits
         * You can enable only instances of the software key management type. You cannot enable instances of the hardware key management type.
         *
         * @param request ConnectKmsInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ConnectKmsInstanceResponse
         */
        public ConnectKmsInstanceResponse ConnectKmsInstanceWithOptions(ConnectKmsInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KMProvider))
            {
                query["KMProvider"] = request.KMProvider;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KmsInstanceId))
            {
                query["KmsInstanceId"] = request.KmsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchIds))
            {
                query["VSwitchIds"] = request.VSwitchIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneIds))
            {
                query["ZoneIds"] = request.ZoneIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConnectKmsInstance",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<ConnectKmsInstanceResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ConnectKmsInstanceResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @summary Enables a Key Management Service (KMS) instance.
         *
         * @description ### [](#)Limits
         * You can enable only instances of the software key management type. You cannot enable instances of the hardware key management type.
         *
         * @param request ConnectKmsInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ConnectKmsInstanceResponse
         */
        public async Task<ConnectKmsInstanceResponse> ConnectKmsInstanceWithOptionsAsync(ConnectKmsInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KMProvider))
            {
                query["KMProvider"] = request.KMProvider;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KmsInstanceId))
            {
                query["KmsInstanceId"] = request.KmsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchIds))
            {
                query["VSwitchIds"] = request.VSwitchIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneIds))
            {
                query["ZoneIds"] = request.ZoneIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConnectKmsInstance",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<ConnectKmsInstanceResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ConnectKmsInstanceResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @summary Enables a Key Management Service (KMS) instance.
         *
         * @description ### [](#)Limits
         * You can enable only instances of the software key management type. You cannot enable instances of the hardware key management type.
         *
         * @param request ConnectKmsInstanceRequest
         * @return ConnectKmsInstanceResponse
         */
        public ConnectKmsInstanceResponse ConnectKmsInstance(ConnectKmsInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConnectKmsInstanceWithOptions(request, runtime);
        }

        /**
         * @summary Enables a Key Management Service (KMS) instance.
         *
         * @description ### [](#)Limits
         * You can enable only instances of the software key management type. You cannot enable instances of the hardware key management type.
         *
         * @param request ConnectKmsInstanceRequest
         * @return ConnectKmsInstanceResponse
         */
        public async Task<ConnectKmsInstanceResponse> ConnectKmsInstanceAsync(ConnectKmsInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConnectKmsInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @description *   Each alias can be bound to only one CMK at a time.
         * *   The aliases of CMKs in the same region must be unique.
         * In this topic, an alias named `alias/example` is created for a CMK named `7906979c-8e06-46a2-be2d-68e3ccbc****`.
         *
         * @param request CreateAliasRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAliasResponse
         */
        public CreateAliasResponse CreateAliasWithOptions(CreateAliasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliasName))
            {
                query["AliasName"] = request.AliasName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyId))
            {
                query["KeyId"] = request.KeyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAlias",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<CreateAliasResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateAliasResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @description *   Each alias can be bound to only one CMK at a time.
         * *   The aliases of CMKs in the same region must be unique.
         * In this topic, an alias named `alias/example` is created for a CMK named `7906979c-8e06-46a2-be2d-68e3ccbc****`.
         *
         * @param request CreateAliasRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAliasResponse
         */
        public async Task<CreateAliasResponse> CreateAliasWithOptionsAsync(CreateAliasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliasName))
            {
                query["AliasName"] = request.AliasName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyId))
            {
                query["KeyId"] = request.KeyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAlias",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<CreateAliasResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateAliasResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @description *   Each alias can be bound to only one CMK at a time.
         * *   The aliases of CMKs in the same region must be unique.
         * In this topic, an alias named `alias/example` is created for a CMK named `7906979c-8e06-46a2-be2d-68e3ccbc****`.
         *
         * @param request CreateAliasRequest
         * @return CreateAliasResponse
         */
        public CreateAliasResponse CreateAlias(CreateAliasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAliasWithOptions(request, runtime);
        }

        /**
         * @description *   Each alias can be bound to only one CMK at a time.
         * *   The aliases of CMKs in the same region must be unique.
         * In this topic, an alias named `alias/example` is created for a CMK named `7906979c-8e06-46a2-be2d-68e3ccbc****`.
         *
         * @param request CreateAliasRequest
         * @return CreateAliasResponse
         */
        public async Task<CreateAliasResponse> CreateAliasAsync(CreateAliasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAliasWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates an application access point (AAP)
         *
         * @description To perform cryptographic operations and retrieve secret values, self-managed applications must use a client key to access a Key Management Service (KMS) instance. The following process shows how to create a client key-based AAP:
         * 1.Create a network access rule: You can configure the private IP addresses or private CIDR blocks that are allowed to access KMS. For more information, see [CreateNetworkRule](https://help.aliyun.com/document_detail/2539407.html).
         * 2.Create a permission policy: You can configure the keys and secrets that are allowed to access and bind network access rules to the keys and secrets. For more information, see [CreatePolicy](https://help.aliyun.com/document_detail/2539454.html).
         * 3.Create an AAP: You can configure an authentication method and bind a permission policy to an AAP. This topic describes how to create an AAP.
         * 4.Create a client key: You can configure the encryption password and validity period of a client key and bind the client key to an AAP. For more information, see [CreateClientKey](https://help.aliyun.com/document_detail/2539509.html).
         *
         * @param request CreateApplicationAccessPointRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateApplicationAccessPointResponse
         */
        public CreateApplicationAccessPointResponse CreateApplicationAccessPointWithOptions(CreateApplicationAccessPointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthenticationMethod))
            {
                query["AuthenticationMethod"] = request.AuthenticationMethod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Policies))
            {
                query["Policies"] = request.Policies;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateApplicationAccessPoint",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<CreateApplicationAccessPointResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateApplicationAccessPointResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @summary Creates an application access point (AAP)
         *
         * @description To perform cryptographic operations and retrieve secret values, self-managed applications must use a client key to access a Key Management Service (KMS) instance. The following process shows how to create a client key-based AAP:
         * 1.Create a network access rule: You can configure the private IP addresses or private CIDR blocks that are allowed to access KMS. For more information, see [CreateNetworkRule](https://help.aliyun.com/document_detail/2539407.html).
         * 2.Create a permission policy: You can configure the keys and secrets that are allowed to access and bind network access rules to the keys and secrets. For more information, see [CreatePolicy](https://help.aliyun.com/document_detail/2539454.html).
         * 3.Create an AAP: You can configure an authentication method and bind a permission policy to an AAP. This topic describes how to create an AAP.
         * 4.Create a client key: You can configure the encryption password and validity period of a client key and bind the client key to an AAP. For more information, see [CreateClientKey](https://help.aliyun.com/document_detail/2539509.html).
         *
         * @param request CreateApplicationAccessPointRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateApplicationAccessPointResponse
         */
        public async Task<CreateApplicationAccessPointResponse> CreateApplicationAccessPointWithOptionsAsync(CreateApplicationAccessPointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthenticationMethod))
            {
                query["AuthenticationMethod"] = request.AuthenticationMethod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Policies))
            {
                query["Policies"] = request.Policies;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateApplicationAccessPoint",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<CreateApplicationAccessPointResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateApplicationAccessPointResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @summary Creates an application access point (AAP)
         *
         * @description To perform cryptographic operations and retrieve secret values, self-managed applications must use a client key to access a Key Management Service (KMS) instance. The following process shows how to create a client key-based AAP:
         * 1.Create a network access rule: You can configure the private IP addresses or private CIDR blocks that are allowed to access KMS. For more information, see [CreateNetworkRule](https://help.aliyun.com/document_detail/2539407.html).
         * 2.Create a permission policy: You can configure the keys and secrets that are allowed to access and bind network access rules to the keys and secrets. For more information, see [CreatePolicy](https://help.aliyun.com/document_detail/2539454.html).
         * 3.Create an AAP: You can configure an authentication method and bind a permission policy to an AAP. This topic describes how to create an AAP.
         * 4.Create a client key: You can configure the encryption password and validity period of a client key and bind the client key to an AAP. For more information, see [CreateClientKey](https://help.aliyun.com/document_detail/2539509.html).
         *
         * @param request CreateApplicationAccessPointRequest
         * @return CreateApplicationAccessPointResponse
         */
        public CreateApplicationAccessPointResponse CreateApplicationAccessPoint(CreateApplicationAccessPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateApplicationAccessPointWithOptions(request, runtime);
        }

        /**
         * @summary Creates an application access point (AAP)
         *
         * @description To perform cryptographic operations and retrieve secret values, self-managed applications must use a client key to access a Key Management Service (KMS) instance. The following process shows how to create a client key-based AAP:
         * 1.Create a network access rule: You can configure the private IP addresses or private CIDR blocks that are allowed to access KMS. For more information, see [CreateNetworkRule](https://help.aliyun.com/document_detail/2539407.html).
         * 2.Create a permission policy: You can configure the keys and secrets that are allowed to access and bind network access rules to the keys and secrets. For more information, see [CreatePolicy](https://help.aliyun.com/document_detail/2539454.html).
         * 3.Create an AAP: You can configure an authentication method and bind a permission policy to an AAP. This topic describes how to create an AAP.
         * 4.Create a client key: You can configure the encryption password and validity period of a client key and bind the client key to an AAP. For more information, see [CreateClientKey](https://help.aliyun.com/document_detail/2539509.html).
         *
         * @param request CreateApplicationAccessPointRequest
         * @return CreateApplicationAccessPointResponse
         */
        public async Task<CreateApplicationAccessPointResponse> CreateApplicationAccessPointAsync(CreateApplicationAccessPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateApplicationAccessPointWithOptionsAsync(request, runtime);
        }

        /**
         * @description To create a certificate, you must specify the type of the asymmetric key. Certificates Manager generates a private key and returns a certificate signing request (CSR). Submit the CSR in the Privacy Enhanced Mail (PEM) format to a certificate authority (CA) to obtain the formal certificate and certificate chain. Then, call the [UploadCertificate](https://help.aliyun.com/document_detail/212136.html) operation to import the certificate into Certificates Manager.
         * In this example, a certificate is created and the CSR is obtained.
         *
         * @param tmpReq CreateCertificateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateCertificateResponse
         */
        public CreateCertificateResponse CreateCertificateWithOptions(CreateCertificateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateCertificateShrinkRequest request = new CreateCertificateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SubjectAlternativeNames))
            {
                request.SubjectAlternativeNamesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SubjectAlternativeNames, "SubjectAlternativeNames", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExportablePrivateKey))
            {
                query["ExportablePrivateKey"] = request.ExportablePrivateKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeySpec))
            {
                query["KeySpec"] = request.KeySpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Subject))
            {
                query["Subject"] = request.Subject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubjectAlternativeNamesShrink))
            {
                query["SubjectAlternativeNames"] = request.SubjectAlternativeNamesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCertificate",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<CreateCertificateResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateCertificateResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @description To create a certificate, you must specify the type of the asymmetric key. Certificates Manager generates a private key and returns a certificate signing request (CSR). Submit the CSR in the Privacy Enhanced Mail (PEM) format to a certificate authority (CA) to obtain the formal certificate and certificate chain. Then, call the [UploadCertificate](https://help.aliyun.com/document_detail/212136.html) operation to import the certificate into Certificates Manager.
         * In this example, a certificate is created and the CSR is obtained.
         *
         * @param tmpReq CreateCertificateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateCertificateResponse
         */
        public async Task<CreateCertificateResponse> CreateCertificateWithOptionsAsync(CreateCertificateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateCertificateShrinkRequest request = new CreateCertificateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SubjectAlternativeNames))
            {
                request.SubjectAlternativeNamesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SubjectAlternativeNames, "SubjectAlternativeNames", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExportablePrivateKey))
            {
                query["ExportablePrivateKey"] = request.ExportablePrivateKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeySpec))
            {
                query["KeySpec"] = request.KeySpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Subject))
            {
                query["Subject"] = request.Subject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubjectAlternativeNamesShrink))
            {
                query["SubjectAlternativeNames"] = request.SubjectAlternativeNamesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCertificate",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<CreateCertificateResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateCertificateResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @description To create a certificate, you must specify the type of the asymmetric key. Certificates Manager generates a private key and returns a certificate signing request (CSR). Submit the CSR in the Privacy Enhanced Mail (PEM) format to a certificate authority (CA) to obtain the formal certificate and certificate chain. Then, call the [UploadCertificate](https://help.aliyun.com/document_detail/212136.html) operation to import the certificate into Certificates Manager.
         * In this example, a certificate is created and the CSR is obtained.
         *
         * @param request CreateCertificateRequest
         * @return CreateCertificateResponse
         */
        public CreateCertificateResponse CreateCertificate(CreateCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCertificateWithOptions(request, runtime);
        }

        /**
         * @description To create a certificate, you must specify the type of the asymmetric key. Certificates Manager generates a private key and returns a certificate signing request (CSR). Submit the CSR in the Privacy Enhanced Mail (PEM) format to a certificate authority (CA) to obtain the formal certificate and certificate chain. Then, call the [UploadCertificate](https://help.aliyun.com/document_detail/212136.html) operation to import the certificate into Certificates Manager.
         * In this example, a certificate is created and the CSR is obtained.
         *
         * @param request CreateCertificateRequest
         * @return CreateCertificateResponse
         */
        public async Task<CreateCertificateResponse> CreateCertificateAsync(CreateCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCertificateWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a client key.
         *
         * @description To perform cryptographic operations and retrieve secret values, self-managed applications must use a client key to access a Key Management Service (KMS) instance. The following process shows how to create a client key-based application access point (AAP):
         * 1.Create an access control rule: You can configure the private IP addresses or private CIDR blocks that are allowed to access a KMS instance. For more information, see [CreateNetworkRule](https://help.aliyun.com/document_detail/2539407.html).
         * 2.Create a permission policy: You can configure the keys and secrets that are allowed to access and bind access control rules to the keys and secrets. For more information, see [CreatePolicy](https://help.aliyun.com/document_detail/2539454.html).
         * 3.Create an AAP: You can configure an authentication method and bind a permission policy to an AAP. For more information, see [CreateApplicationAccessPoint](https://help.aliyun.com/document_detail/2539467.html).
         * 4.Create a client key: You can configure the encryption password and validity period of a client key and bind the client key to an AAP.
         * ### Precautions
         * A client key has a validity period. After a client key expires, applications into which the client key is integrated cannot access the required KMS instance. You must replace the client key before the client key expires. We recommend that you delete the expired client key in KMS after the new client key is used.
         *
         * @param request CreateClientKeyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateClientKeyResponse
         */
        public CreateClientKeyResponse CreateClientKeyWithOptions(CreateClientKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AapName))
            {
                query["AapName"] = request.AapName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotAfter))
            {
                query["NotAfter"] = request.NotAfter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotBefore))
            {
                query["NotBefore"] = request.NotBefore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateClientKey",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<CreateClientKeyResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateClientKeyResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @summary Creates a client key.
         *
         * @description To perform cryptographic operations and retrieve secret values, self-managed applications must use a client key to access a Key Management Service (KMS) instance. The following process shows how to create a client key-based application access point (AAP):
         * 1.Create an access control rule: You can configure the private IP addresses or private CIDR blocks that are allowed to access a KMS instance. For more information, see [CreateNetworkRule](https://help.aliyun.com/document_detail/2539407.html).
         * 2.Create a permission policy: You can configure the keys and secrets that are allowed to access and bind access control rules to the keys and secrets. For more information, see [CreatePolicy](https://help.aliyun.com/document_detail/2539454.html).
         * 3.Create an AAP: You can configure an authentication method and bind a permission policy to an AAP. For more information, see [CreateApplicationAccessPoint](https://help.aliyun.com/document_detail/2539467.html).
         * 4.Create a client key: You can configure the encryption password and validity period of a client key and bind the client key to an AAP.
         * ### Precautions
         * A client key has a validity period. After a client key expires, applications into which the client key is integrated cannot access the required KMS instance. You must replace the client key before the client key expires. We recommend that you delete the expired client key in KMS after the new client key is used.
         *
         * @param request CreateClientKeyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateClientKeyResponse
         */
        public async Task<CreateClientKeyResponse> CreateClientKeyWithOptionsAsync(CreateClientKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AapName))
            {
                query["AapName"] = request.AapName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotAfter))
            {
                query["NotAfter"] = request.NotAfter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotBefore))
            {
                query["NotBefore"] = request.NotBefore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateClientKey",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<CreateClientKeyResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateClientKeyResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @summary Creates a client key.
         *
         * @description To perform cryptographic operations and retrieve secret values, self-managed applications must use a client key to access a Key Management Service (KMS) instance. The following process shows how to create a client key-based application access point (AAP):
         * 1.Create an access control rule: You can configure the private IP addresses or private CIDR blocks that are allowed to access a KMS instance. For more information, see [CreateNetworkRule](https://help.aliyun.com/document_detail/2539407.html).
         * 2.Create a permission policy: You can configure the keys and secrets that are allowed to access and bind access control rules to the keys and secrets. For more information, see [CreatePolicy](https://help.aliyun.com/document_detail/2539454.html).
         * 3.Create an AAP: You can configure an authentication method and bind a permission policy to an AAP. For more information, see [CreateApplicationAccessPoint](https://help.aliyun.com/document_detail/2539467.html).
         * 4.Create a client key: You can configure the encryption password and validity period of a client key and bind the client key to an AAP.
         * ### Precautions
         * A client key has a validity period. After a client key expires, applications into which the client key is integrated cannot access the required KMS instance. You must replace the client key before the client key expires. We recommend that you delete the expired client key in KMS after the new client key is used.
         *
         * @param request CreateClientKeyRequest
         * @return CreateClientKeyResponse
         */
        public CreateClientKeyResponse CreateClientKey(CreateClientKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateClientKeyWithOptions(request, runtime);
        }

        /**
         * @summary Creates a client key.
         *
         * @description To perform cryptographic operations and retrieve secret values, self-managed applications must use a client key to access a Key Management Service (KMS) instance. The following process shows how to create a client key-based application access point (AAP):
         * 1.Create an access control rule: You can configure the private IP addresses or private CIDR blocks that are allowed to access a KMS instance. For more information, see [CreateNetworkRule](https://help.aliyun.com/document_detail/2539407.html).
         * 2.Create a permission policy: You can configure the keys and secrets that are allowed to access and bind access control rules to the keys and secrets. For more information, see [CreatePolicy](https://help.aliyun.com/document_detail/2539454.html).
         * 3.Create an AAP: You can configure an authentication method and bind a permission policy to an AAP. For more information, see [CreateApplicationAccessPoint](https://help.aliyun.com/document_detail/2539467.html).
         * 4.Create a client key: You can configure the encryption password and validity period of a client key and bind the client key to an AAP.
         * ### Precautions
         * A client key has a validity period. After a client key expires, applications into which the client key is integrated cannot access the required KMS instance. You must replace the client key before the client key expires. We recommend that you delete the expired client key in KMS after the new client key is used.
         *
         * @param request CreateClientKeyRequest
         * @return CreateClientKeyResponse
         */
        public async Task<CreateClientKeyResponse> CreateClientKeyAsync(CreateClientKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateClientKeyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a customer master key (CMK).
         *
         * @description KMS supports common symmetric keys and asymmetric keys. For more information, see [Key types and specifications](https://help.aliyun.com/document_detail/480161.html).
         *
         * @param request CreateKeyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateKeyResponse
         */
        public CreateKeyResponse CreateKeyWithOptions(CreateKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DKMSInstanceId))
            {
                query["DKMSInstanceId"] = request.DKMSInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAutomaticRotation))
            {
                query["EnableAutomaticRotation"] = request.EnableAutomaticRotation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeySpec))
            {
                query["KeySpec"] = request.KeySpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyUsage))
            {
                query["KeyUsage"] = request.KeyUsage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Origin))
            {
                query["Origin"] = request.Origin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Policy))
            {
                query["Policy"] = request.Policy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProtectionLevel))
            {
                query["ProtectionLevel"] = request.ProtectionLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RotationInterval))
            {
                query["RotationInterval"] = request.RotationInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateKey",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<CreateKeyResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateKeyResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @summary Creates a customer master key (CMK).
         *
         * @description KMS supports common symmetric keys and asymmetric keys. For more information, see [Key types and specifications](https://help.aliyun.com/document_detail/480161.html).
         *
         * @param request CreateKeyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateKeyResponse
         */
        public async Task<CreateKeyResponse> CreateKeyWithOptionsAsync(CreateKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DKMSInstanceId))
            {
                query["DKMSInstanceId"] = request.DKMSInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAutomaticRotation))
            {
                query["EnableAutomaticRotation"] = request.EnableAutomaticRotation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeySpec))
            {
                query["KeySpec"] = request.KeySpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyUsage))
            {
                query["KeyUsage"] = request.KeyUsage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Origin))
            {
                query["Origin"] = request.Origin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Policy))
            {
                query["Policy"] = request.Policy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProtectionLevel))
            {
                query["ProtectionLevel"] = request.ProtectionLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RotationInterval))
            {
                query["RotationInterval"] = request.RotationInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateKey",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<CreateKeyResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateKeyResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @summary Creates a customer master key (CMK).
         *
         * @description KMS supports common symmetric keys and asymmetric keys. For more information, see [Key types and specifications](https://help.aliyun.com/document_detail/480161.html).
         *
         * @param request CreateKeyRequest
         * @return CreateKeyResponse
         */
        public CreateKeyResponse CreateKey(CreateKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateKeyWithOptions(request, runtime);
        }

        /**
         * @summary Creates a customer master key (CMK).
         *
         * @description KMS supports common symmetric keys and asymmetric keys. For more information, see [Key types and specifications](https://help.aliyun.com/document_detail/480161.html).
         *
         * @param request CreateKeyRequest
         * @return CreateKeyResponse
         */
        public async Task<CreateKeyResponse> CreateKeyAsync(CreateKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateKeyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 为密钥创建新的密钥版本。
         *
         * @description *   You can create a version only for an asymmetric CMK that is in the Enabled state. You can call the [CreateKey](https://help.aliyun.com/document_detail/28947.html) operation to create an asymmetric CMK and the [DescribeKey](https://help.aliyun.com/document_detail/28952.html) operation to query the status of the CMK. The status is specified by the KeyState parameter.
         * *   The minimum interval for creating a version of the same CMK is seven days. You can call the [DescribeKey](https://help.aliyun.com/document_detail/28952.html) operation to query the time when the last version of a CMK was created. The time is specified by the LastRotationDate parameter.
         * *   If a CMK is in a private key store, you cannot create a version for the CMK.
         * *   You can create a maximum of 50 versions for a CMK in the same region.
         * You can create a version for the CMK whose ID is `0b30658a-ed1a-4922-b8f7-a673ca9c****` by using the parameter settings provided in this topic.
         *
         * @param request CreateKeyVersionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateKeyVersionResponse
         */
        public CreateKeyVersionResponse CreateKeyVersionWithOptions(CreateKeyVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyId))
            {
                query["KeyId"] = request.KeyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateKeyVersion",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<CreateKeyVersionResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateKeyVersionResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @summary 为密钥创建新的密钥版本。
         *
         * @description *   You can create a version only for an asymmetric CMK that is in the Enabled state. You can call the [CreateKey](https://help.aliyun.com/document_detail/28947.html) operation to create an asymmetric CMK and the [DescribeKey](https://help.aliyun.com/document_detail/28952.html) operation to query the status of the CMK. The status is specified by the KeyState parameter.
         * *   The minimum interval for creating a version of the same CMK is seven days. You can call the [DescribeKey](https://help.aliyun.com/document_detail/28952.html) operation to query the time when the last version of a CMK was created. The time is specified by the LastRotationDate parameter.
         * *   If a CMK is in a private key store, you cannot create a version for the CMK.
         * *   You can create a maximum of 50 versions for a CMK in the same region.
         * You can create a version for the CMK whose ID is `0b30658a-ed1a-4922-b8f7-a673ca9c****` by using the parameter settings provided in this topic.
         *
         * @param request CreateKeyVersionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateKeyVersionResponse
         */
        public async Task<CreateKeyVersionResponse> CreateKeyVersionWithOptionsAsync(CreateKeyVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyId))
            {
                query["KeyId"] = request.KeyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateKeyVersion",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<CreateKeyVersionResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateKeyVersionResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @summary 为密钥创建新的密钥版本。
         *
         * @description *   You can create a version only for an asymmetric CMK that is in the Enabled state. You can call the [CreateKey](https://help.aliyun.com/document_detail/28947.html) operation to create an asymmetric CMK and the [DescribeKey](https://help.aliyun.com/document_detail/28952.html) operation to query the status of the CMK. The status is specified by the KeyState parameter.
         * *   The minimum interval for creating a version of the same CMK is seven days. You can call the [DescribeKey](https://help.aliyun.com/document_detail/28952.html) operation to query the time when the last version of a CMK was created. The time is specified by the LastRotationDate parameter.
         * *   If a CMK is in a private key store, you cannot create a version for the CMK.
         * *   You can create a maximum of 50 versions for a CMK in the same region.
         * You can create a version for the CMK whose ID is `0b30658a-ed1a-4922-b8f7-a673ca9c****` by using the parameter settings provided in this topic.
         *
         * @param request CreateKeyVersionRequest
         * @return CreateKeyVersionResponse
         */
        public CreateKeyVersionResponse CreateKeyVersion(CreateKeyVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateKeyVersionWithOptions(request, runtime);
        }

        /**
         * @summary 为密钥创建新的密钥版本。
         *
         * @description *   You can create a version only for an asymmetric CMK that is in the Enabled state. You can call the [CreateKey](https://help.aliyun.com/document_detail/28947.html) operation to create an asymmetric CMK and the [DescribeKey](https://help.aliyun.com/document_detail/28952.html) operation to query the status of the CMK. The status is specified by the KeyState parameter.
         * *   The minimum interval for creating a version of the same CMK is seven days. You can call the [DescribeKey](https://help.aliyun.com/document_detail/28952.html) operation to query the time when the last version of a CMK was created. The time is specified by the LastRotationDate parameter.
         * *   If a CMK is in a private key store, you cannot create a version for the CMK.
         * *   You can create a maximum of 50 versions for a CMK in the same region.
         * You can create a version for the CMK whose ID is `0b30658a-ed1a-4922-b8f7-a673ca9c****` by using the parameter settings provided in this topic.
         *
         * @param request CreateKeyVersionRequest
         * @return CreateKeyVersionResponse
         */
        public async Task<CreateKeyVersionResponse> CreateKeyVersionAsync(CreateKeyVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateKeyVersionWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates an access control rule to configure the private IP addresses or CIDR blocks that are allowed to access a Key Management Service (KMS) instance.
         *
         * @description To perform cryptographic operations and retrieve secret values, self-managed applications must use a client key to access a KMS instance. The following process shows how to create a client key-based application access point (AAP):
         * 1.Create an access control rule: You can configure the private IP addresses or private CIDR blocks that are allowed to access a KMS instance.
         * 2.Create a permission policy: You can configure the keys and secrets that are allowed to access and bind access control rules to the keys and secrets. For more information, see [CreatePolicy](https://help.aliyun.com/document_detail/2539454.html).
         * 3.Create an AAP: You can configure an authentication method and bind a permission policy to an AAP. For more information, see [CreateApplicationAccessPoint](https://help.aliyun.com/document_detail/2539467.html).
         * 4.Create a client key: You can configure the encryption password and validity period of a client key and bind the client key to an AAP. For more information, see [CreateClientKey](https://help.aliyun.com/document_detail/2539509.html).
         *
         * @param request CreateNetworkRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateNetworkRuleResponse
         */
        public CreateNetworkRuleResponse CreateNetworkRuleWithOptions(CreateNetworkRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourcePrivateIp))
            {
                query["SourcePrivateIp"] = request.SourcePrivateIp;
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
                Action = "CreateNetworkRule",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<CreateNetworkRuleResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateNetworkRuleResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @summary Creates an access control rule to configure the private IP addresses or CIDR blocks that are allowed to access a Key Management Service (KMS) instance.
         *
         * @description To perform cryptographic operations and retrieve secret values, self-managed applications must use a client key to access a KMS instance. The following process shows how to create a client key-based application access point (AAP):
         * 1.Create an access control rule: You can configure the private IP addresses or private CIDR blocks that are allowed to access a KMS instance.
         * 2.Create a permission policy: You can configure the keys and secrets that are allowed to access and bind access control rules to the keys and secrets. For more information, see [CreatePolicy](https://help.aliyun.com/document_detail/2539454.html).
         * 3.Create an AAP: You can configure an authentication method and bind a permission policy to an AAP. For more information, see [CreateApplicationAccessPoint](https://help.aliyun.com/document_detail/2539467.html).
         * 4.Create a client key: You can configure the encryption password and validity period of a client key and bind the client key to an AAP. For more information, see [CreateClientKey](https://help.aliyun.com/document_detail/2539509.html).
         *
         * @param request CreateNetworkRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateNetworkRuleResponse
         */
        public async Task<CreateNetworkRuleResponse> CreateNetworkRuleWithOptionsAsync(CreateNetworkRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourcePrivateIp))
            {
                query["SourcePrivateIp"] = request.SourcePrivateIp;
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
                Action = "CreateNetworkRule",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<CreateNetworkRuleResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateNetworkRuleResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @summary Creates an access control rule to configure the private IP addresses or CIDR blocks that are allowed to access a Key Management Service (KMS) instance.
         *
         * @description To perform cryptographic operations and retrieve secret values, self-managed applications must use a client key to access a KMS instance. The following process shows how to create a client key-based application access point (AAP):
         * 1.Create an access control rule: You can configure the private IP addresses or private CIDR blocks that are allowed to access a KMS instance.
         * 2.Create a permission policy: You can configure the keys and secrets that are allowed to access and bind access control rules to the keys and secrets. For more information, see [CreatePolicy](https://help.aliyun.com/document_detail/2539454.html).
         * 3.Create an AAP: You can configure an authentication method and bind a permission policy to an AAP. For more information, see [CreateApplicationAccessPoint](https://help.aliyun.com/document_detail/2539467.html).
         * 4.Create a client key: You can configure the encryption password and validity period of a client key and bind the client key to an AAP. For more information, see [CreateClientKey](https://help.aliyun.com/document_detail/2539509.html).
         *
         * @param request CreateNetworkRuleRequest
         * @return CreateNetworkRuleResponse
         */
        public CreateNetworkRuleResponse CreateNetworkRule(CreateNetworkRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateNetworkRuleWithOptions(request, runtime);
        }

        /**
         * @summary Creates an access control rule to configure the private IP addresses or CIDR blocks that are allowed to access a Key Management Service (KMS) instance.
         *
         * @description To perform cryptographic operations and retrieve secret values, self-managed applications must use a client key to access a KMS instance. The following process shows how to create a client key-based application access point (AAP):
         * 1.Create an access control rule: You can configure the private IP addresses or private CIDR blocks that are allowed to access a KMS instance.
         * 2.Create a permission policy: You can configure the keys and secrets that are allowed to access and bind access control rules to the keys and secrets. For more information, see [CreatePolicy](https://help.aliyun.com/document_detail/2539454.html).
         * 3.Create an AAP: You can configure an authentication method and bind a permission policy to an AAP. For more information, see [CreateApplicationAccessPoint](https://help.aliyun.com/document_detail/2539467.html).
         * 4.Create a client key: You can configure the encryption password and validity period of a client key and bind the client key to an AAP. For more information, see [CreateClientKey](https://help.aliyun.com/document_detail/2539509.html).
         *
         * @param request CreateNetworkRuleRequest
         * @return CreateNetworkRuleResponse
         */
        public async Task<CreateNetworkRuleResponse> CreateNetworkRuleAsync(CreateNetworkRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateNetworkRuleWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a permission policy to configure the keys and secrets that are allowed to access.
         *
         * @description To perform cryptographic operations and retrieve secret values, self-managed applications must use a client key to access a Key Management Service (KMS) instance. The following process shows how to create a client key-based application access point (AAP):
         * 1.Create an access control rule: You can configure the private IP addresses or private CIDR blocks that are allowed to access a KMS instance. For more information, see [CreateNetworkRule](https://help.aliyun.com/document_detail/2539407.html).
         * 2.Create a permission policy: You can configure the keys and secrets that are allowed to access and bind access control rules to the keys and secrets.
         * 3.Create an AAP: You can configure an authentication method and bind a permission policy to an AAP. For more information, see [CreateApplicationAccessPoint](https://help.aliyun.com/document_detail/2539467.html).
         * 4.Create a client key: You can configure the encryption password and validity period of a client key and bind the client key to an AAP. For more information, see [CreateClientKey](https://help.aliyun.com/document_detail/2539509.html).
         *
         * @param request CreatePolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreatePolicyResponse
         */
        public CreatePolicyResponse CreatePolicyWithOptions(CreatePolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessControlRules))
            {
                query["AccessControlRules"] = request.AccessControlRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KmsInstance))
            {
                query["KmsInstance"] = request.KmsInstance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Permissions))
            {
                query["Permissions"] = request.Permissions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resources))
            {
                query["Resources"] = request.Resources;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePolicy",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<CreatePolicyResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreatePolicyResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @summary Creates a permission policy to configure the keys and secrets that are allowed to access.
         *
         * @description To perform cryptographic operations and retrieve secret values, self-managed applications must use a client key to access a Key Management Service (KMS) instance. The following process shows how to create a client key-based application access point (AAP):
         * 1.Create an access control rule: You can configure the private IP addresses or private CIDR blocks that are allowed to access a KMS instance. For more information, see [CreateNetworkRule](https://help.aliyun.com/document_detail/2539407.html).
         * 2.Create a permission policy: You can configure the keys and secrets that are allowed to access and bind access control rules to the keys and secrets.
         * 3.Create an AAP: You can configure an authentication method and bind a permission policy to an AAP. For more information, see [CreateApplicationAccessPoint](https://help.aliyun.com/document_detail/2539467.html).
         * 4.Create a client key: You can configure the encryption password and validity period of a client key and bind the client key to an AAP. For more information, see [CreateClientKey](https://help.aliyun.com/document_detail/2539509.html).
         *
         * @param request CreatePolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreatePolicyResponse
         */
        public async Task<CreatePolicyResponse> CreatePolicyWithOptionsAsync(CreatePolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessControlRules))
            {
                query["AccessControlRules"] = request.AccessControlRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KmsInstance))
            {
                query["KmsInstance"] = request.KmsInstance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Permissions))
            {
                query["Permissions"] = request.Permissions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resources))
            {
                query["Resources"] = request.Resources;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePolicy",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<CreatePolicyResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreatePolicyResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @summary Creates a permission policy to configure the keys and secrets that are allowed to access.
         *
         * @description To perform cryptographic operations and retrieve secret values, self-managed applications must use a client key to access a Key Management Service (KMS) instance. The following process shows how to create a client key-based application access point (AAP):
         * 1.Create an access control rule: You can configure the private IP addresses or private CIDR blocks that are allowed to access a KMS instance. For more information, see [CreateNetworkRule](https://help.aliyun.com/document_detail/2539407.html).
         * 2.Create a permission policy: You can configure the keys and secrets that are allowed to access and bind access control rules to the keys and secrets.
         * 3.Create an AAP: You can configure an authentication method and bind a permission policy to an AAP. For more information, see [CreateApplicationAccessPoint](https://help.aliyun.com/document_detail/2539467.html).
         * 4.Create a client key: You can configure the encryption password and validity period of a client key and bind the client key to an AAP. For more information, see [CreateClientKey](https://help.aliyun.com/document_detail/2539509.html).
         *
         * @param request CreatePolicyRequest
         * @return CreatePolicyResponse
         */
        public CreatePolicyResponse CreatePolicy(CreatePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreatePolicyWithOptions(request, runtime);
        }

        /**
         * @summary Creates a permission policy to configure the keys and secrets that are allowed to access.
         *
         * @description To perform cryptographic operations and retrieve secret values, self-managed applications must use a client key to access a Key Management Service (KMS) instance. The following process shows how to create a client key-based application access point (AAP):
         * 1.Create an access control rule: You can configure the private IP addresses or private CIDR blocks that are allowed to access a KMS instance. For more information, see [CreateNetworkRule](https://help.aliyun.com/document_detail/2539407.html).
         * 2.Create a permission policy: You can configure the keys and secrets that are allowed to access and bind access control rules to the keys and secrets.
         * 3.Create an AAP: You can configure an authentication method and bind a permission policy to an AAP. For more information, see [CreateApplicationAccessPoint](https://help.aliyun.com/document_detail/2539467.html).
         * 4.Create a client key: You can configure the encryption password and validity period of a client key and bind the client key to an AAP. For more information, see [CreateClientKey](https://help.aliyun.com/document_detail/2539509.html).
         *
         * @param request CreatePolicyRequest
         * @return CreatePolicyResponse
         */
        public async Task<CreatePolicyResponse> CreatePolicyAsync(CreatePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreatePolicyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建凭据并存入凭据的初始版本。
         *
         * @description The name of the secret.
         * The value must be 1 to 64 characters in length and can contain letters, digits, underscores (_), forward slashes (/), plus signs (+), equal signs (=), periods (.), hyphens (-), and at signs (@). The following list describes the name requirements for different types of secrets:
         * *   If the SecretType parameter is set to Generic or Rds, the name cannot start with `acs/`.
         * *   If the SecretType parameter is set to RAMCredentials, set the SecretName parameter to `$Auto`. In this case, KMS automatically generates a secret name that starts with `acs/ram/user/`. The name includes the display name of RAM user.
         * *   If the SecretType parameter is set to ECS, the name must start with `acs/ecs/`.
         *
         * @param tmpReq CreateSecretRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateSecretResponse
         */
        public CreateSecretResponse CreateSecretWithOptions(CreateSecretRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateSecretShrinkRequest request = new CreateSecretShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExtendedConfig))
            {
                request.ExtendedConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExtendedConfig, "ExtendedConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DKMSInstanceId))
            {
                query["DKMSInstanceId"] = request.DKMSInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAutomaticRotation))
            {
                query["EnableAutomaticRotation"] = request.EnableAutomaticRotation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptionKeyId))
            {
                query["EncryptionKeyId"] = request.EncryptionKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendedConfigShrink))
            {
                query["ExtendedConfig"] = request.ExtendedConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Policy))
            {
                query["Policy"] = request.Policy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RotationInterval))
            {
                query["RotationInterval"] = request.RotationInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretData))
            {
                query["SecretData"] = request.SecretData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretDataType))
            {
                query["SecretDataType"] = request.SecretDataType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretName))
            {
                query["SecretName"] = request.SecretName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretType))
            {
                query["SecretType"] = request.SecretType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionId))
            {
                query["VersionId"] = request.VersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSecret",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<CreateSecretResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateSecretResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @summary 创建凭据并存入凭据的初始版本。
         *
         * @description The name of the secret.
         * The value must be 1 to 64 characters in length and can contain letters, digits, underscores (_), forward slashes (/), plus signs (+), equal signs (=), periods (.), hyphens (-), and at signs (@). The following list describes the name requirements for different types of secrets:
         * *   If the SecretType parameter is set to Generic or Rds, the name cannot start with `acs/`.
         * *   If the SecretType parameter is set to RAMCredentials, set the SecretName parameter to `$Auto`. In this case, KMS automatically generates a secret name that starts with `acs/ram/user/`. The name includes the display name of RAM user.
         * *   If the SecretType parameter is set to ECS, the name must start with `acs/ecs/`.
         *
         * @param tmpReq CreateSecretRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateSecretResponse
         */
        public async Task<CreateSecretResponse> CreateSecretWithOptionsAsync(CreateSecretRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateSecretShrinkRequest request = new CreateSecretShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExtendedConfig))
            {
                request.ExtendedConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExtendedConfig, "ExtendedConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DKMSInstanceId))
            {
                query["DKMSInstanceId"] = request.DKMSInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAutomaticRotation))
            {
                query["EnableAutomaticRotation"] = request.EnableAutomaticRotation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptionKeyId))
            {
                query["EncryptionKeyId"] = request.EncryptionKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendedConfigShrink))
            {
                query["ExtendedConfig"] = request.ExtendedConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Policy))
            {
                query["Policy"] = request.Policy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RotationInterval))
            {
                query["RotationInterval"] = request.RotationInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretData))
            {
                query["SecretData"] = request.SecretData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretDataType))
            {
                query["SecretDataType"] = request.SecretDataType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretName))
            {
                query["SecretName"] = request.SecretName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretType))
            {
                query["SecretType"] = request.SecretType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionId))
            {
                query["VersionId"] = request.VersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSecret",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<CreateSecretResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateSecretResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @summary 创建凭据并存入凭据的初始版本。
         *
         * @description The name of the secret.
         * The value must be 1 to 64 characters in length and can contain letters, digits, underscores (_), forward slashes (/), plus signs (+), equal signs (=), periods (.), hyphens (-), and at signs (@). The following list describes the name requirements for different types of secrets:
         * *   If the SecretType parameter is set to Generic or Rds, the name cannot start with `acs/`.
         * *   If the SecretType parameter is set to RAMCredentials, set the SecretName parameter to `$Auto`. In this case, KMS automatically generates a secret name that starts with `acs/ram/user/`. The name includes the display name of RAM user.
         * *   If the SecretType parameter is set to ECS, the name must start with `acs/ecs/`.
         *
         * @param request CreateSecretRequest
         * @return CreateSecretResponse
         */
        public CreateSecretResponse CreateSecret(CreateSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSecretWithOptions(request, runtime);
        }

        /**
         * @summary 创建凭据并存入凭据的初始版本。
         *
         * @description The name of the secret.
         * The value must be 1 to 64 characters in length and can contain letters, digits, underscores (_), forward slashes (/), plus signs (+), equal signs (=), periods (.), hyphens (-), and at signs (@). The following list describes the name requirements for different types of secrets:
         * *   If the SecretType parameter is set to Generic or Rds, the name cannot start with `acs/`.
         * *   If the SecretType parameter is set to RAMCredentials, set the SecretName parameter to `$Auto`. In this case, KMS automatically generates a secret name that starts with `acs/ram/user/`. The name includes the display name of RAM user.
         * *   If the SecretType parameter is set to ECS, the name must start with `acs/ecs/`.
         *
         * @param request CreateSecretRequest
         * @return CreateSecretResponse
         */
        public async Task<CreateSecretResponse> CreateSecretAsync(CreateSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSecretWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 调用Decrypt接口解密CiphertextBlob中的密文。
         *
         * @param tmpReq DecryptRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DecryptResponse
         */
        public DecryptResponse DecryptWithOptions(DecryptRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DecryptShrinkRequest request = new DecryptShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EncryptionContext))
            {
                request.EncryptionContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EncryptionContext, "EncryptionContext", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CiphertextBlob))
            {
                query["CiphertextBlob"] = request.CiphertextBlob;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptionContextShrink))
            {
                query["EncryptionContext"] = request.EncryptionContextShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Decrypt",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<DecryptResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DecryptResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @summary 调用Decrypt接口解密CiphertextBlob中的密文。
         *
         * @param tmpReq DecryptRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DecryptResponse
         */
        public async Task<DecryptResponse> DecryptWithOptionsAsync(DecryptRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DecryptShrinkRequest request = new DecryptShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EncryptionContext))
            {
                request.EncryptionContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EncryptionContext, "EncryptionContext", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CiphertextBlob))
            {
                query["CiphertextBlob"] = request.CiphertextBlob;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptionContextShrink))
            {
                query["EncryptionContext"] = request.EncryptionContextShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Decrypt",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<DecryptResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DecryptResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @summary 调用Decrypt接口解密CiphertextBlob中的密文。
         *
         * @param request DecryptRequest
         * @return DecryptResponse
         */
        public DecryptResponse Decrypt(DecryptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DecryptWithOptions(request, runtime);
        }

        /**
         * @summary 调用Decrypt接口解密CiphertextBlob中的密文。
         *
         * @param request DecryptRequest
         * @return DecryptResponse
         */
        public async Task<DecryptResponse> DecryptAsync(DecryptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DecryptWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DeleteAliasRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAliasResponse
         */
        public DeleteAliasResponse DeleteAliasWithOptions(DeleteAliasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliasName))
            {
                query["AliasName"] = request.AliasName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAlias",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<DeleteAliasResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteAliasResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @param request DeleteAliasRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAliasResponse
         */
        public async Task<DeleteAliasResponse> DeleteAliasWithOptionsAsync(DeleteAliasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliasName))
            {
                query["AliasName"] = request.AliasName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAlias",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<DeleteAliasResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteAliasResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @param request DeleteAliasRequest
         * @return DeleteAliasResponse
         */
        public DeleteAliasResponse DeleteAlias(DeleteAliasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAliasWithOptions(request, runtime);
        }

        /**
         * @param request DeleteAliasRequest
         * @return DeleteAliasResponse
         */
        public async Task<DeleteAliasResponse> DeleteAliasAsync(DeleteAliasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAliasWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes an application access point (AAP).
         *
         * @description Before you delete an AAP, make sure that the AAP is no longer in use. If you delete an AAP that is in use, applications that use the AAP cannot access Key Management Service (KMS). Exercise caution when you delete an AAP.
         *
         * @param request DeleteApplicationAccessPointRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteApplicationAccessPointResponse
         */
        public DeleteApplicationAccessPointResponse DeleteApplicationAccessPointWithOptions(DeleteApplicationAccessPointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "DeleteApplicationAccessPoint",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<DeleteApplicationAccessPointResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteApplicationAccessPointResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @summary Deletes an application access point (AAP).
         *
         * @description Before you delete an AAP, make sure that the AAP is no longer in use. If you delete an AAP that is in use, applications that use the AAP cannot access Key Management Service (KMS). Exercise caution when you delete an AAP.
         *
         * @param request DeleteApplicationAccessPointRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteApplicationAccessPointResponse
         */
        public async Task<DeleteApplicationAccessPointResponse> DeleteApplicationAccessPointWithOptionsAsync(DeleteApplicationAccessPointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "DeleteApplicationAccessPoint",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<DeleteApplicationAccessPointResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteApplicationAccessPointResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @summary Deletes an application access point (AAP).
         *
         * @description Before you delete an AAP, make sure that the AAP is no longer in use. If you delete an AAP that is in use, applications that use the AAP cannot access Key Management Service (KMS). Exercise caution when you delete an AAP.
         *
         * @param request DeleteApplicationAccessPointRequest
         * @return DeleteApplicationAccessPointResponse
         */
        public DeleteApplicationAccessPointResponse DeleteApplicationAccessPoint(DeleteApplicationAccessPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteApplicationAccessPointWithOptions(request, runtime);
        }

        /**
         * @summary Deletes an application access point (AAP).
         *
         * @description Before you delete an AAP, make sure that the AAP is no longer in use. If you delete an AAP that is in use, applications that use the AAP cannot access Key Management Service (KMS). Exercise caution when you delete an AAP.
         *
         * @param request DeleteApplicationAccessPointRequest
         * @return DeleteApplicationAccessPointResponse
         */
        public async Task<DeleteApplicationAccessPointResponse> DeleteApplicationAccessPointAsync(DeleteApplicationAccessPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteApplicationAccessPointWithOptionsAsync(request, runtime);
        }

        /**
         * @description After the certificate and its private key and certificate chain are deleted, they cannot be restored. Proceed with caution.
         * In this example, the certificate whose ID is `9a28de48-8d8b-484d-a766-dec4****` and its private key and certificate chain are deleted.
         *
         * @param request DeleteCertificateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteCertificateResponse
         */
        public DeleteCertificateResponse DeleteCertificateWithOptions(DeleteCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertificateId))
            {
                query["CertificateId"] = request.CertificateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCertificate",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<DeleteCertificateResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteCertificateResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @description After the certificate and its private key and certificate chain are deleted, they cannot be restored. Proceed with caution.
         * In this example, the certificate whose ID is `9a28de48-8d8b-484d-a766-dec4****` and its private key and certificate chain are deleted.
         *
         * @param request DeleteCertificateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteCertificateResponse
         */
        public async Task<DeleteCertificateResponse> DeleteCertificateWithOptionsAsync(DeleteCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertificateId))
            {
                query["CertificateId"] = request.CertificateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCertificate",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<DeleteCertificateResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteCertificateResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @description After the certificate and its private key and certificate chain are deleted, they cannot be restored. Proceed with caution.
         * In this example, the certificate whose ID is `9a28de48-8d8b-484d-a766-dec4****` and its private key and certificate chain are deleted.
         *
         * @param request DeleteCertificateRequest
         * @return DeleteCertificateResponse
         */
        public DeleteCertificateResponse DeleteCertificate(DeleteCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCertificateWithOptions(request, runtime);
        }

        /**
         * @description After the certificate and its private key and certificate chain are deleted, they cannot be restored. Proceed with caution.
         * In this example, the certificate whose ID is `9a28de48-8d8b-484d-a766-dec4****` and its private key and certificate chain are deleted.
         *
         * @param request DeleteCertificateRequest
         * @return DeleteCertificateResponse
         */
        public async Task<DeleteCertificateResponse> DeleteCertificateAsync(DeleteCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCertificateWithOptionsAsync(request, runtime);
        }

        /**
         * @description Before you delete a client key, make sure that the client key is no longer in use. If you delete a client key that is in use, applications that use the client key cannot access Key Management Service (KMS). Exercise caution when you delete a client key.
         *
         * @param request DeleteClientKeyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteClientKeyResponse
         */
        public DeleteClientKeyResponse DeleteClientKeyWithOptions(DeleteClientKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientKeyId))
            {
                query["ClientKeyId"] = request.ClientKeyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteClientKey",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<DeleteClientKeyResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteClientKeyResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @description Before you delete a client key, make sure that the client key is no longer in use. If you delete a client key that is in use, applications that use the client key cannot access Key Management Service (KMS). Exercise caution when you delete a client key.
         *
         * @param request DeleteClientKeyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteClientKeyResponse
         */
        public async Task<DeleteClientKeyResponse> DeleteClientKeyWithOptionsAsync(DeleteClientKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientKeyId))
            {
                query["ClientKeyId"] = request.ClientKeyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteClientKey",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<DeleteClientKeyResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteClientKeyResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @description Before you delete a client key, make sure that the client key is no longer in use. If you delete a client key that is in use, applications that use the client key cannot access Key Management Service (KMS). Exercise caution when you delete a client key.
         *
         * @param request DeleteClientKeyRequest
         * @return DeleteClientKeyResponse
         */
        public DeleteClientKeyResponse DeleteClientKey(DeleteClientKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteClientKeyWithOptions(request, runtime);
        }

        /**
         * @description Before you delete a client key, make sure that the client key is no longer in use. If you delete a client key that is in use, applications that use the client key cannot access Key Management Service (KMS). Exercise caution when you delete a client key.
         *
         * @param request DeleteClientKeyRequest
         * @return DeleteClientKeyResponse
         */
        public async Task<DeleteClientKeyResponse> DeleteClientKeyAsync(DeleteClientKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteClientKeyWithOptionsAsync(request, runtime);
        }

        /**
         * @description This operation does not delete the CMK that is created by using the key material.
         * If the CMK is in the PendingDeletion state, the state of the CMK and the scheduled deletion time do not change after you call this operation. If the CMK is not in the PendingDeletion state, the state of the CMK changes to PendingImport after you call this operation.
         * After you delete the key material, you can upload only the same key material into the CMK.
         *
         * @param request DeleteKeyMaterialRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteKeyMaterialResponse
         */
        public DeleteKeyMaterialResponse DeleteKeyMaterialWithOptions(DeleteKeyMaterialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyId))
            {
                query["KeyId"] = request.KeyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteKeyMaterial",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<DeleteKeyMaterialResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteKeyMaterialResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @description This operation does not delete the CMK that is created by using the key material.
         * If the CMK is in the PendingDeletion state, the state of the CMK and the scheduled deletion time do not change after you call this operation. If the CMK is not in the PendingDeletion state, the state of the CMK changes to PendingImport after you call this operation.
         * After you delete the key material, you can upload only the same key material into the CMK.
         *
         * @param request DeleteKeyMaterialRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteKeyMaterialResponse
         */
        public async Task<DeleteKeyMaterialResponse> DeleteKeyMaterialWithOptionsAsync(DeleteKeyMaterialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyId))
            {
                query["KeyId"] = request.KeyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteKeyMaterial",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<DeleteKeyMaterialResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteKeyMaterialResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @description This operation does not delete the CMK that is created by using the key material.
         * If the CMK is in the PendingDeletion state, the state of the CMK and the scheduled deletion time do not change after you call this operation. If the CMK is not in the PendingDeletion state, the state of the CMK changes to PendingImport after you call this operation.
         * After you delete the key material, you can upload only the same key material into the CMK.
         *
         * @param request DeleteKeyMaterialRequest
         * @return DeleteKeyMaterialResponse
         */
        public DeleteKeyMaterialResponse DeleteKeyMaterial(DeleteKeyMaterialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteKeyMaterialWithOptions(request, runtime);
        }

        /**
         * @description This operation does not delete the CMK that is created by using the key material.
         * If the CMK is in the PendingDeletion state, the state of the CMK and the scheduled deletion time do not change after you call this operation. If the CMK is not in the PendingDeletion state, the state of the CMK changes to PendingImport after you call this operation.
         * After you delete the key material, you can upload only the same key material into the CMK.
         *
         * @param request DeleteKeyMaterialRequest
         * @return DeleteKeyMaterialResponse
         */
        public async Task<DeleteKeyMaterialResponse> DeleteKeyMaterialAsync(DeleteKeyMaterialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteKeyMaterialWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes a network access rule.
         *
         * @description Before you delete a network access rule, make sure that the network access rule is not bound to permission policies. Otherwise, related applications cannot access Key Management Service (KMS).
         *
         * @param request DeleteNetworkRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteNetworkRuleResponse
         */
        public DeleteNetworkRuleResponse DeleteNetworkRuleWithOptions(DeleteNetworkRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "DeleteNetworkRule",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<DeleteNetworkRuleResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteNetworkRuleResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @summary Deletes a network access rule.
         *
         * @description Before you delete a network access rule, make sure that the network access rule is not bound to permission policies. Otherwise, related applications cannot access Key Management Service (KMS).
         *
         * @param request DeleteNetworkRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteNetworkRuleResponse
         */
        public async Task<DeleteNetworkRuleResponse> DeleteNetworkRuleWithOptionsAsync(DeleteNetworkRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "DeleteNetworkRule",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<DeleteNetworkRuleResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteNetworkRuleResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @summary Deletes a network access rule.
         *
         * @description Before you delete a network access rule, make sure that the network access rule is not bound to permission policies. Otherwise, related applications cannot access Key Management Service (KMS).
         *
         * @param request DeleteNetworkRuleRequest
         * @return DeleteNetworkRuleResponse
         */
        public DeleteNetworkRuleResponse DeleteNetworkRule(DeleteNetworkRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteNetworkRuleWithOptions(request, runtime);
        }

        /**
         * @summary Deletes a network access rule.
         *
         * @description Before you delete a network access rule, make sure that the network access rule is not bound to permission policies. Otherwise, related applications cannot access Key Management Service (KMS).
         *
         * @param request DeleteNetworkRuleRequest
         * @return DeleteNetworkRuleResponse
         */
        public async Task<DeleteNetworkRuleResponse> DeleteNetworkRuleAsync(DeleteNetworkRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteNetworkRuleWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes a permission policy.
         *
         * @description Before you delete a permission policy, make sure that the permission policy is not associated with application access points (AAPs). Otherwise, related applications cannot access Key Management Service (KMS).
         *
         * @param request DeletePolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeletePolicyResponse
         */
        public DeletePolicyResponse DeletePolicyWithOptions(DeletePolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "DeletePolicy",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<DeletePolicyResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeletePolicyResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @summary Deletes a permission policy.
         *
         * @description Before you delete a permission policy, make sure that the permission policy is not associated with application access points (AAPs). Otherwise, related applications cannot access Key Management Service (KMS).
         *
         * @param request DeletePolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeletePolicyResponse
         */
        public async Task<DeletePolicyResponse> DeletePolicyWithOptionsAsync(DeletePolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "DeletePolicy",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<DeletePolicyResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeletePolicyResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @summary Deletes a permission policy.
         *
         * @description Before you delete a permission policy, make sure that the permission policy is not associated with application access points (AAPs). Otherwise, related applications cannot access Key Management Service (KMS).
         *
         * @param request DeletePolicyRequest
         * @return DeletePolicyResponse
         */
        public DeletePolicyResponse DeletePolicy(DeletePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeletePolicyWithOptions(request, runtime);
        }

        /**
         * @summary Deletes a permission policy.
         *
         * @description Before you delete a permission policy, make sure that the permission policy is not associated with application access points (AAPs). Otherwise, related applications cannot access Key Management Service (KMS).
         *
         * @param request DeletePolicyRequest
         * @return DeletePolicyResponse
         */
        public async Task<DeletePolicyResponse> DeletePolicyAsync(DeletePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeletePolicyWithOptionsAsync(request, runtime);
        }

        /**
         * @description If you call this operation without specifying a recovery period, the deleted secret can be recovered within 30 days.
         * If you specify a recovery period, the deleted secret can be recovered within the recovery period. You can also forcibly delete a secret. A forcibly deleted secret cannot be recovered.
         *
         * @param request DeleteSecretRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteSecretResponse
         */
        public DeleteSecretResponse DeleteSecretWithOptions(DeleteSecretRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceDeleteWithoutRecovery))
            {
                query["ForceDeleteWithoutRecovery"] = request.ForceDeleteWithoutRecovery;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryWindowInDays))
            {
                query["RecoveryWindowInDays"] = request.RecoveryWindowInDays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretName))
            {
                query["SecretName"] = request.SecretName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSecret",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<DeleteSecretResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteSecretResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @description If you call this operation without specifying a recovery period, the deleted secret can be recovered within 30 days.
         * If you specify a recovery period, the deleted secret can be recovered within the recovery period. You can also forcibly delete a secret. A forcibly deleted secret cannot be recovered.
         *
         * @param request DeleteSecretRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteSecretResponse
         */
        public async Task<DeleteSecretResponse> DeleteSecretWithOptionsAsync(DeleteSecretRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceDeleteWithoutRecovery))
            {
                query["ForceDeleteWithoutRecovery"] = request.ForceDeleteWithoutRecovery;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryWindowInDays))
            {
                query["RecoveryWindowInDays"] = request.RecoveryWindowInDays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretName))
            {
                query["SecretName"] = request.SecretName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSecret",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<DeleteSecretResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteSecretResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @description If you call this operation without specifying a recovery period, the deleted secret can be recovered within 30 days.
         * If you specify a recovery period, the deleted secret can be recovered within the recovery period. You can also forcibly delete a secret. A forcibly deleted secret cannot be recovered.
         *
         * @param request DeleteSecretRequest
         * @return DeleteSecretResponse
         */
        public DeleteSecretResponse DeleteSecret(DeleteSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSecretWithOptions(request, runtime);
        }

        /**
         * @description If you call this operation without specifying a recovery period, the deleted secret can be recovered within 30 days.
         * If you specify a recovery period, the deleted secret can be recovered within the recovery period. You can also forcibly delete a secret. A forcibly deleted secret cannot be recovered.
         *
         * @param request DeleteSecretRequest
         * @return DeleteSecretResponse
         */
        public async Task<DeleteSecretResponse> DeleteSecretAsync(DeleteSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSecretWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeAccountKmsStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAccountKmsStatusResponse
         */
        public DescribeAccountKmsStatusResponse DescribeAccountKmsStatusWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAccountKmsStatus",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<DescribeAccountKmsStatusResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeAccountKmsStatusResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @param request DescribeAccountKmsStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAccountKmsStatusResponse
         */
        public async Task<DescribeAccountKmsStatusResponse> DescribeAccountKmsStatusWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAccountKmsStatus",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<DescribeAccountKmsStatusResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeAccountKmsStatusResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @return DescribeAccountKmsStatusResponse
         */
        public DescribeAccountKmsStatusResponse DescribeAccountKmsStatus()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAccountKmsStatusWithOptions(runtime);
        }

        /**
         * @return DescribeAccountKmsStatusResponse
         */
        public async Task<DescribeAccountKmsStatusResponse> DescribeAccountKmsStatusAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAccountKmsStatusWithOptionsAsync(runtime);
        }

        /**
         * @summary Queries the details of an application access point (AAP).
         *
         * @param request DescribeApplicationAccessPointRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeApplicationAccessPointResponse
         */
        public DescribeApplicationAccessPointResponse DescribeApplicationAccessPointWithOptions(DescribeApplicationAccessPointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "DescribeApplicationAccessPoint",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<DescribeApplicationAccessPointResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeApplicationAccessPointResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @summary Queries the details of an application access point (AAP).
         *
         * @param request DescribeApplicationAccessPointRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeApplicationAccessPointResponse
         */
        public async Task<DescribeApplicationAccessPointResponse> DescribeApplicationAccessPointWithOptionsAsync(DescribeApplicationAccessPointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "DescribeApplicationAccessPoint",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<DescribeApplicationAccessPointResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeApplicationAccessPointResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @summary Queries the details of an application access point (AAP).
         *
         * @param request DescribeApplicationAccessPointRequest
         * @return DescribeApplicationAccessPointResponse
         */
        public DescribeApplicationAccessPointResponse DescribeApplicationAccessPoint(DescribeApplicationAccessPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeApplicationAccessPointWithOptions(request, runtime);
        }

        /**
         * @summary Queries the details of an application access point (AAP).
         *
         * @param request DescribeApplicationAccessPointRequest
         * @return DescribeApplicationAccessPointResponse
         */
        public async Task<DescribeApplicationAccessPointResponse> DescribeApplicationAccessPointAsync(DescribeApplicationAccessPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeApplicationAccessPointWithOptionsAsync(request, runtime);
        }

        /**
         * @description In this example, the information about the certificate whose ID is `9a28de48-8d8b-484d-a766-dec4****` is queried. The certificate information includes the certificate ID, creation time, certificate issuer, validity period, serial number, and signature algorithm.
         *
         * @param request DescribeCertificateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeCertificateResponse
         */
        public DescribeCertificateResponse DescribeCertificateWithOptions(DescribeCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertificateId))
            {
                query["CertificateId"] = request.CertificateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCertificate",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<DescribeCertificateResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeCertificateResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @description In this example, the information about the certificate whose ID is `9a28de48-8d8b-484d-a766-dec4****` is queried. The certificate information includes the certificate ID, creation time, certificate issuer, validity period, serial number, and signature algorithm.
         *
         * @param request DescribeCertificateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeCertificateResponse
         */
        public async Task<DescribeCertificateResponse> DescribeCertificateWithOptionsAsync(DescribeCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertificateId))
            {
                query["CertificateId"] = request.CertificateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCertificate",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<DescribeCertificateResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeCertificateResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @description In this example, the information about the certificate whose ID is `9a28de48-8d8b-484d-a766-dec4****` is queried. The certificate information includes the certificate ID, creation time, certificate issuer, validity period, serial number, and signature algorithm.
         *
         * @param request DescribeCertificateRequest
         * @return DescribeCertificateResponse
         */
        public DescribeCertificateResponse DescribeCertificate(DescribeCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCertificateWithOptions(request, runtime);
        }

        /**
         * @description In this example, the information about the certificate whose ID is `9a28de48-8d8b-484d-a766-dec4****` is queried. The certificate information includes the certificate ID, creation time, certificate issuer, validity period, serial number, and signature algorithm.
         *
         * @param request DescribeCertificateRequest
         * @return DescribeCertificateResponse
         */
        public async Task<DescribeCertificateResponse> DescribeCertificateAsync(DescribeCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCertificateWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the information about a customer master key (CMK).
         *
         * @description You can query the information about the CMK `05754286-3ba2-4fa6-8d41-4323aca6****` by using parameter settings provided in this topic. The information includes the creator, creation time, status, and deletion protection status of the CMK.
         *
         * @param request DescribeKeyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeKeyResponse
         */
        public DescribeKeyResponse DescribeKeyWithOptions(DescribeKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyId))
            {
                query["KeyId"] = request.KeyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeKey",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<DescribeKeyResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeKeyResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @summary Queries the information about a customer master key (CMK).
         *
         * @description You can query the information about the CMK `05754286-3ba2-4fa6-8d41-4323aca6****` by using parameter settings provided in this topic. The information includes the creator, creation time, status, and deletion protection status of the CMK.
         *
         * @param request DescribeKeyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeKeyResponse
         */
        public async Task<DescribeKeyResponse> DescribeKeyWithOptionsAsync(DescribeKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyId))
            {
                query["KeyId"] = request.KeyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeKey",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<DescribeKeyResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeKeyResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @summary Queries the information about a customer master key (CMK).
         *
         * @description You can query the information about the CMK `05754286-3ba2-4fa6-8d41-4323aca6****` by using parameter settings provided in this topic. The information includes the creator, creation time, status, and deletion protection status of the CMK.
         *
         * @param request DescribeKeyRequest
         * @return DescribeKeyResponse
         */
        public DescribeKeyResponse DescribeKey(DescribeKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeKeyWithOptions(request, runtime);
        }

        /**
         * @summary Queries the information about a customer master key (CMK).
         *
         * @description You can query the information about the CMK `05754286-3ba2-4fa6-8d41-4323aca6****` by using parameter settings provided in this topic. The information includes the creator, creation time, status, and deletion protection status of the CMK.
         *
         * @param request DescribeKeyRequest
         * @return DescribeKeyResponse
         */
        public async Task<DescribeKeyResponse> DescribeKeyAsync(DescribeKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeKeyWithOptionsAsync(request, runtime);
        }

        /**
         * @description This topic provides an example on how to query the information about a version of the CMK `1234abcd-12ab-34cd-56ef-12345678****`. The ID of the CMK version is `2ab1a983-7072-4bbc-a582-584b5bd8****`. The response shows that the creation time of the CMK version is `2016-03-25T10:42:40Z`.
         *
         * @param request DescribeKeyVersionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeKeyVersionResponse
         */
        public DescribeKeyVersionResponse DescribeKeyVersionWithOptions(DescribeKeyVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyId))
            {
                query["KeyId"] = request.KeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyVersionId))
            {
                query["KeyVersionId"] = request.KeyVersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeKeyVersion",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<DescribeKeyVersionResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeKeyVersionResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @description This topic provides an example on how to query the information about a version of the CMK `1234abcd-12ab-34cd-56ef-12345678****`. The ID of the CMK version is `2ab1a983-7072-4bbc-a582-584b5bd8****`. The response shows that the creation time of the CMK version is `2016-03-25T10:42:40Z`.
         *
         * @param request DescribeKeyVersionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeKeyVersionResponse
         */
        public async Task<DescribeKeyVersionResponse> DescribeKeyVersionWithOptionsAsync(DescribeKeyVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyId))
            {
                query["KeyId"] = request.KeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyVersionId))
            {
                query["KeyVersionId"] = request.KeyVersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeKeyVersion",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<DescribeKeyVersionResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeKeyVersionResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @description This topic provides an example on how to query the information about a version of the CMK `1234abcd-12ab-34cd-56ef-12345678****`. The ID of the CMK version is `2ab1a983-7072-4bbc-a582-584b5bd8****`. The response shows that the creation time of the CMK version is `2016-03-25T10:42:40Z`.
         *
         * @param request DescribeKeyVersionRequest
         * @return DescribeKeyVersionResponse
         */
        public DescribeKeyVersionResponse DescribeKeyVersion(DescribeKeyVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeKeyVersionWithOptions(request, runtime);
        }

        /**
         * @description This topic provides an example on how to query the information about a version of the CMK `1234abcd-12ab-34cd-56ef-12345678****`. The ID of the CMK version is `2ab1a983-7072-4bbc-a582-584b5bd8****`. The response shows that the creation time of the CMK version is `2016-03-25T10:42:40Z`.
         *
         * @param request DescribeKeyVersionRequest
         * @return DescribeKeyVersionResponse
         */
        public async Task<DescribeKeyVersionResponse> DescribeKeyVersionAsync(DescribeKeyVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeKeyVersionWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the details of an access control rule.
         *
         * @param request DescribeNetworkRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeNetworkRuleResponse
         */
        public DescribeNetworkRuleResponse DescribeNetworkRuleWithOptions(DescribeNetworkRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "DescribeNetworkRule",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<DescribeNetworkRuleResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeNetworkRuleResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @summary Queries the details of an access control rule.
         *
         * @param request DescribeNetworkRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeNetworkRuleResponse
         */
        public async Task<DescribeNetworkRuleResponse> DescribeNetworkRuleWithOptionsAsync(DescribeNetworkRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "DescribeNetworkRule",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<DescribeNetworkRuleResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeNetworkRuleResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @summary Queries the details of an access control rule.
         *
         * @param request DescribeNetworkRuleRequest
         * @return DescribeNetworkRuleResponse
         */
        public DescribeNetworkRuleResponse DescribeNetworkRule(DescribeNetworkRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeNetworkRuleWithOptions(request, runtime);
        }

        /**
         * @summary Queries the details of an access control rule.
         *
         * @param request DescribeNetworkRuleRequest
         * @return DescribeNetworkRuleResponse
         */
        public async Task<DescribeNetworkRuleResponse> DescribeNetworkRuleAsync(DescribeNetworkRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeNetworkRuleWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the details of a permission policy.
         *
         * @param request DescribePolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePolicyResponse
         */
        public DescribePolicyResponse DescribePolicyWithOptions(DescribePolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "DescribePolicy",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<DescribePolicyResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribePolicyResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @summary Queries the details of a permission policy.
         *
         * @param request DescribePolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePolicyResponse
         */
        public async Task<DescribePolicyResponse> DescribePolicyWithOptionsAsync(DescribePolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "DescribePolicy",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<DescribePolicyResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribePolicyResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @summary Queries the details of a permission policy.
         *
         * @param request DescribePolicyRequest
         * @return DescribePolicyResponse
         */
        public DescribePolicyResponse DescribePolicy(DescribePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePolicyWithOptions(request, runtime);
        }

        /**
         * @summary Queries the details of a permission policy.
         *
         * @param request DescribePolicyRequest
         * @return DescribePolicyResponse
         */
        public async Task<DescribePolicyResponse> DescribePolicyAsync(DescribePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePolicyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries available regions.
         *
         * @description ## Debugging
         * [OpenAPI Explorer automatically calculates the signature value. For your convenience, we recommend that you call this operation in OpenAPI Explorer. OpenAPI Explorer dynamically generates the sample code of the operation for different SDKs.](https://api.aliyun.com/#product=Kms\\&api=DescribeRegions\\&type=RPC\\&version=2016-01-20)
         *
         * @param request DescribeRegionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRegionsResponse
         */
        public DescribeRegionsResponse DescribeRegionsWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<DescribeRegionsResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeRegionsResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @summary Queries available regions.
         *
         * @description ## Debugging
         * [OpenAPI Explorer automatically calculates the signature value. For your convenience, we recommend that you call this operation in OpenAPI Explorer. OpenAPI Explorer dynamically generates the sample code of the operation for different SDKs.](https://api.aliyun.com/#product=Kms\\&api=DescribeRegions\\&type=RPC\\&version=2016-01-20)
         *
         * @param request DescribeRegionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRegionsResponse
         */
        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<DescribeRegionsResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeRegionsResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @summary Queries available regions.
         *
         * @description ## Debugging
         * [OpenAPI Explorer automatically calculates the signature value. For your convenience, we recommend that you call this operation in OpenAPI Explorer. OpenAPI Explorer dynamically generates the sample code of the operation for different SDKs.](https://api.aliyun.com/#product=Kms\\&api=DescribeRegions\\&type=RPC\\&version=2016-01-20)
         *
         * @return DescribeRegionsResponse
         */
        public DescribeRegionsResponse DescribeRegions()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRegionsWithOptions(runtime);
        }

        /**
         * @summary Queries available regions.
         *
         * @description ## Debugging
         * [OpenAPI Explorer automatically calculates the signature value. For your convenience, we recommend that you call this operation in OpenAPI Explorer. OpenAPI Explorer dynamically generates the sample code of the operation for different SDKs.](https://api.aliyun.com/#product=Kms\\&api=DescribeRegions\\&type=RPC\\&version=2016-01-20)
         *
         * @return DescribeRegionsResponse
         */
        public async Task<DescribeRegionsResponse> DescribeRegionsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRegionsWithOptionsAsync(runtime);
        }

        /**
         * @description This operation returns the metadata of a secret. This operation does not return the secret value.
         * In this example, the metadata of the secret named `secret001` is queried.
         *
         * @param request DescribeSecretRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSecretResponse
         */
        public DescribeSecretResponse DescribeSecretWithOptions(DescribeSecretRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FetchTags))
            {
                query["FetchTags"] = request.FetchTags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretName))
            {
                query["SecretName"] = request.SecretName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSecret",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<DescribeSecretResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeSecretResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @description This operation returns the metadata of a secret. This operation does not return the secret value.
         * In this example, the metadata of the secret named `secret001` is queried.
         *
         * @param request DescribeSecretRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSecretResponse
         */
        public async Task<DescribeSecretResponse> DescribeSecretWithOptionsAsync(DescribeSecretRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FetchTags))
            {
                query["FetchTags"] = request.FetchTags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretName))
            {
                query["SecretName"] = request.SecretName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSecret",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<DescribeSecretResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeSecretResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @description This operation returns the metadata of a secret. This operation does not return the secret value.
         * In this example, the metadata of the secret named `secret001` is queried.
         *
         * @param request DescribeSecretRequest
         * @return DescribeSecretResponse
         */
        public DescribeSecretResponse DescribeSecret(DescribeSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSecretWithOptions(request, runtime);
        }

        /**
         * @description This operation returns the metadata of a secret. This operation does not return the secret value.
         * In this example, the metadata of the secret named `secret001` is queried.
         *
         * @param request DescribeSecretRequest
         * @return DescribeSecretResponse
         */
        public async Task<DescribeSecretResponse> DescribeSecretAsync(DescribeSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSecretWithOptionsAsync(request, runtime);
        }

        /**
         * @description If a customer master key (CMK) is disabled, the ciphertext encrypted by using this CMK cannot be decrypted until you re-enable it. You can call the [EnableKey](https://help.aliyun.com/document_detail/35150.html) operation to enable the CMK.
         * In this example, the CMK whose ID is `1234abcd-12ab-34cd-56ef-12345678****` is disabled.
         *
         * @param request DisableKeyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DisableKeyResponse
         */
        public DisableKeyResponse DisableKeyWithOptions(DisableKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyId))
            {
                query["KeyId"] = request.KeyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableKey",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<DisableKeyResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DisableKeyResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @description If a customer master key (CMK) is disabled, the ciphertext encrypted by using this CMK cannot be decrypted until you re-enable it. You can call the [EnableKey](https://help.aliyun.com/document_detail/35150.html) operation to enable the CMK.
         * In this example, the CMK whose ID is `1234abcd-12ab-34cd-56ef-12345678****` is disabled.
         *
         * @param request DisableKeyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DisableKeyResponse
         */
        public async Task<DisableKeyResponse> DisableKeyWithOptionsAsync(DisableKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyId))
            {
                query["KeyId"] = request.KeyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableKey",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<DisableKeyResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DisableKeyResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @description If a customer master key (CMK) is disabled, the ciphertext encrypted by using this CMK cannot be decrypted until you re-enable it. You can call the [EnableKey](https://help.aliyun.com/document_detail/35150.html) operation to enable the CMK.
         * In this example, the CMK whose ID is `1234abcd-12ab-34cd-56ef-12345678****` is disabled.
         *
         * @param request DisableKeyRequest
         * @return DisableKeyResponse
         */
        public DisableKeyResponse DisableKey(DisableKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableKeyWithOptions(request, runtime);
        }

        /**
         * @description If a customer master key (CMK) is disabled, the ciphertext encrypted by using this CMK cannot be decrypted until you re-enable it. You can call the [EnableKey](https://help.aliyun.com/document_detail/35150.html) operation to enable the CMK.
         * In this example, the CMK whose ID is `1234abcd-12ab-34cd-56ef-12345678****` is disabled.
         *
         * @param request DisableKeyRequest
         * @return DisableKeyResponse
         */
        public async Task<DisableKeyResponse> DisableKeyAsync(DisableKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableKeyWithOptionsAsync(request, runtime);
        }

        /**
         * @param request EnableKeyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return EnableKeyResponse
         */
        public EnableKeyResponse EnableKeyWithOptions(EnableKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyId))
            {
                query["KeyId"] = request.KeyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableKey",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<EnableKeyResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<EnableKeyResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @param request EnableKeyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return EnableKeyResponse
         */
        public async Task<EnableKeyResponse> EnableKeyWithOptionsAsync(EnableKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyId))
            {
                query["KeyId"] = request.KeyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableKey",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<EnableKeyResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<EnableKeyResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @param request EnableKeyRequest
         * @return EnableKeyResponse
         */
        public EnableKeyResponse EnableKey(EnableKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableKeyWithOptions(request, runtime);
        }

        /**
         * @param request EnableKeyRequest
         * @return EnableKeyResponse
         */
        public async Task<EnableKeyResponse> EnableKeyAsync(EnableKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableKeyWithOptionsAsync(request, runtime);
        }

        /**
         * @description *   KMS uses the primary version of a specified CMK to encrypt data.
         * *   Only data of 6 KB or less can be encrypted. For example, you can call this operation to encrypt RSA keys, database access passwords, or other sensitive information.
         * *   When you migrate encrypted data across regions, you can call this operation in the destination region to encrypt the plaintext of the data key that is used to encrypt the migrated data in the source region. This way, the ciphertext of the data key is generated in the destination region. You can also call the [Decrypt](https://help.aliyun.com/document_detail/28950.html) operation to decrypt the data key.
         *
         * @param tmpReq EncryptRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return EncryptResponse
         */
        public EncryptResponse EncryptWithOptions(EncryptRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            EncryptShrinkRequest request = new EncryptShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EncryptionContext))
            {
                request.EncryptionContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EncryptionContext, "EncryptionContext", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptionContextShrink))
            {
                query["EncryptionContext"] = request.EncryptionContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyId))
            {
                query["KeyId"] = request.KeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Plaintext))
            {
                query["Plaintext"] = request.Plaintext;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Encrypt",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<EncryptResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<EncryptResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @description *   KMS uses the primary version of a specified CMK to encrypt data.
         * *   Only data of 6 KB or less can be encrypted. For example, you can call this operation to encrypt RSA keys, database access passwords, or other sensitive information.
         * *   When you migrate encrypted data across regions, you can call this operation in the destination region to encrypt the plaintext of the data key that is used to encrypt the migrated data in the source region. This way, the ciphertext of the data key is generated in the destination region. You can also call the [Decrypt](https://help.aliyun.com/document_detail/28950.html) operation to decrypt the data key.
         *
         * @param tmpReq EncryptRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return EncryptResponse
         */
        public async Task<EncryptResponse> EncryptWithOptionsAsync(EncryptRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            EncryptShrinkRequest request = new EncryptShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EncryptionContext))
            {
                request.EncryptionContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EncryptionContext, "EncryptionContext", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptionContextShrink))
            {
                query["EncryptionContext"] = request.EncryptionContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyId))
            {
                query["KeyId"] = request.KeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Plaintext))
            {
                query["Plaintext"] = request.Plaintext;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Encrypt",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<EncryptResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<EncryptResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @description *   KMS uses the primary version of a specified CMK to encrypt data.
         * *   Only data of 6 KB or less can be encrypted. For example, you can call this operation to encrypt RSA keys, database access passwords, or other sensitive information.
         * *   When you migrate encrypted data across regions, you can call this operation in the destination region to encrypt the plaintext of the data key that is used to encrypt the migrated data in the source region. This way, the ciphertext of the data key is generated in the destination region. You can also call the [Decrypt](https://help.aliyun.com/document_detail/28950.html) operation to decrypt the data key.
         *
         * @param request EncryptRequest
         * @return EncryptResponse
         */
        public EncryptResponse Encrypt(EncryptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EncryptWithOptions(request, runtime);
        }

        /**
         * @description *   KMS uses the primary version of a specified CMK to encrypt data.
         * *   Only data of 6 KB or less can be encrypted. For example, you can call this operation to encrypt RSA keys, database access passwords, or other sensitive information.
         * *   When you migrate encrypted data across regions, you can call this operation in the destination region to encrypt the plaintext of the data key that is used to encrypt the migrated data in the source region. This way, the ciphertext of the data key is generated in the destination region. You can also call the [Decrypt](https://help.aliyun.com/document_detail/28950.html) operation to decrypt the data key.
         *
         * @param request EncryptRequest
         * @return EncryptResponse
         */
        public async Task<EncryptResponse> EncryptAsync(EncryptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EncryptWithOptionsAsync(request, runtime);
        }

        /**
         * @description You can call the [GenerateDataKeyWithoutPlaintext](https://help.aliyun.com/document_detail/134043.html) operation to generate a data key, which is encrypted by a CMK. If you want to distribute the data key to other regions or cryptographic modules, you can call the ExportDataKey operation to use a public key to encrypt the data key.
         * Then, you can import the ciphertext of the data key to the cryptographic module where the private key is stored. This way, the data key is securely distributed from KMS to the cryptographic module. After the data key is imported to the cryptographic module, you can use it to encrypt or decrypt data.
         *
         * @param tmpReq ExportDataKeyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ExportDataKeyResponse
         */
        public ExportDataKeyResponse ExportDataKeyWithOptions(ExportDataKeyRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ExportDataKeyShrinkRequest request = new ExportDataKeyShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EncryptionContext))
            {
                request.EncryptionContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EncryptionContext, "EncryptionContext", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CiphertextBlob))
            {
                query["CiphertextBlob"] = request.CiphertextBlob;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptionContextShrink))
            {
                query["EncryptionContext"] = request.EncryptionContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublicKeyBlob))
            {
                query["PublicKeyBlob"] = request.PublicKeyBlob;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WrappingAlgorithm))
            {
                query["WrappingAlgorithm"] = request.WrappingAlgorithm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WrappingKeySpec))
            {
                query["WrappingKeySpec"] = request.WrappingKeySpec;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExportDataKey",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<ExportDataKeyResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ExportDataKeyResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @description You can call the [GenerateDataKeyWithoutPlaintext](https://help.aliyun.com/document_detail/134043.html) operation to generate a data key, which is encrypted by a CMK. If you want to distribute the data key to other regions or cryptographic modules, you can call the ExportDataKey operation to use a public key to encrypt the data key.
         * Then, you can import the ciphertext of the data key to the cryptographic module where the private key is stored. This way, the data key is securely distributed from KMS to the cryptographic module. After the data key is imported to the cryptographic module, you can use it to encrypt or decrypt data.
         *
         * @param tmpReq ExportDataKeyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ExportDataKeyResponse
         */
        public async Task<ExportDataKeyResponse> ExportDataKeyWithOptionsAsync(ExportDataKeyRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ExportDataKeyShrinkRequest request = new ExportDataKeyShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EncryptionContext))
            {
                request.EncryptionContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EncryptionContext, "EncryptionContext", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CiphertextBlob))
            {
                query["CiphertextBlob"] = request.CiphertextBlob;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptionContextShrink))
            {
                query["EncryptionContext"] = request.EncryptionContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublicKeyBlob))
            {
                query["PublicKeyBlob"] = request.PublicKeyBlob;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WrappingAlgorithm))
            {
                query["WrappingAlgorithm"] = request.WrappingAlgorithm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WrappingKeySpec))
            {
                query["WrappingKeySpec"] = request.WrappingKeySpec;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExportDataKey",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<ExportDataKeyResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ExportDataKeyResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @description You can call the [GenerateDataKeyWithoutPlaintext](https://help.aliyun.com/document_detail/134043.html) operation to generate a data key, which is encrypted by a CMK. If you want to distribute the data key to other regions or cryptographic modules, you can call the ExportDataKey operation to use a public key to encrypt the data key.
         * Then, you can import the ciphertext of the data key to the cryptographic module where the private key is stored. This way, the data key is securely distributed from KMS to the cryptographic module. After the data key is imported to the cryptographic module, you can use it to encrypt or decrypt data.
         *
         * @param request ExportDataKeyRequest
         * @return ExportDataKeyResponse
         */
        public ExportDataKeyResponse ExportDataKey(ExportDataKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExportDataKeyWithOptions(request, runtime);
        }

        /**
         * @description You can call the [GenerateDataKeyWithoutPlaintext](https://help.aliyun.com/document_detail/134043.html) operation to generate a data key, which is encrypted by a CMK. If you want to distribute the data key to other regions or cryptographic modules, you can call the ExportDataKey operation to use a public key to encrypt the data key.
         * Then, you can import the ciphertext of the data key to the cryptographic module where the private key is stored. This way, the data key is securely distributed from KMS to the cryptographic module. After the data key is imported to the cryptographic module, you can use it to encrypt or decrypt data.
         *
         * @param request ExportDataKeyRequest
         * @return ExportDataKeyResponse
         */
        public async Task<ExportDataKeyResponse> ExportDataKeyAsync(ExportDataKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExportDataKeyWithOptionsAsync(request, runtime);
        }

        /**
         * @description We recommend that you perform the following steps to import your data key to a cryptographic module:
         * *   Call the GenerateAndExportDataKey operation to generate a data key and obtain both the ciphertext of the data key encrypted by using the CMK and that encrypted by using the public key.
         * *   Store the ciphertext of the data key encrypted by using the CMK in KMS Secrets Manager or in a storage service such as ApsaraDB. This ciphertext is used for backup and restoration.
         * *   Import the ciphertext of the data key encrypted by using the public key to the cryptographic module where the private key is stored. Then, you can use the data key to encrypt or decrypt data.
         * >  The CMK that you specify in the request of this operation is only used to encrypt the data key and is not involved in the generation of the data key. KMS does not record or store the data keys randomly generated by calling this operation. You must take note of the data keys and the returned ciphertext.
         *
         * @param tmpReq GenerateAndExportDataKeyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GenerateAndExportDataKeyResponse
         */
        public GenerateAndExportDataKeyResponse GenerateAndExportDataKeyWithOptions(GenerateAndExportDataKeyRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GenerateAndExportDataKeyShrinkRequest request = new GenerateAndExportDataKeyShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EncryptionContext))
            {
                request.EncryptionContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EncryptionContext, "EncryptionContext", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptionContextShrink))
            {
                query["EncryptionContext"] = request.EncryptionContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyId))
            {
                query["KeyId"] = request.KeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeySpec))
            {
                query["KeySpec"] = request.KeySpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NumberOfBytes))
            {
                query["NumberOfBytes"] = request.NumberOfBytes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublicKeyBlob))
            {
                query["PublicKeyBlob"] = request.PublicKeyBlob;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WrappingAlgorithm))
            {
                query["WrappingAlgorithm"] = request.WrappingAlgorithm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WrappingKeySpec))
            {
                query["WrappingKeySpec"] = request.WrappingKeySpec;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateAndExportDataKey",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<GenerateAndExportDataKeyResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GenerateAndExportDataKeyResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @description We recommend that you perform the following steps to import your data key to a cryptographic module:
         * *   Call the GenerateAndExportDataKey operation to generate a data key and obtain both the ciphertext of the data key encrypted by using the CMK and that encrypted by using the public key.
         * *   Store the ciphertext of the data key encrypted by using the CMK in KMS Secrets Manager or in a storage service such as ApsaraDB. This ciphertext is used for backup and restoration.
         * *   Import the ciphertext of the data key encrypted by using the public key to the cryptographic module where the private key is stored. Then, you can use the data key to encrypt or decrypt data.
         * >  The CMK that you specify in the request of this operation is only used to encrypt the data key and is not involved in the generation of the data key. KMS does not record or store the data keys randomly generated by calling this operation. You must take note of the data keys and the returned ciphertext.
         *
         * @param tmpReq GenerateAndExportDataKeyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GenerateAndExportDataKeyResponse
         */
        public async Task<GenerateAndExportDataKeyResponse> GenerateAndExportDataKeyWithOptionsAsync(GenerateAndExportDataKeyRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GenerateAndExportDataKeyShrinkRequest request = new GenerateAndExportDataKeyShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EncryptionContext))
            {
                request.EncryptionContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EncryptionContext, "EncryptionContext", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptionContextShrink))
            {
                query["EncryptionContext"] = request.EncryptionContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyId))
            {
                query["KeyId"] = request.KeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeySpec))
            {
                query["KeySpec"] = request.KeySpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NumberOfBytes))
            {
                query["NumberOfBytes"] = request.NumberOfBytes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublicKeyBlob))
            {
                query["PublicKeyBlob"] = request.PublicKeyBlob;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WrappingAlgorithm))
            {
                query["WrappingAlgorithm"] = request.WrappingAlgorithm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WrappingKeySpec))
            {
                query["WrappingKeySpec"] = request.WrappingKeySpec;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateAndExportDataKey",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<GenerateAndExportDataKeyResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GenerateAndExportDataKeyResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @description We recommend that you perform the following steps to import your data key to a cryptographic module:
         * *   Call the GenerateAndExportDataKey operation to generate a data key and obtain both the ciphertext of the data key encrypted by using the CMK and that encrypted by using the public key.
         * *   Store the ciphertext of the data key encrypted by using the CMK in KMS Secrets Manager or in a storage service such as ApsaraDB. This ciphertext is used for backup and restoration.
         * *   Import the ciphertext of the data key encrypted by using the public key to the cryptographic module where the private key is stored. Then, you can use the data key to encrypt or decrypt data.
         * >  The CMK that you specify in the request of this operation is only used to encrypt the data key and is not involved in the generation of the data key. KMS does not record or store the data keys randomly generated by calling this operation. You must take note of the data keys and the returned ciphertext.
         *
         * @param request GenerateAndExportDataKeyRequest
         * @return GenerateAndExportDataKeyResponse
         */
        public GenerateAndExportDataKeyResponse GenerateAndExportDataKey(GenerateAndExportDataKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateAndExportDataKeyWithOptions(request, runtime);
        }

        /**
         * @description We recommend that you perform the following steps to import your data key to a cryptographic module:
         * *   Call the GenerateAndExportDataKey operation to generate a data key and obtain both the ciphertext of the data key encrypted by using the CMK and that encrypted by using the public key.
         * *   Store the ciphertext of the data key encrypted by using the CMK in KMS Secrets Manager or in a storage service such as ApsaraDB. This ciphertext is used for backup and restoration.
         * *   Import the ciphertext of the data key encrypted by using the public key to the cryptographic module where the private key is stored. Then, you can use the data key to encrypt or decrypt data.
         * >  The CMK that you specify in the request of this operation is only used to encrypt the data key and is not involved in the generation of the data key. KMS does not record or store the data keys randomly generated by calling this operation. You must take note of the data keys and the returned ciphertext.
         *
         * @param request GenerateAndExportDataKeyRequest
         * @return GenerateAndExportDataKeyResponse
         */
        public async Task<GenerateAndExportDataKeyResponse> GenerateAndExportDataKeyAsync(GenerateAndExportDataKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateAndExportDataKeyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 生成一个数据密钥
         *
         * @description This operation creates a random data key, encrypts the data key by using the specified customer master key (CMK), and returns the plaintext and ciphertext of the data key. You can use the plaintext of the data key to locally encrypt your data without using KMS and store the encrypted data together with the ciphertext of the data key. You can obtain the plaintext of the data key from the Plaintext parameter in the response and the ciphertext of the data key from the CiphertextBlob parameter in the response.
         * The CMK that you specify in the request of this operation is only used to encrypt the data key and is not involved in the generation of the data key. KMS does not record or store the generated data key. Therefore, you need to store the ciphertext of the data key in persistent storage.
         * We recommend that you locally encrypt data by performing the following steps:
         * 1\\. Call the GenerateDataKey operation.
         * 2\\. Use the plaintext of the data key that you obtain to locally encrypt data without using KMS. Then, delete the plaintext of the data key from the memory.
         * 3\\. Store the encrypted data together with the ciphertext of the data key that you obtain.
         * We recommend that you locally decrypt data by performing the following steps:
         * *   Call the [Decrypt](https://help.aliyun.com/document_detail/28950.html) operation to decrypt the locally stored ciphertext of the data key. The plaintext of data key is then returned.
         * *   Use the plaintext of the data key to locally decrypt data and then delete the plaintext of the data key from the memory.
         * In this example, a random data key is generated for the CMK whose ID is `7906979c-8e06-46a2-be2d-68e3ccbc****`.
         *
         * @param tmpReq GenerateDataKeyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GenerateDataKeyResponse
         */
        public GenerateDataKeyResponse GenerateDataKeyWithOptions(GenerateDataKeyRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GenerateDataKeyShrinkRequest request = new GenerateDataKeyShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EncryptionContext))
            {
                request.EncryptionContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EncryptionContext, "EncryptionContext", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptionContextShrink))
            {
                query["EncryptionContext"] = request.EncryptionContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyId))
            {
                query["KeyId"] = request.KeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeySpec))
            {
                query["KeySpec"] = request.KeySpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NumberOfBytes))
            {
                query["NumberOfBytes"] = request.NumberOfBytes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateDataKey",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<GenerateDataKeyResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GenerateDataKeyResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @summary 生成一个数据密钥
         *
         * @description This operation creates a random data key, encrypts the data key by using the specified customer master key (CMK), and returns the plaintext and ciphertext of the data key. You can use the plaintext of the data key to locally encrypt your data without using KMS and store the encrypted data together with the ciphertext of the data key. You can obtain the plaintext of the data key from the Plaintext parameter in the response and the ciphertext of the data key from the CiphertextBlob parameter in the response.
         * The CMK that you specify in the request of this operation is only used to encrypt the data key and is not involved in the generation of the data key. KMS does not record or store the generated data key. Therefore, you need to store the ciphertext of the data key in persistent storage.
         * We recommend that you locally encrypt data by performing the following steps:
         * 1\\. Call the GenerateDataKey operation.
         * 2\\. Use the plaintext of the data key that you obtain to locally encrypt data without using KMS. Then, delete the plaintext of the data key from the memory.
         * 3\\. Store the encrypted data together with the ciphertext of the data key that you obtain.
         * We recommend that you locally decrypt data by performing the following steps:
         * *   Call the [Decrypt](https://help.aliyun.com/document_detail/28950.html) operation to decrypt the locally stored ciphertext of the data key. The plaintext of data key is then returned.
         * *   Use the plaintext of the data key to locally decrypt data and then delete the plaintext of the data key from the memory.
         * In this example, a random data key is generated for the CMK whose ID is `7906979c-8e06-46a2-be2d-68e3ccbc****`.
         *
         * @param tmpReq GenerateDataKeyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GenerateDataKeyResponse
         */
        public async Task<GenerateDataKeyResponse> GenerateDataKeyWithOptionsAsync(GenerateDataKeyRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GenerateDataKeyShrinkRequest request = new GenerateDataKeyShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EncryptionContext))
            {
                request.EncryptionContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EncryptionContext, "EncryptionContext", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptionContextShrink))
            {
                query["EncryptionContext"] = request.EncryptionContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyId))
            {
                query["KeyId"] = request.KeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeySpec))
            {
                query["KeySpec"] = request.KeySpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NumberOfBytes))
            {
                query["NumberOfBytes"] = request.NumberOfBytes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateDataKey",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<GenerateDataKeyResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GenerateDataKeyResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @summary 生成一个数据密钥
         *
         * @description This operation creates a random data key, encrypts the data key by using the specified customer master key (CMK), and returns the plaintext and ciphertext of the data key. You can use the plaintext of the data key to locally encrypt your data without using KMS and store the encrypted data together with the ciphertext of the data key. You can obtain the plaintext of the data key from the Plaintext parameter in the response and the ciphertext of the data key from the CiphertextBlob parameter in the response.
         * The CMK that you specify in the request of this operation is only used to encrypt the data key and is not involved in the generation of the data key. KMS does not record or store the generated data key. Therefore, you need to store the ciphertext of the data key in persistent storage.
         * We recommend that you locally encrypt data by performing the following steps:
         * 1\\. Call the GenerateDataKey operation.
         * 2\\. Use the plaintext of the data key that you obtain to locally encrypt data without using KMS. Then, delete the plaintext of the data key from the memory.
         * 3\\. Store the encrypted data together with the ciphertext of the data key that you obtain.
         * We recommend that you locally decrypt data by performing the following steps:
         * *   Call the [Decrypt](https://help.aliyun.com/document_detail/28950.html) operation to decrypt the locally stored ciphertext of the data key. The plaintext of data key is then returned.
         * *   Use the plaintext of the data key to locally decrypt data and then delete the plaintext of the data key from the memory.
         * In this example, a random data key is generated for the CMK whose ID is `7906979c-8e06-46a2-be2d-68e3ccbc****`.
         *
         * @param request GenerateDataKeyRequest
         * @return GenerateDataKeyResponse
         */
        public GenerateDataKeyResponse GenerateDataKey(GenerateDataKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateDataKeyWithOptions(request, runtime);
        }

        /**
         * @summary 生成一个数据密钥
         *
         * @description This operation creates a random data key, encrypts the data key by using the specified customer master key (CMK), and returns the plaintext and ciphertext of the data key. You can use the plaintext of the data key to locally encrypt your data without using KMS and store the encrypted data together with the ciphertext of the data key. You can obtain the plaintext of the data key from the Plaintext parameter in the response and the ciphertext of the data key from the CiphertextBlob parameter in the response.
         * The CMK that you specify in the request of this operation is only used to encrypt the data key and is not involved in the generation of the data key. KMS does not record or store the generated data key. Therefore, you need to store the ciphertext of the data key in persistent storage.
         * We recommend that you locally encrypt data by performing the following steps:
         * 1\\. Call the GenerateDataKey operation.
         * 2\\. Use the plaintext of the data key that you obtain to locally encrypt data without using KMS. Then, delete the plaintext of the data key from the memory.
         * 3\\. Store the encrypted data together with the ciphertext of the data key that you obtain.
         * We recommend that you locally decrypt data by performing the following steps:
         * *   Call the [Decrypt](https://help.aliyun.com/document_detail/28950.html) operation to decrypt the locally stored ciphertext of the data key. The plaintext of data key is then returned.
         * *   Use the plaintext of the data key to locally decrypt data and then delete the plaintext of the data key from the memory.
         * In this example, a random data key is generated for the CMK whose ID is `7906979c-8e06-46a2-be2d-68e3ccbc****`.
         *
         * @param request GenerateDataKeyRequest
         * @return GenerateDataKeyResponse
         */
        public async Task<GenerateDataKeyResponse> GenerateDataKeyAsync(GenerateDataKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateDataKeyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Generates a random data key, which can be used to encrypt local data.
         *
         * @description This operation creates a random data key, encrypts the data key by using a specific symmetric CMK, and returns the ciphertext of the data key. This operation serves the same purpose as the [GenerateDataKey](https://help.aliyun.com/document_detail/28948.html) operation. The only difference is that this operation does not return the plaintext of the data key.
         * The CMK that you specify in the request of this operation is only used to encrypt the data key and is not involved in the generation of the data key. KMS does not record or store the generated data key.
         * > * This operation applies to the scenario when you do not need to use the data key to immediately encrypt data. Before you can use the data key to encrypt data, you must call the [Decrypt](https://help.aliyun.com/document_detail/28950.html) operation to decrypt the ciphertext of the data key.
         * > * This operation is also suitable for a distributed system with different trust levels. For example, a system stores data in different partitions based on a preset trust policy. A module creates different partitions and generates different data keys for each partition in advance. This module is not involved in data production and consumption after it completes initialization of the control plane. This module is the key provider. When producing and consuming data, modules on the control plane obtain the ciphertext of the data key for a partition first. After decrypting the ciphertext of the data key, modules on the control plane use the plaintext of the data key to encrypt or decrypt data and then clear the plaintext of the data key from the memory. In such a system, the key provider does not need to obtain the plaintext of the data key. It only needs to have the permissions to call the GenerateDataKeyWithoutPlaintext operation. The data producers or consumers do not need to generate new data keys. They only need to have the permissions to call the Decrypt operation.
         *
         * @param tmpReq GenerateDataKeyWithoutPlaintextRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GenerateDataKeyWithoutPlaintextResponse
         */
        public GenerateDataKeyWithoutPlaintextResponse GenerateDataKeyWithoutPlaintextWithOptions(GenerateDataKeyWithoutPlaintextRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GenerateDataKeyWithoutPlaintextShrinkRequest request = new GenerateDataKeyWithoutPlaintextShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EncryptionContext))
            {
                request.EncryptionContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EncryptionContext, "EncryptionContext", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptionContextShrink))
            {
                query["EncryptionContext"] = request.EncryptionContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyId))
            {
                query["KeyId"] = request.KeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeySpec))
            {
                query["KeySpec"] = request.KeySpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NumberOfBytes))
            {
                query["NumberOfBytes"] = request.NumberOfBytes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateDataKeyWithoutPlaintext",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<GenerateDataKeyWithoutPlaintextResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GenerateDataKeyWithoutPlaintextResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @summary Generates a random data key, which can be used to encrypt local data.
         *
         * @description This operation creates a random data key, encrypts the data key by using a specific symmetric CMK, and returns the ciphertext of the data key. This operation serves the same purpose as the [GenerateDataKey](https://help.aliyun.com/document_detail/28948.html) operation. The only difference is that this operation does not return the plaintext of the data key.
         * The CMK that you specify in the request of this operation is only used to encrypt the data key and is not involved in the generation of the data key. KMS does not record or store the generated data key.
         * > * This operation applies to the scenario when you do not need to use the data key to immediately encrypt data. Before you can use the data key to encrypt data, you must call the [Decrypt](https://help.aliyun.com/document_detail/28950.html) operation to decrypt the ciphertext of the data key.
         * > * This operation is also suitable for a distributed system with different trust levels. For example, a system stores data in different partitions based on a preset trust policy. A module creates different partitions and generates different data keys for each partition in advance. This module is not involved in data production and consumption after it completes initialization of the control plane. This module is the key provider. When producing and consuming data, modules on the control plane obtain the ciphertext of the data key for a partition first. After decrypting the ciphertext of the data key, modules on the control plane use the plaintext of the data key to encrypt or decrypt data and then clear the plaintext of the data key from the memory. In such a system, the key provider does not need to obtain the plaintext of the data key. It only needs to have the permissions to call the GenerateDataKeyWithoutPlaintext operation. The data producers or consumers do not need to generate new data keys. They only need to have the permissions to call the Decrypt operation.
         *
         * @param tmpReq GenerateDataKeyWithoutPlaintextRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GenerateDataKeyWithoutPlaintextResponse
         */
        public async Task<GenerateDataKeyWithoutPlaintextResponse> GenerateDataKeyWithoutPlaintextWithOptionsAsync(GenerateDataKeyWithoutPlaintextRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GenerateDataKeyWithoutPlaintextShrinkRequest request = new GenerateDataKeyWithoutPlaintextShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EncryptionContext))
            {
                request.EncryptionContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EncryptionContext, "EncryptionContext", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptionContextShrink))
            {
                query["EncryptionContext"] = request.EncryptionContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyId))
            {
                query["KeyId"] = request.KeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeySpec))
            {
                query["KeySpec"] = request.KeySpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NumberOfBytes))
            {
                query["NumberOfBytes"] = request.NumberOfBytes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateDataKeyWithoutPlaintext",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<GenerateDataKeyWithoutPlaintextResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GenerateDataKeyWithoutPlaintextResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @summary Generates a random data key, which can be used to encrypt local data.
         *
         * @description This operation creates a random data key, encrypts the data key by using a specific symmetric CMK, and returns the ciphertext of the data key. This operation serves the same purpose as the [GenerateDataKey](https://help.aliyun.com/document_detail/28948.html) operation. The only difference is that this operation does not return the plaintext of the data key.
         * The CMK that you specify in the request of this operation is only used to encrypt the data key and is not involved in the generation of the data key. KMS does not record or store the generated data key.
         * > * This operation applies to the scenario when you do not need to use the data key to immediately encrypt data. Before you can use the data key to encrypt data, you must call the [Decrypt](https://help.aliyun.com/document_detail/28950.html) operation to decrypt the ciphertext of the data key.
         * > * This operation is also suitable for a distributed system with different trust levels. For example, a system stores data in different partitions based on a preset trust policy. A module creates different partitions and generates different data keys for each partition in advance. This module is not involved in data production and consumption after it completes initialization of the control plane. This module is the key provider. When producing and consuming data, modules on the control plane obtain the ciphertext of the data key for a partition first. After decrypting the ciphertext of the data key, modules on the control plane use the plaintext of the data key to encrypt or decrypt data and then clear the plaintext of the data key from the memory. In such a system, the key provider does not need to obtain the plaintext of the data key. It only needs to have the permissions to call the GenerateDataKeyWithoutPlaintext operation. The data producers or consumers do not need to generate new data keys. They only need to have the permissions to call the Decrypt operation.
         *
         * @param request GenerateDataKeyWithoutPlaintextRequest
         * @return GenerateDataKeyWithoutPlaintextResponse
         */
        public GenerateDataKeyWithoutPlaintextResponse GenerateDataKeyWithoutPlaintext(GenerateDataKeyWithoutPlaintextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateDataKeyWithoutPlaintextWithOptions(request, runtime);
        }

        /**
         * @summary Generates a random data key, which can be used to encrypt local data.
         *
         * @description This operation creates a random data key, encrypts the data key by using a specific symmetric CMK, and returns the ciphertext of the data key. This operation serves the same purpose as the [GenerateDataKey](https://help.aliyun.com/document_detail/28948.html) operation. The only difference is that this operation does not return the plaintext of the data key.
         * The CMK that you specify in the request of this operation is only used to encrypt the data key and is not involved in the generation of the data key. KMS does not record or store the generated data key.
         * > * This operation applies to the scenario when you do not need to use the data key to immediately encrypt data. Before you can use the data key to encrypt data, you must call the [Decrypt](https://help.aliyun.com/document_detail/28950.html) operation to decrypt the ciphertext of the data key.
         * > * This operation is also suitable for a distributed system with different trust levels. For example, a system stores data in different partitions based on a preset trust policy. A module creates different partitions and generates different data keys for each partition in advance. This module is not involved in data production and consumption after it completes initialization of the control plane. This module is the key provider. When producing and consuming data, modules on the control plane obtain the ciphertext of the data key for a partition first. After decrypting the ciphertext of the data key, modules on the control plane use the plaintext of the data key to encrypt or decrypt data and then clear the plaintext of the data key from the memory. In such a system, the key provider does not need to obtain the plaintext of the data key. It only needs to have the permissions to call the GenerateDataKeyWithoutPlaintext operation. The data producers or consumers do not need to generate new data keys. They only need to have the permissions to call the Decrypt operation.
         *
         * @param request GenerateDataKeyWithoutPlaintextRequest
         * @return GenerateDataKeyWithoutPlaintextResponse
         */
        public async Task<GenerateDataKeyWithoutPlaintextResponse> GenerateDataKeyWithoutPlaintextAsync(GenerateDataKeyWithoutPlaintextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateDataKeyWithoutPlaintextWithOptionsAsync(request, runtime);
        }

        /**
         * @description In this example, the certificate whose ID is `9a28de48-8d8b-484d-a766-dec4****` is queried. The certificate, certificate chain, certificate ID, and certificate signing request (CSR) are returned.
         *
         * @param request GetCertificateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCertificateResponse
         */
        public GetCertificateResponse GetCertificateWithOptions(GetCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertificateId))
            {
                query["CertificateId"] = request.CertificateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCertificate",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<GetCertificateResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetCertificateResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @description In this example, the certificate whose ID is `9a28de48-8d8b-484d-a766-dec4****` is queried. The certificate, certificate chain, certificate ID, and certificate signing request (CSR) are returned.
         *
         * @param request GetCertificateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCertificateResponse
         */
        public async Task<GetCertificateResponse> GetCertificateWithOptionsAsync(GetCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertificateId))
            {
                query["CertificateId"] = request.CertificateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCertificate",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<GetCertificateResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetCertificateResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @description In this example, the certificate whose ID is `9a28de48-8d8b-484d-a766-dec4****` is queried. The certificate, certificate chain, certificate ID, and certificate signing request (CSR) are returned.
         *
         * @param request GetCertificateRequest
         * @return GetCertificateResponse
         */
        public GetCertificateResponse GetCertificate(GetCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCertificateWithOptions(request, runtime);
        }

        /**
         * @description In this example, the certificate whose ID is `9a28de48-8d8b-484d-a766-dec4****` is queried. The certificate, certificate chain, certificate ID, and certificate signing request (CSR) are returned.
         *
         * @param request GetCertificateRequest
         * @return GetCertificateResponse
         */
        public async Task<GetCertificateResponse> GetCertificateAsync(GetCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCertificateWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the information about a client key.
         *
         * @param request GetClientKeyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetClientKeyResponse
         */
        public GetClientKeyResponse GetClientKeyWithOptions(GetClientKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetClientKey",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<GetClientKeyResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetClientKeyResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @summary Queries the information about a client key.
         *
         * @param request GetClientKeyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetClientKeyResponse
         */
        public async Task<GetClientKeyResponse> GetClientKeyWithOptionsAsync(GetClientKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetClientKey",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<GetClientKeyResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetClientKeyResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @summary Queries the information about a client key.
         *
         * @param request GetClientKeyRequest
         * @return GetClientKeyResponse
         */
        public GetClientKeyResponse GetClientKey(GetClientKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetClientKeyWithOptions(request, runtime);
        }

        /**
         * @summary Queries the information about a client key.
         *
         * @param request GetClientKeyRequest
         * @return GetClientKeyResponse
         */
        public async Task<GetClientKeyResponse> GetClientKeyAsync(GetClientKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetClientKeyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 仅可查询名称为 default 的 Key Policy，否则提示 Not Found。
         *
         * @param request GetKeyPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetKeyPolicyResponse
         */
        public GetKeyPolicyResponse GetKeyPolicyWithOptions(GetKeyPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyId))
            {
                query["KeyId"] = request.KeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                query["PolicyName"] = request.PolicyName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetKeyPolicy",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<GetKeyPolicyResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetKeyPolicyResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @summary 仅可查询名称为 default 的 Key Policy，否则提示 Not Found。
         *
         * @param request GetKeyPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetKeyPolicyResponse
         */
        public async Task<GetKeyPolicyResponse> GetKeyPolicyWithOptionsAsync(GetKeyPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyId))
            {
                query["KeyId"] = request.KeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                query["PolicyName"] = request.PolicyName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetKeyPolicy",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<GetKeyPolicyResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetKeyPolicyResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @summary 仅可查询名称为 default 的 Key Policy，否则提示 Not Found。
         *
         * @param request GetKeyPolicyRequest
         * @return GetKeyPolicyResponse
         */
        public GetKeyPolicyResponse GetKeyPolicy(GetKeyPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetKeyPolicyWithOptions(request, runtime);
        }

        /**
         * @summary 仅可查询名称为 default 的 Key Policy，否则提示 Not Found。
         *
         * @param request GetKeyPolicyRequest
         * @return GetKeyPolicyResponse
         */
        public async Task<GetKeyPolicyResponse> GetKeyPolicyAsync(GetKeyPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetKeyPolicyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the details of a Key Management Service (KMS) instance.
         *
         * @param request GetKmsInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetKmsInstanceResponse
         */
        public GetKmsInstanceResponse GetKmsInstanceWithOptions(GetKmsInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KmsInstanceId))
            {
                query["KmsInstanceId"] = request.KmsInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetKmsInstance",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<GetKmsInstanceResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetKmsInstanceResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @summary Queries the details of a Key Management Service (KMS) instance.
         *
         * @param request GetKmsInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetKmsInstanceResponse
         */
        public async Task<GetKmsInstanceResponse> GetKmsInstanceWithOptionsAsync(GetKmsInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KmsInstanceId))
            {
                query["KmsInstanceId"] = request.KmsInstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetKmsInstance",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<GetKmsInstanceResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetKmsInstanceResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @summary Queries the details of a Key Management Service (KMS) instance.
         *
         * @param request GetKmsInstanceRequest
         * @return GetKmsInstanceResponse
         */
        public GetKmsInstanceResponse GetKmsInstance(GetKmsInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetKmsInstanceWithOptions(request, runtime);
        }

        /**
         * @summary Queries the details of a Key Management Service (KMS) instance.
         *
         * @param request GetKmsInstanceRequest
         * @return GetKmsInstanceResponse
         */
        public async Task<GetKmsInstanceResponse> GetKmsInstanceAsync(GetKmsInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetKmsInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the parameters that are used to import key material for a customer master key (CMK).
         *
         * @description The returned parameters can be used to call the [ImportKeyMaterial](https://www.alibabacloud.com/help/en/key-management-service/latest/importkeymaterial) operation.
         * - You can import key material only for CMKs whose Origin parameter is set to EXTERNAL.
         * - The public key and token that are returned by the GetParametersForImport operation must be used together. The public key and token can be used to import key material only for the CMK that is specified when you call the operation.
         * - The public key and token that are returned vary each time you call the GetParametersForImport operation.
         * - You must specify the type of the public key and the encryption algorithm that are used to encrypt key material. The following table lists the types of public keys and the encryption algorithms allowed for each type.   
         * | Public key type | Encryption algorithm | Description |
         * | --------------- | -------------------- | ----------- |
         * | RSA_2048 | RSAES_PKCS1_V1_5 
         * RSAES_OAEP_SHA_1 
         * RSAES_OAEP_SHA_256 | CMKs of all regions and all protection levels are supported. 
         * Dedicated Key Management Service (KMS) does not support RSAES_OAEP_SHA_1. |
         * | EC_SM2 | SM2PKE | CMKs whose ProtectionLevel is set to HSM are supported. The SM2 algorithm is developed and approved by the State Cryptography Administration of China. The SM2 algorithm can be used only to import key material for a CMK whose ProtectionLevel is set to HSM. You can use the SM2 algorithm only when you enable the Managed HSM feature for KMS in the Chinese mainland. For more information, see [Overview of Managed HSM](https://www.alibabacloud.com/help/en/key-management-service/latest/managed-hsm-overview). |
         * For more information, see [Import key material](https://www.alibabacloud.com/help/en/key-management-service/latest/import-key-material). This topic provides an example on how to query the parameters that are used to import key material for a CMK. The ID of the CMK is `1234abcd-12ab-34cd-56ef-12345678****`, the encryption algorithm is `RSAES_PKCS1_V1_5`, and the public key is of the `RSA_2048` type. The parameters that are returned include the ID of the CMK, the public key that is used to encrypt the key material, the token that is used to import the key material, and the time when the token expires.
         *
         * @param request GetParametersForImportRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetParametersForImportResponse
         */
        public GetParametersForImportResponse GetParametersForImportWithOptions(GetParametersForImportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyId))
            {
                query["KeyId"] = request.KeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WrappingAlgorithm))
            {
                query["WrappingAlgorithm"] = request.WrappingAlgorithm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WrappingKeySpec))
            {
                query["WrappingKeySpec"] = request.WrappingKeySpec;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetParametersForImport",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<GetParametersForImportResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetParametersForImportResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @summary Queries the parameters that are used to import key material for a customer master key (CMK).
         *
         * @description The returned parameters can be used to call the [ImportKeyMaterial](https://www.alibabacloud.com/help/en/key-management-service/latest/importkeymaterial) operation.
         * - You can import key material only for CMKs whose Origin parameter is set to EXTERNAL.
         * - The public key and token that are returned by the GetParametersForImport operation must be used together. The public key and token can be used to import key material only for the CMK that is specified when you call the operation.
         * - The public key and token that are returned vary each time you call the GetParametersForImport operation.
         * - You must specify the type of the public key and the encryption algorithm that are used to encrypt key material. The following table lists the types of public keys and the encryption algorithms allowed for each type.   
         * | Public key type | Encryption algorithm | Description |
         * | --------------- | -------------------- | ----------- |
         * | RSA_2048 | RSAES_PKCS1_V1_5 
         * RSAES_OAEP_SHA_1 
         * RSAES_OAEP_SHA_256 | CMKs of all regions and all protection levels are supported. 
         * Dedicated Key Management Service (KMS) does not support RSAES_OAEP_SHA_1. |
         * | EC_SM2 | SM2PKE | CMKs whose ProtectionLevel is set to HSM are supported. The SM2 algorithm is developed and approved by the State Cryptography Administration of China. The SM2 algorithm can be used only to import key material for a CMK whose ProtectionLevel is set to HSM. You can use the SM2 algorithm only when you enable the Managed HSM feature for KMS in the Chinese mainland. For more information, see [Overview of Managed HSM](https://www.alibabacloud.com/help/en/key-management-service/latest/managed-hsm-overview). |
         * For more information, see [Import key material](https://www.alibabacloud.com/help/en/key-management-service/latest/import-key-material). This topic provides an example on how to query the parameters that are used to import key material for a CMK. The ID of the CMK is `1234abcd-12ab-34cd-56ef-12345678****`, the encryption algorithm is `RSAES_PKCS1_V1_5`, and the public key is of the `RSA_2048` type. The parameters that are returned include the ID of the CMK, the public key that is used to encrypt the key material, the token that is used to import the key material, and the time when the token expires.
         *
         * @param request GetParametersForImportRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetParametersForImportResponse
         */
        public async Task<GetParametersForImportResponse> GetParametersForImportWithOptionsAsync(GetParametersForImportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyId))
            {
                query["KeyId"] = request.KeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WrappingAlgorithm))
            {
                query["WrappingAlgorithm"] = request.WrappingAlgorithm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WrappingKeySpec))
            {
                query["WrappingKeySpec"] = request.WrappingKeySpec;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetParametersForImport",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<GetParametersForImportResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetParametersForImportResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @summary Queries the parameters that are used to import key material for a customer master key (CMK).
         *
         * @description The returned parameters can be used to call the [ImportKeyMaterial](https://www.alibabacloud.com/help/en/key-management-service/latest/importkeymaterial) operation.
         * - You can import key material only for CMKs whose Origin parameter is set to EXTERNAL.
         * - The public key and token that are returned by the GetParametersForImport operation must be used together. The public key and token can be used to import key material only for the CMK that is specified when you call the operation.
         * - The public key and token that are returned vary each time you call the GetParametersForImport operation.
         * - You must specify the type of the public key and the encryption algorithm that are used to encrypt key material. The following table lists the types of public keys and the encryption algorithms allowed for each type.   
         * | Public key type | Encryption algorithm | Description |
         * | --------------- | -------------------- | ----------- |
         * | RSA_2048 | RSAES_PKCS1_V1_5 
         * RSAES_OAEP_SHA_1 
         * RSAES_OAEP_SHA_256 | CMKs of all regions and all protection levels are supported. 
         * Dedicated Key Management Service (KMS) does not support RSAES_OAEP_SHA_1. |
         * | EC_SM2 | SM2PKE | CMKs whose ProtectionLevel is set to HSM are supported. The SM2 algorithm is developed and approved by the State Cryptography Administration of China. The SM2 algorithm can be used only to import key material for a CMK whose ProtectionLevel is set to HSM. You can use the SM2 algorithm only when you enable the Managed HSM feature for KMS in the Chinese mainland. For more information, see [Overview of Managed HSM](https://www.alibabacloud.com/help/en/key-management-service/latest/managed-hsm-overview). |
         * For more information, see [Import key material](https://www.alibabacloud.com/help/en/key-management-service/latest/import-key-material). This topic provides an example on how to query the parameters that are used to import key material for a CMK. The ID of the CMK is `1234abcd-12ab-34cd-56ef-12345678****`, the encryption algorithm is `RSAES_PKCS1_V1_5`, and the public key is of the `RSA_2048` type. The parameters that are returned include the ID of the CMK, the public key that is used to encrypt the key material, the token that is used to import the key material, and the time when the token expires.
         *
         * @param request GetParametersForImportRequest
         * @return GetParametersForImportResponse
         */
        public GetParametersForImportResponse GetParametersForImport(GetParametersForImportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetParametersForImportWithOptions(request, runtime);
        }

        /**
         * @summary Queries the parameters that are used to import key material for a customer master key (CMK).
         *
         * @description The returned parameters can be used to call the [ImportKeyMaterial](https://www.alibabacloud.com/help/en/key-management-service/latest/importkeymaterial) operation.
         * - You can import key material only for CMKs whose Origin parameter is set to EXTERNAL.
         * - The public key and token that are returned by the GetParametersForImport operation must be used together. The public key and token can be used to import key material only for the CMK that is specified when you call the operation.
         * - The public key and token that are returned vary each time you call the GetParametersForImport operation.
         * - You must specify the type of the public key and the encryption algorithm that are used to encrypt key material. The following table lists the types of public keys and the encryption algorithms allowed for each type.   
         * | Public key type | Encryption algorithm | Description |
         * | --------------- | -------------------- | ----------- |
         * | RSA_2048 | RSAES_PKCS1_V1_5 
         * RSAES_OAEP_SHA_1 
         * RSAES_OAEP_SHA_256 | CMKs of all regions and all protection levels are supported. 
         * Dedicated Key Management Service (KMS) does not support RSAES_OAEP_SHA_1. |
         * | EC_SM2 | SM2PKE | CMKs whose ProtectionLevel is set to HSM are supported. The SM2 algorithm is developed and approved by the State Cryptography Administration of China. The SM2 algorithm can be used only to import key material for a CMK whose ProtectionLevel is set to HSM. You can use the SM2 algorithm only when you enable the Managed HSM feature for KMS in the Chinese mainland. For more information, see [Overview of Managed HSM](https://www.alibabacloud.com/help/en/key-management-service/latest/managed-hsm-overview). |
         * For more information, see [Import key material](https://www.alibabacloud.com/help/en/key-management-service/latest/import-key-material). This topic provides an example on how to query the parameters that are used to import key material for a CMK. The ID of the CMK is `1234abcd-12ab-34cd-56ef-12345678****`, the encryption algorithm is `RSAES_PKCS1_V1_5`, and the public key is of the `RSA_2048` type. The parameters that are returned include the ID of the CMK, the public key that is used to encrypt the key material, the token that is used to import the key material, and the time when the token expires.
         *
         * @param request GetParametersForImportRequest
         * @return GetParametersForImportResponse
         */
        public async Task<GetParametersForImportResponse> GetParametersForImportAsync(GetParametersForImportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetParametersForImportWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GetPublicKeyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPublicKeyResponse
         */
        public GetPublicKeyResponse GetPublicKeyWithOptions(GetPublicKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyId))
            {
                query["KeyId"] = request.KeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyVersionId))
            {
                query["KeyVersionId"] = request.KeyVersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPublicKey",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<GetPublicKeyResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetPublicKeyResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @param request GetPublicKeyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPublicKeyResponse
         */
        public async Task<GetPublicKeyResponse> GetPublicKeyWithOptionsAsync(GetPublicKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyId))
            {
                query["KeyId"] = request.KeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyVersionId))
            {
                query["KeyVersionId"] = request.KeyVersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPublicKey",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<GetPublicKeyResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetPublicKeyResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @param request GetPublicKeyRequest
         * @return GetPublicKeyResponse
         */
        public GetPublicKeyResponse GetPublicKey(GetPublicKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPublicKeyWithOptions(request, runtime);
        }

        /**
         * @param request GetPublicKeyRequest
         * @return GetPublicKeyResponse
         */
        public async Task<GetPublicKeyResponse> GetPublicKeyAsync(GetPublicKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPublicKeyWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GetRandomPasswordRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetRandomPasswordResponse
         */
        public GetRandomPasswordResponse GetRandomPasswordWithOptions(GetRandomPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeCharacters))
            {
                query["ExcludeCharacters"] = request.ExcludeCharacters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeLowercase))
            {
                query["ExcludeLowercase"] = request.ExcludeLowercase;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeNumbers))
            {
                query["ExcludeNumbers"] = request.ExcludeNumbers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludePunctuation))
            {
                query["ExcludePunctuation"] = request.ExcludePunctuation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeUppercase))
            {
                query["ExcludeUppercase"] = request.ExcludeUppercase;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PasswordLength))
            {
                query["PasswordLength"] = request.PasswordLength;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequireEachIncludedType))
            {
                query["RequireEachIncludedType"] = request.RequireEachIncludedType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRandomPassword",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<GetRandomPasswordResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetRandomPasswordResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @param request GetRandomPasswordRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetRandomPasswordResponse
         */
        public async Task<GetRandomPasswordResponse> GetRandomPasswordWithOptionsAsync(GetRandomPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeCharacters))
            {
                query["ExcludeCharacters"] = request.ExcludeCharacters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeLowercase))
            {
                query["ExcludeLowercase"] = request.ExcludeLowercase;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeNumbers))
            {
                query["ExcludeNumbers"] = request.ExcludeNumbers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludePunctuation))
            {
                query["ExcludePunctuation"] = request.ExcludePunctuation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeUppercase))
            {
                query["ExcludeUppercase"] = request.ExcludeUppercase;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PasswordLength))
            {
                query["PasswordLength"] = request.PasswordLength;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequireEachIncludedType))
            {
                query["RequireEachIncludedType"] = request.RequireEachIncludedType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRandomPassword",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<GetRandomPasswordResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetRandomPasswordResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @param request GetRandomPasswordRequest
         * @return GetRandomPasswordResponse
         */
        public GetRandomPasswordResponse GetRandomPassword(GetRandomPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRandomPasswordWithOptions(request, runtime);
        }

        /**
         * @param request GetRandomPasswordRequest
         * @return GetRandomPasswordResponse
         */
        public async Task<GetRandomPasswordResponse> GetRandomPasswordAsync(GetRandomPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRandomPasswordWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 仅可查询名称为 default 的 Secret Policy，否则提示 Not Found。
         *
         * @param request GetSecretPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSecretPolicyResponse
         */
        public GetSecretPolicyResponse GetSecretPolicyWithOptions(GetSecretPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                query["PolicyName"] = request.PolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretName))
            {
                query["SecretName"] = request.SecretName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSecretPolicy",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<GetSecretPolicyResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetSecretPolicyResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @summary 仅可查询名称为 default 的 Secret Policy，否则提示 Not Found。
         *
         * @param request GetSecretPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSecretPolicyResponse
         */
        public async Task<GetSecretPolicyResponse> GetSecretPolicyWithOptionsAsync(GetSecretPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                query["PolicyName"] = request.PolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretName))
            {
                query["SecretName"] = request.SecretName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSecretPolicy",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<GetSecretPolicyResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetSecretPolicyResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @summary 仅可查询名称为 default 的 Secret Policy，否则提示 Not Found。
         *
         * @param request GetSecretPolicyRequest
         * @return GetSecretPolicyResponse
         */
        public GetSecretPolicyResponse GetSecretPolicy(GetSecretPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSecretPolicyWithOptions(request, runtime);
        }

        /**
         * @summary 仅可查询名称为 default 的 Secret Policy，否则提示 Not Found。
         *
         * @param request GetSecretPolicyRequest
         * @return GetSecretPolicyResponse
         */
        public async Task<GetSecretPolicyResponse> GetSecretPolicyAsync(GetSecretPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSecretPolicyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 调用GetSecretValue接口获取凭据值。
         *
         * @description If you do not specify a version number or stage label, Secrets Manager returns the secret value of the version marked with ACSCurrent.
         * If a customer master key (CMK) is specified to encrypt the secret value, you must also have the `kms:Decrypt` permission on the CMK to call the GetSecretValue operation.
         * In this example, the value of the secret named `secret001` is obtained. The secret value is returned in the `SecretData` parameter. The secret value is `testdata1`.
         *
         * @param request GetSecretValueRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSecretValueResponse
         */
        public GetSecretValueResponse GetSecretValueWithOptions(GetSecretValueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FetchExtendedConfig))
            {
                query["FetchExtendedConfig"] = request.FetchExtendedConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretName))
            {
                query["SecretName"] = request.SecretName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionId))
            {
                query["VersionId"] = request.VersionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionStage))
            {
                query["VersionStage"] = request.VersionStage;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSecretValue",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<GetSecretValueResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetSecretValueResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @summary 调用GetSecretValue接口获取凭据值。
         *
         * @description If you do not specify a version number or stage label, Secrets Manager returns the secret value of the version marked with ACSCurrent.
         * If a customer master key (CMK) is specified to encrypt the secret value, you must also have the `kms:Decrypt` permission on the CMK to call the GetSecretValue operation.
         * In this example, the value of the secret named `secret001` is obtained. The secret value is returned in the `SecretData` parameter. The secret value is `testdata1`.
         *
         * @param request GetSecretValueRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSecretValueResponse
         */
        public async Task<GetSecretValueResponse> GetSecretValueWithOptionsAsync(GetSecretValueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FetchExtendedConfig))
            {
                query["FetchExtendedConfig"] = request.FetchExtendedConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretName))
            {
                query["SecretName"] = request.SecretName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionId))
            {
                query["VersionId"] = request.VersionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionStage))
            {
                query["VersionStage"] = request.VersionStage;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSecretValue",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<GetSecretValueResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetSecretValueResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @summary 调用GetSecretValue接口获取凭据值。
         *
         * @description If you do not specify a version number or stage label, Secrets Manager returns the secret value of the version marked with ACSCurrent.
         * If a customer master key (CMK) is specified to encrypt the secret value, you must also have the `kms:Decrypt` permission on the CMK to call the GetSecretValue operation.
         * In this example, the value of the secret named `secret001` is obtained. The secret value is returned in the `SecretData` parameter. The secret value is `testdata1`.
         *
         * @param request GetSecretValueRequest
         * @return GetSecretValueResponse
         */
        public GetSecretValueResponse GetSecretValue(GetSecretValueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSecretValueWithOptions(request, runtime);
        }

        /**
         * @summary 调用GetSecretValue接口获取凭据值。
         *
         * @description If you do not specify a version number or stage label, Secrets Manager returns the secret value of the version marked with ACSCurrent.
         * If a customer master key (CMK) is specified to encrypt the secret value, you must also have the `kms:Decrypt` permission on the CMK to call the GetSecretValue operation.
         * In this example, the value of the secret named `secret001` is obtained. The secret value is returned in the `SecretData` parameter. The secret value is `testdata1`.
         *
         * @param request GetSecretValueRequest
         * @return GetSecretValueResponse
         */
        public async Task<GetSecretValueResponse> GetSecretValueAsync(GetSecretValueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSecretValueWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Call the ImportKeyMaterial operation to import the key material.
         *
         * @description Call [CreateKey](https://help.aliyun.com/document_detail/28947.html) when creating a CMK, you can select its key material source as external. **Origin** set to **EXTERNAL**. This API is used to import the key material into the CMK.
         * *   To view the CMK **Origin**, see [DescribeKey](https://help.aliyun.com/document_detail/28952.html).
         * *   Before importing key material, you need to call the [GetParametersForImport](https://help.aliyun.com/document_detail/68621.html) obtain the parameters required to import the key material, including the public key and import token.
         * > *   The key type of the pair is **Aliyun_AES_256** the key material must be 256 bits. The key type must be **Aliyun_SM4** the CMK and key material must be 128 bits.
         * > *   You can set the expiration time for the key material, or you can set it to never expire.
         * > *   You can reimport the key material and reset the expiration time for the specified CMK at any time, but the same key material must be imported.
         * > *   After the imported key material expires or is deleted, the specified CMK is unavailable until the same key material are imported again.
         * > *   A Key material can be imported to multiple cmks, but any Data or Data Key encrypted by one CMK cannot be decrypted by another CMK.
         *
         * @param request ImportKeyMaterialRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ImportKeyMaterialResponse
         */
        public ImportKeyMaterialResponse ImportKeyMaterialWithOptions(ImportKeyMaterialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptedKeyMaterial))
            {
                query["EncryptedKeyMaterial"] = request.EncryptedKeyMaterial;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImportToken))
            {
                query["ImportToken"] = request.ImportToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyId))
            {
                query["KeyId"] = request.KeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyMaterialExpireUnix))
            {
                query["KeyMaterialExpireUnix"] = request.KeyMaterialExpireUnix;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImportKeyMaterial",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<ImportKeyMaterialResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ImportKeyMaterialResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @summary Call the ImportKeyMaterial operation to import the key material.
         *
         * @description Call [CreateKey](https://help.aliyun.com/document_detail/28947.html) when creating a CMK, you can select its key material source as external. **Origin** set to **EXTERNAL**. This API is used to import the key material into the CMK.
         * *   To view the CMK **Origin**, see [DescribeKey](https://help.aliyun.com/document_detail/28952.html).
         * *   Before importing key material, you need to call the [GetParametersForImport](https://help.aliyun.com/document_detail/68621.html) obtain the parameters required to import the key material, including the public key and import token.
         * > *   The key type of the pair is **Aliyun_AES_256** the key material must be 256 bits. The key type must be **Aliyun_SM4** the CMK and key material must be 128 bits.
         * > *   You can set the expiration time for the key material, or you can set it to never expire.
         * > *   You can reimport the key material and reset the expiration time for the specified CMK at any time, but the same key material must be imported.
         * > *   After the imported key material expires or is deleted, the specified CMK is unavailable until the same key material are imported again.
         * > *   A Key material can be imported to multiple cmks, but any Data or Data Key encrypted by one CMK cannot be decrypted by another CMK.
         *
         * @param request ImportKeyMaterialRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ImportKeyMaterialResponse
         */
        public async Task<ImportKeyMaterialResponse> ImportKeyMaterialWithOptionsAsync(ImportKeyMaterialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptedKeyMaterial))
            {
                query["EncryptedKeyMaterial"] = request.EncryptedKeyMaterial;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImportToken))
            {
                query["ImportToken"] = request.ImportToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyId))
            {
                query["KeyId"] = request.KeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyMaterialExpireUnix))
            {
                query["KeyMaterialExpireUnix"] = request.KeyMaterialExpireUnix;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImportKeyMaterial",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<ImportKeyMaterialResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ImportKeyMaterialResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @summary Call the ImportKeyMaterial operation to import the key material.
         *
         * @description Call [CreateKey](https://help.aliyun.com/document_detail/28947.html) when creating a CMK, you can select its key material source as external. **Origin** set to **EXTERNAL**. This API is used to import the key material into the CMK.
         * *   To view the CMK **Origin**, see [DescribeKey](https://help.aliyun.com/document_detail/28952.html).
         * *   Before importing key material, you need to call the [GetParametersForImport](https://help.aliyun.com/document_detail/68621.html) obtain the parameters required to import the key material, including the public key and import token.
         * > *   The key type of the pair is **Aliyun_AES_256** the key material must be 256 bits. The key type must be **Aliyun_SM4** the CMK and key material must be 128 bits.
         * > *   You can set the expiration time for the key material, or you can set it to never expire.
         * > *   You can reimport the key material and reset the expiration time for the specified CMK at any time, but the same key material must be imported.
         * > *   After the imported key material expires or is deleted, the specified CMK is unavailable until the same key material are imported again.
         * > *   A Key material can be imported to multiple cmks, but any Data or Data Key encrypted by one CMK cannot be decrypted by another CMK.
         *
         * @param request ImportKeyMaterialRequest
         * @return ImportKeyMaterialResponse
         */
        public ImportKeyMaterialResponse ImportKeyMaterial(ImportKeyMaterialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ImportKeyMaterialWithOptions(request, runtime);
        }

        /**
         * @summary Call the ImportKeyMaterial operation to import the key material.
         *
         * @description Call [CreateKey](https://help.aliyun.com/document_detail/28947.html) when creating a CMK, you can select its key material source as external. **Origin** set to **EXTERNAL**. This API is used to import the key material into the CMK.
         * *   To view the CMK **Origin**, see [DescribeKey](https://help.aliyun.com/document_detail/28952.html).
         * *   Before importing key material, you need to call the [GetParametersForImport](https://help.aliyun.com/document_detail/68621.html) obtain the parameters required to import the key material, including the public key and import token.
         * > *   The key type of the pair is **Aliyun_AES_256** the key material must be 256 bits. The key type must be **Aliyun_SM4** the CMK and key material must be 128 bits.
         * > *   You can set the expiration time for the key material, or you can set it to never expire.
         * > *   You can reimport the key material and reset the expiration time for the specified CMK at any time, but the same key material must be imported.
         * > *   After the imported key material expires or is deleted, the specified CMK is unavailable until the same key material are imported again.
         * > *   A Key material can be imported to multiple cmks, but any Data or Data Key encrypted by one CMK cannot be decrypted by another CMK.
         *
         * @param request ImportKeyMaterialRequest
         * @return ImportKeyMaterialResponse
         */
        public async Task<ImportKeyMaterialResponse> ImportKeyMaterialAsync(ImportKeyMaterialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ImportKeyMaterialWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries all aliases in the current region for the current account.
         *
         * @param request ListAliasesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAliasesResponse
         */
        public ListAliasesResponse ListAliasesWithOptions(ListAliasesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAliases",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<ListAliasesResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListAliasesResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @summary Queries all aliases in the current region for the current account.
         *
         * @param request ListAliasesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAliasesResponse
         */
        public async Task<ListAliasesResponse> ListAliasesWithOptionsAsync(ListAliasesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAliases",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<ListAliasesResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListAliasesResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @summary Queries all aliases in the current region for the current account.
         *
         * @param request ListAliasesRequest
         * @return ListAliasesResponse
         */
        public ListAliasesResponse ListAliases(ListAliasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAliasesWithOptions(request, runtime);
        }

        /**
         * @summary Queries all aliases in the current region for the current account.
         *
         * @param request ListAliasesRequest
         * @return ListAliasesResponse
         */
        public async Task<ListAliasesResponse> ListAliasesAsync(ListAliasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAliasesWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ListAliasesByKeyIdRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAliasesByKeyIdResponse
         */
        public ListAliasesByKeyIdResponse ListAliasesByKeyIdWithOptions(ListAliasesByKeyIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyId))
            {
                query["KeyId"] = request.KeyId;
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
                Action = "ListAliasesByKeyId",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<ListAliasesByKeyIdResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListAliasesByKeyIdResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @param request ListAliasesByKeyIdRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAliasesByKeyIdResponse
         */
        public async Task<ListAliasesByKeyIdResponse> ListAliasesByKeyIdWithOptionsAsync(ListAliasesByKeyIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyId))
            {
                query["KeyId"] = request.KeyId;
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
                Action = "ListAliasesByKeyId",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<ListAliasesByKeyIdResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListAliasesByKeyIdResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @param request ListAliasesByKeyIdRequest
         * @return ListAliasesByKeyIdResponse
         */
        public ListAliasesByKeyIdResponse ListAliasesByKeyId(ListAliasesByKeyIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAliasesByKeyIdWithOptions(request, runtime);
        }

        /**
         * @param request ListAliasesByKeyIdRequest
         * @return ListAliasesByKeyIdResponse
         */
        public async Task<ListAliasesByKeyIdResponse> ListAliasesByKeyIdAsync(ListAliasesByKeyIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAliasesByKeyIdWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries a list of application access points (AAPs).
         *
         * @param request ListApplicationAccessPointsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListApplicationAccessPointsResponse
         */
        public ListApplicationAccessPointsResponse ListApplicationAccessPointsWithOptions(ListApplicationAccessPointsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListApplicationAccessPoints",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<ListApplicationAccessPointsResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListApplicationAccessPointsResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @summary Queries a list of application access points (AAPs).
         *
         * @param request ListApplicationAccessPointsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListApplicationAccessPointsResponse
         */
        public async Task<ListApplicationAccessPointsResponse> ListApplicationAccessPointsWithOptionsAsync(ListApplicationAccessPointsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListApplicationAccessPoints",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<ListApplicationAccessPointsResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListApplicationAccessPointsResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @summary Queries a list of application access points (AAPs).
         *
         * @param request ListApplicationAccessPointsRequest
         * @return ListApplicationAccessPointsResponse
         */
        public ListApplicationAccessPointsResponse ListApplicationAccessPoints(ListApplicationAccessPointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListApplicationAccessPointsWithOptions(request, runtime);
        }

        /**
         * @summary Queries a list of application access points (AAPs).
         *
         * @param request ListApplicationAccessPointsRequest
         * @return ListApplicationAccessPointsResponse
         */
        public async Task<ListApplicationAccessPointsResponse> ListApplicationAccessPointsAsync(ListApplicationAccessPointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListApplicationAccessPointsWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ListClientKeysRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListClientKeysResponse
         */
        public ListClientKeysResponse ListClientKeysWithOptions(ListClientKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListClientKeys",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<ListClientKeysResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListClientKeysResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @param request ListClientKeysRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListClientKeysResponse
         */
        public async Task<ListClientKeysResponse> ListClientKeysWithOptionsAsync(ListClientKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListClientKeys",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<ListClientKeysResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListClientKeysResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @param request ListClientKeysRequest
         * @return ListClientKeysResponse
         */
        public ListClientKeysResponse ListClientKeys(ListClientKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListClientKeysWithOptions(request, runtime);
        }

        /**
         * @param request ListClientKeysRequest
         * @return ListClientKeysResponse
         */
        public async Task<ListClientKeysResponse> ListClientKeysAsync(ListClientKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListClientKeysWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries all versions of a specified CMK.
         *
         * @param request ListKeyVersionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListKeyVersionsResponse
         */
        public ListKeyVersionsResponse ListKeyVersionsWithOptions(ListKeyVersionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyId))
            {
                query["KeyId"] = request.KeyId;
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
                Action = "ListKeyVersions",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<ListKeyVersionsResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListKeyVersionsResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @summary Queries all versions of a specified CMK.
         *
         * @param request ListKeyVersionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListKeyVersionsResponse
         */
        public async Task<ListKeyVersionsResponse> ListKeyVersionsWithOptionsAsync(ListKeyVersionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyId))
            {
                query["KeyId"] = request.KeyId;
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
                Action = "ListKeyVersions",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<ListKeyVersionsResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListKeyVersionsResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @summary Queries all versions of a specified CMK.
         *
         * @param request ListKeyVersionsRequest
         * @return ListKeyVersionsResponse
         */
        public ListKeyVersionsResponse ListKeyVersions(ListKeyVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListKeyVersionsWithOptions(request, runtime);
        }

        /**
         * @summary Queries all versions of a specified CMK.
         *
         * @param request ListKeyVersionsRequest
         * @return ListKeyVersionsResponse
         */
        public async Task<ListKeyVersionsResponse> ListKeyVersionsAsync(ListKeyVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListKeyVersionsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries all customer master keys (CMKs) of the current Alibaba Cloud account in the current region.
         *
         * @param request ListKeysRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListKeysResponse
         */
        public ListKeysResponse ListKeysWithOptions(ListKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filters))
            {
                query["Filters"] = request.Filters;
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
                Action = "ListKeys",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<ListKeysResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListKeysResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @summary Queries all customer master keys (CMKs) of the current Alibaba Cloud account in the current region.
         *
         * @param request ListKeysRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListKeysResponse
         */
        public async Task<ListKeysResponse> ListKeysWithOptionsAsync(ListKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filters))
            {
                query["Filters"] = request.Filters;
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
                Action = "ListKeys",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<ListKeysResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListKeysResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @summary Queries all customer master keys (CMKs) of the current Alibaba Cloud account in the current region.
         *
         * @param request ListKeysRequest
         * @return ListKeysResponse
         */
        public ListKeysResponse ListKeys(ListKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListKeysWithOptions(request, runtime);
        }

        /**
         * @summary Queries all customer master keys (CMKs) of the current Alibaba Cloud account in the current region.
         *
         * @param request ListKeysRequest
         * @return ListKeysResponse
         */
        public async Task<ListKeysResponse> ListKeysAsync(ListKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListKeysWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries a list of Key Management Service (KMS) instances.
         *
         * @param request ListKmsInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListKmsInstancesResponse
         */
        public ListKmsInstancesResponse ListKmsInstancesWithOptions(ListKmsInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListKmsInstances",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<ListKmsInstancesResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListKmsInstancesResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @summary Queries a list of Key Management Service (KMS) instances.
         *
         * @param request ListKmsInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListKmsInstancesResponse
         */
        public async Task<ListKmsInstancesResponse> ListKmsInstancesWithOptionsAsync(ListKmsInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListKmsInstances",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<ListKmsInstancesResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListKmsInstancesResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @summary Queries a list of Key Management Service (KMS) instances.
         *
         * @param request ListKmsInstancesRequest
         * @return ListKmsInstancesResponse
         */
        public ListKmsInstancesResponse ListKmsInstances(ListKmsInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListKmsInstancesWithOptions(request, runtime);
        }

        /**
         * @summary Queries a list of Key Management Service (KMS) instances.
         *
         * @param request ListKmsInstancesRequest
         * @return ListKmsInstancesResponse
         */
        public async Task<ListKmsInstancesResponse> ListKmsInstancesAsync(ListKmsInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListKmsInstancesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries a list of access control rules.
         *
         * @param request ListNetworkRulesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListNetworkRulesResponse
         */
        public ListNetworkRulesResponse ListNetworkRulesWithOptions(ListNetworkRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListNetworkRules",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<ListNetworkRulesResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListNetworkRulesResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @summary Queries a list of access control rules.
         *
         * @param request ListNetworkRulesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListNetworkRulesResponse
         */
        public async Task<ListNetworkRulesResponse> ListNetworkRulesWithOptionsAsync(ListNetworkRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListNetworkRules",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<ListNetworkRulesResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListNetworkRulesResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @summary Queries a list of access control rules.
         *
         * @param request ListNetworkRulesRequest
         * @return ListNetworkRulesResponse
         */
        public ListNetworkRulesResponse ListNetworkRules(ListNetworkRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListNetworkRulesWithOptions(request, runtime);
        }

        /**
         * @summary Queries a list of access control rules.
         *
         * @param request ListNetworkRulesRequest
         * @return ListNetworkRulesResponse
         */
        public async Task<ListNetworkRulesResponse> ListNetworkRulesAsync(ListNetworkRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListNetworkRulesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries a list of permission policies.
         *
         * @param request ListPoliciesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPoliciesResponse
         */
        public ListPoliciesResponse ListPoliciesWithOptions(ListPoliciesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPolicies",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<ListPoliciesResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListPoliciesResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @summary Queries a list of permission policies.
         *
         * @param request ListPoliciesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPoliciesResponse
         */
        public async Task<ListPoliciesResponse> ListPoliciesWithOptionsAsync(ListPoliciesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPolicies",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<ListPoliciesResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListPoliciesResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @summary Queries a list of permission policies.
         *
         * @param request ListPoliciesRequest
         * @return ListPoliciesResponse
         */
        public ListPoliciesResponse ListPolicies(ListPoliciesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPoliciesWithOptions(request, runtime);
        }

        /**
         * @summary Queries a list of permission policies.
         *
         * @param request ListPoliciesRequest
         * @return ListPoliciesResponse
         */
        public async Task<ListPoliciesResponse> ListPoliciesAsync(ListPoliciesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPoliciesWithOptionsAsync(request, runtime);
        }

        /**
         * @description Request format: KeyId="string"
         *
         * @param request ListResourceTagsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListResourceTagsResponse
         */
        public ListResourceTagsResponse ListResourceTagsWithOptions(ListResourceTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyId))
            {
                query["KeyId"] = request.KeyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListResourceTags",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<ListResourceTagsResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListResourceTagsResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @description Request format: KeyId="string"
         *
         * @param request ListResourceTagsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListResourceTagsResponse
         */
        public async Task<ListResourceTagsResponse> ListResourceTagsWithOptionsAsync(ListResourceTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyId))
            {
                query["KeyId"] = request.KeyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListResourceTags",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<ListResourceTagsResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListResourceTagsResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @description Request format: KeyId="string"
         *
         * @param request ListResourceTagsRequest
         * @return ListResourceTagsResponse
         */
        public ListResourceTagsResponse ListResourceTags(ListResourceTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListResourceTagsWithOptions(request, runtime);
        }

        /**
         * @description Request format: KeyId="string"
         *
         * @param request ListResourceTagsRequest
         * @return ListResourceTagsResponse
         */
        public async Task<ListResourceTagsResponse> ListResourceTagsAsync(ListResourceTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListResourceTagsWithOptionsAsync(request, runtime);
        }

        /**
         * @description The secret value is not included in the returned version information. By default, deprecated secret versions are not returned.
         *
         * @param request ListSecretVersionIdsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSecretVersionIdsResponse
         */
        public ListSecretVersionIdsResponse ListSecretVersionIdsWithOptions(ListSecretVersionIdsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeDeprecated))
            {
                query["IncludeDeprecated"] = request.IncludeDeprecated;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretName))
            {
                query["SecretName"] = request.SecretName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSecretVersionIds",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<ListSecretVersionIdsResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListSecretVersionIdsResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @description The secret value is not included in the returned version information. By default, deprecated secret versions are not returned.
         *
         * @param request ListSecretVersionIdsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSecretVersionIdsResponse
         */
        public async Task<ListSecretVersionIdsResponse> ListSecretVersionIdsWithOptionsAsync(ListSecretVersionIdsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeDeprecated))
            {
                query["IncludeDeprecated"] = request.IncludeDeprecated;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretName))
            {
                query["SecretName"] = request.SecretName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSecretVersionIds",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<ListSecretVersionIdsResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListSecretVersionIdsResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @description The secret value is not included in the returned version information. By default, deprecated secret versions are not returned.
         *
         * @param request ListSecretVersionIdsRequest
         * @return ListSecretVersionIdsResponse
         */
        public ListSecretVersionIdsResponse ListSecretVersionIds(ListSecretVersionIdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSecretVersionIdsWithOptions(request, runtime);
        }

        /**
         * @description The secret value is not included in the returned version information. By default, deprecated secret versions are not returned.
         *
         * @param request ListSecretVersionIdsRequest
         * @return ListSecretVersionIdsResponse
         */
        public async Task<ListSecretVersionIdsResponse> ListSecretVersionIdsAsync(ListSecretVersionIdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSecretVersionIdsWithOptionsAsync(request, runtime);
        }

        /**
         * @description Specifies whether to return the resource tags of the secret. Valid values:
         * *   true: returns the resource tags.
         * *   false: does not return the resource tags. This is the default value.
         *
         * @param request ListSecretsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSecretsResponse
         */
        public ListSecretsResponse ListSecretsWithOptions(ListSecretsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FetchTags))
            {
                query["FetchTags"] = request.FetchTags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filters))
            {
                query["Filters"] = request.Filters;
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
                Action = "ListSecrets",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<ListSecretsResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListSecretsResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @description Specifies whether to return the resource tags of the secret. Valid values:
         * *   true: returns the resource tags.
         * *   false: does not return the resource tags. This is the default value.
         *
         * @param request ListSecretsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSecretsResponse
         */
        public async Task<ListSecretsResponse> ListSecretsWithOptionsAsync(ListSecretsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FetchTags))
            {
                query["FetchTags"] = request.FetchTags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filters))
            {
                query["Filters"] = request.Filters;
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
                Action = "ListSecrets",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<ListSecretsResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListSecretsResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @description Specifies whether to return the resource tags of the secret. Valid values:
         * *   true: returns the resource tags.
         * *   false: does not return the resource tags. This is the default value.
         *
         * @param request ListSecretsRequest
         * @return ListSecretsResponse
         */
        public ListSecretsResponse ListSecrets(ListSecretsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSecretsWithOptions(request, runtime);
        }

        /**
         * @description Specifies whether to return the resource tags of the secret. Valid values:
         * *   true: returns the resource tags.
         * *   false: does not return the resource tags. This is the default value.
         *
         * @param request ListSecretsRequest
         * @return ListSecretsResponse
         */
        public async Task<ListSecretsResponse> ListSecretsAsync(ListSecretsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSecretsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the tags of a key or a secret.
         *
         * @param request ListTagResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTagResourcesResponse
         */
        public ListTagResourcesResponse ListTagResourcesWithOptions(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Version = "2016-01-20",
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
                return TeaModel.ToObject<ListTagResourcesResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListTagResourcesResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @summary Queries the tags of a key or a secret.
         *
         * @param request ListTagResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTagResourcesResponse
         */
        public async Task<ListTagResourcesResponse> ListTagResourcesWithOptionsAsync(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Version = "2016-01-20",
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
                return TeaModel.ToObject<ListTagResourcesResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListTagResourcesResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @summary Queries the tags of a key or a secret.
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
         * @summary Queries the tags of a key or a secret.
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
         * @summary Activates Key Management Service (KMS) under your Alibaba cloud account.
         *
         * @description When you call this operation, note that:
         * - KMS is a paid service. For more information about the billing method, see [Billing description](https://www.alibabacloud.com/help/en/key-management-service/latest/billing-billing).
         * - An Alibaba Cloud account can activate KMS only once.
         * - Make sure that your Alibaba Cloud account has passed real-name authentication.
         *
         * @param request OpenKmsServiceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return OpenKmsServiceResponse
         */
        public OpenKmsServiceResponse OpenKmsServiceWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OpenKmsService",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<OpenKmsServiceResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<OpenKmsServiceResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @summary Activates Key Management Service (KMS) under your Alibaba cloud account.
         *
         * @description When you call this operation, note that:
         * - KMS is a paid service. For more information about the billing method, see [Billing description](https://www.alibabacloud.com/help/en/key-management-service/latest/billing-billing).
         * - An Alibaba Cloud account can activate KMS only once.
         * - Make sure that your Alibaba Cloud account has passed real-name authentication.
         *
         * @param request OpenKmsServiceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return OpenKmsServiceResponse
         */
        public async Task<OpenKmsServiceResponse> OpenKmsServiceWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OpenKmsService",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<OpenKmsServiceResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<OpenKmsServiceResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @summary Activates Key Management Service (KMS) under your Alibaba cloud account.
         *
         * @description When you call this operation, note that:
         * - KMS is a paid service. For more information about the billing method, see [Billing description](https://www.alibabacloud.com/help/en/key-management-service/latest/billing-billing).
         * - An Alibaba Cloud account can activate KMS only once.
         * - Make sure that your Alibaba Cloud account has passed real-name authentication.
         *
         * @return OpenKmsServiceResponse
         */
        public OpenKmsServiceResponse OpenKmsService()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OpenKmsServiceWithOptions(runtime);
        }

        /**
         * @summary Activates Key Management Service (KMS) under your Alibaba cloud account.
         *
         * @description When you call this operation, note that:
         * - KMS is a paid service. For more information about the billing method, see [Billing description](https://www.alibabacloud.com/help/en/key-management-service/latest/billing-billing).
         * - An Alibaba Cloud account can activate KMS only once.
         * - Make sure that your Alibaba Cloud account has passed real-name authentication.
         *
         * @return OpenKmsServiceResponse
         */
        public async Task<OpenKmsServiceResponse> OpenKmsServiceAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OpenKmsServiceWithOptionsAsync(runtime);
        }

        /**
         * @description This operation is used to store the secret values of new versions. It cannot be used to modify the secret value of an existing version.
         * By default, the newly stored secret value is marked with ACSCurrent, and the mark for the previous version of the secret value is changed from ACSCurrent to ACSPrevious. If you specify the VersionStage parameter, the newly stored secret value is marked with the stage label that you specify.
         * You must specify a version number when you call the operation. Secrets Manager performs operations based on the following rules:
         * *   If the specified version number does not exist in the secret, Secrets Manager creates the version and stores the secret value.
         * *   If the specified version number already exists in the secret and the secret value of the existing version is the same as the secret value that you specify, Secrets Manager ignores the request and returns a success message. The request is idempotent.
         * *   If the specified version number already exists in the secret but the secret value of the existing version is different from the secret value that you specify, Secrets Manager rejects the request and returns a failure message.
         * Limits: This operation is available only for standard secrets.
         * In this example, the secret value of a new version is stored into the `secret001` secret. The `VersionId` parameter is set to `00000000000000000000000000000000203` as the new version, and the `SecretData` parameter is set to `importantdata`.
         *
         * @param request PutSecretValueRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return PutSecretValueResponse
         */
        public PutSecretValueResponse PutSecretValueWithOptions(PutSecretValueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretData))
            {
                query["SecretData"] = request.SecretData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretDataType))
            {
                query["SecretDataType"] = request.SecretDataType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretName))
            {
                query["SecretName"] = request.SecretName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionId))
            {
                query["VersionId"] = request.VersionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionStages))
            {
                query["VersionStages"] = request.VersionStages;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutSecretValue",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<PutSecretValueResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<PutSecretValueResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @description This operation is used to store the secret values of new versions. It cannot be used to modify the secret value of an existing version.
         * By default, the newly stored secret value is marked with ACSCurrent, and the mark for the previous version of the secret value is changed from ACSCurrent to ACSPrevious. If you specify the VersionStage parameter, the newly stored secret value is marked with the stage label that you specify.
         * You must specify a version number when you call the operation. Secrets Manager performs operations based on the following rules:
         * *   If the specified version number does not exist in the secret, Secrets Manager creates the version and stores the secret value.
         * *   If the specified version number already exists in the secret and the secret value of the existing version is the same as the secret value that you specify, Secrets Manager ignores the request and returns a success message. The request is idempotent.
         * *   If the specified version number already exists in the secret but the secret value of the existing version is different from the secret value that you specify, Secrets Manager rejects the request and returns a failure message.
         * Limits: This operation is available only for standard secrets.
         * In this example, the secret value of a new version is stored into the `secret001` secret. The `VersionId` parameter is set to `00000000000000000000000000000000203` as the new version, and the `SecretData` parameter is set to `importantdata`.
         *
         * @param request PutSecretValueRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return PutSecretValueResponse
         */
        public async Task<PutSecretValueResponse> PutSecretValueWithOptionsAsync(PutSecretValueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretData))
            {
                query["SecretData"] = request.SecretData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretDataType))
            {
                query["SecretDataType"] = request.SecretDataType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretName))
            {
                query["SecretName"] = request.SecretName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionId))
            {
                query["VersionId"] = request.VersionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionStages))
            {
                query["VersionStages"] = request.VersionStages;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutSecretValue",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<PutSecretValueResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<PutSecretValueResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @description This operation is used to store the secret values of new versions. It cannot be used to modify the secret value of an existing version.
         * By default, the newly stored secret value is marked with ACSCurrent, and the mark for the previous version of the secret value is changed from ACSCurrent to ACSPrevious. If you specify the VersionStage parameter, the newly stored secret value is marked with the stage label that you specify.
         * You must specify a version number when you call the operation. Secrets Manager performs operations based on the following rules:
         * *   If the specified version number does not exist in the secret, Secrets Manager creates the version and stores the secret value.
         * *   If the specified version number already exists in the secret and the secret value of the existing version is the same as the secret value that you specify, Secrets Manager ignores the request and returns a success message. The request is idempotent.
         * *   If the specified version number already exists in the secret but the secret value of the existing version is different from the secret value that you specify, Secrets Manager rejects the request and returns a failure message.
         * Limits: This operation is available only for standard secrets.
         * In this example, the secret value of a new version is stored into the `secret001` secret. The `VersionId` parameter is set to `00000000000000000000000000000000203` as the new version, and the `SecretData` parameter is set to `importantdata`.
         *
         * @param request PutSecretValueRequest
         * @return PutSecretValueResponse
         */
        public PutSecretValueResponse PutSecretValue(PutSecretValueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PutSecretValueWithOptions(request, runtime);
        }

        /**
         * @description This operation is used to store the secret values of new versions. It cannot be used to modify the secret value of an existing version.
         * By default, the newly stored secret value is marked with ACSCurrent, and the mark for the previous version of the secret value is changed from ACSCurrent to ACSPrevious. If you specify the VersionStage parameter, the newly stored secret value is marked with the stage label that you specify.
         * You must specify a version number when you call the operation. Secrets Manager performs operations based on the following rules:
         * *   If the specified version number does not exist in the secret, Secrets Manager creates the version and stores the secret value.
         * *   If the specified version number already exists in the secret and the secret value of the existing version is the same as the secret value that you specify, Secrets Manager ignores the request and returns a success message. The request is idempotent.
         * *   If the specified version number already exists in the secret but the secret value of the existing version is different from the secret value that you specify, Secrets Manager rejects the request and returns a failure message.
         * Limits: This operation is available only for standard secrets.
         * In this example, the secret value of a new version is stored into the `secret001` secret. The `VersionId` parameter is set to `00000000000000000000000000000000203` as the new version, and the `SecretData` parameter is set to `importantdata`.
         *
         * @param request PutSecretValueRequest
         * @return PutSecretValueResponse
         */
        public async Task<PutSecretValueResponse> PutSecretValueAsync(PutSecretValueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PutSecretValueWithOptionsAsync(request, runtime);
        }

        /**
         * @description You can call this operation in the following scenarios:
         * *   After the CMK that was used to encrypt your data is rotated, you can call this operation to use the latest CMK version to re-encrypt the data. For more information about automatic key rotation, see [Configure automatic key rotation](https://help.aliyun.com/document_detail/134270.html).
         * *   The CMK that was used to encrypt your data remains unchanged, but EncryptionContext is changed. In this scenario, you can call this operation to re-encrypt the data.
         * *   You can call this operation to use a CMK in KMS to re-encrypt data or a data key that was previously encrypted by a different CMK.
         * To use the ReEncrypt operation, you must have two permissions:
         * *   kms:ReEncryptFrom on the source CMK
         * *   kms:ReEncryptTo on the destination CMK
         * *   For simplicity, you can specify kms:ReEncrypt\\* to allow both of the preceding permissions.
         *
         * @param tmpReq ReEncryptRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ReEncryptResponse
         */
        public ReEncryptResponse ReEncryptWithOptions(ReEncryptRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ReEncryptShrinkRequest request = new ReEncryptShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DestinationEncryptionContext))
            {
                request.DestinationEncryptionContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DestinationEncryptionContext, "DestinationEncryptionContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceEncryptionContext))
            {
                request.SourceEncryptionContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceEncryptionContext, "SourceEncryptionContext", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CiphertextBlob))
            {
                query["CiphertextBlob"] = request.CiphertextBlob;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationEncryptionContextShrink))
            {
                query["DestinationEncryptionContext"] = request.DestinationEncryptionContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationKeyId))
            {
                query["DestinationKeyId"] = request.DestinationKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEncryptionAlgorithm))
            {
                query["SourceEncryptionAlgorithm"] = request.SourceEncryptionAlgorithm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEncryptionContextShrink))
            {
                query["SourceEncryptionContext"] = request.SourceEncryptionContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceKeyId))
            {
                query["SourceKeyId"] = request.SourceKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceKeyVersionId))
            {
                query["SourceKeyVersionId"] = request.SourceKeyVersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReEncrypt",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<ReEncryptResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ReEncryptResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @description You can call this operation in the following scenarios:
         * *   After the CMK that was used to encrypt your data is rotated, you can call this operation to use the latest CMK version to re-encrypt the data. For more information about automatic key rotation, see [Configure automatic key rotation](https://help.aliyun.com/document_detail/134270.html).
         * *   The CMK that was used to encrypt your data remains unchanged, but EncryptionContext is changed. In this scenario, you can call this operation to re-encrypt the data.
         * *   You can call this operation to use a CMK in KMS to re-encrypt data or a data key that was previously encrypted by a different CMK.
         * To use the ReEncrypt operation, you must have two permissions:
         * *   kms:ReEncryptFrom on the source CMK
         * *   kms:ReEncryptTo on the destination CMK
         * *   For simplicity, you can specify kms:ReEncrypt\\* to allow both of the preceding permissions.
         *
         * @param tmpReq ReEncryptRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ReEncryptResponse
         */
        public async Task<ReEncryptResponse> ReEncryptWithOptionsAsync(ReEncryptRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ReEncryptShrinkRequest request = new ReEncryptShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DestinationEncryptionContext))
            {
                request.DestinationEncryptionContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DestinationEncryptionContext, "DestinationEncryptionContext", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceEncryptionContext))
            {
                request.SourceEncryptionContextShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceEncryptionContext, "SourceEncryptionContext", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CiphertextBlob))
            {
                query["CiphertextBlob"] = request.CiphertextBlob;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationEncryptionContextShrink))
            {
                query["DestinationEncryptionContext"] = request.DestinationEncryptionContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationKeyId))
            {
                query["DestinationKeyId"] = request.DestinationKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEncryptionAlgorithm))
            {
                query["SourceEncryptionAlgorithm"] = request.SourceEncryptionAlgorithm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEncryptionContextShrink))
            {
                query["SourceEncryptionContext"] = request.SourceEncryptionContextShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceKeyId))
            {
                query["SourceKeyId"] = request.SourceKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceKeyVersionId))
            {
                query["SourceKeyVersionId"] = request.SourceKeyVersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReEncrypt",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<ReEncryptResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ReEncryptResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @description You can call this operation in the following scenarios:
         * *   After the CMK that was used to encrypt your data is rotated, you can call this operation to use the latest CMK version to re-encrypt the data. For more information about automatic key rotation, see [Configure automatic key rotation](https://help.aliyun.com/document_detail/134270.html).
         * *   The CMK that was used to encrypt your data remains unchanged, but EncryptionContext is changed. In this scenario, you can call this operation to re-encrypt the data.
         * *   You can call this operation to use a CMK in KMS to re-encrypt data or a data key that was previously encrypted by a different CMK.
         * To use the ReEncrypt operation, you must have two permissions:
         * *   kms:ReEncryptFrom on the source CMK
         * *   kms:ReEncryptTo on the destination CMK
         * *   For simplicity, you can specify kms:ReEncrypt\\* to allow both of the preceding permissions.
         *
         * @param request ReEncryptRequest
         * @return ReEncryptResponse
         */
        public ReEncryptResponse ReEncrypt(ReEncryptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReEncryptWithOptions(request, runtime);
        }

        /**
         * @description You can call this operation in the following scenarios:
         * *   After the CMK that was used to encrypt your data is rotated, you can call this operation to use the latest CMK version to re-encrypt the data. For more information about automatic key rotation, see [Configure automatic key rotation](https://help.aliyun.com/document_detail/134270.html).
         * *   The CMK that was used to encrypt your data remains unchanged, but EncryptionContext is changed. In this scenario, you can call this operation to re-encrypt the data.
         * *   You can call this operation to use a CMK in KMS to re-encrypt data or a data key that was previously encrypted by a different CMK.
         * To use the ReEncrypt operation, you must have two permissions:
         * *   kms:ReEncryptFrom on the source CMK
         * *   kms:ReEncryptTo on the destination CMK
         * *   For simplicity, you can specify kms:ReEncrypt\\* to allow both of the preceding permissions.
         *
         * @param request ReEncryptRequest
         * @return ReEncryptResponse
         */
        public async Task<ReEncryptResponse> ReEncryptAsync(ReEncryptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReEncryptWithOptionsAsync(request, runtime);
        }

        /**
         * @description You can only use this operation to restore a deleted secret that is within its recovery period. If you set **ForceDeleteWithoutRecovery** to **true** when you delete the secret, you cannot restore it.
         *
         * @param request RestoreSecretRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RestoreSecretResponse
         */
        public RestoreSecretResponse RestoreSecretWithOptions(RestoreSecretRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretName))
            {
                query["SecretName"] = request.SecretName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RestoreSecret",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<RestoreSecretResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<RestoreSecretResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @description You can only use this operation to restore a deleted secret that is within its recovery period. If you set **ForceDeleteWithoutRecovery** to **true** when you delete the secret, you cannot restore it.
         *
         * @param request RestoreSecretRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RestoreSecretResponse
         */
        public async Task<RestoreSecretResponse> RestoreSecretWithOptionsAsync(RestoreSecretRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretName))
            {
                query["SecretName"] = request.SecretName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RestoreSecret",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<RestoreSecretResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<RestoreSecretResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @description You can only use this operation to restore a deleted secret that is within its recovery period. If you set **ForceDeleteWithoutRecovery** to **true** when you delete the secret, you cannot restore it.
         *
         * @param request RestoreSecretRequest
         * @return RestoreSecretResponse
         */
        public RestoreSecretResponse RestoreSecret(RestoreSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RestoreSecretWithOptions(request, runtime);
        }

        /**
         * @description You can only use this operation to restore a deleted secret that is within its recovery period. If you set **ForceDeleteWithoutRecovery** to **true** when you delete the secret, you cannot restore it.
         *
         * @param request RestoreSecretRequest
         * @return RestoreSecretResponse
         */
        public async Task<RestoreSecretResponse> RestoreSecretAsync(RestoreSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RestoreSecretWithOptionsAsync(request, runtime);
        }

        /**
         * @description Limits:
         * • A secret of each Alibaba Cloud account can be rotated for a maximum of 50 times per hour.
         * • The RotateSecret operation is unavailable for standard secrets.
         * In this example, the `RdsSecret/Mysql5.4/MyCred` secret is manually rotated, and the version number of the secret is set to `000000123` after the secret is rotated.
         *
         * @param request RotateSecretRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RotateSecretResponse
         */
        public RotateSecretResponse RotateSecretWithOptions(RotateSecretRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretName))
            {
                query["SecretName"] = request.SecretName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionId))
            {
                query["VersionId"] = request.VersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RotateSecret",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<RotateSecretResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<RotateSecretResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @description Limits:
         * • A secret of each Alibaba Cloud account can be rotated for a maximum of 50 times per hour.
         * • The RotateSecret operation is unavailable for standard secrets.
         * In this example, the `RdsSecret/Mysql5.4/MyCred` secret is manually rotated, and the version number of the secret is set to `000000123` after the secret is rotated.
         *
         * @param request RotateSecretRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RotateSecretResponse
         */
        public async Task<RotateSecretResponse> RotateSecretWithOptionsAsync(RotateSecretRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretName))
            {
                query["SecretName"] = request.SecretName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionId))
            {
                query["VersionId"] = request.VersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RotateSecret",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<RotateSecretResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<RotateSecretResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @description Limits:
         * • A secret of each Alibaba Cloud account can be rotated for a maximum of 50 times per hour.
         * • The RotateSecret operation is unavailable for standard secrets.
         * In this example, the `RdsSecret/Mysql5.4/MyCred` secret is manually rotated, and the version number of the secret is set to `000000123` after the secret is rotated.
         *
         * @param request RotateSecretRequest
         * @return RotateSecretResponse
         */
        public RotateSecretResponse RotateSecret(RotateSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RotateSecretWithOptions(request, runtime);
        }

        /**
         * @description Limits:
         * • A secret of each Alibaba Cloud account can be rotated for a maximum of 50 times per hour.
         * • The RotateSecret operation is unavailable for standard secrets.
         * In this example, the `RdsSecret/Mysql5.4/MyCred` secret is manually rotated, and the version number of the secret is set to `000000123` after the secret is rotated.
         *
         * @param request RotateSecretRequest
         * @return RotateSecretResponse
         */
        public async Task<RotateSecretResponse> RotateSecretAsync(RotateSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RotateSecretWithOptionsAsync(request, runtime);
        }

        /**
         * @description During the scheduled period, the CMK is in the PendingDeletion state and cannot be used to encrypt data, decrypt data, or generate data keys.
         * After a CMK is deleted, it cannot be recovered. Data that is encrypted and data keys that are generated by using the CMK cannot be decrypted. To prevent accidental deletion of CMKs, Key Management Service (KMS) allows you to only schedule key deletion tasks. You cannot directly delete CMKs. If you want to delete a CMK, call the [DisableKey](https://help.aliyun.com/document_detail/35151.html) operation to disable the CMK.
         * When you call this operation, you must specify a scheduled period between 7 days to 366 days. The scheduled period starts from the time when you submit the request. You can call the [CancelKeyDeletion](https://help.aliyun.com/document_detail/44197.html) operation to cancel the key deletion task before the scheduled period ends.
         *
         * @param request ScheduleKeyDeletionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ScheduleKeyDeletionResponse
         */
        public ScheduleKeyDeletionResponse ScheduleKeyDeletionWithOptions(ScheduleKeyDeletionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyId))
            {
                query["KeyId"] = request.KeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PendingWindowInDays))
            {
                query["PendingWindowInDays"] = request.PendingWindowInDays;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ScheduleKeyDeletion",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<ScheduleKeyDeletionResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ScheduleKeyDeletionResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @description During the scheduled period, the CMK is in the PendingDeletion state and cannot be used to encrypt data, decrypt data, or generate data keys.
         * After a CMK is deleted, it cannot be recovered. Data that is encrypted and data keys that are generated by using the CMK cannot be decrypted. To prevent accidental deletion of CMKs, Key Management Service (KMS) allows you to only schedule key deletion tasks. You cannot directly delete CMKs. If you want to delete a CMK, call the [DisableKey](https://help.aliyun.com/document_detail/35151.html) operation to disable the CMK.
         * When you call this operation, you must specify a scheduled period between 7 days to 366 days. The scheduled period starts from the time when you submit the request. You can call the [CancelKeyDeletion](https://help.aliyun.com/document_detail/44197.html) operation to cancel the key deletion task before the scheduled period ends.
         *
         * @param request ScheduleKeyDeletionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ScheduleKeyDeletionResponse
         */
        public async Task<ScheduleKeyDeletionResponse> ScheduleKeyDeletionWithOptionsAsync(ScheduleKeyDeletionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyId))
            {
                query["KeyId"] = request.KeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PendingWindowInDays))
            {
                query["PendingWindowInDays"] = request.PendingWindowInDays;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ScheduleKeyDeletion",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<ScheduleKeyDeletionResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ScheduleKeyDeletionResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @description During the scheduled period, the CMK is in the PendingDeletion state and cannot be used to encrypt data, decrypt data, or generate data keys.
         * After a CMK is deleted, it cannot be recovered. Data that is encrypted and data keys that are generated by using the CMK cannot be decrypted. To prevent accidental deletion of CMKs, Key Management Service (KMS) allows you to only schedule key deletion tasks. You cannot directly delete CMKs. If you want to delete a CMK, call the [DisableKey](https://help.aliyun.com/document_detail/35151.html) operation to disable the CMK.
         * When you call this operation, you must specify a scheduled period between 7 days to 366 days. The scheduled period starts from the time when you submit the request. You can call the [CancelKeyDeletion](https://help.aliyun.com/document_detail/44197.html) operation to cancel the key deletion task before the scheduled period ends.
         *
         * @param request ScheduleKeyDeletionRequest
         * @return ScheduleKeyDeletionResponse
         */
        public ScheduleKeyDeletionResponse ScheduleKeyDeletion(ScheduleKeyDeletionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ScheduleKeyDeletionWithOptions(request, runtime);
        }

        /**
         * @description During the scheduled period, the CMK is in the PendingDeletion state and cannot be used to encrypt data, decrypt data, or generate data keys.
         * After a CMK is deleted, it cannot be recovered. Data that is encrypted and data keys that are generated by using the CMK cannot be decrypted. To prevent accidental deletion of CMKs, Key Management Service (KMS) allows you to only schedule key deletion tasks. You cannot directly delete CMKs. If you want to delete a CMK, call the [DisableKey](https://help.aliyun.com/document_detail/35151.html) operation to disable the CMK.
         * When you call this operation, you must specify a scheduled period between 7 days to 366 days. The scheduled period starts from the time when you submit the request. You can call the [CancelKeyDeletion](https://help.aliyun.com/document_detail/44197.html) operation to cancel the key deletion task before the scheduled period ends.
         *
         * @param request ScheduleKeyDeletionRequest
         * @return ScheduleKeyDeletionResponse
         */
        public async Task<ScheduleKeyDeletionResponse> ScheduleKeyDeletionAsync(ScheduleKeyDeletionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ScheduleKeyDeletionWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Enables or disables deletion protection for a customer master key (CMK).
         *
         * @description *   After you enable deletion protection for a CMK, you cannot delete the CMK. If you want to delete the CMK, you must first disable deletion protection for the CMK.
         * *   Before you can call the SetDeletionProtection operation, make sure that the required CMK is not in the Pending Deletion state. You can call the [DescribeKey](https://help.aliyun.com/document_detail/28952.html) operation to query the CMK status, which is specified by the KeyState parameter.
         * You can enable deletion protection for the CMK whose Alibaba Cloud Resource Name (ARN) is `acs:kms:cn-hangzhou:123213123****:key/0225f411-b21d-46d1-be5b-93931c82****` by using parameter settings provided in this topic. The CMK ARN is specified by the ProtectedResourceArn parameter.
         *
         * @param request SetDeletionProtectionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetDeletionProtectionResponse
         */
        public SetDeletionProtectionResponse SetDeletionProtectionWithOptions(SetDeletionProtectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeletionProtectionDescription))
            {
                query["DeletionProtectionDescription"] = request.DeletionProtectionDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableDeletionProtection))
            {
                query["EnableDeletionProtection"] = request.EnableDeletionProtection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProtectedResourceArn))
            {
                query["ProtectedResourceArn"] = request.ProtectedResourceArn;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetDeletionProtection",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<SetDeletionProtectionResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<SetDeletionProtectionResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @summary Enables or disables deletion protection for a customer master key (CMK).
         *
         * @description *   After you enable deletion protection for a CMK, you cannot delete the CMK. If you want to delete the CMK, you must first disable deletion protection for the CMK.
         * *   Before you can call the SetDeletionProtection operation, make sure that the required CMK is not in the Pending Deletion state. You can call the [DescribeKey](https://help.aliyun.com/document_detail/28952.html) operation to query the CMK status, which is specified by the KeyState parameter.
         * You can enable deletion protection for the CMK whose Alibaba Cloud Resource Name (ARN) is `acs:kms:cn-hangzhou:123213123****:key/0225f411-b21d-46d1-be5b-93931c82****` by using parameter settings provided in this topic. The CMK ARN is specified by the ProtectedResourceArn parameter.
         *
         * @param request SetDeletionProtectionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetDeletionProtectionResponse
         */
        public async Task<SetDeletionProtectionResponse> SetDeletionProtectionWithOptionsAsync(SetDeletionProtectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeletionProtectionDescription))
            {
                query["DeletionProtectionDescription"] = request.DeletionProtectionDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableDeletionProtection))
            {
                query["EnableDeletionProtection"] = request.EnableDeletionProtection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProtectedResourceArn))
            {
                query["ProtectedResourceArn"] = request.ProtectedResourceArn;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetDeletionProtection",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<SetDeletionProtectionResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<SetDeletionProtectionResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @summary Enables or disables deletion protection for a customer master key (CMK).
         *
         * @description *   After you enable deletion protection for a CMK, you cannot delete the CMK. If you want to delete the CMK, you must first disable deletion protection for the CMK.
         * *   Before you can call the SetDeletionProtection operation, make sure that the required CMK is not in the Pending Deletion state. You can call the [DescribeKey](https://help.aliyun.com/document_detail/28952.html) operation to query the CMK status, which is specified by the KeyState parameter.
         * You can enable deletion protection for the CMK whose Alibaba Cloud Resource Name (ARN) is `acs:kms:cn-hangzhou:123213123****:key/0225f411-b21d-46d1-be5b-93931c82****` by using parameter settings provided in this topic. The CMK ARN is specified by the ProtectedResourceArn parameter.
         *
         * @param request SetDeletionProtectionRequest
         * @return SetDeletionProtectionResponse
         */
        public SetDeletionProtectionResponse SetDeletionProtection(SetDeletionProtectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetDeletionProtectionWithOptions(request, runtime);
        }

        /**
         * @summary Enables or disables deletion protection for a customer master key (CMK).
         *
         * @description *   After you enable deletion protection for a CMK, you cannot delete the CMK. If you want to delete the CMK, you must first disable deletion protection for the CMK.
         * *   Before you can call the SetDeletionProtection operation, make sure that the required CMK is not in the Pending Deletion state. You can call the [DescribeKey](https://help.aliyun.com/document_detail/28952.html) operation to query the CMK status, which is specified by the KeyState parameter.
         * You can enable deletion protection for the CMK whose Alibaba Cloud Resource Name (ARN) is `acs:kms:cn-hangzhou:123213123****:key/0225f411-b21d-46d1-be5b-93931c82****` by using parameter settings provided in this topic. The CMK ARN is specified by the ProtectedResourceArn parameter.
         *
         * @param request SetDeletionProtectionRequest
         * @return SetDeletionProtectionResponse
         */
        public async Task<SetDeletionProtectionResponse> SetDeletionProtectionAsync(SetDeletionProtectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetDeletionProtectionWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 可以设置一条 Key Policy，且名称必须为 default。
         *
         * @param request SetKeyPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetKeyPolicyResponse
         */
        public SetKeyPolicyResponse SetKeyPolicyWithOptions(SetKeyPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyId))
            {
                query["KeyId"] = request.KeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Policy))
            {
                query["Policy"] = request.Policy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                query["PolicyName"] = request.PolicyName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetKeyPolicy",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<SetKeyPolicyResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<SetKeyPolicyResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @summary 可以设置一条 Key Policy，且名称必须为 default。
         *
         * @param request SetKeyPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetKeyPolicyResponse
         */
        public async Task<SetKeyPolicyResponse> SetKeyPolicyWithOptionsAsync(SetKeyPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyId))
            {
                query["KeyId"] = request.KeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Policy))
            {
                query["Policy"] = request.Policy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                query["PolicyName"] = request.PolicyName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetKeyPolicy",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<SetKeyPolicyResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<SetKeyPolicyResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @summary 可以设置一条 Key Policy，且名称必须为 default。
         *
         * @param request SetKeyPolicyRequest
         * @return SetKeyPolicyResponse
         */
        public SetKeyPolicyResponse SetKeyPolicy(SetKeyPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetKeyPolicyWithOptions(request, runtime);
        }

        /**
         * @summary 可以设置一条 Key Policy，且名称必须为 default。
         *
         * @param request SetKeyPolicyRequest
         * @return SetKeyPolicyResponse
         */
        public async Task<SetKeyPolicyResponse> SetKeyPolicyAsync(SetKeyPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetKeyPolicyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 可以设置一条 Secret Policy，且名称必须为 default。
         *
         * @param request SetSecretPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetSecretPolicyResponse
         */
        public SetSecretPolicyResponse SetSecretPolicyWithOptions(SetSecretPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Policy))
            {
                query["Policy"] = request.Policy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                query["PolicyName"] = request.PolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretName))
            {
                query["SecretName"] = request.SecretName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetSecretPolicy",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<SetSecretPolicyResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<SetSecretPolicyResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @summary 可以设置一条 Secret Policy，且名称必须为 default。
         *
         * @param request SetSecretPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetSecretPolicyResponse
         */
        public async Task<SetSecretPolicyResponse> SetSecretPolicyWithOptionsAsync(SetSecretPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Policy))
            {
                query["Policy"] = request.Policy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                query["PolicyName"] = request.PolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretName))
            {
                query["SecretName"] = request.SecretName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetSecretPolicy",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<SetSecretPolicyResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<SetSecretPolicyResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @summary 可以设置一条 Secret Policy，且名称必须为 default。
         *
         * @param request SetSecretPolicyRequest
         * @return SetSecretPolicyResponse
         */
        public SetSecretPolicyResponse SetSecretPolicy(SetSecretPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetSecretPolicyWithOptions(request, runtime);
        }

        /**
         * @summary 可以设置一条 Secret Policy，且名称必须为 default。
         *
         * @param request SetSecretPolicyRequest
         * @return SetSecretPolicyResponse
         */
        public async Task<SetSecretPolicyResponse> SetSecretPolicyAsync(SetSecretPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetSecretPolicyWithOptionsAsync(request, runtime);
        }

        /**
         * @description You can add up to 10 tags to a CMK, secret, or certificate.
         * In this example, the tags `[{"TagKey":"S1key1","TagValue":"S1val1"},{"TagKey":"S1key2","TagValue":"S2val2"}]` are added to the CMK whose ID is `08c33a6f-4e0a-4a1b-a3fa-7ddf****`.
         *
         * @param request TagResourceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return TagResourceResponse
         */
        public TagResourceResponse TagResourceWithOptions(TagResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertificateId))
            {
                query["CertificateId"] = request.CertificateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyId))
            {
                query["KeyId"] = request.KeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretName))
            {
                query["SecretName"] = request.SecretName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagResource",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<TagResourceResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<TagResourceResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @description You can add up to 10 tags to a CMK, secret, or certificate.
         * In this example, the tags `[{"TagKey":"S1key1","TagValue":"S1val1"},{"TagKey":"S1key2","TagValue":"S2val2"}]` are added to the CMK whose ID is `08c33a6f-4e0a-4a1b-a3fa-7ddf****`.
         *
         * @param request TagResourceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return TagResourceResponse
         */
        public async Task<TagResourceResponse> TagResourceWithOptionsAsync(TagResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertificateId))
            {
                query["CertificateId"] = request.CertificateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyId))
            {
                query["KeyId"] = request.KeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretName))
            {
                query["SecretName"] = request.SecretName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagResource",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<TagResourceResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<TagResourceResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @description You can add up to 10 tags to a CMK, secret, or certificate.
         * In this example, the tags `[{"TagKey":"S1key1","TagValue":"S1val1"},{"TagKey":"S1key2","TagValue":"S2val2"}]` are added to the CMK whose ID is `08c33a6f-4e0a-4a1b-a3fa-7ddf****`.
         *
         * @param request TagResourceRequest
         * @return TagResourceResponse
         */
        public TagResourceResponse TagResource(TagResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TagResourceWithOptions(request, runtime);
        }

        /**
         * @description You can add up to 10 tags to a CMK, secret, or certificate.
         * In this example, the tags `[{"TagKey":"S1key1","TagValue":"S1val1"},{"TagKey":"S1key2","TagValue":"S2val2"}]` are added to the CMK whose ID is `08c33a6f-4e0a-4a1b-a3fa-7ddf****`.
         *
         * @param request TagResourceRequest
         * @return TagResourceResponse
         */
        public async Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TagResourceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Adds tags to keys or secrets.
         *
         * @description You can add multiple tags to multiple keys or multiple secrets at a time.
         *
         * @param request TagResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return TagResourcesResponse
         */
        public TagResourcesResponse TagResourcesWithOptions(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Version = "2016-01-20",
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
                return TeaModel.ToObject<TagResourcesResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<TagResourcesResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @summary Adds tags to keys or secrets.
         *
         * @description You can add multiple tags to multiple keys or multiple secrets at a time.
         *
         * @param request TagResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return TagResourcesResponse
         */
        public async Task<TagResourcesResponse> TagResourcesWithOptionsAsync(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Version = "2016-01-20",
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
                return TeaModel.ToObject<TagResourcesResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<TagResourcesResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @summary Adds tags to keys or secrets.
         *
         * @description You can add multiple tags to multiple keys or multiple secrets at a time.
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
         * @summary Adds tags to keys or secrets.
         *
         * @description You can add multiple tags to multiple keys or multiple secrets at a time.
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
         * @description One or more tag keys. Separate multiple tag keys with commas (,).
         * You need to specify only the tag keys, not the tag values.
         * Each tag key must be 1 to 128 bytes in length.
         *
         * @param request UntagResourceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UntagResourceResponse
         */
        public UntagResourceResponse UntagResourceWithOptions(UntagResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertificateId))
            {
                query["CertificateId"] = request.CertificateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyId))
            {
                query["KeyId"] = request.KeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretName))
            {
                query["SecretName"] = request.SecretName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKeys))
            {
                query["TagKeys"] = request.TagKeys;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UntagResource",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<UntagResourceResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UntagResourceResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @description One or more tag keys. Separate multiple tag keys with commas (,).
         * You need to specify only the tag keys, not the tag values.
         * Each tag key must be 1 to 128 bytes in length.
         *
         * @param request UntagResourceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UntagResourceResponse
         */
        public async Task<UntagResourceResponse> UntagResourceWithOptionsAsync(UntagResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertificateId))
            {
                query["CertificateId"] = request.CertificateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyId))
            {
                query["KeyId"] = request.KeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretName))
            {
                query["SecretName"] = request.SecretName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKeys))
            {
                query["TagKeys"] = request.TagKeys;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UntagResource",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<UntagResourceResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UntagResourceResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @description One or more tag keys. Separate multiple tag keys with commas (,).
         * You need to specify only the tag keys, not the tag values.
         * Each tag key must be 1 to 128 bytes in length.
         *
         * @param request UntagResourceRequest
         * @return UntagResourceResponse
         */
        public UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UntagResourceWithOptions(request, runtime);
        }

        /**
         * @description One or more tag keys. Separate multiple tag keys with commas (,).
         * You need to specify only the tag keys, not the tag values.
         * Each tag key must be 1 to 128 bytes in length.
         *
         * @param request UntagResourceRequest
         * @return UntagResourceResponse
         */
        public async Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UntagResourceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Removes tags from keys or secrets.
         *
         * @description You can remove multiple tags from multiple keys or multiple secrets at a time. You cannot remove tags that start with aliyun or acs:.
         * If you enter multiple tag keys in the request parameters and only some of the tag keys are associated with resources, the operation can be called and the tags whose keys are associated with resources are removed from the resources.
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Version = "2016-01-20",
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
                return TeaModel.ToObject<UntagResourcesResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UntagResourcesResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @summary Removes tags from keys or secrets.
         *
         * @description You can remove multiple tags from multiple keys or multiple secrets at a time. You cannot remove tags that start with aliyun or acs:.
         * If you enter multiple tag keys in the request parameters and only some of the tag keys are associated with resources, the operation can be called and the tags whose keys are associated with resources are removed from the resources.
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Version = "2016-01-20",
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
                return TeaModel.ToObject<UntagResourcesResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UntagResourcesResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @summary Removes tags from keys or secrets.
         *
         * @description You can remove multiple tags from multiple keys or multiple secrets at a time. You cannot remove tags that start with aliyun or acs:.
         * If you enter multiple tag keys in the request parameters and only some of the tag keys are associated with resources, the operation can be called and the tags whose keys are associated with resources are removed from the resources.
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
         * @summary Removes tags from keys or secrets.
         *
         * @description You can remove multiple tags from multiple keys or multiple secrets at a time. You cannot remove tags that start with aliyun or acs:.
         * If you enter multiple tag keys in the request parameters and only some of the tag keys are associated with resources, the operation can be called and the tags whose keys are associated with resources are removed from the resources.
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
         * @param request UpdateAliasRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateAliasResponse
         */
        public UpdateAliasResponse UpdateAliasWithOptions(UpdateAliasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliasName))
            {
                query["AliasName"] = request.AliasName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyId))
            {
                query["KeyId"] = request.KeyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAlias",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<UpdateAliasResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UpdateAliasResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @param request UpdateAliasRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateAliasResponse
         */
        public async Task<UpdateAliasResponse> UpdateAliasWithOptionsAsync(UpdateAliasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliasName))
            {
                query["AliasName"] = request.AliasName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyId))
            {
                query["KeyId"] = request.KeyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAlias",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<UpdateAliasResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UpdateAliasResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @param request UpdateAliasRequest
         * @return UpdateAliasResponse
         */
        public UpdateAliasResponse UpdateAlias(UpdateAliasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAliasWithOptions(request, runtime);
        }

        /**
         * @param request UpdateAliasRequest
         * @return UpdateAliasResponse
         */
        public async Task<UpdateAliasResponse> UpdateAliasAsync(UpdateAliasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAliasWithOptionsAsync(request, runtime);
        }

        /**
         * @description The update takes effect immediately after an AAP information is updated. Exercise caution when you perform this operation. You can update the description of an AAP and the permission policies that are associated with the AAP. You cannot update the name of the AAP.
         *
         * @param request UpdateApplicationAccessPointRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateApplicationAccessPointResponse
         */
        public UpdateApplicationAccessPointResponse UpdateApplicationAccessPointWithOptions(UpdateApplicationAccessPointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Policies))
            {
                query["Policies"] = request.Policies;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateApplicationAccessPoint",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<UpdateApplicationAccessPointResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UpdateApplicationAccessPointResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @description The update takes effect immediately after an AAP information is updated. Exercise caution when you perform this operation. You can update the description of an AAP and the permission policies that are associated with the AAP. You cannot update the name of the AAP.
         *
         * @param request UpdateApplicationAccessPointRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateApplicationAccessPointResponse
         */
        public async Task<UpdateApplicationAccessPointResponse> UpdateApplicationAccessPointWithOptionsAsync(UpdateApplicationAccessPointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Policies))
            {
                query["Policies"] = request.Policies;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateApplicationAccessPoint",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<UpdateApplicationAccessPointResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UpdateApplicationAccessPointResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @description The update takes effect immediately after an AAP information is updated. Exercise caution when you perform this operation. You can update the description of an AAP and the permission policies that are associated with the AAP. You cannot update the name of the AAP.
         *
         * @param request UpdateApplicationAccessPointRequest
         * @return UpdateApplicationAccessPointResponse
         */
        public UpdateApplicationAccessPointResponse UpdateApplicationAccessPoint(UpdateApplicationAccessPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateApplicationAccessPointWithOptions(request, runtime);
        }

        /**
         * @description The update takes effect immediately after an AAP information is updated. Exercise caution when you perform this operation. You can update the description of an AAP and the permission policies that are associated with the AAP. You cannot update the name of the AAP.
         *
         * @param request UpdateApplicationAccessPointRequest
         * @return UpdateApplicationAccessPointResponse
         */
        public async Task<UpdateApplicationAccessPointResponse> UpdateApplicationAccessPointAsync(UpdateApplicationAccessPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateApplicationAccessPointWithOptionsAsync(request, runtime);
        }

        /**
         * @description In this example, the status of the certificate whose ID is `9a28de48-8d8b-484d-a766-dec4****` is updated to INACTIVE.
         *
         * @param request UpdateCertificateStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateCertificateStatusResponse
         */
        public UpdateCertificateStatusResponse UpdateCertificateStatusWithOptions(UpdateCertificateStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertificateId))
            {
                query["CertificateId"] = request.CertificateId;
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
                Action = "UpdateCertificateStatus",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<UpdateCertificateStatusResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UpdateCertificateStatusResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @description In this example, the status of the certificate whose ID is `9a28de48-8d8b-484d-a766-dec4****` is updated to INACTIVE.
         *
         * @param request UpdateCertificateStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateCertificateStatusResponse
         */
        public async Task<UpdateCertificateStatusResponse> UpdateCertificateStatusWithOptionsAsync(UpdateCertificateStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertificateId))
            {
                query["CertificateId"] = request.CertificateId;
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
                Action = "UpdateCertificateStatus",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<UpdateCertificateStatusResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UpdateCertificateStatusResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @description In this example, the status of the certificate whose ID is `9a28de48-8d8b-484d-a766-dec4****` is updated to INACTIVE.
         *
         * @param request UpdateCertificateStatusRequest
         * @return UpdateCertificateStatusResponse
         */
        public UpdateCertificateStatusResponse UpdateCertificateStatus(UpdateCertificateStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateCertificateStatusWithOptions(request, runtime);
        }

        /**
         * @description In this example, the status of the certificate whose ID is `9a28de48-8d8b-484d-a766-dec4****` is updated to INACTIVE.
         *
         * @param request UpdateCertificateStatusRequest
         * @return UpdateCertificateStatusResponse
         */
        public async Task<UpdateCertificateStatusResponse> UpdateCertificateStatusAsync(UpdateCertificateStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateCertificateStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 调用UpdateKeyDescription接口更新主密钥的描述信息。
         *
         * @description This operation replaces the description of a customer master key (CMK) with the description that you specify. The original description of the CMK is specified by the Description parameter when you call the [DescribeKey](https://help.aliyun.com/document_detail/28952.html) operation. You can call this operation to add, modify, or delete the description of a CMK.
         *
         * @param request UpdateKeyDescriptionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateKeyDescriptionResponse
         */
        public UpdateKeyDescriptionResponse UpdateKeyDescriptionWithOptions(UpdateKeyDescriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyId))
            {
                query["KeyId"] = request.KeyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateKeyDescription",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<UpdateKeyDescriptionResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UpdateKeyDescriptionResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @summary 调用UpdateKeyDescription接口更新主密钥的描述信息。
         *
         * @description This operation replaces the description of a customer master key (CMK) with the description that you specify. The original description of the CMK is specified by the Description parameter when you call the [DescribeKey](https://help.aliyun.com/document_detail/28952.html) operation. You can call this operation to add, modify, or delete the description of a CMK.
         *
         * @param request UpdateKeyDescriptionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateKeyDescriptionResponse
         */
        public async Task<UpdateKeyDescriptionResponse> UpdateKeyDescriptionWithOptionsAsync(UpdateKeyDescriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyId))
            {
                query["KeyId"] = request.KeyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateKeyDescription",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<UpdateKeyDescriptionResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UpdateKeyDescriptionResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @summary 调用UpdateKeyDescription接口更新主密钥的描述信息。
         *
         * @description This operation replaces the description of a customer master key (CMK) with the description that you specify. The original description of the CMK is specified by the Description parameter when you call the [DescribeKey](https://help.aliyun.com/document_detail/28952.html) operation. You can call this operation to add, modify, or delete the description of a CMK.
         *
         * @param request UpdateKeyDescriptionRequest
         * @return UpdateKeyDescriptionResponse
         */
        public UpdateKeyDescriptionResponse UpdateKeyDescription(UpdateKeyDescriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateKeyDescriptionWithOptions(request, runtime);
        }

        /**
         * @summary 调用UpdateKeyDescription接口更新主密钥的描述信息。
         *
         * @description This operation replaces the description of a customer master key (CMK) with the description that you specify. The original description of the CMK is specified by the Description parameter when you call the [DescribeKey](https://help.aliyun.com/document_detail/28952.html) operation. You can call this operation to add, modify, or delete the description of a CMK.
         *
         * @param request UpdateKeyDescriptionRequest
         * @return UpdateKeyDescriptionResponse
         */
        public async Task<UpdateKeyDescriptionResponse> UpdateKeyDescriptionAsync(UpdateKeyDescriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateKeyDescriptionWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Updates the virtual private cloud (VPC) that is associated with a Key Management Service (KMS) instance.
         *
         * @description If your own applications are deployed in multiple VPCs in the same region, you can associate the VPCs except the VPC in which the KMS instance resides with the KMS instance. This topic describes how to configure the VPCs.
         * The VPCs can belong to the same Alibaba Cloud account or different Alibaba Cloud accounts. After the configuration is complete, the applications in these VPCs can access the KMS instance.
         * > If the VPCs belong to different Alibaba Cloud accounts, you must first configure resource sharing to share the vSwitches of other Alibaba Cloud accounts with the Alibaba Cloud account to which the KMS instance belongs. For more information, see [Access a KMS instance from multiple VPCs in the same region](https://help.aliyun.com/document_detail/2393236.html).
         *
         * @param request UpdateKmsInstanceBindVpcRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateKmsInstanceBindVpcResponse
         */
        public UpdateKmsInstanceBindVpcResponse UpdateKmsInstanceBindVpcWithOptions(UpdateKmsInstanceBindVpcRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateKmsInstanceBindVpc",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<UpdateKmsInstanceBindVpcResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UpdateKmsInstanceBindVpcResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @summary Updates the virtual private cloud (VPC) that is associated with a Key Management Service (KMS) instance.
         *
         * @description If your own applications are deployed in multiple VPCs in the same region, you can associate the VPCs except the VPC in which the KMS instance resides with the KMS instance. This topic describes how to configure the VPCs.
         * The VPCs can belong to the same Alibaba Cloud account or different Alibaba Cloud accounts. After the configuration is complete, the applications in these VPCs can access the KMS instance.
         * > If the VPCs belong to different Alibaba Cloud accounts, you must first configure resource sharing to share the vSwitches of other Alibaba Cloud accounts with the Alibaba Cloud account to which the KMS instance belongs. For more information, see [Access a KMS instance from multiple VPCs in the same region](https://help.aliyun.com/document_detail/2393236.html).
         *
         * @param request UpdateKmsInstanceBindVpcRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateKmsInstanceBindVpcResponse
         */
        public async Task<UpdateKmsInstanceBindVpcResponse> UpdateKmsInstanceBindVpcWithOptionsAsync(UpdateKmsInstanceBindVpcRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateKmsInstanceBindVpc",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<UpdateKmsInstanceBindVpcResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UpdateKmsInstanceBindVpcResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @summary Updates the virtual private cloud (VPC) that is associated with a Key Management Service (KMS) instance.
         *
         * @description If your own applications are deployed in multiple VPCs in the same region, you can associate the VPCs except the VPC in which the KMS instance resides with the KMS instance. This topic describes how to configure the VPCs.
         * The VPCs can belong to the same Alibaba Cloud account or different Alibaba Cloud accounts. After the configuration is complete, the applications in these VPCs can access the KMS instance.
         * > If the VPCs belong to different Alibaba Cloud accounts, you must first configure resource sharing to share the vSwitches of other Alibaba Cloud accounts with the Alibaba Cloud account to which the KMS instance belongs. For more information, see [Access a KMS instance from multiple VPCs in the same region](https://help.aliyun.com/document_detail/2393236.html).
         *
         * @param request UpdateKmsInstanceBindVpcRequest
         * @return UpdateKmsInstanceBindVpcResponse
         */
        public UpdateKmsInstanceBindVpcResponse UpdateKmsInstanceBindVpc(UpdateKmsInstanceBindVpcRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateKmsInstanceBindVpcWithOptions(request, runtime);
        }

        /**
         * @summary Updates the virtual private cloud (VPC) that is associated with a Key Management Service (KMS) instance.
         *
         * @description If your own applications are deployed in multiple VPCs in the same region, you can associate the VPCs except the VPC in which the KMS instance resides with the KMS instance. This topic describes how to configure the VPCs.
         * The VPCs can belong to the same Alibaba Cloud account or different Alibaba Cloud accounts. After the configuration is complete, the applications in these VPCs can access the KMS instance.
         * > If the VPCs belong to different Alibaba Cloud accounts, you must first configure resource sharing to share the vSwitches of other Alibaba Cloud accounts with the Alibaba Cloud account to which the KMS instance belongs. For more information, see [Access a KMS instance from multiple VPCs in the same region](https://help.aliyun.com/document_detail/2393236.html).
         *
         * @param request UpdateKmsInstanceBindVpcRequest
         * @return UpdateKmsInstanceBindVpcResponse
         */
        public async Task<UpdateKmsInstanceBindVpcResponse> UpdateKmsInstanceBindVpcAsync(UpdateKmsInstanceBindVpcRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateKmsInstanceBindVpcWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Updates an access control rule.
         *
         * @description - You can update only private IP addresses and description of an access control rule. You cannot update the name and network type of an access control rule.
         * - Updating an access control rule affects all permission policies that are bound to the access control rule. Exercise caution when you perform this operation.
         *
         * @param request UpdateNetworkRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateNetworkRuleResponse
         */
        public UpdateNetworkRuleResponse UpdateNetworkRuleWithOptions(UpdateNetworkRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourcePrivateIp))
            {
                query["SourcePrivateIp"] = request.SourcePrivateIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateNetworkRule",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<UpdateNetworkRuleResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UpdateNetworkRuleResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @summary Updates an access control rule.
         *
         * @description - You can update only private IP addresses and description of an access control rule. You cannot update the name and network type of an access control rule.
         * - Updating an access control rule affects all permission policies that are bound to the access control rule. Exercise caution when you perform this operation.
         *
         * @param request UpdateNetworkRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateNetworkRuleResponse
         */
        public async Task<UpdateNetworkRuleResponse> UpdateNetworkRuleWithOptionsAsync(UpdateNetworkRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourcePrivateIp))
            {
                query["SourcePrivateIp"] = request.SourcePrivateIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateNetworkRule",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<UpdateNetworkRuleResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UpdateNetworkRuleResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @summary Updates an access control rule.
         *
         * @description - You can update only private IP addresses and description of an access control rule. You cannot update the name and network type of an access control rule.
         * - Updating an access control rule affects all permission policies that are bound to the access control rule. Exercise caution when you perform this operation.
         *
         * @param request UpdateNetworkRuleRequest
         * @return UpdateNetworkRuleResponse
         */
        public UpdateNetworkRuleResponse UpdateNetworkRule(UpdateNetworkRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateNetworkRuleWithOptions(request, runtime);
        }

        /**
         * @summary Updates an access control rule.
         *
         * @description - You can update only private IP addresses and description of an access control rule. You cannot update the name and network type of an access control rule.
         * - Updating an access control rule affects all permission policies that are bound to the access control rule. Exercise caution when you perform this operation.
         *
         * @param request UpdateNetworkRuleRequest
         * @return UpdateNetworkRuleResponse
         */
        public async Task<UpdateNetworkRuleResponse> UpdateNetworkRuleAsync(UpdateNetworkRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateNetworkRuleWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 更新一个权限策略
         *
         * @description - You can update the role-based access control (RBAC) permissions, accessible resources, access control rules, and description of a permission policy. You cannot update the name or scope of a permission policy.
         * - Updating a permission policy affects all application access points (AAPs) that are bound to the permission policy. Exercise caution when you perform this operation.
         *
         * @param request UpdatePolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdatePolicyResponse
         */
        public UpdatePolicyResponse UpdatePolicyWithOptions(UpdatePolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessControlRules))
            {
                query["AccessControlRules"] = request.AccessControlRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Permissions))
            {
                query["Permissions"] = request.Permissions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resources))
            {
                query["Resources"] = request.Resources;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdatePolicy",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<UpdatePolicyResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UpdatePolicyResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @summary 更新一个权限策略
         *
         * @description - You can update the role-based access control (RBAC) permissions, accessible resources, access control rules, and description of a permission policy. You cannot update the name or scope of a permission policy.
         * - Updating a permission policy affects all application access points (AAPs) that are bound to the permission policy. Exercise caution when you perform this operation.
         *
         * @param request UpdatePolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdatePolicyResponse
         */
        public async Task<UpdatePolicyResponse> UpdatePolicyWithOptionsAsync(UpdatePolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessControlRules))
            {
                query["AccessControlRules"] = request.AccessControlRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Permissions))
            {
                query["Permissions"] = request.Permissions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resources))
            {
                query["Resources"] = request.Resources;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdatePolicy",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<UpdatePolicyResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UpdatePolicyResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @summary 更新一个权限策略
         *
         * @description - You can update the role-based access control (RBAC) permissions, accessible resources, access control rules, and description of a permission policy. You cannot update the name or scope of a permission policy.
         * - Updating a permission policy affects all application access points (AAPs) that are bound to the permission policy. Exercise caution when you perform this operation.
         *
         * @param request UpdatePolicyRequest
         * @return UpdatePolicyResponse
         */
        public UpdatePolicyResponse UpdatePolicy(UpdatePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdatePolicyWithOptions(request, runtime);
        }

        /**
         * @summary 更新一个权限策略
         *
         * @description - You can update the role-based access control (RBAC) permissions, accessible resources, access control rules, and description of a permission policy. You cannot update the name or scope of a permission policy.
         * - Updating a permission policy affects all application access points (AAPs) that are bound to the permission policy. Exercise caution when you perform this operation.
         *
         * @param request UpdatePolicyRequest
         * @return UpdatePolicyResponse
         */
        public async Task<UpdatePolicyResponse> UpdatePolicyAsync(UpdatePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdatePolicyWithOptionsAsync(request, runtime);
        }

        /**
         * @description When automatic key rotation is enabled, KMS automatically creates a key version after the preset rotation period arrives. In addition, KMS sets the new key version as the primary key version.
         * An automatic key rotation policy cannot be configured for the following keys:
         * *   Asymmetric key
         * *   Service-managed key
         * *   Bring your own key (BYOK) that is imported into KMS
         * *   Key that is not in the **Enabled** state
         * In this example, automatic key rotation is enabled for a CMK whose ID is `1234abcd-12ab-34cd-56ef-12345678****`. The automatic rotation period is 30 days.
         *
         * @param request UpdateRotationPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateRotationPolicyResponse
         */
        public UpdateRotationPolicyResponse UpdateRotationPolicyWithOptions(UpdateRotationPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAutomaticRotation))
            {
                query["EnableAutomaticRotation"] = request.EnableAutomaticRotation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyId))
            {
                query["KeyId"] = request.KeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RotationInterval))
            {
                query["RotationInterval"] = request.RotationInterval;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRotationPolicy",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<UpdateRotationPolicyResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UpdateRotationPolicyResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @description When automatic key rotation is enabled, KMS automatically creates a key version after the preset rotation period arrives. In addition, KMS sets the new key version as the primary key version.
         * An automatic key rotation policy cannot be configured for the following keys:
         * *   Asymmetric key
         * *   Service-managed key
         * *   Bring your own key (BYOK) that is imported into KMS
         * *   Key that is not in the **Enabled** state
         * In this example, automatic key rotation is enabled for a CMK whose ID is `1234abcd-12ab-34cd-56ef-12345678****`. The automatic rotation period is 30 days.
         *
         * @param request UpdateRotationPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateRotationPolicyResponse
         */
        public async Task<UpdateRotationPolicyResponse> UpdateRotationPolicyWithOptionsAsync(UpdateRotationPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAutomaticRotation))
            {
                query["EnableAutomaticRotation"] = request.EnableAutomaticRotation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyId))
            {
                query["KeyId"] = request.KeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RotationInterval))
            {
                query["RotationInterval"] = request.RotationInterval;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRotationPolicy",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<UpdateRotationPolicyResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UpdateRotationPolicyResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @description When automatic key rotation is enabled, KMS automatically creates a key version after the preset rotation period arrives. In addition, KMS sets the new key version as the primary key version.
         * An automatic key rotation policy cannot be configured for the following keys:
         * *   Asymmetric key
         * *   Service-managed key
         * *   Bring your own key (BYOK) that is imported into KMS
         * *   Key that is not in the **Enabled** state
         * In this example, automatic key rotation is enabled for a CMK whose ID is `1234abcd-12ab-34cd-56ef-12345678****`. The automatic rotation period is 30 days.
         *
         * @param request UpdateRotationPolicyRequest
         * @return UpdateRotationPolicyResponse
         */
        public UpdateRotationPolicyResponse UpdateRotationPolicy(UpdateRotationPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateRotationPolicyWithOptions(request, runtime);
        }

        /**
         * @description When automatic key rotation is enabled, KMS automatically creates a key version after the preset rotation period arrives. In addition, KMS sets the new key version as the primary key version.
         * An automatic key rotation policy cannot be configured for the following keys:
         * *   Asymmetric key
         * *   Service-managed key
         * *   Bring your own key (BYOK) that is imported into KMS
         * *   Key that is not in the **Enabled** state
         * In this example, automatic key rotation is enabled for a CMK whose ID is `1234abcd-12ab-34cd-56ef-12345678****`. The automatic rotation period is 30 days.
         *
         * @param request UpdateRotationPolicyRequest
         * @return UpdateRotationPolicyResponse
         */
        public async Task<UpdateRotationPolicyResponse> UpdateRotationPolicyAsync(UpdateRotationPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateRotationPolicyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Updates the metadata of a secret.
         *
         * @description In this example, the metadata of the `secret001` secret is updated. The `Description` parameter is set to `datainfo`.
         *
         * @param request UpdateSecretRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateSecretResponse
         */
        public UpdateSecretResponse UpdateSecretWithOptions(UpdateSecretRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretName))
            {
                query["SecretName"] = request.SecretName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendedConfig))
            {
                query["ExtendedConfig"] = request.ExtendedConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSecret",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<UpdateSecretResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UpdateSecretResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @summary Updates the metadata of a secret.
         *
         * @description In this example, the metadata of the `secret001` secret is updated. The `Description` parameter is set to `datainfo`.
         *
         * @param request UpdateSecretRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateSecretResponse
         */
        public async Task<UpdateSecretResponse> UpdateSecretWithOptionsAsync(UpdateSecretRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretName))
            {
                query["SecretName"] = request.SecretName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendedConfig))
            {
                query["ExtendedConfig"] = request.ExtendedConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSecret",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<UpdateSecretResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UpdateSecretResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @summary Updates the metadata of a secret.
         *
         * @description In this example, the metadata of the `secret001` secret is updated. The `Description` parameter is set to `datainfo`.
         *
         * @param request UpdateSecretRequest
         * @return UpdateSecretResponse
         */
        public UpdateSecretResponse UpdateSecret(UpdateSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateSecretWithOptions(request, runtime);
        }

        /**
         * @summary Updates the metadata of a secret.
         *
         * @description In this example, the metadata of the `secret001` secret is updated. The `Description` parameter is set to `datainfo`.
         *
         * @param request UpdateSecretRequest
         * @return UpdateSecretResponse
         */
        public async Task<UpdateSecretResponse> UpdateSecretAsync(UpdateSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateSecretWithOptionsAsync(request, runtime);
        }

        /**
         * @description After automatic rotation is enabled, Secrets Manager schedules the first automatic rotation by adding the preset rotation interval to the timestamp of the last rotation.
         * Limits: The UpdateSecretRotationPolicy operation cannot be used to update the rotation policy of generic secrets.
         * In this example, the rotation policy of the `RdsSecret/Mysql5.4/MyCred` secret is updated. The following settings are modified:
         * *   The `EnableAutomaticRotation` parameter is set to `true`, which indicates that automatic rotation is enabled.
         * *   The `RotationInterval` parameter is set to `30d`, which indicates that the interval for automatic rotation is 30 days.
         *
         * @param request UpdateSecretRotationPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateSecretRotationPolicyResponse
         */
        public UpdateSecretRotationPolicyResponse UpdateSecretRotationPolicyWithOptions(UpdateSecretRotationPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAutomaticRotation))
            {
                query["EnableAutomaticRotation"] = request.EnableAutomaticRotation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RotationInterval))
            {
                query["RotationInterval"] = request.RotationInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretName))
            {
                query["SecretName"] = request.SecretName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSecretRotationPolicy",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<UpdateSecretRotationPolicyResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UpdateSecretRotationPolicyResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @description After automatic rotation is enabled, Secrets Manager schedules the first automatic rotation by adding the preset rotation interval to the timestamp of the last rotation.
         * Limits: The UpdateSecretRotationPolicy operation cannot be used to update the rotation policy of generic secrets.
         * In this example, the rotation policy of the `RdsSecret/Mysql5.4/MyCred` secret is updated. The following settings are modified:
         * *   The `EnableAutomaticRotation` parameter is set to `true`, which indicates that automatic rotation is enabled.
         * *   The `RotationInterval` parameter is set to `30d`, which indicates that the interval for automatic rotation is 30 days.
         *
         * @param request UpdateSecretRotationPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateSecretRotationPolicyResponse
         */
        public async Task<UpdateSecretRotationPolicyResponse> UpdateSecretRotationPolicyWithOptionsAsync(UpdateSecretRotationPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAutomaticRotation))
            {
                query["EnableAutomaticRotation"] = request.EnableAutomaticRotation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RotationInterval))
            {
                query["RotationInterval"] = request.RotationInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretName))
            {
                query["SecretName"] = request.SecretName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSecretRotationPolicy",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<UpdateSecretRotationPolicyResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UpdateSecretRotationPolicyResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @description After automatic rotation is enabled, Secrets Manager schedules the first automatic rotation by adding the preset rotation interval to the timestamp of the last rotation.
         * Limits: The UpdateSecretRotationPolicy operation cannot be used to update the rotation policy of generic secrets.
         * In this example, the rotation policy of the `RdsSecret/Mysql5.4/MyCred` secret is updated. The following settings are modified:
         * *   The `EnableAutomaticRotation` parameter is set to `true`, which indicates that automatic rotation is enabled.
         * *   The `RotationInterval` parameter is set to `30d`, which indicates that the interval for automatic rotation is 30 days.
         *
         * @param request UpdateSecretRotationPolicyRequest
         * @return UpdateSecretRotationPolicyResponse
         */
        public UpdateSecretRotationPolicyResponse UpdateSecretRotationPolicy(UpdateSecretRotationPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateSecretRotationPolicyWithOptions(request, runtime);
        }

        /**
         * @description After automatic rotation is enabled, Secrets Manager schedules the first automatic rotation by adding the preset rotation interval to the timestamp of the last rotation.
         * Limits: The UpdateSecretRotationPolicy operation cannot be used to update the rotation policy of generic secrets.
         * In this example, the rotation policy of the `RdsSecret/Mysql5.4/MyCred` secret is updated. The following settings are modified:
         * *   The `EnableAutomaticRotation` parameter is set to `true`, which indicates that automatic rotation is enabled.
         * *   The `RotationInterval` parameter is set to `30d`, which indicates that the interval for automatic rotation is 30 days.
         *
         * @param request UpdateSecretRotationPolicyRequest
         * @return UpdateSecretRotationPolicyResponse
         */
        public async Task<UpdateSecretRotationPolicyResponse> UpdateSecretRotationPolicyAsync(UpdateSecretRotationPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateSecretRotationPolicyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary UpdateSecretVersionStage
         *
         * @description Updates the stage label that marks a secret version.
         *
         * @param request UpdateSecretVersionStageRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateSecretVersionStageResponse
         */
        public UpdateSecretVersionStageResponse UpdateSecretVersionStageWithOptions(UpdateSecretVersionStageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MoveToVersion))
            {
                query["MoveToVersion"] = request.MoveToVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemoveFromVersion))
            {
                query["RemoveFromVersion"] = request.RemoveFromVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretName))
            {
                query["SecretName"] = request.SecretName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionStage))
            {
                query["VersionStage"] = request.VersionStage;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSecretVersionStage",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<UpdateSecretVersionStageResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UpdateSecretVersionStageResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @summary UpdateSecretVersionStage
         *
         * @description Updates the stage label that marks a secret version.
         *
         * @param request UpdateSecretVersionStageRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateSecretVersionStageResponse
         */
        public async Task<UpdateSecretVersionStageResponse> UpdateSecretVersionStageWithOptionsAsync(UpdateSecretVersionStageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MoveToVersion))
            {
                query["MoveToVersion"] = request.MoveToVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemoveFromVersion))
            {
                query["RemoveFromVersion"] = request.RemoveFromVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretName))
            {
                query["SecretName"] = request.SecretName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionStage))
            {
                query["VersionStage"] = request.VersionStage;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSecretVersionStage",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<UpdateSecretVersionStageResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UpdateSecretVersionStageResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @summary UpdateSecretVersionStage
         *
         * @description Updates the stage label that marks a secret version.
         *
         * @param request UpdateSecretVersionStageRequest
         * @return UpdateSecretVersionStageResponse
         */
        public UpdateSecretVersionStageResponse UpdateSecretVersionStage(UpdateSecretVersionStageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateSecretVersionStageWithOptions(request, runtime);
        }

        /**
         * @summary UpdateSecretVersionStage
         *
         * @description Updates the stage label that marks a secret version.
         *
         * @param request UpdateSecretVersionStageRequest
         * @return UpdateSecretVersionStageResponse
         */
        public async Task<UpdateSecretVersionStageResponse> UpdateSecretVersionStageAsync(UpdateSecretVersionStageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateSecretVersionStageWithOptionsAsync(request, runtime);
        }

        /**
         * @description In this example, a certificate issued by a CA is imported into Certificates Manager. The ID of the certificate in Certificates Manager is `12345678-1234-1234-1234-12345678****`.
         *
         * @param request UploadCertificateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UploadCertificateResponse
         */
        public UploadCertificateResponse UploadCertificateWithOptions(UploadCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Certificate))
            {
                query["Certificate"] = request.Certificate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertificateChain))
            {
                query["CertificateChain"] = request.CertificateChain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertificateId))
            {
                query["CertificateId"] = request.CertificateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadCertificate",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<UploadCertificateResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UploadCertificateResponse>(Execute(params_, req, runtime));
            }
        }

        /**
         * @description In this example, a certificate issued by a CA is imported into Certificates Manager. The ID of the certificate in Certificates Manager is `12345678-1234-1234-1234-12345678****`.
         *
         * @param request UploadCertificateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UploadCertificateResponse
         */
        public async Task<UploadCertificateResponse> UploadCertificateWithOptionsAsync(UploadCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Certificate))
            {
                query["Certificate"] = request.Certificate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertificateChain))
            {
                query["CertificateChain"] = request.CertificateChain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertificateId))
            {
                query["CertificateId"] = request.CertificateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadCertificate",
                Version = "2016-01-20",
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
                return TeaModel.ToObject<UploadCertificateResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UploadCertificateResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /**
         * @description In this example, a certificate issued by a CA is imported into Certificates Manager. The ID of the certificate in Certificates Manager is `12345678-1234-1234-1234-12345678****`.
         *
         * @param request UploadCertificateRequest
         * @return UploadCertificateResponse
         */
        public UploadCertificateResponse UploadCertificate(UploadCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UploadCertificateWithOptions(request, runtime);
        }

        /**
         * @description In this example, a certificate issued by a CA is imported into Certificates Manager. The ID of the certificate in Certificates Manager is `12345678-1234-1234-1234-12345678****`.
         *
         * @param request UploadCertificateRequest
         * @return UploadCertificateResponse
         */
        public async Task<UploadCertificateResponse> UploadCertificateAsync(UploadCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UploadCertificateWithOptionsAsync(request, runtime);
        }

    }
}
