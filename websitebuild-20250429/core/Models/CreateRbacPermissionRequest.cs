// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class CreateRbacPermissionRequest : TeaModel {
        /// <summary>
        /// <para>The business ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WD20250821161210000001</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <para>The permission parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;resource&quot;:&quot;post&quot;,&quot;action&quot;:&quot;read&quot;,&quot;description&quot;:&quot;read post&quot;}</para>
        /// </summary>
        [NameInMap("PermissionData")]
        [Validation(Required=false)]
        public string PermissionData { get; set; }

    }

}
