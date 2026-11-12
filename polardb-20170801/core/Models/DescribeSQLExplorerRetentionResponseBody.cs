// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeSQLExplorerRetentionResponseBody : TeaModel {
        /// <summary>
        /// <para>The retention period of SQL Explorer logs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>30</b>: 30 days</description></item>
        /// <item><description><b>180</b>: 180 days</description></item>
        /// <item><description><b>365</b>: 1 year</description></item>
        /// <item><description><b>1095</b>: 3 years</description></item>
        /// <item><description><b>1825</b>: 5 years</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("ConfigValue")]
        [Validation(Required=false)]
        public string ConfigValue { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>35707295</para>
        /// </summary>
        [NameInMap("DBInstanceID")]
        [Validation(Required=false)]
        public int? DBInstanceID { get; set; }

        /// <summary>
        /// <para>The cluster name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-****************</para>
        /// </summary>
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6A2EE5B4-CC9F-46E1-A747-E43BC9******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
