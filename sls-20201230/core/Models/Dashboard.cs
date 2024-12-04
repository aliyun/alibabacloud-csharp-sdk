// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class Dashboard : TeaModel {
        [NameInMap("attribute")]
        [Validation(Required=false)]
        public Dictionary<string, string> Attribute { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("charts")]
        [Validation(Required=false)]
        public List<Chart> Charts { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dashboard-1609294922657-434834</para>
        /// </summary>
        [NameInMap("dashboardName")]
        [Validation(Required=false)]
        public string DashboardName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>这是一个仪表盘。</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-alert</para>
        /// </summary>
        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

    }

}
