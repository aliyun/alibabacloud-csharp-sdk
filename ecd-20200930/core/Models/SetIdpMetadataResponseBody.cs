// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class SetIdpMetadataResponseBody : TeaModel {
        /// <summary>
        /// <para>The entity ID obtained after the IdP metadata file is parsed.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://test****.cn/adfs/services/trust">http://test****.cn/adfs/services/trust</a></para>
        /// </summary>
        [NameInMap("IdpEntityId")]
        [Validation(Required=false)]
        public string IdpEntityId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
