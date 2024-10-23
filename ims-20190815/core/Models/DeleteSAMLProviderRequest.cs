// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class DeleteSAMLProviderRequest : TeaModel {
        /// <summary>
        /// <para>The name of the IdP that you want to delete.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-provider</para>
        /// </summary>
        [NameInMap("SAMLProviderName")]
        [Validation(Required=false)]
        public string SAMLProviderName { get; set; }

    }

}
