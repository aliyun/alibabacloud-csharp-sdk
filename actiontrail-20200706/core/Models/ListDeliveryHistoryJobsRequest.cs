// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20200706.Models
{
    public class ListDeliveryHistoryJobsRequest : TeaModel {
        /// <summary>
        /// <para>The page number.</para>
        /// <list type="bullet">
        /// <item><description><para>The value must be greater than or equal to 1.</para>
        /// </description></item>
        /// <item><description><para>Default value: 1.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// <list type="bullet">
        /// <item><description><para>Valid values: 1 to 100.</para>
        /// </description></item>
        /// <item><description><para>Default value: 20.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
