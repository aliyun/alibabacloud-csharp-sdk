// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class UpdateAutoSqlOptimizeStatusRequest : TeaModel {
        /// <summary>
        /// <para>The database instance IDs. Separate multiple IDs with commas (,).</para>
        /// <remarks>
        /// <para> You can specify up to 50 instance IDs.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-bp10usoc1erj7****,rm-bp10usoc1erj7****</para>
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public string Instances { get; set; }

        /// <summary>
        /// <para>The status of the automatic SQL optimization feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: The automatic SQL optimization feature is disabled.</description></item>
        /// <item><description><b>1</b>: <b>SQL diagnosis and automatic index creation</b> is specified.</description></item>
        /// <item><description><b>3</b>: <b>SQL diagnosis only</b> is specified.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
