// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeBackupsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the backup set.</para>
        /// 
        /// <b>Example:</b>
        /// <para>32732****</para>
        /// </summary>
        [NameInMap("BackupId")]
        [Validation(Required=false)]
        public string BackupId { get; set; }

        /// <summary>
        /// <para>The RAM role name of the backup set owner\&quot;s Alibaba Cloud account.</para>
        /// <remarks>
        /// <para>Specify this parameter only when backing up across Alibaba Cloud accounts.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>role-for-xxx</para>
        /// </summary>
        [NameInMap("CrossRole")]
        [Validation(Required=false)]
        public string CrossRole { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account ID of the backup set owner.</para>
        /// <remarks>
        /// <para>Specify this parameter only when backing up across Alibaba Cloud accounts.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>195****</para>
        /// </summary>
        [NameInMap("CrossUid")]
        [Validation(Required=false)]
        public string CrossUid { get; set; }

        /// <summary>
        /// <para>The ID of the AnalyticDB for MySQL cluster.</para>
        /// <remarks>
        /// <para>Call <a href="https://help.aliyun.com/document_detail/129857.html">DescribeDBClusters</a> to list cluster IDs in a region.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>am-bp18934i73vb5****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The end time of the query. It must be later than the start time. Format: yyyy-MM-ddTHH:mmZ.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-06-02T16:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number. Valid values: positive integers greater than 0 and no larger than the maximum value of the integer data type. Default value: 1.</para>
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
        /// <item><description><para><b>30</b> (default)</para>
        /// </description></item>
        /// <item><description><para><b>50</b></para>
        /// </description></item>
        /// <item><description><para><b>100</b></para>
        /// </description></item>
        /// </list>
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
        /// <para>Call <a href="https://help.aliyun.com/document_detail/143074.html">DescribeRegions</a> to list supported regions and zones for AnalyticDB for MySQL, including region IDs.</para>
        /// </remarks>
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
        /// <para>The start time of the query. Format: yyyy-MM-ddTHH:mmZ.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-06-01T16:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
