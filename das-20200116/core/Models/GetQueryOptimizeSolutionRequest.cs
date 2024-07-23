// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetQueryOptimizeSolutionRequest : TeaModel {
        /// <summary>
        /// <para>The database engine. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>MySQL</b></description></item>
        /// <item><description><b>PolarDBMySQL</b></description></item>
        /// <item><description><b>PostgreSQL</b></description></item>
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
        /// <para>The instance ID. You can call the <a href="https://help.aliyun.com/document_detail/405261.html">GetQueryOptimizeDataStats</a> operation to query the instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-bp1o3z6beqpej****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The tag ID. For more information, see <a href="https://help.aliyun.com/document_detail/290038.html">Query governance</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LARGE_ROWS_EXAMINED</para>
        /// </summary>
        [NameInMap("RuleIds")]
        [Validation(Required=false)]
        public string RuleIds { get; set; }

        /// <summary>
        /// <para>The SQL template ID. You can call the <a href="https://help.aliyun.com/document_detail/405261.html">GetQueryOptimizeDataStats</a> operation to query the SQL template ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>05fecf7e7b3efd123c4d5197035f****</para>
        /// </summary>
        [NameInMap("SqlId")]
        [Validation(Required=false)]
        public string SqlId { get; set; }

    }

}
