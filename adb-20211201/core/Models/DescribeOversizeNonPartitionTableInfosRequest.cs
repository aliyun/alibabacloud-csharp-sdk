// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeOversizeNonPartitionTableInfosRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-bp11q28kvl688****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The end time of the query. The time is in UTC and follows the <i>yyyy-MM-ddTHH:mm:ssZ</i> format.</para>
        /// <remarks>
        /// <para>The end time must be later than the start time. The interval between the start time and the end time must be less than 7 days.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2024-05-11T05:44Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The language of the title for the downloaded file and specific error messages. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Simplified Chinese. This is the default value.</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// <item><description><b>ja</b>: Japanese.</description></item>
        /// <item><description><b>zh-tw</b>: Traditional Chinese.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The sorting rule for a specified field. The value is a JSON array. You must specify the fields to be sorted and the sorting order in sequence. Example:</para>
        /// <pre><c>[
        /// 
        ///     {
        /// 
        ///         &quot;Field&quot;:&quot;Name&quot;,
        /// 
        ///         &quot;Type&quot;:&quot;Asc&quot;
        /// 
        ///     }
        /// 
        /// ]
        /// </c></pre>
        /// <para>Field: the name of the field to be sorted. Only the Name field is supported.
        /// Type: the sorting order. Valid values: Desc for descending order, and Asc for ascending order.</para>
        /// <para>The values are not case-sensitive.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Field&quot;:&quot;SchemaName&quot;,&quot;Type&quot;:&quot;Asc&quot;}]</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number. The value must be a positive integer. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>30</description></item>
        /// <item><description>50</description></item>
        /// <item><description>100</description></item>
        /// </list>
        /// <para>Default value: 30.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/143074.html">DescribeRegions</a> operation to query the region ID.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The start time of the query. The time is in UTC and follows the yyyy-MM-ddTHH:mmZ format.</para>
        /// <remarks>
        /// <para>SQL audit logs can be queried only when SQL audit is enabled. You can query SQL audit logs generated within the last 30 days. If SQL audit is disabled and then re-enabled, you can query only the SQL audit logs generated after it is re-enabled.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2024-05-11T05:44Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
