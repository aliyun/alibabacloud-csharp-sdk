// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class ListRenderingDataPackagesRequest : TeaModel {
        /// <summary>
        /// <para>The category. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Package</para>
        /// </description></item>
        /// <item><description><para>Baseline</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Baseline</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>The ID of the data pack.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dp-449ea3d16c0841b8bf33ec5bbc86a152</para>
        /// </summary>
        [NameInMap("DataPackageId")]
        [Validation(Required=false)]
        public string DataPackageId { get; set; }

        /// <summary>
        /// <para>The parameter for filtering by time range. Use UTC time in ISO8601 format: yyyy-MM-ddTHH:mm:ssZ.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-09-24T03:30:46Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The page number for the query list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries displayed per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The size of the data pack.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

        /// <summary>
        /// <para>The parameter for filtering by time range. Use UTC time in ISO8601 format: yyyy-MM-ddTHH:mm:ssZ.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-10-30T16:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The status of the data pack. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>available</para>
        /// </description></item>
        /// <item><description><para>packing</para>
        /// </description></item>
        /// <item><description><para>failed</para>
        /// </description></item>
        /// <item><description><para>bonded</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>available</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
