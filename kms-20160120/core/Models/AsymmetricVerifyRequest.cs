// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class AsymmetricVerifyRequest : TeaModel {
        /// <summary>
        /// <para>The signature algorithm.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RSA_PSS_SHA_256</para>
        /// </summary>
        [NameInMap("Algorithm")]
        [Validation(Required=false)]
        public string Algorithm { get; set; }

        /// <summary>
        /// <para>The digest that is generated using the hash algorithm that corresponds to the value of <b>Algorithm</b> to hash the original message.</para>
        /// <remarks>
        /// <para>The value is Base64-encoded.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ZOyIygCyaOW6GjVnihtTFtIS9PNmskdyMlNKiuy****=</para>
        /// </summary>
        [NameInMap("Digest")]
        [Validation(Required=false)]
        public string Digest { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run.</para>
        /// <list type="bullet">
        /// <item><description><para>true: performs a dry run.</para>
        /// </description></item>
        /// <item><description><para>false (default): does not perform a dry run.</para>
        /// </description></item>
        /// </list>
        /// <para>A dry run is used to test API calls and verify whether you have the permissions to access the specified resources and whether the request parameters are valid. If you perform a dry run, KMS always returns a failure response that indicates the cause of the failure. The following failure causes are included:</para>
        /// <list type="bullet">
        /// <item><description><para>DryRunOperationError: The request would have succeeded if the DryRun parameter is not specified.</para>
        /// </description></item>
        /// <item><description><para>ValidationError: The specified parameters in the request are invalid.</para>
        /// </description></item>
        /// <item><description><para>AccessDeniedError: You are not authorized to perform this operation on the KMS resource.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public string DryRun { get; set; }

        /// <summary>
        /// <para>The globally unique identifier (GUID) of the customer master key (CMK).</para>
        /// <remarks>
        /// <para>You can also specify the alias that is bound to the CMK. For more information, see <a href="https://help.aliyun.com/document_detail/68522.html">Overview of aliases</a>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5c438b18-05be-40ad-b6c2-3be6752c****</para>
        /// </summary>
        [NameInMap("KeyId")]
        [Validation(Required=false)]
        public string KeyId { get; set; }

        /// <summary>
        /// <para>The ID of the key version. The ID must be the GUID of the key version.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2ab1a983-7072-4bbc-a582-584b5bd8****</para>
        /// </summary>
        [NameInMap("KeyVersionId")]
        [Validation(Required=false)]
        public string KeyVersionId { get; set; }

        /// <summary>
        /// <para>The signature value to be verified.</para>
        /// <remarks>
        /// <para>The value is Base64-encoded.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>M2CceNZH00ZgL9ED/ZHFp21YRAvYeZHknJUc207OCZ0N9wNn9As4z2bON3FF3je+1Nu+2+/8Zj50HpMTpzYpMp2R93cYmACCmhaYoKydxylbyGzJR8y9likZRCrkD38lRoS40aBBvv/6iRKzQuo9EGYVcel36cMNg00VmYNBy3pa1rwg3gA4l3cy6kjayZja1WGPkVhrVKsrJMdbpl0ApLjXKuD8rw1n1XLCwCUEL5eLPljTZaAveqdOFQOiZnZEGI27qIiZe7I1fN8tcz6anS/gTM7xRKE++5egEvRWlTQQTJeApnPSiUPA+8ZykNdelQsOQh5SrGoyI4A5pq****==</para>
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
