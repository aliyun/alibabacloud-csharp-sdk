// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListCalendarsRequest : TeaModel {
        /// <summary>
        /// <para>The name of the scheduling calendar. Partial match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>calendar</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The account ID of the owner. Exact match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456789</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of items per page. Default value: 10. Valid values: 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The workspace ID. Queries the calendars applicable to this workspace, including those applicable to all workspaces. If this parameter is not specified, the calendars of the current tenant are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The sorting rule. The format is &quot;Field Direction&quot;, separated by a space.</para>
        /// <list type="bullet">
        /// <item><description>Field: ModifyTime, Name, or Id.</description></item>
        /// <item><description>Direction: Asc for ascending order, or Desc for descending order. If this parameter is not specified, Asc is used.</description></item>
        /// </list>
        /// <para>Default value: ModifyTime Desc.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ModifyTime Desc</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

    }

}
