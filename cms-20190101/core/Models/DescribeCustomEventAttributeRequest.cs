// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeCustomEventAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The end time.</para>
        /// <para>The value is a UNIX timestamp that indicates the number of milliseconds that have elapsed since January 1, 1970.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1552227965971</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The event ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123****</para>
        /// </summary>
        [NameInMap("EventId")]
        [Validation(Required=false)]
        public string EventId { get; set; }

        /// <summary>
        /// <para>The application group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123****</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The event name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test123</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The keywords used to search event content.</para>
        /// <list type="bullet">
        /// <item><description>If the event content contains both A and B, you can search for A and B.</description></item>
        /// <item><description>If the event content contains either A or B, you can search for A or B.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cms</para>
        /// </summary>
        [NameInMap("SearchKeywords")]
        [Validation(Required=false)]
        public string SearchKeywords { get; set; }

        /// <summary>
        /// <para>The start time.</para>
        /// <para>The value is a UNIX timestamp that indicates the number of milliseconds that have elapsed since January 1, 1970.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1552224365971</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
