// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class UpdateDashboardRequest : TeaModel {
        /// <summary>
        /// The attributes of the dashboard.
        /// </summary>
        [NameInMap("attribute")]
        [Validation(Required=false)]
        public Dictionary<string, string> Attribute { get; set; }

        /// <summary>
        /// The charts on the dashboard.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("charts")]
        [Validation(Required=false)]
        public List<Chart> Charts { get; set; }

        /// <summary>
        /// The name of the dashboard.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("dashboardName")]
        [Validation(Required=false)]
        public string DashboardName { get; set; }

        /// <summary>
        /// The description of the dashboard.
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The display name of the dashboard.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

    }

}
