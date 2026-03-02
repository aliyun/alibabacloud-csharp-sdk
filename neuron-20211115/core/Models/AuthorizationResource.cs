// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class AuthorizationResource : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("authorizerId")]
        [Validation(Required=false)]
        public string AuthorizerId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>developer</para>
        /// </summary>
        [NameInMap("authorizerType")]
        [Validation(Required=false)]
        public string AuthorizerType { get; set; }

    }

}
