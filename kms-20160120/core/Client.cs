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
            this._endpointMap = new Dictionary<string, string>
            {
                {"us-west-1", "kms.us-west-1.aliyuncs.com"},
                {"us-east-1", "kms.us-east-1.aliyuncs.com"},
                {"me-east-1", "kms.me-east-1.aliyuncs.com"},
                {"me-central-1", "kms.me-central-1.aliyuncs.com"},
                {"eu-west-1", "kms.eu-west-1.aliyuncs.com"},
                {"eu-central-1", "kms.eu-central-1.aliyuncs.com"},
                {"cn-zhengzhou-jva", "kms.cn-zhengzhou-jva.aliyuncs.com"},
                {"cn-zhangjiakou", "kms.cn-zhangjiakou.aliyuncs.com"},
                {"cn-wulanchabu", "kms.cn-wulanchabu.aliyuncs.com"},
                {"cn-wuhan-lr", "kms.cn-wuhan-lr.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "kms.cn-shenzhen-finance-1.aliyuncs.com"},
                {"cn-shenzhen", "kms.cn-shenzhen.aliyuncs.com"},
                {"cn-shanghai-finance-1", "kms.cn-shanghai-finance-1.aliyuncs.com"},
                {"cn-shanghai", "kms.cn-shanghai.aliyuncs.com"},
                {"cn-qingdao", "kms.cn-qingdao.aliyuncs.com"},
                {"cn-huhehaote", "kms.cn-huhehaote.aliyuncs.com"},
                {"cn-hongkong", "kms.cn-hongkong.aliyuncs.com"},
                {"cn-heyuan", "kms.cn-heyuan.aliyuncs.com"},
                {"cn-hangzhou-finance", "kms.cn-hangzhou-finance.aliyuncs.com"},
                {"cn-hangzhou", "kms.cn-hangzhou.aliyuncs.com"},
                {"cn-guangzhou", "kms.cn-guangzhou.aliyuncs.com"},
                {"cn-fuzhou", "kms.cn-fuzhou.aliyuncs.com"},
                {"cn-chengdu", "kms.cn-chengdu.aliyuncs.com"},
                {"cn-beijing-finance-1", "kms.cn-beijing-finance-1.aliyuncs.com"},
                {"cn-beijing", "kms.cn-beijing.aliyuncs.com"},
                {"ap-southeast-7", "kms.ap-southeast-7.aliyuncs.com"},
                {"ap-southeast-6", "kms.ap-southeast-6.aliyuncs.com"},
                {"ap-southeast-5", "kms.ap-southeast-5.aliyuncs.com"},
                {"ap-southeast-3", "kms.ap-southeast-3.aliyuncs.com"},
                {"ap-southeast-1", "kms.ap-southeast-1.aliyuncs.com"},
                {"ap-northeast-2", "kms.ap-northeast-2.aliyuncs.com"},
                {"ap-northeast-1", "kms.ap-northeast-1.aliyuncs.com"},
            };
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
        /// <para>Decrypts data by using the private key of an asymmetric CMK.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Usage notes</h3>
        /// <list type="bullet">
        /// <item><description>For information about the access policy required for a RAM user or RAM role to call this API operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>This operation can be called through a shared gateway or a dedicated gateway. For more information, see <a href="https://help.aliyun.com/document_detail/601559.html">Alibaba Cloud SDK</a>.<list type="bullet">
        /// <item><description>Shared gateway: You can access KMS over the Internet or a VPC. To access KMS over the Internet, you must enable the public endpoint. For more information, see <a href="https://help.aliyun.com/document_detail/2856718.html">Access keys in a KMS instance over the Internet</a>.</description></item>
        /// <item><description>Dedicated gateway: You can access KMS using the private endpoint of KMS (<c>&lt;YOUR_KMS_INSTANCE_ID&gt;.cryptoservice.kms.aliyuncs.com</c>).</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <h3>QPS limits</h3>
        /// <list type="bullet">
        /// <item><description>If you use a shared gateway, the queries per second (QPS) limit for each Alibaba Cloud account is 200. If the QPS exceeds the limit, the API call is throttled. This can affect your business. We recommend that you plan your calls to avoid exceeding this limit.</description></item>
        /// <item><description>If you use a dedicated gateway, the QPS limit for each Alibaba Cloud account is subject to the performance specifications of your KMS instance. For more information, see <a href="https://help.aliyun.com/document_detail/480120.html">Performance metrics</a>.</description></item>
        /// </list>
        /// <h3>Description</h3>
        /// <para>This operation supports only asymmetric keys for which the <b>Usage</b> parameter is set to <b>ENCRYPT/DECRYPT</b>. The following table describes the supported encryption algorithms.</para>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>KeySpec</th>
        /// <th>Algorithm</th>
        /// <th>Description</th>
        /// <th>Ciphertext length (bytes)</th>
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
        /// <td>SM2 elliptic curve public key encryption algorithm</td>
        /// <td>Maximum 6,144</td>
        /// </tr>
        /// <tr>
        /// <td>This topic provides an example of how to use the asymmetric key whose ID is <c>key-hzz630494463ejqjx****</c> and version ID is <c>2ab1a983-7072-4bbc-a582-584b5bd8****</c> to decrypt the ciphertext <c>BQKP+1zK6+ZEMxTP5qaVzcsgXtWplYBKm0NXdSnB5FzliFxE1bSiu4dnEIlca2JpeH7yz1/S6fed630H+hIH6DoM25fTLNcKj+mFB0Xnh9m2+HN59Mn4qyTfcUeadnfCXSWcGBouhXFwcdd2rJ3n337bzTf4jm659gZu3L0i6PLuxM9p7mqdwO0cKJPfGVfhnfMz+f4alMg79WB/NNyE2lyX7/qxvV49ObNrrJbKSFiz8Djocaf0IESNLMbfYI5bXjWkJlX92DQbKhibtQW8ZOJ//ZC6t0AWcUoKL6QDm/dg5koQalcleRinpB+QadFm894sLbVZ9+N4GVsv1W****==</c> using the <c>RSAES_OAEP_SHA_1</c> decryption algorithm.</td>
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
        /// <para>Decrypts data by using the private key of an asymmetric CMK.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Usage notes</h3>
        /// <list type="bullet">
        /// <item><description>For information about the access policy required for a RAM user or RAM role to call this API operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>This operation can be called through a shared gateway or a dedicated gateway. For more information, see <a href="https://help.aliyun.com/document_detail/601559.html">Alibaba Cloud SDK</a>.<list type="bullet">
        /// <item><description>Shared gateway: You can access KMS over the Internet or a VPC. To access KMS over the Internet, you must enable the public endpoint. For more information, see <a href="https://help.aliyun.com/document_detail/2856718.html">Access keys in a KMS instance over the Internet</a>.</description></item>
        /// <item><description>Dedicated gateway: You can access KMS using the private endpoint of KMS (<c>&lt;YOUR_KMS_INSTANCE_ID&gt;.cryptoservice.kms.aliyuncs.com</c>).</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <h3>QPS limits</h3>
        /// <list type="bullet">
        /// <item><description>If you use a shared gateway, the queries per second (QPS) limit for each Alibaba Cloud account is 200. If the QPS exceeds the limit, the API call is throttled. This can affect your business. We recommend that you plan your calls to avoid exceeding this limit.</description></item>
        /// <item><description>If you use a dedicated gateway, the QPS limit for each Alibaba Cloud account is subject to the performance specifications of your KMS instance. For more information, see <a href="https://help.aliyun.com/document_detail/480120.html">Performance metrics</a>.</description></item>
        /// </list>
        /// <h3>Description</h3>
        /// <para>This operation supports only asymmetric keys for which the <b>Usage</b> parameter is set to <b>ENCRYPT/DECRYPT</b>. The following table describes the supported encryption algorithms.</para>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>KeySpec</th>
        /// <th>Algorithm</th>
        /// <th>Description</th>
        /// <th>Ciphertext length (bytes)</th>
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
        /// <td>SM2 elliptic curve public key encryption algorithm</td>
        /// <td>Maximum 6,144</td>
        /// </tr>
        /// <tr>
        /// <td>This topic provides an example of how to use the asymmetric key whose ID is <c>key-hzz630494463ejqjx****</c> and version ID is <c>2ab1a983-7072-4bbc-a582-584b5bd8****</c> to decrypt the ciphertext <c>BQKP+1zK6+ZEMxTP5qaVzcsgXtWplYBKm0NXdSnB5FzliFxE1bSiu4dnEIlca2JpeH7yz1/S6fed630H+hIH6DoM25fTLNcKj+mFB0Xnh9m2+HN59Mn4qyTfcUeadnfCXSWcGBouhXFwcdd2rJ3n337bzTf4jm659gZu3L0i6PLuxM9p7mqdwO0cKJPfGVfhnfMz+f4alMg79WB/NNyE2lyX7/qxvV49ObNrrJbKSFiz8Djocaf0IESNLMbfYI5bXjWkJlX92DQbKhibtQW8ZOJ//ZC6t0AWcUoKL6QDm/dg5koQalcleRinpB+QadFm894sLbVZ9+N4GVsv1W****==</c> using the <c>RSAES_OAEP_SHA_1</c> decryption algorithm.</td>
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
        /// <para>Decrypts data by using the private key of an asymmetric CMK.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Usage notes</h3>
        /// <list type="bullet">
        /// <item><description>For information about the access policy required for a RAM user or RAM role to call this API operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>This operation can be called through a shared gateway or a dedicated gateway. For more information, see <a href="https://help.aliyun.com/document_detail/601559.html">Alibaba Cloud SDK</a>.<list type="bullet">
        /// <item><description>Shared gateway: You can access KMS over the Internet or a VPC. To access KMS over the Internet, you must enable the public endpoint. For more information, see <a href="https://help.aliyun.com/document_detail/2856718.html">Access keys in a KMS instance over the Internet</a>.</description></item>
        /// <item><description>Dedicated gateway: You can access KMS using the private endpoint of KMS (<c>&lt;YOUR_KMS_INSTANCE_ID&gt;.cryptoservice.kms.aliyuncs.com</c>).</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <h3>QPS limits</h3>
        /// <list type="bullet">
        /// <item><description>If you use a shared gateway, the queries per second (QPS) limit for each Alibaba Cloud account is 200. If the QPS exceeds the limit, the API call is throttled. This can affect your business. We recommend that you plan your calls to avoid exceeding this limit.</description></item>
        /// <item><description>If you use a dedicated gateway, the QPS limit for each Alibaba Cloud account is subject to the performance specifications of your KMS instance. For more information, see <a href="https://help.aliyun.com/document_detail/480120.html">Performance metrics</a>.</description></item>
        /// </list>
        /// <h3>Description</h3>
        /// <para>This operation supports only asymmetric keys for which the <b>Usage</b> parameter is set to <b>ENCRYPT/DECRYPT</b>. The following table describes the supported encryption algorithms.</para>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>KeySpec</th>
        /// <th>Algorithm</th>
        /// <th>Description</th>
        /// <th>Ciphertext length (bytes)</th>
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
        /// <td>SM2 elliptic curve public key encryption algorithm</td>
        /// <td>Maximum 6,144</td>
        /// </tr>
        /// <tr>
        /// <td>This topic provides an example of how to use the asymmetric key whose ID is <c>key-hzz630494463ejqjx****</c> and version ID is <c>2ab1a983-7072-4bbc-a582-584b5bd8****</c> to decrypt the ciphertext <c>BQKP+1zK6+ZEMxTP5qaVzcsgXtWplYBKm0NXdSnB5FzliFxE1bSiu4dnEIlca2JpeH7yz1/S6fed630H+hIH6DoM25fTLNcKj+mFB0Xnh9m2+HN59Mn4qyTfcUeadnfCXSWcGBouhXFwcdd2rJ3n337bzTf4jm659gZu3L0i6PLuxM9p7mqdwO0cKJPfGVfhnfMz+f4alMg79WB/NNyE2lyX7/qxvV49ObNrrJbKSFiz8Djocaf0IESNLMbfYI5bXjWkJlX92DQbKhibtQW8ZOJ//ZC6t0AWcUoKL6QDm/dg5koQalcleRinpB+QadFm894sLbVZ9+N4GVsv1W****==</c> using the <c>RSAES_OAEP_SHA_1</c> decryption algorithm.</td>
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
        /// <para>Decrypts data by using the private key of an asymmetric CMK.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Usage notes</h3>
        /// <list type="bullet">
        /// <item><description>For information about the access policy required for a RAM user or RAM role to call this API operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>This operation can be called through a shared gateway or a dedicated gateway. For more information, see <a href="https://help.aliyun.com/document_detail/601559.html">Alibaba Cloud SDK</a>.<list type="bullet">
        /// <item><description>Shared gateway: You can access KMS over the Internet or a VPC. To access KMS over the Internet, you must enable the public endpoint. For more information, see <a href="https://help.aliyun.com/document_detail/2856718.html">Access keys in a KMS instance over the Internet</a>.</description></item>
        /// <item><description>Dedicated gateway: You can access KMS using the private endpoint of KMS (<c>&lt;YOUR_KMS_INSTANCE_ID&gt;.cryptoservice.kms.aliyuncs.com</c>).</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <h3>QPS limits</h3>
        /// <list type="bullet">
        /// <item><description>If you use a shared gateway, the queries per second (QPS) limit for each Alibaba Cloud account is 200. If the QPS exceeds the limit, the API call is throttled. This can affect your business. We recommend that you plan your calls to avoid exceeding this limit.</description></item>
        /// <item><description>If you use a dedicated gateway, the QPS limit for each Alibaba Cloud account is subject to the performance specifications of your KMS instance. For more information, see <a href="https://help.aliyun.com/document_detail/480120.html">Performance metrics</a>.</description></item>
        /// </list>
        /// <h3>Description</h3>
        /// <para>This operation supports only asymmetric keys for which the <b>Usage</b> parameter is set to <b>ENCRYPT/DECRYPT</b>. The following table describes the supported encryption algorithms.</para>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>KeySpec</th>
        /// <th>Algorithm</th>
        /// <th>Description</th>
        /// <th>Ciphertext length (bytes)</th>
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
        /// <td>SM2 elliptic curve public key encryption algorithm</td>
        /// <td>Maximum 6,144</td>
        /// </tr>
        /// <tr>
        /// <td>This topic provides an example of how to use the asymmetric key whose ID is <c>key-hzz630494463ejqjx****</c> and version ID is <c>2ab1a983-7072-4bbc-a582-584b5bd8****</c> to decrypt the ciphertext <c>BQKP+1zK6+ZEMxTP5qaVzcsgXtWplYBKm0NXdSnB5FzliFxE1bSiu4dnEIlca2JpeH7yz1/S6fed630H+hIH6DoM25fTLNcKj+mFB0Xnh9m2+HN59Mn4qyTfcUeadnfCXSWcGBouhXFwcdd2rJ3n337bzTf4jm659gZu3L0i6PLuxM9p7mqdwO0cKJPfGVfhnfMz+f4alMg79WB/NNyE2lyX7/qxvV49ObNrrJbKSFiz8Djocaf0IESNLMbfYI5bXjWkJlX92DQbKhibtQW8ZOJ//ZC6t0AWcUoKL6QDm/dg5koQalcleRinpB+QadFm894sLbVZ9+N4GVsv1W****==</c> using the <c>RSAES_OAEP_SHA_1</c> decryption algorithm.</td>
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
        /// <para>Encrypts data by using the public key of an asymmetric CMK.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Precautions</h3>
        /// <list type="bullet">
        /// <item><description>For information about the permissions that are required to call this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>This operation can be called through a shared gateway or a dedicated gateway. For more information, see <a href="https://help.aliyun.com/document_detail/601559.html">Alibaba Cloud SDK</a>.<list type="bullet">
        /// <item><description>Shared gateway: You can access KMS over the Internet or using a VPC domain name. To access KMS over the Internet, you must enable Internet access. For more information, see <a href="https://help.aliyun.com/document_detail/2856718.html">Access a key in a KMS instance over the Internet</a>.</description></item>
        /// <item><description>Dedicated gateway: You can access KMS using the private endpoint of KMS (<c>&lt;YOUR_KMS_INSTANCE_ID&gt;.cryptoservice.kms.aliyuncs.com</c>).</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <h3>QPS limits</h3>
        /// <list type="bullet">
        /// <item><description>If you use a shared gateway: The number of queries per second (QPS) for a single user is limited to 200. If the limit is exceeded, API calls are throttled. This may affect your business. We recommend that you plan your API calls to avoid exceeding this limit.</description></item>
        /// <item><description>If you use a dedicated gateway: The QPS limit for a single user depends on the computing performance specifications of your KMS instance. For more information, see <a href="https://help.aliyun.com/document_detail/480120.html">Performance metrics</a>.</description></item>
        /// </list>
        /// <h3>Description</h3>
        /// <para>This operation supports only asymmetric keys that have the <b>Usage</b> parameter set to <b>ENCRYPT/DECRYPT</b>. The following table describes the supported encryption algorithms.</para>
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
        /// <td>SM2 elliptic curve public key encryption algorithm</td>
        /// <td>6047</td>
        /// </tr>
        /// <tr>
        /// <td>In this example, the plaintext <c>SGVsbG8gd29ybGQ=</c> is encrypted using an asymmetric key with the key ID <c>key-hzz630494463ejqjx****</c>, the key version ID <c>2ab1a983-7072-4bbc-a582-584b5bd8****</c>, and the <c>RSAES_OAEP_SHA_1</c> encryption algorithm.</td>
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
        /// <para>Encrypts data by using the public key of an asymmetric CMK.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Precautions</h3>
        /// <list type="bullet">
        /// <item><description>For information about the permissions that are required to call this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>This operation can be called through a shared gateway or a dedicated gateway. For more information, see <a href="https://help.aliyun.com/document_detail/601559.html">Alibaba Cloud SDK</a>.<list type="bullet">
        /// <item><description>Shared gateway: You can access KMS over the Internet or using a VPC domain name. To access KMS over the Internet, you must enable Internet access. For more information, see <a href="https://help.aliyun.com/document_detail/2856718.html">Access a key in a KMS instance over the Internet</a>.</description></item>
        /// <item><description>Dedicated gateway: You can access KMS using the private endpoint of KMS (<c>&lt;YOUR_KMS_INSTANCE_ID&gt;.cryptoservice.kms.aliyuncs.com</c>).</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <h3>QPS limits</h3>
        /// <list type="bullet">
        /// <item><description>If you use a shared gateway: The number of queries per second (QPS) for a single user is limited to 200. If the limit is exceeded, API calls are throttled. This may affect your business. We recommend that you plan your API calls to avoid exceeding this limit.</description></item>
        /// <item><description>If you use a dedicated gateway: The QPS limit for a single user depends on the computing performance specifications of your KMS instance. For more information, see <a href="https://help.aliyun.com/document_detail/480120.html">Performance metrics</a>.</description></item>
        /// </list>
        /// <h3>Description</h3>
        /// <para>This operation supports only asymmetric keys that have the <b>Usage</b> parameter set to <b>ENCRYPT/DECRYPT</b>. The following table describes the supported encryption algorithms.</para>
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
        /// <td>SM2 elliptic curve public key encryption algorithm</td>
        /// <td>6047</td>
        /// </tr>
        /// <tr>
        /// <td>In this example, the plaintext <c>SGVsbG8gd29ybGQ=</c> is encrypted using an asymmetric key with the key ID <c>key-hzz630494463ejqjx****</c>, the key version ID <c>2ab1a983-7072-4bbc-a582-584b5bd8****</c>, and the <c>RSAES_OAEP_SHA_1</c> encryption algorithm.</td>
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
        /// <para>Encrypts data by using the public key of an asymmetric CMK.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Precautions</h3>
        /// <list type="bullet">
        /// <item><description>For information about the permissions that are required to call this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>This operation can be called through a shared gateway or a dedicated gateway. For more information, see <a href="https://help.aliyun.com/document_detail/601559.html">Alibaba Cloud SDK</a>.<list type="bullet">
        /// <item><description>Shared gateway: You can access KMS over the Internet or using a VPC domain name. To access KMS over the Internet, you must enable Internet access. For more information, see <a href="https://help.aliyun.com/document_detail/2856718.html">Access a key in a KMS instance over the Internet</a>.</description></item>
        /// <item><description>Dedicated gateway: You can access KMS using the private endpoint of KMS (<c>&lt;YOUR_KMS_INSTANCE_ID&gt;.cryptoservice.kms.aliyuncs.com</c>).</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <h3>QPS limits</h3>
        /// <list type="bullet">
        /// <item><description>If you use a shared gateway: The number of queries per second (QPS) for a single user is limited to 200. If the limit is exceeded, API calls are throttled. This may affect your business. We recommend that you plan your API calls to avoid exceeding this limit.</description></item>
        /// <item><description>If you use a dedicated gateway: The QPS limit for a single user depends on the computing performance specifications of your KMS instance. For more information, see <a href="https://help.aliyun.com/document_detail/480120.html">Performance metrics</a>.</description></item>
        /// </list>
        /// <h3>Description</h3>
        /// <para>This operation supports only asymmetric keys that have the <b>Usage</b> parameter set to <b>ENCRYPT/DECRYPT</b>. The following table describes the supported encryption algorithms.</para>
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
        /// <td>SM2 elliptic curve public key encryption algorithm</td>
        /// <td>6047</td>
        /// </tr>
        /// <tr>
        /// <td>In this example, the plaintext <c>SGVsbG8gd29ybGQ=</c> is encrypted using an asymmetric key with the key ID <c>key-hzz630494463ejqjx****</c>, the key version ID <c>2ab1a983-7072-4bbc-a582-584b5bd8****</c>, and the <c>RSAES_OAEP_SHA_1</c> encryption algorithm.</td>
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
        /// <para>Encrypts data by using the public key of an asymmetric CMK.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Precautions</h3>
        /// <list type="bullet">
        /// <item><description>For information about the permissions that are required to call this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>This operation can be called through a shared gateway or a dedicated gateway. For more information, see <a href="https://help.aliyun.com/document_detail/601559.html">Alibaba Cloud SDK</a>.<list type="bullet">
        /// <item><description>Shared gateway: You can access KMS over the Internet or using a VPC domain name. To access KMS over the Internet, you must enable Internet access. For more information, see <a href="https://help.aliyun.com/document_detail/2856718.html">Access a key in a KMS instance over the Internet</a>.</description></item>
        /// <item><description>Dedicated gateway: You can access KMS using the private endpoint of KMS (<c>&lt;YOUR_KMS_INSTANCE_ID&gt;.cryptoservice.kms.aliyuncs.com</c>).</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <h3>QPS limits</h3>
        /// <list type="bullet">
        /// <item><description>If you use a shared gateway: The number of queries per second (QPS) for a single user is limited to 200. If the limit is exceeded, API calls are throttled. This may affect your business. We recommend that you plan your API calls to avoid exceeding this limit.</description></item>
        /// <item><description>If you use a dedicated gateway: The QPS limit for a single user depends on the computing performance specifications of your KMS instance. For more information, see <a href="https://help.aliyun.com/document_detail/480120.html">Performance metrics</a>.</description></item>
        /// </list>
        /// <h3>Description</h3>
        /// <para>This operation supports only asymmetric keys that have the <b>Usage</b> parameter set to <b>ENCRYPT/DECRYPT</b>. The following table describes the supported encryption algorithms.</para>
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
        /// <td>SM2 elliptic curve public key encryption algorithm</td>
        /// <td>6047</td>
        /// </tr>
        /// <tr>
        /// <td>In this example, the plaintext <c>SGVsbG8gd29ybGQ=</c> is encrypted using an asymmetric key with the key ID <c>key-hzz630494463ejqjx****</c>, the key version ID <c>2ab1a983-7072-4bbc-a582-584b5bd8****</c>, and the <c>RSAES_OAEP_SHA_1</c> encryption algorithm.</td>
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
        /// <para>Generates a digital signature by using an asymmetric CMK.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Precautions</h3>
        /// <list type="bullet">
        /// <item><description>For information about the access policies that are required for a RAM user or RAM role to call this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>This operation can be called through a shared gateway or a dedicated gateway. For more information, see <a href="https://help.aliyun.com/document_detail/601559.html">Alibaba Cloud SDK</a>.<list type="bullet">
        /// <item><description>Shared gateway: You can access KMS over the Internet or a VPC. This method requires you to enable Internet access. For more information, see <a href="https://help.aliyun.com/document_detail/2856718.html">Access keys in a KMS instance over the Internet</a>.</description></item>
        /// <item><description>Dedicated gateway: You can access KMS using the private endpoint of KMS (<c>&lt;YOUR_KMS_INSTANCE_ID&gt;.cryptoservice.kms.aliyuncs.com</c>).</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <h3>QPS limits</h3>
        /// <list type="bullet">
        /// <item><description>Shared gateway: This operation is limited to 200 queries per second (QPS) for each user. If the limit is exceeded, API calls are throttled, which may affect your business. We recommend that you call this operation at a reasonable rate.</description></item>
        /// <item><description>Dedicated gateway: The QPS for each user is limited by the performance specifications of your KMS instance. For more information, see <a href="https://help.aliyun.com/document_detail/480120.html">Performance metrics</a>.</description></item>
        /// </list>
        /// <h3>Description</h3>
        /// <para>This operation supports only asymmetric keys for which the <b>Usage</b> parameter is set to <b>SIGN/VERIFY</b>. The following table describes the supported signature algorithms.</para>
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
        /// <td>SM2 elliptic curve digital signature algorithm</td>
        /// </tr>
        /// </tbody></table>
        /// <remarks>
        /// <para>According to the GB/T 32918.2 standard &quot;Information security technology - SM2 elliptic curve public key cryptography - Part 2: Digital signature algorithm&quot;, when you calculate an SM2 signature, the value of the <b>Digest</b> parameter is not the SM3 hash value of the original message. Instead, the value is the SM3 hash value of the result of concatenating Z(A) and M. M is the original message to be signed. Z(A) is the hash value of user A, as defined in GB/T 32918.2.
        /// This topic provides an example of how to use an asymmetric key with the key ID <c>5c438b18-05be-40ad-b6c2-3be6752c****</c> and the key version ID <c>2ab1a983-7072-4bbc-a582-584b5bd8****</c> to sign the digest <c>ZOyIygCyaOW6GjVnihtTFtIS9PNmskdyMlNKiuy****=</c> using the <c>RSA_PSS_SHA_256</c> signature algorithm.</para>
        /// </remarks>
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
        /// <para>Generates a digital signature by using an asymmetric CMK.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Precautions</h3>
        /// <list type="bullet">
        /// <item><description>For information about the access policies that are required for a RAM user or RAM role to call this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>This operation can be called through a shared gateway or a dedicated gateway. For more information, see <a href="https://help.aliyun.com/document_detail/601559.html">Alibaba Cloud SDK</a>.<list type="bullet">
        /// <item><description>Shared gateway: You can access KMS over the Internet or a VPC. This method requires you to enable Internet access. For more information, see <a href="https://help.aliyun.com/document_detail/2856718.html">Access keys in a KMS instance over the Internet</a>.</description></item>
        /// <item><description>Dedicated gateway: You can access KMS using the private endpoint of KMS (<c>&lt;YOUR_KMS_INSTANCE_ID&gt;.cryptoservice.kms.aliyuncs.com</c>).</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <h3>QPS limits</h3>
        /// <list type="bullet">
        /// <item><description>Shared gateway: This operation is limited to 200 queries per second (QPS) for each user. If the limit is exceeded, API calls are throttled, which may affect your business. We recommend that you call this operation at a reasonable rate.</description></item>
        /// <item><description>Dedicated gateway: The QPS for each user is limited by the performance specifications of your KMS instance. For more information, see <a href="https://help.aliyun.com/document_detail/480120.html">Performance metrics</a>.</description></item>
        /// </list>
        /// <h3>Description</h3>
        /// <para>This operation supports only asymmetric keys for which the <b>Usage</b> parameter is set to <b>SIGN/VERIFY</b>. The following table describes the supported signature algorithms.</para>
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
        /// <td>SM2 elliptic curve digital signature algorithm</td>
        /// </tr>
        /// </tbody></table>
        /// <remarks>
        /// <para>According to the GB/T 32918.2 standard &quot;Information security technology - SM2 elliptic curve public key cryptography - Part 2: Digital signature algorithm&quot;, when you calculate an SM2 signature, the value of the <b>Digest</b> parameter is not the SM3 hash value of the original message. Instead, the value is the SM3 hash value of the result of concatenating Z(A) and M. M is the original message to be signed. Z(A) is the hash value of user A, as defined in GB/T 32918.2.
        /// This topic provides an example of how to use an asymmetric key with the key ID <c>5c438b18-05be-40ad-b6c2-3be6752c****</c> and the key version ID <c>2ab1a983-7072-4bbc-a582-584b5bd8****</c> to sign the digest <c>ZOyIygCyaOW6GjVnihtTFtIS9PNmskdyMlNKiuy****=</c> using the <c>RSA_PSS_SHA_256</c> signature algorithm.</para>
        /// </remarks>
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
        /// <para>Generates a digital signature by using an asymmetric CMK.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Precautions</h3>
        /// <list type="bullet">
        /// <item><description>For information about the access policies that are required for a RAM user or RAM role to call this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>This operation can be called through a shared gateway or a dedicated gateway. For more information, see <a href="https://help.aliyun.com/document_detail/601559.html">Alibaba Cloud SDK</a>.<list type="bullet">
        /// <item><description>Shared gateway: You can access KMS over the Internet or a VPC. This method requires you to enable Internet access. For more information, see <a href="https://help.aliyun.com/document_detail/2856718.html">Access keys in a KMS instance over the Internet</a>.</description></item>
        /// <item><description>Dedicated gateway: You can access KMS using the private endpoint of KMS (<c>&lt;YOUR_KMS_INSTANCE_ID&gt;.cryptoservice.kms.aliyuncs.com</c>).</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <h3>QPS limits</h3>
        /// <list type="bullet">
        /// <item><description>Shared gateway: This operation is limited to 200 queries per second (QPS) for each user. If the limit is exceeded, API calls are throttled, which may affect your business. We recommend that you call this operation at a reasonable rate.</description></item>
        /// <item><description>Dedicated gateway: The QPS for each user is limited by the performance specifications of your KMS instance. For more information, see <a href="https://help.aliyun.com/document_detail/480120.html">Performance metrics</a>.</description></item>
        /// </list>
        /// <h3>Description</h3>
        /// <para>This operation supports only asymmetric keys for which the <b>Usage</b> parameter is set to <b>SIGN/VERIFY</b>. The following table describes the supported signature algorithms.</para>
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
        /// <td>SM2 elliptic curve digital signature algorithm</td>
        /// </tr>
        /// </tbody></table>
        /// <remarks>
        /// <para>According to the GB/T 32918.2 standard &quot;Information security technology - SM2 elliptic curve public key cryptography - Part 2: Digital signature algorithm&quot;, when you calculate an SM2 signature, the value of the <b>Digest</b> parameter is not the SM3 hash value of the original message. Instead, the value is the SM3 hash value of the result of concatenating Z(A) and M. M is the original message to be signed. Z(A) is the hash value of user A, as defined in GB/T 32918.2.
        /// This topic provides an example of how to use an asymmetric key with the key ID <c>5c438b18-05be-40ad-b6c2-3be6752c****</c> and the key version ID <c>2ab1a983-7072-4bbc-a582-584b5bd8****</c> to sign the digest <c>ZOyIygCyaOW6GjVnihtTFtIS9PNmskdyMlNKiuy****=</c> using the <c>RSA_PSS_SHA_256</c> signature algorithm.</para>
        /// </remarks>
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
        /// <para>Generates a digital signature by using an asymmetric CMK.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Precautions</h3>
        /// <list type="bullet">
        /// <item><description>For information about the access policies that are required for a RAM user or RAM role to call this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>This operation can be called through a shared gateway or a dedicated gateway. For more information, see <a href="https://help.aliyun.com/document_detail/601559.html">Alibaba Cloud SDK</a>.<list type="bullet">
        /// <item><description>Shared gateway: You can access KMS over the Internet or a VPC. This method requires you to enable Internet access. For more information, see <a href="https://help.aliyun.com/document_detail/2856718.html">Access keys in a KMS instance over the Internet</a>.</description></item>
        /// <item><description>Dedicated gateway: You can access KMS using the private endpoint of KMS (<c>&lt;YOUR_KMS_INSTANCE_ID&gt;.cryptoservice.kms.aliyuncs.com</c>).</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <h3>QPS limits</h3>
        /// <list type="bullet">
        /// <item><description>Shared gateway: This operation is limited to 200 queries per second (QPS) for each user. If the limit is exceeded, API calls are throttled, which may affect your business. We recommend that you call this operation at a reasonable rate.</description></item>
        /// <item><description>Dedicated gateway: The QPS for each user is limited by the performance specifications of your KMS instance. For more information, see <a href="https://help.aliyun.com/document_detail/480120.html">Performance metrics</a>.</description></item>
        /// </list>
        /// <h3>Description</h3>
        /// <para>This operation supports only asymmetric keys for which the <b>Usage</b> parameter is set to <b>SIGN/VERIFY</b>. The following table describes the supported signature algorithms.</para>
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
        /// <td>SM2 elliptic curve digital signature algorithm</td>
        /// </tr>
        /// </tbody></table>
        /// <remarks>
        /// <para>According to the GB/T 32918.2 standard &quot;Information security technology - SM2 elliptic curve public key cryptography - Part 2: Digital signature algorithm&quot;, when you calculate an SM2 signature, the value of the <b>Digest</b> parameter is not the SM3 hash value of the original message. Instead, the value is the SM3 hash value of the result of concatenating Z(A) and M. M is the original message to be signed. Z(A) is the hash value of user A, as defined in GB/T 32918.2.
        /// This topic provides an example of how to use an asymmetric key with the key ID <c>5c438b18-05be-40ad-b6c2-3be6752c****</c> and the key version ID <c>2ab1a983-7072-4bbc-a582-584b5bd8****</c> to sign the digest <c>ZOyIygCyaOW6GjVnihtTFtIS9PNmskdyMlNKiuy****=</c> using the <c>RSA_PSS_SHA_256</c> signature algorithm.</para>
        /// </remarks>
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
        /// <para>Verifies a digital signature by using the public key of an asymmetric CMK.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Precautions</h3>
        /// <list type="bullet">
        /// <item><description>For information about the access policy required for a RAM user or RAM role to call this API operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>This operation can be called through a shared gateway or a dedicated gateway. For more information, see <a href="https://help.aliyun.com/document_detail/601559.html">Alibaba Cloud SDK</a>.<list type="bullet">
        /// <item><description>Shared gateway: You can access KMS over the Internet or through a VPC. To access KMS over the Internet, you must enable the public endpoint. For more information, see <a href="https://help.aliyun.com/document_detail/2856718.html">Access KMS instances over the Internet</a>.</description></item>
        /// <item><description>Dedicated gateway: You can access KMS using the private endpoint of KMS (<c>&lt;YOUR_KMS_INSTANCE_ID&gt;.cryptoservice.kms.aliyuncs.com</c>).</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <h3>QPS limits</h3>
        /// <list type="bullet">
        /// <item><description>If you use a shared gateway, the queries per second (QPS) limit for this operation is 200 for a single user. If you exceed this limit, API calls are throttled, which may impact your business. We recommend that you manage your call frequency to stay within the QPS limit.</description></item>
        /// <item><description>If you use a dedicated gateway, the QPS limit for this operation for a single user is determined by the computing performance specifications of your KMS instance. For more information, see <a href="https://help.aliyun.com/document_detail/480120.html">Performance metrics</a>.</description></item>
        /// </list>
        /// <h3>Description</h3>
        /// <para>This operation supports only asymmetric keys for which the <b>Usage</b> parameter is set to <b>SIGN/VERIFY</b>. The following table lists the supported signature algorithms.</para>
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
        /// <td>SM2 elliptic curve digital signature algorithm</td>
        /// </tr>
        /// </tbody></table>
        /// <remarks>
        /// <para>In accordance with the GBT32918 standard, when an SM2 signature is calculated, the value of the <b>Digest</b> parameter is not the SM3 hash value of the original message. Instead, the value is the SM3 hash value of the result generated by concatenating Z(A) and M. In this formula, M is the original message to be signed, and Z(A) is the hash value of user A as defined in GBT32918.
        /// This topic provides an example of how to use an asymmetric key with the key ID \<c>5c438b18-05be-40ad-b6c2-3be6752c\\*\\*\\*\\*\\</c> and the key version ID \<c>2ab1a983-7072-4bbc-a582-584b5bd8\\*\\*\\*\\*\\</c> to verify the signature \<c>M2CceNZH00ZgL9ED/ZHFp21YRAvYeZHknJUc207OCZ0N9wNn9As4z2bON3FF3je+1Nu+2+/8Zj50HpMTpzYpMp2R93cYmACCmhaYoKydxylbyGzJR8y9likZRCrkD38lRoS40aBBvv/6iRKzQuo9EGYVcel36cMNg00VmYNBy3pa1rwg3gA4l3cy6kjayZja1WGPkVhrVKsrJMdbpl0ApLjXKuD8rw1n1XLCwCUEL5eLPljTZaAveqdOFQOiZnZEGI27qIiZe7I1fN8tcz6anS/gTM7xRKE++5egEvRWlTQQTJeApnPSiUPA+8ZykNdelQsOQh5SrGoyI4A5pq\\*\\*\\*\\*==\\</c> for the digest \<c>ZOyIygCyaOW6GjVnihtTFtIS9PNmskdyMlNKiuyjfzw=\\</c> using the RSA_PSS_SHA_256 signature algorithm.</para>
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
        /// <para>Verifies a digital signature by using the public key of an asymmetric CMK.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Precautions</h3>
        /// <list type="bullet">
        /// <item><description>For information about the access policy required for a RAM user or RAM role to call this API operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>This operation can be called through a shared gateway or a dedicated gateway. For more information, see <a href="https://help.aliyun.com/document_detail/601559.html">Alibaba Cloud SDK</a>.<list type="bullet">
        /// <item><description>Shared gateway: You can access KMS over the Internet or through a VPC. To access KMS over the Internet, you must enable the public endpoint. For more information, see <a href="https://help.aliyun.com/document_detail/2856718.html">Access KMS instances over the Internet</a>.</description></item>
        /// <item><description>Dedicated gateway: You can access KMS using the private endpoint of KMS (<c>&lt;YOUR_KMS_INSTANCE_ID&gt;.cryptoservice.kms.aliyuncs.com</c>).</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <h3>QPS limits</h3>
        /// <list type="bullet">
        /// <item><description>If you use a shared gateway, the queries per second (QPS) limit for this operation is 200 for a single user. If you exceed this limit, API calls are throttled, which may impact your business. We recommend that you manage your call frequency to stay within the QPS limit.</description></item>
        /// <item><description>If you use a dedicated gateway, the QPS limit for this operation for a single user is determined by the computing performance specifications of your KMS instance. For more information, see <a href="https://help.aliyun.com/document_detail/480120.html">Performance metrics</a>.</description></item>
        /// </list>
        /// <h3>Description</h3>
        /// <para>This operation supports only asymmetric keys for which the <b>Usage</b> parameter is set to <b>SIGN/VERIFY</b>. The following table lists the supported signature algorithms.</para>
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
        /// <td>SM2 elliptic curve digital signature algorithm</td>
        /// </tr>
        /// </tbody></table>
        /// <remarks>
        /// <para>In accordance with the GBT32918 standard, when an SM2 signature is calculated, the value of the <b>Digest</b> parameter is not the SM3 hash value of the original message. Instead, the value is the SM3 hash value of the result generated by concatenating Z(A) and M. In this formula, M is the original message to be signed, and Z(A) is the hash value of user A as defined in GBT32918.
        /// This topic provides an example of how to use an asymmetric key with the key ID \<c>5c438b18-05be-40ad-b6c2-3be6752c\\*\\*\\*\\*\\</c> and the key version ID \<c>2ab1a983-7072-4bbc-a582-584b5bd8\\*\\*\\*\\*\\</c> to verify the signature \<c>M2CceNZH00ZgL9ED/ZHFp21YRAvYeZHknJUc207OCZ0N9wNn9As4z2bON3FF3je+1Nu+2+/8Zj50HpMTpzYpMp2R93cYmACCmhaYoKydxylbyGzJR8y9likZRCrkD38lRoS40aBBvv/6iRKzQuo9EGYVcel36cMNg00VmYNBy3pa1rwg3gA4l3cy6kjayZja1WGPkVhrVKsrJMdbpl0ApLjXKuD8rw1n1XLCwCUEL5eLPljTZaAveqdOFQOiZnZEGI27qIiZe7I1fN8tcz6anS/gTM7xRKE++5egEvRWlTQQTJeApnPSiUPA+8ZykNdelQsOQh5SrGoyI4A5pq\\*\\*\\*\\*==\\</c> for the digest \<c>ZOyIygCyaOW6GjVnihtTFtIS9PNmskdyMlNKiuyjfzw=\\</c> using the RSA_PSS_SHA_256 signature algorithm.</para>
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
        /// <para>Verifies a digital signature by using the public key of an asymmetric CMK.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Precautions</h3>
        /// <list type="bullet">
        /// <item><description>For information about the access policy required for a RAM user or RAM role to call this API operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>This operation can be called through a shared gateway or a dedicated gateway. For more information, see <a href="https://help.aliyun.com/document_detail/601559.html">Alibaba Cloud SDK</a>.<list type="bullet">
        /// <item><description>Shared gateway: You can access KMS over the Internet or through a VPC. To access KMS over the Internet, you must enable the public endpoint. For more information, see <a href="https://help.aliyun.com/document_detail/2856718.html">Access KMS instances over the Internet</a>.</description></item>
        /// <item><description>Dedicated gateway: You can access KMS using the private endpoint of KMS (<c>&lt;YOUR_KMS_INSTANCE_ID&gt;.cryptoservice.kms.aliyuncs.com</c>).</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <h3>QPS limits</h3>
        /// <list type="bullet">
        /// <item><description>If you use a shared gateway, the queries per second (QPS) limit for this operation is 200 for a single user. If you exceed this limit, API calls are throttled, which may impact your business. We recommend that you manage your call frequency to stay within the QPS limit.</description></item>
        /// <item><description>If you use a dedicated gateway, the QPS limit for this operation for a single user is determined by the computing performance specifications of your KMS instance. For more information, see <a href="https://help.aliyun.com/document_detail/480120.html">Performance metrics</a>.</description></item>
        /// </list>
        /// <h3>Description</h3>
        /// <para>This operation supports only asymmetric keys for which the <b>Usage</b> parameter is set to <b>SIGN/VERIFY</b>. The following table lists the supported signature algorithms.</para>
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
        /// <td>SM2 elliptic curve digital signature algorithm</td>
        /// </tr>
        /// </tbody></table>
        /// <remarks>
        /// <para>In accordance with the GBT32918 standard, when an SM2 signature is calculated, the value of the <b>Digest</b> parameter is not the SM3 hash value of the original message. Instead, the value is the SM3 hash value of the result generated by concatenating Z(A) and M. In this formula, M is the original message to be signed, and Z(A) is the hash value of user A as defined in GBT32918.
        /// This topic provides an example of how to use an asymmetric key with the key ID \<c>5c438b18-05be-40ad-b6c2-3be6752c\\*\\*\\*\\*\\</c> and the key version ID \<c>2ab1a983-7072-4bbc-a582-584b5bd8\\*\\*\\*\\*\\</c> to verify the signature \<c>M2CceNZH00ZgL9ED/ZHFp21YRAvYeZHknJUc207OCZ0N9wNn9As4z2bON3FF3je+1Nu+2+/8Zj50HpMTpzYpMp2R93cYmACCmhaYoKydxylbyGzJR8y9likZRCrkD38lRoS40aBBvv/6iRKzQuo9EGYVcel36cMNg00VmYNBy3pa1rwg3gA4l3cy6kjayZja1WGPkVhrVKsrJMdbpl0ApLjXKuD8rw1n1XLCwCUEL5eLPljTZaAveqdOFQOiZnZEGI27qIiZe7I1fN8tcz6anS/gTM7xRKE++5egEvRWlTQQTJeApnPSiUPA+8ZykNdelQsOQh5SrGoyI4A5pq\\*\\*\\*\\*==\\</c> for the digest \<c>ZOyIygCyaOW6GjVnihtTFtIS9PNmskdyMlNKiuyjfzw=\\</c> using the RSA_PSS_SHA_256 signature algorithm.</para>
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
        /// <para>Verifies a digital signature by using the public key of an asymmetric CMK.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Precautions</h3>
        /// <list type="bullet">
        /// <item><description>For information about the access policy required for a RAM user or RAM role to call this API operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>This operation can be called through a shared gateway or a dedicated gateway. For more information, see <a href="https://help.aliyun.com/document_detail/601559.html">Alibaba Cloud SDK</a>.<list type="bullet">
        /// <item><description>Shared gateway: You can access KMS over the Internet or through a VPC. To access KMS over the Internet, you must enable the public endpoint. For more information, see <a href="https://help.aliyun.com/document_detail/2856718.html">Access KMS instances over the Internet</a>.</description></item>
        /// <item><description>Dedicated gateway: You can access KMS using the private endpoint of KMS (<c>&lt;YOUR_KMS_INSTANCE_ID&gt;.cryptoservice.kms.aliyuncs.com</c>).</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <h3>QPS limits</h3>
        /// <list type="bullet">
        /// <item><description>If you use a shared gateway, the queries per second (QPS) limit for this operation is 200 for a single user. If you exceed this limit, API calls are throttled, which may impact your business. We recommend that you manage your call frequency to stay within the QPS limit.</description></item>
        /// <item><description>If you use a dedicated gateway, the QPS limit for this operation for a single user is determined by the computing performance specifications of your KMS instance. For more information, see <a href="https://help.aliyun.com/document_detail/480120.html">Performance metrics</a>.</description></item>
        /// </list>
        /// <h3>Description</h3>
        /// <para>This operation supports only asymmetric keys for which the <b>Usage</b> parameter is set to <b>SIGN/VERIFY</b>. The following table lists the supported signature algorithms.</para>
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
        /// <td>SM2 elliptic curve digital signature algorithm</td>
        /// </tr>
        /// </tbody></table>
        /// <remarks>
        /// <para>In accordance with the GBT32918 standard, when an SM2 signature is calculated, the value of the <b>Digest</b> parameter is not the SM3 hash value of the original message. Instead, the value is the SM3 hash value of the result generated by concatenating Z(A) and M. In this formula, M is the original message to be signed, and Z(A) is the hash value of user A as defined in GBT32918.
        /// This topic provides an example of how to use an asymmetric key with the key ID \<c>5c438b18-05be-40ad-b6c2-3be6752c\\*\\*\\*\\*\\</c> and the key version ID \<c>2ab1a983-7072-4bbc-a582-584b5bd8\\*\\*\\*\\*\\</c> to verify the signature \<c>M2CceNZH00ZgL9ED/ZHFp21YRAvYeZHknJUc207OCZ0N9wNn9As4z2bON3FF3je+1Nu+2+/8Zj50HpMTpzYpMp2R93cYmACCmhaYoKydxylbyGzJR8y9likZRCrkD38lRoS40aBBvv/6iRKzQuo9EGYVcel36cMNg00VmYNBy3pa1rwg3gA4l3cy6kjayZja1WGPkVhrVKsrJMdbpl0ApLjXKuD8rw1n1XLCwCUEL5eLPljTZaAveqdOFQOiZnZEGI27qIiZe7I1fN8tcz6anS/gTM7xRKE++5egEvRWlTQQTJeApnPSiUPA+8ZykNdelQsOQh5SrGoyI4A5pq\\*\\*\\*\\*==\\</c> for the digest \<c>ZOyIygCyaOW6GjVnihtTFtIS9PNmskdyMlNKiuyjfzw=\\</c> using the RSA_PSS_SHA_256 signature algorithm.</para>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels the deletion task of a CMK.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels the deletion task of a CMK.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels the deletion task of a CMK.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels the deletion task of a CMK.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an alias for a key.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an alias for a key.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an alias for a key.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an alias for a key.</para>
        /// </summary>
        /// 
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
        /// <para>Creates a customer master key (CMK) for envelope encryption, digital signatures, or other cryptographic operations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For information about the access policies required for a RAM user or RAM role to call this OpenAPI operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>Alibaba Cloud Key Management Service (KMS) supports common specifications for symmetric and asymmetric keys. For more information, see <a href="https://help.aliyun.com/document_detail/480161.html">Key management types and key specifications</a>.</description></item>
        /// </list>
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
        /// <para>Creates a customer master key (CMK) for envelope encryption, digital signatures, or other cryptographic operations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For information about the access policies required for a RAM user or RAM role to call this OpenAPI operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>Alibaba Cloud Key Management Service (KMS) supports common specifications for symmetric and asymmetric keys. For more information, see <a href="https://help.aliyun.com/document_detail/480161.html">Key management types and key specifications</a>.</description></item>
        /// </list>
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
        /// <para>Creates a customer master key (CMK) for envelope encryption, digital signatures, or other cryptographic operations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For information about the access policies required for a RAM user or RAM role to call this OpenAPI operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>Alibaba Cloud Key Management Service (KMS) supports common specifications for symmetric and asymmetric keys. For more information, see <a href="https://help.aliyun.com/document_detail/480161.html">Key management types and key specifications</a>.</description></item>
        /// </list>
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
        /// <para>Creates a customer master key (CMK) for envelope encryption, digital signatures, or other cryptographic operations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For information about the access policies required for a RAM user or RAM role to call this OpenAPI operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>Alibaba Cloud Key Management Service (KMS) supports common specifications for symmetric and asymmetric keys. For more information, see <a href="https://help.aliyun.com/document_detail/480161.html">Key management types and key specifications</a>.</description></item>
        /// </list>
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
        /// <para>Creates a version for a customer master key (CMK).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>You can create a version only for an asymmetric CMK that is in the Enabled state. You can call the <a href="https://help.aliyun.com/document_detail/28947.html">CreateKey</a> operation to create an asymmetric CMK and the <a href="https://help.aliyun.com/document_detail/28952.html">DescribeKey</a> operation to query the status of the CMK. The status is specified by the KeyState parameter.</description></item>
        /// <item><description>The minimum interval for creating a version of the same CMK is seven days. You can call the <a href="https://help.aliyun.com/document_detail/28952.html">DescribeKey</a> operation to query the time when the last version of a CMK was created. The time is specified by the LastRotationDate parameter.</description></item>
        /// <item><description>If a CMK is in a private key store, you cannot create a version for the CMK.</description></item>
        /// <item><description>You can create a maximum of 50 versions for a CMK in the same region.
        /// You can create a version for the CMK whose ID is <c>0b30658a-ed1a-4922-b8f7-a673ca9c****</c> by using the parameter settings provided in this topic.
        /// For more information about the access policy required by a RAM user or RAM role to call this API, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
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
        /// <para>Creates a version for a customer master key (CMK).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>You can create a version only for an asymmetric CMK that is in the Enabled state. You can call the <a href="https://help.aliyun.com/document_detail/28947.html">CreateKey</a> operation to create an asymmetric CMK and the <a href="https://help.aliyun.com/document_detail/28952.html">DescribeKey</a> operation to query the status of the CMK. The status is specified by the KeyState parameter.</description></item>
        /// <item><description>The minimum interval for creating a version of the same CMK is seven days. You can call the <a href="https://help.aliyun.com/document_detail/28952.html">DescribeKey</a> operation to query the time when the last version of a CMK was created. The time is specified by the LastRotationDate parameter.</description></item>
        /// <item><description>If a CMK is in a private key store, you cannot create a version for the CMK.</description></item>
        /// <item><description>You can create a maximum of 50 versions for a CMK in the same region.
        /// You can create a version for the CMK whose ID is <c>0b30658a-ed1a-4922-b8f7-a673ca9c****</c> by using the parameter settings provided in this topic.
        /// For more information about the access policy required by a RAM user or RAM role to call this API, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
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
        /// <para>Creates a version for a customer master key (CMK).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>You can create a version only for an asymmetric CMK that is in the Enabled state. You can call the <a href="https://help.aliyun.com/document_detail/28947.html">CreateKey</a> operation to create an asymmetric CMK and the <a href="https://help.aliyun.com/document_detail/28952.html">DescribeKey</a> operation to query the status of the CMK. The status is specified by the KeyState parameter.</description></item>
        /// <item><description>The minimum interval for creating a version of the same CMK is seven days. You can call the <a href="https://help.aliyun.com/document_detail/28952.html">DescribeKey</a> operation to query the time when the last version of a CMK was created. The time is specified by the LastRotationDate parameter.</description></item>
        /// <item><description>If a CMK is in a private key store, you cannot create a version for the CMK.</description></item>
        /// <item><description>You can create a maximum of 50 versions for a CMK in the same region.
        /// You can create a version for the CMK whose ID is <c>0b30658a-ed1a-4922-b8f7-a673ca9c****</c> by using the parameter settings provided in this topic.
        /// For more information about the access policy required by a RAM user or RAM role to call this API, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
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
        /// <para>Creates a version for a customer master key (CMK).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>You can create a version only for an asymmetric CMK that is in the Enabled state. You can call the <a href="https://help.aliyun.com/document_detail/28947.html">CreateKey</a> operation to create an asymmetric CMK and the <a href="https://help.aliyun.com/document_detail/28952.html">DescribeKey</a> operation to query the status of the CMK. The status is specified by the KeyState parameter.</description></item>
        /// <item><description>The minimum interval for creating a version of the same CMK is seven days. You can call the <a href="https://help.aliyun.com/document_detail/28952.html">DescribeKey</a> operation to query the time when the last version of a CMK was created. The time is specified by the LastRotationDate parameter.</description></item>
        /// <item><description>If a CMK is in a private key store, you cannot create a version for the CMK.</description></item>
        /// <item><description>You can create a maximum of 50 versions for a CMK in the same region.
        /// You can create a version for the CMK whose ID is <c>0b30658a-ed1a-4922-b8f7-a673ca9c****</c> by using the parameter settings provided in this topic.
        /// For more information about the access policy required by a RAM user or RAM role to call this API, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
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
        /// <para>Creates a network access rule to configure the private IP addresses or private CIDR blocks that are allowed to access a Key Management Service (KMS) instance.</para>
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
        /// <para>Creates a network access rule to configure the private IP addresses or private CIDR blocks that are allowed to access a Key Management Service (KMS) instance.</para>
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
        /// <para>Creates a network access rule to configure the private IP addresses or private CIDR blocks that are allowed to access a Key Management Service (KMS) instance.</para>
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
        /// <para>Creates a network access rule to configure the private IP addresses or private CIDR blocks that are allowed to access a Key Management Service (KMS) instance.</para>
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
        /// <para>Creates a secret and stores its initial version.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For information about the access policy required for a Resource Access Management (RAM) user or RAM role to call this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>Specify the secret name, the secret value for the initial version, and the version number. The initial version is marked with the ACSCurrent stage label.</description></item>
        /// <item><description>Key Management Service (KMS) uses the key that you specify to encrypt the secret value. The key and the secret must be in the same KMS instance. The key must be a symmetric key.<remarks>
        /// <para>KMS encrypts the secret value of each version. Metadata such as the secret name, version number, and version stage labels are not encrypted.</para>
        /// </remarks>
        /// </description></item>
        /// <item><description>Before you encrypt the secret value, you must have the <c>kms:GenerateDataKey</c> permission on the key.
        /// This topic provides an example of how to create an RDS secret. The secret is named <c>mydbconninfo</c>. The <c>VersionId</c> of the initial version is <c>v1</c>. The <c>SecretData</c> is <c>{&quot;Accounts&quot;:[{&quot;AccountName&quot;:&quot;user1&quot;,&quot;AccountPassword&quot;:&quot;****&quot;}]}</c>.</description></item>
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
        /// <para>Creates a secret and stores its initial version.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For information about the access policy required for a Resource Access Management (RAM) user or RAM role to call this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>Specify the secret name, the secret value for the initial version, and the version number. The initial version is marked with the ACSCurrent stage label.</description></item>
        /// <item><description>Key Management Service (KMS) uses the key that you specify to encrypt the secret value. The key and the secret must be in the same KMS instance. The key must be a symmetric key.<remarks>
        /// <para>KMS encrypts the secret value of each version. Metadata such as the secret name, version number, and version stage labels are not encrypted.</para>
        /// </remarks>
        /// </description></item>
        /// <item><description>Before you encrypt the secret value, you must have the <c>kms:GenerateDataKey</c> permission on the key.
        /// This topic provides an example of how to create an RDS secret. The secret is named <c>mydbconninfo</c>. The <c>VersionId</c> of the initial version is <c>v1</c>. The <c>SecretData</c> is <c>{&quot;Accounts&quot;:[{&quot;AccountName&quot;:&quot;user1&quot;,&quot;AccountPassword&quot;:&quot;****&quot;}]}</c>.</description></item>
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
        /// <para>Creates a secret and stores its initial version.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For information about the access policy required for a Resource Access Management (RAM) user or RAM role to call this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>Specify the secret name, the secret value for the initial version, and the version number. The initial version is marked with the ACSCurrent stage label.</description></item>
        /// <item><description>Key Management Service (KMS) uses the key that you specify to encrypt the secret value. The key and the secret must be in the same KMS instance. The key must be a symmetric key.<remarks>
        /// <para>KMS encrypts the secret value of each version. Metadata such as the secret name, version number, and version stage labels are not encrypted.</para>
        /// </remarks>
        /// </description></item>
        /// <item><description>Before you encrypt the secret value, you must have the <c>kms:GenerateDataKey</c> permission on the key.
        /// This topic provides an example of how to create an RDS secret. The secret is named <c>mydbconninfo</c>. The <c>VersionId</c> of the initial version is <c>v1</c>. The <c>SecretData</c> is <c>{&quot;Accounts&quot;:[{&quot;AccountName&quot;:&quot;user1&quot;,&quot;AccountPassword&quot;:&quot;****&quot;}]}</c>.</description></item>
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
        /// <para>Creates a secret and stores its initial version.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For information about the access policy required for a Resource Access Management (RAM) user or RAM role to call this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>Specify the secret name, the secret value for the initial version, and the version number. The initial version is marked with the ACSCurrent stage label.</description></item>
        /// <item><description>Key Management Service (KMS) uses the key that you specify to encrypt the secret value. The key and the secret must be in the same KMS instance. The key must be a symmetric key.<remarks>
        /// <para>KMS encrypts the secret value of each version. Metadata such as the secret name, version number, and version stage labels are not encrypted.</para>
        /// </remarks>
        /// </description></item>
        /// <item><description>Before you encrypt the secret value, you must have the <c>kms:GenerateDataKey</c> permission on the key.
        /// This topic provides an example of how to create an RDS secret. The secret is named <c>mydbconninfo</c>. The <c>VersionId</c> of the initial version is <c>v1</c>. The <c>SecretData</c> is <c>{&quot;Accounts&quot;:[{&quot;AccountName&quot;:&quot;user1&quot;,&quot;AccountPassword&quot;:&quot;****&quot;}]}</c>.</description></item>
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
        /// <para>Decrypts ciphertext that was encrypted by using a CMK.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Precautions</h3>
        /// <list type="bullet">
        /// <item><description>For information about the access policy required for a RAM user or RAM role to call this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>This operation can be called through a shared gateway or a dedicated gateway. For more information, see <a href="https://help.aliyun.com/document_detail/601559.html">Alibaba Cloud SDK</a>.<list type="bullet">
        /// <item><description>Shared gateway: You can access KMS over the Internet or using a VPC domain name. To use a shared gateway, you must enable Internet access. For more information, see <a href="https://help.aliyun.com/document_detail/2856718.html">Access keys in a KMS instance over the Internet</a>.</description></item>
        /// <item><description>Dedicated gateway: You can access KMS using the private endpoint of KMS (<c>&lt;YOUR_KMS_INSTANCE_ID&gt;.cryptoservice.kms.aliyuncs.com</c>).</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <h3>QPS limits</h3>
        /// <list type="bullet">
        /// <item><description>Shared gateway: The queries per second (QPS) limit for a single user for this operation is 1,000. If this limit is exceeded, API calls are throttled, which may affect your business. We recommend that you plan your calls accordingly.</description></item>
        /// <item><description>Dedicated gateway: The QPS limit for a single user for this operation is subject to the performance specifications of your KMS instance. For more information, see <a href="https://help.aliyun.com/document_detail/480120.html">Performance metrics</a>.</description></item>
        /// </list>
        /// </description>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Recipient))
            {
                query["Recipient"] = request.Recipient;
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
        /// <para>Decrypts ciphertext that was encrypted by using a CMK.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Precautions</h3>
        /// <list type="bullet">
        /// <item><description>For information about the access policy required for a RAM user or RAM role to call this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>This operation can be called through a shared gateway or a dedicated gateway. For more information, see <a href="https://help.aliyun.com/document_detail/601559.html">Alibaba Cloud SDK</a>.<list type="bullet">
        /// <item><description>Shared gateway: You can access KMS over the Internet or using a VPC domain name. To use a shared gateway, you must enable Internet access. For more information, see <a href="https://help.aliyun.com/document_detail/2856718.html">Access keys in a KMS instance over the Internet</a>.</description></item>
        /// <item><description>Dedicated gateway: You can access KMS using the private endpoint of KMS (<c>&lt;YOUR_KMS_INSTANCE_ID&gt;.cryptoservice.kms.aliyuncs.com</c>).</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <h3>QPS limits</h3>
        /// <list type="bullet">
        /// <item><description>Shared gateway: The queries per second (QPS) limit for a single user for this operation is 1,000. If this limit is exceeded, API calls are throttled, which may affect your business. We recommend that you plan your calls accordingly.</description></item>
        /// <item><description>Dedicated gateway: The QPS limit for a single user for this operation is subject to the performance specifications of your KMS instance. For more information, see <a href="https://help.aliyun.com/document_detail/480120.html">Performance metrics</a>.</description></item>
        /// </list>
        /// </description>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Recipient))
            {
                query["Recipient"] = request.Recipient;
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
        /// <para>Decrypts ciphertext that was encrypted by using a CMK.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Precautions</h3>
        /// <list type="bullet">
        /// <item><description>For information about the access policy required for a RAM user or RAM role to call this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>This operation can be called through a shared gateway or a dedicated gateway. For more information, see <a href="https://help.aliyun.com/document_detail/601559.html">Alibaba Cloud SDK</a>.<list type="bullet">
        /// <item><description>Shared gateway: You can access KMS over the Internet or using a VPC domain name. To use a shared gateway, you must enable Internet access. For more information, see <a href="https://help.aliyun.com/document_detail/2856718.html">Access keys in a KMS instance over the Internet</a>.</description></item>
        /// <item><description>Dedicated gateway: You can access KMS using the private endpoint of KMS (<c>&lt;YOUR_KMS_INSTANCE_ID&gt;.cryptoservice.kms.aliyuncs.com</c>).</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <h3>QPS limits</h3>
        /// <list type="bullet">
        /// <item><description>Shared gateway: The queries per second (QPS) limit for a single user for this operation is 1,000. If this limit is exceeded, API calls are throttled, which may affect your business. We recommend that you plan your calls accordingly.</description></item>
        /// <item><description>Dedicated gateway: The QPS limit for a single user for this operation is subject to the performance specifications of your KMS instance. For more information, see <a href="https://help.aliyun.com/document_detail/480120.html">Performance metrics</a>.</description></item>
        /// </list>
        /// </description>
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
        /// <para>Decrypts ciphertext that was encrypted by using a CMK.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Precautions</h3>
        /// <list type="bullet">
        /// <item><description>For information about the access policy required for a RAM user or RAM role to call this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>This operation can be called through a shared gateway or a dedicated gateway. For more information, see <a href="https://help.aliyun.com/document_detail/601559.html">Alibaba Cloud SDK</a>.<list type="bullet">
        /// <item><description>Shared gateway: You can access KMS over the Internet or using a VPC domain name. To use a shared gateway, you must enable Internet access. For more information, see <a href="https://help.aliyun.com/document_detail/2856718.html">Access keys in a KMS instance over the Internet</a>.</description></item>
        /// <item><description>Dedicated gateway: You can access KMS using the private endpoint of KMS (<c>&lt;YOUR_KMS_INSTANCE_ID&gt;.cryptoservice.kms.aliyuncs.com</c>).</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <h3>QPS limits</h3>
        /// <list type="bullet">
        /// <item><description>Shared gateway: The queries per second (QPS) limit for a single user for this operation is 1,000. If this limit is exceeded, API calls are throttled, which may affect your business. We recommend that you plan your calls accordingly.</description></item>
        /// <item><description>Dedicated gateway: The QPS limit for a single user for this operation is subject to the performance specifications of your KMS instance. For more information, see <a href="https://help.aliyun.com/document_detail/480120.html">Performance metrics</a>.</description></item>
        /// </list>
        /// </description>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an alias.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an alias.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an alias.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an alias.</para>
        /// </summary>
        /// 
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
        /// <list type="bullet">
        /// <item><description>For information about the access policy that a RAM user or RAM role requires to call this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>Before you delete an AAP, make sure that it is no longer in use. If you delete an AAP that is in use, related applications cannot access KMS. Proceed with caution.</description></item>
        /// </list>
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
        /// <list type="bullet">
        /// <item><description>For information about the access policy that a RAM user or RAM role requires to call this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>Before you delete an AAP, make sure that it is no longer in use. If you delete an AAP that is in use, related applications cannot access KMS. Proceed with caution.</description></item>
        /// </list>
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
        /// <list type="bullet">
        /// <item><description>For information about the access policy that a RAM user or RAM role requires to call this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>Before you delete an AAP, make sure that it is no longer in use. If you delete an AAP that is in use, related applications cannot access KMS. Proceed with caution.</description></item>
        /// </list>
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
        /// <list type="bullet">
        /// <item><description>For information about the access policy that a RAM user or RAM role requires to call this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>Before you delete an AAP, make sure that it is no longer in use. If you delete an AAP that is in use, related applications cannot access KMS. Proceed with caution.</description></item>
        /// </list>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a client key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For information about the access policy required for a RAM user or RAM role to call this API operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>Before you delete a ClientKey, make sure that it is no longer in use. Deleting a ClientKey that is in use prevents related applications from accessing KMS. Proceed with caution.</description></item>
        /// </list>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a client key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For information about the access policy required for a RAM user or RAM role to call this API operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>Before you delete a ClientKey, make sure that it is no longer in use. Deleting a ClientKey that is in use prevents related applications from accessing KMS. Proceed with caution.</description></item>
        /// </list>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a client key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For information about the access policy required for a RAM user or RAM role to call this API operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>Before you delete a ClientKey, make sure that it is no longer in use. Deleting a ClientKey that is in use prevents related applications from accessing KMS. Proceed with caution.</description></item>
        /// </list>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a client key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For information about the access policy required for a RAM user or RAM role to call this API operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>Before you delete a ClientKey, make sure that it is no longer in use. Deleting a ClientKey that is in use prevents related applications from accessing KMS. Proceed with caution.</description></item>
        /// </list>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the imported key material from a CMK. After deletion, the CMK enters the PendingImport state until you re-import key material.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation does not delete the CMK that is created by using the key material.
        /// If the CMK is in the PendingDeletion state, the state of the CMK and the scheduled deletion time do not change after you call this operation. If the CMK is not in the PendingDeletion state, the state of the CMK changes to PendingImport after you call this operation.
        /// After you delete the key material, you can upload only the same key material into the CMK.
        /// For more information about the access policy required by a RAM user or RAM role to call this API, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the imported key material from a CMK. After deletion, the CMK enters the PendingImport state until you re-import key material.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation does not delete the CMK that is created by using the key material.
        /// If the CMK is in the PendingDeletion state, the state of the CMK and the scheduled deletion time do not change after you call this operation. If the CMK is not in the PendingDeletion state, the state of the CMK changes to PendingImport after you call this operation.
        /// After you delete the key material, you can upload only the same key material into the CMK.
        /// For more information about the access policy required by a RAM user or RAM role to call this API, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the imported key material from a CMK. After deletion, the CMK enters the PendingImport state until you re-import key material.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation does not delete the CMK that is created by using the key material.
        /// If the CMK is in the PendingDeletion state, the state of the CMK and the scheduled deletion time do not change after you call this operation. If the CMK is not in the PendingDeletion state, the state of the CMK changes to PendingImport after you call this operation.
        /// After you delete the key material, you can upload only the same key material into the CMK.
        /// For more information about the access policy required by a RAM user or RAM role to call this API, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the imported key material from a CMK. After deletion, the CMK enters the PendingImport state until you re-import key material.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation does not delete the CMK that is created by using the key material.
        /// If the CMK is in the PendingDeletion state, the state of the CMK and the scheduled deletion time do not change after you call this operation. If the CMK is not in the PendingDeletion state, the state of the CMK changes to PendingImport after you call this operation.
        /// After you delete the key material, you can upload only the same key material into the CMK.
        /// For more information about the access policy required by a RAM user or RAM role to call this API, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
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
        /// <list type="bullet">
        /// <item><description>For information about the access policy that is required to call this OpenAPI as a Resource Access Management (RAM) user or RAM role, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>Before deleting the network control rule, ensure that it is not attached to any access policies. Otherwise, related applications cannot access KMS as expected.</description></item>
        /// </list>
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
        /// <list type="bullet">
        /// <item><description>For information about the access policy that is required to call this OpenAPI as a Resource Access Management (RAM) user or RAM role, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>Before deleting the network control rule, ensure that it is not attached to any access policies. Otherwise, related applications cannot access KMS as expected.</description></item>
        /// </list>
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
        /// <list type="bullet">
        /// <item><description>For information about the access policy that is required to call this OpenAPI as a Resource Access Management (RAM) user or RAM role, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>Before deleting the network control rule, ensure that it is not attached to any access policies. Otherwise, related applications cannot access KMS as expected.</description></item>
        /// </list>
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
        /// <list type="bullet">
        /// <item><description>For information about the access policy that is required to call this OpenAPI as a Resource Access Management (RAM) user or RAM role, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>Before deleting the network control rule, ensure that it is not attached to any access policies. Otherwise, related applications cannot access KMS as expected.</description></item>
        /// </list>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a secret.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a secret.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a secret.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a secret.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of Key Management Service (KMS) within your Alibaba Cloud account.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For more information about the access policy required by a RAM user or RAM role to call this API, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
        /// </description>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of Key Management Service (KMS) within your Alibaba Cloud account.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For more information about the access policy required by a RAM user or RAM role to call this API, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
        /// </description>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of Key Management Service (KMS) within your Alibaba Cloud account.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For more information about the access policy required by a RAM user or RAM role to call this API, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
        /// </description>
        /// 
        /// <returns>
        /// DescribeAccountKmsStatusResponse
        /// </returns>
        public DescribeAccountKmsStatusResponse DescribeAccountKmsStatus()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAccountKmsStatusWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of Key Management Service (KMS) within your Alibaba Cloud account.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For more information about the access policy required by a RAM user or RAM role to call this API, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
        /// </description>
        /// 
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
        /// <para>Retrieves the details of an application access point (AAP).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For information about the access policy that a Resource Access Management (RAM) user or RAM role must have to call this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
        /// </description>
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
        /// <para>Retrieves the details of an application access point (AAP).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For information about the access policy that a Resource Access Management (RAM) user or RAM role must have to call this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
        /// </description>
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
        /// <para>Retrieves the details of an application access point (AAP).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For information about the access policy that a Resource Access Management (RAM) user or RAM role must have to call this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
        /// </description>
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
        /// <para>Retrieves the details of an application access point (AAP).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For information about the access policy that a Resource Access Management (RAM) user or RAM role must have to call this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
        /// </description>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the metadata of a CMK, such as the key state, usage, and rotation configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can query the information about the CMK <c>05754286-3ba2-4fa6-8d41-4323aca6****</c> by using parameter settings provided in this topic. The information includes the creator, creation time, status, and deletion protection status of the CMK.
        /// For more information about the access policy required by a RAM user or RAM role to call this API, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
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
        /// <para>Queries the metadata of a CMK, such as the key state, usage, and rotation configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can query the information about the CMK <c>05754286-3ba2-4fa6-8d41-4323aca6****</c> by using parameter settings provided in this topic. The information includes the creator, creation time, status, and deletion protection status of the CMK.
        /// For more information about the access policy required by a RAM user or RAM role to call this API, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
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
        /// <para>Queries the metadata of a CMK, such as the key state, usage, and rotation configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can query the information about the CMK <c>05754286-3ba2-4fa6-8d41-4323aca6****</c> by using parameter settings provided in this topic. The information includes the creator, creation time, status, and deletion protection status of the CMK.
        /// For more information about the access policy required by a RAM user or RAM role to call this API, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
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
        /// <para>Queries the metadata of a CMK, such as the key state, usage, and rotation configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can query the information about the CMK <c>05754286-3ba2-4fa6-8d41-4323aca6****</c> by using parameter settings provided in this topic. The information includes the creator, creation time, status, and deletion protection status of the CMK.
        /// For more information about the access policy required by a RAM user or RAM role to call this API, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the metadata of a specific CMK version.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the information about a version of the CMK <c>1234abcd-12ab-34cd-56ef-12345678****</c>. The ID of the CMK version is <c>2ab1a983-7072-4bbc-a582-584b5bd8****</c>. The response shows that the creation time of the CMK version is <c>2016-03-25T10:42:40Z</c>.
        /// For more information about the access policy required by a RAM user or RAM role to call this API, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the metadata of a specific CMK version.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the information about a version of the CMK <c>1234abcd-12ab-34cd-56ef-12345678****</c>. The ID of the CMK version is <c>2ab1a983-7072-4bbc-a582-584b5bd8****</c>. The response shows that the creation time of the CMK version is <c>2016-03-25T10:42:40Z</c>.
        /// For more information about the access policy required by a RAM user or RAM role to call this API, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the metadata of a specific CMK version.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the information about a version of the CMK <c>1234abcd-12ab-34cd-56ef-12345678****</c>. The ID of the CMK version is <c>2ab1a983-7072-4bbc-a582-584b5bd8****</c>. The response shows that the creation time of the CMK version is <c>2016-03-25T10:42:40Z</c>.
        /// For more information about the access policy required by a RAM user or RAM role to call this API, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the metadata of a specific CMK version.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to query the information about a version of the CMK <c>1234abcd-12ab-34cd-56ef-12345678****</c>. The ID of the CMK version is <c>2ab1a983-7072-4bbc-a582-584b5bd8****</c>. The response shows that the creation time of the CMK version is <c>2016-03-25T10:42:40Z</c>.
        /// For more information about the access policy required by a RAM user or RAM role to call this API, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
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
        /// <para>Retrieves the details of a network access rule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For information about the required access policy for a Resource Access Management (RAM) user or RAM role to call this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
        /// </description>
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
        /// <para>Retrieves the details of a network access rule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For information about the required access policy for a Resource Access Management (RAM) user or RAM role to call this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
        /// </description>
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
        /// <para>Retrieves the details of a network access rule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For information about the required access policy for a Resource Access Management (RAM) user or RAM role to call this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
        /// </description>
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
        /// <para>Retrieves the details of a network access rule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For information about the required access policy for a Resource Access Management (RAM) user or RAM role to call this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
        /// </description>
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
        /// <para>Retrieves the details of a permission policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For more information about the access policy required by a RAM user or RAM role to call this API, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
        /// </description>
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
        /// <para>Retrieves the details of a permission policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For more information about the access policy required by a RAM user or RAM role to call this API, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
        /// </description>
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
        /// <para>Retrieves the details of a permission policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For more information about the access policy required by a RAM user or RAM role to call this API, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
        /// </description>
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
        /// <para>Retrieves the details of a permission policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For more information about the access policy required by a RAM user or RAM role to call this API, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
        /// </description>
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
        /// <para>Queries the regions where KMS is available.</para>
        /// </summary>
        /// 
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
        /// <para>Queries the regions where KMS is available.</para>
        /// </summary>
        /// 
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
        /// <para>Queries the regions where KMS is available.</para>
        /// </summary>
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
        /// <para>Queries the regions where KMS is available.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DescribeRegionsResponse
        /// </returns>
        public async Task<DescribeRegionsResponse> DescribeRegionsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRegionsWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the metadata of a secret.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the metadata of a secret.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the metadata of a secret.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the metadata of a secret.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables a key.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables a key.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables a key.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables a key.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables a key to encrypt and decrypt data.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables a key to encrypt and decrypt data.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables a key to encrypt and decrypt data.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables a key to encrypt and decrypt data.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Encrypts plaintext by using a symmetric CMK.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Precautions</h3>
        /// <list type="bullet">
        /// <item><description>For information about the access policy required to allow a RAM user or RAM role to use this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>This operation is accessible through a shared gateway or a dedicated gateway. For more information, see <a href="https://help.aliyun.com/document_detail/601559.html">Alibaba Cloud SDK</a>.<list type="bullet">
        /// <item><description>Shared gateway: You can access KMS over the Internet or a VPC. To use this method, you must enable Internet access. For more information, see <a href="https://help.aliyun.com/document_detail/2856718.html">Access keys in a KMS instance over the Internet</a>.</description></item>
        /// <item><description>Dedicated gateway: You can access KMS using the private endpoint of KMS (<c>&lt;YOUR_KMS_INSTANCE_ID&gt;.cryptoservice.kms.aliyuncs.com</c>).</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <h3>QPS limits</h3>
        /// <list type="bullet">
        /// <item><description>When accessed through a shared gateway, the queries per second (QPS) limit for a single user is 1,000. If the limit is exceeded, requests are throttled, which can affect your business. We recommend that you stay within this limit to avoid throttling.</description></item>
        /// <item><description>When accessed through a dedicated gateway, the QPS limit for a single user is subject to the computing performance specifications of your KMS instance. For more information, see <a href="https://help.aliyun.com/document_detail/480120.html">Performance metrics</a>.</description></item>
        /// </list>
        /// <h3>Description</h3>
        /// <list type="bullet">
        /// <item><description>KMS encrypts the specified data using the primary version of a specified key.</description></item>
        /// <item><description>You can encrypt a maximum of 6 KB of data, such as an RSA key, a database password, or other sensitive information.</description></item>
        /// <item><description>If you migrate encrypted data from one region to another, you can call the Encrypt operation in the destination region to re-encrypt the plaintext data key from the source region. This generates a new encrypted data key. You can then call the <a href="https://help.aliyun.com/document_detail/28950.html">Decrypt</a> operation to decrypt this new key in the destination region.</description></item>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Encrypts plaintext by using a symmetric CMK.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Precautions</h3>
        /// <list type="bullet">
        /// <item><description>For information about the access policy required to allow a RAM user or RAM role to use this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>This operation is accessible through a shared gateway or a dedicated gateway. For more information, see <a href="https://help.aliyun.com/document_detail/601559.html">Alibaba Cloud SDK</a>.<list type="bullet">
        /// <item><description>Shared gateway: You can access KMS over the Internet or a VPC. To use this method, you must enable Internet access. For more information, see <a href="https://help.aliyun.com/document_detail/2856718.html">Access keys in a KMS instance over the Internet</a>.</description></item>
        /// <item><description>Dedicated gateway: You can access KMS using the private endpoint of KMS (<c>&lt;YOUR_KMS_INSTANCE_ID&gt;.cryptoservice.kms.aliyuncs.com</c>).</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <h3>QPS limits</h3>
        /// <list type="bullet">
        /// <item><description>When accessed through a shared gateway, the queries per second (QPS) limit for a single user is 1,000. If the limit is exceeded, requests are throttled, which can affect your business. We recommend that you stay within this limit to avoid throttling.</description></item>
        /// <item><description>When accessed through a dedicated gateway, the QPS limit for a single user is subject to the computing performance specifications of your KMS instance. For more information, see <a href="https://help.aliyun.com/document_detail/480120.html">Performance metrics</a>.</description></item>
        /// </list>
        /// <h3>Description</h3>
        /// <list type="bullet">
        /// <item><description>KMS encrypts the specified data using the primary version of a specified key.</description></item>
        /// <item><description>You can encrypt a maximum of 6 KB of data, such as an RSA key, a database password, or other sensitive information.</description></item>
        /// <item><description>If you migrate encrypted data from one region to another, you can call the Encrypt operation in the destination region to re-encrypt the plaintext data key from the source region. This generates a new encrypted data key. You can then call the <a href="https://help.aliyun.com/document_detail/28950.html">Decrypt</a> operation to decrypt this new key in the destination region.</description></item>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Encrypts plaintext by using a symmetric CMK.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Precautions</h3>
        /// <list type="bullet">
        /// <item><description>For information about the access policy required to allow a RAM user or RAM role to use this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>This operation is accessible through a shared gateway or a dedicated gateway. For more information, see <a href="https://help.aliyun.com/document_detail/601559.html">Alibaba Cloud SDK</a>.<list type="bullet">
        /// <item><description>Shared gateway: You can access KMS over the Internet or a VPC. To use this method, you must enable Internet access. For more information, see <a href="https://help.aliyun.com/document_detail/2856718.html">Access keys in a KMS instance over the Internet</a>.</description></item>
        /// <item><description>Dedicated gateway: You can access KMS using the private endpoint of KMS (<c>&lt;YOUR_KMS_INSTANCE_ID&gt;.cryptoservice.kms.aliyuncs.com</c>).</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <h3>QPS limits</h3>
        /// <list type="bullet">
        /// <item><description>When accessed through a shared gateway, the queries per second (QPS) limit for a single user is 1,000. If the limit is exceeded, requests are throttled, which can affect your business. We recommend that you stay within this limit to avoid throttling.</description></item>
        /// <item><description>When accessed through a dedicated gateway, the QPS limit for a single user is subject to the computing performance specifications of your KMS instance. For more information, see <a href="https://help.aliyun.com/document_detail/480120.html">Performance metrics</a>.</description></item>
        /// </list>
        /// <h3>Description</h3>
        /// <list type="bullet">
        /// <item><description>KMS encrypts the specified data using the primary version of a specified key.</description></item>
        /// <item><description>You can encrypt a maximum of 6 KB of data, such as an RSA key, a database password, or other sensitive information.</description></item>
        /// <item><description>If you migrate encrypted data from one region to another, you can call the Encrypt operation in the destination region to re-encrypt the plaintext data key from the source region. This generates a new encrypted data key. You can then call the <a href="https://help.aliyun.com/document_detail/28950.html">Decrypt</a> operation to decrypt this new key in the destination region.</description></item>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Encrypts plaintext by using a symmetric CMK.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Precautions</h3>
        /// <list type="bullet">
        /// <item><description>For information about the access policy required to allow a RAM user or RAM role to use this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>This operation is accessible through a shared gateway or a dedicated gateway. For more information, see <a href="https://help.aliyun.com/document_detail/601559.html">Alibaba Cloud SDK</a>.<list type="bullet">
        /// <item><description>Shared gateway: You can access KMS over the Internet or a VPC. To use this method, you must enable Internet access. For more information, see <a href="https://help.aliyun.com/document_detail/2856718.html">Access keys in a KMS instance over the Internet</a>.</description></item>
        /// <item><description>Dedicated gateway: You can access KMS using the private endpoint of KMS (<c>&lt;YOUR_KMS_INSTANCE_ID&gt;.cryptoservice.kms.aliyuncs.com</c>).</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <h3>QPS limits</h3>
        /// <list type="bullet">
        /// <item><description>When accessed through a shared gateway, the queries per second (QPS) limit for a single user is 1,000. If the limit is exceeded, requests are throttled, which can affect your business. We recommend that you stay within this limit to avoid throttling.</description></item>
        /// <item><description>When accessed through a dedicated gateway, the QPS limit for a single user is subject to the computing performance specifications of your KMS instance. For more information, see <a href="https://help.aliyun.com/document_detail/480120.html">Performance metrics</a>.</description></item>
        /// </list>
        /// <h3>Description</h3>
        /// <list type="bullet">
        /// <item><description>KMS encrypts the specified data using the primary version of a specified key.</description></item>
        /// <item><description>You can encrypt a maximum of 6 KB of data, such as an RSA key, a database password, or other sensitive information.</description></item>
        /// <item><description>If you migrate encrypted data from one region to another, you can call the Encrypt operation in the destination region to re-encrypt the plaintext data key from the source region. This generates a new encrypted data key. You can then call the <a href="https://help.aliyun.com/document_detail/28950.html">Decrypt</a> operation to decrypt this new key in the destination region.</description></item>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Exports a data key encrypted by a CMK. The data key is re-encrypted by a public key that you specify for secure transmission.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Precautions</h3>
        /// <list type="bullet">
        /// <item><description>For information about the access policy required for a RAM user or RAM role to use this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>This operation is accessible through a shared gateway or a dedicated gateway. For more information, see <a href="https://help.aliyun.com/document_detail/601559.html">Alibaba Cloud SDK</a>.<list type="bullet">
        /// <item><description>Shared gateway: You can access KMS using the public endpoint or a VPC endpoint. To use the public endpoint, you must first enable it. For more information, see <a href="https://help.aliyun.com/document_detail/2856718.html">Access the key in a KMS instance over the Internet</a>.</description></item>
        /// <item><description>Dedicated gateway: You can access KMS using the private endpoint of the KMS instance: <c>&lt;YOUR_KMS_INSTANCE_ID&gt;.cryptoservice.kms.aliyuncs.com</c>.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <h3>Description</h3>
        /// <para>After you call the <a href="https://help.aliyun.com/document_detail/134043.html">GenerateDataKeyWithoutPlaintext</a> operation to obtain a data key encrypted by a master key (CMK), you can use the ExportDataKey operation to distribute the data key to other regions or cryptographic modules. The ExportDataKey operation returns the ciphertext of the data key, re-encrypted with the specified public key.
        /// You can import the exported ciphertext into the cryptographic module that holds the corresponding private key. This process lets you securely distribute the data key from KMS to a cryptographic module. After the data key is imported into the cryptographic module, you can use it to encrypt or decrypt data.</para>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Exports a data key encrypted by a CMK. The data key is re-encrypted by a public key that you specify for secure transmission.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Precautions</h3>
        /// <list type="bullet">
        /// <item><description>For information about the access policy required for a RAM user or RAM role to use this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>This operation is accessible through a shared gateway or a dedicated gateway. For more information, see <a href="https://help.aliyun.com/document_detail/601559.html">Alibaba Cloud SDK</a>.<list type="bullet">
        /// <item><description>Shared gateway: You can access KMS using the public endpoint or a VPC endpoint. To use the public endpoint, you must first enable it. For more information, see <a href="https://help.aliyun.com/document_detail/2856718.html">Access the key in a KMS instance over the Internet</a>.</description></item>
        /// <item><description>Dedicated gateway: You can access KMS using the private endpoint of the KMS instance: <c>&lt;YOUR_KMS_INSTANCE_ID&gt;.cryptoservice.kms.aliyuncs.com</c>.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <h3>Description</h3>
        /// <para>After you call the <a href="https://help.aliyun.com/document_detail/134043.html">GenerateDataKeyWithoutPlaintext</a> operation to obtain a data key encrypted by a master key (CMK), you can use the ExportDataKey operation to distribute the data key to other regions or cryptographic modules. The ExportDataKey operation returns the ciphertext of the data key, re-encrypted with the specified public key.
        /// You can import the exported ciphertext into the cryptographic module that holds the corresponding private key. This process lets you securely distribute the data key from KMS to a cryptographic module. After the data key is imported into the cryptographic module, you can use it to encrypt or decrypt data.</para>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Exports a data key encrypted by a CMK. The data key is re-encrypted by a public key that you specify for secure transmission.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Precautions</h3>
        /// <list type="bullet">
        /// <item><description>For information about the access policy required for a RAM user or RAM role to use this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>This operation is accessible through a shared gateway or a dedicated gateway. For more information, see <a href="https://help.aliyun.com/document_detail/601559.html">Alibaba Cloud SDK</a>.<list type="bullet">
        /// <item><description>Shared gateway: You can access KMS using the public endpoint or a VPC endpoint. To use the public endpoint, you must first enable it. For more information, see <a href="https://help.aliyun.com/document_detail/2856718.html">Access the key in a KMS instance over the Internet</a>.</description></item>
        /// <item><description>Dedicated gateway: You can access KMS using the private endpoint of the KMS instance: <c>&lt;YOUR_KMS_INSTANCE_ID&gt;.cryptoservice.kms.aliyuncs.com</c>.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <h3>Description</h3>
        /// <para>After you call the <a href="https://help.aliyun.com/document_detail/134043.html">GenerateDataKeyWithoutPlaintext</a> operation to obtain a data key encrypted by a master key (CMK), you can use the ExportDataKey operation to distribute the data key to other regions or cryptographic modules. The ExportDataKey operation returns the ciphertext of the data key, re-encrypted with the specified public key.
        /// You can import the exported ciphertext into the cryptographic module that holds the corresponding private key. This process lets you securely distribute the data key from KMS to a cryptographic module. After the data key is imported into the cryptographic module, you can use it to encrypt or decrypt data.</para>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Exports a data key encrypted by a CMK. The data key is re-encrypted by a public key that you specify for secure transmission.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Precautions</h3>
        /// <list type="bullet">
        /// <item><description>For information about the access policy required for a RAM user or RAM role to use this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>This operation is accessible through a shared gateway or a dedicated gateway. For more information, see <a href="https://help.aliyun.com/document_detail/601559.html">Alibaba Cloud SDK</a>.<list type="bullet">
        /// <item><description>Shared gateway: You can access KMS using the public endpoint or a VPC endpoint. To use the public endpoint, you must first enable it. For more information, see <a href="https://help.aliyun.com/document_detail/2856718.html">Access the key in a KMS instance over the Internet</a>.</description></item>
        /// <item><description>Dedicated gateway: You can access KMS using the private endpoint of the KMS instance: <c>&lt;YOUR_KMS_INSTANCE_ID&gt;.cryptoservice.kms.aliyuncs.com</c>.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <h3>Description</h3>
        /// <para>After you call the <a href="https://help.aliyun.com/document_detail/134043.html">GenerateDataKeyWithoutPlaintext</a> operation to obtain a data key encrypted by a master key (CMK), you can use the ExportDataKey operation to distribute the data key to other regions or cryptographic modules. The ExportDataKey operation returns the ciphertext of the data key, re-encrypted with the specified public key.
        /// You can import the exported ciphertext into the cryptographic module that holds the corresponding private key. This process lets you securely distribute the data key from KMS to a cryptographic module. After the data key is imported into the cryptographic module, you can use it to encrypt or decrypt data.</para>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates a random data key, encrypts it by using a CMK and a public key that you specify, and returns both ciphertexts.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Notes</h3>
        /// <list type="bullet">
        /// <item><description>For more information about the access policy required for a RAM user or RAM role to use this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>This operation is accessible through a shared gateway or a dedicated gateway. For more information, see <a href="https://help.aliyun.com/document_detail/601559.html">Alibaba Cloud SDK</a>.<list type="bullet">
        /// <item><description>Shared gateway: You can access KMS over the Internet or a VPC. To access KMS over the Internet, you must enable Internet access. For more information, see <a href="https://help.aliyun.com/document_detail/2856718.html">Access KMS instances over the Internet</a>.</description></item>
        /// <item><description>Dedicated gateway: You can access KMS using the private endpoint of KMS (<c>&lt;YOUR_KMS_INSTANCE_ID&gt;.cryptoservice.kms.aliyuncs.com</c>).</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <h3>Description</h3>
        /// <para>We recommend that you import the data key to a cryptographic module for data encryption and data decryption as follows:
        /// 1\. Call the GenerateAndExportDataKey operation to obtain the data key encrypted by a KMS key and a specified public key.
        /// 2\. Save the ciphertext of the data key that is encrypted by the KMS key to KMS or a storage service, such as ApsaraDB, for key backup and recovery.
        /// 3\. Import the ciphertext of the data key that is encrypted by the public key to the cryptographic module that contains the corresponding private key. This process distributes the key from KMS to the cryptographic module. You can then use the data key to encrypt and decrypt data.</para>
        /// <remarks>
        /// <para>The KMS key that you specify in the request is used only to encrypt the data key and is not used to generate the data key. KMS does not record or store the randomly generated data key. You are responsible for recording the data key or its ciphertext.</para>
        /// </remarks>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates a random data key, encrypts it by using a CMK and a public key that you specify, and returns both ciphertexts.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Notes</h3>
        /// <list type="bullet">
        /// <item><description>For more information about the access policy required for a RAM user or RAM role to use this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>This operation is accessible through a shared gateway or a dedicated gateway. For more information, see <a href="https://help.aliyun.com/document_detail/601559.html">Alibaba Cloud SDK</a>.<list type="bullet">
        /// <item><description>Shared gateway: You can access KMS over the Internet or a VPC. To access KMS over the Internet, you must enable Internet access. For more information, see <a href="https://help.aliyun.com/document_detail/2856718.html">Access KMS instances over the Internet</a>.</description></item>
        /// <item><description>Dedicated gateway: You can access KMS using the private endpoint of KMS (<c>&lt;YOUR_KMS_INSTANCE_ID&gt;.cryptoservice.kms.aliyuncs.com</c>).</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <h3>Description</h3>
        /// <para>We recommend that you import the data key to a cryptographic module for data encryption and data decryption as follows:
        /// 1\. Call the GenerateAndExportDataKey operation to obtain the data key encrypted by a KMS key and a specified public key.
        /// 2\. Save the ciphertext of the data key that is encrypted by the KMS key to KMS or a storage service, such as ApsaraDB, for key backup and recovery.
        /// 3\. Import the ciphertext of the data key that is encrypted by the public key to the cryptographic module that contains the corresponding private key. This process distributes the key from KMS to the cryptographic module. You can then use the data key to encrypt and decrypt data.</para>
        /// <remarks>
        /// <para>The KMS key that you specify in the request is used only to encrypt the data key and is not used to generate the data key. KMS does not record or store the randomly generated data key. You are responsible for recording the data key or its ciphertext.</para>
        /// </remarks>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates a random data key, encrypts it by using a CMK and a public key that you specify, and returns both ciphertexts.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Notes</h3>
        /// <list type="bullet">
        /// <item><description>For more information about the access policy required for a RAM user or RAM role to use this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>This operation is accessible through a shared gateway or a dedicated gateway. For more information, see <a href="https://help.aliyun.com/document_detail/601559.html">Alibaba Cloud SDK</a>.<list type="bullet">
        /// <item><description>Shared gateway: You can access KMS over the Internet or a VPC. To access KMS over the Internet, you must enable Internet access. For more information, see <a href="https://help.aliyun.com/document_detail/2856718.html">Access KMS instances over the Internet</a>.</description></item>
        /// <item><description>Dedicated gateway: You can access KMS using the private endpoint of KMS (<c>&lt;YOUR_KMS_INSTANCE_ID&gt;.cryptoservice.kms.aliyuncs.com</c>).</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <h3>Description</h3>
        /// <para>We recommend that you import the data key to a cryptographic module for data encryption and data decryption as follows:
        /// 1\. Call the GenerateAndExportDataKey operation to obtain the data key encrypted by a KMS key and a specified public key.
        /// 2\. Save the ciphertext of the data key that is encrypted by the KMS key to KMS or a storage service, such as ApsaraDB, for key backup and recovery.
        /// 3\. Import the ciphertext of the data key that is encrypted by the public key to the cryptographic module that contains the corresponding private key. This process distributes the key from KMS to the cryptographic module. You can then use the data key to encrypt and decrypt data.</para>
        /// <remarks>
        /// <para>The KMS key that you specify in the request is used only to encrypt the data key and is not used to generate the data key. KMS does not record or store the randomly generated data key. You are responsible for recording the data key or its ciphertext.</para>
        /// </remarks>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates a random data key, encrypts it by using a CMK and a public key that you specify, and returns both ciphertexts.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Notes</h3>
        /// <list type="bullet">
        /// <item><description>For more information about the access policy required for a RAM user or RAM role to use this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>This operation is accessible through a shared gateway or a dedicated gateway. For more information, see <a href="https://help.aliyun.com/document_detail/601559.html">Alibaba Cloud SDK</a>.<list type="bullet">
        /// <item><description>Shared gateway: You can access KMS over the Internet or a VPC. To access KMS over the Internet, you must enable Internet access. For more information, see <a href="https://help.aliyun.com/document_detail/2856718.html">Access KMS instances over the Internet</a>.</description></item>
        /// <item><description>Dedicated gateway: You can access KMS using the private endpoint of KMS (<c>&lt;YOUR_KMS_INSTANCE_ID&gt;.cryptoservice.kms.aliyuncs.com</c>).</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <h3>Description</h3>
        /// <para>We recommend that you import the data key to a cryptographic module for data encryption and data decryption as follows:
        /// 1\. Call the GenerateAndExportDataKey operation to obtain the data key encrypted by a KMS key and a specified public key.
        /// 2\. Save the ciphertext of the data key that is encrypted by the KMS key to KMS or a storage service, such as ApsaraDB, for key backup and recovery.
        /// 3\. Import the ciphertext of the data key that is encrypted by the public key to the cryptographic module that contains the corresponding private key. This process distributes the key from KMS to the cryptographic module. You can then use the data key to encrypt and decrypt data.</para>
        /// <remarks>
        /// <para>The KMS key that you specify in the request is used only to encrypt the data key and is not used to generate the data key. KMS does not record or store the randomly generated data key. You are responsible for recording the data key or its ciphertext.</para>
        /// </remarks>
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
        /// <para>Generates a random data key for envelope encryption. The data key is returned in both plaintext and ciphertext forms.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For information about the permissions that are required to call this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>This operation can be called using a shared gateway or a dedicated gateway. For more information, see <a href="https://help.aliyun.com/document_detail/601559.html">Alibaba Cloud SDK</a>.<list type="bullet">
        /// <item><description>Shared gateway: You can access KMS over the Internet or a VPC. To access KMS over the Internet, you must enable the public endpoint. For more information, see <a href="https://help.aliyun.com/document_detail/2856718.html">Access keys in a KMS instance over the Internet</a>.</description></item>
        /// <item><description>Dedicated gateway: You can access KMS using the private endpoint of KMS (<c>&lt;YOUR_KMS_INSTANCE_ID&gt;.cryptoservice.kms.aliyuncs.com</c>).</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <h3>QPS limits</h3>
        /// <list type="bullet">
        /// <item><description>If you use a shared gateway to call this operation, the queries per second (QPS) limit for a single user is 1,000. If the limit is exceeded, API calls are throttled. This may affect your business. We recommend that you call this operation at a reasonable rate.</description></item>
        /// <item><description>If you use a dedicated gateway to call this operation, the QPS limit for a single user is based on the computing performance of your KMS instance. For more information, see <a href="https://help.aliyun.com/document_detail/480120.html">Performance metrics</a>.</description></item>
        /// </list>
        /// <h3>Description</h3>
        /// <para>This operation generates a random data key, encrypts the data key using the specified customer master key (CMK), and returns the plaintext and ciphertext of the data key. You can use the plaintext of the data key to encrypt data locally and outside of KMS. When you store the encrypted data, you must also store the ciphertext of the data key. You can obtain the plaintext of the data key from the Plaintext field and the ciphertext of the data key from the CiphertextBlob field in the response.
        /// The CMK that you specify in the request is used only to encrypt the data key. It is not involved in the generation of the data key. KMS does not record or store the randomly generated data key. You are responsible for the persistence of the ciphertext of the data key.
        /// We recommend that you perform the following steps to encrypt data locally:
        /// 1\. Call the GenerateDataKey operation to obtain a data key for data encryption.
        /// 2\. Use the plaintext of the data key returned in the Plaintext field of the response to encrypt data locally. Then, clear the plaintext of the data key from memory.
        /// 3\. Store the ciphertext of the data key returned in the CiphertextBlob field of the response together with the encrypted data.
        /// To decrypt data locally:</para>
        /// <list type="bullet">
        /// <item><description>Call the <a href="https://help.aliyun.com/document_detail/28950.html">Decrypt</a> operation to decrypt the stored ciphertext of the data key. This operation returns the plaintext of the data key.</description></item>
        /// <item><description>Use the plaintext of the data key to decrypt data locally. Then, clear the plaintext of the data key from memory.
        /// This topic provides an example of how to generate a random data key for a key with the ID <c>key-hzz630494463ejqjx****</c>.</description></item>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Recipient))
            {
                query["Recipient"] = request.Recipient;
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
        /// <para>Generates a random data key for envelope encryption. The data key is returned in both plaintext and ciphertext forms.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For information about the permissions that are required to call this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>This operation can be called using a shared gateway or a dedicated gateway. For more information, see <a href="https://help.aliyun.com/document_detail/601559.html">Alibaba Cloud SDK</a>.<list type="bullet">
        /// <item><description>Shared gateway: You can access KMS over the Internet or a VPC. To access KMS over the Internet, you must enable the public endpoint. For more information, see <a href="https://help.aliyun.com/document_detail/2856718.html">Access keys in a KMS instance over the Internet</a>.</description></item>
        /// <item><description>Dedicated gateway: You can access KMS using the private endpoint of KMS (<c>&lt;YOUR_KMS_INSTANCE_ID&gt;.cryptoservice.kms.aliyuncs.com</c>).</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <h3>QPS limits</h3>
        /// <list type="bullet">
        /// <item><description>If you use a shared gateway to call this operation, the queries per second (QPS) limit for a single user is 1,000. If the limit is exceeded, API calls are throttled. This may affect your business. We recommend that you call this operation at a reasonable rate.</description></item>
        /// <item><description>If you use a dedicated gateway to call this operation, the QPS limit for a single user is based on the computing performance of your KMS instance. For more information, see <a href="https://help.aliyun.com/document_detail/480120.html">Performance metrics</a>.</description></item>
        /// </list>
        /// <h3>Description</h3>
        /// <para>This operation generates a random data key, encrypts the data key using the specified customer master key (CMK), and returns the plaintext and ciphertext of the data key. You can use the plaintext of the data key to encrypt data locally and outside of KMS. When you store the encrypted data, you must also store the ciphertext of the data key. You can obtain the plaintext of the data key from the Plaintext field and the ciphertext of the data key from the CiphertextBlob field in the response.
        /// The CMK that you specify in the request is used only to encrypt the data key. It is not involved in the generation of the data key. KMS does not record or store the randomly generated data key. You are responsible for the persistence of the ciphertext of the data key.
        /// We recommend that you perform the following steps to encrypt data locally:
        /// 1\. Call the GenerateDataKey operation to obtain a data key for data encryption.
        /// 2\. Use the plaintext of the data key returned in the Plaintext field of the response to encrypt data locally. Then, clear the plaintext of the data key from memory.
        /// 3\. Store the ciphertext of the data key returned in the CiphertextBlob field of the response together with the encrypted data.
        /// To decrypt data locally:</para>
        /// <list type="bullet">
        /// <item><description>Call the <a href="https://help.aliyun.com/document_detail/28950.html">Decrypt</a> operation to decrypt the stored ciphertext of the data key. This operation returns the plaintext of the data key.</description></item>
        /// <item><description>Use the plaintext of the data key to decrypt data locally. Then, clear the plaintext of the data key from memory.
        /// This topic provides an example of how to generate a random data key for a key with the ID <c>key-hzz630494463ejqjx****</c>.</description></item>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Recipient))
            {
                query["Recipient"] = request.Recipient;
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
        /// <para>Generates a random data key for envelope encryption. The data key is returned in both plaintext and ciphertext forms.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For information about the permissions that are required to call this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>This operation can be called using a shared gateway or a dedicated gateway. For more information, see <a href="https://help.aliyun.com/document_detail/601559.html">Alibaba Cloud SDK</a>.<list type="bullet">
        /// <item><description>Shared gateway: You can access KMS over the Internet or a VPC. To access KMS over the Internet, you must enable the public endpoint. For more information, see <a href="https://help.aliyun.com/document_detail/2856718.html">Access keys in a KMS instance over the Internet</a>.</description></item>
        /// <item><description>Dedicated gateway: You can access KMS using the private endpoint of KMS (<c>&lt;YOUR_KMS_INSTANCE_ID&gt;.cryptoservice.kms.aliyuncs.com</c>).</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <h3>QPS limits</h3>
        /// <list type="bullet">
        /// <item><description>If you use a shared gateway to call this operation, the queries per second (QPS) limit for a single user is 1,000. If the limit is exceeded, API calls are throttled. This may affect your business. We recommend that you call this operation at a reasonable rate.</description></item>
        /// <item><description>If you use a dedicated gateway to call this operation, the QPS limit for a single user is based on the computing performance of your KMS instance. For more information, see <a href="https://help.aliyun.com/document_detail/480120.html">Performance metrics</a>.</description></item>
        /// </list>
        /// <h3>Description</h3>
        /// <para>This operation generates a random data key, encrypts the data key using the specified customer master key (CMK), and returns the plaintext and ciphertext of the data key. You can use the plaintext of the data key to encrypt data locally and outside of KMS. When you store the encrypted data, you must also store the ciphertext of the data key. You can obtain the plaintext of the data key from the Plaintext field and the ciphertext of the data key from the CiphertextBlob field in the response.
        /// The CMK that you specify in the request is used only to encrypt the data key. It is not involved in the generation of the data key. KMS does not record or store the randomly generated data key. You are responsible for the persistence of the ciphertext of the data key.
        /// We recommend that you perform the following steps to encrypt data locally:
        /// 1\. Call the GenerateDataKey operation to obtain a data key for data encryption.
        /// 2\. Use the plaintext of the data key returned in the Plaintext field of the response to encrypt data locally. Then, clear the plaintext of the data key from memory.
        /// 3\. Store the ciphertext of the data key returned in the CiphertextBlob field of the response together with the encrypted data.
        /// To decrypt data locally:</para>
        /// <list type="bullet">
        /// <item><description>Call the <a href="https://help.aliyun.com/document_detail/28950.html">Decrypt</a> operation to decrypt the stored ciphertext of the data key. This operation returns the plaintext of the data key.</description></item>
        /// <item><description>Use the plaintext of the data key to decrypt data locally. Then, clear the plaintext of the data key from memory.
        /// This topic provides an example of how to generate a random data key for a key with the ID <c>key-hzz630494463ejqjx****</c>.</description></item>
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
        /// <para>Generates a random data key for envelope encryption. The data key is returned in both plaintext and ciphertext forms.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For information about the permissions that are required to call this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>This operation can be called using a shared gateway or a dedicated gateway. For more information, see <a href="https://help.aliyun.com/document_detail/601559.html">Alibaba Cloud SDK</a>.<list type="bullet">
        /// <item><description>Shared gateway: You can access KMS over the Internet or a VPC. To access KMS over the Internet, you must enable the public endpoint. For more information, see <a href="https://help.aliyun.com/document_detail/2856718.html">Access keys in a KMS instance over the Internet</a>.</description></item>
        /// <item><description>Dedicated gateway: You can access KMS using the private endpoint of KMS (<c>&lt;YOUR_KMS_INSTANCE_ID&gt;.cryptoservice.kms.aliyuncs.com</c>).</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <h3>QPS limits</h3>
        /// <list type="bullet">
        /// <item><description>If you use a shared gateway to call this operation, the queries per second (QPS) limit for a single user is 1,000. If the limit is exceeded, API calls are throttled. This may affect your business. We recommend that you call this operation at a reasonable rate.</description></item>
        /// <item><description>If you use a dedicated gateway to call this operation, the QPS limit for a single user is based on the computing performance of your KMS instance. For more information, see <a href="https://help.aliyun.com/document_detail/480120.html">Performance metrics</a>.</description></item>
        /// </list>
        /// <h3>Description</h3>
        /// <para>This operation generates a random data key, encrypts the data key using the specified customer master key (CMK), and returns the plaintext and ciphertext of the data key. You can use the plaintext of the data key to encrypt data locally and outside of KMS. When you store the encrypted data, you must also store the ciphertext of the data key. You can obtain the plaintext of the data key from the Plaintext field and the ciphertext of the data key from the CiphertextBlob field in the response.
        /// The CMK that you specify in the request is used only to encrypt the data key. It is not involved in the generation of the data key. KMS does not record or store the randomly generated data key. You are responsible for the persistence of the ciphertext of the data key.
        /// We recommend that you perform the following steps to encrypt data locally:
        /// 1\. Call the GenerateDataKey operation to obtain a data key for data encryption.
        /// 2\. Use the plaintext of the data key returned in the Plaintext field of the response to encrypt data locally. Then, clear the plaintext of the data key from memory.
        /// 3\. Store the ciphertext of the data key returned in the CiphertextBlob field of the response together with the encrypted data.
        /// To decrypt data locally:</para>
        /// <list type="bullet">
        /// <item><description>Call the <a href="https://help.aliyun.com/document_detail/28950.html">Decrypt</a> operation to decrypt the stored ciphertext of the data key. This operation returns the plaintext of the data key.</description></item>
        /// <item><description>Use the plaintext of the data key to decrypt data locally. Then, clear the plaintext of the data key from memory.
        /// This topic provides an example of how to generate a random data key for a key with the ID <c>key-hzz630494463ejqjx****</c>.</description></item>
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
        /// <para>Generates a random data key in only ciphertext form, without the plaintext copy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Precautions</h3>
        /// <list type="bullet">
        /// <item><description>For information about the access policy that a RAM user or RAM role needs to use this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>This operation is accessible through a shared gateway or a dedicated gateway. For more information, see <a href="https://help.aliyun.com/document_detail/601559.html">Alibaba Cloud SDK</a>.<list type="bullet">
        /// <item><description>Shared gateway: Access KMS over the Internet or through a VPC domain name. This method requires Internet access to be enabled. For more information, see <a href="https://help.aliyun.com/document_detail/2856718.html">Access keys in a KMS instance over the Internet</a>.</description></item>
        /// <item><description>Dedicated gateway: Access KMS through a KMS private endpoint (<c>&lt;YOUR_KMS_INSTANCE_ID&gt;.cryptoservice.kms.aliyuncs.com</c>).</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <h3>QPS limits</h3>
        /// <list type="bullet">
        /// <item><description>Calls through a shared gateway: The queries per second (QPS) limit for a single user is 1,000. If you exceed this limit, requests are throttled, which may affect your business. We recommend that you stay within this limit.</description></item>
        /// <item><description>Calls through a dedicated gateway: The QPS limit for a single user depends on the computing performance of your KMS instance. For more information, see <a href="https://help.aliyun.com/document_detail/480120.html">Performance metrics</a>.</description></item>
        /// </list>
        /// <h3>Details</h3>
        /// <para>This operation generates a random data key, encrypts it with a specified symmetric customer master key (CMK), and returns the ciphertext of the data key. This operation provides the same features as <a href="https://help.aliyun.com/document_detail/28948.html">GenerateDataKey</a>. The only difference is that this operation does not return the plaintext of the data key.
        /// The CMK that you specify in the request is used only to encrypt the data key. It is not used to generate the data key. KMS does not record or store the randomly generated data key.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>This operation is suitable for systems that do not need to immediately use the data key for data encryption. When encryption is required, the system calls the <a href="https://help.aliyun.com/document_detail/28950.html">Decrypt</a> API to decrypt the ciphertext of the data key.</para>
        /// </description></item>
        /// <item><description><para>This operation is also suitable for distributed systems with different trust levels. For example, your system stores data in different partitions based on a defined policy. A module pre-creates these data partitions and generates a unique data key for each one. After this module initializes the control plane, it acts as a key distributor and does not produce or consume data. When data plane modules produce and consume data, they first retrieve the ciphertext of the data key for a partition. They then decrypt the ciphertext and use the plaintext data key to encrypt or decrypt data. Finally, they purge the plaintext data key from memory. In such a system, the key distributor does not need to access the plaintext of the data key. It only requires the \<c>GenerateDataKeyWithoutPlaintext\\</c> permission for the relevant CMK. Data producers and consumers do not need to generate new data keys. They only require the \<c>Decrypt\\</c> permission for the relevant CMK.</para>
        /// </description></item>
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
        /// <para>Generates a random data key in only ciphertext form, without the plaintext copy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Precautions</h3>
        /// <list type="bullet">
        /// <item><description>For information about the access policy that a RAM user or RAM role needs to use this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>This operation is accessible through a shared gateway or a dedicated gateway. For more information, see <a href="https://help.aliyun.com/document_detail/601559.html">Alibaba Cloud SDK</a>.<list type="bullet">
        /// <item><description>Shared gateway: Access KMS over the Internet or through a VPC domain name. This method requires Internet access to be enabled. For more information, see <a href="https://help.aliyun.com/document_detail/2856718.html">Access keys in a KMS instance over the Internet</a>.</description></item>
        /// <item><description>Dedicated gateway: Access KMS through a KMS private endpoint (<c>&lt;YOUR_KMS_INSTANCE_ID&gt;.cryptoservice.kms.aliyuncs.com</c>).</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <h3>QPS limits</h3>
        /// <list type="bullet">
        /// <item><description>Calls through a shared gateway: The queries per second (QPS) limit for a single user is 1,000. If you exceed this limit, requests are throttled, which may affect your business. We recommend that you stay within this limit.</description></item>
        /// <item><description>Calls through a dedicated gateway: The QPS limit for a single user depends on the computing performance of your KMS instance. For more information, see <a href="https://help.aliyun.com/document_detail/480120.html">Performance metrics</a>.</description></item>
        /// </list>
        /// <h3>Details</h3>
        /// <para>This operation generates a random data key, encrypts it with a specified symmetric customer master key (CMK), and returns the ciphertext of the data key. This operation provides the same features as <a href="https://help.aliyun.com/document_detail/28948.html">GenerateDataKey</a>. The only difference is that this operation does not return the plaintext of the data key.
        /// The CMK that you specify in the request is used only to encrypt the data key. It is not used to generate the data key. KMS does not record or store the randomly generated data key.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>This operation is suitable for systems that do not need to immediately use the data key for data encryption. When encryption is required, the system calls the <a href="https://help.aliyun.com/document_detail/28950.html">Decrypt</a> API to decrypt the ciphertext of the data key.</para>
        /// </description></item>
        /// <item><description><para>This operation is also suitable for distributed systems with different trust levels. For example, your system stores data in different partitions based on a defined policy. A module pre-creates these data partitions and generates a unique data key for each one. After this module initializes the control plane, it acts as a key distributor and does not produce or consume data. When data plane modules produce and consume data, they first retrieve the ciphertext of the data key for a partition. They then decrypt the ciphertext and use the plaintext data key to encrypt or decrypt data. Finally, they purge the plaintext data key from memory. In such a system, the key distributor does not need to access the plaintext of the data key. It only requires the \<c>GenerateDataKeyWithoutPlaintext\\</c> permission for the relevant CMK. Data producers and consumers do not need to generate new data keys. They only require the \<c>Decrypt\\</c> permission for the relevant CMK.</para>
        /// </description></item>
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
        /// <para>Generates a random data key in only ciphertext form, without the plaintext copy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Precautions</h3>
        /// <list type="bullet">
        /// <item><description>For information about the access policy that a RAM user or RAM role needs to use this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>This operation is accessible through a shared gateway or a dedicated gateway. For more information, see <a href="https://help.aliyun.com/document_detail/601559.html">Alibaba Cloud SDK</a>.<list type="bullet">
        /// <item><description>Shared gateway: Access KMS over the Internet or through a VPC domain name. This method requires Internet access to be enabled. For more information, see <a href="https://help.aliyun.com/document_detail/2856718.html">Access keys in a KMS instance over the Internet</a>.</description></item>
        /// <item><description>Dedicated gateway: Access KMS through a KMS private endpoint (<c>&lt;YOUR_KMS_INSTANCE_ID&gt;.cryptoservice.kms.aliyuncs.com</c>).</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <h3>QPS limits</h3>
        /// <list type="bullet">
        /// <item><description>Calls through a shared gateway: The queries per second (QPS) limit for a single user is 1,000. If you exceed this limit, requests are throttled, which may affect your business. We recommend that you stay within this limit.</description></item>
        /// <item><description>Calls through a dedicated gateway: The QPS limit for a single user depends on the computing performance of your KMS instance. For more information, see <a href="https://help.aliyun.com/document_detail/480120.html">Performance metrics</a>.</description></item>
        /// </list>
        /// <h3>Details</h3>
        /// <para>This operation generates a random data key, encrypts it with a specified symmetric customer master key (CMK), and returns the ciphertext of the data key. This operation provides the same features as <a href="https://help.aliyun.com/document_detail/28948.html">GenerateDataKey</a>. The only difference is that this operation does not return the plaintext of the data key.
        /// The CMK that you specify in the request is used only to encrypt the data key. It is not used to generate the data key. KMS does not record or store the randomly generated data key.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>This operation is suitable for systems that do not need to immediately use the data key for data encryption. When encryption is required, the system calls the <a href="https://help.aliyun.com/document_detail/28950.html">Decrypt</a> API to decrypt the ciphertext of the data key.</para>
        /// </description></item>
        /// <item><description><para>This operation is also suitable for distributed systems with different trust levels. For example, your system stores data in different partitions based on a defined policy. A module pre-creates these data partitions and generates a unique data key for each one. After this module initializes the control plane, it acts as a key distributor and does not produce or consume data. When data plane modules produce and consume data, they first retrieve the ciphertext of the data key for a partition. They then decrypt the ciphertext and use the plaintext data key to encrypt or decrypt data. Finally, they purge the plaintext data key from memory. In such a system, the key distributor does not need to access the plaintext of the data key. It only requires the \<c>GenerateDataKeyWithoutPlaintext\\</c> permission for the relevant CMK. Data producers and consumers do not need to generate new data keys. They only require the \<c>Decrypt\\</c> permission for the relevant CMK.</para>
        /// </description></item>
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
        /// <para>Generates a random data key in only ciphertext form, without the plaintext copy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Precautions</h3>
        /// <list type="bullet">
        /// <item><description>For information about the access policy that a RAM user or RAM role needs to use this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>This operation is accessible through a shared gateway or a dedicated gateway. For more information, see <a href="https://help.aliyun.com/document_detail/601559.html">Alibaba Cloud SDK</a>.<list type="bullet">
        /// <item><description>Shared gateway: Access KMS over the Internet or through a VPC domain name. This method requires Internet access to be enabled. For more information, see <a href="https://help.aliyun.com/document_detail/2856718.html">Access keys in a KMS instance over the Internet</a>.</description></item>
        /// <item><description>Dedicated gateway: Access KMS through a KMS private endpoint (<c>&lt;YOUR_KMS_INSTANCE_ID&gt;.cryptoservice.kms.aliyuncs.com</c>).</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <h3>QPS limits</h3>
        /// <list type="bullet">
        /// <item><description>Calls through a shared gateway: The queries per second (QPS) limit for a single user is 1,000. If you exceed this limit, requests are throttled, which may affect your business. We recommend that you stay within this limit.</description></item>
        /// <item><description>Calls through a dedicated gateway: The QPS limit for a single user depends on the computing performance of your KMS instance. For more information, see <a href="https://help.aliyun.com/document_detail/480120.html">Performance metrics</a>.</description></item>
        /// </list>
        /// <h3>Details</h3>
        /// <para>This operation generates a random data key, encrypts it with a specified symmetric customer master key (CMK), and returns the ciphertext of the data key. This operation provides the same features as <a href="https://help.aliyun.com/document_detail/28948.html">GenerateDataKey</a>. The only difference is that this operation does not return the plaintext of the data key.
        /// The CMK that you specify in the request is used only to encrypt the data key. It is not used to generate the data key. KMS does not record or store the randomly generated data key.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>This operation is suitable for systems that do not need to immediately use the data key for data encryption. When encryption is required, the system calls the <a href="https://help.aliyun.com/document_detail/28950.html">Decrypt</a> API to decrypt the ciphertext of the data key.</para>
        /// </description></item>
        /// <item><description><para>This operation is also suitable for distributed systems with different trust levels. For example, your system stores data in different partitions based on a defined policy. A module pre-creates these data partitions and generates a unique data key for each one. After this module initializes the control plane, it acts as a key distributor and does not produce or consume data. When data plane modules produce and consume data, they first retrieve the ciphertext of the data key for a partition. They then decrypt the ciphertext and use the plaintext data key to encrypt or decrypt data. Finally, they purge the plaintext data key from memory. In such a system, the key distributor does not need to access the plaintext of the data key. It only requires the \<c>GenerateDataKeyWithoutPlaintext\\</c> permission for the relevant CMK. Data producers and consumers do not need to generate new data keys. They only require the \<c>Decrypt\\</c> permission for the relevant CMK.</para>
        /// </description></item>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates an HMAC message authentication code for a message by using a specified key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For details about the access policy required when a RAM user or RAM role invokes this operation, refer to access control.
        /// This operation can be invoked through a shared gateway or a dedicated gateway. For more information, refer to Alibaba Cloud SDK.</para>
        /// <list type="bullet">
        /// <item><description>Shared gateway: Access KMS through a public or VPC endpoint. This method requires you to enable the public network access switch. For more information, refer to accessing keys in a KMS instance over the Internet.</description></item>
        /// <item><description>Dedicated gateway: Access KMS through a KMS private endpoint (<YOUR_KMS_INSTANCE_ID>.cryptoservice.kms.aliyuncs.com).</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GenerateMacRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateMacResponse
        /// </returns>
        public GenerateMacResponse GenerateMacWithOptions(GenerateMacRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                query["Message"] = request.Message;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateMac",
                Version = "2016-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateMacResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates an HMAC message authentication code for a message by using a specified key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For details about the access policy required when a RAM user or RAM role invokes this operation, refer to access control.
        /// This operation can be invoked through a shared gateway or a dedicated gateway. For more information, refer to Alibaba Cloud SDK.</para>
        /// <list type="bullet">
        /// <item><description>Shared gateway: Access KMS through a public or VPC endpoint. This method requires you to enable the public network access switch. For more information, refer to accessing keys in a KMS instance over the Internet.</description></item>
        /// <item><description>Dedicated gateway: Access KMS through a KMS private endpoint (<YOUR_KMS_INSTANCE_ID>.cryptoservice.kms.aliyuncs.com).</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GenerateMacRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateMacResponse
        /// </returns>
        public async Task<GenerateMacResponse> GenerateMacWithOptionsAsync(GenerateMacRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                query["Message"] = request.Message;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateMac",
                Version = "2016-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateMacResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates an HMAC message authentication code for a message by using a specified key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For details about the access policy required when a RAM user or RAM role invokes this operation, refer to access control.
        /// This operation can be invoked through a shared gateway or a dedicated gateway. For more information, refer to Alibaba Cloud SDK.</para>
        /// <list type="bullet">
        /// <item><description>Shared gateway: Access KMS through a public or VPC endpoint. This method requires you to enable the public network access switch. For more information, refer to accessing keys in a KMS instance over the Internet.</description></item>
        /// <item><description>Dedicated gateway: Access KMS through a KMS private endpoint (<YOUR_KMS_INSTANCE_ID>.cryptoservice.kms.aliyuncs.com).</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GenerateMacRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateMacResponse
        /// </returns>
        public GenerateMacResponse GenerateMac(GenerateMacRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateMacWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates an HMAC message authentication code for a message by using a specified key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For details about the access policy required when a RAM user or RAM role invokes this operation, refer to access control.
        /// This operation can be invoked through a shared gateway or a dedicated gateway. For more information, refer to Alibaba Cloud SDK.</para>
        /// <list type="bullet">
        /// <item><description>Shared gateway: Access KMS through a public or VPC endpoint. This method requires you to enable the public network access switch. For more information, refer to accessing keys in a KMS instance over the Internet.</description></item>
        /// <item><description>Dedicated gateway: Access KMS through a KMS private endpoint (<YOUR_KMS_INSTANCE_ID>.cryptoservice.kms.aliyuncs.com).</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GenerateMacRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateMacResponse
        /// </returns>
        public async Task<GenerateMacResponse> GenerateMacAsync(GenerateMacRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateMacWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves information about a client key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For information about the access policy required for a RAM user or RAM role to call this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
        /// </description>
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
        /// <para>Retrieves information about a client key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For information about the access policy required for a RAM user or RAM role to call this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
        /// </description>
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
        /// <para>Retrieves information about a client key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For information about the access policy required for a RAM user or RAM role to call this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
        /// </description>
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
        /// <para>Retrieves information about a client key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For information about the access policy required for a RAM user or RAM role to call this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
        /// </description>
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
        /// <para>Queries the default KMS instance in a specified region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For information about the access policy that is required to call this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>This API is for users who migrate from KMS 1.0 to KMS 3.0. After the migration is complete, if you create an Asset without specifying a KMS instance, the Asset is created in the default KMS instance.</description></item>
        /// </list>
        /// </description>
        /// 
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
        /// <para>Queries the default KMS instance in a specified region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For information about the access policy that is required to call this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>This API is for users who migrate from KMS 1.0 to KMS 3.0. After the migration is complete, if you create an Asset without specifying a KMS instance, the Asset is created in the default KMS instance.</description></item>
        /// </list>
        /// </description>
        /// 
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
        /// <para>Queries the default KMS instance in a specified region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For information about the access policy that is required to call this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>This API is for users who migrate from KMS 1.0 to KMS 3.0. After the migration is complete, if you create an Asset without specifying a KMS instance, the Asset is created in the default KMS instance.</description></item>
        /// </list>
        /// </description>
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
        /// <para>Queries the default KMS instance in a specified region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For information about the access policy that is required to call this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>This API is for users who migrate from KMS 1.0 to KMS 3.0. After the migration is complete, if you create an Asset without specifying a KMS instance, the Asset is created in the default KMS instance.</description></item>
        /// </list>
        /// </description>
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
        /// <para>Queries the key policy of a CMK in a KMS instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For more information about the access policy required for a Resource Access Management (RAM) user or RAM role to call this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>Because the key policy name can only be set to default, you must set the PolicyName parameter to default when you query the key policy. Otherwise, a <c>Not Found</c> error is returned.</description></item>
        /// </list>
        /// </description>
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
        /// <para>Queries the key policy of a CMK in a KMS instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For more information about the access policy required for a Resource Access Management (RAM) user or RAM role to call this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>Because the key policy name can only be set to default, you must set the PolicyName parameter to default when you query the key policy. Otherwise, a <c>Not Found</c> error is returned.</description></item>
        /// </list>
        /// </description>
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
        /// <para>Queries the key policy of a CMK in a KMS instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For more information about the access policy required for a Resource Access Management (RAM) user or RAM role to call this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>Because the key policy name can only be set to default, you must set the PolicyName parameter to default when you query the key policy. Otherwise, a <c>Not Found</c> error is returned.</description></item>
        /// </list>
        /// </description>
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
        /// <para>Queries the key policy of a CMK in a KMS instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For more information about the access policy required for a Resource Access Management (RAM) user or RAM role to call this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>Because the key policy name can only be set to default, you must set the PolicyName parameter to default when you query the key policy. Otherwise, a <c>Not Found</c> error is returned.</description></item>
        /// </list>
        /// </description>
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
        /// <para>Retrieves the details of a KMS instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Refer to <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a> for the access policy required to call this OpenAPI as a RAM user or RAM role.</para>
        /// </description>
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
        /// <para>Retrieves the details of a KMS instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Refer to <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a> for the access policy required to call this OpenAPI as a RAM user or RAM role.</para>
        /// </description>
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
        /// <para>Retrieves the details of a KMS instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Refer to <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a> for the access policy required to call this OpenAPI as a RAM user or RAM role.</para>
        /// </description>
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
        /// <para>Retrieves the details of a KMS instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Refer to <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a> for the access policy required to call this OpenAPI as a RAM user or RAM role.</para>
        /// </description>
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
        /// <para>Queries the quota usage and limits for a KMS instance.</para>
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
        /// <para>Queries the quota usage and limits for a KMS instance.</para>
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
        /// <para>Queries the quota usage and limits for a KMS instance.</para>
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
        /// <para>Queries the quota usage and limits for a KMS instance.</para>
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
        /// <para>Retrieves the plaintext of a managed data key (DK).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For information about the access policy that must be granted to a RAM user or RAM role to call this operation, refer to access control.
        /// This operation can be called through a shared gateway. For more information, refer to Alibaba Cloud SDK.</para>
        /// <list type="bullet">
        /// <item><description>Shared gateway: Access KMS through public or VPC endpoints.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetManagedDataKeyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetManagedDataKeyResponse
        /// </returns>
        public GetManagedDataKeyResponse GetManagedDataKeyWithOptions(GetManagedDataKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataKeyName))
            {
                query["DataKeyName"] = request.DataKeyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataKeyVersionId))
            {
                query["DataKeyVersionId"] = request.DataKeyVersionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseLatest))
            {
                query["UseLatest"] = request.UseLatest;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetManagedDataKey",
                Version = "2016-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetManagedDataKeyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the plaintext of a managed data key (DK).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For information about the access policy that must be granted to a RAM user or RAM role to call this operation, refer to access control.
        /// This operation can be called through a shared gateway. For more information, refer to Alibaba Cloud SDK.</para>
        /// <list type="bullet">
        /// <item><description>Shared gateway: Access KMS through public or VPC endpoints.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetManagedDataKeyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetManagedDataKeyResponse
        /// </returns>
        public async Task<GetManagedDataKeyResponse> GetManagedDataKeyWithOptionsAsync(GetManagedDataKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataKeyName))
            {
                query["DataKeyName"] = request.DataKeyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataKeyVersionId))
            {
                query["DataKeyVersionId"] = request.DataKeyVersionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseLatest))
            {
                query["UseLatest"] = request.UseLatest;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetManagedDataKey",
                Version = "2016-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetManagedDataKeyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the plaintext of a managed data key (DK).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For information about the access policy that must be granted to a RAM user or RAM role to call this operation, refer to access control.
        /// This operation can be called through a shared gateway. For more information, refer to Alibaba Cloud SDK.</para>
        /// <list type="bullet">
        /// <item><description>Shared gateway: Access KMS through public or VPC endpoints.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetManagedDataKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// GetManagedDataKeyResponse
        /// </returns>
        public GetManagedDataKeyResponse GetManagedDataKey(GetManagedDataKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetManagedDataKeyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the plaintext of a managed data key (DK).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For information about the access policy that must be granted to a RAM user or RAM role to call this operation, refer to access control.
        /// This operation can be called through a shared gateway. For more information, refer to Alibaba Cloud SDK.</para>
        /// <list type="bullet">
        /// <item><description>Shared gateway: Access KMS through public or VPC endpoints.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetManagedDataKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// GetManagedDataKeyResponse
        /// </returns>
        public async Task<GetManagedDataKeyResponse> GetManagedDataKeyAsync(GetManagedDataKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetManagedDataKeyWithOptionsAsync(request, runtime);
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the public key of an asymmetric key. You can use the public key to encrypt data or verify a signature on your device.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For more information about the access policy required for a RAM user or RAM role to call this OpenAPI operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>This operation supports both shared gateways and dedicated gateways. For more information, see <a href="https://help.aliyun.com/document_detail/601559.html">Alibaba Cloud SDK</a>.<list type="bullet">
        /// <item><description>Shared gateway: You can access KMS over the Internet or using a VPC domain name. If you access KMS over the Internet, you must enable Internet access. For more information, see <a href="https://help.aliyun.com/document_detail/2856718.html">Access keys in a KMS instance over the Internet</a>.</description></item>
        /// <item><description>Dedicated gateway: You can access KMS using the private endpoint of KMS (<c>&lt;YOUR_KMS_INSTANCE_ID&gt;.cryptoservice.kms.aliyuncs.com</c>).</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the public key of an asymmetric key. You can use the public key to encrypt data or verify a signature on your device.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For more information about the access policy required for a RAM user or RAM role to call this OpenAPI operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>This operation supports both shared gateways and dedicated gateways. For more information, see <a href="https://help.aliyun.com/document_detail/601559.html">Alibaba Cloud SDK</a>.<list type="bullet">
        /// <item><description>Shared gateway: You can access KMS over the Internet or using a VPC domain name. If you access KMS over the Internet, you must enable Internet access. For more information, see <a href="https://help.aliyun.com/document_detail/2856718.html">Access keys in a KMS instance over the Internet</a>.</description></item>
        /// <item><description>Dedicated gateway: You can access KMS using the private endpoint of KMS (<c>&lt;YOUR_KMS_INSTANCE_ID&gt;.cryptoservice.kms.aliyuncs.com</c>).</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the public key of an asymmetric key. You can use the public key to encrypt data or verify a signature on your device.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For more information about the access policy required for a RAM user or RAM role to call this OpenAPI operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>This operation supports both shared gateways and dedicated gateways. For more information, see <a href="https://help.aliyun.com/document_detail/601559.html">Alibaba Cloud SDK</a>.<list type="bullet">
        /// <item><description>Shared gateway: You can access KMS over the Internet or using a VPC domain name. If you access KMS over the Internet, you must enable Internet access. For more information, see <a href="https://help.aliyun.com/document_detail/2856718.html">Access keys in a KMS instance over the Internet</a>.</description></item>
        /// <item><description>Dedicated gateway: You can access KMS using the private endpoint of KMS (<c>&lt;YOUR_KMS_INSTANCE_ID&gt;.cryptoservice.kms.aliyuncs.com</c>).</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the public key of an asymmetric key. You can use the public key to encrypt data or verify a signature on your device.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For more information about the access policy required for a RAM user or RAM role to call this OpenAPI operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>This operation supports both shared gateways and dedicated gateways. For more information, see <a href="https://help.aliyun.com/document_detail/601559.html">Alibaba Cloud SDK</a>.<list type="bullet">
        /// <item><description>Shared gateway: You can access KMS over the Internet or using a VPC domain name. If you access KMS over the Internet, you must enable Internet access. For more information, see <a href="https://help.aliyun.com/document_detail/2856718.html">Access keys in a KMS instance over the Internet</a>.</description></item>
        /// <item><description>Dedicated gateway: You can access KMS using the private endpoint of KMS (<c>&lt;YOUR_KMS_INSTANCE_ID&gt;.cryptoservice.kms.aliyuncs.com</c>).</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates a random password string.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For more information about the access policy required by a RAM user or RAM role to call this API, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
        /// </description>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates a random password string.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For more information about the access policy required by a RAM user or RAM role to call this API, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
        /// </description>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates a random password string.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For more information about the access policy required by a RAM user or RAM role to call this API, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
        /// </description>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates a random password string.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For more information about the access policy required by a RAM user or RAM role to call this API, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
        /// </description>
        /// 
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
        /// <para>Queries the access policy of a specified secret in a KMS instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For information about the access policy required for a RAM user or RAM role to call this OpenAPI, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>A credential policy name can be set only to default. Therefore, you must set the PolicyName parameter to default when you query the credential policy. Otherwise, a <c>Not Found</c> error is returned.</description></item>
        /// </list>
        /// </description>
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
        /// <para>Queries the access policy of a specified secret in a KMS instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For information about the access policy required for a RAM user or RAM role to call this OpenAPI, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>A credential policy name can be set only to default. Therefore, you must set the PolicyName parameter to default when you query the credential policy. Otherwise, a <c>Not Found</c> error is returned.</description></item>
        /// </list>
        /// </description>
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
        /// <para>Queries the access policy of a specified secret in a KMS instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For information about the access policy required for a RAM user or RAM role to call this OpenAPI, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>A credential policy name can be set only to default. Therefore, you must set the PolicyName parameter to default when you query the credential policy. Otherwise, a <c>Not Found</c> error is returned.</description></item>
        /// </list>
        /// </description>
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
        /// <para>Queries the access policy of a specified secret in a KMS instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For information about the access policy required for a RAM user or RAM role to call this OpenAPI, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>A credential policy name can be set only to default. Therefore, you must set the PolicyName parameter to default when you query the credential policy. Otherwise, a <c>Not Found</c> error is returned.</description></item>
        /// </list>
        /// </description>
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
        /// <para>Retrieve the credential value.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For details about the access policy that must be granted to a Resource Access Management (RAM) user or RAM role to invoke this OpenAPI operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>If you do not specify a version number or version status, Key Management Service (KMS) returns the credential value of the version marked as ACSCurrent by default.</description></item>
        /// <item><description>If a customer-managed key is used to protect the credential value, the caller must also have the <c>kms:Decrypt</c> permission on the corresponding master key.
        /// This topic provides a sample request to retrieve the credential value of a credential named <c>secret001</c>. The returned result shows that the credential value <c>SecretData</c> is <c>testdata1</c>.</description></item>
        /// </list>
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
        /// <para>Retrieve the credential value.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For details about the access policy that must be granted to a Resource Access Management (RAM) user or RAM role to invoke this OpenAPI operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>If you do not specify a version number or version status, Key Management Service (KMS) returns the credential value of the version marked as ACSCurrent by default.</description></item>
        /// <item><description>If a customer-managed key is used to protect the credential value, the caller must also have the <c>kms:Decrypt</c> permission on the corresponding master key.
        /// This topic provides a sample request to retrieve the credential value of a credential named <c>secret001</c>. The returned result shows that the credential value <c>SecretData</c> is <c>testdata1</c>.</description></item>
        /// </list>
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
        /// <para>Retrieve the credential value.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For details about the access policy that must be granted to a Resource Access Management (RAM) user or RAM role to invoke this OpenAPI operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>If you do not specify a version number or version status, Key Management Service (KMS) returns the credential value of the version marked as ACSCurrent by default.</description></item>
        /// <item><description>If a customer-managed key is used to protect the credential value, the caller must also have the <c>kms:Decrypt</c> permission on the corresponding master key.
        /// This topic provides a sample request to retrieve the credential value of a credential named <c>secret001</c>. The returned result shows that the credential value <c>SecretData</c> is <c>testdata1</c>.</description></item>
        /// </list>
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
        /// <para>Retrieve the credential value.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For details about the access policy that must be granted to a Resource Access Management (RAM) user or RAM role to invoke this OpenAPI operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>If you do not specify a version number or version status, Key Management Service (KMS) returns the credential value of the version marked as ACSCurrent by default.</description></item>
        /// <item><description>If a customer-managed key is used to protect the credential value, the caller must also have the <c>kms:Decrypt</c> permission on the corresponding master key.
        /// This topic provides a sample request to retrieve the credential value of a credential named <c>secret001</c>. The returned result shows that the credential value <c>SecretData</c> is <c>testdata1</c>.</description></item>
        /// </list>
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
        /// <para>Imports externally generated key material into a CMK whose origin is EXTERNAL.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call <a href="https://help.aliyun.com/document_detail/28947.html">CreateKey</a> to create a CMK, you can set <b>Origin</b> to <b>EXTERNAL</b> to specify that the key material comes from an external source. Use this operation to import the key material into such a CMK.</para>
        /// <list type="bullet">
        /// <item><description>To view the CMK <b>Origin</b>, see <a href="https://help.aliyun.com/document_detail/28952.html">DescribeKey</a>.</description></item>
        /// <item><description>Before importing key material, call <a href="https://help.aliyun.com/document_detail/68621.html">GetParametersForImport</a> to obtain the parameters required for the import, including the public key and import token.<remarks>
        /// <list type="bullet">
        /// <item><description><para>For a CMK of type <b>Aliyun_AES_256</b>, the key material must be 256 bits. For a CMK of type <b>Aliyun_SM4</b>, the key material must be 128 bits.</para>
        /// </description></item>
        /// <item><description><para>You can set the expiration time for the key material, or you can set it to never expire.</para>
        /// </description></item>
        /// <item><description><para>You can reimport the key material and reset the expiration time for the specified CMK at any time, but the same key material must be imported.</para>
        /// </description></item>
        /// <item><description><para>After the imported key material expires or is deleted, the specified CMK becomes unavailable until the same key material is imported again.</para>
        /// </description></item>
        /// <item><description><para>The same key material can be imported into multiple CMKs, but data or data keys encrypted by one CMK cannot be decrypted by another CMK.
        /// For more information about the access policy required for a RAM user or RAM role to call this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
        /// </description></item>
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
        /// <para>Imports externally generated key material into a CMK whose origin is EXTERNAL.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call <a href="https://help.aliyun.com/document_detail/28947.html">CreateKey</a> to create a CMK, you can set <b>Origin</b> to <b>EXTERNAL</b> to specify that the key material comes from an external source. Use this operation to import the key material into such a CMK.</para>
        /// <list type="bullet">
        /// <item><description>To view the CMK <b>Origin</b>, see <a href="https://help.aliyun.com/document_detail/28952.html">DescribeKey</a>.</description></item>
        /// <item><description>Before importing key material, call <a href="https://help.aliyun.com/document_detail/68621.html">GetParametersForImport</a> to obtain the parameters required for the import, including the public key and import token.<remarks>
        /// <list type="bullet">
        /// <item><description><para>For a CMK of type <b>Aliyun_AES_256</b>, the key material must be 256 bits. For a CMK of type <b>Aliyun_SM4</b>, the key material must be 128 bits.</para>
        /// </description></item>
        /// <item><description><para>You can set the expiration time for the key material, or you can set it to never expire.</para>
        /// </description></item>
        /// <item><description><para>You can reimport the key material and reset the expiration time for the specified CMK at any time, but the same key material must be imported.</para>
        /// </description></item>
        /// <item><description><para>After the imported key material expires or is deleted, the specified CMK becomes unavailable until the same key material is imported again.</para>
        /// </description></item>
        /// <item><description><para>The same key material can be imported into multiple CMKs, but data or data keys encrypted by one CMK cannot be decrypted by another CMK.
        /// For more information about the access policy required for a RAM user or RAM role to call this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
        /// </description></item>
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
        /// <para>Imports externally generated key material into a CMK whose origin is EXTERNAL.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call <a href="https://help.aliyun.com/document_detail/28947.html">CreateKey</a> to create a CMK, you can set <b>Origin</b> to <b>EXTERNAL</b> to specify that the key material comes from an external source. Use this operation to import the key material into such a CMK.</para>
        /// <list type="bullet">
        /// <item><description>To view the CMK <b>Origin</b>, see <a href="https://help.aliyun.com/document_detail/28952.html">DescribeKey</a>.</description></item>
        /// <item><description>Before importing key material, call <a href="https://help.aliyun.com/document_detail/68621.html">GetParametersForImport</a> to obtain the parameters required for the import, including the public key and import token.<remarks>
        /// <list type="bullet">
        /// <item><description><para>For a CMK of type <b>Aliyun_AES_256</b>, the key material must be 256 bits. For a CMK of type <b>Aliyun_SM4</b>, the key material must be 128 bits.</para>
        /// </description></item>
        /// <item><description><para>You can set the expiration time for the key material, or you can set it to never expire.</para>
        /// </description></item>
        /// <item><description><para>You can reimport the key material and reset the expiration time for the specified CMK at any time, but the same key material must be imported.</para>
        /// </description></item>
        /// <item><description><para>After the imported key material expires or is deleted, the specified CMK becomes unavailable until the same key material is imported again.</para>
        /// </description></item>
        /// <item><description><para>The same key material can be imported into multiple CMKs, but data or data keys encrypted by one CMK cannot be decrypted by another CMK.
        /// For more information about the access policy required for a RAM user or RAM role to call this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
        /// </description></item>
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
        /// <para>Imports externally generated key material into a CMK whose origin is EXTERNAL.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call <a href="https://help.aliyun.com/document_detail/28947.html">CreateKey</a> to create a CMK, you can set <b>Origin</b> to <b>EXTERNAL</b> to specify that the key material comes from an external source. Use this operation to import the key material into such a CMK.</para>
        /// <list type="bullet">
        /// <item><description>To view the CMK <b>Origin</b>, see <a href="https://help.aliyun.com/document_detail/28952.html">DescribeKey</a>.</description></item>
        /// <item><description>Before importing key material, call <a href="https://help.aliyun.com/document_detail/68621.html">GetParametersForImport</a> to obtain the parameters required for the import, including the public key and import token.<remarks>
        /// <list type="bullet">
        /// <item><description><para>For a CMK of type <b>Aliyun_AES_256</b>, the key material must be 256 bits. For a CMK of type <b>Aliyun_SM4</b>, the key material must be 128 bits.</para>
        /// </description></item>
        /// <item><description><para>You can set the expiration time for the key material, or you can set it to never expire.</para>
        /// </description></item>
        /// <item><description><para>You can reimport the key material and reset the expiration time for the specified CMK at any time, but the same key material must be imported.</para>
        /// </description></item>
        /// <item><description><para>After the imported key material expires or is deleted, the specified CMK becomes unavailable until the same key material is imported again.</para>
        /// </description></item>
        /// <item><description><para>The same key material can be imported into multiple CMKs, but data or data keys encrypted by one CMK cannot be decrypted by another CMK.
        /// For more information about the access policy required for a RAM user or RAM role to call this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
        /// </description></item>
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
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For more information about the access policy required by a RAM user or RAM role to call this API, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
        /// </description>
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
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For more information about the access policy required by a RAM user or RAM role to call this API, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
        /// </description>
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
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For more information about the access policy required by a RAM user or RAM role to call this API, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
        /// </description>
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
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For more information about the access policy required by a RAM user or RAM role to call this API, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
        /// </description>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all aliases that are bound to a key.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all aliases that are bound to a key.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all aliases that are bound to a key.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all aliases that are bound to a key.</para>
        /// </summary>
        /// 
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
        /// <para>Queries all application access points (AAPs) in the current region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For more information about the access policy required by a RAM user or RAM role to call this API, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
        /// </description>
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
        /// <para>Queries all application access points (AAPs) in the current region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For more information about the access policy required by a RAM user or RAM role to call this API, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
        /// </description>
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
        /// <para>Queries all application access points (AAPs) in the current region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For more information about the access policy required by a RAM user or RAM role to call this API, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
        /// </description>
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
        /// <para>Queries all application access points (AAPs) in the current region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For more information about the access policy required by a RAM user or RAM role to call this API, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
        /// </description>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all client keys within an AAP.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For more information about the access policy required by a RAM user or RAM role to call this API, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
        /// </description>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all client keys within an AAP.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For more information about the access policy required by a RAM user or RAM role to call this API, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
        /// </description>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all client keys within an AAP.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For more information about the access policy required by a RAM user or RAM role to call this API, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
        /// </description>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all client keys within an AAP.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For more information about the access policy required by a RAM user or RAM role to call this API, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
        /// </description>
        /// 
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
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For more information about the access policy required by a RAM user or RAM role to call this API, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
        /// </description>
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
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For more information about the access policy required by a RAM user or RAM role to call this API, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
        /// </description>
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
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For more information about the access policy required by a RAM user or RAM role to call this API, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
        /// </description>
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
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For more information about the access policy required by a RAM user or RAM role to call this API, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
        /// </description>
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
        /// <para>Queries the IDs and ARNs of all CMKs in the current region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For more information about the access policy required by a RAM user or RAM role to call this API, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
        /// </description>
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
        /// <para>Queries the IDs and ARNs of all CMKs in the current region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For more information about the access policy required by a RAM user or RAM role to call this API, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
        /// </description>
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
        /// <para>Queries the IDs and ARNs of all CMKs in the current region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For more information about the access policy required by a RAM user or RAM role to call this API, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
        /// </description>
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
        /// <para>Queries the IDs and ARNs of all CMKs in the current region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For more information about the access policy required by a RAM user or RAM role to call this API, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
        /// </description>
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
        /// <para>Queries all KMS instances in the current region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For more information about the access policy required for a RAM user or RAM role to call this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
        /// </description>
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
        /// <para>Queries all KMS instances in the current region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For more information about the access policy required for a RAM user or RAM role to call this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
        /// </description>
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
        /// <para>Queries all KMS instances in the current region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For more information about the access policy required for a RAM user or RAM role to call this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
        /// </description>
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
        /// <para>Queries all KMS instances in the current region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For more information about the access policy required for a RAM user or RAM role to call this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
        /// </description>
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
        /// <para>Lists the key versions of a specified managed data key (DK).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For details about the access policy required when a RAM user or RAM role invokes this operation, refer to access control.
        /// This operation can be invoked through the shared gateway. For more information, refer to Alibaba Cloud SDK.</para>
        /// <list type="bullet">
        /// <item><description>Shared gateway: Access KMS through public or VPC endpoints.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListManagedDataKeyVersionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListManagedDataKeyVersionsResponse
        /// </returns>
        public ListManagedDataKeyVersionsResponse ListManagedDataKeyVersionsWithOptions(ListManagedDataKeyVersionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataKeyName))
            {
                query["DataKeyName"] = request.DataKeyName;
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
                Action = "ListManagedDataKeyVersions",
                Version = "2016-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListManagedDataKeyVersionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the key versions of a specified managed data key (DK).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For details about the access policy required when a RAM user or RAM role invokes this operation, refer to access control.
        /// This operation can be invoked through the shared gateway. For more information, refer to Alibaba Cloud SDK.</para>
        /// <list type="bullet">
        /// <item><description>Shared gateway: Access KMS through public or VPC endpoints.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListManagedDataKeyVersionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListManagedDataKeyVersionsResponse
        /// </returns>
        public async Task<ListManagedDataKeyVersionsResponse> ListManagedDataKeyVersionsWithOptionsAsync(ListManagedDataKeyVersionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataKeyName))
            {
                query["DataKeyName"] = request.DataKeyName;
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
                Action = "ListManagedDataKeyVersions",
                Version = "2016-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListManagedDataKeyVersionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the key versions of a specified managed data key (DK).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For details about the access policy required when a RAM user or RAM role invokes this operation, refer to access control.
        /// This operation can be invoked through the shared gateway. For more information, refer to Alibaba Cloud SDK.</para>
        /// <list type="bullet">
        /// <item><description>Shared gateway: Access KMS through public or VPC endpoints.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListManagedDataKeyVersionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListManagedDataKeyVersionsResponse
        /// </returns>
        public ListManagedDataKeyVersionsResponse ListManagedDataKeyVersions(ListManagedDataKeyVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListManagedDataKeyVersionsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the key versions of a specified managed data key (DK).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For details about the access policy required when a RAM user or RAM role invokes this operation, refer to access control.
        /// This operation can be invoked through the shared gateway. For more information, refer to Alibaba Cloud SDK.</para>
        /// <list type="bullet">
        /// <item><description>Shared gateway: Access KMS through public or VPC endpoints.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListManagedDataKeyVersionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListManagedDataKeyVersionsResponse
        /// </returns>
        public async Task<ListManagedDataKeyVersionsResponse> ListManagedDataKeyVersionsAsync(ListManagedDataKeyVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListManagedDataKeyVersionsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all network access rules in the current region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For more information about the access policy required by a RAM user or RAM role to call this API, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
        /// </description>
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
        /// <para>Queries all network access rules in the current region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For more information about the access policy required by a RAM user or RAM role to call this API, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
        /// </description>
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
        /// <para>Queries all network access rules in the current region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For more information about the access policy required by a RAM user or RAM role to call this API, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
        /// </description>
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
        /// <para>Queries all network access rules in the current region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For more information about the access policy required by a RAM user or RAM role to call this API, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
        /// </description>
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
        /// <para>Queries all permission policies in the current region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For more information about the access policy required by a RAM user or RAM role to call this API, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
        /// </description>
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
        /// <para>Queries all permission policies in the current region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For more information about the access policy required by a RAM user or RAM role to call this API, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
        /// </description>
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
        /// <para>Queries all permission policies in the current region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For more information about the access policy required by a RAM user or RAM role to call this API, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
        /// </description>
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
        /// <para>Queries all permission policies in the current region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For more information about the access policy required by a RAM user or RAM role to call this API, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
        /// </description>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tags of a customer master key (CMK).</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tags of a customer master key (CMK).</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tags of a customer master key (CMK).</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tags of a customer master key (CMK).</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all version IDs and stage labels of a specified secret.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For more information about the access policy required for a RAM user or RAM role to call this OpenAPI, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>The version information does not include the secret value. By default, this operation returns only the secret versions that are marked with a version stage.</description></item>
        /// </list>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all version IDs and stage labels of a specified secret.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For more information about the access policy required for a RAM user or RAM role to call this OpenAPI, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>The version information does not include the secret value. By default, this operation returns only the secret versions that are marked with a version stage.</description></item>
        /// </list>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all version IDs and stage labels of a specified secret.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For more information about the access policy required for a RAM user or RAM role to call this OpenAPI, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>The version information does not include the secret value. By default, this operation returns only the secret versions that are marked with a version stage.</description></item>
        /// </list>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all version IDs and stage labels of a specified secret.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For more information about the access policy required for a RAM user or RAM role to call this OpenAPI, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>The version information does not include the secret value. By default, this operation returns only the secret versions that are marked with a version stage.</description></item>
        /// </list>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all secrets in the current region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>To call this operation, the RAM user or RAM role must be granted the required policy. For more information, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>This operation returns only secret metadata, not the secret values.
        /// This example shows how to query secrets created by the current user in the current region. <c>PageNumber</c> is set to <c>1</c> and <c>PageSize</c> is set to <c>2</c>, returning metadata for two secrets.</description></item>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all secrets in the current region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>To call this operation, the RAM user or RAM role must be granted the required policy. For more information, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>This operation returns only secret metadata, not the secret values.
        /// This example shows how to query secrets created by the current user in the current region. <c>PageNumber</c> is set to <c>1</c> and <c>PageSize</c> is set to <c>2</c>, returning metadata for two secrets.</description></item>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all secrets in the current region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>To call this operation, the RAM user or RAM role must be granted the required policy. For more information, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>This operation returns only secret metadata, not the secret values.
        /// This example shows how to query secrets created by the current user in the current region. <c>PageNumber</c> is set to <c>1</c> and <c>PageSize</c> is set to <c>2</c>, returning metadata for two secrets.</description></item>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all secrets in the current region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>To call this operation, the RAM user or RAM role must be granted the required policy. For more information, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>This operation returns only secret metadata, not the secret values.
        /// This example shows how to query secrets created by the current user in the current region. <c>PageNumber</c> is set to <c>1</c> and <c>PageSize</c> is set to <c>2</c>, returning metadata for two secrets.</description></item>
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
        /// <para>Lists the tags that are bound to a key or a secret.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For more information about the access policy required for a RAM user or RAM role to call this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
        /// </description>
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
        /// <para>Lists the tags that are bound to a key or a secret.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For more information about the access policy required for a RAM user or RAM role to call this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
        /// </description>
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
        /// <para>Lists the tags that are bound to a key or a secret.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For more information about the access policy required for a RAM user or RAM role to call this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
        /// </description>
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
        /// <para>Lists the tags that are bound to a key or a secret.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For more information about the access policy required for a RAM user or RAM role to call this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
        /// </description>
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
        /// <para>Activates Key Management Service (KMS) for your Alibaba Cloud account.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For more information about the access policies that a RAM user or RAM role needs to call this OpenAPI, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>KMS is a paid service. For more information about billing, see <a href="https://help.aliyun.com/document_detail/52608.html">Billing</a>.</description></item>
        /// <item><description>You can activate the service for an Alibaba Cloud account only once.</description></item>
        /// <item><description>Make sure that your Alibaba Cloud account has completed real-name verification.</description></item>
        /// </list>
        /// </description>
        /// 
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
        /// <para>Activates Key Management Service (KMS) for your Alibaba Cloud account.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For more information about the access policies that a RAM user or RAM role needs to call this OpenAPI, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>KMS is a paid service. For more information about billing, see <a href="https://help.aliyun.com/document_detail/52608.html">Billing</a>.</description></item>
        /// <item><description>You can activate the service for an Alibaba Cloud account only once.</description></item>
        /// <item><description>Make sure that your Alibaba Cloud account has completed real-name verification.</description></item>
        /// </list>
        /// </description>
        /// 
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
        /// <para>Activates Key Management Service (KMS) for your Alibaba Cloud account.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For more information about the access policies that a RAM user or RAM role needs to call this OpenAPI, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>KMS is a paid service. For more information about billing, see <a href="https://help.aliyun.com/document_detail/52608.html">Billing</a>.</description></item>
        /// <item><description>You can activate the service for an Alibaba Cloud account only once.</description></item>
        /// <item><description>Make sure that your Alibaba Cloud account has completed real-name verification.</description></item>
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
        /// <para>Activates Key Management Service (KMS) for your Alibaba Cloud account.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For more information about the access policies that a RAM user or RAM role needs to call this OpenAPI, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>KMS is a paid service. For more information about billing, see <a href="https://help.aliyun.com/document_detail/52608.html">Billing</a>.</description></item>
        /// <item><description>You can activate the service for an Alibaba Cloud account only once.</description></item>
        /// <item><description>Make sure that your Alibaba Cloud account has completed real-name verification.</description></item>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stores a new version of a secret value for a generic secret.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For information about the access policy required for a RAM user or RAM role to call this OpenAPI operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>This operation supports only generic secrets. Each generic secret can have a maximum of 10 versions. If the number of versions exceeds the limit, KMS deletes the earliest version.</description></item>
        /// <item><description>By default, the new secret value is marked with ACSCurrent, and the previous version that was marked with ACSCurrent is marked with ACSPrevious. You can specify the VersionStage parameter to overwrite this default behavior.</description></item>
        /// <item><description>This operation stores a new version of a secret value. You cannot use it to modify an existing version of a secret value. You must specify a version number when you store a new version. KMS processes requests based on the following rules:<list type="bullet">
        /// <item><description>If the version number does not exist in the secret, KMS creates a new version and stores the secret value.</description></item>
        /// <item><description>If the version number already exists in the secret, KMS compares the secret value in the request with the stored value. If the values are the same, the request is ignored and a success message is returned. This makes the operation idempotent. If the values are different, the request is rejected.
        /// This topic provides an example of how to store a new version of a secret value for the secret named <c>secret001</c>. The new version number (<c>VersionId</c>) is <c>v3</c> and the secret value (<c>SecretData</c>) is <c>importantdata</c>.</description></item>
        /// </list>
        /// </description></item>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stores a new version of a secret value for a generic secret.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For information about the access policy required for a RAM user or RAM role to call this OpenAPI operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>This operation supports only generic secrets. Each generic secret can have a maximum of 10 versions. If the number of versions exceeds the limit, KMS deletes the earliest version.</description></item>
        /// <item><description>By default, the new secret value is marked with ACSCurrent, and the previous version that was marked with ACSCurrent is marked with ACSPrevious. You can specify the VersionStage parameter to overwrite this default behavior.</description></item>
        /// <item><description>This operation stores a new version of a secret value. You cannot use it to modify an existing version of a secret value. You must specify a version number when you store a new version. KMS processes requests based on the following rules:<list type="bullet">
        /// <item><description>If the version number does not exist in the secret, KMS creates a new version and stores the secret value.</description></item>
        /// <item><description>If the version number already exists in the secret, KMS compares the secret value in the request with the stored value. If the values are the same, the request is ignored and a success message is returned. This makes the operation idempotent. If the values are different, the request is rejected.
        /// This topic provides an example of how to store a new version of a secret value for the secret named <c>secret001</c>. The new version number (<c>VersionId</c>) is <c>v3</c> and the secret value (<c>SecretData</c>) is <c>importantdata</c>.</description></item>
        /// </list>
        /// </description></item>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stores a new version of a secret value for a generic secret.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For information about the access policy required for a RAM user or RAM role to call this OpenAPI operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>This operation supports only generic secrets. Each generic secret can have a maximum of 10 versions. If the number of versions exceeds the limit, KMS deletes the earliest version.</description></item>
        /// <item><description>By default, the new secret value is marked with ACSCurrent, and the previous version that was marked with ACSCurrent is marked with ACSPrevious. You can specify the VersionStage parameter to overwrite this default behavior.</description></item>
        /// <item><description>This operation stores a new version of a secret value. You cannot use it to modify an existing version of a secret value. You must specify a version number when you store a new version. KMS processes requests based on the following rules:<list type="bullet">
        /// <item><description>If the version number does not exist in the secret, KMS creates a new version and stores the secret value.</description></item>
        /// <item><description>If the version number already exists in the secret, KMS compares the secret value in the request with the stored value. If the values are the same, the request is ignored and a success message is returned. This makes the operation idempotent. If the values are different, the request is rejected.
        /// This topic provides an example of how to store a new version of a secret value for the secret named <c>secret001</c>. The new version number (<c>VersionId</c>) is <c>v3</c> and the secret value (<c>SecretData</c>) is <c>importantdata</c>.</description></item>
        /// </list>
        /// </description></item>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stores a new version of a secret value for a generic secret.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For information about the access policy required for a RAM user or RAM role to call this OpenAPI operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>This operation supports only generic secrets. Each generic secret can have a maximum of 10 versions. If the number of versions exceeds the limit, KMS deletes the earliest version.</description></item>
        /// <item><description>By default, the new secret value is marked with ACSCurrent, and the previous version that was marked with ACSCurrent is marked with ACSPrevious. You can specify the VersionStage parameter to overwrite this default behavior.</description></item>
        /// <item><description>This operation stores a new version of a secret value. You cannot use it to modify an existing version of a secret value. You must specify a version number when you store a new version. KMS processes requests based on the following rules:<list type="bullet">
        /// <item><description>If the version number does not exist in the secret, KMS creates a new version and stores the secret value.</description></item>
        /// <item><description>If the version number already exists in the secret, KMS compares the secret value in the request with the stored value. If the values are the same, the request is ignored and a success message is returned. This makes the operation idempotent. If the values are different, the request is rejected.
        /// This topic provides an example of how to store a new version of a secret value for the secret named <c>secret001</c>. The new version number (<c>VersionId</c>) is <c>v3</c> and the secret value (<c>SecretData</c>) is <c>importantdata</c>.</description></item>
        /// </list>
        /// </description></item>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Re-encrypts ciphertext under a different CMK without exposing the plaintext.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Notes</h3>
        /// <list type="bullet">
        /// <item><description>For more information about the access policy required to grant a RAM user or RAM role the permission to use this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>This operation is accessible only through a shared gateway, not a dedicated gateway. For more information, see <a href="https://help.aliyun.com/document_detail/601559.html">Alibaba Cloud SDK</a>.
        /// When using a shared gateway, you access KMS through an Internet or a VPC domain name. This method requires Internet access to be enabled. For more information, see <a href="https://help.aliyun.com/document_detail/2856718.html">Access keys in a KMS instance over the Internet</a>.</description></item>
        /// </list>
        /// <h3>QPS limits</h3>
        /// <para>This operation is accessible only through a shared gateway. The single-user queries per second (QPS) limit is 750. If this limit is exceeded, requests are throttled, which may affect your business. We recommend that you stay within the specified limit.</para>
        /// <h3>Details</h3>
        /// <para>You can use the ReEncrypt operation in the following scenarios:</para>
        /// <list type="bullet">
        /// <item><description>After a customer master key (CMK) is rotated, you can use the latest key version to re-encrypt data. For more information about automatic key rotation, see <a href="https://help.aliyun.com/document_detail/134270.html">Automatic key rotation</a>.</description></item>
        /// <item><description>You can re-encrypt data by changing the encryption context without changing the master key.</description></item>
        /// <item><description>You can re-encrypt data or a data key that is encrypted by one master key with another master key in KMS.
        /// The ReEncrypt operation requires the following permissions:</description></item>
        /// <item><description>The kms:ReEncryptFrom permission for the source master key.</description></item>
        /// <item><description>The kms:ReEncryptTo permission for the destination master key.</description></item>
        /// <item><description>You can use kms:ReEncrypt\* to grant both permissions.</description></item>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Re-encrypts ciphertext under a different CMK without exposing the plaintext.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Notes</h3>
        /// <list type="bullet">
        /// <item><description>For more information about the access policy required to grant a RAM user or RAM role the permission to use this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>This operation is accessible only through a shared gateway, not a dedicated gateway. For more information, see <a href="https://help.aliyun.com/document_detail/601559.html">Alibaba Cloud SDK</a>.
        /// When using a shared gateway, you access KMS through an Internet or a VPC domain name. This method requires Internet access to be enabled. For more information, see <a href="https://help.aliyun.com/document_detail/2856718.html">Access keys in a KMS instance over the Internet</a>.</description></item>
        /// </list>
        /// <h3>QPS limits</h3>
        /// <para>This operation is accessible only through a shared gateway. The single-user queries per second (QPS) limit is 750. If this limit is exceeded, requests are throttled, which may affect your business. We recommend that you stay within the specified limit.</para>
        /// <h3>Details</h3>
        /// <para>You can use the ReEncrypt operation in the following scenarios:</para>
        /// <list type="bullet">
        /// <item><description>After a customer master key (CMK) is rotated, you can use the latest key version to re-encrypt data. For more information about automatic key rotation, see <a href="https://help.aliyun.com/document_detail/134270.html">Automatic key rotation</a>.</description></item>
        /// <item><description>You can re-encrypt data by changing the encryption context without changing the master key.</description></item>
        /// <item><description>You can re-encrypt data or a data key that is encrypted by one master key with another master key in KMS.
        /// The ReEncrypt operation requires the following permissions:</description></item>
        /// <item><description>The kms:ReEncryptFrom permission for the source master key.</description></item>
        /// <item><description>The kms:ReEncryptTo permission for the destination master key.</description></item>
        /// <item><description>You can use kms:ReEncrypt\* to grant both permissions.</description></item>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Re-encrypts ciphertext under a different CMK without exposing the plaintext.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Notes</h3>
        /// <list type="bullet">
        /// <item><description>For more information about the access policy required to grant a RAM user or RAM role the permission to use this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>This operation is accessible only through a shared gateway, not a dedicated gateway. For more information, see <a href="https://help.aliyun.com/document_detail/601559.html">Alibaba Cloud SDK</a>.
        /// When using a shared gateway, you access KMS through an Internet or a VPC domain name. This method requires Internet access to be enabled. For more information, see <a href="https://help.aliyun.com/document_detail/2856718.html">Access keys in a KMS instance over the Internet</a>.</description></item>
        /// </list>
        /// <h3>QPS limits</h3>
        /// <para>This operation is accessible only through a shared gateway. The single-user queries per second (QPS) limit is 750. If this limit is exceeded, requests are throttled, which may affect your business. We recommend that you stay within the specified limit.</para>
        /// <h3>Details</h3>
        /// <para>You can use the ReEncrypt operation in the following scenarios:</para>
        /// <list type="bullet">
        /// <item><description>After a customer master key (CMK) is rotated, you can use the latest key version to re-encrypt data. For more information about automatic key rotation, see <a href="https://help.aliyun.com/document_detail/134270.html">Automatic key rotation</a>.</description></item>
        /// <item><description>You can re-encrypt data by changing the encryption context without changing the master key.</description></item>
        /// <item><description>You can re-encrypt data or a data key that is encrypted by one master key with another master key in KMS.
        /// The ReEncrypt operation requires the following permissions:</description></item>
        /// <item><description>The kms:ReEncryptFrom permission for the source master key.</description></item>
        /// <item><description>The kms:ReEncryptTo permission for the destination master key.</description></item>
        /// <item><description>You can use kms:ReEncrypt\* to grant both permissions.</description></item>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Re-encrypts ciphertext under a different CMK without exposing the plaintext.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Notes</h3>
        /// <list type="bullet">
        /// <item><description>For more information about the access policy required to grant a RAM user or RAM role the permission to use this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>This operation is accessible only through a shared gateway, not a dedicated gateway. For more information, see <a href="https://help.aliyun.com/document_detail/601559.html">Alibaba Cloud SDK</a>.
        /// When using a shared gateway, you access KMS through an Internet or a VPC domain name. This method requires Internet access to be enabled. For more information, see <a href="https://help.aliyun.com/document_detail/2856718.html">Access keys in a KMS instance over the Internet</a>.</description></item>
        /// </list>
        /// <h3>QPS limits</h3>
        /// <para>This operation is accessible only through a shared gateway. The single-user queries per second (QPS) limit is 750. If this limit is exceeded, requests are throttled, which may affect your business. We recommend that you stay within the specified limit.</para>
        /// <h3>Details</h3>
        /// <para>You can use the ReEncrypt operation in the following scenarios:</para>
        /// <list type="bullet">
        /// <item><description>After a customer master key (CMK) is rotated, you can use the latest key version to re-encrypt data. For more information about automatic key rotation, see <a href="https://help.aliyun.com/document_detail/134270.html">Automatic key rotation</a>.</description></item>
        /// <item><description>You can re-encrypt data by changing the encryption context without changing the master key.</description></item>
        /// <item><description>You can re-encrypt data or a data key that is encrypted by one master key with another master key in KMS.
        /// The ReEncrypt operation requires the following permissions:</description></item>
        /// <item><description>The kms:ReEncryptFrom permission for the source master key.</description></item>
        /// <item><description>The kms:ReEncryptTo permission for the destination master key.</description></item>
        /// <item><description>You can use kms:ReEncrypt\* to grant both permissions.</description></item>
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
        /// <para>Releases a pay-as-you-go KMS instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For information about the access policy that is required to allow a RAM user or RAM role to call this OpenAPI operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>Subscription instances cannot be manually released. You can only unsubscribe from them under specific conditions. To unsubscribe, go to the Expenses and Costs page in the console and choose Unsubscribe. For more information, see <a href="https://help.aliyun.com/document_detail/600418.html">Unsubscription policy</a>.</description></item>
        /// <item><description>After you release an instance, all resources in the instance are also released. Resources that are encrypted using keys in the instance cannot be decrypted, and credentials cannot be retrieved. Before you release an instance, make sure that no data is encrypted by the keys in the instance and no services call the credentials. This prevents service interruptions.</description></item>
        /// <item><description>If your instance is a software key management instance, we recommend that you back up the resources of the instance before you release it. The backed-up resources can be recovered. For more information, see <a href="https://help.aliyun.com/document_detail/2357488.html">Backup management</a>.</description></item>
        /// <item><description>The billing epoch is daily. Therefore, after you release a pay-as-you-go instance, the bill for the previous day is pushed before 12:00 on the next day.</description></item>
        /// <item><description>Before you release a KMS instance, we recommend that you check whether deletion protection is enabled for the instance in the console. If deletion protection is enabled, disable it in the console before you release the instance. For more information, see <a href="https://help.aliyun.com/document_detail/604735.html">Manage a KMS instance</a>.</description></item>
        /// </list>
        /// </description>
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
        /// <para>Releases a pay-as-you-go KMS instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For information about the access policy that is required to allow a RAM user or RAM role to call this OpenAPI operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>Subscription instances cannot be manually released. You can only unsubscribe from them under specific conditions. To unsubscribe, go to the Expenses and Costs page in the console and choose Unsubscribe. For more information, see <a href="https://help.aliyun.com/document_detail/600418.html">Unsubscription policy</a>.</description></item>
        /// <item><description>After you release an instance, all resources in the instance are also released. Resources that are encrypted using keys in the instance cannot be decrypted, and credentials cannot be retrieved. Before you release an instance, make sure that no data is encrypted by the keys in the instance and no services call the credentials. This prevents service interruptions.</description></item>
        /// <item><description>If your instance is a software key management instance, we recommend that you back up the resources of the instance before you release it. The backed-up resources can be recovered. For more information, see <a href="https://help.aliyun.com/document_detail/2357488.html">Backup management</a>.</description></item>
        /// <item><description>The billing epoch is daily. Therefore, after you release a pay-as-you-go instance, the bill for the previous day is pushed before 12:00 on the next day.</description></item>
        /// <item><description>Before you release a KMS instance, we recommend that you check whether deletion protection is enabled for the instance in the console. If deletion protection is enabled, disable it in the console before you release the instance. For more information, see <a href="https://help.aliyun.com/document_detail/604735.html">Manage a KMS instance</a>.</description></item>
        /// </list>
        /// </description>
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
        /// <para>Releases a pay-as-you-go KMS instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For information about the access policy that is required to allow a RAM user or RAM role to call this OpenAPI operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>Subscription instances cannot be manually released. You can only unsubscribe from them under specific conditions. To unsubscribe, go to the Expenses and Costs page in the console and choose Unsubscribe. For more information, see <a href="https://help.aliyun.com/document_detail/600418.html">Unsubscription policy</a>.</description></item>
        /// <item><description>After you release an instance, all resources in the instance are also released. Resources that are encrypted using keys in the instance cannot be decrypted, and credentials cannot be retrieved. Before you release an instance, make sure that no data is encrypted by the keys in the instance and no services call the credentials. This prevents service interruptions.</description></item>
        /// <item><description>If your instance is a software key management instance, we recommend that you back up the resources of the instance before you release it. The backed-up resources can be recovered. For more information, see <a href="https://help.aliyun.com/document_detail/2357488.html">Backup management</a>.</description></item>
        /// <item><description>The billing epoch is daily. Therefore, after you release a pay-as-you-go instance, the bill for the previous day is pushed before 12:00 on the next day.</description></item>
        /// <item><description>Before you release a KMS instance, we recommend that you check whether deletion protection is enabled for the instance in the console. If deletion protection is enabled, disable it in the console before you release the instance. For more information, see <a href="https://help.aliyun.com/document_detail/604735.html">Manage a KMS instance</a>.</description></item>
        /// </list>
        /// </description>
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
        /// <para>Releases a pay-as-you-go KMS instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For information about the access policy that is required to allow a RAM user or RAM role to call this OpenAPI operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>Subscription instances cannot be manually released. You can only unsubscribe from them under specific conditions. To unsubscribe, go to the Expenses and Costs page in the console and choose Unsubscribe. For more information, see <a href="https://help.aliyun.com/document_detail/600418.html">Unsubscription policy</a>.</description></item>
        /// <item><description>After you release an instance, all resources in the instance are also released. Resources that are encrypted using keys in the instance cannot be decrypted, and credentials cannot be retrieved. Before you release an instance, make sure that no data is encrypted by the keys in the instance and no services call the credentials. This prevents service interruptions.</description></item>
        /// <item><description>If your instance is a software key management instance, we recommend that you back up the resources of the instance before you release it. The backed-up resources can be recovered. For more information, see <a href="https://help.aliyun.com/document_detail/2357488.html">Backup management</a>.</description></item>
        /// <item><description>The billing epoch is daily. Therefore, after you release a pay-as-you-go instance, the bill for the previous day is pushed before 12:00 on the next day.</description></item>
        /// <item><description>Before you release a KMS instance, we recommend that you check whether deletion protection is enabled for the instance in the console. If deletion protection is enabled, disable it in the console before you release the instance. For more information, see <a href="https://help.aliyun.com/document_detail/604735.html">Manage a KMS instance</a>.</description></item>
        /// </list>
        /// </description>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Restores a deleted secret.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Restores a deleted secret.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Restores a deleted secret.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Restores a deleted secret.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Immediately rotates a secret.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Limits:
        /// • A secret of each Alibaba Cloud account can be rotated for a maximum of 50 times per hour.
        /// • The RotateSecret operation is unavailable for standard secrets.
        /// In this example, the <c>RdsSecret/Mysql5.4/MyCred</c> secret is manually rotated, and the version number of the secret is set to <c>000000123</c> after the secret is rotated.
        /// For more information about the access policy required by a RAM user or RAM role to call this API, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Immediately rotates a secret.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Limits:
        /// • A secret of each Alibaba Cloud account can be rotated for a maximum of 50 times per hour.
        /// • The RotateSecret operation is unavailable for standard secrets.
        /// In this example, the <c>RdsSecret/Mysql5.4/MyCred</c> secret is manually rotated, and the version number of the secret is set to <c>000000123</c> after the secret is rotated.
        /// For more information about the access policy required by a RAM user or RAM role to call this API, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Immediately rotates a secret.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Limits:
        /// • A secret of each Alibaba Cloud account can be rotated for a maximum of 50 times per hour.
        /// • The RotateSecret operation is unavailable for standard secrets.
        /// In this example, the <c>RdsSecret/Mysql5.4/MyCred</c> secret is manually rotated, and the version number of the secret is set to <c>000000123</c> after the secret is rotated.
        /// For more information about the access policy required by a RAM user or RAM role to call this API, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Immediately rotates a secret.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Limits:
        /// • A secret of each Alibaba Cloud account can be rotated for a maximum of 50 times per hour.
        /// • The RotateSecret operation is unavailable for standard secrets.
        /// In this example, the <c>RdsSecret/Mysql5.4/MyCred</c> secret is manually rotated, and the version number of the secret is set to <c>000000123</c> after the secret is rotated.
        /// For more information about the access policy required by a RAM user or RAM role to call this API, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a specified customer master key (CMK).</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a specified customer master key (CMK).</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a specified customer master key (CMK).</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a specified customer master key (CMK).</para>
        /// </summary>
        /// 
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
        /// <list type="bullet">
        /// <item><description>For details about the access policy that must be granted to a Resource Access Management (RAM) user or RAM role to invoke this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Access control</a>.</description></item>
        /// <item><description>After you enable deletion protection for a CMK, you cannot delete the CMK. To delete the CMK, disable deletion protection first.  </description></item>
        /// <item><description>Before you invoke the SetDeletionProtection operation, make sure that the CMK is not in the PendingDeletion state. You can invoke the <a href="https://help.aliyun.com/document_detail/28952.html">DescribeKey</a> operation to query the status (KeyState) of the CMK.</description></item>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KmsInstanceId))
            {
                query["KmsInstanceId"] = request.KmsInstanceId;
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
        /// <list type="bullet">
        /// <item><description>For details about the access policy that must be granted to a Resource Access Management (RAM) user or RAM role to invoke this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Access control</a>.</description></item>
        /// <item><description>After you enable deletion protection for a CMK, you cannot delete the CMK. To delete the CMK, disable deletion protection first.  </description></item>
        /// <item><description>Before you invoke the SetDeletionProtection operation, make sure that the CMK is not in the PendingDeletion state. You can invoke the <a href="https://help.aliyun.com/document_detail/28952.html">DescribeKey</a> operation to query the status (KeyState) of the CMK.</description></item>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KmsInstanceId))
            {
                query["KmsInstanceId"] = request.KmsInstanceId;
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
        /// <list type="bullet">
        /// <item><description>For details about the access policy that must be granted to a Resource Access Management (RAM) user or RAM role to invoke this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Access control</a>.</description></item>
        /// <item><description>After you enable deletion protection for a CMK, you cannot delete the CMK. To delete the CMK, disable deletion protection first.  </description></item>
        /// <item><description>Before you invoke the SetDeletionProtection operation, make sure that the CMK is not in the PendingDeletion state. You can invoke the <a href="https://help.aliyun.com/document_detail/28952.html">DescribeKey</a> operation to query the status (KeyState) of the CMK.</description></item>
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
        /// <list type="bullet">
        /// <item><description>For details about the access policy that must be granted to a Resource Access Management (RAM) user or RAM role to invoke this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Access control</a>.</description></item>
        /// <item><description>After you enable deletion protection for a CMK, you cannot delete the CMK. To delete the CMK, disable deletion protection first.  </description></item>
        /// <item><description>Before you invoke the SetDeletionProtection operation, make sure that the CMK is not in the PendingDeletion state. You can invoke the <a href="https://help.aliyun.com/document_detail/28952.html">DescribeKey</a> operation to query the status (KeyState) of the CMK.</description></item>
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
        /// <para>Sets the key policy for a CMK in a KMS instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For information about the access policy required for a RAM user or RAM role to call this API operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>For more information about key policies, see <a href="https://help.aliyun.com/document_detail/2716468.html">Key policy overview</a>.</description></item>
        /// </list>
        /// </description>
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
        /// <para>Sets the key policy for a CMK in a KMS instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For information about the access policy required for a RAM user or RAM role to call this API operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>For more information about key policies, see <a href="https://help.aliyun.com/document_detail/2716468.html">Key policy overview</a>.</description></item>
        /// </list>
        /// </description>
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
        /// <para>Sets the key policy for a CMK in a KMS instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For information about the access policy required for a RAM user or RAM role to call this API operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>For more information about key policies, see <a href="https://help.aliyun.com/document_detail/2716468.html">Key policy overview</a>.</description></item>
        /// </list>
        /// </description>
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
        /// <para>Sets the key policy for a CMK in a KMS instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For information about the access policy required for a RAM user or RAM role to call this API operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>For more information about key policies, see <a href="https://help.aliyun.com/document_detail/2716468.html">Key policy overview</a>.</description></item>
        /// </list>
        /// </description>
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
        /// <para>Sets the access policy for a secret in a KMS instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For information about the access policy that a RAM user or RAM role requires to call this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>For more information about secret policies, see <a href="https://help.aliyun.com/document_detail/2716465.html">Secret policy overview</a>.</description></item>
        /// </list>
        /// </description>
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
        /// <para>Sets the access policy for a secret in a KMS instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For information about the access policy that a RAM user or RAM role requires to call this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>For more information about secret policies, see <a href="https://help.aliyun.com/document_detail/2716465.html">Secret policy overview</a>.</description></item>
        /// </list>
        /// </description>
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
        /// <para>Sets the access policy for a secret in a KMS instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For information about the access policy that a RAM user or RAM role requires to call this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>For more information about secret policies, see <a href="https://help.aliyun.com/document_detail/2716465.html">Secret policy overview</a>.</description></item>
        /// </list>
        /// </description>
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
        /// <para>Sets the access policy for a secret in a KMS instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For information about the access policy that a RAM user or RAM role requires to call this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>For more information about secret policies, see <a href="https://help.aliyun.com/document_detail/2716465.html">Secret policy overview</a>.</description></item>
        /// </list>
        /// </description>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds tags to a CMK, secret, or certificate.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can add up to 10 tags to a CMK, secret, or certificate.
        /// In this example, the tags <c>[{&quot;TagKey&quot;:&quot;S1key1&quot;,&quot;TagValue&quot;:&quot;S1val1&quot;},{&quot;TagKey&quot;:&quot;S1key2&quot;,&quot;TagValue&quot;:&quot;S2val2&quot;}]</c> are added to the CMK whose ID is <c>08c33a6f-4e0a-4a1b-a3fa-7ddf****</c>.
        /// For more information about the access policy required by a RAM user or RAM role to call this API, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds tags to a CMK, secret, or certificate.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can add up to 10 tags to a CMK, secret, or certificate.
        /// In this example, the tags <c>[{&quot;TagKey&quot;:&quot;S1key1&quot;,&quot;TagValue&quot;:&quot;S1val1&quot;},{&quot;TagKey&quot;:&quot;S1key2&quot;,&quot;TagValue&quot;:&quot;S2val2&quot;}]</c> are added to the CMK whose ID is <c>08c33a6f-4e0a-4a1b-a3fa-7ddf****</c>.
        /// For more information about the access policy required by a RAM user or RAM role to call this API, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds tags to a CMK, secret, or certificate.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can add up to 10 tags to a CMK, secret, or certificate.
        /// In this example, the tags <c>[{&quot;TagKey&quot;:&quot;S1key1&quot;,&quot;TagValue&quot;:&quot;S1val1&quot;},{&quot;TagKey&quot;:&quot;S1key2&quot;,&quot;TagValue&quot;:&quot;S2val2&quot;}]</c> are added to the CMK whose ID is <c>08c33a6f-4e0a-4a1b-a3fa-7ddf****</c>.
        /// For more information about the access policy required by a RAM user or RAM role to call this API, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds tags to a CMK, secret, or certificate.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can add up to 10 tags to a CMK, secret, or certificate.
        /// In this example, the tags <c>[{&quot;TagKey&quot;:&quot;S1key1&quot;,&quot;TagValue&quot;:&quot;S1val1&quot;},{&quot;TagKey&quot;:&quot;S1key2&quot;,&quot;TagValue&quot;:&quot;S2val2&quot;}]</c> are added to the CMK whose ID is <c>08c33a6f-4e0a-4a1b-a3fa-7ddf****</c>.
        /// For more information about the access policy required by a RAM user or RAM role to call this API, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
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
        /// <para>Adds tags to one or more keys or secrets.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can add multiple tags to multiple keys or multiple secrets at a time.
        /// For more information about the access policy required by a RAM user or RAM role to call this API, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
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
        /// <para>Adds tags to one or more keys or secrets.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can add multiple tags to multiple keys or multiple secrets at a time.
        /// For more information about the access policy required by a RAM user or RAM role to call this API, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
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
        /// <para>Adds tags to one or more keys or secrets.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can add multiple tags to multiple keys or multiple secrets at a time.
        /// For more information about the access policy required by a RAM user or RAM role to call this API, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
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
        /// <para>Adds tags to one or more keys or secrets.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can add multiple tags to multiple keys or multiple secrets at a time.
        /// For more information about the access policy required by a RAM user or RAM role to call this API, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes tags from a CMK, secret, or certificate.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For information about the access policy that is required for a RAM user or RAM role to call this OpenAPI operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.
        /// This topic provides an example of how to detach tags with the tag keys tagkey1 and tagkey2 from the key with the ID <c>08c33a6f-4e0a-4a1b-a3fa-7ddf****</c>.</para>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes tags from a CMK, secret, or certificate.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For information about the access policy that is required for a RAM user or RAM role to call this OpenAPI operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.
        /// This topic provides an example of how to detach tags with the tag keys tagkey1 and tagkey2 from the key with the ID <c>08c33a6f-4e0a-4a1b-a3fa-7ddf****</c>.</para>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes tags from a CMK, secret, or certificate.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For information about the access policy that is required for a RAM user or RAM role to call this OpenAPI operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.
        /// This topic provides an example of how to detach tags with the tag keys tagkey1 and tagkey2 from the key with the ID <c>08c33a6f-4e0a-4a1b-a3fa-7ddf****</c>.</para>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes tags from a CMK, secret, or certificate.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For information about the access policy that is required for a RAM user or RAM role to call this OpenAPI operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.
        /// This topic provides an example of how to detach tags with the tag keys tagkey1 and tagkey2 from the key with the ID <c>08c33a6f-4e0a-4a1b-a3fa-7ddf****</c>.</para>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Binds an existing alias to a different customer master key (CMK) ID.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Binds an existing alias to a different customer master key (CMK) ID.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Binds an existing alias to a different customer master key (CMK) ID.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Binds an existing alias to a different customer master key (CMK) ID.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the information about an application access point (AAP).</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the information about an application access point (AAP).</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the information about an application access point (AAP).</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the information about an application access point (AAP).</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the description of a CMK.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation replaces the description of a customer master key (CMK) with the description that you specify. The original description of the CMK is specified by the Description parameter when you call the <a href="https://help.aliyun.com/document_detail/28952.html">DescribeKey</a> operation. Use this operation to add, modify, or delete the description of a CMK.
        /// For more information about the access policy required for a RAM user or RAM role to call this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
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
        /// <para>Updates the description of a CMK.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation replaces the description of a customer master key (CMK) with the description that you specify. The original description of the CMK is specified by the Description parameter when you call the <a href="https://help.aliyun.com/document_detail/28952.html">DescribeKey</a> operation. Use this operation to add, modify, or delete the description of a CMK.
        /// For more information about the access policy required for a RAM user or RAM role to call this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
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
        /// <para>Updates the description of a CMK.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation replaces the description of a customer master key (CMK) with the description that you specify. The original description of the CMK is specified by the Description parameter when you call the <a href="https://help.aliyun.com/document_detail/28952.html">DescribeKey</a> operation. Use this operation to add, modify, or delete the description of a CMK.
        /// For more information about the access policy required for a RAM user or RAM role to call this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
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
        /// <para>Updates the description of a CMK.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation replaces the description of a customer master key (CMK) with the description that you specify. The original description of the CMK is specified by the Description parameter when you call the <a href="https://help.aliyun.com/document_detail/28952.html">DescribeKey</a> operation. Use this operation to add, modify, or delete the description of a CMK.
        /// For more information about the access policy required for a RAM user or RAM role to call this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</para>
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
        /// <para>Updates the VPC bindings of a KMS instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For information about the access policy required for a Resource Access Management (RAM) user or RAM role to call this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>If your self-managed application is deployed in multiple VPCs in the same region, you can bind the KMS instance to additional VPCs. These VPCs are in addition to the one that you specified when you enabled the instance.
        /// These VPCs can belong to the same Alibaba Cloud account or different Alibaba Cloud accounts. After the configuration is complete, self-managed applications in these VPCs can access the specified KMS instance.<remarks>
        /// <para>If the VPCs belong to different Alibaba Cloud accounts, you must first configure resource sharing to share the vSwitch resources from those accounts with the Alibaba Cloud account that owns the KMS instance. For more information, see <a href="https://help.aliyun.com/document_detail/2393236.html">Access a KMS instance from multiple VPCs in the same region</a>.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
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
        /// <para>Updates the VPC bindings of a KMS instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For information about the access policy required for a Resource Access Management (RAM) user or RAM role to call this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>If your self-managed application is deployed in multiple VPCs in the same region, you can bind the KMS instance to additional VPCs. These VPCs are in addition to the one that you specified when you enabled the instance.
        /// These VPCs can belong to the same Alibaba Cloud account or different Alibaba Cloud accounts. After the configuration is complete, self-managed applications in these VPCs can access the specified KMS instance.<remarks>
        /// <para>If the VPCs belong to different Alibaba Cloud accounts, you must first configure resource sharing to share the vSwitch resources from those accounts with the Alibaba Cloud account that owns the KMS instance. For more information, see <a href="https://help.aliyun.com/document_detail/2393236.html">Access a KMS instance from multiple VPCs in the same region</a>.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
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
        /// <para>Updates the VPC bindings of a KMS instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For information about the access policy required for a Resource Access Management (RAM) user or RAM role to call this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>If your self-managed application is deployed in multiple VPCs in the same region, you can bind the KMS instance to additional VPCs. These VPCs are in addition to the one that you specified when you enabled the instance.
        /// These VPCs can belong to the same Alibaba Cloud account or different Alibaba Cloud accounts. After the configuration is complete, self-managed applications in these VPCs can access the specified KMS instance.<remarks>
        /// <para>If the VPCs belong to different Alibaba Cloud accounts, you must first configure resource sharing to share the vSwitch resources from those accounts with the Alibaba Cloud account that owns the KMS instance. For more information, see <a href="https://help.aliyun.com/document_detail/2393236.html">Access a KMS instance from multiple VPCs in the same region</a>.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
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
        /// <para>Updates the VPC bindings of a KMS instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For information about the access policy required for a Resource Access Management (RAM) user or RAM role to call this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>If your self-managed application is deployed in multiple VPCs in the same region, you can bind the KMS instance to additional VPCs. These VPCs are in addition to the one that you specified when you enabled the instance.
        /// These VPCs can belong to the same Alibaba Cloud account or different Alibaba Cloud accounts. After the configuration is complete, self-managed applications in these VPCs can access the specified KMS instance.<remarks>
        /// <para>If the VPCs belong to different Alibaba Cloud accounts, you must first configure resource sharing to share the vSwitch resources from those accounts with the Alibaba Cloud account that owns the KMS instance. For more information, see <a href="https://help.aliyun.com/document_detail/2393236.html">Access a KMS instance from multiple VPCs in the same region</a>.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
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
        /// <para>Updates a network access rule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For more information about the access policy required for a Resource Access Management (RAM) user or RAM role to call this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Access control</a>.</description></item>
        /// <item><description>You can only modify the private IP addresses and description of a network control rule. The name and network type cannot be modified.</description></item>
        /// <item><description>When you update a network control rule, the access policies attached to it are also updated. Proceed with caution.</description></item>
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
        /// <para>Updates a network access rule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For more information about the access policy required for a Resource Access Management (RAM) user or RAM role to call this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Access control</a>.</description></item>
        /// <item><description>You can only modify the private IP addresses and description of a network control rule. The name and network type cannot be modified.</description></item>
        /// <item><description>When you update a network control rule, the access policies attached to it are also updated. Proceed with caution.</description></item>
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
        /// <para>Updates a network access rule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For more information about the access policy required for a Resource Access Management (RAM) user or RAM role to call this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Access control</a>.</description></item>
        /// <item><description>You can only modify the private IP addresses and description of a network control rule. The name and network type cannot be modified.</description></item>
        /// <item><description>When you update a network control rule, the access policies attached to it are also updated. Proceed with caution.</description></item>
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
        /// <para>Updates a network access rule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For more information about the access policy required for a Resource Access Management (RAM) user or RAM role to call this operation, see <a href="https://help.aliyun.com/document_detail/2767210.html">Access control</a>.</description></item>
        /// <item><description>You can only modify the private IP addresses and description of a network control rule. The name and network type cannot be modified.</description></item>
        /// <item><description>When you update a network control rule, the access policies attached to it are also updated. Proceed with caution.</description></item>
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
        /// <para>Updates a permission policy.</para>
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
        /// <para>Updates a permission policy.</para>
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
        /// <para>Updates a permission policy.</para>
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
        /// <para>Updates a permission policy.</para>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the automatic rotation policy of a CMK.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When automatic key rotation is enabled, KMS automatically creates a key version after the preset rotation period arrives. In addition, KMS sets the new key version as the primary key version.
        /// An automatic key rotation policy cannot be configured for the following keys:</para>
        /// <list type="bullet">
        /// <item><description>Asymmetric key</description></item>
        /// <item><description>Service-managed key</description></item>
        /// <item><description>Bring your own key (BYOK) that is imported into KMS</description></item>
        /// <item><description>Key that is not in the <b>Enabled</b> state
        /// In this example, automatic key rotation is enabled for a CMK whose ID is <c>1234abcd-12ab-34cd-56ef-12345678****</c>. The automatic rotation period is 30 days.
        /// For more information about the access policy required by a RAM user or RAM role to call this API, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the automatic rotation policy of a CMK.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When automatic key rotation is enabled, KMS automatically creates a key version after the preset rotation period arrives. In addition, KMS sets the new key version as the primary key version.
        /// An automatic key rotation policy cannot be configured for the following keys:</para>
        /// <list type="bullet">
        /// <item><description>Asymmetric key</description></item>
        /// <item><description>Service-managed key</description></item>
        /// <item><description>Bring your own key (BYOK) that is imported into KMS</description></item>
        /// <item><description>Key that is not in the <b>Enabled</b> state
        /// In this example, automatic key rotation is enabled for a CMK whose ID is <c>1234abcd-12ab-34cd-56ef-12345678****</c>. The automatic rotation period is 30 days.
        /// For more information about the access policy required by a RAM user or RAM role to call this API, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the automatic rotation policy of a CMK.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When automatic key rotation is enabled, KMS automatically creates a key version after the preset rotation period arrives. In addition, KMS sets the new key version as the primary key version.
        /// An automatic key rotation policy cannot be configured for the following keys:</para>
        /// <list type="bullet">
        /// <item><description>Asymmetric key</description></item>
        /// <item><description>Service-managed key</description></item>
        /// <item><description>Bring your own key (BYOK) that is imported into KMS</description></item>
        /// <item><description>Key that is not in the <b>Enabled</b> state
        /// In this example, automatic key rotation is enabled for a CMK whose ID is <c>1234abcd-12ab-34cd-56ef-12345678****</c>. The automatic rotation period is 30 days.
        /// For more information about the access policy required by a RAM user or RAM role to call this API, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the automatic rotation policy of a CMK.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When automatic key rotation is enabled, KMS automatically creates a key version after the preset rotation period arrives. In addition, KMS sets the new key version as the primary key version.
        /// An automatic key rotation policy cannot be configured for the following keys:</para>
        /// <list type="bullet">
        /// <item><description>Asymmetric key</description></item>
        /// <item><description>Service-managed key</description></item>
        /// <item><description>Bring your own key (BYOK) that is imported into KMS</description></item>
        /// <item><description>Key that is not in the <b>Enabled</b> state
        /// In this example, automatic key rotation is enabled for a CMK whose ID is <c>1234abcd-12ab-34cd-56ef-12345678****</c>. The automatic rotation period is 30 days.
        /// For more information about the access policy required by a RAM user or RAM role to call this API, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the rotation policy of a secret.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the rotation policy of a secret.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the rotation policy of a secret.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the rotation policy of a secret.</para>
        /// </summary>
        /// 
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
        /// <para>Moves a version stage label to a different version of a secret.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For more information about the access policy that is required to call this operation as a Resource Access Management (RAM) user or RAM role, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>This operation supports only generic secrets. You can perform the following operations:<list type="bullet">
        /// <item><description>Add a version stage to a specified secret version.</description></item>
        /// <item><description>Remove a version stage from a specified secret version.</description></item>
        /// <item><description>Remove a version stage from a specified secret version and attach it to another secret version.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>The total number of version stages for each generic secret cannot exceed 8.
        /// This topic provides an example of how to update the version stage of the secret named <c>secret001</c>. In this example, the <c>ACSCurrent</c> stage is used to mark version <c>002</c>.</description></item>
        /// </list>
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
        /// <para>Moves a version stage label to a different version of a secret.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For more information about the access policy that is required to call this operation as a Resource Access Management (RAM) user or RAM role, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>This operation supports only generic secrets. You can perform the following operations:<list type="bullet">
        /// <item><description>Add a version stage to a specified secret version.</description></item>
        /// <item><description>Remove a version stage from a specified secret version.</description></item>
        /// <item><description>Remove a version stage from a specified secret version and attach it to another secret version.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>The total number of version stages for each generic secret cannot exceed 8.
        /// This topic provides an example of how to update the version stage of the secret named <c>secret001</c>. In this example, the <c>ACSCurrent</c> stage is used to mark version <c>002</c>.</description></item>
        /// </list>
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
        /// <para>Moves a version stage label to a different version of a secret.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For more information about the access policy that is required to call this operation as a Resource Access Management (RAM) user or RAM role, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>This operation supports only generic secrets. You can perform the following operations:<list type="bullet">
        /// <item><description>Add a version stage to a specified secret version.</description></item>
        /// <item><description>Remove a version stage from a specified secret version.</description></item>
        /// <item><description>Remove a version stage from a specified secret version and attach it to another secret version.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>The total number of version stages for each generic secret cannot exceed 8.
        /// This topic provides an example of how to update the version stage of the secret named <c>secret001</c>. In this example, the <c>ACSCurrent</c> stage is used to mark version <c>002</c>.</description></item>
        /// </list>
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
        /// <para>Moves a version stage label to a different version of a secret.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>For more information about the access policy that is required to call this operation as a Resource Access Management (RAM) user or RAM role, see <a href="https://help.aliyun.com/document_detail/2767210.html">Resource Access Management</a>.</description></item>
        /// <item><description>This operation supports only generic secrets. You can perform the following operations:<list type="bullet">
        /// <item><description>Add a version stage to a specified secret version.</description></item>
        /// <item><description>Remove a version stage from a specified secret version.</description></item>
        /// <item><description>Remove a version stage from a specified secret version and attach it to another secret version.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>The total number of version stages for each generic secret cannot exceed 8.
        /// This topic provides an example of how to update the version stage of the secret named <c>secret001</c>. In this example, the <c>ACSCurrent</c> stage is used to mark version <c>002</c>.</description></item>
        /// </list>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Verifies the HMAC message authentication code of a specific message by using a specified key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For details about the access policy required when a RAM user or RAM role invokes this operation, refer to access control.
        /// This operation can be invoked through a shared gateway or a dedicated gateway. For more information, refer to Alibaba Cloud SDK.</para>
        /// <list type="bullet">
        /// <item><description>Shared gateway: Access KMS through a public or VPC endpoint. This method requires you to enable the public network access switch. For more information, refer to accessing keys in a KMS instance over the Internet.</description></item>
        /// <item><description>Dedicated gateway: Access KMS through a KMS private endpoint (<YOUR_KMS_INSTANCE_ID>.cryptoservice.kms.aliyuncs.com).</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// VerifyMacRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// VerifyMacResponse
        /// </returns>
        public VerifyMacResponse VerifyMacWithOptions(VerifyMacRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mac))
            {
                query["Mac"] = request.Mac;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                query["Message"] = request.Message;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VerifyMac",
                Version = "2016-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VerifyMacResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Verifies the HMAC message authentication code of a specific message by using a specified key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For details about the access policy required when a RAM user or RAM role invokes this operation, refer to access control.
        /// This operation can be invoked through a shared gateway or a dedicated gateway. For more information, refer to Alibaba Cloud SDK.</para>
        /// <list type="bullet">
        /// <item><description>Shared gateway: Access KMS through a public or VPC endpoint. This method requires you to enable the public network access switch. For more information, refer to accessing keys in a KMS instance over the Internet.</description></item>
        /// <item><description>Dedicated gateway: Access KMS through a KMS private endpoint (<YOUR_KMS_INSTANCE_ID>.cryptoservice.kms.aliyuncs.com).</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// VerifyMacRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// VerifyMacResponse
        /// </returns>
        public async Task<VerifyMacResponse> VerifyMacWithOptionsAsync(VerifyMacRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mac))
            {
                query["Mac"] = request.Mac;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                query["Message"] = request.Message;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VerifyMac",
                Version = "2016-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VerifyMacResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Verifies the HMAC message authentication code of a specific message by using a specified key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For details about the access policy required when a RAM user or RAM role invokes this operation, refer to access control.
        /// This operation can be invoked through a shared gateway or a dedicated gateway. For more information, refer to Alibaba Cloud SDK.</para>
        /// <list type="bullet">
        /// <item><description>Shared gateway: Access KMS through a public or VPC endpoint. This method requires you to enable the public network access switch. For more information, refer to accessing keys in a KMS instance over the Internet.</description></item>
        /// <item><description>Dedicated gateway: Access KMS through a KMS private endpoint (<YOUR_KMS_INSTANCE_ID>.cryptoservice.kms.aliyuncs.com).</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// VerifyMacRequest
        /// </param>
        /// 
        /// <returns>
        /// VerifyMacResponse
        /// </returns>
        public VerifyMacResponse VerifyMac(VerifyMacRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VerifyMacWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Verifies the HMAC message authentication code of a specific message by using a specified key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For details about the access policy required when a RAM user or RAM role invokes this operation, refer to access control.
        /// This operation can be invoked through a shared gateway or a dedicated gateway. For more information, refer to Alibaba Cloud SDK.</para>
        /// <list type="bullet">
        /// <item><description>Shared gateway: Access KMS through a public or VPC endpoint. This method requires you to enable the public network access switch. For more information, refer to accessing keys in a KMS instance over the Internet.</description></item>
        /// <item><description>Dedicated gateway: Access KMS through a KMS private endpoint (<YOUR_KMS_INSTANCE_ID>.cryptoservice.kms.aliyuncs.com).</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// VerifyMacRequest
        /// </param>
        /// 
        /// <returns>
        /// VerifyMacResponse
        /// </returns>
        public async Task<VerifyMacResponse> VerifyMacAsync(VerifyMacRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VerifyMacWithOptionsAsync(request, runtime);
        }

    }
}
