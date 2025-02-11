// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeSparkSQLDiagnosisListRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-2zez35ww415xjwk5</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-11-28 23:00:00</para>
        /// </summary>
        [NameInMap("MaxStartTime")]
        [Validation(Required=false)]
        public string MaxStartTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-11-28 22:00:00</para>
        /// </summary>
        [NameInMap("MinStartTime")]
        [Validation(Required=false)]
        public string MinStartTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[{\&quot;Field\&quot;:\&quot;QueryStartTime\&quot;,\&quot;Type\&quot;:\&quot;Desc\&quot;}]</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("StatementId")]
        [Validation(Required=false)]
        public long? StatementId { get; set; }

    }

}
