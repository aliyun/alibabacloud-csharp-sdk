// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class SetRbacRoleHierarchyRequest : TeaModel {
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
        /// <para>The child role ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fc94cc51-310f-4485-adb2-ed8c706aff3b</para>
        /// </summary>
        [NameInMap("ChildRoleId")]
        [Validation(Required=false)]
        public string ChildRoleId { get; set; }

        /// <summary>
        /// <para>The parent role ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>71e07711-9a17-49f4-9f83-387a60ee5b64</para>
        /// </summary>
        [NameInMap("ParentRoleId")]
        [Validation(Required=false)]
        public string ParentRoleId { get; set; }

    }

}
