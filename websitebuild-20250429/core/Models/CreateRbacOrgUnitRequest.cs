// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class CreateRbacOrgUnitRequest : TeaModel {
        /// <summary>
        /// <para>The site ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WD20250703155602000001</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <para>The organization parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;name&quot;:&quot;xx&quot;,&quot;path&quot;:&quot;root.shanghai&quot;}</para>
        /// </summary>
        [NameInMap("OrgUnitData")]
        [Validation(Required=false)]
        public string OrgUnitData { get; set; }

    }

}
