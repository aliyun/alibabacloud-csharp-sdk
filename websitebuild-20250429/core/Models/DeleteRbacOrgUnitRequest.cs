// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class DeleteRbacOrgUnitRequest : TeaModel {
        /// <summary>
        /// <para>The business ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WD20250703155602000001</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <para>The organization ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f0534aa7-94ec-4368-a34a-310390f66253</para>
        /// </summary>
        [NameInMap("OrgUnitId")]
        [Validation(Required=false)]
        public string OrgUnitId { get; set; }

    }

}
