// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class DeleteRbacPermissionRequest : TeaModel {
        /// <summary>
        /// <para>The business instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WD20250814102215000001</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <para>The permission ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>804a6b2a-82ac-49f2-960a-a6c2ed9e73dd</para>
        /// </summary>
        [NameInMap("PermissionId")]
        [Validation(Required=false)]
        public string PermissionId { get; set; }

    }

}
