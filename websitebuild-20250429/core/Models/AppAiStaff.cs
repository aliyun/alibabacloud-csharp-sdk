// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class AppAiStaff : TeaModel {
        [NameInMap("StaffId")]
        [Validation(Required=false)]
        public string StaffId { get; set; }

        [NameInMap("StaffName")]
        [Validation(Required=false)]
        public string StaffName { get; set; }

        [NameInMap("StaffType")]
        [Validation(Required=false)]
        public string StaffType { get; set; }

        /// <summary>
        /// <para>可能的值：unknown, init, testing, online</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
