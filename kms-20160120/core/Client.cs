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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Decrypts data by using an asymmetric key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation supports only asymmetric keys for which the <b>Usage</b> parameter is set to <b>ENCRYPT/DECRYPT</b>. The following table lists supported encryption algorithms. </para>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>KeySpec</th>
        /// <th>Algorithm</th>
        /// <th>Description</th>
        /// <th>Maximum length in bytes</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>RSA_2048</td>
        /// <td>RSAES_OAEP_SHA_256</td>
        /// <td>RSAES-OAEP using SHA-256 and MGF1 with SHA-256</td>
        /// <td>256</td>
        /// </tr>
        /// <tr>
        /// <td>RSA_2048</td>
        /// <td>RSAES_OAEP_SHA_1</td>
        /// <td>RSAES-OAEP using SHA1 and MGF1 with SHA1</td>
        /// <td>256</td>
        /// </tr>
        /// <tr>
        /// <td>RSA_3072</td>
        /// <td>RSAES_OAEP_SHA_256</td>
        /// <td>RSAES-OAEP using SHA-256 and MGF1 with SHA-256</td>
        /// <td>384</td>
        /// </tr>
        /// <tr>
        /// <td>RSA_3072</td>
        /// <td>RSAES_OAEP_SHA_1</td>
        /// <td>RSAES-OAEP using SHA1 and MGF1 with SHA1</td>
        /// <td>384</td>
        /// </tr>
        /// <tr>
        /// <td>EC_SM2</td>
        /// <td>SM2PKE</td>
        /// <td>SM2 public key encryption algorithm based on elliptic curves</td>
        /// <td>6144</td>
        /// </tr>
        /// <tr>
        /// <td>In this example, the asymmetric key whose ID is <c>5c438b18-05be-40ad-b6c2-3be6752c****</c> and version ID is <c>2ab1a983-7072-4bbc-a582-584b5bd8****</c> and the decryption algorithm <c>RSAES_OAEP_SHA_1</c> are used to decrypt the ciphertext <c>BQKP+1zK6+ZEMxTP5qaVzcsgXtWplYBKm0NXdSnB5FzliFxE1bSiu4dnEIlca2JpeH7yz1/S6fed630H+hIH6DoM25fTLNcKj+mFB0Xnh9m2+HN59Mn4qyTfcUeadnfCXSWcGBouhXFwcdd2rJ3n337bzTf4jm659gZu3L0i6PLuxM9p7mqdwO0cKJPfGVfhnfMz+f4alMg79WB/NNyE2lyX7/qxvV49ObNrrJbKSFiz8Djocaf0IESNLMbfYI5bXjWkJlX92DQbKhibtQW8ZOJ//ZC6t0AWcUoKL6QDm/dg5koQalcleRinpB+QadFm894sLbVZ9+N4GVsv1W****==</c>.</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// </description>
        /// 
        /// <param name="request">
        /// AsymmetricDecryptRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AsymmetricDecryptResponse
        /// </returns>
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
            return TeaModel.ToObject<AsymmetricDecryptResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Decrypts data by using an asymmetric key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation supports only asymmetric keys for which the <b>Usage</b> parameter is set to <b>ENCRYPT/DECRYPT</b>. The following table lists supported encryption algorithms. </para>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>KeySpec</th>
        /// <th>Algorithm</th>
        /// <th>Description</th>
        /// <th>Maximum length in bytes</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>RSA_2048</td>
        /// <td>RSAES_OAEP_SHA_256</td>
        /// <td>RSAES-OAEP using SHA-256 and MGF1 with SHA-256</td>
        /// <td>256</td>
        /// </tr>
        /// <tr>
        /// <td>RSA_2048</td>
        /// <td>RSAES_OAEP_SHA_1</td>
        /// <td>RSAES-OAEP using SHA1 and MGF1 with SHA1</td>
        /// <td>256</td>
        /// </tr>
        /// <tr>
        /// <td>RSA_3072</td>
        /// <td>RSAES_OAEP_SHA_256</td>
        /// <td>RSAES-OAEP using SHA-256 and MGF1 with SHA-256</td>
        /// <td>384</td>
        /// </tr>
        /// <tr>
        /// <td>RSA_3072</td>
        /// <td>RSAES_OAEP_SHA_1</td>
        /// <td>RSAES-OAEP using SHA1 and MGF1 with SHA1</td>
        /// <td>384</td>
        /// </tr>
        /// <tr>
        /// <td>EC_SM2</td>
        /// <td>SM2PKE</td>
        /// <td>SM2 public key encryption algorithm based on elliptic curves</td>
        /// <td>6144</td>
        /// </tr>
        /// <tr>
        /// <td>In this example, the asymmetric key whose ID is <c>5c438b18-05be-40ad-b6c2-3be6752c****</c> and version ID is <c>2ab1a983-7072-4bbc-a582-584b5bd8****</c> and the decryption algorithm <c>RSAES_OAEP_SHA_1</c> are used to decrypt the ciphertext <c>BQKP+1zK6+ZEMxTP5qaVzcsgXtWplYBKm0NXdSnB5FzliFxE1bSiu4dnEIlca2JpeH7yz1/S6fed630H+hIH6DoM25fTLNcKj+mFB0Xnh9m2+HN59Mn4qyTfcUeadnfCXSWcGBouhXFwcdd2rJ3n337bzTf4jm659gZu3L0i6PLuxM9p7mqdwO0cKJPfGVfhnfMz+f4alMg79WB/NNyE2lyX7/qxvV49ObNrrJbKSFiz8Djocaf0IESNLMbfYI5bXjWkJlX92DQbKhibtQW8ZOJ//ZC6t0AWcUoKL6QDm/dg5koQalcleRinpB+QadFm894sLbVZ9+N4GVsv1W****==</c>.</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// </description>
        /// 
        /// <param name="request">
        /// AsymmetricDecryptRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AsymmetricDecryptResponse
        /// </returns>
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
            return TeaModel.ToObject<AsymmetricDecryptResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Decrypts data by using an asymmetric key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation supports only asymmetric keys for which the <b>Usage</b> parameter is set to <b>ENCRYPT/DECRYPT</b>. The following table lists supported encryption algorithms. </para>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>KeySpec</th>
        /// <th>Algorithm</th>
        /// <th>Description</th>
        /// <th>Maximum length in bytes</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>RSA_2048</td>
        /// <td>RSAES_OAEP_SHA_256</td>
        /// <td>RSAES-OAEP using SHA-256 and MGF1 with SHA-256</td>
        /// <td>256</td>
        /// </tr>
        /// <tr>
        /// <td>RSA_2048</td>
        /// <td>RSAES_OAEP_SHA_1</td>
        /// <td>RSAES-OAEP using SHA1 and MGF1 with SHA1</td>
        /// <td>256</td>
        /// </tr>
        /// <tr>
        /// <td>RSA_3072</td>
        /// <td>RSAES_OAEP_SHA_256</td>
        /// <td>RSAES-OAEP using SHA-256 and MGF1 with SHA-256</td>
        /// <td>384</td>
        /// </tr>
        /// <tr>
        /// <td>RSA_3072</td>
        /// <td>RSAES_OAEP_SHA_1</td>
        /// <td>RSAES-OAEP using SHA1 and MGF1 with SHA1</td>
        /// <td>384</td>
        /// </tr>
        /// <tr>
        /// <td>EC_SM2</td>
        /// <td>SM2PKE</td>
        /// <td>SM2 public key encryption algorithm based on elliptic curves</td>
        /// <td>6144</td>
        /// </tr>
        /// <tr>
        /// <td>In this example, the asymmetric key whose ID is <c>5c438b18-05be-40ad-b6c2-3be6752c****</c> and version ID is <c>2ab1a983-7072-4bbc-a582-584b5bd8****</c> and the decryption algorithm <c>RSAES_OAEP_SHA_1</c> are used to decrypt the ciphertext <c>BQKP+1zK6+ZEMxTP5qaVzcsgXtWplYBKm0NXdSnB5FzliFxE1bSiu4dnEIlca2JpeH7yz1/S6fed630H+hIH6DoM25fTLNcKj+mFB0Xnh9m2+HN59Mn4qyTfcUeadnfCXSWcGBouhXFwcdd2rJ3n337bzTf4jm659gZu3L0i6PLuxM9p7mqdwO0cKJPfGVfhnfMz+f4alMg79WB/NNyE2lyX7/qxvV49ObNrrJbKSFiz8Djocaf0IESNLMbfYI5bXjWkJlX92DQbKhibtQW8ZOJ//ZC6t0AWcUoKL6QDm/dg5koQalcleRinpB+QadFm894sLbVZ9+N4GVsv1W****==</c>.</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// </description>
        /// 
        /// <param name="request">
        /// AsymmetricDecryptRequest
        /// </param>
        /// 
        /// <returns>
        /// AsymmetricDecryptResponse
        /// </returns>
        public AsymmetricDecryptResponse AsymmetricDecrypt(AsymmetricDecryptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AsymmetricDecryptWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Decrypts data by using an asymmetric key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation supports only asymmetric keys for which the <b>Usage</b> parameter is set to <b>ENCRYPT/DECRYPT</b>. The following table lists supported encryption algorithms. </para>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>KeySpec</th>
        /// <th>Algorithm</th>
        /// <th>Description</th>
        /// <th>Maximum length in bytes</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>RSA_2048</td>
        /// <td>RSAES_OAEP_SHA_256</td>
        /// <td>RSAES-OAEP using SHA-256 and MGF1 with SHA-256</td>
        /// <td>256</td>
        /// </tr>
        /// <tr>
        /// <td>RSA_2048</td>
        /// <td>RSAES_OAEP_SHA_1</td>
        /// <td>RSAES-OAEP using SHA1 and MGF1 with SHA1</td>
        /// <td>256</td>
        /// </tr>
        /// <tr>
        /// <td>RSA_3072</td>
        /// <td>RSAES_OAEP_SHA_256</td>
        /// <td>RSAES-OAEP using SHA-256 and MGF1 with SHA-256</td>
        /// <td>384</td>
        /// </tr>
        /// <tr>
        /// <td>RSA_3072</td>
        /// <td>RSAES_OAEP_SHA_1</td>
        /// <td>RSAES-OAEP using SHA1 and MGF1 with SHA1</td>
        /// <td>384</td>
        /// </tr>
        /// <tr>
        /// <td>EC_SM2</td>
        /// <td>SM2PKE</td>
        /// <td>SM2 public key encryption algorithm based on elliptic curves</td>
        /// <td>6144</td>
        /// </tr>
        /// <tr>
        /// <td>In this example, the asymmetric key whose ID is <c>5c438b18-05be-40ad-b6c2-3be6752c****</c> and version ID is <c>2ab1a983-7072-4bbc-a582-584b5bd8****</c> and the decryption algorithm <c>RSAES_OAEP_SHA_1</c> are used to decrypt the ciphertext <c>BQKP+1zK6+ZEMxTP5qaVzcsgXtWplYBKm0NXdSnB5FzliFxE1bSiu4dnEIlca2JpeH7yz1/S6fed630H+hIH6DoM25fTLNcKj+mFB0Xnh9m2+HN59Mn4qyTfcUeadnfCXSWcGBouhXFwcdd2rJ3n337bzTf4jm659gZu3L0i6PLuxM9p7mqdwO0cKJPfGVfhnfMz+f4alMg79WB/NNyE2lyX7/qxvV49ObNrrJbKSFiz8Djocaf0IESNLMbfYI5bXjWkJlX92DQbKhibtQW8ZOJ//ZC6t0AWcUoKL6QDm/dg5koQalcleRinpB+QadFm894sLbVZ9+N4GVsv1W****==</c>.</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// </description>
        /// 
        /// <param name="request">
        /// AsymmetricDecryptRequest
        /// </param>
        /// 
        /// <returns>
        /// AsymmetricDecryptResponse
        /// </returns>
        public async Task<AsymmetricDecryptResponse> AsymmetricDecryptAsync(AsymmetricDecryptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AsymmetricDecryptWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Encrypts data by using an asymmetric customer master key (CMK).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is supported only for asymmetric keys for which the <b>Usage</b> parameter is set to <b>ENCRYPT/DECRYPT</b>. The following table lists the supported encryption algorithms: </para>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>KeySpec</th>
        /// <th>Algorithm</th>
        /// <th>Description</th>
        /// <th>Maximum number of bytes that can be encrypted</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>RSA_2048</td>
        /// <td>RSAES_OAEP_SHA_256</td>
        /// <td>RSAES-OAEP using SHA-256 and MGF1 with SHA-256</td>
        /// <td>190</td>
        /// </tr>
        /// <tr>
        /// <td>RSA_2048</td>
        /// <td>RSAES_OAEP_SHA_1</td>
        /// <td>RSAES-OAEP using SHA1 and MGF1 with SHA1</td>
        /// <td>214</td>
        /// </tr>
        /// <tr>
        /// <td>RSA_3072</td>
        /// <td>RSAES_OAEP_SHA_256</td>
        /// <td>RSAES-OAEP using SHA-256 and MGF1 with SHA-256</td>
        /// <td>318</td>
        /// </tr>
        /// <tr>
        /// <td>RSA_3072</td>
        /// <td>RSAES_OAEP_SHA_1</td>
        /// <td>RSAES-OAEP using SHA1 and MGF1 with SHA1</td>
        /// <td>342</td>
        /// </tr>
        /// <tr>
        /// <td>EC_SM2</td>
        /// <td>SM2PKE</td>
        /// <td>SM2 public key encryption algorithm based on elliptic curves</td>
        /// <td>6047</td>
        /// </tr>
        /// <tr>
        /// <td>You can use the asymmetric CMK whose ID is <c>5c438b18-05be-40ad-b6c2-3be6752c****</c> and version ID is <c>2ab1a983-7072-4bbc-a582-584b5bd8****</c> and the algorithm <c>RSAES_OAEP_SHA_1</c> to encrypt the plaintext <c>SGVsbG8gd29ybGQ=</c> based on the parameter settings provided in this topic.</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// </description>
        /// 
        /// <param name="request">
        /// AsymmetricEncryptRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AsymmetricEncryptResponse
        /// </returns>
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
            return TeaModel.ToObject<AsymmetricEncryptResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Encrypts data by using an asymmetric customer master key (CMK).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is supported only for asymmetric keys for which the <b>Usage</b> parameter is set to <b>ENCRYPT/DECRYPT</b>. The following table lists the supported encryption algorithms: </para>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>KeySpec</th>
        /// <th>Algorithm</th>
        /// <th>Description</th>
        /// <th>Maximum number of bytes that can be encrypted</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>RSA_2048</td>
        /// <td>RSAES_OAEP_SHA_256</td>
        /// <td>RSAES-OAEP using SHA-256 and MGF1 with SHA-256</td>
        /// <td>190</td>
        /// </tr>
        /// <tr>
        /// <td>RSA_2048</td>
        /// <td>RSAES_OAEP_SHA_1</td>
        /// <td>RSAES-OAEP using SHA1 and MGF1 with SHA1</td>
        /// <td>214</td>
        /// </tr>
        /// <tr>
        /// <td>RSA_3072</td>
        /// <td>RSAES_OAEP_SHA_256</td>
        /// <td>RSAES-OAEP using SHA-256 and MGF1 with SHA-256</td>
        /// <td>318</td>
        /// </tr>
        /// <tr>
        /// <td>RSA_3072</td>
        /// <td>RSAES_OAEP_SHA_1</td>
        /// <td>RSAES-OAEP using SHA1 and MGF1 with SHA1</td>
        /// <td>342</td>
        /// </tr>
        /// <tr>
        /// <td>EC_SM2</td>
        /// <td>SM2PKE</td>
        /// <td>SM2 public key encryption algorithm based on elliptic curves</td>
        /// <td>6047</td>
        /// </tr>
        /// <tr>
        /// <td>You can use the asymmetric CMK whose ID is <c>5c438b18-05be-40ad-b6c2-3be6752c****</c> and version ID is <c>2ab1a983-7072-4bbc-a582-584b5bd8****</c> and the algorithm <c>RSAES_OAEP_SHA_1</c> to encrypt the plaintext <c>SGVsbG8gd29ybGQ=</c> based on the parameter settings provided in this topic.</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// </description>
        /// 
        /// <param name="request">
        /// AsymmetricEncryptRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AsymmetricEncryptResponse
        /// </returns>
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
            return TeaModel.ToObject<AsymmetricEncryptResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Encrypts data by using an asymmetric customer master key (CMK).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is supported only for asymmetric keys for which the <b>Usage</b> parameter is set to <b>ENCRYPT/DECRYPT</b>. The following table lists the supported encryption algorithms: </para>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>KeySpec</th>
        /// <th>Algorithm</th>
        /// <th>Description</th>
        /// <th>Maximum number of bytes that can be encrypted</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>RSA_2048</td>
        /// <td>RSAES_OAEP_SHA_256</td>
        /// <td>RSAES-OAEP using SHA-256 and MGF1 with SHA-256</td>
        /// <td>190</td>
        /// </tr>
        /// <tr>
        /// <td>RSA_2048</td>
        /// <td>RSAES_OAEP_SHA_1</td>
        /// <td>RSAES-OAEP using SHA1 and MGF1 with SHA1</td>
        /// <td>214</td>
        /// </tr>
        /// <tr>
        /// <td>RSA_3072</td>
        /// <td>RSAES_OAEP_SHA_256</td>
        /// <td>RSAES-OAEP using SHA-256 and MGF1 with SHA-256</td>
        /// <td>318</td>
        /// </tr>
        /// <tr>
        /// <td>RSA_3072</td>
        /// <td>RSAES_OAEP_SHA_1</td>
        /// <td>RSAES-OAEP using SHA1 and MGF1 with SHA1</td>
        /// <td>342</td>
        /// </tr>
        /// <tr>
        /// <td>EC_SM2</td>
        /// <td>SM2PKE</td>
        /// <td>SM2 public key encryption algorithm based on elliptic curves</td>
        /// <td>6047</td>
        /// </tr>
        /// <tr>
        /// <td>You can use the asymmetric CMK whose ID is <c>5c438b18-05be-40ad-b6c2-3be6752c****</c> and version ID is <c>2ab1a983-7072-4bbc-a582-584b5bd8****</c> and the algorithm <c>RSAES_OAEP_SHA_1</c> to encrypt the plaintext <c>SGVsbG8gd29ybGQ=</c> based on the parameter settings provided in this topic.</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// </description>
        /// 
        /// <param name="request">
        /// AsymmetricEncryptRequest
        /// </param>
        /// 
        /// <returns>
        /// AsymmetricEncryptResponse
        /// </returns>
        public AsymmetricEncryptResponse AsymmetricEncrypt(AsymmetricEncryptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AsymmetricEncryptWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Encrypts data by using an asymmetric customer master key (CMK).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is supported only for asymmetric keys for which the <b>Usage</b> parameter is set to <b>ENCRYPT/DECRYPT</b>. The following table lists the supported encryption algorithms: </para>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>KeySpec</th>
        /// <th>Algorithm</th>
        /// <th>Description</th>
        /// <th>Maximum number of bytes that can be encrypted</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>RSA_2048</td>
        /// <td>RSAES_OAEP_SHA_256</td>
        /// <td>RSAES-OAEP using SHA-256 and MGF1 with SHA-256</td>
        /// <td>190</td>
        /// </tr>
        /// <tr>
        /// <td>RSA_2048</td>
        /// <td>RSAES_OAEP_SHA_1</td>
        /// <td>RSAES-OAEP using SHA1 and MGF1 with SHA1</td>
        /// <td>214</td>
        /// </tr>
        /// <tr>
        /// <td>RSA_3072</td>
        /// <td>RSAES_OAEP_SHA_256</td>
        /// <td>RSAES-OAEP using SHA-256 and MGF1 with SHA-256</td>
        /// <td>318</td>
        /// </tr>
        /// <tr>
        /// <td>RSA_3072</td>
        /// <td>RSAES_OAEP_SHA_1</td>
        /// <td>RSAES-OAEP using SHA1 and MGF1 with SHA1</td>
        /// <td>342</td>
        /// </tr>
        /// <tr>
        /// <td>EC_SM2</td>
        /// <td>SM2PKE</td>
        /// <td>SM2 public key encryption algorithm based on elliptic curves</td>
        /// <td>6047</td>
        /// </tr>
        /// <tr>
        /// <td>You can use the asymmetric CMK whose ID is <c>5c438b18-05be-40ad-b6c2-3be6752c****</c> and version ID is <c>2ab1a983-7072-4bbc-a582-584b5bd8****</c> and the algorithm <c>RSAES_OAEP_SHA_1</c> to encrypt the plaintext <c>SGVsbG8gd29ybGQ=</c> based on the parameter settings provided in this topic.</td>
        /// <td></td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// </description>
        /// 
        /// <param name="request">
        /// AsymmetricEncryptRequest
        /// </param>
        /// 
        /// <returns>
        /// AsymmetricEncryptResponse
        /// </returns>
        public async Task<AsymmetricEncryptResponse> AsymmetricEncryptAsync(AsymmetricEncryptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AsymmetricEncryptWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>AsymmetricSign</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Generates a signature by using an asymmetric key.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AsymmetricSignRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AsymmetricSignResponse
        /// </returns>
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
            return TeaModel.ToObject<AsymmetricSignResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>AsymmetricSign</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Generates a signature by using an asymmetric key.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AsymmetricSignRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AsymmetricSignResponse
        /// </returns>
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
            return TeaModel.ToObject<AsymmetricSignResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>AsymmetricSign</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Generates a signature by using an asymmetric key.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AsymmetricSignRequest
        /// </param>
        /// 
        /// <returns>
        /// AsymmetricSignResponse
        /// </returns>
        public AsymmetricSignResponse AsymmetricSign(AsymmetricSignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AsymmetricSignWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>AsymmetricSign</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Generates a signature by using an asymmetric key.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AsymmetricSignRequest
        /// </param>
        /// 
        /// <returns>
        /// AsymmetricSignResponse
        /// </returns>
        public async Task<AsymmetricSignResponse> AsymmetricSignAsync(AsymmetricSignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AsymmetricSignWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Verifies a signature by using an asymmetric key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation supports only asymmetric keys for which the <b>Usage</b> parameter is set to <b>SIGN/VERIFY</b>. The following table describes the supported signature algorithms. </para>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>KeySpec</th>
        /// <th>Algorithm</th>
        /// <th>Description</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>RSA_2048</td>
        /// <td>RSA_PSS_SHA_256</td>
        /// <td>RSASSA-PSS using SHA-256 and MGF1 with SHA-256</td>
        /// </tr>
        /// <tr>
        /// <td>RSA_2048</td>
        /// <td>RSA_PKCS1_SHA_256</td>
        /// <td>RSASSA-PKCS1-v1_5 using SHA-256</td>
        /// </tr>
        /// <tr>
        /// <td>RSA_3072</td>
        /// <td>RSA_PSS_SHA_256</td>
        /// <td>RSASSA-PSS using SHA-256 and MGF1 with SHA-256</td>
        /// </tr>
        /// <tr>
        /// <td>RSA_3072</td>
        /// <td>RSA_PKCS1_SHA_256</td>
        /// <td>RSASSA-PKCS1-v1_5 using SHA-256</td>
        /// </tr>
        /// <tr>
        /// <td>EC_P256</td>
        /// <td>ECDSA_SHA_256</td>
        /// <td>ECDSA on the P-256 Curve(secp256r1) with a SHA-256 digest</td>
        /// </tr>
        /// <tr>
        /// <td>EC_P256K</td>
        /// <td>ECDSA_SHA_256</td>
        /// <td>ECDSA on the P-256K Curve(secp256k1) with a SHA-256 digest</td>
        /// </tr>
        /// <tr>
        /// <td>EC_SM2</td>
        /// <td>SM2DSA</td>
        /// <td>SM2 elliptic curve public key encryption algorithm</td>
        /// </tr>
        /// </tbody></table>
        /// <remarks>
        /// <para> When you calculate the SM2 signature based on GB/T 32918, the <b>Digest</b> parameter is used to calculate the digest value of the combination of Z(A) and M, rather than the SM3 digest value. M indicates the original message to be signed. Z(A) indicates the hash value for User A. The hash value is defined in GB/T 32918.  In this example, the asymmetric key whose ID is <c>5c438b18-05be-40ad-b6c2-3be6752c****</c> and version ID is <c>2ab1a983-7072-4bbc-a582-584b5bd8****</c> and the signature algorithm RSA_PSS_SHA_256 are used to verify the signature <c>M2CceNZH00ZgL9ED/ZHFp21YRAvYeZHknJUc207OCZ0N9wNn9As4z2bON3FF3je+1Nu+2+/8Zj50HpMTpzYpMp2R93cYmACCmhaYoKydxylbyGzJR8y9likZRCrkD38lRoS40aBBvv/6iRKzQuo9EGYVcel36cMNg00VmYNBy3pa1rwg3gA4l3cy6kjayZja1WGPkVhrVKsrJMdbpl0ApLjXKuD8rw1n1XLCwCUEL5eLPljTZaAveqdOFQOiZnZEGI27qIiZe7I1fN8tcz6anS/gTM7xRKE++5egEvRWlTQQTJeApnPSiUPA+8ZykNdelQsOQh5SrGoyI4A5pq****==</c> of the digest <c>ZOyIygCyaOW6GjVnihtTFtIS9PNmskdyMlNKiuyjfzw=</c>.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// AsymmetricVerifyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AsymmetricVerifyResponse
        /// </returns>
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
            return TeaModel.ToObject<AsymmetricVerifyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Verifies a signature by using an asymmetric key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation supports only asymmetric keys for which the <b>Usage</b> parameter is set to <b>SIGN/VERIFY</b>. The following table describes the supported signature algorithms. </para>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>KeySpec</th>
        /// <th>Algorithm</th>
        /// <th>Description</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>RSA_2048</td>
        /// <td>RSA_PSS_SHA_256</td>
        /// <td>RSASSA-PSS using SHA-256 and MGF1 with SHA-256</td>
        /// </tr>
        /// <tr>
        /// <td>RSA_2048</td>
        /// <td>RSA_PKCS1_SHA_256</td>
        /// <td>RSASSA-PKCS1-v1_5 using SHA-256</td>
        /// </tr>
        /// <tr>
        /// <td>RSA_3072</td>
        /// <td>RSA_PSS_SHA_256</td>
        /// <td>RSASSA-PSS using SHA-256 and MGF1 with SHA-256</td>
        /// </tr>
        /// <tr>
        /// <td>RSA_3072</td>
        /// <td>RSA_PKCS1_SHA_256</td>
        /// <td>RSASSA-PKCS1-v1_5 using SHA-256</td>
        /// </tr>
        /// <tr>
        /// <td>EC_P256</td>
        /// <td>ECDSA_SHA_256</td>
        /// <td>ECDSA on the P-256 Curve(secp256r1) with a SHA-256 digest</td>
        /// </tr>
        /// <tr>
        /// <td>EC_P256K</td>
        /// <td>ECDSA_SHA_256</td>
        /// <td>ECDSA on the P-256K Curve(secp256k1) with a SHA-256 digest</td>
        /// </tr>
        /// <tr>
        /// <td>EC_SM2</td>
        /// <td>SM2DSA</td>
        /// <td>SM2 elliptic curve public key encryption algorithm</td>
        /// </tr>
        /// </tbody></table>
        /// <remarks>
        /// <para> When you calculate the SM2 signature based on GB/T 32918, the <b>Digest</b> parameter is used to calculate the digest value of the combination of Z(A) and M, rather than the SM3 digest value. M indicates the original message to be signed. Z(A) indicates the hash value for User A. The hash value is defined in GB/T 32918.  In this example, the asymmetric key whose ID is <c>5c438b18-05be-40ad-b6c2-3be6752c****</c> and version ID is <c>2ab1a983-7072-4bbc-a582-584b5bd8****</c> and the signature algorithm RSA_PSS_SHA_256 are used to verify the signature <c>M2CceNZH00ZgL9ED/ZHFp21YRAvYeZHknJUc207OCZ0N9wNn9As4z2bON3FF3je+1Nu+2+/8Zj50HpMTpzYpMp2R93cYmACCmhaYoKydxylbyGzJR8y9likZRCrkD38lRoS40aBBvv/6iRKzQuo9EGYVcel36cMNg00VmYNBy3pa1rwg3gA4l3cy6kjayZja1WGPkVhrVKsrJMdbpl0ApLjXKuD8rw1n1XLCwCUEL5eLPljTZaAveqdOFQOiZnZEGI27qIiZe7I1fN8tcz6anS/gTM7xRKE++5egEvRWlTQQTJeApnPSiUPA+8ZykNdelQsOQh5SrGoyI4A5pq****==</c> of the digest <c>ZOyIygCyaOW6GjVnihtTFtIS9PNmskdyMlNKiuyjfzw=</c>.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// AsymmetricVerifyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AsymmetricVerifyResponse
        /// </returns>
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
            return TeaModel.ToObject<AsymmetricVerifyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Verifies a signature by using an asymmetric key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation supports only asymmetric keys for which the <b>Usage</b> parameter is set to <b>SIGN/VERIFY</b>. The following table describes the supported signature algorithms. </para>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>KeySpec</th>
        /// <th>Algorithm</th>
        /// <th>Description</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>RSA_2048</td>
        /// <td>RSA_PSS_SHA_256</td>
        /// <td>RSASSA-PSS using SHA-256 and MGF1 with SHA-256</td>
        /// </tr>
        /// <tr>
        /// <td>RSA_2048</td>
        /// <td>RSA_PKCS1_SHA_256</td>
        /// <td>RSASSA-PKCS1-v1_5 using SHA-256</td>
        /// </tr>
        /// <tr>
        /// <td>RSA_3072</td>
        /// <td>RSA_PSS_SHA_256</td>
        /// <td>RSASSA-PSS using SHA-256 and MGF1 with SHA-256</td>
        /// </tr>
        /// <tr>
        /// <td>RSA_3072</td>
        /// <td>RSA_PKCS1_SHA_256</td>
        /// <td>RSASSA-PKCS1-v1_5 using SHA-256</td>
        /// </tr>
        /// <tr>
        /// <td>EC_P256</td>
        /// <td>ECDSA_SHA_256</td>
        /// <td>ECDSA on the P-256 Curve(secp256r1) with a SHA-256 digest</td>
        /// </tr>
        /// <tr>
        /// <td>EC_P256K</td>
        /// <td>ECDSA_SHA_256</td>
        /// <td>ECDSA on the P-256K Curve(secp256k1) with a SHA-256 digest</td>
        /// </tr>
        /// <tr>
        /// <td>EC_SM2</td>
        /// <td>SM2DSA</td>
        /// <td>SM2 elliptic curve public key encryption algorithm</td>
        /// </tr>
        /// </tbody></table>
        /// <remarks>
        /// <para> When you calculate the SM2 signature based on GB/T 32918, the <b>Digest</b> parameter is used to calculate the digest value of the combination of Z(A) and M, rather than the SM3 digest value. M indicates the original message to be signed. Z(A) indicates the hash value for User A. The hash value is defined in GB/T 32918.  In this example, the asymmetric key whose ID is <c>5c438b18-05be-40ad-b6c2-3be6752c****</c> and version ID is <c>2ab1a983-7072-4bbc-a582-584b5bd8****</c> and the signature algorithm RSA_PSS_SHA_256 are used to verify the signature <c>M2CceNZH00ZgL9ED/ZHFp21YRAvYeZHknJUc207OCZ0N9wNn9As4z2bON3FF3je+1Nu+2+/8Zj50HpMTpzYpMp2R93cYmACCmhaYoKydxylbyGzJR8y9likZRCrkD38lRoS40aBBvv/6iRKzQuo9EGYVcel36cMNg00VmYNBy3pa1rwg3gA4l3cy6kjayZja1WGPkVhrVKsrJMdbpl0ApLjXKuD8rw1n1XLCwCUEL5eLPljTZaAveqdOFQOiZnZEGI27qIiZe7I1fN8tcz6anS/gTM7xRKE++5egEvRWlTQQTJeApnPSiUPA+8ZykNdelQsOQh5SrGoyI4A5pq****==</c> of the digest <c>ZOyIygCyaOW6GjVnihtTFtIS9PNmskdyMlNKiuyjfzw=</c>.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// AsymmetricVerifyRequest
        /// </param>
        /// 
        /// <returns>
        /// AsymmetricVerifyResponse
        /// </returns>
        public AsymmetricVerifyResponse AsymmetricVerify(AsymmetricVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AsymmetricVerifyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Verifies a signature by using an asymmetric key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation supports only asymmetric keys for which the <b>Usage</b> parameter is set to <b>SIGN/VERIFY</b>. The following table describes the supported signature algorithms. </para>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>KeySpec</th>
        /// <th>Algorithm</th>
        /// <th>Description</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>RSA_2048</td>
        /// <td>RSA_PSS_SHA_256</td>
        /// <td>RSASSA-PSS using SHA-256 and MGF1 with SHA-256</td>
        /// </tr>
        /// <tr>
        /// <td>RSA_2048</td>
        /// <td>RSA_PKCS1_SHA_256</td>
        /// <td>RSASSA-PKCS1-v1_5 using SHA-256</td>
        /// </tr>
        /// <tr>
        /// <td>RSA_3072</td>
        /// <td>RSA_PSS_SHA_256</td>
        /// <td>RSASSA-PSS using SHA-256 and MGF1 with SHA-256</td>
        /// </tr>
        /// <tr>
        /// <td>RSA_3072</td>
        /// <td>RSA_PKCS1_SHA_256</td>
        /// <td>RSASSA-PKCS1-v1_5 using SHA-256</td>
        /// </tr>
        /// <tr>
        /// <td>EC_P256</td>
        /// <td>ECDSA_SHA_256</td>
        /// <td>ECDSA on the P-256 Curve(secp256r1) with a SHA-256 digest</td>
        /// </tr>
        /// <tr>
        /// <td>EC_P256K</td>
        /// <td>ECDSA_SHA_256</td>
        /// <td>ECDSA on the P-256K Curve(secp256k1) with a SHA-256 digest</td>
        /// </tr>
        /// <tr>
        /// <td>EC_SM2</td>
        /// <td>SM2DSA</td>
        /// <td>SM2 elliptic curve public key encryption algorithm</td>
        /// </tr>
        /// </tbody></table>
        /// <remarks>
        /// <para> When you calculate the SM2 signature based on GB/T 32918, the <b>Digest</b> parameter is used to calculate the digest value of the combination of Z(A) and M, rather than the SM3 digest value. M indicates the original message to be signed. Z(A) indicates the hash value for User A. The hash value is defined in GB/T 32918.  In this example, the asymmetric key whose ID is <c>5c438b18-05be-40ad-b6c2-3be6752c****</c> and version ID is <c>2ab1a983-7072-4bbc-a582-584b5bd8****</c> and the signature algorithm RSA_PSS_SHA_256 are used to verify the signature <c>M2CceNZH00ZgL9ED/ZHFp21YRAvYeZHknJUc207OCZ0N9wNn9As4z2bON3FF3je+1Nu+2+/8Zj50HpMTpzYpMp2R93cYmACCmhaYoKydxylbyGzJR8y9likZRCrkD38lRoS40aBBvv/6iRKzQuo9EGYVcel36cMNg00VmYNBy3pa1rwg3gA4l3cy6kjayZja1WGPkVhrVKsrJMdbpl0ApLjXKuD8rw1n1XLCwCUEL5eLPljTZaAveqdOFQOiZnZEGI27qIiZe7I1fN8tcz6anS/gTM7xRKE++5egEvRWlTQQTJeApnPSiUPA+8ZykNdelQsOQh5SrGoyI4A5pq****==</c> of the digest <c>ZOyIygCyaOW6GjVnihtTFtIS9PNmskdyMlNKiuyjfzw=</c>.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// AsymmetricVerifyRequest
        /// </param>
        /// 
        /// <returns>
        /// AsymmetricVerifyResponse
        /// </returns>
        public async Task<AsymmetricVerifyResponse> AsymmetricVerifyAsync(AsymmetricVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AsymmetricVerifyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If the deletion task of a CMK is canceled, the CMK returns to the Enabled state.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CancelKeyDeletionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelKeyDeletionResponse
        /// </returns>
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
            return TeaModel.ToObject<CancelKeyDeletionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If the deletion task of a CMK is canceled, the CMK returns to the Enabled state.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CancelKeyDeletionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelKeyDeletionResponse
        /// </returns>
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
            return TeaModel.ToObject<CancelKeyDeletionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If the deletion task of a CMK is canceled, the CMK returns to the Enabled state.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CancelKeyDeletionRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelKeyDeletionResponse
        /// </returns>
        public CancelKeyDeletionResponse CancelKeyDeletion(CancelKeyDeletionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelKeyDeletionWithOptions(request, runtime);
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If the deletion task of a CMK is canceled, the CMK returns to the Enabled state.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CancelKeyDeletionRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelKeyDeletionResponse
        /// </returns>
        public async Task<CancelKeyDeletionResponse> CancelKeyDeletionAsync(CancelKeyDeletionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelKeyDeletionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Decrypts data by using a specific certificate.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Limit: The encryption algorithm in the request parameters must match the key type. 
        /// The following table describes the mapping between encryption algorithms and key types.</para>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Algorithm</th>
        /// <th>Key Spec</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>RSAES_OAEP_SHA_1</td>
        /// <td>RSA_2048</td>
        /// </tr>
        /// <tr>
        /// <td>RSAES_OAEP_SHA_256</td>
        /// <td>RSA_2048</td>
        /// </tr>
        /// <tr>
        /// <td>SM2PKE</td>
        /// <td>EC_SM2</td>
        /// </tr>
        /// <tr>
        /// <td>In this example, the certificate whose ID is <c>12345678-1234-1234-1234-12345678****</c> and the encryption algorithm <c>RSAES_OAEP_SHA_256</c> are used to decrypt the data <c>ZOyIygCyaOW6Gj****MlNKiuyjfzw=</c>.</td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// </description>
        /// 
        /// <param name="request">
        /// CertificatePrivateKeyDecryptRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CertificatePrivateKeyDecryptResponse
        /// </returns>
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
            return TeaModel.ToObject<CertificatePrivateKeyDecryptResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Decrypts data by using a specific certificate.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Limit: The encryption algorithm in the request parameters must match the key type. 
        /// The following table describes the mapping between encryption algorithms and key types.</para>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Algorithm</th>
        /// <th>Key Spec</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>RSAES_OAEP_SHA_1</td>
        /// <td>RSA_2048</td>
        /// </tr>
        /// <tr>
        /// <td>RSAES_OAEP_SHA_256</td>
        /// <td>RSA_2048</td>
        /// </tr>
        /// <tr>
        /// <td>SM2PKE</td>
        /// <td>EC_SM2</td>
        /// </tr>
        /// <tr>
        /// <td>In this example, the certificate whose ID is <c>12345678-1234-1234-1234-12345678****</c> and the encryption algorithm <c>RSAES_OAEP_SHA_256</c> are used to decrypt the data <c>ZOyIygCyaOW6Gj****MlNKiuyjfzw=</c>.</td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// </description>
        /// 
        /// <param name="request">
        /// CertificatePrivateKeyDecryptRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CertificatePrivateKeyDecryptResponse
        /// </returns>
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
            return TeaModel.ToObject<CertificatePrivateKeyDecryptResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Decrypts data by using a specific certificate.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Limit: The encryption algorithm in the request parameters must match the key type. 
        /// The following table describes the mapping between encryption algorithms and key types.</para>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Algorithm</th>
        /// <th>Key Spec</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>RSAES_OAEP_SHA_1</td>
        /// <td>RSA_2048</td>
        /// </tr>
        /// <tr>
        /// <td>RSAES_OAEP_SHA_256</td>
        /// <td>RSA_2048</td>
        /// </tr>
        /// <tr>
        /// <td>SM2PKE</td>
        /// <td>EC_SM2</td>
        /// </tr>
        /// <tr>
        /// <td>In this example, the certificate whose ID is <c>12345678-1234-1234-1234-12345678****</c> and the encryption algorithm <c>RSAES_OAEP_SHA_256</c> are used to decrypt the data <c>ZOyIygCyaOW6Gj****MlNKiuyjfzw=</c>.</td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// </description>
        /// 
        /// <param name="request">
        /// CertificatePrivateKeyDecryptRequest
        /// </param>
        /// 
        /// <returns>
        /// CertificatePrivateKeyDecryptResponse
        /// </returns>
        public CertificatePrivateKeyDecryptResponse CertificatePrivateKeyDecrypt(CertificatePrivateKeyDecryptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CertificatePrivateKeyDecryptWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Decrypts data by using a specific certificate.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Limit: The encryption algorithm in the request parameters must match the key type. 
        /// The following table describes the mapping between encryption algorithms and key types.</para>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Algorithm</th>
        /// <th>Key Spec</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>RSAES_OAEP_SHA_1</td>
        /// <td>RSA_2048</td>
        /// </tr>
        /// <tr>
        /// <td>RSAES_OAEP_SHA_256</td>
        /// <td>RSA_2048</td>
        /// </tr>
        /// <tr>
        /// <td>SM2PKE</td>
        /// <td>EC_SM2</td>
        /// </tr>
        /// <tr>
        /// <td>In this example, the certificate whose ID is <c>12345678-1234-1234-1234-12345678****</c> and the encryption algorithm <c>RSAES_OAEP_SHA_256</c> are used to decrypt the data <c>ZOyIygCyaOW6Gj****MlNKiuyjfzw=</c>.</td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// </description>
        /// 
        /// <param name="request">
        /// CertificatePrivateKeyDecryptRequest
        /// </param>
        /// 
        /// <returns>
        /// CertificatePrivateKeyDecryptResponse
        /// </returns>
        public async Task<CertificatePrivateKeyDecryptResponse> CertificatePrivateKeyDecryptAsync(CertificatePrivateKeyDecryptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CertificatePrivateKeyDecryptWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates a signature by using a specified certificate.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The signature algorithm in the request parameters must match the key type. The following table describes the mapping between signature algorithms and key types.  </para>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Algorithm</th>
        /// <th>Key Spec</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>RSA_PKCS1_SHA_256</td>
        /// <td>RSA_2048</td>
        /// </tr>
        /// <tr>
        /// <td>RSA_PSS_SHA_256</td>
        /// <td>RSA_2048</td>
        /// </tr>
        /// <tr>
        /// <td>ECDSA_SHA_256</td>
        /// <td>EC_P256</td>
        /// </tr>
        /// <tr>
        /// <td>SM2DSA</td>
        /// <td>EC_SM2</td>
        /// </tr>
        /// <tr>
        /// <td>In this example, the certificate whose ID is <c>12345678-1234-1234-1234-12345678****</c> and the signature algorithm <c>ECDSA_SHA_256</c> are used to generate a signature for the raw data <c>VGhlIHF1aWNrIGJyb3duIGZveCBqdW1wcyBvdmVyIHRoZSBsYXp5IGRvZy4=</c>.</td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// </description>
        /// 
        /// <param name="request">
        /// CertificatePrivateKeySignRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CertificatePrivateKeySignResponse
        /// </returns>
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
            return TeaModel.ToObject<CertificatePrivateKeySignResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates a signature by using a specified certificate.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The signature algorithm in the request parameters must match the key type. The following table describes the mapping between signature algorithms and key types.  </para>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Algorithm</th>
        /// <th>Key Spec</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>RSA_PKCS1_SHA_256</td>
        /// <td>RSA_2048</td>
        /// </tr>
        /// <tr>
        /// <td>RSA_PSS_SHA_256</td>
        /// <td>RSA_2048</td>
        /// </tr>
        /// <tr>
        /// <td>ECDSA_SHA_256</td>
        /// <td>EC_P256</td>
        /// </tr>
        /// <tr>
        /// <td>SM2DSA</td>
        /// <td>EC_SM2</td>
        /// </tr>
        /// <tr>
        /// <td>In this example, the certificate whose ID is <c>12345678-1234-1234-1234-12345678****</c> and the signature algorithm <c>ECDSA_SHA_256</c> are used to generate a signature for the raw data <c>VGhlIHF1aWNrIGJyb3duIGZveCBqdW1wcyBvdmVyIHRoZSBsYXp5IGRvZy4=</c>.</td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// </description>
        /// 
        /// <param name="request">
        /// CertificatePrivateKeySignRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CertificatePrivateKeySignResponse
        /// </returns>
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
            return TeaModel.ToObject<CertificatePrivateKeySignResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates a signature by using a specified certificate.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The signature algorithm in the request parameters must match the key type. The following table describes the mapping between signature algorithms and key types.  </para>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Algorithm</th>
        /// <th>Key Spec</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>RSA_PKCS1_SHA_256</td>
        /// <td>RSA_2048</td>
        /// </tr>
        /// <tr>
        /// <td>RSA_PSS_SHA_256</td>
        /// <td>RSA_2048</td>
        /// </tr>
        /// <tr>
        /// <td>ECDSA_SHA_256</td>
        /// <td>EC_P256</td>
        /// </tr>
        /// <tr>
        /// <td>SM2DSA</td>
        /// <td>EC_SM2</td>
        /// </tr>
        /// <tr>
        /// <td>In this example, the certificate whose ID is <c>12345678-1234-1234-1234-12345678****</c> and the signature algorithm <c>ECDSA_SHA_256</c> are used to generate a signature for the raw data <c>VGhlIHF1aWNrIGJyb3duIGZveCBqdW1wcyBvdmVyIHRoZSBsYXp5IGRvZy4=</c>.</td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// </description>
        /// 
        /// <param name="request">
        /// CertificatePrivateKeySignRequest
        /// </param>
        /// 
        /// <returns>
        /// CertificatePrivateKeySignResponse
        /// </returns>
        public CertificatePrivateKeySignResponse CertificatePrivateKeySign(CertificatePrivateKeySignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CertificatePrivateKeySignWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates a signature by using a specified certificate.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The signature algorithm in the request parameters must match the key type. The following table describes the mapping between signature algorithms and key types.  </para>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Algorithm</th>
        /// <th>Key Spec</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>RSA_PKCS1_SHA_256</td>
        /// <td>RSA_2048</td>
        /// </tr>
        /// <tr>
        /// <td>RSA_PSS_SHA_256</td>
        /// <td>RSA_2048</td>
        /// </tr>
        /// <tr>
        /// <td>ECDSA_SHA_256</td>
        /// <td>EC_P256</td>
        /// </tr>
        /// <tr>
        /// <td>SM2DSA</td>
        /// <td>EC_SM2</td>
        /// </tr>
        /// <tr>
        /// <td>In this example, the certificate whose ID is <c>12345678-1234-1234-1234-12345678****</c> and the signature algorithm <c>ECDSA_SHA_256</c> are used to generate a signature for the raw data <c>VGhlIHF1aWNrIGJyb3duIGZveCBqdW1wcyBvdmVyIHRoZSBsYXp5IGRvZy4=</c>.</td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// </description>
        /// 
        /// <param name="request">
        /// CertificatePrivateKeySignRequest
        /// </param>
        /// 
        /// <returns>
        /// CertificatePrivateKeySignResponse
        /// </returns>
        public async Task<CertificatePrivateKeySignResponse> CertificatePrivateKeySignAsync(CertificatePrivateKeySignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CertificatePrivateKeySignWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Encrypts data by using a specific certificate.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Limit: The encryption algorithm in the request parameters must match the key type. 
        /// The following table describes the mapping between encryption algorithms and key types.</para>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Algorithm</th>
        /// <th>Key Spec</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>RSAES_OAEP_SHA_1</td>
        /// <td>RSA_2048</td>
        /// </tr>
        /// <tr>
        /// <td>RSAES_OAEP_SHA_256</td>
        /// <td>RSA_2048</td>
        /// </tr>
        /// <tr>
        /// <td>SM2PKE</td>
        /// <td>EC_SM2</td>
        /// </tr>
        /// <tr>
        /// <td>In this example, the certificate whose ID is <c>12345678-1234-1234-1234-12345678****</c> and the encryption algorithm <c>RSAES_OAEP_SHA_256</c> are used to encrypt the data <c>VGhlIHF1aWNrIGJyb3duIGZveCBqdW1wcyBvdmVyIHRoZSBsYXp5IGRvZy4=</c>.</td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// </description>
        /// 
        /// <param name="request">
        /// CertificatePublicKeyEncryptRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CertificatePublicKeyEncryptResponse
        /// </returns>
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
            return TeaModel.ToObject<CertificatePublicKeyEncryptResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Encrypts data by using a specific certificate.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Limit: The encryption algorithm in the request parameters must match the key type. 
        /// The following table describes the mapping between encryption algorithms and key types.</para>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Algorithm</th>
        /// <th>Key Spec</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>RSAES_OAEP_SHA_1</td>
        /// <td>RSA_2048</td>
        /// </tr>
        /// <tr>
        /// <td>RSAES_OAEP_SHA_256</td>
        /// <td>RSA_2048</td>
        /// </tr>
        /// <tr>
        /// <td>SM2PKE</td>
        /// <td>EC_SM2</td>
        /// </tr>
        /// <tr>
        /// <td>In this example, the certificate whose ID is <c>12345678-1234-1234-1234-12345678****</c> and the encryption algorithm <c>RSAES_OAEP_SHA_256</c> are used to encrypt the data <c>VGhlIHF1aWNrIGJyb3duIGZveCBqdW1wcyBvdmVyIHRoZSBsYXp5IGRvZy4=</c>.</td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// </description>
        /// 
        /// <param name="request">
        /// CertificatePublicKeyEncryptRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CertificatePublicKeyEncryptResponse
        /// </returns>
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
            return TeaModel.ToObject<CertificatePublicKeyEncryptResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Encrypts data by using a specific certificate.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Limit: The encryption algorithm in the request parameters must match the key type. 
        /// The following table describes the mapping between encryption algorithms and key types.</para>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Algorithm</th>
        /// <th>Key Spec</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>RSAES_OAEP_SHA_1</td>
        /// <td>RSA_2048</td>
        /// </tr>
        /// <tr>
        /// <td>RSAES_OAEP_SHA_256</td>
        /// <td>RSA_2048</td>
        /// </tr>
        /// <tr>
        /// <td>SM2PKE</td>
        /// <td>EC_SM2</td>
        /// </tr>
        /// <tr>
        /// <td>In this example, the certificate whose ID is <c>12345678-1234-1234-1234-12345678****</c> and the encryption algorithm <c>RSAES_OAEP_SHA_256</c> are used to encrypt the data <c>VGhlIHF1aWNrIGJyb3duIGZveCBqdW1wcyBvdmVyIHRoZSBsYXp5IGRvZy4=</c>.</td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// </description>
        /// 
        /// <param name="request">
        /// CertificatePublicKeyEncryptRequest
        /// </param>
        /// 
        /// <returns>
        /// CertificatePublicKeyEncryptResponse
        /// </returns>
        public CertificatePublicKeyEncryptResponse CertificatePublicKeyEncrypt(CertificatePublicKeyEncryptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CertificatePublicKeyEncryptWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Encrypts data by using a specific certificate.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Limit: The encryption algorithm in the request parameters must match the key type. 
        /// The following table describes the mapping between encryption algorithms and key types.</para>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Algorithm</th>
        /// <th>Key Spec</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>RSAES_OAEP_SHA_1</td>
        /// <td>RSA_2048</td>
        /// </tr>
        /// <tr>
        /// <td>RSAES_OAEP_SHA_256</td>
        /// <td>RSA_2048</td>
        /// </tr>
        /// <tr>
        /// <td>SM2PKE</td>
        /// <td>EC_SM2</td>
        /// </tr>
        /// <tr>
        /// <td>In this example, the certificate whose ID is <c>12345678-1234-1234-1234-12345678****</c> and the encryption algorithm <c>RSAES_OAEP_SHA_256</c> are used to encrypt the data <c>VGhlIHF1aWNrIGJyb3duIGZveCBqdW1wcyBvdmVyIHRoZSBsYXp5IGRvZy4=</c>.</td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// </description>
        /// 
        /// <param name="request">
        /// CertificatePublicKeyEncryptRequest
        /// </param>
        /// 
        /// <returns>
        /// CertificatePublicKeyEncryptResponse
        /// </returns>
        public async Task<CertificatePublicKeyEncryptResponse> CertificatePublicKeyEncryptAsync(CertificatePublicKeyEncryptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CertificatePublicKeyEncryptWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Verifies a digital signature by using a specified certificate.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The signature algorithm in the request parameters must match the key type. The following table describes the mapping between signature algorithms and key types.  </para>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Algorithm</th>
        /// <th>Key Spec</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>RSA_PKCS1_SHA_256</td>
        /// <td>RSA_2048</td>
        /// </tr>
        /// <tr>
        /// <td>RSA_PSS_SHA_256</td>
        /// <td>RSA_2048</td>
        /// </tr>
        /// <tr>
        /// <td>ECDSA_SHA_256</td>
        /// <td>EC_P256</td>
        /// </tr>
        /// <tr>
        /// <td>SM2DSA</td>
        /// <td>EC_SM2</td>
        /// </tr>
        /// <tr>
        /// <td>In this example, the certificate whose ID is <c>12345678-1234-1234-1234-12345678****</c> and the signature algorithm <c>ECDSA_SHA_256</c> are used to verify the digital signature <c>ZOyIygCyaOW6Gj****MlNKiuyjfzw=</c> of the raw data <c>VGhlIHF1aWNrIGJyb3duIGZveCBqdW1wcyBvdmVyIHRoZSBsYXp5IGRvZy4=</c>.</td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// </description>
        /// 
        /// <param name="request">
        /// CertificatePublicKeyVerifyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CertificatePublicKeyVerifyResponse
        /// </returns>
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
            return TeaModel.ToObject<CertificatePublicKeyVerifyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Verifies a digital signature by using a specified certificate.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The signature algorithm in the request parameters must match the key type. The following table describes the mapping between signature algorithms and key types.  </para>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Algorithm</th>
        /// <th>Key Spec</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>RSA_PKCS1_SHA_256</td>
        /// <td>RSA_2048</td>
        /// </tr>
        /// <tr>
        /// <td>RSA_PSS_SHA_256</td>
        /// <td>RSA_2048</td>
        /// </tr>
        /// <tr>
        /// <td>ECDSA_SHA_256</td>
        /// <td>EC_P256</td>
        /// </tr>
        /// <tr>
        /// <td>SM2DSA</td>
        /// <td>EC_SM2</td>
        /// </tr>
        /// <tr>
        /// <td>In this example, the certificate whose ID is <c>12345678-1234-1234-1234-12345678****</c> and the signature algorithm <c>ECDSA_SHA_256</c> are used to verify the digital signature <c>ZOyIygCyaOW6Gj****MlNKiuyjfzw=</c> of the raw data <c>VGhlIHF1aWNrIGJyb3duIGZveCBqdW1wcyBvdmVyIHRoZSBsYXp5IGRvZy4=</c>.</td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// </description>
        /// 
        /// <param name="request">
        /// CertificatePublicKeyVerifyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CertificatePublicKeyVerifyResponse
        /// </returns>
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
            return TeaModel.ToObject<CertificatePublicKeyVerifyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Verifies a digital signature by using a specified certificate.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The signature algorithm in the request parameters must match the key type. The following table describes the mapping between signature algorithms and key types.  </para>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Algorithm</th>
        /// <th>Key Spec</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>RSA_PKCS1_SHA_256</td>
        /// <td>RSA_2048</td>
        /// </tr>
        /// <tr>
        /// <td>RSA_PSS_SHA_256</td>
        /// <td>RSA_2048</td>
        /// </tr>
        /// <tr>
        /// <td>ECDSA_SHA_256</td>
        /// <td>EC_P256</td>
        /// </tr>
        /// <tr>
        /// <td>SM2DSA</td>
        /// <td>EC_SM2</td>
        /// </tr>
        /// <tr>
        /// <td>In this example, the certificate whose ID is <c>12345678-1234-1234-1234-12345678****</c> and the signature algorithm <c>ECDSA_SHA_256</c> are used to verify the digital signature <c>ZOyIygCyaOW6Gj****MlNKiuyjfzw=</c> of the raw data <c>VGhlIHF1aWNrIGJyb3duIGZveCBqdW1wcyBvdmVyIHRoZSBsYXp5IGRvZy4=</c>.</td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// </description>
        /// 
        /// <param name="request">
        /// CertificatePublicKeyVerifyRequest
        /// </param>
        /// 
        /// <returns>
        /// CertificatePublicKeyVerifyResponse
        /// </returns>
        public CertificatePublicKeyVerifyResponse CertificatePublicKeyVerify(CertificatePublicKeyVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CertificatePublicKeyVerifyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Verifies a digital signature by using a specified certificate.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The signature algorithm in the request parameters must match the key type. The following table describes the mapping between signature algorithms and key types.  </para>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Algorithm</th>
        /// <th>Key Spec</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>RSA_PKCS1_SHA_256</td>
        /// <td>RSA_2048</td>
        /// </tr>
        /// <tr>
        /// <td>RSA_PSS_SHA_256</td>
        /// <td>RSA_2048</td>
        /// </tr>
        /// <tr>
        /// <td>ECDSA_SHA_256</td>
        /// <td>EC_P256</td>
        /// </tr>
        /// <tr>
        /// <td>SM2DSA</td>
        /// <td>EC_SM2</td>
        /// </tr>
        /// <tr>
        /// <td>In this example, the certificate whose ID is <c>12345678-1234-1234-1234-12345678****</c> and the signature algorithm <c>ECDSA_SHA_256</c> are used to verify the digital signature <c>ZOyIygCyaOW6Gj****MlNKiuyjfzw=</c> of the raw data <c>VGhlIHF1aWNrIGJyb3duIGZveCBqdW1wcyBvdmVyIHRoZSBsYXp5IGRvZy4=</c>.</td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// </description>
        /// 
        /// <param name="request">
        /// CertificatePublicKeyVerifyRequest
        /// </param>
        /// 
        /// <returns>
        /// CertificatePublicKeyVerifyResponse
        /// </returns>
        public async Task<CertificatePublicKeyVerifyResponse> CertificatePublicKeyVerifyAsync(CertificatePublicKeyVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CertificatePublicKeyVerifyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables a Key Management Service (KMS) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Limits</h3>
        /// <para>You can enable only instances of the software key management type. You cannot enable instances of the hardware key management type.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ConnectKmsInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ConnectKmsInstanceResponse
        /// </returns>
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
            return TeaModel.ToObject<ConnectKmsInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables a Key Management Service (KMS) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Limits</h3>
        /// <para>You can enable only instances of the software key management type. You cannot enable instances of the hardware key management type.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ConnectKmsInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ConnectKmsInstanceResponse
        /// </returns>
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
            return TeaModel.ToObject<ConnectKmsInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables a Key Management Service (KMS) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Limits</h3>
        /// <para>You can enable only instances of the software key management type. You cannot enable instances of the hardware key management type.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ConnectKmsInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// ConnectKmsInstanceResponse
        /// </returns>
        public ConnectKmsInstanceResponse ConnectKmsInstance(ConnectKmsInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConnectKmsInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables a Key Management Service (KMS) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Limits</h3>
        /// <para>You can enable only instances of the software key management type. You cannot enable instances of the hardware key management type.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ConnectKmsInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// ConnectKmsInstanceResponse
        /// </returns>
        public async Task<ConnectKmsInstanceResponse> ConnectKmsInstanceAsync(ConnectKmsInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConnectKmsInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Each alias can be bound to only one CMK at a time.</para>
        /// <list type="bullet">
        /// <item><description>The aliases of CMKs in the same region must be unique.
        /// In this topic, an alias named <c>alias/example</c> is created for a CMK named <c>7906979c-8e06-46a2-be2d-68e3ccbc****</c>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAliasRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAliasResponse
        /// </returns>
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
            return TeaModel.ToObject<CreateAliasResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Each alias can be bound to only one CMK at a time.</para>
        /// <list type="bullet">
        /// <item><description>The aliases of CMKs in the same region must be unique.
        /// In this topic, an alias named <c>alias/example</c> is created for a CMK named <c>7906979c-8e06-46a2-be2d-68e3ccbc****</c>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAliasRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAliasResponse
        /// </returns>
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
            return TeaModel.ToObject<CreateAliasResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Each alias can be bound to only one CMK at a time.</para>
        /// <list type="bullet">
        /// <item><description>The aliases of CMKs in the same region must be unique.
        /// In this topic, an alias named <c>alias/example</c> is created for a CMK named <c>7906979c-8e06-46a2-be2d-68e3ccbc****</c>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAliasRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAliasResponse
        /// </returns>
        public CreateAliasResponse CreateAlias(CreateAliasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAliasWithOptions(request, runtime);
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Each alias can be bound to only one CMK at a time.</para>
        /// <list type="bullet">
        /// <item><description>The aliases of CMKs in the same region must be unique.
        /// In this topic, an alias named <c>alias/example</c> is created for a CMK named <c>7906979c-8e06-46a2-be2d-68e3ccbc****</c>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAliasRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAliasResponse
        /// </returns>
        public async Task<CreateAliasResponse> CreateAliasAsync(CreateAliasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAliasWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an application access point (AAP)</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>To perform cryptographic operations and retrieve secret values, self-managed applications must use a client key to access a Key Management Service (KMS) instance. The following process shows how to create a client key-based AAP:
        /// 1.Create a network access rule: You can configure the private IP addresses or private CIDR blocks that are allowed to access KMS. For more information, see <a href="https://help.aliyun.com/document_detail/2539407.html">CreateNetworkRule</a>.
        /// 2.Create a permission policy: You can configure the keys and secrets that are allowed to access and bind network access rules to the keys and secrets. For more information, see <a href="https://help.aliyun.com/document_detail/2539454.html">CreatePolicy</a>.
        /// 3.Create an AAP: You can configure an authentication method and bind a permission policy to an AAP. This topic describes how to create an AAP.
        /// 4.Create a client key: You can configure the encryption password and validity period of a client key and bind the client key to an AAP. For more information, see <a href="https://help.aliyun.com/document_detail/2539509.html">CreateClientKey</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateApplicationAccessPointRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateApplicationAccessPointResponse
        /// </returns>
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
            return TeaModel.ToObject<CreateApplicationAccessPointResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an application access point (AAP)</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>To perform cryptographic operations and retrieve secret values, self-managed applications must use a client key to access a Key Management Service (KMS) instance. The following process shows how to create a client key-based AAP:
        /// 1.Create a network access rule: You can configure the private IP addresses or private CIDR blocks that are allowed to access KMS. For more information, see <a href="https://help.aliyun.com/document_detail/2539407.html">CreateNetworkRule</a>.
        /// 2.Create a permission policy: You can configure the keys and secrets that are allowed to access and bind network access rules to the keys and secrets. For more information, see <a href="https://help.aliyun.com/document_detail/2539454.html">CreatePolicy</a>.
        /// 3.Create an AAP: You can configure an authentication method and bind a permission policy to an AAP. This topic describes how to create an AAP.
        /// 4.Create a client key: You can configure the encryption password and validity period of a client key and bind the client key to an AAP. For more information, see <a href="https://help.aliyun.com/document_detail/2539509.html">CreateClientKey</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateApplicationAccessPointRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateApplicationAccessPointResponse
        /// </returns>
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
            return TeaModel.ToObject<CreateApplicationAccessPointResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an application access point (AAP)</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>To perform cryptographic operations and retrieve secret values, self-managed applications must use a client key to access a Key Management Service (KMS) instance. The following process shows how to create a client key-based AAP:
        /// 1.Create a network access rule: You can configure the private IP addresses or private CIDR blocks that are allowed to access KMS. For more information, see <a href="https://help.aliyun.com/document_detail/2539407.html">CreateNetworkRule</a>.
        /// 2.Create a permission policy: You can configure the keys and secrets that are allowed to access and bind network access rules to the keys and secrets. For more information, see <a href="https://help.aliyun.com/document_detail/2539454.html">CreatePolicy</a>.
        /// 3.Create an AAP: You can configure an authentication method and bind a permission policy to an AAP. This topic describes how to create an AAP.
        /// 4.Create a client key: You can configure the encryption password and validity period of a client key and bind the client key to an AAP. For more information, see <a href="https://help.aliyun.com/document_detail/2539509.html">CreateClientKey</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateApplicationAccessPointRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateApplicationAccessPointResponse
        /// </returns>
        public CreateApplicationAccessPointResponse CreateApplicationAccessPoint(CreateApplicationAccessPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateApplicationAccessPointWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an application access point (AAP)</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>To perform cryptographic operations and retrieve secret values, self-managed applications must use a client key to access a Key Management Service (KMS) instance. The following process shows how to create a client key-based AAP:
        /// 1.Create a network access rule: You can configure the private IP addresses or private CIDR blocks that are allowed to access KMS. For more information, see <a href="https://help.aliyun.com/document_detail/2539407.html">CreateNetworkRule</a>.
        /// 2.Create a permission policy: You can configure the keys and secrets that are allowed to access and bind network access rules to the keys and secrets. For more information, see <a href="https://help.aliyun.com/document_detail/2539454.html">CreatePolicy</a>.
        /// 3.Create an AAP: You can configure an authentication method and bind a permission policy to an AAP. This topic describes how to create an AAP.
        /// 4.Create a client key: You can configure the encryption password and validity period of a client key and bind the client key to an AAP. For more information, see <a href="https://help.aliyun.com/document_detail/2539509.html">CreateClientKey</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateApplicationAccessPointRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateApplicationAccessPointResponse
        /// </returns>
        public async Task<CreateApplicationAccessPointResponse> CreateApplicationAccessPointAsync(CreateApplicationAccessPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateApplicationAccessPointWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a client key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>To perform cryptographic operations and retrieve secret values, self-managed applications must use a client key to access a Key Management Service (KMS) instance. The following process shows how to create a client key-based application access point (AAP):
        /// 1.Create an access control rule: You can configure the private IP addresses or private CIDR blocks that are allowed to access a KMS instance. For more information, see <a href="https://help.aliyun.com/document_detail/2539407.html">CreateNetworkRule</a>.
        /// 2.Create a permission policy: You can configure the keys and secrets that are allowed to access and bind access control rules to the keys and secrets. For more information, see <a href="https://help.aliyun.com/document_detail/2539454.html">CreatePolicy</a>.
        /// 3.Create an AAP: You can configure an authentication method and bind a permission policy to an AAP. For more information, see <a href="https://help.aliyun.com/document_detail/2539467.html">CreateApplicationAccessPoint</a>.
        /// 4.Create a client key: You can configure the encryption password and validity period of a client key and bind the client key to an AAP.</para>
        /// <h3>Precautions</h3>
        /// <para>A client key has a validity period. After a client key expires, applications into which the client key is integrated cannot access the required KMS instance. You must replace the client key before the client key expires. We recommend that you delete the expired client key in KMS after the new client key is used.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateClientKeyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateClientKeyResponse
        /// </returns>
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
            return TeaModel.ToObject<CreateClientKeyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a client key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>To perform cryptographic operations and retrieve secret values, self-managed applications must use a client key to access a Key Management Service (KMS) instance. The following process shows how to create a client key-based application access point (AAP):
        /// 1.Create an access control rule: You can configure the private IP addresses or private CIDR blocks that are allowed to access a KMS instance. For more information, see <a href="https://help.aliyun.com/document_detail/2539407.html">CreateNetworkRule</a>.
        /// 2.Create a permission policy: You can configure the keys and secrets that are allowed to access and bind access control rules to the keys and secrets. For more information, see <a href="https://help.aliyun.com/document_detail/2539454.html">CreatePolicy</a>.
        /// 3.Create an AAP: You can configure an authentication method and bind a permission policy to an AAP. For more information, see <a href="https://help.aliyun.com/document_detail/2539467.html">CreateApplicationAccessPoint</a>.
        /// 4.Create a client key: You can configure the encryption password and validity period of a client key and bind the client key to an AAP.</para>
        /// <h3>Precautions</h3>
        /// <para>A client key has a validity period. After a client key expires, applications into which the client key is integrated cannot access the required KMS instance. You must replace the client key before the client key expires. We recommend that you delete the expired client key in KMS after the new client key is used.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateClientKeyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateClientKeyResponse
        /// </returns>
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
            return TeaModel.ToObject<CreateClientKeyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a client key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>To perform cryptographic operations and retrieve secret values, self-managed applications must use a client key to access a Key Management Service (KMS) instance. The following process shows how to create a client key-based application access point (AAP):
        /// 1.Create an access control rule: You can configure the private IP addresses or private CIDR blocks that are allowed to access a KMS instance. For more information, see <a href="https://help.aliyun.com/document_detail/2539407.html">CreateNetworkRule</a>.
        /// 2.Create a permission policy: You can configure the keys and secrets that are allowed to access and bind access control rules to the keys and secrets. For more information, see <a href="https://help.aliyun.com/document_detail/2539454.html">CreatePolicy</a>.
        /// 3.Create an AAP: You can configure an authentication method and bind a permission policy to an AAP. For more information, see <a href="https://help.aliyun.com/document_detail/2539467.html">CreateApplicationAccessPoint</a>.
        /// 4.Create a client key: You can configure the encryption password and validity period of a client key and bind the client key to an AAP.</para>
        /// <h3>Precautions</h3>
        /// <para>A client key has a validity period. After a client key expires, applications into which the client key is integrated cannot access the required KMS instance. You must replace the client key before the client key expires. We recommend that you delete the expired client key in KMS after the new client key is used.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateClientKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateClientKeyResponse
        /// </returns>
        public CreateClientKeyResponse CreateClientKey(CreateClientKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateClientKeyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a client key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>To perform cryptographic operations and retrieve secret values, self-managed applications must use a client key to access a Key Management Service (KMS) instance. The following process shows how to create a client key-based application access point (AAP):
        /// 1.Create an access control rule: You can configure the private IP addresses or private CIDR blocks that are allowed to access a KMS instance. For more information, see <a href="https://help.aliyun.com/document_detail/2539407.html">CreateNetworkRule</a>.
        /// 2.Create a permission policy: You can configure the keys and secrets that are allowed to access and bind access control rules to the keys and secrets. For more information, see <a href="https://help.aliyun.com/document_detail/2539454.html">CreatePolicy</a>.
        /// 3.Create an AAP: You can configure an authentication method and bind a permission policy to an AAP. For more information, see <a href="https://help.aliyun.com/document_detail/2539467.html">CreateApplicationAccessPoint</a>.
        /// 4.Create a client key: You can configure the encryption password and validity period of a client key and bind the client key to an AAP.</para>
        /// <h3>Precautions</h3>
        /// <para>A client key has a validity period. After a client key expires, applications into which the client key is integrated cannot access the required KMS instance. You must replace the client key before the client key expires. We recommend that you delete the expired client key in KMS after the new client key is used.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateClientKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateClientKeyResponse
        /// </returns>
        public async Task<CreateClientKeyResponse> CreateClientKeyAsync(CreateClientKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateClientKeyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a customer master key (CMK).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>KMS supports common symmetric keys and asymmetric keys. For more information, see <a href="https://help.aliyun.com/document_detail/480161.html">Key types and specifications</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateKeyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateKeyResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyStorageMechanism))
            {
                query["KeyStorageMechanism"] = request.KeyStorageMechanism;
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
            return TeaModel.ToObject<CreateKeyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a customer master key (CMK).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>KMS supports common symmetric keys and asymmetric keys. For more information, see <a href="https://help.aliyun.com/document_detail/480161.html">Key types and specifications</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateKeyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateKeyResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyStorageMechanism))
            {
                query["KeyStorageMechanism"] = request.KeyStorageMechanism;
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
            return TeaModel.ToObject<CreateKeyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a customer master key (CMK).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>KMS supports common symmetric keys and asymmetric keys. For more information, see <a href="https://help.aliyun.com/document_detail/480161.html">Key types and specifications</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateKeyResponse
        /// </returns>
        public CreateKeyResponse CreateKey(CreateKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateKeyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a customer master key (CMK).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>KMS supports common symmetric keys and asymmetric keys. For more information, see <a href="https://help.aliyun.com/document_detail/480161.html">Key types and specifications</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateKeyResponse
        /// </returns>
        public async Task<CreateKeyResponse> CreateKeyAsync(CreateKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateKeyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>为密钥创建新的密钥版本。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can create a version only for an asymmetric CMK that is in the Enabled state. You can call the <a href="https://help.aliyun.com/document_detail/28947.html">CreateKey</a> operation to create an asymmetric CMK and the <a href="https://help.aliyun.com/document_detail/28952.html">DescribeKey</a> operation to query the status of the CMK. The status is specified by the KeyState parameter.</para>
        /// <list type="bullet">
        /// <item><description>The minimum interval for creating a version of the same CMK is seven days. You can call the <a href="https://help.aliyun.com/document_detail/28952.html">DescribeKey</a> operation to query the time when the last version of a CMK was created. The time is specified by the LastRotationDate parameter.</description></item>
        /// <item><description>If a CMK is in a private key store, you cannot create a version for the CMK.</description></item>
        /// <item><description>You can create a maximum of 50 versions for a CMK in the same region.
        /// You can create a version for the CMK whose ID is <c>0b30658a-ed1a-4922-b8f7-a673ca9c****</c> by using the parameter settings provided in this topic.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateKeyVersionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateKeyVersionResponse
        /// </returns>
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
            return TeaModel.ToObject<CreateKeyVersionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>为密钥创建新的密钥版本。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can create a version only for an asymmetric CMK that is in the Enabled state. You can call the <a href="https://help.aliyun.com/document_detail/28947.html">CreateKey</a> operation to create an asymmetric CMK and the <a href="https://help.aliyun.com/document_detail/28952.html">DescribeKey</a> operation to query the status of the CMK. The status is specified by the KeyState parameter.</para>
        /// <list type="bullet">
        /// <item><description>The minimum interval for creating a version of the same CMK is seven days. You can call the <a href="https://help.aliyun.com/document_detail/28952.html">DescribeKey</a> operation to query the time when the last version of a CMK was created. The time is specified by the LastRotationDate parameter.</description></item>
        /// <item><description>If a CMK is in a private key store, you cannot create a version for the CMK.</description></item>
        /// <item><description>You can create a maximum of 50 versions for a CMK in the same region.
        /// You can create a version for the CMK whose ID is <c>0b30658a-ed1a-4922-b8f7-a673ca9c****</c> by using the parameter settings provided in this topic.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateKeyVersionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateKeyVersionResponse
        /// </returns>
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
            return TeaModel.ToObject<CreateKeyVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>为密钥创建新的密钥版本。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can create a version only for an asymmetric CMK that is in the Enabled state. You can call the <a href="https://help.aliyun.com/document_detail/28947.html">CreateKey</a> operation to create an asymmetric CMK and the <a href="https://help.aliyun.com/document_detail/28952.html">DescribeKey</a> operation to query the status of the CMK. The status is specified by the KeyState parameter.</para>
        /// <list type="bullet">
        /// <item><description>The minimum interval for creating a version of the same CMK is seven days. You can call the <a href="https://help.aliyun.com/document_detail/28952.html">DescribeKey</a> operation to query the time when the last version of a CMK was created. The time is specified by the LastRotationDate parameter.</description></item>
        /// <item><description>If a CMK is in a private key store, you cannot create a version for the CMK.</description></item>
        /// <item><description>You can create a maximum of 50 versions for a CMK in the same region.
        /// You can create a version for the CMK whose ID is <c>0b30658a-ed1a-4922-b8f7-a673ca9c****</c> by using the parameter settings provided in this topic.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateKeyVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateKeyVersionResponse
        /// </returns>
        public CreateKeyVersionResponse CreateKeyVersion(CreateKeyVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateKeyVersionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>为密钥创建新的密钥版本。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can create a version only for an asymmetric CMK that is in the Enabled state. You can call the <a href="https://help.aliyun.com/document_detail/28947.html">CreateKey</a> operation to create an asymmetric CMK and the <a href="https://help.aliyun.com/document_detail/28952.html">DescribeKey</a> operation to query the status of the CMK. The status is specified by the KeyState parameter.</para>
        /// <list type="bullet">
        /// <item><description>The minimum interval for creating a version of the same CMK is seven days. You can call the <a href="https://help.aliyun.com/document_detail/28952.html">DescribeKey</a> operation to query the time when the last version of a CMK was created. The time is specified by the LastRotationDate parameter.</description></item>
        /// <item><description>If a CMK is in a private key store, you cannot create a version for the CMK.</description></item>
        /// <item><description>You can create a maximum of 50 versions for a CMK in the same region.
        /// You can create a version for the CMK whose ID is <c>0b30658a-ed1a-4922-b8f7-a673ca9c****</c> by using the parameter settings provided in this topic.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateKeyVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateKeyVersionResponse
        /// </returns>
        public async Task<CreateKeyVersionResponse> CreateKeyVersionAsync(CreateKeyVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateKeyVersionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an access control rule to configure the private IP addresses or CIDR blocks that are allowed to access a Key Management Service (KMS) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>To perform cryptographic operations and retrieve secret values, self-managed applications must use a client key to access a KMS instance. The following process shows how to create a client key-based application access point (AAP):
        /// 1.Create an access control rule: You can configure the private IP addresses or private CIDR blocks that are allowed to access a KMS instance.
        /// 2.Create a permission policy: You can configure the keys and secrets that are allowed to access and bind access control rules to the keys and secrets. For more information, see <a href="https://help.aliyun.com/document_detail/2539454.html">CreatePolicy</a>.
        /// 3.Create an AAP: You can configure an authentication method and bind a permission policy to an AAP. For more information, see <a href="https://help.aliyun.com/document_detail/2539467.html">CreateApplicationAccessPoint</a>.
        /// 4.Create a client key: You can configure the encryption password and validity period of a client key and bind the client key to an AAP. For more information, see <a href="https://help.aliyun.com/document_detail/2539509.html">CreateClientKey</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateNetworkRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateNetworkRuleResponse
        /// </returns>
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
            return TeaModel.ToObject<CreateNetworkRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an access control rule to configure the private IP addresses or CIDR blocks that are allowed to access a Key Management Service (KMS) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>To perform cryptographic operations and retrieve secret values, self-managed applications must use a client key to access a KMS instance. The following process shows how to create a client key-based application access point (AAP):
        /// 1.Create an access control rule: You can configure the private IP addresses or private CIDR blocks that are allowed to access a KMS instance.
        /// 2.Create a permission policy: You can configure the keys and secrets that are allowed to access and bind access control rules to the keys and secrets. For more information, see <a href="https://help.aliyun.com/document_detail/2539454.html">CreatePolicy</a>.
        /// 3.Create an AAP: You can configure an authentication method and bind a permission policy to an AAP. For more information, see <a href="https://help.aliyun.com/document_detail/2539467.html">CreateApplicationAccessPoint</a>.
        /// 4.Create a client key: You can configure the encryption password and validity period of a client key and bind the client key to an AAP. For more information, see <a href="https://help.aliyun.com/document_detail/2539509.html">CreateClientKey</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateNetworkRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateNetworkRuleResponse
        /// </returns>
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
            return TeaModel.ToObject<CreateNetworkRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an access control rule to configure the private IP addresses or CIDR blocks that are allowed to access a Key Management Service (KMS) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>To perform cryptographic operations and retrieve secret values, self-managed applications must use a client key to access a KMS instance. The following process shows how to create a client key-based application access point (AAP):
        /// 1.Create an access control rule: You can configure the private IP addresses or private CIDR blocks that are allowed to access a KMS instance.
        /// 2.Create a permission policy: You can configure the keys and secrets that are allowed to access and bind access control rules to the keys and secrets. For more information, see <a href="https://help.aliyun.com/document_detail/2539454.html">CreatePolicy</a>.
        /// 3.Create an AAP: You can configure an authentication method and bind a permission policy to an AAP. For more information, see <a href="https://help.aliyun.com/document_detail/2539467.html">CreateApplicationAccessPoint</a>.
        /// 4.Create a client key: You can configure the encryption password and validity period of a client key and bind the client key to an AAP. For more information, see <a href="https://help.aliyun.com/document_detail/2539509.html">CreateClientKey</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateNetworkRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateNetworkRuleResponse
        /// </returns>
        public CreateNetworkRuleResponse CreateNetworkRule(CreateNetworkRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateNetworkRuleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an access control rule to configure the private IP addresses or CIDR blocks that are allowed to access a Key Management Service (KMS) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>To perform cryptographic operations and retrieve secret values, self-managed applications must use a client key to access a KMS instance. The following process shows how to create a client key-based application access point (AAP):
        /// 1.Create an access control rule: You can configure the private IP addresses or private CIDR blocks that are allowed to access a KMS instance.
        /// 2.Create a permission policy: You can configure the keys and secrets that are allowed to access and bind access control rules to the keys and secrets. For more information, see <a href="https://help.aliyun.com/document_detail/2539454.html">CreatePolicy</a>.
        /// 3.Create an AAP: You can configure an authentication method and bind a permission policy to an AAP. For more information, see <a href="https://help.aliyun.com/document_detail/2539467.html">CreateApplicationAccessPoint</a>.
        /// 4.Create a client key: You can configure the encryption password and validity period of a client key and bind the client key to an AAP. For more information, see <a href="https://help.aliyun.com/document_detail/2539509.html">CreateClientKey</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateNetworkRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateNetworkRuleResponse
        /// </returns>
        public async Task<CreateNetworkRuleResponse> CreateNetworkRuleAsync(CreateNetworkRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateNetworkRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a permission policy to configure the keys and secrets that are allowed to access.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>To perform cryptographic operations and retrieve secret values, self-managed applications must use a client key to access a Key Management Service (KMS) instance. The following process shows how to create a client key-based application access point (AAP):
        /// 1.Create an access control rule: You can configure the private IP addresses or private CIDR blocks that are allowed to access a KMS instance. For more information, see <a href="https://help.aliyun.com/document_detail/2539407.html">CreateNetworkRule</a>.
        /// 2.Create a permission policy: You can configure the keys and secrets that are allowed to access and bind access control rules to the keys and secrets.
        /// 3.Create an AAP: You can configure an authentication method and bind a permission policy to an AAP. For more information, see <a href="https://help.aliyun.com/document_detail/2539467.html">CreateApplicationAccessPoint</a>.
        /// 4.Create a client key: You can configure the encryption password and validity period of a client key and bind the client key to an AAP. For more information, see <a href="https://help.aliyun.com/document_detail/2539509.html">CreateClientKey</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreatePolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePolicyResponse
        /// </returns>
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
            return TeaModel.ToObject<CreatePolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a permission policy to configure the keys and secrets that are allowed to access.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>To perform cryptographic operations and retrieve secret values, self-managed applications must use a client key to access a Key Management Service (KMS) instance. The following process shows how to create a client key-based application access point (AAP):
        /// 1.Create an access control rule: You can configure the private IP addresses or private CIDR blocks that are allowed to access a KMS instance. For more information, see <a href="https://help.aliyun.com/document_detail/2539407.html">CreateNetworkRule</a>.
        /// 2.Create a permission policy: You can configure the keys and secrets that are allowed to access and bind access control rules to the keys and secrets.
        /// 3.Create an AAP: You can configure an authentication method and bind a permission policy to an AAP. For more information, see <a href="https://help.aliyun.com/document_detail/2539467.html">CreateApplicationAccessPoint</a>.
        /// 4.Create a client key: You can configure the encryption password and validity period of a client key and bind the client key to an AAP. For more information, see <a href="https://help.aliyun.com/document_detail/2539509.html">CreateClientKey</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreatePolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePolicyResponse
        /// </returns>
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
            return TeaModel.ToObject<CreatePolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a permission policy to configure the keys and secrets that are allowed to access.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>To perform cryptographic operations and retrieve secret values, self-managed applications must use a client key to access a Key Management Service (KMS) instance. The following process shows how to create a client key-based application access point (AAP):
        /// 1.Create an access control rule: You can configure the private IP addresses or private CIDR blocks that are allowed to access a KMS instance. For more information, see <a href="https://help.aliyun.com/document_detail/2539407.html">CreateNetworkRule</a>.
        /// 2.Create a permission policy: You can configure the keys and secrets that are allowed to access and bind access control rules to the keys and secrets.
        /// 3.Create an AAP: You can configure an authentication method and bind a permission policy to an AAP. For more information, see <a href="https://help.aliyun.com/document_detail/2539467.html">CreateApplicationAccessPoint</a>.
        /// 4.Create a client key: You can configure the encryption password and validity period of a client key and bind the client key to an AAP. For more information, see <a href="https://help.aliyun.com/document_detail/2539509.html">CreateClientKey</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreatePolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePolicyResponse
        /// </returns>
        public CreatePolicyResponse CreatePolicy(CreatePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreatePolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a permission policy to configure the keys and secrets that are allowed to access.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>To perform cryptographic operations and retrieve secret values, self-managed applications must use a client key to access a Key Management Service (KMS) instance. The following process shows how to create a client key-based application access point (AAP):
        /// 1.Create an access control rule: You can configure the private IP addresses or private CIDR blocks that are allowed to access a KMS instance. For more information, see <a href="https://help.aliyun.com/document_detail/2539407.html">CreateNetworkRule</a>.
        /// 2.Create a permission policy: You can configure the keys and secrets that are allowed to access and bind access control rules to the keys and secrets.
        /// 3.Create an AAP: You can configure an authentication method and bind a permission policy to an AAP. For more information, see <a href="https://help.aliyun.com/document_detail/2539467.html">CreateApplicationAccessPoint</a>.
        /// 4.Create a client key: You can configure the encryption password and validity period of a client key and bind the client key to an AAP. For more information, see <a href="https://help.aliyun.com/document_detail/2539509.html">CreateClientKey</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreatePolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePolicyResponse
        /// </returns>
        public async Task<CreatePolicyResponse> CreatePolicyAsync(CreatePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreatePolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建凭据并存入凭据的初始版本。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The name of the secret.
        /// The value must be 1 to 64 characters in length and can contain letters, digits, underscores (_), forward slashes (/), plus signs (+), equal signs (=), periods (.), hyphens (-), and at signs (@). The following list describes the name requirements for different types of secrets:</para>
        /// <list type="bullet">
        /// <item><description>If the SecretType parameter is set to Generic or Rds, the name cannot start with <c>acs/</c>.</description></item>
        /// <item><description>If the SecretType parameter is set to RAMCredentials, set the SecretName parameter to <c>$Auto</c>. In this case, KMS automatically generates a secret name that starts with <c>acs/ram/user/</c>. The name includes the display name of RAM user.</description></item>
        /// <item><description>If the SecretType parameter is set to ECS, the name must start with <c>acs/ecs/</c>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateSecretRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSecretResponse
        /// </returns>
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
            return TeaModel.ToObject<CreateSecretResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建凭据并存入凭据的初始版本。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The name of the secret.
        /// The value must be 1 to 64 characters in length and can contain letters, digits, underscores (_), forward slashes (/), plus signs (+), equal signs (=), periods (.), hyphens (-), and at signs (@). The following list describes the name requirements for different types of secrets:</para>
        /// <list type="bullet">
        /// <item><description>If the SecretType parameter is set to Generic or Rds, the name cannot start with <c>acs/</c>.</description></item>
        /// <item><description>If the SecretType parameter is set to RAMCredentials, set the SecretName parameter to <c>$Auto</c>. In this case, KMS automatically generates a secret name that starts with <c>acs/ram/user/</c>. The name includes the display name of RAM user.</description></item>
        /// <item><description>If the SecretType parameter is set to ECS, the name must start with <c>acs/ecs/</c>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateSecretRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSecretResponse
        /// </returns>
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
            return TeaModel.ToObject<CreateSecretResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建凭据并存入凭据的初始版本。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The name of the secret.
        /// The value must be 1 to 64 characters in length and can contain letters, digits, underscores (_), forward slashes (/), plus signs (+), equal signs (=), periods (.), hyphens (-), and at signs (@). The following list describes the name requirements for different types of secrets:</para>
        /// <list type="bullet">
        /// <item><description>If the SecretType parameter is set to Generic or Rds, the name cannot start with <c>acs/</c>.</description></item>
        /// <item><description>If the SecretType parameter is set to RAMCredentials, set the SecretName parameter to <c>$Auto</c>. In this case, KMS automatically generates a secret name that starts with <c>acs/ram/user/</c>. The name includes the display name of RAM user.</description></item>
        /// <item><description>If the SecretType parameter is set to ECS, the name must start with <c>acs/ecs/</c>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateSecretRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSecretResponse
        /// </returns>
        public CreateSecretResponse CreateSecret(CreateSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSecretWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建凭据并存入凭据的初始版本。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The name of the secret.
        /// The value must be 1 to 64 characters in length and can contain letters, digits, underscores (_), forward slashes (/), plus signs (+), equal signs (=), periods (.), hyphens (-), and at signs (@). The following list describes the name requirements for different types of secrets:</para>
        /// <list type="bullet">
        /// <item><description>If the SecretType parameter is set to Generic or Rds, the name cannot start with <c>acs/</c>.</description></item>
        /// <item><description>If the SecretType parameter is set to RAMCredentials, set the SecretName parameter to <c>$Auto</c>. In this case, KMS automatically generates a secret name that starts with <c>acs/ram/user/</c>. The name includes the display name of RAM user.</description></item>
        /// <item><description>If the SecretType parameter is set to ECS, the name must start with <c>acs/ecs/</c>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateSecretRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSecretResponse
        /// </returns>
        public async Task<CreateSecretResponse> CreateSecretAsync(CreateSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSecretWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用Decrypt接口解密CiphertextBlob中的密文。</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DecryptRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DecryptResponse
        /// </returns>
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
            return TeaModel.ToObject<DecryptResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用Decrypt接口解密CiphertextBlob中的密文。</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DecryptRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DecryptResponse
        /// </returns>
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
            return TeaModel.ToObject<DecryptResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用Decrypt接口解密CiphertextBlob中的密文。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DecryptRequest
        /// </param>
        /// 
        /// <returns>
        /// DecryptResponse
        /// </returns>
        public DecryptResponse Decrypt(DecryptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DecryptWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用Decrypt接口解密CiphertextBlob中的密文。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DecryptRequest
        /// </param>
        /// 
        /// <returns>
        /// DecryptResponse
        /// </returns>
        public async Task<DecryptResponse> DecryptAsync(DecryptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DecryptWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DeleteAliasRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAliasResponse
        /// </returns>
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
            return TeaModel.ToObject<DeleteAliasResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteAliasRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAliasResponse
        /// </returns>
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
            return TeaModel.ToObject<DeleteAliasResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteAliasRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAliasResponse
        /// </returns>
        public DeleteAliasResponse DeleteAlias(DeleteAliasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAliasWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DeleteAliasRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAliasResponse
        /// </returns>
        public async Task<DeleteAliasResponse> DeleteAliasAsync(DeleteAliasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAliasWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an application access point (AAP).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you delete an AAP, make sure that the AAP is no longer in use. If you delete an AAP that is in use, applications that use the AAP cannot access Key Management Service (KMS). Exercise caution when you delete an AAP.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteApplicationAccessPointRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteApplicationAccessPointResponse
        /// </returns>
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
            return TeaModel.ToObject<DeleteApplicationAccessPointResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an application access point (AAP).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you delete an AAP, make sure that the AAP is no longer in use. If you delete an AAP that is in use, applications that use the AAP cannot access Key Management Service (KMS). Exercise caution when you delete an AAP.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteApplicationAccessPointRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteApplicationAccessPointResponse
        /// </returns>
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
            return TeaModel.ToObject<DeleteApplicationAccessPointResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an application access point (AAP).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you delete an AAP, make sure that the AAP is no longer in use. If you delete an AAP that is in use, applications that use the AAP cannot access Key Management Service (KMS). Exercise caution when you delete an AAP.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteApplicationAccessPointRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteApplicationAccessPointResponse
        /// </returns>
        public DeleteApplicationAccessPointResponse DeleteApplicationAccessPoint(DeleteApplicationAccessPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteApplicationAccessPointWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an application access point (AAP).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you delete an AAP, make sure that the AAP is no longer in use. If you delete an AAP that is in use, applications that use the AAP cannot access Key Management Service (KMS). Exercise caution when you delete an AAP.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteApplicationAccessPointRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteApplicationAccessPointResponse
        /// </returns>
        public async Task<DeleteApplicationAccessPointResponse> DeleteApplicationAccessPointAsync(DeleteApplicationAccessPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteApplicationAccessPointWithOptionsAsync(request, runtime);
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After the certificate and its private key and certificate chain are deleted, they cannot be restored. Proceed with caution.
        /// In this example, the certificate whose ID is <c>9a28de48-8d8b-484d-a766-dec4****</c> and its private key and certificate chain are deleted.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteCertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCertificateResponse
        /// </returns>
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
            return TeaModel.ToObject<DeleteCertificateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After the certificate and its private key and certificate chain are deleted, they cannot be restored. Proceed with caution.
        /// In this example, the certificate whose ID is <c>9a28de48-8d8b-484d-a766-dec4****</c> and its private key and certificate chain are deleted.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteCertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCertificateResponse
        /// </returns>
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
            return TeaModel.ToObject<DeleteCertificateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After the certificate and its private key and certificate chain are deleted, they cannot be restored. Proceed with caution.
        /// In this example, the certificate whose ID is <c>9a28de48-8d8b-484d-a766-dec4****</c> and its private key and certificate chain are deleted.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteCertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteCertificateResponse
        /// </returns>
        public DeleteCertificateResponse DeleteCertificate(DeleteCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCertificateWithOptions(request, runtime);
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After the certificate and its private key and certificate chain are deleted, they cannot be restored. Proceed with caution.
        /// In this example, the certificate whose ID is <c>9a28de48-8d8b-484d-a766-dec4****</c> and its private key and certificate chain are deleted.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteCertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteCertificateResponse
        /// </returns>
        public async Task<DeleteCertificateResponse> DeleteCertificateAsync(DeleteCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCertificateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you delete a client key, make sure that the client key is no longer in use. If you delete a client key that is in use, applications that use the client key cannot access Key Management Service (KMS). Exercise caution when you delete a client key.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteClientKeyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteClientKeyResponse
        /// </returns>
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
            return TeaModel.ToObject<DeleteClientKeyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you delete a client key, make sure that the client key is no longer in use. If you delete a client key that is in use, applications that use the client key cannot access Key Management Service (KMS). Exercise caution when you delete a client key.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteClientKeyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteClientKeyResponse
        /// </returns>
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
            return TeaModel.ToObject<DeleteClientKeyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you delete a client key, make sure that the client key is no longer in use. If you delete a client key that is in use, applications that use the client key cannot access Key Management Service (KMS). Exercise caution when you delete a client key.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteClientKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteClientKeyResponse
        /// </returns>
        public DeleteClientKeyResponse DeleteClientKey(DeleteClientKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteClientKeyWithOptions(request, runtime);
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you delete a client key, make sure that the client key is no longer in use. If you delete a client key that is in use, applications that use the client key cannot access Key Management Service (KMS). Exercise caution when you delete a client key.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteClientKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteClientKeyResponse
        /// </returns>
        public async Task<DeleteClientKeyResponse> DeleteClientKeyAsync(DeleteClientKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteClientKeyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation does not delete the CMK that is created by using the key material.
        /// If the CMK is in the PendingDeletion state, the state of the CMK and the scheduled deletion time do not change after you call this operation. If the CMK is not in the PendingDeletion state, the state of the CMK changes to PendingImport after you call this operation.
        /// After you delete the key material, you can upload only the same key material into the CMK.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteKeyMaterialRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteKeyMaterialResponse
        /// </returns>
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
            return TeaModel.ToObject<DeleteKeyMaterialResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation does not delete the CMK that is created by using the key material.
        /// If the CMK is in the PendingDeletion state, the state of the CMK and the scheduled deletion time do not change after you call this operation. If the CMK is not in the PendingDeletion state, the state of the CMK changes to PendingImport after you call this operation.
        /// After you delete the key material, you can upload only the same key material into the CMK.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteKeyMaterialRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteKeyMaterialResponse
        /// </returns>
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
            return TeaModel.ToObject<DeleteKeyMaterialResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation does not delete the CMK that is created by using the key material.
        /// If the CMK is in the PendingDeletion state, the state of the CMK and the scheduled deletion time do not change after you call this operation. If the CMK is not in the PendingDeletion state, the state of the CMK changes to PendingImport after you call this operation.
        /// After you delete the key material, you can upload only the same key material into the CMK.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteKeyMaterialRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteKeyMaterialResponse
        /// </returns>
        public DeleteKeyMaterialResponse DeleteKeyMaterial(DeleteKeyMaterialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteKeyMaterialWithOptions(request, runtime);
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation does not delete the CMK that is created by using the key material.
        /// If the CMK is in the PendingDeletion state, the state of the CMK and the scheduled deletion time do not change after you call this operation. If the CMK is not in the PendingDeletion state, the state of the CMK changes to PendingImport after you call this operation.
        /// After you delete the key material, you can upload only the same key material into the CMK.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteKeyMaterialRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteKeyMaterialResponse
        /// </returns>
        public async Task<DeleteKeyMaterialResponse> DeleteKeyMaterialAsync(DeleteKeyMaterialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteKeyMaterialWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a network access rule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you delete a network access rule, make sure that the network access rule is not bound to permission policies. Otherwise, related applications cannot access Key Management Service (KMS).</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteNetworkRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteNetworkRuleResponse
        /// </returns>
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
            return TeaModel.ToObject<DeleteNetworkRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a network access rule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you delete a network access rule, make sure that the network access rule is not bound to permission policies. Otherwise, related applications cannot access Key Management Service (KMS).</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteNetworkRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteNetworkRuleResponse
        /// </returns>
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
            return TeaModel.ToObject<DeleteNetworkRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a network access rule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you delete a network access rule, make sure that the network access rule is not bound to permission policies. Otherwise, related applications cannot access Key Management Service (KMS).</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteNetworkRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteNetworkRuleResponse
        /// </returns>
        public DeleteNetworkRuleResponse DeleteNetworkRule(DeleteNetworkRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteNetworkRuleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a network access rule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you delete a network access rule, make sure that the network access rule is not bound to permission policies. Otherwise, related applications cannot access Key Management Service (KMS).</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteNetworkRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteNetworkRuleResponse
        /// </returns>
        public async Task<DeleteNetworkRuleResponse> DeleteNetworkRuleAsync(DeleteNetworkRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteNetworkRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a permission policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you delete a permission policy, make sure that the permission policy is not associated with application access points (AAPs). Otherwise, related applications cannot access Key Management Service (KMS).</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeletePolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeletePolicyResponse
        /// </returns>
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
            return TeaModel.ToObject<DeletePolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a permission policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you delete a permission policy, make sure that the permission policy is not associated with application access points (AAPs). Otherwise, related applications cannot access Key Management Service (KMS).</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeletePolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeletePolicyResponse
        /// </returns>
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
            return TeaModel.ToObject<DeletePolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a permission policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you delete a permission policy, make sure that the permission policy is not associated with application access points (AAPs). Otherwise, related applications cannot access Key Management Service (KMS).</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeletePolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// DeletePolicyResponse
        /// </returns>
        public DeletePolicyResponse DeletePolicy(DeletePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeletePolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a permission policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you delete a permission policy, make sure that the permission policy is not associated with application access points (AAPs). Otherwise, related applications cannot access Key Management Service (KMS).</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeletePolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// DeletePolicyResponse
        /// </returns>
        public async Task<DeletePolicyResponse> DeletePolicyAsync(DeletePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeletePolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you call this operation without specifying a recovery period, the deleted secret can be recovered within 30 days.
        /// If you specify a recovery period, the deleted secret can be recovered within the recovery period. You can also forcibly delete a secret. A forcibly deleted secret cannot be recovered.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteSecretRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSecretResponse
        /// </returns>
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
            return TeaModel.ToObject<DeleteSecretResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you call this operation without specifying a recovery period, the deleted secret can be recovered within 30 days.
        /// If you specify a recovery period, the deleted secret can be recovered within the recovery period. You can also forcibly delete a secret. A forcibly deleted secret cannot be recovered.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteSecretRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSecretResponse
        /// </returns>
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
            return TeaModel.ToObject<DeleteSecretResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you call this operation without specifying a recovery period, the deleted secret can be recovered within 30 days.
        /// If you specify a recovery period, the deleted secret can be recovered within the recovery period. You can also forcibly delete a secret. A forcibly deleted secret cannot be recovered.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteSecretRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSecretResponse
        /// </returns>
        public DeleteSecretResponse DeleteSecret(DeleteSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSecretWithOptions(request, runtime);
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you call this operation without specifying a recovery period, the deleted secret can be recovered within 30 days.
        /// If you specify a recovery period, the deleted secret can be recovered within the recovery period. You can also forcibly delete a secret. A forcibly deleted secret cannot be recovered.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteSecretRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSecretResponse
        /// </returns>
        public async Task<DeleteSecretResponse> DeleteSecretAsync(DeleteSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSecretWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DescribeAccountKmsStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAccountKmsStatusResponse
        /// </returns>
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
            return TeaModel.ToObject<DescribeAccountKmsStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DescribeAccountKmsStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAccountKmsStatusResponse
        /// </returns>
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
            return TeaModel.ToObject<DescribeAccountKmsStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <returns>
        /// DescribeAccountKmsStatusResponse
        /// </returns>
        public DescribeAccountKmsStatusResponse DescribeAccountKmsStatus()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAccountKmsStatusWithOptions(runtime);
        }

        /// <returns>
        /// DescribeAccountKmsStatusResponse
        /// </returns>
        public async Task<DescribeAccountKmsStatusResponse> DescribeAccountKmsStatusAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAccountKmsStatusWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an application access point (AAP).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeApplicationAccessPointRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeApplicationAccessPointResponse
        /// </returns>
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
            return TeaModel.ToObject<DescribeApplicationAccessPointResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an application access point (AAP).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeApplicationAccessPointRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeApplicationAccessPointResponse
        /// </returns>
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
            return TeaModel.ToObject<DescribeApplicationAccessPointResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an application access point (AAP).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeApplicationAccessPointRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeApplicationAccessPointResponse
        /// </returns>
        public DescribeApplicationAccessPointResponse DescribeApplicationAccessPoint(DescribeApplicationAccessPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeApplicationAccessPointWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an application access point (AAP).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeApplicationAccessPointRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeApplicationAccessPointResponse
        /// </returns>
        public async Task<DescribeApplicationAccessPointResponse> DescribeApplicationAccessPointAsync(DescribeApplicationAccessPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeApplicationAccessPointWithOptionsAsync(request, runtime);
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In this example, the information about the certificate whose ID is <c>9a28de48-8d8b-484d-a766-dec4****</c> is queried. The certificate information includes the certificate ID, creation time, certificate issuer, validity period, serial number, and signature algorithm.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCertificateResponse
        /// </returns>
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
            return TeaModel.ToObject<DescribeCertificateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In this example, the information about the certificate whose ID is <c>9a28de48-8d8b-484d-a766-dec4****</c> is queried. The certificate information includes the certificate ID, creation time, certificate issuer, validity period, serial number, and signature algorithm.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCertificateResponse
        /// </returns>
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
            return TeaModel.ToObject<DescribeCertificateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In this example, the information about the certificate whose ID is <c>9a28de48-8d8b-484d-a766-dec4****</c> is queried. The certificate information includes the certificate ID, creation time, certificate issuer, validity period, serial number, and signature algorithm.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCertificateResponse
        /// </returns>
        public DescribeCertificateResponse DescribeCertificate(DescribeCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCertificateWithOptions(request, runtime);
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In this example, the information about the certificate whose ID is <c>9a28de48-8d8b-484d-a766-dec4****</c> is queried. The certificate information includes the certificate ID, creation time, certificate issuer, validity period, serial number, and signature algorithm.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCertificateResponse
        /// </returns>
        public async Task<DescribeCertificateResponse> DescribeCertificateAsync(DescribeCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCertificateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a customer master key (CMK).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can query the information about the CMK <c>05754286-3ba2-4fa6-8d41-4323aca6****</c> by using parameter settings provided in this topic. The information includes the creator, creation time, status, and deletion protection status of the CMK.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeKeyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeKeyResponse
        /// </returns>
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
            return TeaModel.ToObject<DescribeKeyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a customer master key (CMK).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can query the information about the CMK <c>05754286-3ba2-4fa6-8d41-4323aca6****</c> by using parameter settings provided in this topic. The information includes the creator, creation time, status, and deletion protection status of the CMK.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeKeyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeKeyResponse
        /// </returns>
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
            return TeaModel.ToObject<DescribeKeyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a customer master key (CMK).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can query the information about the CMK <c>05754286-3ba2-4fa6-8d41-4323aca6****</c> by using parameter settings provided in this topic. The information includes the creator, creation time, status, and deletion protection status of the CMK.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeKeyResponse
        /// </returns>
        public DescribeKeyResponse DescribeKey(DescribeKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeKeyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a customer master key (CMK).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can query the information about the CMK <c>05754286-3ba2-4fa6-8d41-4323aca6****</c> by using parameter settings provided in this topic. The information includes the creator, creation time, status, and deletion protection status of the CMK.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeKeyResponse
        /// </returns>
        public async Task<DescribeKeyResponse> DescribeKeyAsync(DescribeKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeKeyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the information about a version of the CMK <c>1234abcd-12ab-34cd-56ef-12345678****</c>. The ID of the CMK version is <c>2ab1a983-7072-4bbc-a582-584b5bd8****</c>. The response shows that the creation time of the CMK version is <c>2016-03-25T10:42:40Z</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeKeyVersionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeKeyVersionResponse
        /// </returns>
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
            return TeaModel.ToObject<DescribeKeyVersionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the information about a version of the CMK <c>1234abcd-12ab-34cd-56ef-12345678****</c>. The ID of the CMK version is <c>2ab1a983-7072-4bbc-a582-584b5bd8****</c>. The response shows that the creation time of the CMK version is <c>2016-03-25T10:42:40Z</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeKeyVersionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeKeyVersionResponse
        /// </returns>
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
            return TeaModel.ToObject<DescribeKeyVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the information about a version of the CMK <c>1234abcd-12ab-34cd-56ef-12345678****</c>. The ID of the CMK version is <c>2ab1a983-7072-4bbc-a582-584b5bd8****</c>. The response shows that the creation time of the CMK version is <c>2016-03-25T10:42:40Z</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeKeyVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeKeyVersionResponse
        /// </returns>
        public DescribeKeyVersionResponse DescribeKeyVersion(DescribeKeyVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeKeyVersionWithOptions(request, runtime);
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the information about a version of the CMK <c>1234abcd-12ab-34cd-56ef-12345678****</c>. The ID of the CMK version is <c>2ab1a983-7072-4bbc-a582-584b5bd8****</c>. The response shows that the creation time of the CMK version is <c>2016-03-25T10:42:40Z</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeKeyVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeKeyVersionResponse
        /// </returns>
        public async Task<DescribeKeyVersionResponse> DescribeKeyVersionAsync(DescribeKeyVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeKeyVersionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an access control rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeNetworkRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeNetworkRuleResponse
        /// </returns>
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
            return TeaModel.ToObject<DescribeNetworkRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an access control rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeNetworkRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeNetworkRuleResponse
        /// </returns>
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
            return TeaModel.ToObject<DescribeNetworkRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an access control rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeNetworkRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeNetworkRuleResponse
        /// </returns>
        public DescribeNetworkRuleResponse DescribeNetworkRule(DescribeNetworkRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeNetworkRuleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an access control rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeNetworkRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeNetworkRuleResponse
        /// </returns>
        public async Task<DescribeNetworkRuleResponse> DescribeNetworkRuleAsync(DescribeNetworkRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeNetworkRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a permission policy.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePolicyResponse
        /// </returns>
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
            return TeaModel.ToObject<DescribePolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a permission policy.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePolicyResponse
        /// </returns>
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
            return TeaModel.ToObject<DescribePolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a permission policy.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePolicyResponse
        /// </returns>
        public DescribePolicyResponse DescribePolicy(DescribePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a permission policy.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePolicyResponse
        /// </returns>
        public async Task<DescribePolicyResponse> DescribePolicyAsync(DescribePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries available regions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Debugging</h2>
        /// <para><a href="https://api.aliyun.com/#product=Kms%5C&api=DescribeRegions%5C&type=RPC%5C&version=2016-01-20">OpenAPI Explorer automatically calculates the signature value. For your convenience, we recommend that you call this operation in OpenAPI Explorer. OpenAPI Explorer dynamically generates the sample code of the operation for different SDKs.</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeRegionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeRegionsResponse
        /// </returns>
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
            return TeaModel.ToObject<DescribeRegionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries available regions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Debugging</h2>
        /// <para><a href="https://api.aliyun.com/#product=Kms%5C&api=DescribeRegions%5C&type=RPC%5C&version=2016-01-20">OpenAPI Explorer automatically calculates the signature value. For your convenience, we recommend that you call this operation in OpenAPI Explorer. OpenAPI Explorer dynamically generates the sample code of the operation for different SDKs.</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeRegionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeRegionsResponse
        /// </returns>
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
            return TeaModel.ToObject<DescribeRegionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries available regions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Debugging</h2>
        /// <para><a href="https://api.aliyun.com/#product=Kms%5C&api=DescribeRegions%5C&type=RPC%5C&version=2016-01-20">OpenAPI Explorer automatically calculates the signature value. For your convenience, we recommend that you call this operation in OpenAPI Explorer. OpenAPI Explorer dynamically generates the sample code of the operation for different SDKs.</a></para>
        /// </description>
        /// 
        /// <returns>
        /// DescribeRegionsResponse
        /// </returns>
        public DescribeRegionsResponse DescribeRegions()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRegionsWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries available regions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Debugging</h2>
        /// <para><a href="https://api.aliyun.com/#product=Kms%5C&api=DescribeRegions%5C&type=RPC%5C&version=2016-01-20">OpenAPI Explorer automatically calculates the signature value. For your convenience, we recommend that you call this operation in OpenAPI Explorer. OpenAPI Explorer dynamically generates the sample code of the operation for different SDKs.</a></para>
        /// </description>
        /// 
        /// <returns>
        /// DescribeRegionsResponse
        /// </returns>
        public async Task<DescribeRegionsResponse> DescribeRegionsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRegionsWithOptionsAsync(runtime);
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation returns the metadata of a secret. This operation does not return the secret value.
        /// In this example, the metadata of the secret named <c>secret001</c> is queried.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeSecretRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSecretResponse
        /// </returns>
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
            return TeaModel.ToObject<DescribeSecretResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation returns the metadata of a secret. This operation does not return the secret value.
        /// In this example, the metadata of the secret named <c>secret001</c> is queried.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeSecretRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSecretResponse
        /// </returns>
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
            return TeaModel.ToObject<DescribeSecretResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation returns the metadata of a secret. This operation does not return the secret value.
        /// In this example, the metadata of the secret named <c>secret001</c> is queried.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeSecretRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSecretResponse
        /// </returns>
        public DescribeSecretResponse DescribeSecret(DescribeSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSecretWithOptions(request, runtime);
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation returns the metadata of a secret. This operation does not return the secret value.
        /// In this example, the metadata of the secret named <c>secret001</c> is queried.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeSecretRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSecretResponse
        /// </returns>
        public async Task<DescribeSecretResponse> DescribeSecretAsync(DescribeSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSecretWithOptionsAsync(request, runtime);
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If a customer master key (CMK) is disabled, the ciphertext encrypted by using this CMK cannot be decrypted until you re-enable it. You can call the <a href="https://help.aliyun.com/document_detail/35150.html">EnableKey</a> operation to enable the CMK.
        /// In this example, the CMK whose ID is <c>1234abcd-12ab-34cd-56ef-12345678****</c> is disabled.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DisableKeyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisableKeyResponse
        /// </returns>
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
            return TeaModel.ToObject<DisableKeyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If a customer master key (CMK) is disabled, the ciphertext encrypted by using this CMK cannot be decrypted until you re-enable it. You can call the <a href="https://help.aliyun.com/document_detail/35150.html">EnableKey</a> operation to enable the CMK.
        /// In this example, the CMK whose ID is <c>1234abcd-12ab-34cd-56ef-12345678****</c> is disabled.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DisableKeyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisableKeyResponse
        /// </returns>
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
            return TeaModel.ToObject<DisableKeyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If a customer master key (CMK) is disabled, the ciphertext encrypted by using this CMK cannot be decrypted until you re-enable it. You can call the <a href="https://help.aliyun.com/document_detail/35150.html">EnableKey</a> operation to enable the CMK.
        /// In this example, the CMK whose ID is <c>1234abcd-12ab-34cd-56ef-12345678****</c> is disabled.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DisableKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// DisableKeyResponse
        /// </returns>
        public DisableKeyResponse DisableKey(DisableKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableKeyWithOptions(request, runtime);
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If a customer master key (CMK) is disabled, the ciphertext encrypted by using this CMK cannot be decrypted until you re-enable it. You can call the <a href="https://help.aliyun.com/document_detail/35150.html">EnableKey</a> operation to enable the CMK.
        /// In this example, the CMK whose ID is <c>1234abcd-12ab-34cd-56ef-12345678****</c> is disabled.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DisableKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// DisableKeyResponse
        /// </returns>
        public async Task<DisableKeyResponse> DisableKeyAsync(DisableKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableKeyWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// EnableKeyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableKeyResponse
        /// </returns>
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
            return TeaModel.ToObject<EnableKeyResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// EnableKeyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableKeyResponse
        /// </returns>
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
            return TeaModel.ToObject<EnableKeyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// EnableKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// EnableKeyResponse
        /// </returns>
        public EnableKeyResponse EnableKey(EnableKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableKeyWithOptions(request, runtime);
        }

        /// <param name="request">
        /// EnableKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// EnableKeyResponse
        /// </returns>
        public async Task<EnableKeyResponse> EnableKeyAsync(EnableKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableKeyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  KMS uses the primary version of a specified CMK to encrypt data.</para>
        /// <list type="bullet">
        /// <item><description>Only data of 6 KB or less can be encrypted. For example, you can call this operation to encrypt RSA keys, database access passwords, or other sensitive information.</description></item>
        /// <item><description>When you migrate encrypted data across regions, you can call this operation in the destination region to encrypt the plaintext of the data key that is used to encrypt the migrated data in the source region. This way, the ciphertext of the data key is generated in the destination region. You can also call the <a href="https://help.aliyun.com/document_detail/28950.html">Decrypt</a> operation to decrypt the data key.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// EncryptRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EncryptResponse
        /// </returns>
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
            return TeaModel.ToObject<EncryptResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  KMS uses the primary version of a specified CMK to encrypt data.</para>
        /// <list type="bullet">
        /// <item><description>Only data of 6 KB or less can be encrypted. For example, you can call this operation to encrypt RSA keys, database access passwords, or other sensitive information.</description></item>
        /// <item><description>When you migrate encrypted data across regions, you can call this operation in the destination region to encrypt the plaintext of the data key that is used to encrypt the migrated data in the source region. This way, the ciphertext of the data key is generated in the destination region. You can also call the <a href="https://help.aliyun.com/document_detail/28950.html">Decrypt</a> operation to decrypt the data key.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// EncryptRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EncryptResponse
        /// </returns>
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
            return TeaModel.ToObject<EncryptResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  KMS uses the primary version of a specified CMK to encrypt data.</para>
        /// <list type="bullet">
        /// <item><description>Only data of 6 KB or less can be encrypted. For example, you can call this operation to encrypt RSA keys, database access passwords, or other sensitive information.</description></item>
        /// <item><description>When you migrate encrypted data across regions, you can call this operation in the destination region to encrypt the plaintext of the data key that is used to encrypt the migrated data in the source region. This way, the ciphertext of the data key is generated in the destination region. You can also call the <a href="https://help.aliyun.com/document_detail/28950.html">Decrypt</a> operation to decrypt the data key.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// EncryptRequest
        /// </param>
        /// 
        /// <returns>
        /// EncryptResponse
        /// </returns>
        public EncryptResponse Encrypt(EncryptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EncryptWithOptions(request, runtime);
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  KMS uses the primary version of a specified CMK to encrypt data.</para>
        /// <list type="bullet">
        /// <item><description>Only data of 6 KB or less can be encrypted. For example, you can call this operation to encrypt RSA keys, database access passwords, or other sensitive information.</description></item>
        /// <item><description>When you migrate encrypted data across regions, you can call this operation in the destination region to encrypt the plaintext of the data key that is used to encrypt the migrated data in the source region. This way, the ciphertext of the data key is generated in the destination region. You can also call the <a href="https://help.aliyun.com/document_detail/28950.html">Decrypt</a> operation to decrypt the data key.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// EncryptRequest
        /// </param>
        /// 
        /// <returns>
        /// EncryptResponse
        /// </returns>
        public async Task<EncryptResponse> EncryptAsync(EncryptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EncryptWithOptionsAsync(request, runtime);
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/134043.html">GenerateDataKeyWithoutPlaintext</a> operation to generate a data key, which is encrypted by a CMK. If you want to distribute the data key to other regions or cryptographic modules, you can call the ExportDataKey operation to use a public key to encrypt the data key.
        /// Then, you can import the ciphertext of the data key to the cryptographic module where the private key is stored. This way, the data key is securely distributed from KMS to the cryptographic module. After the data key is imported to the cryptographic module, you can use it to encrypt or decrypt data.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ExportDataKeyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExportDataKeyResponse
        /// </returns>
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
            return TeaModel.ToObject<ExportDataKeyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/134043.html">GenerateDataKeyWithoutPlaintext</a> operation to generate a data key, which is encrypted by a CMK. If you want to distribute the data key to other regions or cryptographic modules, you can call the ExportDataKey operation to use a public key to encrypt the data key.
        /// Then, you can import the ciphertext of the data key to the cryptographic module where the private key is stored. This way, the data key is securely distributed from KMS to the cryptographic module. After the data key is imported to the cryptographic module, you can use it to encrypt or decrypt data.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ExportDataKeyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExportDataKeyResponse
        /// </returns>
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
            return TeaModel.ToObject<ExportDataKeyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/134043.html">GenerateDataKeyWithoutPlaintext</a> operation to generate a data key, which is encrypted by a CMK. If you want to distribute the data key to other regions or cryptographic modules, you can call the ExportDataKey operation to use a public key to encrypt the data key.
        /// Then, you can import the ciphertext of the data key to the cryptographic module where the private key is stored. This way, the data key is securely distributed from KMS to the cryptographic module. After the data key is imported to the cryptographic module, you can use it to encrypt or decrypt data.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ExportDataKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// ExportDataKeyResponse
        /// </returns>
        public ExportDataKeyResponse ExportDataKey(ExportDataKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExportDataKeyWithOptions(request, runtime);
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/134043.html">GenerateDataKeyWithoutPlaintext</a> operation to generate a data key, which is encrypted by a CMK. If you want to distribute the data key to other regions or cryptographic modules, you can call the ExportDataKey operation to use a public key to encrypt the data key.
        /// Then, you can import the ciphertext of the data key to the cryptographic module where the private key is stored. This way, the data key is securely distributed from KMS to the cryptographic module. After the data key is imported to the cryptographic module, you can use it to encrypt or decrypt data.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ExportDataKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// ExportDataKeyResponse
        /// </returns>
        public async Task<ExportDataKeyResponse> ExportDataKeyAsync(ExportDataKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExportDataKeyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>We recommend that you perform the following steps to import your data key to a cryptographic module:</para>
        /// <list type="bullet">
        /// <item><description>Call the GenerateAndExportDataKey operation to generate a data key and obtain both the ciphertext of the data key encrypted by using the CMK and that encrypted by using the public key.</description></item>
        /// <item><description>Store the ciphertext of the data key encrypted by using the CMK in KMS Secrets Manager or in a storage service such as ApsaraDB. This ciphertext is used for backup and restoration.</description></item>
        /// <item><description>Import the ciphertext of the data key encrypted by using the public key to the cryptographic module where the private key is stored. Then, you can use the data key to encrypt or decrypt data.<remarks>
        /// <para> The CMK that you specify in the request of this operation is only used to encrypt the data key and is not involved in the generation of the data key. KMS does not record or store the data keys randomly generated by calling this operation. You must take note of the data keys and the returned ciphertext.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// GenerateAndExportDataKeyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateAndExportDataKeyResponse
        /// </returns>
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
            return TeaModel.ToObject<GenerateAndExportDataKeyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>We recommend that you perform the following steps to import your data key to a cryptographic module:</para>
        /// <list type="bullet">
        /// <item><description>Call the GenerateAndExportDataKey operation to generate a data key and obtain both the ciphertext of the data key encrypted by using the CMK and that encrypted by using the public key.</description></item>
        /// <item><description>Store the ciphertext of the data key encrypted by using the CMK in KMS Secrets Manager or in a storage service such as ApsaraDB. This ciphertext is used for backup and restoration.</description></item>
        /// <item><description>Import the ciphertext of the data key encrypted by using the public key to the cryptographic module where the private key is stored. Then, you can use the data key to encrypt or decrypt data.<remarks>
        /// <para> The CMK that you specify in the request of this operation is only used to encrypt the data key and is not involved in the generation of the data key. KMS does not record or store the data keys randomly generated by calling this operation. You must take note of the data keys and the returned ciphertext.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// GenerateAndExportDataKeyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateAndExportDataKeyResponse
        /// </returns>
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
            return TeaModel.ToObject<GenerateAndExportDataKeyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>We recommend that you perform the following steps to import your data key to a cryptographic module:</para>
        /// <list type="bullet">
        /// <item><description>Call the GenerateAndExportDataKey operation to generate a data key and obtain both the ciphertext of the data key encrypted by using the CMK and that encrypted by using the public key.</description></item>
        /// <item><description>Store the ciphertext of the data key encrypted by using the CMK in KMS Secrets Manager or in a storage service such as ApsaraDB. This ciphertext is used for backup and restoration.</description></item>
        /// <item><description>Import the ciphertext of the data key encrypted by using the public key to the cryptographic module where the private key is stored. Then, you can use the data key to encrypt or decrypt data.<remarks>
        /// <para> The CMK that you specify in the request of this operation is only used to encrypt the data key and is not involved in the generation of the data key. KMS does not record or store the data keys randomly generated by calling this operation. You must take note of the data keys and the returned ciphertext.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GenerateAndExportDataKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateAndExportDataKeyResponse
        /// </returns>
        public GenerateAndExportDataKeyResponse GenerateAndExportDataKey(GenerateAndExportDataKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateAndExportDataKeyWithOptions(request, runtime);
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>We recommend that you perform the following steps to import your data key to a cryptographic module:</para>
        /// <list type="bullet">
        /// <item><description>Call the GenerateAndExportDataKey operation to generate a data key and obtain both the ciphertext of the data key encrypted by using the CMK and that encrypted by using the public key.</description></item>
        /// <item><description>Store the ciphertext of the data key encrypted by using the CMK in KMS Secrets Manager or in a storage service such as ApsaraDB. This ciphertext is used for backup and restoration.</description></item>
        /// <item><description>Import the ciphertext of the data key encrypted by using the public key to the cryptographic module where the private key is stored. Then, you can use the data key to encrypt or decrypt data.<remarks>
        /// <para> The CMK that you specify in the request of this operation is only used to encrypt the data key and is not involved in the generation of the data key. KMS does not record or store the data keys randomly generated by calling this operation. You must take note of the data keys and the returned ciphertext.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GenerateAndExportDataKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateAndExportDataKeyResponse
        /// </returns>
        public async Task<GenerateAndExportDataKeyResponse> GenerateAndExportDataKeyAsync(GenerateAndExportDataKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateAndExportDataKeyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成一个数据密钥</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation creates a random data key, encrypts the data key by using the specified customer master key (CMK), and returns the plaintext and ciphertext of the data key. You can use the plaintext of the data key to locally encrypt your data without using KMS and store the encrypted data together with the ciphertext of the data key. You can obtain the plaintext of the data key from the Plaintext parameter in the response and the ciphertext of the data key from the CiphertextBlob parameter in the response.
        /// The CMK that you specify in the request of this operation is only used to encrypt the data key and is not involved in the generation of the data key. KMS does not record or store the generated data key. Therefore, you need to store the ciphertext of the data key in persistent storage.
        /// We recommend that you locally encrypt data by performing the following steps:
        /// 1\. Call the GenerateDataKey operation.
        /// 2\. Use the plaintext of the data key that you obtain to locally encrypt data without using KMS. Then, delete the plaintext of the data key from the memory.
        /// 3\. Store the encrypted data together with the ciphertext of the data key that you obtain.
        /// We recommend that you locally decrypt data by performing the following steps:</para>
        /// <list type="bullet">
        /// <item><description>Call the <a href="https://help.aliyun.com/document_detail/28950.html">Decrypt</a> operation to decrypt the locally stored ciphertext of the data key. The plaintext of data key is then returned.</description></item>
        /// <item><description>Use the plaintext of the data key to locally decrypt data and then delete the plaintext of the data key from the memory.
        /// In this example, a random data key is generated for the CMK whose ID is <c>7906979c-8e06-46a2-be2d-68e3ccbc****</c>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// GenerateDataKeyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateDataKeyResponse
        /// </returns>
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
            return TeaModel.ToObject<GenerateDataKeyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成一个数据密钥</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation creates a random data key, encrypts the data key by using the specified customer master key (CMK), and returns the plaintext and ciphertext of the data key. You can use the plaintext of the data key to locally encrypt your data without using KMS and store the encrypted data together with the ciphertext of the data key. You can obtain the plaintext of the data key from the Plaintext parameter in the response and the ciphertext of the data key from the CiphertextBlob parameter in the response.
        /// The CMK that you specify in the request of this operation is only used to encrypt the data key and is not involved in the generation of the data key. KMS does not record or store the generated data key. Therefore, you need to store the ciphertext of the data key in persistent storage.
        /// We recommend that you locally encrypt data by performing the following steps:
        /// 1\. Call the GenerateDataKey operation.
        /// 2\. Use the plaintext of the data key that you obtain to locally encrypt data without using KMS. Then, delete the plaintext of the data key from the memory.
        /// 3\. Store the encrypted data together with the ciphertext of the data key that you obtain.
        /// We recommend that you locally decrypt data by performing the following steps:</para>
        /// <list type="bullet">
        /// <item><description>Call the <a href="https://help.aliyun.com/document_detail/28950.html">Decrypt</a> operation to decrypt the locally stored ciphertext of the data key. The plaintext of data key is then returned.</description></item>
        /// <item><description>Use the plaintext of the data key to locally decrypt data and then delete the plaintext of the data key from the memory.
        /// In this example, a random data key is generated for the CMK whose ID is <c>7906979c-8e06-46a2-be2d-68e3ccbc****</c>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// GenerateDataKeyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateDataKeyResponse
        /// </returns>
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
            return TeaModel.ToObject<GenerateDataKeyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成一个数据密钥</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation creates a random data key, encrypts the data key by using the specified customer master key (CMK), and returns the plaintext and ciphertext of the data key. You can use the plaintext of the data key to locally encrypt your data without using KMS and store the encrypted data together with the ciphertext of the data key. You can obtain the plaintext of the data key from the Plaintext parameter in the response and the ciphertext of the data key from the CiphertextBlob parameter in the response.
        /// The CMK that you specify in the request of this operation is only used to encrypt the data key and is not involved in the generation of the data key. KMS does not record or store the generated data key. Therefore, you need to store the ciphertext of the data key in persistent storage.
        /// We recommend that you locally encrypt data by performing the following steps:
        /// 1\. Call the GenerateDataKey operation.
        /// 2\. Use the plaintext of the data key that you obtain to locally encrypt data without using KMS. Then, delete the plaintext of the data key from the memory.
        /// 3\. Store the encrypted data together with the ciphertext of the data key that you obtain.
        /// We recommend that you locally decrypt data by performing the following steps:</para>
        /// <list type="bullet">
        /// <item><description>Call the <a href="https://help.aliyun.com/document_detail/28950.html">Decrypt</a> operation to decrypt the locally stored ciphertext of the data key. The plaintext of data key is then returned.</description></item>
        /// <item><description>Use the plaintext of the data key to locally decrypt data and then delete the plaintext of the data key from the memory.
        /// In this example, a random data key is generated for the CMK whose ID is <c>7906979c-8e06-46a2-be2d-68e3ccbc****</c>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GenerateDataKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateDataKeyResponse
        /// </returns>
        public GenerateDataKeyResponse GenerateDataKey(GenerateDataKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateDataKeyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成一个数据密钥</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation creates a random data key, encrypts the data key by using the specified customer master key (CMK), and returns the plaintext and ciphertext of the data key. You can use the plaintext of the data key to locally encrypt your data without using KMS and store the encrypted data together with the ciphertext of the data key. You can obtain the plaintext of the data key from the Plaintext parameter in the response and the ciphertext of the data key from the CiphertextBlob parameter in the response.
        /// The CMK that you specify in the request of this operation is only used to encrypt the data key and is not involved in the generation of the data key. KMS does not record or store the generated data key. Therefore, you need to store the ciphertext of the data key in persistent storage.
        /// We recommend that you locally encrypt data by performing the following steps:
        /// 1\. Call the GenerateDataKey operation.
        /// 2\. Use the plaintext of the data key that you obtain to locally encrypt data without using KMS. Then, delete the plaintext of the data key from the memory.
        /// 3\. Store the encrypted data together with the ciphertext of the data key that you obtain.
        /// We recommend that you locally decrypt data by performing the following steps:</para>
        /// <list type="bullet">
        /// <item><description>Call the <a href="https://help.aliyun.com/document_detail/28950.html">Decrypt</a> operation to decrypt the locally stored ciphertext of the data key. The plaintext of data key is then returned.</description></item>
        /// <item><description>Use the plaintext of the data key to locally decrypt data and then delete the plaintext of the data key from the memory.
        /// In this example, a random data key is generated for the CMK whose ID is <c>7906979c-8e06-46a2-be2d-68e3ccbc****</c>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GenerateDataKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateDataKeyResponse
        /// </returns>
        public async Task<GenerateDataKeyResponse> GenerateDataKeyAsync(GenerateDataKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateDataKeyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates a random data key, which can be used to encrypt local data.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation creates a random data key, encrypts the data key by using a specific symmetric CMK, and returns the ciphertext of the data key. This operation serves the same purpose as the <a href="https://help.aliyun.com/document_detail/28948.html">GenerateDataKey</a> operation. The only difference is that this operation does not return the plaintext of the data key.
        /// The CMK that you specify in the request of this operation is only used to encrypt the data key and is not involved in the generation of the data key. KMS does not record or store the generated data key.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This operation applies to the scenario when you do not need to use the data key to immediately encrypt data. Before you can use the data key to encrypt data, you must call the <a href="https://help.aliyun.com/document_detail/28950.html">Decrypt</a> operation to decrypt the ciphertext of the data key.</description></item>
        /// <item><description>This operation is also suitable for a distributed system with different trust levels. For example, a system stores data in different partitions based on a preset trust policy. A module creates different partitions and generates different data keys for each partition in advance. This module is not involved in data production and consumption after it completes initialization of the control plane. This module is the key provider. When producing and consuming data, modules on the control plane obtain the ciphertext of the data key for a partition first. After decrypting the ciphertext of the data key, modules on the control plane use the plaintext of the data key to encrypt or decrypt data and then clear the plaintext of the data key from the memory. In such a system, the key provider does not need to obtain the plaintext of the data key. It only needs to have the permissions to call the GenerateDataKeyWithoutPlaintext operation. The data producers or consumers do not need to generate new data keys. They only need to have the permissions to call the Decrypt operation.</description></item>
        /// </list>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// GenerateDataKeyWithoutPlaintextRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateDataKeyWithoutPlaintextResponse
        /// </returns>
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
            return TeaModel.ToObject<GenerateDataKeyWithoutPlaintextResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates a random data key, which can be used to encrypt local data.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation creates a random data key, encrypts the data key by using a specific symmetric CMK, and returns the ciphertext of the data key. This operation serves the same purpose as the <a href="https://help.aliyun.com/document_detail/28948.html">GenerateDataKey</a> operation. The only difference is that this operation does not return the plaintext of the data key.
        /// The CMK that you specify in the request of this operation is only used to encrypt the data key and is not involved in the generation of the data key. KMS does not record or store the generated data key.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This operation applies to the scenario when you do not need to use the data key to immediately encrypt data. Before you can use the data key to encrypt data, you must call the <a href="https://help.aliyun.com/document_detail/28950.html">Decrypt</a> operation to decrypt the ciphertext of the data key.</description></item>
        /// <item><description>This operation is also suitable for a distributed system with different trust levels. For example, a system stores data in different partitions based on a preset trust policy. A module creates different partitions and generates different data keys for each partition in advance. This module is not involved in data production and consumption after it completes initialization of the control plane. This module is the key provider. When producing and consuming data, modules on the control plane obtain the ciphertext of the data key for a partition first. After decrypting the ciphertext of the data key, modules on the control plane use the plaintext of the data key to encrypt or decrypt data and then clear the plaintext of the data key from the memory. In such a system, the key provider does not need to obtain the plaintext of the data key. It only needs to have the permissions to call the GenerateDataKeyWithoutPlaintext operation. The data producers or consumers do not need to generate new data keys. They only need to have the permissions to call the Decrypt operation.</description></item>
        /// </list>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// GenerateDataKeyWithoutPlaintextRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateDataKeyWithoutPlaintextResponse
        /// </returns>
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
            return TeaModel.ToObject<GenerateDataKeyWithoutPlaintextResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates a random data key, which can be used to encrypt local data.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation creates a random data key, encrypts the data key by using a specific symmetric CMK, and returns the ciphertext of the data key. This operation serves the same purpose as the <a href="https://help.aliyun.com/document_detail/28948.html">GenerateDataKey</a> operation. The only difference is that this operation does not return the plaintext of the data key.
        /// The CMK that you specify in the request of this operation is only used to encrypt the data key and is not involved in the generation of the data key. KMS does not record or store the generated data key.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This operation applies to the scenario when you do not need to use the data key to immediately encrypt data. Before you can use the data key to encrypt data, you must call the <a href="https://help.aliyun.com/document_detail/28950.html">Decrypt</a> operation to decrypt the ciphertext of the data key.</description></item>
        /// <item><description>This operation is also suitable for a distributed system with different trust levels. For example, a system stores data in different partitions based on a preset trust policy. A module creates different partitions and generates different data keys for each partition in advance. This module is not involved in data production and consumption after it completes initialization of the control plane. This module is the key provider. When producing and consuming data, modules on the control plane obtain the ciphertext of the data key for a partition first. After decrypting the ciphertext of the data key, modules on the control plane use the plaintext of the data key to encrypt or decrypt data and then clear the plaintext of the data key from the memory. In such a system, the key provider does not need to obtain the plaintext of the data key. It only needs to have the permissions to call the GenerateDataKeyWithoutPlaintext operation. The data producers or consumers do not need to generate new data keys. They only need to have the permissions to call the Decrypt operation.</description></item>
        /// </list>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// GenerateDataKeyWithoutPlaintextRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateDataKeyWithoutPlaintextResponse
        /// </returns>
        public GenerateDataKeyWithoutPlaintextResponse GenerateDataKeyWithoutPlaintext(GenerateDataKeyWithoutPlaintextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateDataKeyWithoutPlaintextWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates a random data key, which can be used to encrypt local data.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation creates a random data key, encrypts the data key by using a specific symmetric CMK, and returns the ciphertext of the data key. This operation serves the same purpose as the <a href="https://help.aliyun.com/document_detail/28948.html">GenerateDataKey</a> operation. The only difference is that this operation does not return the plaintext of the data key.
        /// The CMK that you specify in the request of this operation is only used to encrypt the data key and is not involved in the generation of the data key. KMS does not record or store the generated data key.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This operation applies to the scenario when you do not need to use the data key to immediately encrypt data. Before you can use the data key to encrypt data, you must call the <a href="https://help.aliyun.com/document_detail/28950.html">Decrypt</a> operation to decrypt the ciphertext of the data key.</description></item>
        /// <item><description>This operation is also suitable for a distributed system with different trust levels. For example, a system stores data in different partitions based on a preset trust policy. A module creates different partitions and generates different data keys for each partition in advance. This module is not involved in data production and consumption after it completes initialization of the control plane. This module is the key provider. When producing and consuming data, modules on the control plane obtain the ciphertext of the data key for a partition first. After decrypting the ciphertext of the data key, modules on the control plane use the plaintext of the data key to encrypt or decrypt data and then clear the plaintext of the data key from the memory. In such a system, the key provider does not need to obtain the plaintext of the data key. It only needs to have the permissions to call the GenerateDataKeyWithoutPlaintext operation. The data producers or consumers do not need to generate new data keys. They only need to have the permissions to call the Decrypt operation.</description></item>
        /// </list>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// GenerateDataKeyWithoutPlaintextRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateDataKeyWithoutPlaintextResponse
        /// </returns>
        public async Task<GenerateDataKeyWithoutPlaintextResponse> GenerateDataKeyWithoutPlaintextAsync(GenerateDataKeyWithoutPlaintextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateDataKeyWithoutPlaintextWithOptionsAsync(request, runtime);
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In this example, the certificate whose ID is <c>9a28de48-8d8b-484d-a766-dec4****</c> is queried. The certificate, certificate chain, certificate ID, and certificate signing request (CSR) are returned.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetCertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCertificateResponse
        /// </returns>
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
            return TeaModel.ToObject<GetCertificateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In this example, the certificate whose ID is <c>9a28de48-8d8b-484d-a766-dec4****</c> is queried. The certificate, certificate chain, certificate ID, and certificate signing request (CSR) are returned.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetCertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCertificateResponse
        /// </returns>
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
            return TeaModel.ToObject<GetCertificateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In this example, the certificate whose ID is <c>9a28de48-8d8b-484d-a766-dec4****</c> is queried. The certificate, certificate chain, certificate ID, and certificate signing request (CSR) are returned.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetCertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCertificateResponse
        /// </returns>
        public GetCertificateResponse GetCertificate(GetCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCertificateWithOptions(request, runtime);
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In this example, the certificate whose ID is <c>9a28de48-8d8b-484d-a766-dec4****</c> is queried. The certificate, certificate chain, certificate ID, and certificate signing request (CSR) are returned.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetCertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCertificateResponse
        /// </returns>
        public async Task<GetCertificateResponse> GetCertificateAsync(GetCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCertificateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a client key.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetClientKeyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetClientKeyResponse
        /// </returns>
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
            return TeaModel.ToObject<GetClientKeyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a client key.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetClientKeyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetClientKeyResponse
        /// </returns>
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
            return TeaModel.ToObject<GetClientKeyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a client key.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetClientKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// GetClientKeyResponse
        /// </returns>
        public GetClientKeyResponse GetClientKey(GetClientKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetClientKeyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a client key.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetClientKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// GetClientKeyResponse
        /// </returns>
        public async Task<GetClientKeyResponse> GetClientKeyAsync(GetClientKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetClientKeyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取默认KMS实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDefaultKmsInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDefaultKmsInstanceResponse
        /// </returns>
        public GetDefaultKmsInstanceResponse GetDefaultKmsInstanceWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDefaultKmsInstance",
                Version = "2016-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDefaultKmsInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取默认KMS实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDefaultKmsInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDefaultKmsInstanceResponse
        /// </returns>
        public async Task<GetDefaultKmsInstanceResponse> GetDefaultKmsInstanceWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDefaultKmsInstance",
                Version = "2016-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDefaultKmsInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取默认KMS实例</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetDefaultKmsInstanceResponse
        /// </returns>
        public GetDefaultKmsInstanceResponse GetDefaultKmsInstance()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDefaultKmsInstanceWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取默认KMS实例</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetDefaultKmsInstanceResponse
        /// </returns>
        public async Task<GetDefaultKmsInstanceResponse> GetDefaultKmsInstanceAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDefaultKmsInstanceWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>仅可查询名称为 default 的 Key Policy，否则提示 Not Found。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetKeyPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetKeyPolicyResponse
        /// </returns>
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
            return TeaModel.ToObject<GetKeyPolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>仅可查询名称为 default 的 Key Policy，否则提示 Not Found。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetKeyPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetKeyPolicyResponse
        /// </returns>
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
            return TeaModel.ToObject<GetKeyPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>仅可查询名称为 default 的 Key Policy，否则提示 Not Found。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetKeyPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// GetKeyPolicyResponse
        /// </returns>
        public GetKeyPolicyResponse GetKeyPolicy(GetKeyPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetKeyPolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>仅可查询名称为 default 的 Key Policy，否则提示 Not Found。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetKeyPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// GetKeyPolicyResponse
        /// </returns>
        public async Task<GetKeyPolicyResponse> GetKeyPolicyAsync(GetKeyPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetKeyPolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a Key Management Service (KMS) instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetKmsInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetKmsInstanceResponse
        /// </returns>
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
            return TeaModel.ToObject<GetKmsInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a Key Management Service (KMS) instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetKmsInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetKmsInstanceResponse
        /// </returns>
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
            return TeaModel.ToObject<GetKmsInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a Key Management Service (KMS) instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetKmsInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetKmsInstanceResponse
        /// </returns>
        public GetKmsInstanceResponse GetKmsInstance(GetKmsInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetKmsInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a Key Management Service (KMS) instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetKmsInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetKmsInstanceResponse
        /// </returns>
        public async Task<GetKmsInstanceResponse> GetKmsInstanceAsync(GetKmsInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetKmsInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取实例配额信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetKmsInstanceQuotaInfosRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetKmsInstanceQuotaInfosResponse
        /// </returns>
        public GetKmsInstanceQuotaInfosResponse GetKmsInstanceQuotaInfosWithOptions(GetKmsInstanceQuotaInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KmsInstanceId))
            {
                query["KmsInstanceId"] = request.KmsInstanceId;
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
                Action = "GetKmsInstanceQuotaInfos",
                Version = "2016-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetKmsInstanceQuotaInfosResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取实例配额信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetKmsInstanceQuotaInfosRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetKmsInstanceQuotaInfosResponse
        /// </returns>
        public async Task<GetKmsInstanceQuotaInfosResponse> GetKmsInstanceQuotaInfosWithOptionsAsync(GetKmsInstanceQuotaInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KmsInstanceId))
            {
                query["KmsInstanceId"] = request.KmsInstanceId;
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
                Action = "GetKmsInstanceQuotaInfos",
                Version = "2016-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetKmsInstanceQuotaInfosResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取实例配额信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetKmsInstanceQuotaInfosRequest
        /// </param>
        /// 
        /// <returns>
        /// GetKmsInstanceQuotaInfosResponse
        /// </returns>
        public GetKmsInstanceQuotaInfosResponse GetKmsInstanceQuotaInfos(GetKmsInstanceQuotaInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetKmsInstanceQuotaInfosWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取实例配额信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetKmsInstanceQuotaInfosRequest
        /// </param>
        /// 
        /// <returns>
        /// GetKmsInstanceQuotaInfosResponse
        /// </returns>
        public async Task<GetKmsInstanceQuotaInfosResponse> GetKmsInstanceQuotaInfosAsync(GetKmsInstanceQuotaInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetKmsInstanceQuotaInfosWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the parameters that are used to import key material for a customer master key (CMK).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The returned parameters can be used to call the <a href="https://www.alibabacloud.com/help/en/key-management-service/latest/importkeymaterial">ImportKeyMaterial</a> operation.</para>
        /// <list type="bullet">
        /// <item><description>You can import key material only for CMKs whose Origin parameter is set to EXTERNAL.</description></item>
        /// <item><description>The public key and token that are returned by the GetParametersForImport operation must be used together. The public key and token can be used to import key material only for the CMK that is specified when you call the operation.</description></item>
        /// <item><description>The public key and token that are returned vary each time you call the GetParametersForImport operation.</description></item>
        /// <item><description>You must specify the type of the public key and the encryption algorithm that are used to encrypt key material. The following table lists the types of public keys and the encryption algorithms allowed for each type.   <table>
        /// <thead>
        /// <tr>
        /// <th>Public key type</th>
        /// <th>Encryption algorithm</th>
        /// <th>Description</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>RSA_2048</td>
        /// <td>RSAES_PKCS1_V1_5</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>RSAES_OAEP_SHA_1</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>RSAES_OAEP_SHA_256</td>
        /// <td>CMKs of all regions and all protection levels are supported.</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Dedicated Key Management Service (KMS) does not support RSAES_OAEP_SHA_1.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>EC_SM2</td>
        /// <td>SM2PKE</td>
        /// <td>CMKs whose ProtectionLevel is set to HSM are supported. The SM2 algorithm is developed and approved by the State Cryptography Administration of China. The SM2 algorithm can be used only to import key material for a CMK whose ProtectionLevel is set to HSM. You can use the SM2 algorithm only when you enable the Managed HSM feature for KMS in the Chinese mainland. For more information, see <a href="https://www.alibabacloud.com/help/en/key-management-service/latest/managed-hsm-overview">Overview of Managed HSM</a>.</td>
        /// </tr>
        /// <tr>
        /// <td>For more information, see <a href="https://www.alibabacloud.com/help/en/key-management-service/latest/import-key-material">Import key material</a>. This topic provides an example on how to query the parameters that are used to import key material for a CMK. The ID of the CMK is <c>1234abcd-12ab-34cd-56ef-12345678****</c>, the encryption algorithm is <c>RSAES_PKCS1_V1_5</c>, and the public key is of the <c>RSA_2048</c> type. The parameters that are returned include the ID of the CMK, the public key that is used to encrypt the key material, the token that is used to import the key material, and the time when the token expires.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetParametersForImportRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetParametersForImportResponse
        /// </returns>
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
            return TeaModel.ToObject<GetParametersForImportResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the parameters that are used to import key material for a customer master key (CMK).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The returned parameters can be used to call the <a href="https://www.alibabacloud.com/help/en/key-management-service/latest/importkeymaterial">ImportKeyMaterial</a> operation.</para>
        /// <list type="bullet">
        /// <item><description>You can import key material only for CMKs whose Origin parameter is set to EXTERNAL.</description></item>
        /// <item><description>The public key and token that are returned by the GetParametersForImport operation must be used together. The public key and token can be used to import key material only for the CMK that is specified when you call the operation.</description></item>
        /// <item><description>The public key and token that are returned vary each time you call the GetParametersForImport operation.</description></item>
        /// <item><description>You must specify the type of the public key and the encryption algorithm that are used to encrypt key material. The following table lists the types of public keys and the encryption algorithms allowed for each type.   <table>
        /// <thead>
        /// <tr>
        /// <th>Public key type</th>
        /// <th>Encryption algorithm</th>
        /// <th>Description</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>RSA_2048</td>
        /// <td>RSAES_PKCS1_V1_5</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>RSAES_OAEP_SHA_1</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>RSAES_OAEP_SHA_256</td>
        /// <td>CMKs of all regions and all protection levels are supported.</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Dedicated Key Management Service (KMS) does not support RSAES_OAEP_SHA_1.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>EC_SM2</td>
        /// <td>SM2PKE</td>
        /// <td>CMKs whose ProtectionLevel is set to HSM are supported. The SM2 algorithm is developed and approved by the State Cryptography Administration of China. The SM2 algorithm can be used only to import key material for a CMK whose ProtectionLevel is set to HSM. You can use the SM2 algorithm only when you enable the Managed HSM feature for KMS in the Chinese mainland. For more information, see <a href="https://www.alibabacloud.com/help/en/key-management-service/latest/managed-hsm-overview">Overview of Managed HSM</a>.</td>
        /// </tr>
        /// <tr>
        /// <td>For more information, see <a href="https://www.alibabacloud.com/help/en/key-management-service/latest/import-key-material">Import key material</a>. This topic provides an example on how to query the parameters that are used to import key material for a CMK. The ID of the CMK is <c>1234abcd-12ab-34cd-56ef-12345678****</c>, the encryption algorithm is <c>RSAES_PKCS1_V1_5</c>, and the public key is of the <c>RSA_2048</c> type. The parameters that are returned include the ID of the CMK, the public key that is used to encrypt the key material, the token that is used to import the key material, and the time when the token expires.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetParametersForImportRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetParametersForImportResponse
        /// </returns>
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
            return TeaModel.ToObject<GetParametersForImportResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the parameters that are used to import key material for a customer master key (CMK).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The returned parameters can be used to call the <a href="https://www.alibabacloud.com/help/en/key-management-service/latest/importkeymaterial">ImportKeyMaterial</a> operation.</para>
        /// <list type="bullet">
        /// <item><description>You can import key material only for CMKs whose Origin parameter is set to EXTERNAL.</description></item>
        /// <item><description>The public key and token that are returned by the GetParametersForImport operation must be used together. The public key and token can be used to import key material only for the CMK that is specified when you call the operation.</description></item>
        /// <item><description>The public key and token that are returned vary each time you call the GetParametersForImport operation.</description></item>
        /// <item><description>You must specify the type of the public key and the encryption algorithm that are used to encrypt key material. The following table lists the types of public keys and the encryption algorithms allowed for each type.   <table>
        /// <thead>
        /// <tr>
        /// <th>Public key type</th>
        /// <th>Encryption algorithm</th>
        /// <th>Description</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>RSA_2048</td>
        /// <td>RSAES_PKCS1_V1_5</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>RSAES_OAEP_SHA_1</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>RSAES_OAEP_SHA_256</td>
        /// <td>CMKs of all regions and all protection levels are supported.</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Dedicated Key Management Service (KMS) does not support RSAES_OAEP_SHA_1.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>EC_SM2</td>
        /// <td>SM2PKE</td>
        /// <td>CMKs whose ProtectionLevel is set to HSM are supported. The SM2 algorithm is developed and approved by the State Cryptography Administration of China. The SM2 algorithm can be used only to import key material for a CMK whose ProtectionLevel is set to HSM. You can use the SM2 algorithm only when you enable the Managed HSM feature for KMS in the Chinese mainland. For more information, see <a href="https://www.alibabacloud.com/help/en/key-management-service/latest/managed-hsm-overview">Overview of Managed HSM</a>.</td>
        /// </tr>
        /// <tr>
        /// <td>For more information, see <a href="https://www.alibabacloud.com/help/en/key-management-service/latest/import-key-material">Import key material</a>. This topic provides an example on how to query the parameters that are used to import key material for a CMK. The ID of the CMK is <c>1234abcd-12ab-34cd-56ef-12345678****</c>, the encryption algorithm is <c>RSAES_PKCS1_V1_5</c>, and the public key is of the <c>RSA_2048</c> type. The parameters that are returned include the ID of the CMK, the public key that is used to encrypt the key material, the token that is used to import the key material, and the time when the token expires.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetParametersForImportRequest
        /// </param>
        /// 
        /// <returns>
        /// GetParametersForImportResponse
        /// </returns>
        public GetParametersForImportResponse GetParametersForImport(GetParametersForImportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetParametersForImportWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the parameters that are used to import key material for a customer master key (CMK).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The returned parameters can be used to call the <a href="https://www.alibabacloud.com/help/en/key-management-service/latest/importkeymaterial">ImportKeyMaterial</a> operation.</para>
        /// <list type="bullet">
        /// <item><description>You can import key material only for CMKs whose Origin parameter is set to EXTERNAL.</description></item>
        /// <item><description>The public key and token that are returned by the GetParametersForImport operation must be used together. The public key and token can be used to import key material only for the CMK that is specified when you call the operation.</description></item>
        /// <item><description>The public key and token that are returned vary each time you call the GetParametersForImport operation.</description></item>
        /// <item><description>You must specify the type of the public key and the encryption algorithm that are used to encrypt key material. The following table lists the types of public keys and the encryption algorithms allowed for each type.   <table>
        /// <thead>
        /// <tr>
        /// <th>Public key type</th>
        /// <th>Encryption algorithm</th>
        /// <th>Description</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>RSA_2048</td>
        /// <td>RSAES_PKCS1_V1_5</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>RSAES_OAEP_SHA_1</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>RSAES_OAEP_SHA_256</td>
        /// <td>CMKs of all regions and all protection levels are supported.</td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>Dedicated Key Management Service (KMS) does not support RSAES_OAEP_SHA_1.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// <tr>
        /// <td>EC_SM2</td>
        /// <td>SM2PKE</td>
        /// <td>CMKs whose ProtectionLevel is set to HSM are supported. The SM2 algorithm is developed and approved by the State Cryptography Administration of China. The SM2 algorithm can be used only to import key material for a CMK whose ProtectionLevel is set to HSM. You can use the SM2 algorithm only when you enable the Managed HSM feature for KMS in the Chinese mainland. For more information, see <a href="https://www.alibabacloud.com/help/en/key-management-service/latest/managed-hsm-overview">Overview of Managed HSM</a>.</td>
        /// </tr>
        /// <tr>
        /// <td>For more information, see <a href="https://www.alibabacloud.com/help/en/key-management-service/latest/import-key-material">Import key material</a>. This topic provides an example on how to query the parameters that are used to import key material for a CMK. The ID of the CMK is <c>1234abcd-12ab-34cd-56ef-12345678****</c>, the encryption algorithm is <c>RSAES_PKCS1_V1_5</c>, and the public key is of the <c>RSA_2048</c> type. The parameters that are returned include the ID of the CMK, the public key that is used to encrypt the key material, the token that is used to import the key material, and the time when the token expires.</td>
        /// <td></td>
        /// <td></td>
        /// </tr>
        /// </tbody></table>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetParametersForImportRequest
        /// </param>
        /// 
        /// <returns>
        /// GetParametersForImportResponse
        /// </returns>
        public async Task<GetParametersForImportResponse> GetParametersForImportAsync(GetParametersForImportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetParametersForImportWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetPublicKeyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPublicKeyResponse
        /// </returns>
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
            return TeaModel.ToObject<GetPublicKeyResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetPublicKeyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPublicKeyResponse
        /// </returns>
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
            return TeaModel.ToObject<GetPublicKeyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetPublicKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPublicKeyResponse
        /// </returns>
        public GetPublicKeyResponse GetPublicKey(GetPublicKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPublicKeyWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetPublicKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPublicKeyResponse
        /// </returns>
        public async Task<GetPublicKeyResponse> GetPublicKeyAsync(GetPublicKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPublicKeyWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetRandomPasswordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRandomPasswordResponse
        /// </returns>
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
            return TeaModel.ToObject<GetRandomPasswordResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetRandomPasswordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRandomPasswordResponse
        /// </returns>
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
            return TeaModel.ToObject<GetRandomPasswordResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetRandomPasswordRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRandomPasswordResponse
        /// </returns>
        public GetRandomPasswordResponse GetRandomPassword(GetRandomPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRandomPasswordWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetRandomPasswordRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRandomPasswordResponse
        /// </returns>
        public async Task<GetRandomPasswordResponse> GetRandomPasswordAsync(GetRandomPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRandomPasswordWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>仅可查询名称为 default 的 Secret Policy，否则提示 Not Found。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSecretPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSecretPolicyResponse
        /// </returns>
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
            return TeaModel.ToObject<GetSecretPolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>仅可查询名称为 default 的 Secret Policy，否则提示 Not Found。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSecretPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSecretPolicyResponse
        /// </returns>
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
            return TeaModel.ToObject<GetSecretPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>仅可查询名称为 default 的 Secret Policy，否则提示 Not Found。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSecretPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSecretPolicyResponse
        /// </returns>
        public GetSecretPolicyResponse GetSecretPolicy(GetSecretPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSecretPolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>仅可查询名称为 default 的 Secret Policy，否则提示 Not Found。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSecretPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSecretPolicyResponse
        /// </returns>
        public async Task<GetSecretPolicyResponse> GetSecretPolicyAsync(GetSecretPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSecretPolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用GetSecretValue接口获取凭据值。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you do not specify a version number or stage label, Secrets Manager returns the secret value of the version marked with ACSCurrent.
        /// If a customer master key (CMK) is specified to encrypt the secret value, you must also have the <c>kms:Decrypt</c> permission on the CMK to call the GetSecretValue operation.
        /// In this example, the value of the secret named <c>secret001</c> is obtained. The secret value is returned in the <c>SecretData</c> parameter. The secret value is <c>testdata1</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSecretValueRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSecretValueResponse
        /// </returns>
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
            return TeaModel.ToObject<GetSecretValueResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用GetSecretValue接口获取凭据值。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you do not specify a version number or stage label, Secrets Manager returns the secret value of the version marked with ACSCurrent.
        /// If a customer master key (CMK) is specified to encrypt the secret value, you must also have the <c>kms:Decrypt</c> permission on the CMK to call the GetSecretValue operation.
        /// In this example, the value of the secret named <c>secret001</c> is obtained. The secret value is returned in the <c>SecretData</c> parameter. The secret value is <c>testdata1</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSecretValueRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSecretValueResponse
        /// </returns>
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
            return TeaModel.ToObject<GetSecretValueResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用GetSecretValue接口获取凭据值。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you do not specify a version number or stage label, Secrets Manager returns the secret value of the version marked with ACSCurrent.
        /// If a customer master key (CMK) is specified to encrypt the secret value, you must also have the <c>kms:Decrypt</c> permission on the CMK to call the GetSecretValue operation.
        /// In this example, the value of the secret named <c>secret001</c> is obtained. The secret value is returned in the <c>SecretData</c> parameter. The secret value is <c>testdata1</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSecretValueRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSecretValueResponse
        /// </returns>
        public GetSecretValueResponse GetSecretValue(GetSecretValueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSecretValueWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用GetSecretValue接口获取凭据值。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you do not specify a version number or stage label, Secrets Manager returns the secret value of the version marked with ACSCurrent.
        /// If a customer master key (CMK) is specified to encrypt the secret value, you must also have the <c>kms:Decrypt</c> permission on the CMK to call the GetSecretValue operation.
        /// In this example, the value of the secret named <c>secret001</c> is obtained. The secret value is returned in the <c>SecretData</c> parameter. The secret value is <c>testdata1</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSecretValueRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSecretValueResponse
        /// </returns>
        public async Task<GetSecretValueResponse> GetSecretValueAsync(GetSecretValueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSecretValueWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Call the ImportKeyMaterial operation to import the key material.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Call <a href="https://help.aliyun.com/document_detail/28947.html">CreateKey</a> when creating a CMK, you can select its key material source as external. <b>Origin</b> set to <b>EXTERNAL</b>. This API is used to import the key material into the CMK.</para>
        /// <list type="bullet">
        /// <item><description>To view the CMK <b>Origin</b>, see <a href="https://help.aliyun.com/document_detail/28952.html">DescribeKey</a>.</description></item>
        /// <item><description>Before importing key material, you need to call the <a href="https://help.aliyun.com/document_detail/68621.html">GetParametersForImport</a> obtain the parameters required to import the key material, including the public key and import token.<remarks>
        /// <list type="bullet">
        /// <item><description>The key type of the pair is <b>Aliyun_AES_256</b> the key material must be 256 bits. The key type must be <b>Aliyun_SM4</b> the CMK and key material must be 128 bits.</description></item>
        /// <item><description>You can set the expiration time for the key material, or you can set it to never expire.</description></item>
        /// <item><description>You can reimport the key material and reset the expiration time for the specified CMK at any time, but the same key material must be imported.</description></item>
        /// <item><description>After the imported key material expires or is deleted, the specified CMK is unavailable until the same key material are imported again.</description></item>
        /// <item><description>A Key material can be imported to multiple cmks, but any Data or Data Key encrypted by one CMK cannot be decrypted by another CMK.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ImportKeyMaterialRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ImportKeyMaterialResponse
        /// </returns>
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
            return TeaModel.ToObject<ImportKeyMaterialResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Call the ImportKeyMaterial operation to import the key material.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Call <a href="https://help.aliyun.com/document_detail/28947.html">CreateKey</a> when creating a CMK, you can select its key material source as external. <b>Origin</b> set to <b>EXTERNAL</b>. This API is used to import the key material into the CMK.</para>
        /// <list type="bullet">
        /// <item><description>To view the CMK <b>Origin</b>, see <a href="https://help.aliyun.com/document_detail/28952.html">DescribeKey</a>.</description></item>
        /// <item><description>Before importing key material, you need to call the <a href="https://help.aliyun.com/document_detail/68621.html">GetParametersForImport</a> obtain the parameters required to import the key material, including the public key and import token.<remarks>
        /// <list type="bullet">
        /// <item><description>The key type of the pair is <b>Aliyun_AES_256</b> the key material must be 256 bits. The key type must be <b>Aliyun_SM4</b> the CMK and key material must be 128 bits.</description></item>
        /// <item><description>You can set the expiration time for the key material, or you can set it to never expire.</description></item>
        /// <item><description>You can reimport the key material and reset the expiration time for the specified CMK at any time, but the same key material must be imported.</description></item>
        /// <item><description>After the imported key material expires or is deleted, the specified CMK is unavailable until the same key material are imported again.</description></item>
        /// <item><description>A Key material can be imported to multiple cmks, but any Data or Data Key encrypted by one CMK cannot be decrypted by another CMK.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ImportKeyMaterialRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ImportKeyMaterialResponse
        /// </returns>
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
            return TeaModel.ToObject<ImportKeyMaterialResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Call the ImportKeyMaterial operation to import the key material.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Call <a href="https://help.aliyun.com/document_detail/28947.html">CreateKey</a> when creating a CMK, you can select its key material source as external. <b>Origin</b> set to <b>EXTERNAL</b>. This API is used to import the key material into the CMK.</para>
        /// <list type="bullet">
        /// <item><description>To view the CMK <b>Origin</b>, see <a href="https://help.aliyun.com/document_detail/28952.html">DescribeKey</a>.</description></item>
        /// <item><description>Before importing key material, you need to call the <a href="https://help.aliyun.com/document_detail/68621.html">GetParametersForImport</a> obtain the parameters required to import the key material, including the public key and import token.<remarks>
        /// <list type="bullet">
        /// <item><description>The key type of the pair is <b>Aliyun_AES_256</b> the key material must be 256 bits. The key type must be <b>Aliyun_SM4</b> the CMK and key material must be 128 bits.</description></item>
        /// <item><description>You can set the expiration time for the key material, or you can set it to never expire.</description></item>
        /// <item><description>You can reimport the key material and reset the expiration time for the specified CMK at any time, but the same key material must be imported.</description></item>
        /// <item><description>After the imported key material expires or is deleted, the specified CMK is unavailable until the same key material are imported again.</description></item>
        /// <item><description>A Key material can be imported to multiple cmks, but any Data or Data Key encrypted by one CMK cannot be decrypted by another CMK.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ImportKeyMaterialRequest
        /// </param>
        /// 
        /// <returns>
        /// ImportKeyMaterialResponse
        /// </returns>
        public ImportKeyMaterialResponse ImportKeyMaterial(ImportKeyMaterialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ImportKeyMaterialWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Call the ImportKeyMaterial operation to import the key material.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Call <a href="https://help.aliyun.com/document_detail/28947.html">CreateKey</a> when creating a CMK, you can select its key material source as external. <b>Origin</b> set to <b>EXTERNAL</b>. This API is used to import the key material into the CMK.</para>
        /// <list type="bullet">
        /// <item><description>To view the CMK <b>Origin</b>, see <a href="https://help.aliyun.com/document_detail/28952.html">DescribeKey</a>.</description></item>
        /// <item><description>Before importing key material, you need to call the <a href="https://help.aliyun.com/document_detail/68621.html">GetParametersForImport</a> obtain the parameters required to import the key material, including the public key and import token.<remarks>
        /// <list type="bullet">
        /// <item><description>The key type of the pair is <b>Aliyun_AES_256</b> the key material must be 256 bits. The key type must be <b>Aliyun_SM4</b> the CMK and key material must be 128 bits.</description></item>
        /// <item><description>You can set the expiration time for the key material, or you can set it to never expire.</description></item>
        /// <item><description>You can reimport the key material and reset the expiration time for the specified CMK at any time, but the same key material must be imported.</description></item>
        /// <item><description>After the imported key material expires or is deleted, the specified CMK is unavailable until the same key material are imported again.</description></item>
        /// <item><description>A Key material can be imported to multiple cmks, but any Data or Data Key encrypted by one CMK cannot be decrypted by another CMK.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ImportKeyMaterialRequest
        /// </param>
        /// 
        /// <returns>
        /// ImportKeyMaterialResponse
        /// </returns>
        public async Task<ImportKeyMaterialResponse> ImportKeyMaterialAsync(ImportKeyMaterialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ImportKeyMaterialWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all aliases in the current region for the current account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAliasesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAliasesResponse
        /// </returns>
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
            return TeaModel.ToObject<ListAliasesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all aliases in the current region for the current account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAliasesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAliasesResponse
        /// </returns>
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
            return TeaModel.ToObject<ListAliasesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all aliases in the current region for the current account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAliasesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAliasesResponse
        /// </returns>
        public ListAliasesResponse ListAliases(ListAliasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAliasesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all aliases in the current region for the current account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAliasesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAliasesResponse
        /// </returns>
        public async Task<ListAliasesResponse> ListAliasesAsync(ListAliasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAliasesWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListAliasesByKeyIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAliasesByKeyIdResponse
        /// </returns>
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
            return TeaModel.ToObject<ListAliasesByKeyIdResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListAliasesByKeyIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAliasesByKeyIdResponse
        /// </returns>
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
            return TeaModel.ToObject<ListAliasesByKeyIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListAliasesByKeyIdRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAliasesByKeyIdResponse
        /// </returns>
        public ListAliasesByKeyIdResponse ListAliasesByKeyId(ListAliasesByKeyIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAliasesByKeyIdWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListAliasesByKeyIdRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAliasesByKeyIdResponse
        /// </returns>
        public async Task<ListAliasesByKeyIdResponse> ListAliasesByKeyIdAsync(ListAliasesByKeyIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAliasesByKeyIdWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of application access points (AAPs).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApplicationAccessPointsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListApplicationAccessPointsResponse
        /// </returns>
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
            return TeaModel.ToObject<ListApplicationAccessPointsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of application access points (AAPs).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApplicationAccessPointsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListApplicationAccessPointsResponse
        /// </returns>
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
            return TeaModel.ToObject<ListApplicationAccessPointsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of application access points (AAPs).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApplicationAccessPointsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListApplicationAccessPointsResponse
        /// </returns>
        public ListApplicationAccessPointsResponse ListApplicationAccessPoints(ListApplicationAccessPointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListApplicationAccessPointsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of application access points (AAPs).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApplicationAccessPointsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListApplicationAccessPointsResponse
        /// </returns>
        public async Task<ListApplicationAccessPointsResponse> ListApplicationAccessPointsAsync(ListApplicationAccessPointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListApplicationAccessPointsWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListClientKeysRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListClientKeysResponse
        /// </returns>
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
            return TeaModel.ToObject<ListClientKeysResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListClientKeysRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListClientKeysResponse
        /// </returns>
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
            return TeaModel.ToObject<ListClientKeysResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListClientKeysRequest
        /// </param>
        /// 
        /// <returns>
        /// ListClientKeysResponse
        /// </returns>
        public ListClientKeysResponse ListClientKeys(ListClientKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListClientKeysWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListClientKeysRequest
        /// </param>
        /// 
        /// <returns>
        /// ListClientKeysResponse
        /// </returns>
        public async Task<ListClientKeysResponse> ListClientKeysAsync(ListClientKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListClientKeysWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all versions of a specified CMK.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListKeyVersionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListKeyVersionsResponse
        /// </returns>
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
            return TeaModel.ToObject<ListKeyVersionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all versions of a specified CMK.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListKeyVersionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListKeyVersionsResponse
        /// </returns>
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
            return TeaModel.ToObject<ListKeyVersionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all versions of a specified CMK.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListKeyVersionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListKeyVersionsResponse
        /// </returns>
        public ListKeyVersionsResponse ListKeyVersions(ListKeyVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListKeyVersionsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all versions of a specified CMK.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListKeyVersionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListKeyVersionsResponse
        /// </returns>
        public async Task<ListKeyVersionsResponse> ListKeyVersionsAsync(ListKeyVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListKeyVersionsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all customer master keys (CMKs) of the current Alibaba Cloud account in the current region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListKeysRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListKeysResponse
        /// </returns>
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
            return TeaModel.ToObject<ListKeysResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all customer master keys (CMKs) of the current Alibaba Cloud account in the current region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListKeysRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListKeysResponse
        /// </returns>
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
            return TeaModel.ToObject<ListKeysResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all customer master keys (CMKs) of the current Alibaba Cloud account in the current region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListKeysRequest
        /// </param>
        /// 
        /// <returns>
        /// ListKeysResponse
        /// </returns>
        public ListKeysResponse ListKeys(ListKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListKeysWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all customer master keys (CMKs) of the current Alibaba Cloud account in the current region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListKeysRequest
        /// </param>
        /// 
        /// <returns>
        /// ListKeysResponse
        /// </returns>
        public async Task<ListKeysResponse> ListKeysAsync(ListKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListKeysWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of Key Management Service (KMS) instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListKmsInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListKmsInstancesResponse
        /// </returns>
        public ListKmsInstancesResponse ListKmsInstancesWithOptions(ListKmsInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<ListKmsInstancesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of Key Management Service (KMS) instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListKmsInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListKmsInstancesResponse
        /// </returns>
        public async Task<ListKmsInstancesResponse> ListKmsInstancesWithOptionsAsync(ListKmsInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            return TeaModel.ToObject<ListKmsInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of Key Management Service (KMS) instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListKmsInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListKmsInstancesResponse
        /// </returns>
        public ListKmsInstancesResponse ListKmsInstances(ListKmsInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListKmsInstancesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of Key Management Service (KMS) instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListKmsInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListKmsInstancesResponse
        /// </returns>
        public async Task<ListKmsInstancesResponse> ListKmsInstancesAsync(ListKmsInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListKmsInstancesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of access control rules.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNetworkRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListNetworkRulesResponse
        /// </returns>
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
            return TeaModel.ToObject<ListNetworkRulesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of access control rules.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNetworkRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListNetworkRulesResponse
        /// </returns>
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
            return TeaModel.ToObject<ListNetworkRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of access control rules.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNetworkRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListNetworkRulesResponse
        /// </returns>
        public ListNetworkRulesResponse ListNetworkRules(ListNetworkRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListNetworkRulesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of access control rules.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNetworkRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListNetworkRulesResponse
        /// </returns>
        public async Task<ListNetworkRulesResponse> ListNetworkRulesAsync(ListNetworkRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListNetworkRulesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of permission policies.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPoliciesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPoliciesResponse
        /// </returns>
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
            return TeaModel.ToObject<ListPoliciesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of permission policies.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPoliciesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPoliciesResponse
        /// </returns>
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
            return TeaModel.ToObject<ListPoliciesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of permission policies.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPoliciesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPoliciesResponse
        /// </returns>
        public ListPoliciesResponse ListPolicies(ListPoliciesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPoliciesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of permission policies.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPoliciesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPoliciesResponse
        /// </returns>
        public async Task<ListPoliciesResponse> ListPoliciesAsync(ListPoliciesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPoliciesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Request format: KeyId=&quot;string&quot;</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListResourceTagsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListResourceTagsResponse
        /// </returns>
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
            return TeaModel.ToObject<ListResourceTagsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Request format: KeyId=&quot;string&quot;</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListResourceTagsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListResourceTagsResponse
        /// </returns>
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
            return TeaModel.ToObject<ListResourceTagsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Request format: KeyId=&quot;string&quot;</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListResourceTagsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListResourceTagsResponse
        /// </returns>
        public ListResourceTagsResponse ListResourceTags(ListResourceTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListResourceTagsWithOptions(request, runtime);
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Request format: KeyId=&quot;string&quot;</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListResourceTagsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListResourceTagsResponse
        /// </returns>
        public async Task<ListResourceTagsResponse> ListResourceTagsAsync(ListResourceTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListResourceTagsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The secret value is not included in the returned version information. By default, deprecated secret versions are not returned.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListSecretVersionIdsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSecretVersionIdsResponse
        /// </returns>
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
            return TeaModel.ToObject<ListSecretVersionIdsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The secret value is not included in the returned version information. By default, deprecated secret versions are not returned.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListSecretVersionIdsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSecretVersionIdsResponse
        /// </returns>
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
            return TeaModel.ToObject<ListSecretVersionIdsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The secret value is not included in the returned version information. By default, deprecated secret versions are not returned.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListSecretVersionIdsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSecretVersionIdsResponse
        /// </returns>
        public ListSecretVersionIdsResponse ListSecretVersionIds(ListSecretVersionIdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSecretVersionIdsWithOptions(request, runtime);
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The secret value is not included in the returned version information. By default, deprecated secret versions are not returned.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListSecretVersionIdsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSecretVersionIdsResponse
        /// </returns>
        public async Task<ListSecretVersionIdsResponse> ListSecretVersionIdsAsync(ListSecretVersionIdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSecretVersionIdsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Specifies whether to return the resource tags of the secret. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: returns the resource tags.</description></item>
        /// <item><description>false: does not return the resource tags. This is the default value.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListSecretsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSecretsResponse
        /// </returns>
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
            return TeaModel.ToObject<ListSecretsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Specifies whether to return the resource tags of the secret. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: returns the resource tags.</description></item>
        /// <item><description>false: does not return the resource tags. This is the default value.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListSecretsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSecretsResponse
        /// </returns>
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
            return TeaModel.ToObject<ListSecretsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Specifies whether to return the resource tags of the secret. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: returns the resource tags.</description></item>
        /// <item><description>false: does not return the resource tags. This is the default value.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListSecretsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSecretsResponse
        /// </returns>
        public ListSecretsResponse ListSecrets(ListSecretsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSecretsWithOptions(request, runtime);
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Specifies whether to return the resource tags of the secret. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: returns the resource tags.</description></item>
        /// <item><description>false: does not return the resource tags. This is the default value.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListSecretsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSecretsResponse
        /// </returns>
        public async Task<ListSecretsResponse> ListSecretsAsync(ListSecretsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSecretsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tags of a key or a secret.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTagResourcesResponse
        /// </returns>
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
            return TeaModel.ToObject<ListTagResourcesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tags of a key or a secret.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTagResourcesResponse
        /// </returns>
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
            return TeaModel.ToObject<ListTagResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tags of a key or a secret.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTagResourcesResponse
        /// </returns>
        public ListTagResourcesResponse ListTagResources(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTagResourcesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tags of a key or a secret.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTagResourcesResponse
        /// </returns>
        public async Task<ListTagResourcesResponse> ListTagResourcesAsync(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTagResourcesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Activates Key Management Service (KMS) under your Alibaba cloud account.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation, note that:</para>
        /// <list type="bullet">
        /// <item><description>KMS is a paid service. For more information about the billing method, see <a href="https://www.alibabacloud.com/help/en/key-management-service/latest/billing-billing">Billing description</a>.</description></item>
        /// <item><description>An Alibaba Cloud account can activate KMS only once.</description></item>
        /// <item><description>Make sure that your Alibaba Cloud account has passed real-name authentication.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// OpenKmsServiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OpenKmsServiceResponse
        /// </returns>
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
            return TeaModel.ToObject<OpenKmsServiceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Activates Key Management Service (KMS) under your Alibaba cloud account.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation, note that:</para>
        /// <list type="bullet">
        /// <item><description>KMS is a paid service. For more information about the billing method, see <a href="https://www.alibabacloud.com/help/en/key-management-service/latest/billing-billing">Billing description</a>.</description></item>
        /// <item><description>An Alibaba Cloud account can activate KMS only once.</description></item>
        /// <item><description>Make sure that your Alibaba Cloud account has passed real-name authentication.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// OpenKmsServiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OpenKmsServiceResponse
        /// </returns>
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
            return TeaModel.ToObject<OpenKmsServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Activates Key Management Service (KMS) under your Alibaba cloud account.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation, note that:</para>
        /// <list type="bullet">
        /// <item><description>KMS is a paid service. For more information about the billing method, see <a href="https://www.alibabacloud.com/help/en/key-management-service/latest/billing-billing">Billing description</a>.</description></item>
        /// <item><description>An Alibaba Cloud account can activate KMS only once.</description></item>
        /// <item><description>Make sure that your Alibaba Cloud account has passed real-name authentication.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <returns>
        /// OpenKmsServiceResponse
        /// </returns>
        public OpenKmsServiceResponse OpenKmsService()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OpenKmsServiceWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Activates Key Management Service (KMS) under your Alibaba cloud account.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call this operation, note that:</para>
        /// <list type="bullet">
        /// <item><description>KMS is a paid service. For more information about the billing method, see <a href="https://www.alibabacloud.com/help/en/key-management-service/latest/billing-billing">Billing description</a>.</description></item>
        /// <item><description>An Alibaba Cloud account can activate KMS only once.</description></item>
        /// <item><description>Make sure that your Alibaba Cloud account has passed real-name authentication.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <returns>
        /// OpenKmsServiceResponse
        /// </returns>
        public async Task<OpenKmsServiceResponse> OpenKmsServiceAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OpenKmsServiceWithOptionsAsync(runtime);
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is used to store the secret values of new versions. It cannot be used to modify the secret value of an existing version.
        /// By default, the newly stored secret value is marked with ACSCurrent, and the mark for the previous version of the secret value is changed from ACSCurrent to ACSPrevious. If you specify the VersionStage parameter, the newly stored secret value is marked with the stage label that you specify.
        /// You must specify a version number when you call the operation. Secrets Manager performs operations based on the following rules:</para>
        /// <list type="bullet">
        /// <item><description>If the specified version number does not exist in the secret, Secrets Manager creates the version and stores the secret value.</description></item>
        /// <item><description>If the specified version number already exists in the secret and the secret value of the existing version is the same as the secret value that you specify, Secrets Manager ignores the request and returns a success message. The request is idempotent.</description></item>
        /// <item><description>If the specified version number already exists in the secret but the secret value of the existing version is different from the secret value that you specify, Secrets Manager rejects the request and returns a failure message.
        /// Limits: This operation is available only for standard secrets.
        /// In this example, the secret value of a new version is stored into the <c>secret001</c> secret. The <c>VersionId</c> parameter is set to <c>00000000000000000000000000000000203</c> as the new version, and the <c>SecretData</c> parameter is set to <c>importantdata</c>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// PutSecretValueRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PutSecretValueResponse
        /// </returns>
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
            return TeaModel.ToObject<PutSecretValueResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is used to store the secret values of new versions. It cannot be used to modify the secret value of an existing version.
        /// By default, the newly stored secret value is marked with ACSCurrent, and the mark for the previous version of the secret value is changed from ACSCurrent to ACSPrevious. If you specify the VersionStage parameter, the newly stored secret value is marked with the stage label that you specify.
        /// You must specify a version number when you call the operation. Secrets Manager performs operations based on the following rules:</para>
        /// <list type="bullet">
        /// <item><description>If the specified version number does not exist in the secret, Secrets Manager creates the version and stores the secret value.</description></item>
        /// <item><description>If the specified version number already exists in the secret and the secret value of the existing version is the same as the secret value that you specify, Secrets Manager ignores the request and returns a success message. The request is idempotent.</description></item>
        /// <item><description>If the specified version number already exists in the secret but the secret value of the existing version is different from the secret value that you specify, Secrets Manager rejects the request and returns a failure message.
        /// Limits: This operation is available only for standard secrets.
        /// In this example, the secret value of a new version is stored into the <c>secret001</c> secret. The <c>VersionId</c> parameter is set to <c>00000000000000000000000000000000203</c> as the new version, and the <c>SecretData</c> parameter is set to <c>importantdata</c>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// PutSecretValueRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PutSecretValueResponse
        /// </returns>
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
            return TeaModel.ToObject<PutSecretValueResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is used to store the secret values of new versions. It cannot be used to modify the secret value of an existing version.
        /// By default, the newly stored secret value is marked with ACSCurrent, and the mark for the previous version of the secret value is changed from ACSCurrent to ACSPrevious. If you specify the VersionStage parameter, the newly stored secret value is marked with the stage label that you specify.
        /// You must specify a version number when you call the operation. Secrets Manager performs operations based on the following rules:</para>
        /// <list type="bullet">
        /// <item><description>If the specified version number does not exist in the secret, Secrets Manager creates the version and stores the secret value.</description></item>
        /// <item><description>If the specified version number already exists in the secret and the secret value of the existing version is the same as the secret value that you specify, Secrets Manager ignores the request and returns a success message. The request is idempotent.</description></item>
        /// <item><description>If the specified version number already exists in the secret but the secret value of the existing version is different from the secret value that you specify, Secrets Manager rejects the request and returns a failure message.
        /// Limits: This operation is available only for standard secrets.
        /// In this example, the secret value of a new version is stored into the <c>secret001</c> secret. The <c>VersionId</c> parameter is set to <c>00000000000000000000000000000000203</c> as the new version, and the <c>SecretData</c> parameter is set to <c>importantdata</c>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// PutSecretValueRequest
        /// </param>
        /// 
        /// <returns>
        /// PutSecretValueResponse
        /// </returns>
        public PutSecretValueResponse PutSecretValue(PutSecretValueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PutSecretValueWithOptions(request, runtime);
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is used to store the secret values of new versions. It cannot be used to modify the secret value of an existing version.
        /// By default, the newly stored secret value is marked with ACSCurrent, and the mark for the previous version of the secret value is changed from ACSCurrent to ACSPrevious. If you specify the VersionStage parameter, the newly stored secret value is marked with the stage label that you specify.
        /// You must specify a version number when you call the operation. Secrets Manager performs operations based on the following rules:</para>
        /// <list type="bullet">
        /// <item><description>If the specified version number does not exist in the secret, Secrets Manager creates the version and stores the secret value.</description></item>
        /// <item><description>If the specified version number already exists in the secret and the secret value of the existing version is the same as the secret value that you specify, Secrets Manager ignores the request and returns a success message. The request is idempotent.</description></item>
        /// <item><description>If the specified version number already exists in the secret but the secret value of the existing version is different from the secret value that you specify, Secrets Manager rejects the request and returns a failure message.
        /// Limits: This operation is available only for standard secrets.
        /// In this example, the secret value of a new version is stored into the <c>secret001</c> secret. The <c>VersionId</c> parameter is set to <c>00000000000000000000000000000000203</c> as the new version, and the <c>SecretData</c> parameter is set to <c>importantdata</c>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// PutSecretValueRequest
        /// </param>
        /// 
        /// <returns>
        /// PutSecretValueResponse
        /// </returns>
        public async Task<PutSecretValueResponse> PutSecretValueAsync(PutSecretValueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PutSecretValueWithOptionsAsync(request, runtime);
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation in the following scenarios:</para>
        /// <list type="bullet">
        /// <item><description>After the CMK that was used to encrypt your data is rotated, you can call this operation to use the latest CMK version to re-encrypt the data. For more information about automatic key rotation, see <a href="https://help.aliyun.com/document_detail/134270.html">Configure automatic key rotation</a>.</description></item>
        /// <item><description>The CMK that was used to encrypt your data remains unchanged, but EncryptionContext is changed. In this scenario, you can call this operation to re-encrypt the data.</description></item>
        /// <item><description>You can call this operation to use a CMK in KMS to re-encrypt data or a data key that was previously encrypted by a different CMK.
        /// To use the ReEncrypt operation, you must have two permissions:</description></item>
        /// <item><description>kms:ReEncryptFrom on the source CMK</description></item>
        /// <item><description>kms:ReEncryptTo on the destination CMK</description></item>
        /// <item><description>For simplicity, you can specify kms:ReEncrypt\* to allow both of the preceding permissions.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ReEncryptRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReEncryptResponse
        /// </returns>
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
            return TeaModel.ToObject<ReEncryptResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation in the following scenarios:</para>
        /// <list type="bullet">
        /// <item><description>After the CMK that was used to encrypt your data is rotated, you can call this operation to use the latest CMK version to re-encrypt the data. For more information about automatic key rotation, see <a href="https://help.aliyun.com/document_detail/134270.html">Configure automatic key rotation</a>.</description></item>
        /// <item><description>The CMK that was used to encrypt your data remains unchanged, but EncryptionContext is changed. In this scenario, you can call this operation to re-encrypt the data.</description></item>
        /// <item><description>You can call this operation to use a CMK in KMS to re-encrypt data or a data key that was previously encrypted by a different CMK.
        /// To use the ReEncrypt operation, you must have two permissions:</description></item>
        /// <item><description>kms:ReEncryptFrom on the source CMK</description></item>
        /// <item><description>kms:ReEncryptTo on the destination CMK</description></item>
        /// <item><description>For simplicity, you can specify kms:ReEncrypt\* to allow both of the preceding permissions.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ReEncryptRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReEncryptResponse
        /// </returns>
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
            return TeaModel.ToObject<ReEncryptResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation in the following scenarios:</para>
        /// <list type="bullet">
        /// <item><description>After the CMK that was used to encrypt your data is rotated, you can call this operation to use the latest CMK version to re-encrypt the data. For more information about automatic key rotation, see <a href="https://help.aliyun.com/document_detail/134270.html">Configure automatic key rotation</a>.</description></item>
        /// <item><description>The CMK that was used to encrypt your data remains unchanged, but EncryptionContext is changed. In this scenario, you can call this operation to re-encrypt the data.</description></item>
        /// <item><description>You can call this operation to use a CMK in KMS to re-encrypt data or a data key that was previously encrypted by a different CMK.
        /// To use the ReEncrypt operation, you must have two permissions:</description></item>
        /// <item><description>kms:ReEncryptFrom on the source CMK</description></item>
        /// <item><description>kms:ReEncryptTo on the destination CMK</description></item>
        /// <item><description>For simplicity, you can specify kms:ReEncrypt\* to allow both of the preceding permissions.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ReEncryptRequest
        /// </param>
        /// 
        /// <returns>
        /// ReEncryptResponse
        /// </returns>
        public ReEncryptResponse ReEncrypt(ReEncryptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReEncryptWithOptions(request, runtime);
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation in the following scenarios:</para>
        /// <list type="bullet">
        /// <item><description>After the CMK that was used to encrypt your data is rotated, you can call this operation to use the latest CMK version to re-encrypt the data. For more information about automatic key rotation, see <a href="https://help.aliyun.com/document_detail/134270.html">Configure automatic key rotation</a>.</description></item>
        /// <item><description>The CMK that was used to encrypt your data remains unchanged, but EncryptionContext is changed. In this scenario, you can call this operation to re-encrypt the data.</description></item>
        /// <item><description>You can call this operation to use a CMK in KMS to re-encrypt data or a data key that was previously encrypted by a different CMK.
        /// To use the ReEncrypt operation, you must have two permissions:</description></item>
        /// <item><description>kms:ReEncryptFrom on the source CMK</description></item>
        /// <item><description>kms:ReEncryptTo on the destination CMK</description></item>
        /// <item><description>For simplicity, you can specify kms:ReEncrypt\* to allow both of the preceding permissions.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ReEncryptRequest
        /// </param>
        /// 
        /// <returns>
        /// ReEncryptResponse
        /// </returns>
        public async Task<ReEncryptResponse> ReEncryptAsync(ReEncryptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReEncryptWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>仅后付费实例支持释放，预付费实例需要从用户中心-退订管理释放。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReleaseKmsInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReleaseKmsInstanceResponse
        /// </returns>
        public ReleaseKmsInstanceResponse ReleaseKmsInstanceWithOptions(ReleaseKmsInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceDeleteWithoutBackup))
            {
                query["ForceDeleteWithoutBackup"] = request.ForceDeleteWithoutBackup;
            }
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
                Action = "ReleaseKmsInstance",
                Version = "2016-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseKmsInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>仅后付费实例支持释放，预付费实例需要从用户中心-退订管理释放。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReleaseKmsInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReleaseKmsInstanceResponse
        /// </returns>
        public async Task<ReleaseKmsInstanceResponse> ReleaseKmsInstanceWithOptionsAsync(ReleaseKmsInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceDeleteWithoutBackup))
            {
                query["ForceDeleteWithoutBackup"] = request.ForceDeleteWithoutBackup;
            }
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
                Action = "ReleaseKmsInstance",
                Version = "2016-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseKmsInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>仅后付费实例支持释放，预付费实例需要从用户中心-退订管理释放。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReleaseKmsInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// ReleaseKmsInstanceResponse
        /// </returns>
        public ReleaseKmsInstanceResponse ReleaseKmsInstance(ReleaseKmsInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReleaseKmsInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>仅后付费实例支持释放，预付费实例需要从用户中心-退订管理释放。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReleaseKmsInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// ReleaseKmsInstanceResponse
        /// </returns>
        public async Task<ReleaseKmsInstanceResponse> ReleaseKmsInstanceAsync(ReleaseKmsInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReleaseKmsInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can only use this operation to restore a deleted secret that is within its recovery period. If you set <b>ForceDeleteWithoutRecovery</b> to <b>true</b> when you delete the secret, you cannot restore it.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RestoreSecretRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RestoreSecretResponse
        /// </returns>
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
            return TeaModel.ToObject<RestoreSecretResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can only use this operation to restore a deleted secret that is within its recovery period. If you set <b>ForceDeleteWithoutRecovery</b> to <b>true</b> when you delete the secret, you cannot restore it.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RestoreSecretRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RestoreSecretResponse
        /// </returns>
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
            return TeaModel.ToObject<RestoreSecretResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can only use this operation to restore a deleted secret that is within its recovery period. If you set <b>ForceDeleteWithoutRecovery</b> to <b>true</b> when you delete the secret, you cannot restore it.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RestoreSecretRequest
        /// </param>
        /// 
        /// <returns>
        /// RestoreSecretResponse
        /// </returns>
        public RestoreSecretResponse RestoreSecret(RestoreSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RestoreSecretWithOptions(request, runtime);
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can only use this operation to restore a deleted secret that is within its recovery period. If you set <b>ForceDeleteWithoutRecovery</b> to <b>true</b> when you delete the secret, you cannot restore it.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RestoreSecretRequest
        /// </param>
        /// 
        /// <returns>
        /// RestoreSecretResponse
        /// </returns>
        public async Task<RestoreSecretResponse> RestoreSecretAsync(RestoreSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RestoreSecretWithOptionsAsync(request, runtime);
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Limits:
        /// • A secret of each Alibaba Cloud account can be rotated for a maximum of 50 times per hour.
        /// • The RotateSecret operation is unavailable for standard secrets.
        /// In this example, the <c>RdsSecret/Mysql5.4/MyCred</c> secret is manually rotated, and the version number of the secret is set to <c>000000123</c> after the secret is rotated.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RotateSecretRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RotateSecretResponse
        /// </returns>
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
            return TeaModel.ToObject<RotateSecretResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Limits:
        /// • A secret of each Alibaba Cloud account can be rotated for a maximum of 50 times per hour.
        /// • The RotateSecret operation is unavailable for standard secrets.
        /// In this example, the <c>RdsSecret/Mysql5.4/MyCred</c> secret is manually rotated, and the version number of the secret is set to <c>000000123</c> after the secret is rotated.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RotateSecretRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RotateSecretResponse
        /// </returns>
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
            return TeaModel.ToObject<RotateSecretResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Limits:
        /// • A secret of each Alibaba Cloud account can be rotated for a maximum of 50 times per hour.
        /// • The RotateSecret operation is unavailable for standard secrets.
        /// In this example, the <c>RdsSecret/Mysql5.4/MyCred</c> secret is manually rotated, and the version number of the secret is set to <c>000000123</c> after the secret is rotated.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RotateSecretRequest
        /// </param>
        /// 
        /// <returns>
        /// RotateSecretResponse
        /// </returns>
        public RotateSecretResponse RotateSecret(RotateSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RotateSecretWithOptions(request, runtime);
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Limits:
        /// • A secret of each Alibaba Cloud account can be rotated for a maximum of 50 times per hour.
        /// • The RotateSecret operation is unavailable for standard secrets.
        /// In this example, the <c>RdsSecret/Mysql5.4/MyCred</c> secret is manually rotated, and the version number of the secret is set to <c>000000123</c> after the secret is rotated.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RotateSecretRequest
        /// </param>
        /// 
        /// <returns>
        /// RotateSecretResponse
        /// </returns>
        public async Task<RotateSecretResponse> RotateSecretAsync(RotateSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RotateSecretWithOptionsAsync(request, runtime);
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>During the scheduled period, the CMK is in the PendingDeletion state and cannot be used to encrypt data, decrypt data, or generate data keys.
        /// After a CMK is deleted, it cannot be recovered. Data that is encrypted and data keys that are generated by using the CMK cannot be decrypted. To prevent accidental deletion of CMKs, Key Management Service (KMS) allows you to only schedule key deletion tasks. You cannot directly delete CMKs. If you want to delete a CMK, call the <a href="https://help.aliyun.com/document_detail/35151.html">DisableKey</a> operation to disable the CMK.
        /// When you call this operation, you must specify a scheduled period between 7 days to 366 days. The scheduled period starts from the time when you submit the request. You can call the <a href="https://help.aliyun.com/document_detail/44197.html">CancelKeyDeletion</a> operation to cancel the key deletion task before the scheduled period ends.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ScheduleKeyDeletionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ScheduleKeyDeletionResponse
        /// </returns>
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
            return TeaModel.ToObject<ScheduleKeyDeletionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>During the scheduled period, the CMK is in the PendingDeletion state and cannot be used to encrypt data, decrypt data, or generate data keys.
        /// After a CMK is deleted, it cannot be recovered. Data that is encrypted and data keys that are generated by using the CMK cannot be decrypted. To prevent accidental deletion of CMKs, Key Management Service (KMS) allows you to only schedule key deletion tasks. You cannot directly delete CMKs. If you want to delete a CMK, call the <a href="https://help.aliyun.com/document_detail/35151.html">DisableKey</a> operation to disable the CMK.
        /// When you call this operation, you must specify a scheduled period between 7 days to 366 days. The scheduled period starts from the time when you submit the request. You can call the <a href="https://help.aliyun.com/document_detail/44197.html">CancelKeyDeletion</a> operation to cancel the key deletion task before the scheduled period ends.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ScheduleKeyDeletionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ScheduleKeyDeletionResponse
        /// </returns>
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
            return TeaModel.ToObject<ScheduleKeyDeletionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>During the scheduled period, the CMK is in the PendingDeletion state and cannot be used to encrypt data, decrypt data, or generate data keys.
        /// After a CMK is deleted, it cannot be recovered. Data that is encrypted and data keys that are generated by using the CMK cannot be decrypted. To prevent accidental deletion of CMKs, Key Management Service (KMS) allows you to only schedule key deletion tasks. You cannot directly delete CMKs. If you want to delete a CMK, call the <a href="https://help.aliyun.com/document_detail/35151.html">DisableKey</a> operation to disable the CMK.
        /// When you call this operation, you must specify a scheduled period between 7 days to 366 days. The scheduled period starts from the time when you submit the request. You can call the <a href="https://help.aliyun.com/document_detail/44197.html">CancelKeyDeletion</a> operation to cancel the key deletion task before the scheduled period ends.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ScheduleKeyDeletionRequest
        /// </param>
        /// 
        /// <returns>
        /// ScheduleKeyDeletionResponse
        /// </returns>
        public ScheduleKeyDeletionResponse ScheduleKeyDeletion(ScheduleKeyDeletionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ScheduleKeyDeletionWithOptions(request, runtime);
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>During the scheduled period, the CMK is in the PendingDeletion state and cannot be used to encrypt data, decrypt data, or generate data keys.
        /// After a CMK is deleted, it cannot be recovered. Data that is encrypted and data keys that are generated by using the CMK cannot be decrypted. To prevent accidental deletion of CMKs, Key Management Service (KMS) allows you to only schedule key deletion tasks. You cannot directly delete CMKs. If you want to delete a CMK, call the <a href="https://help.aliyun.com/document_detail/35151.html">DisableKey</a> operation to disable the CMK.
        /// When you call this operation, you must specify a scheduled period between 7 days to 366 days. The scheduled period starts from the time when you submit the request. You can call the <a href="https://help.aliyun.com/document_detail/44197.html">CancelKeyDeletion</a> operation to cancel the key deletion task before the scheduled period ends.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ScheduleKeyDeletionRequest
        /// </param>
        /// 
        /// <returns>
        /// ScheduleKeyDeletionResponse
        /// </returns>
        public async Task<ScheduleKeyDeletionResponse> ScheduleKeyDeletionAsync(ScheduleKeyDeletionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ScheduleKeyDeletionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables or disables deletion protection for a customer master key (CMK).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  After you enable deletion protection for a CMK, you cannot delete the CMK. If you want to delete the CMK, you must first disable deletion protection for the CMK.</para>
        /// <list type="bullet">
        /// <item><description>Before you can call the SetDeletionProtection operation, make sure that the required CMK is not in the Pending Deletion state. You can call the <a href="https://help.aliyun.com/document_detail/28952.html">DescribeKey</a> operation to query the CMK status, which is specified by the KeyState parameter.
        /// You can enable deletion protection for the CMK whose Alibaba Cloud Resource Name (ARN) is <c>acs:kms:cn-hangzhou:123213123****:key/0225f411-b21d-46d1-be5b-93931c82****</c> by using parameter settings provided in this topic. The CMK ARN is specified by the ProtectedResourceArn parameter.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SetDeletionProtectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetDeletionProtectionResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyId))
            {
                query["KeyId"] = request.KeyId;
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
            return TeaModel.ToObject<SetDeletionProtectionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables or disables deletion protection for a customer master key (CMK).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  After you enable deletion protection for a CMK, you cannot delete the CMK. If you want to delete the CMK, you must first disable deletion protection for the CMK.</para>
        /// <list type="bullet">
        /// <item><description>Before you can call the SetDeletionProtection operation, make sure that the required CMK is not in the Pending Deletion state. You can call the <a href="https://help.aliyun.com/document_detail/28952.html">DescribeKey</a> operation to query the CMK status, which is specified by the KeyState parameter.
        /// You can enable deletion protection for the CMK whose Alibaba Cloud Resource Name (ARN) is <c>acs:kms:cn-hangzhou:123213123****:key/0225f411-b21d-46d1-be5b-93931c82****</c> by using parameter settings provided in this topic. The CMK ARN is specified by the ProtectedResourceArn parameter.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SetDeletionProtectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetDeletionProtectionResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyId))
            {
                query["KeyId"] = request.KeyId;
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
            return TeaModel.ToObject<SetDeletionProtectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables or disables deletion protection for a customer master key (CMK).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  After you enable deletion protection for a CMK, you cannot delete the CMK. If you want to delete the CMK, you must first disable deletion protection for the CMK.</para>
        /// <list type="bullet">
        /// <item><description>Before you can call the SetDeletionProtection operation, make sure that the required CMK is not in the Pending Deletion state. You can call the <a href="https://help.aliyun.com/document_detail/28952.html">DescribeKey</a> operation to query the CMK status, which is specified by the KeyState parameter.
        /// You can enable deletion protection for the CMK whose Alibaba Cloud Resource Name (ARN) is <c>acs:kms:cn-hangzhou:123213123****:key/0225f411-b21d-46d1-be5b-93931c82****</c> by using parameter settings provided in this topic. The CMK ARN is specified by the ProtectedResourceArn parameter.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SetDeletionProtectionRequest
        /// </param>
        /// 
        /// <returns>
        /// SetDeletionProtectionResponse
        /// </returns>
        public SetDeletionProtectionResponse SetDeletionProtection(SetDeletionProtectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetDeletionProtectionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables or disables deletion protection for a customer master key (CMK).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  After you enable deletion protection for a CMK, you cannot delete the CMK. If you want to delete the CMK, you must first disable deletion protection for the CMK.</para>
        /// <list type="bullet">
        /// <item><description>Before you can call the SetDeletionProtection operation, make sure that the required CMK is not in the Pending Deletion state. You can call the <a href="https://help.aliyun.com/document_detail/28952.html">DescribeKey</a> operation to query the CMK status, which is specified by the KeyState parameter.
        /// You can enable deletion protection for the CMK whose Alibaba Cloud Resource Name (ARN) is <c>acs:kms:cn-hangzhou:123213123****:key/0225f411-b21d-46d1-be5b-93931c82****</c> by using parameter settings provided in this topic. The CMK ARN is specified by the ProtectedResourceArn parameter.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SetDeletionProtectionRequest
        /// </param>
        /// 
        /// <returns>
        /// SetDeletionProtectionResponse
        /// </returns>
        public async Task<SetDeletionProtectionResponse> SetDeletionProtectionAsync(SetDeletionProtectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetDeletionProtectionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>可以设置一条 Key Policy，且名称必须为 default。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetKeyPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetKeyPolicyResponse
        /// </returns>
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
            return TeaModel.ToObject<SetKeyPolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>可以设置一条 Key Policy，且名称必须为 default。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetKeyPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetKeyPolicyResponse
        /// </returns>
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
            return TeaModel.ToObject<SetKeyPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>可以设置一条 Key Policy，且名称必须为 default。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetKeyPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// SetKeyPolicyResponse
        /// </returns>
        public SetKeyPolicyResponse SetKeyPolicy(SetKeyPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetKeyPolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>可以设置一条 Key Policy，且名称必须为 default。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetKeyPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// SetKeyPolicyResponse
        /// </returns>
        public async Task<SetKeyPolicyResponse> SetKeyPolicyAsync(SetKeyPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetKeyPolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>可以设置一条 Secret Policy，且名称必须为 default。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetSecretPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetSecretPolicyResponse
        /// </returns>
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
            return TeaModel.ToObject<SetSecretPolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>可以设置一条 Secret Policy，且名称必须为 default。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetSecretPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetSecretPolicyResponse
        /// </returns>
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
            return TeaModel.ToObject<SetSecretPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>可以设置一条 Secret Policy，且名称必须为 default。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetSecretPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// SetSecretPolicyResponse
        /// </returns>
        public SetSecretPolicyResponse SetSecretPolicy(SetSecretPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetSecretPolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>可以设置一条 Secret Policy，且名称必须为 default。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetSecretPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// SetSecretPolicyResponse
        /// </returns>
        public async Task<SetSecretPolicyResponse> SetSecretPolicyAsync(SetSecretPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetSecretPolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can add up to 10 tags to a CMK, secret, or certificate.
        /// In this example, the tags <c>[{&quot;TagKey&quot;:&quot;S1key1&quot;,&quot;TagValue&quot;:&quot;S1val1&quot;},{&quot;TagKey&quot;:&quot;S1key2&quot;,&quot;TagValue&quot;:&quot;S2val2&quot;}]</c> are added to the CMK whose ID is <c>08c33a6f-4e0a-4a1b-a3fa-7ddf****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// TagResourceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TagResourceResponse
        /// </returns>
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
            return TeaModel.ToObject<TagResourceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can add up to 10 tags to a CMK, secret, or certificate.
        /// In this example, the tags <c>[{&quot;TagKey&quot;:&quot;S1key1&quot;,&quot;TagValue&quot;:&quot;S1val1&quot;},{&quot;TagKey&quot;:&quot;S1key2&quot;,&quot;TagValue&quot;:&quot;S2val2&quot;}]</c> are added to the CMK whose ID is <c>08c33a6f-4e0a-4a1b-a3fa-7ddf****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// TagResourceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TagResourceResponse
        /// </returns>
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
            return TeaModel.ToObject<TagResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can add up to 10 tags to a CMK, secret, or certificate.
        /// In this example, the tags <c>[{&quot;TagKey&quot;:&quot;S1key1&quot;,&quot;TagValue&quot;:&quot;S1val1&quot;},{&quot;TagKey&quot;:&quot;S1key2&quot;,&quot;TagValue&quot;:&quot;S2val2&quot;}]</c> are added to the CMK whose ID is <c>08c33a6f-4e0a-4a1b-a3fa-7ddf****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// TagResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// TagResourceResponse
        /// </returns>
        public TagResourceResponse TagResource(TagResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TagResourceWithOptions(request, runtime);
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can add up to 10 tags to a CMK, secret, or certificate.
        /// In this example, the tags <c>[{&quot;TagKey&quot;:&quot;S1key1&quot;,&quot;TagValue&quot;:&quot;S1val1&quot;},{&quot;TagKey&quot;:&quot;S1key2&quot;,&quot;TagValue&quot;:&quot;S2val2&quot;}]</c> are added to the CMK whose ID is <c>08c33a6f-4e0a-4a1b-a3fa-7ddf****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// TagResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// TagResourceResponse
        /// </returns>
        public async Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TagResourceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds tags to keys or secrets.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can add multiple tags to multiple keys or multiple secrets at a time.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// TagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TagResourcesResponse
        /// </returns>
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
            return TeaModel.ToObject<TagResourcesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds tags to keys or secrets.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can add multiple tags to multiple keys or multiple secrets at a time.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// TagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TagResourcesResponse
        /// </returns>
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
            return TeaModel.ToObject<TagResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds tags to keys or secrets.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can add multiple tags to multiple keys or multiple secrets at a time.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// TagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// TagResourcesResponse
        /// </returns>
        public TagResourcesResponse TagResources(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TagResourcesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds tags to keys or secrets.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can add multiple tags to multiple keys or multiple secrets at a time.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// TagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// TagResourcesResponse
        /// </returns>
        public async Task<TagResourcesResponse> TagResourcesAsync(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TagResourcesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>One or more tag keys. Separate multiple tag keys with commas (,).
        /// You need to specify only the tag keys, not the tag values.
        /// Each tag key must be 1 to 128 bytes in length.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UntagResourceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UntagResourceResponse
        /// </returns>
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
            return TeaModel.ToObject<UntagResourceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>One or more tag keys. Separate multiple tag keys with commas (,).
        /// You need to specify only the tag keys, not the tag values.
        /// Each tag key must be 1 to 128 bytes in length.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UntagResourceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UntagResourceResponse
        /// </returns>
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
            return TeaModel.ToObject<UntagResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>One or more tag keys. Separate multiple tag keys with commas (,).
        /// You need to specify only the tag keys, not the tag values.
        /// Each tag key must be 1 to 128 bytes in length.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UntagResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// UntagResourceResponse
        /// </returns>
        public UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UntagResourceWithOptions(request, runtime);
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>One or more tag keys. Separate multiple tag keys with commas (,).
        /// You need to specify only the tag keys, not the tag values.
        /// Each tag key must be 1 to 128 bytes in length.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UntagResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// UntagResourceResponse
        /// </returns>
        public async Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UntagResourceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes tags from keys or secrets.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can remove multiple tags from multiple keys or multiple secrets at a time. You cannot remove tags that start with aliyun or acs:.
        /// If you enter multiple tag keys in the request parameters and only some of the tag keys are associated with resources, the operation can be called and the tags whose keys are associated with resources are removed from the resources.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UntagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UntagResourcesResponse
        /// </returns>
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
            return TeaModel.ToObject<UntagResourcesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes tags from keys or secrets.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can remove multiple tags from multiple keys or multiple secrets at a time. You cannot remove tags that start with aliyun or acs:.
        /// If you enter multiple tag keys in the request parameters and only some of the tag keys are associated with resources, the operation can be called and the tags whose keys are associated with resources are removed from the resources.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UntagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UntagResourcesResponse
        /// </returns>
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
            return TeaModel.ToObject<UntagResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes tags from keys or secrets.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can remove multiple tags from multiple keys or multiple secrets at a time. You cannot remove tags that start with aliyun or acs:.
        /// If you enter multiple tag keys in the request parameters and only some of the tag keys are associated with resources, the operation can be called and the tags whose keys are associated with resources are removed from the resources.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UntagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// UntagResourcesResponse
        /// </returns>
        public UntagResourcesResponse UntagResources(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UntagResourcesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes tags from keys or secrets.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can remove multiple tags from multiple keys or multiple secrets at a time. You cannot remove tags that start with aliyun or acs:.
        /// If you enter multiple tag keys in the request parameters and only some of the tag keys are associated with resources, the operation can be called and the tags whose keys are associated with resources are removed from the resources.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UntagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// UntagResourcesResponse
        /// </returns>
        public async Task<UntagResourcesResponse> UntagResourcesAsync(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UntagResourcesWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// UpdateAliasRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAliasResponse
        /// </returns>
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
            return TeaModel.ToObject<UpdateAliasResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// UpdateAliasRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAliasResponse
        /// </returns>
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
            return TeaModel.ToObject<UpdateAliasResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// UpdateAliasRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAliasResponse
        /// </returns>
        public UpdateAliasResponse UpdateAlias(UpdateAliasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAliasWithOptions(request, runtime);
        }

        /// <param name="request">
        /// UpdateAliasRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAliasResponse
        /// </returns>
        public async Task<UpdateAliasResponse> UpdateAliasAsync(UpdateAliasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAliasWithOptionsAsync(request, runtime);
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The update takes effect immediately after an AAP information is updated. Exercise caution when you perform this operation. You can update the description of an AAP and the permission policies that are associated with the AAP. You cannot update the name of the AAP.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateApplicationAccessPointRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateApplicationAccessPointResponse
        /// </returns>
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
            return TeaModel.ToObject<UpdateApplicationAccessPointResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The update takes effect immediately after an AAP information is updated. Exercise caution when you perform this operation. You can update the description of an AAP and the permission policies that are associated with the AAP. You cannot update the name of the AAP.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateApplicationAccessPointRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateApplicationAccessPointResponse
        /// </returns>
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
            return TeaModel.ToObject<UpdateApplicationAccessPointResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The update takes effect immediately after an AAP information is updated. Exercise caution when you perform this operation. You can update the description of an AAP and the permission policies that are associated with the AAP. You cannot update the name of the AAP.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateApplicationAccessPointRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateApplicationAccessPointResponse
        /// </returns>
        public UpdateApplicationAccessPointResponse UpdateApplicationAccessPoint(UpdateApplicationAccessPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateApplicationAccessPointWithOptions(request, runtime);
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The update takes effect immediately after an AAP information is updated. Exercise caution when you perform this operation. You can update the description of an AAP and the permission policies that are associated with the AAP. You cannot update the name of the AAP.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateApplicationAccessPointRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateApplicationAccessPointResponse
        /// </returns>
        public async Task<UpdateApplicationAccessPointResponse> UpdateApplicationAccessPointAsync(UpdateApplicationAccessPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateApplicationAccessPointWithOptionsAsync(request, runtime);
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In this example, the status of the certificate whose ID is <c>9a28de48-8d8b-484d-a766-dec4****</c> is updated to INACTIVE.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateCertificateStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateCertificateStatusResponse
        /// </returns>
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
            return TeaModel.ToObject<UpdateCertificateStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In this example, the status of the certificate whose ID is <c>9a28de48-8d8b-484d-a766-dec4****</c> is updated to INACTIVE.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateCertificateStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateCertificateStatusResponse
        /// </returns>
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
            return TeaModel.ToObject<UpdateCertificateStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In this example, the status of the certificate whose ID is <c>9a28de48-8d8b-484d-a766-dec4****</c> is updated to INACTIVE.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateCertificateStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateCertificateStatusResponse
        /// </returns>
        public UpdateCertificateStatusResponse UpdateCertificateStatus(UpdateCertificateStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateCertificateStatusWithOptions(request, runtime);
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In this example, the status of the certificate whose ID is <c>9a28de48-8d8b-484d-a766-dec4****</c> is updated to INACTIVE.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateCertificateStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateCertificateStatusResponse
        /// </returns>
        public async Task<UpdateCertificateStatusResponse> UpdateCertificateStatusAsync(UpdateCertificateStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateCertificateStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用UpdateKeyDescription接口更新主密钥的描述信息。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation replaces the description of a customer master key (CMK) with the description that you specify. The original description of the CMK is specified by the Description parameter when you call the <a href="https://help.aliyun.com/document_detail/28952.html">DescribeKey</a> operation. You can call this operation to add, modify, or delete the description of a CMK.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateKeyDescriptionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateKeyDescriptionResponse
        /// </returns>
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
            return TeaModel.ToObject<UpdateKeyDescriptionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用UpdateKeyDescription接口更新主密钥的描述信息。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation replaces the description of a customer master key (CMK) with the description that you specify. The original description of the CMK is specified by the Description parameter when you call the <a href="https://help.aliyun.com/document_detail/28952.html">DescribeKey</a> operation. You can call this operation to add, modify, or delete the description of a CMK.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateKeyDescriptionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateKeyDescriptionResponse
        /// </returns>
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
            return TeaModel.ToObject<UpdateKeyDescriptionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用UpdateKeyDescription接口更新主密钥的描述信息。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation replaces the description of a customer master key (CMK) with the description that you specify. The original description of the CMK is specified by the Description parameter when you call the <a href="https://help.aliyun.com/document_detail/28952.html">DescribeKey</a> operation. You can call this operation to add, modify, or delete the description of a CMK.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateKeyDescriptionRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateKeyDescriptionResponse
        /// </returns>
        public UpdateKeyDescriptionResponse UpdateKeyDescription(UpdateKeyDescriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateKeyDescriptionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用UpdateKeyDescription接口更新主密钥的描述信息。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation replaces the description of a customer master key (CMK) with the description that you specify. The original description of the CMK is specified by the Description parameter when you call the <a href="https://help.aliyun.com/document_detail/28952.html">DescribeKey</a> operation. You can call this operation to add, modify, or delete the description of a CMK.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateKeyDescriptionRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateKeyDescriptionResponse
        /// </returns>
        public async Task<UpdateKeyDescriptionResponse> UpdateKeyDescriptionAsync(UpdateKeyDescriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateKeyDescriptionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the virtual private cloud (VPC) that is associated with a Key Management Service (KMS) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If your own applications are deployed in multiple VPCs in the same region, you can associate the VPCs except the VPC in which the KMS instance resides with the KMS instance. This topic describes how to configure the VPCs.
        /// The VPCs can belong to the same Alibaba Cloud account or different Alibaba Cloud accounts. After the configuration is complete, the applications in these VPCs can access the KMS instance.</para>
        /// <remarks>
        /// <para>If the VPCs belong to different Alibaba Cloud accounts, you must first configure resource sharing to share the vSwitches of other Alibaba Cloud accounts with the Alibaba Cloud account to which the KMS instance belongs. For more information, see <a href="https://help.aliyun.com/document_detail/2393236.html">Access a KMS instance from multiple VPCs in the same region</a>.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateKmsInstanceBindVpcRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateKmsInstanceBindVpcResponse
        /// </returns>
        public UpdateKmsInstanceBindVpcResponse UpdateKmsInstanceBindVpcWithOptions(UpdateKmsInstanceBindVpcRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindVpcs))
            {
                query["BindVpcs"] = request.BindVpcs;
            }
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
                Action = "UpdateKmsInstanceBindVpc",
                Version = "2016-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateKmsInstanceBindVpcResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the virtual private cloud (VPC) that is associated with a Key Management Service (KMS) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If your own applications are deployed in multiple VPCs in the same region, you can associate the VPCs except the VPC in which the KMS instance resides with the KMS instance. This topic describes how to configure the VPCs.
        /// The VPCs can belong to the same Alibaba Cloud account or different Alibaba Cloud accounts. After the configuration is complete, the applications in these VPCs can access the KMS instance.</para>
        /// <remarks>
        /// <para>If the VPCs belong to different Alibaba Cloud accounts, you must first configure resource sharing to share the vSwitches of other Alibaba Cloud accounts with the Alibaba Cloud account to which the KMS instance belongs. For more information, see <a href="https://help.aliyun.com/document_detail/2393236.html">Access a KMS instance from multiple VPCs in the same region</a>.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateKmsInstanceBindVpcRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateKmsInstanceBindVpcResponse
        /// </returns>
        public async Task<UpdateKmsInstanceBindVpcResponse> UpdateKmsInstanceBindVpcWithOptionsAsync(UpdateKmsInstanceBindVpcRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindVpcs))
            {
                query["BindVpcs"] = request.BindVpcs;
            }
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
                Action = "UpdateKmsInstanceBindVpc",
                Version = "2016-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateKmsInstanceBindVpcResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the virtual private cloud (VPC) that is associated with a Key Management Service (KMS) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If your own applications are deployed in multiple VPCs in the same region, you can associate the VPCs except the VPC in which the KMS instance resides with the KMS instance. This topic describes how to configure the VPCs.
        /// The VPCs can belong to the same Alibaba Cloud account or different Alibaba Cloud accounts. After the configuration is complete, the applications in these VPCs can access the KMS instance.</para>
        /// <remarks>
        /// <para>If the VPCs belong to different Alibaba Cloud accounts, you must first configure resource sharing to share the vSwitches of other Alibaba Cloud accounts with the Alibaba Cloud account to which the KMS instance belongs. For more information, see <a href="https://help.aliyun.com/document_detail/2393236.html">Access a KMS instance from multiple VPCs in the same region</a>.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateKmsInstanceBindVpcRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateKmsInstanceBindVpcResponse
        /// </returns>
        public UpdateKmsInstanceBindVpcResponse UpdateKmsInstanceBindVpc(UpdateKmsInstanceBindVpcRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateKmsInstanceBindVpcWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the virtual private cloud (VPC) that is associated with a Key Management Service (KMS) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If your own applications are deployed in multiple VPCs in the same region, you can associate the VPCs except the VPC in which the KMS instance resides with the KMS instance. This topic describes how to configure the VPCs.
        /// The VPCs can belong to the same Alibaba Cloud account or different Alibaba Cloud accounts. After the configuration is complete, the applications in these VPCs can access the KMS instance.</para>
        /// <remarks>
        /// <para>If the VPCs belong to different Alibaba Cloud accounts, you must first configure resource sharing to share the vSwitches of other Alibaba Cloud accounts with the Alibaba Cloud account to which the KMS instance belongs. For more information, see <a href="https://help.aliyun.com/document_detail/2393236.html">Access a KMS instance from multiple VPCs in the same region</a>.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateKmsInstanceBindVpcRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateKmsInstanceBindVpcResponse
        /// </returns>
        public async Task<UpdateKmsInstanceBindVpcResponse> UpdateKmsInstanceBindVpcAsync(UpdateKmsInstanceBindVpcRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateKmsInstanceBindVpcWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an access control rule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>You can update only private IP addresses and description of an access control rule. You cannot update the name and network type of an access control rule.</description></item>
        /// <item><description>Updating an access control rule affects all permission policies that are bound to the access control rule. Exercise caution when you perform this operation.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateNetworkRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateNetworkRuleResponse
        /// </returns>
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
            return TeaModel.ToObject<UpdateNetworkRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an access control rule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>You can update only private IP addresses and description of an access control rule. You cannot update the name and network type of an access control rule.</description></item>
        /// <item><description>Updating an access control rule affects all permission policies that are bound to the access control rule. Exercise caution when you perform this operation.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateNetworkRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateNetworkRuleResponse
        /// </returns>
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
            return TeaModel.ToObject<UpdateNetworkRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an access control rule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>You can update only private IP addresses and description of an access control rule. You cannot update the name and network type of an access control rule.</description></item>
        /// <item><description>Updating an access control rule affects all permission policies that are bound to the access control rule. Exercise caution when you perform this operation.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateNetworkRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateNetworkRuleResponse
        /// </returns>
        public UpdateNetworkRuleResponse UpdateNetworkRule(UpdateNetworkRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateNetworkRuleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an access control rule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>You can update only private IP addresses and description of an access control rule. You cannot update the name and network type of an access control rule.</description></item>
        /// <item><description>Updating an access control rule affects all permission policies that are bound to the access control rule. Exercise caution when you perform this operation.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateNetworkRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateNetworkRuleResponse
        /// </returns>
        public async Task<UpdateNetworkRuleResponse> UpdateNetworkRuleAsync(UpdateNetworkRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateNetworkRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新一个权限策略</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>You can update the role-based access control (RBAC) permissions, accessible resources, access control rules, and description of a permission policy. You cannot update the name or scope of a permission policy.</description></item>
        /// <item><description>Updating a permission policy affects all application access points (AAPs) that are bound to the permission policy. Exercise caution when you perform this operation.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdatePolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdatePolicyResponse
        /// </returns>
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
            return TeaModel.ToObject<UpdatePolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新一个权限策略</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>You can update the role-based access control (RBAC) permissions, accessible resources, access control rules, and description of a permission policy. You cannot update the name or scope of a permission policy.</description></item>
        /// <item><description>Updating a permission policy affects all application access points (AAPs) that are bound to the permission policy. Exercise caution when you perform this operation.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdatePolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdatePolicyResponse
        /// </returns>
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
            return TeaModel.ToObject<UpdatePolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新一个权限策略</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>You can update the role-based access control (RBAC) permissions, accessible resources, access control rules, and description of a permission policy. You cannot update the name or scope of a permission policy.</description></item>
        /// <item><description>Updating a permission policy affects all application access points (AAPs) that are bound to the permission policy. Exercise caution when you perform this operation.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdatePolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdatePolicyResponse
        /// </returns>
        public UpdatePolicyResponse UpdatePolicy(UpdatePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdatePolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新一个权限策略</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>You can update the role-based access control (RBAC) permissions, accessible resources, access control rules, and description of a permission policy. You cannot update the name or scope of a permission policy.</description></item>
        /// <item><description>Updating a permission policy affects all application access points (AAPs) that are bound to the permission policy. Exercise caution when you perform this operation.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdatePolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdatePolicyResponse
        /// </returns>
        public async Task<UpdatePolicyResponse> UpdatePolicyAsync(UpdatePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdatePolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When automatic key rotation is enabled, KMS automatically creates a key version after the preset rotation period arrives. In addition, KMS sets the new key version as the primary key version.
        /// An automatic key rotation policy cannot be configured for the following keys:</para>
        /// <list type="bullet">
        /// <item><description>Asymmetric key</description></item>
        /// <item><description>Service-managed key</description></item>
        /// <item><description>Bring your own key (BYOK) that is imported into KMS</description></item>
        /// <item><description>Key that is not in the <b>Enabled</b> state
        /// In this example, automatic key rotation is enabled for a CMK whose ID is <c>1234abcd-12ab-34cd-56ef-12345678****</c>. The automatic rotation period is 30 days.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateRotationPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateRotationPolicyResponse
        /// </returns>
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
            return TeaModel.ToObject<UpdateRotationPolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When automatic key rotation is enabled, KMS automatically creates a key version after the preset rotation period arrives. In addition, KMS sets the new key version as the primary key version.
        /// An automatic key rotation policy cannot be configured for the following keys:</para>
        /// <list type="bullet">
        /// <item><description>Asymmetric key</description></item>
        /// <item><description>Service-managed key</description></item>
        /// <item><description>Bring your own key (BYOK) that is imported into KMS</description></item>
        /// <item><description>Key that is not in the <b>Enabled</b> state
        /// In this example, automatic key rotation is enabled for a CMK whose ID is <c>1234abcd-12ab-34cd-56ef-12345678****</c>. The automatic rotation period is 30 days.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateRotationPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateRotationPolicyResponse
        /// </returns>
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
            return TeaModel.ToObject<UpdateRotationPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When automatic key rotation is enabled, KMS automatically creates a key version after the preset rotation period arrives. In addition, KMS sets the new key version as the primary key version.
        /// An automatic key rotation policy cannot be configured for the following keys:</para>
        /// <list type="bullet">
        /// <item><description>Asymmetric key</description></item>
        /// <item><description>Service-managed key</description></item>
        /// <item><description>Bring your own key (BYOK) that is imported into KMS</description></item>
        /// <item><description>Key that is not in the <b>Enabled</b> state
        /// In this example, automatic key rotation is enabled for a CMK whose ID is <c>1234abcd-12ab-34cd-56ef-12345678****</c>. The automatic rotation period is 30 days.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateRotationPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateRotationPolicyResponse
        /// </returns>
        public UpdateRotationPolicyResponse UpdateRotationPolicy(UpdateRotationPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateRotationPolicyWithOptions(request, runtime);
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When automatic key rotation is enabled, KMS automatically creates a key version after the preset rotation period arrives. In addition, KMS sets the new key version as the primary key version.
        /// An automatic key rotation policy cannot be configured for the following keys:</para>
        /// <list type="bullet">
        /// <item><description>Asymmetric key</description></item>
        /// <item><description>Service-managed key</description></item>
        /// <item><description>Bring your own key (BYOK) that is imported into KMS</description></item>
        /// <item><description>Key that is not in the <b>Enabled</b> state
        /// In this example, automatic key rotation is enabled for a CMK whose ID is <c>1234abcd-12ab-34cd-56ef-12345678****</c>. The automatic rotation period is 30 days.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateRotationPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateRotationPolicyResponse
        /// </returns>
        public async Task<UpdateRotationPolicyResponse> UpdateRotationPolicyAsync(UpdateRotationPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateRotationPolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the metadata of a secret.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In this example, the metadata of the <c>secret001</c> secret is updated. The <c>Description</c> parameter is set to <c>datainfo</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateSecretRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSecretResponse
        /// </returns>
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
            return TeaModel.ToObject<UpdateSecretResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the metadata of a secret.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In this example, the metadata of the <c>secret001</c> secret is updated. The <c>Description</c> parameter is set to <c>datainfo</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateSecretRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSecretResponse
        /// </returns>
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
            return TeaModel.ToObject<UpdateSecretResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the metadata of a secret.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In this example, the metadata of the <c>secret001</c> secret is updated. The <c>Description</c> parameter is set to <c>datainfo</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateSecretRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSecretResponse
        /// </returns>
        public UpdateSecretResponse UpdateSecret(UpdateSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateSecretWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the metadata of a secret.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In this example, the metadata of the <c>secret001</c> secret is updated. The <c>Description</c> parameter is set to <c>datainfo</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateSecretRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSecretResponse
        /// </returns>
        public async Task<UpdateSecretResponse> UpdateSecretAsync(UpdateSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateSecretWithOptionsAsync(request, runtime);
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After automatic rotation is enabled, Secrets Manager schedules the first automatic rotation by adding the preset rotation interval to the timestamp of the last rotation.
        /// Limits: The UpdateSecretRotationPolicy operation cannot be used to update the rotation policy of generic secrets.
        /// In this example, the rotation policy of the <c>RdsSecret/Mysql5.4/MyCred</c> secret is updated. The following settings are modified:</para>
        /// <list type="bullet">
        /// <item><description>The <c>EnableAutomaticRotation</c> parameter is set to <c>true</c>, which indicates that automatic rotation is enabled.</description></item>
        /// <item><description>The <c>RotationInterval</c> parameter is set to <c>30d</c>, which indicates that the interval for automatic rotation is 30 days.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateSecretRotationPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSecretRotationPolicyResponse
        /// </returns>
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
            return TeaModel.ToObject<UpdateSecretRotationPolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After automatic rotation is enabled, Secrets Manager schedules the first automatic rotation by adding the preset rotation interval to the timestamp of the last rotation.
        /// Limits: The UpdateSecretRotationPolicy operation cannot be used to update the rotation policy of generic secrets.
        /// In this example, the rotation policy of the <c>RdsSecret/Mysql5.4/MyCred</c> secret is updated. The following settings are modified:</para>
        /// <list type="bullet">
        /// <item><description>The <c>EnableAutomaticRotation</c> parameter is set to <c>true</c>, which indicates that automatic rotation is enabled.</description></item>
        /// <item><description>The <c>RotationInterval</c> parameter is set to <c>30d</c>, which indicates that the interval for automatic rotation is 30 days.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateSecretRotationPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSecretRotationPolicyResponse
        /// </returns>
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
            return TeaModel.ToObject<UpdateSecretRotationPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After automatic rotation is enabled, Secrets Manager schedules the first automatic rotation by adding the preset rotation interval to the timestamp of the last rotation.
        /// Limits: The UpdateSecretRotationPolicy operation cannot be used to update the rotation policy of generic secrets.
        /// In this example, the rotation policy of the <c>RdsSecret/Mysql5.4/MyCred</c> secret is updated. The following settings are modified:</para>
        /// <list type="bullet">
        /// <item><description>The <c>EnableAutomaticRotation</c> parameter is set to <c>true</c>, which indicates that automatic rotation is enabled.</description></item>
        /// <item><description>The <c>RotationInterval</c> parameter is set to <c>30d</c>, which indicates that the interval for automatic rotation is 30 days.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateSecretRotationPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSecretRotationPolicyResponse
        /// </returns>
        public UpdateSecretRotationPolicyResponse UpdateSecretRotationPolicy(UpdateSecretRotationPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateSecretRotationPolicyWithOptions(request, runtime);
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After automatic rotation is enabled, Secrets Manager schedules the first automatic rotation by adding the preset rotation interval to the timestamp of the last rotation.
        /// Limits: The UpdateSecretRotationPolicy operation cannot be used to update the rotation policy of generic secrets.
        /// In this example, the rotation policy of the <c>RdsSecret/Mysql5.4/MyCred</c> secret is updated. The following settings are modified:</para>
        /// <list type="bullet">
        /// <item><description>The <c>EnableAutomaticRotation</c> parameter is set to <c>true</c>, which indicates that automatic rotation is enabled.</description></item>
        /// <item><description>The <c>RotationInterval</c> parameter is set to <c>30d</c>, which indicates that the interval for automatic rotation is 30 days.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateSecretRotationPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSecretRotationPolicyResponse
        /// </returns>
        public async Task<UpdateSecretRotationPolicyResponse> UpdateSecretRotationPolicyAsync(UpdateSecretRotationPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateSecretRotationPolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>UpdateSecretVersionStage</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the stage label that marks a secret version.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateSecretVersionStageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSecretVersionStageResponse
        /// </returns>
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
            return TeaModel.ToObject<UpdateSecretVersionStageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>UpdateSecretVersionStage</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the stage label that marks a secret version.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateSecretVersionStageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSecretVersionStageResponse
        /// </returns>
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
            return TeaModel.ToObject<UpdateSecretVersionStageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>UpdateSecretVersionStage</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the stage label that marks a secret version.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateSecretVersionStageRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSecretVersionStageResponse
        /// </returns>
        public UpdateSecretVersionStageResponse UpdateSecretVersionStage(UpdateSecretVersionStageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateSecretVersionStageWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>UpdateSecretVersionStage</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the stage label that marks a secret version.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateSecretVersionStageRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSecretVersionStageResponse
        /// </returns>
        public async Task<UpdateSecretVersionStageResponse> UpdateSecretVersionStageAsync(UpdateSecretVersionStageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateSecretVersionStageWithOptionsAsync(request, runtime);
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In this example, a certificate issued by a CA is imported into Certificates Manager. The ID of the certificate in Certificates Manager is <c>12345678-1234-1234-1234-12345678****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UploadCertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UploadCertificateResponse
        /// </returns>
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
            return TeaModel.ToObject<UploadCertificateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In this example, a certificate issued by a CA is imported into Certificates Manager. The ID of the certificate in Certificates Manager is <c>12345678-1234-1234-1234-12345678****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UploadCertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UploadCertificateResponse
        /// </returns>
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
            return TeaModel.ToObject<UploadCertificateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In this example, a certificate issued by a CA is imported into Certificates Manager. The ID of the certificate in Certificates Manager is <c>12345678-1234-1234-1234-12345678****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UploadCertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// UploadCertificateResponse
        /// </returns>
        public UploadCertificateResponse UploadCertificate(UploadCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UploadCertificateWithOptions(request, runtime);
        }

        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>In this example, a certificate issued by a CA is imported into Certificates Manager. The ID of the certificate in Certificates Manager is <c>12345678-1234-1234-1234-12345678****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UploadCertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// UploadCertificateResponse
        /// </returns>
        public async Task<UploadCertificateResponse> UploadCertificateAsync(UploadCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UploadCertificateWithOptionsAsync(request, runtime);
        }

    }
}
