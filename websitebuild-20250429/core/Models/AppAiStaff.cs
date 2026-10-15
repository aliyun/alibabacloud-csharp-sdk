// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class AppAiStaff : TeaModel {
        /// <summary>
        /// <para>The employee ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>370196</para>
        /// </summary>
        [NameInMap("StaffId")]
        [Validation(Required=false)]
        public string StaffId { get; set; }

        /// <summary>
        /// <para>The employee name.</para>
        /// </summary>
        [NameInMap("StaffName")]
        [Validation(Required=false)]
        public string StaffName { get; set; }

        /// <summary>
        /// <para>The employee type.</para>
        /// </summary>
        [NameInMap("StaffType")]
        [Validation(Required=false)]
        public string StaffType { get; set; }

        /// <summary>
        /// <para>Valid values: unknown, init, testing, and online.</para>
        /// 
        /// <b>Example:</b>
        /// <para>online</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
