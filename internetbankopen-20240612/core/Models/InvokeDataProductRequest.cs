// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.InternetBankOpen20240612.Models
{
    public class InvokeDataProductRequest : TeaModel {
        /// <summary>
        /// <para>The customer transaction serial number, used for idempotence. This parameter is required for business purposes. If it is missing, a MissingParameter.ClientToken error is returned. Only 1 to 64 ASCII letters, digits, periods (.), underscores (_), or hyphens (-) are allowed. It is case-sensitive and leading and trailing spaces are not trimmed. If the format is invalid, an InvalidParameter.ClientToken error is returned. The ClientToken is globally unique under the same Alibaba Cloud account, regardless of the product. When you retry with the same parameters, the result of the initial call and the original CallId are returned, and the data service provider is not called again. If the initial request is still being processed, a RequestInProgress error (HTTP 409) is returned. Retry with the original parameters later. If the same ClientToken is used with a different ProductCode or ServiceParameters, an IdempotentParameterMismatch error is returned. Use a new serial number. If the result is not obtained due to a network interruption, retry with the original ClientToken and do not change the serial number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a1b2c3d4-5e6f-7a8b-9c0d-1e2f3a4b5c6d</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The commodity code of the data product, used to identify the data product invoked in this call. The gateway uses this code to complete product authorization and route the request to the corresponding data service provider. This parameter is required for business purposes. If it is missing, a MissingParameter.ProductCode error is returned. If the code is not registered or has been deactivated, an InvalidParameter.ProductCode error is returned. If the current account has not activated the product, a Forbidden.ProductNotAuthorized error is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cloudsec.demo.v1</para>
        /// </summary>
        [NameInMap("productCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The complete package of business elements, which must be a JSON object serialized as a string. It carries the business parameters required for this data product call. This parameter is required for business purposes. If it is missing, a MissingParameter.ServiceParameters error is returned. For sensitive information such as mobile phone numbers and ID card numbers, only digests are passed, and plaintext is not allowed. If plaintext fields such as mobile or certNo are passed, an InvalidParameter.ServiceParameters error is returned. Fields ending with Sha256 must be 64-character hexadecimal strings, and fields ending with Md5 must be 32-character hexadecimal strings. Uppercase letters are automatically converted to lowercase. The specific required elements are determined by the product corresponding to the ProductCode. For example, some products require at least one of mobileSha256 and mobileMd5. If required elements are missing, the JSON is invalid, or the digest format is incorrect, an InvalidParameter.ServiceParameters error is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;mobileMd5&quot;:&quot;25f9e794323b453885f5181f1b624d0b&quot;,&quot;certNoSha256&quot;:&quot;a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3&quot;}</para>
        /// </summary>
        [NameInMap("serviceParameters")]
        [Validation(Required=false)]
        public string ServiceParameters { get; set; }

    }

}
