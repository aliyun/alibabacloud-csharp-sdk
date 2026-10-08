// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeSQLCollectorRetentionResponseBody : TeaModel {
        /// <summary>
        /// <para>Log retention period of SQL Explorer logs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>30</b>: 30 days.</description></item>
        /// <item><description><b>180</b>: 180 days.</description></item>
        /// <item><description><b>365</b>: 1 year.</description></item>
        /// <item><description><b>1095</b>: 3 years.</description></item>
        /// <item><description><b>1825</b>: 5 years.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Log retention period of SQL Explorer logs for ApsaraDB RDS for PostgreSQL and ApsaraDB RDS for SQL Server is fixed at 30 days.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>365</para>
        /// </summary>
        [NameInMap("ConfigValue")]
        [Validation(Required=false)]
        public string ConfigValue { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D5CEDCC2-CA75-43F7-9508-92F418CE6391</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
