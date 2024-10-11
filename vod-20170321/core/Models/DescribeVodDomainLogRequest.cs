// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodDomainLogRequest : TeaModel {
        /// <summary>
        /// <para>The domain name for CDN.</para>
        /// <remarks>
        /// <para> You can specify only one domain name in each query.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. The end time must be later than the start time. The maximum time range that can be specified is one year. Specify the time in the ISO 8601 standard in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2016-10-20T05:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// <list type="bullet">
        /// <item><description>Default value: <b>300</b>.</description></item>
        /// <item><description>Valid values: <b>1 to 1000</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the ISO 8601 standard in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2016-10-20T04:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
