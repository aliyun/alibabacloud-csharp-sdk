// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class CostModelDetailRespDTO : TeaModel {
        /// <summary>
        /// <para>List of column definitions</para>
        /// </summary>
        [NameInMap("columns")]
        [Validation(Required=false)]
        public List<MetricDefRespDTO> Columns { get; set; }

        /// <summary>
        /// <para>Current granularity: daily/hourly</para>
        /// 
        /// <b>Example:</b>
        /// <para>hourly</para>
        /// </summary>
        [NameInMap("granularity")]
        [Validation(Required=false)]
        public string Granularity { get; set; }

        /// <summary>
        /// <para>Model ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("modelId")]
        [Validation(Required=false)]
        public long? ModelId { get; set; }

        /// <summary>
        /// <para>Model name</para>
        /// 
        /// <b>Example:</b>
        /// <para>通义千问-Plus</para>
        /// </summary>
        [NameInMap("modelName")]
        [Validation(Required=false)]
        public string ModelName { get; set; }

        /// <summary>
        /// <para>Current page</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// <para>Number of entries per page</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>List of data rows</para>
        /// </summary>
        [NameInMap("rows")]
        [Validation(Required=false)]
        public List<CostModelDetailRowDTO> Rows { get; set; }

        /// <summary>
        /// <para>Total number of entries</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
