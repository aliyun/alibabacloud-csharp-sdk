// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class GetProjectLogsRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the Dedicated SQL feature. For more information, see <a href="https://help.aliyun.com/document_detail/223777.html">Enable Dedicated SQL</a>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false (default): enables the Standard SQL feature.</description></item>
        /// </list>
        /// <para>You can use the powerSql or <b>query</b> parameter to configure Dedicated SQL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("powerSql")]
        [Validation(Required=false)]
        public bool? PowerSql { get; set; }

        /// <summary>
        /// <para>The standard SQL statement. In this example, the SQL statement queries the number of page views (PVs) from 2022-03-01 10:41:40 to 2022-03-01 10:56:40 in a Logstore whose name is nginx-moni.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SELECT COUNT(*) as pv FROM nginx-moni where <b>time</b> &gt; 1646102500 and <b>time</b> &lt; 1646103400</para>
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

    }

}
