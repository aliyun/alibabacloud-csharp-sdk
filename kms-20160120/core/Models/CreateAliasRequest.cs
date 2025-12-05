// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class CreateAliasRequest : TeaModel {
        /// <summary>
        /// <para>The alias of the CMK.</para>
        /// <para>The alias must be 1 to 255 characters in length and must contain the prefix <c>alias/</c>. The alias cannot be prefixed with the reserved word <c>alias/acs</c>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alias/example</para>
        /// </summary>
        [NameInMap("AliasName")]
        [Validation(Required=false)]
        public string AliasName { get; set; }

        /// <summary>
        /// <para>The ID of the CMK. The ID must be globally unique.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7906979c-8e06-46a2-be2d-68e3ccbc****</para>
        /// </summary>
        [NameInMap("KeyId")]
        [Validation(Required=false)]
        public string KeyId { get; set; }

    }

}
