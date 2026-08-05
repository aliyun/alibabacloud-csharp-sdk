// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDomainLogRequest : TeaModel {
        /// <summary>
        /// <para>The streaming domain or ingest domain.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>When you specify DomainName, make sure that the domain name is a live streaming domain name and that the user calling this operation has the required permissions on the specified domain name.</description></item>
        /// <item><description>Only a single domain name can be queried at a time.</description></item>
        /// </list>
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
        /// <para>The end time. Specify the time in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format (UTC).</para>
        /// <para>The end time must be later than the start time. The interval between the start time and end time cannot exceed 31 days.</para>
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
        /// <para>The page number.
        /// Valid values: [1, 9223372036854775807].</para>
        /// <remarks>
        /// <para>If you do not specify PageNumber, the first page of data is returned by default.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The page size. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Any integer from <b>1</b> to <b>1000</b>.</description></item>
        /// <item><description>Default value: <b>300</b>.</description></item>
        /// <item><description>Maximum value: <b>1000</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The start time. Specify the time in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format (UTC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2016-10-20T04:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
