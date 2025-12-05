// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class AsymmetricSignResponseBody : TeaModel {
        /// <summary>
        /// <para>The version ID of the CMK. The ID must be globally unique.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5c438b18-05be-40ad-b6c2-3be6752c****</para>
        /// </summary>
        [NameInMap("KeyId")]
        [Validation(Required=false)]
        public string KeyId { get; set; }

        /// <summary>
        /// <para>The digest that is generated for the original message by using a hash algorithm. The hash algorithm is specified by the Algorithm parameter.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The value is encoded in Base64.</description></item>
        /// <item><description>For more information about how to calculate message digests, see the <b>Preprocess signature: compute a message digest</b> section of the <a href="https://help.aliyun.com/document_detail/148146.html">Generate and verify a signature by using an asymmetric CMK</a> topic.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2ab1a983-7072-4bbc-a582-584b5bd8****</para>
        /// </summary>
        [NameInMap("KeyVersionId")]
        [Validation(Required=false)]
        public string KeyVersionId { get; set; }

        /// <summary>
        /// <para>The calculated signature.</para>
        /// <remarks>
        /// <para> The value is encoded in Base64.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>475f1620-b9d3-4d35-b5c6-3fbdd941423d</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the CMK. The ID must be globally unique.</para>
        /// <remarks>
        /// <para> If you set the KeyId parameter in the request to an alias, the ID of the CMK to which the alias is bound is returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>M2CceNZH00ZgL9ED/ZHFp21YRAvYeZHknJUc207OCZ0N9wNn9As4z2bON3FF3je+1Nu+2+/8Zj50HpMTpzYpMp2R93cYmACCmhaYoKydxylbyGzJR8y9likZRCrkD38lRoS40aBBvv/6iRKzQuo9EGYVcel36cMNg00VmYNBy3pa1rwg3gA4l3cy6kjayZja1WGPkVhrVKsrJMdbpl0ApLjXKuD8rw1n1XLCwCUEL5eLPljTZaAveqdOFQOiZnZEGI27qIiZe7I1fN8tcz6anS/gTM7xRKE++5egEvRWlTQQTJeApnPSiUPA+8ZykNdelQsOQh5SrGoyI4A5pq****==</para>
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
