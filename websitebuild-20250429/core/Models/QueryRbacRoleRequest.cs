// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class QueryRbacRoleRequest : TeaModel {
        /// <summary>
        /// <para>The business ID of the application instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WD20250821161210000001</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <para>The storage management role ID, including preset roles and custom roles.</para>
        /// <list type="bullet">
        /// <item><description>25: storage management administrator (preset role)</description></item>
        /// <item><description>26: developer (preset role)</description></item>
        /// <item><description>27: analyst (preset role)</description></item>
        /// <item><description>30: viewer (preset role)</description></item>
        /// <item><description>Custom role: the role ID of the custom role</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>75b2f16f-35a5-4e90-949f-295ea14a4dc8</para>
        /// </summary>
        [NameInMap("RoleId")]
        [Validation(Required=false)]
        public string RoleId { get; set; }

    }

}
