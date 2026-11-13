// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class PublishProductRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the HiMarket portal to which the API product is published. This parameter specifies the target portal for the publication. You can query the publication record by portal dimension by calling ListPortalPublications. This ID also appears in the publication record details and is paired with portalName.</para>
        /// 
        /// <b>Example:</b>
        /// <para>portal-xxxxxxxx</para>
        /// </summary>
        [NameInMap("portalId")]
        [Validation(Required=false)]
        public string PortalId { get; set; }

    }

}
