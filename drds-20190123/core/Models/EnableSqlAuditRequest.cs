// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class EnableSqlAuditRequest : TeaModel {
        /// <summary>
        /// <para>The name of the database for which you want to enable the SQL audit feature.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        /// <summary>
        /// <para>The ID of the PolarDB-X 1.0 instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>drds***********</para>
        /// </summary>
        [NameInMap("DrdsInstanceId")]
        [Validation(Required=false)]
        public string DrdsInstanceId { get; set; }

        /// <summary>
        /// <para>Specifies whether to backtrack historical SQL statements for auditing.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsRecall")]
        [Validation(Required=false)]
        public bool? IsRecall { get; set; }

        /// <summary>
        /// <para>The timestamp that indicates when the backtracking ends. Unit: milliseconds.</para>
        /// <remarks>
        /// <para>The end time of the backtracking must be later than the start time of the backtracking.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1568875132000</para>
        /// </summary>
        [NameInMap("RecallEndTimestamp")]
        [Validation(Required=false)]
        public string RecallEndTimestamp { get; set; }

        /// <summary>
        /// <para>The timestamp that indicates when the backtracking starts. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1568875132000</para>
        /// </summary>
        [NameInMap("RecallStartTimestamp")]
        [Validation(Required=false)]
        public string RecallStartTimestamp { get; set; }

    }

}
