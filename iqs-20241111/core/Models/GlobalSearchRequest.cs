// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241111.Models
{
    public class GlobalSearchRequest : TeaModel {
        /// <summary>
        /// <para>The page number. The value starts from 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The search query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Latest Trump tariff news</para>
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>The relative time range of the webpage publication time. Specify a value based on the relative time options.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OneWeek</para>
        /// </summary>
        [NameInMap("timeRange")]
        [Validation(Required=false)]
        public string TimeRange { get; set; }

    }

}
