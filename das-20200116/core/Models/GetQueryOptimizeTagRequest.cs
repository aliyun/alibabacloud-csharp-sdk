// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetQueryOptimizeTagRequest : TeaModel {
        /// <summary>
        /// <para>The database engine. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>MySQL</b>: ApsaraDB RDS for MySQL</description></item>
        /// <item><description><b>PolarDBMySQL</b>: PolarDB for MySQL</description></item>
        /// <item><description><b>PostgreSQL</b>: ApsaraDB RDS for PostgreSQL</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-2ze8g2am97624****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The SQL template ID. You can call the <a href="https://help.aliyun.com/document_detail/405261.html">GetQueryOptimizeDataStats</a> operation to query the SQL template ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>29d9fef63e347d39c3436658a5fe5f2b</para>
        /// </summary>
        [NameInMap("SqlId")]
        [Validation(Required=false)]
        public string SqlId { get; set; }

    }

}
