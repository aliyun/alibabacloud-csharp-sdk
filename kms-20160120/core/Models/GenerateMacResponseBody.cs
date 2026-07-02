// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class GenerateMacResponseBody : TeaModel {
        /// <summary>
        /// <para>The algorithm that is used to generate the message authentication code. Valid values vary based on the key specification:  </para>
        /// <list type="bullet">
        /// <item><description><para>HMAC_SM3</para>
        /// </description></item>
        /// <item><description><para>HMAC_SHA_224</para>
        /// </description></item>
        /// <item><description><para>HMAC_SHA_256</para>
        /// </description></item>
        /// <item><description><para>HMAC_SHA_384</para>
        /// </description></item>
        /// <item><description><para>HMAC_SHA_512</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>HMAC_SHA_256</para>
        /// </summary>
        [NameInMap("Algorithm")]
        [Validation(Required=false)]
        public string Algorithm { get; set; }

        /// <summary>
        /// <para>The globally unique identifier of the customer master key (CMK).</para>
        /// <remarks>
        /// <para>If the KeyId parameter in the request uses a CMK alias, the response returns the CMK identifier that corresponds to the alias.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>key-hzz630494463ejqjx****</para>
        /// </summary>
        [NameInMap("KeyId")]
        [Validation(Required=false)]
        public string KeyId { get; set; }

        /// <summary>
        /// <para>The Base64-encoded message authenticate code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vz1Snp+jGJbgydCFRWVWxAwIMdyfKCSp+jnMWQ==</para>
        /// </summary>
        [NameInMap("Mac")]
        [Validation(Required=false)]
        public string Mac { get; set; }

        /// <summary>
        /// <para>The ID of the request. Alibaba Cloud generates a unique identifier for each request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4c8ae23f-3a42-6791-a4ba-1faa77831c28</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
