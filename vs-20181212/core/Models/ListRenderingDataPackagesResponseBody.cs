// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class ListRenderingDataPackagesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of cloud application service data packages.</para>
        /// </summary>
        [NameInMap("DataPackages")]
        [Validation(Required=false)]
        public List<ListRenderingDataPackagesResponseBodyDataPackages> DataPackages { get; set; }
        public class ListRenderingDataPackagesResponseBodyDataPackages : TeaModel {
            /// <summary>
            /// <para>The category. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Package: package</description></item>
            /// <item><description>Baseline: baseline</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Package</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The creation time of the cloud rendering instance. The time is displayed in the YYYY-MM-DDTHH:mm:ss+HH:mm format and follows the ISO 8601 standard with a time zone offset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-10-15T10:23:06+08:00</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The ID of the data package.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dp-449ea3d16c0841b8bf33ec5bbc86a152</para>
            /// </summary>
            [NameInMap("DataPackageId")]
            [Validation(Required=false)]
            public string DataPackageId { get; set; }

            /// <summary>
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The ID of the cloud application service instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>render-342012a227dc4ddf91f024639e43051a</para>
            /// </summary>
            [NameInMap("RenderingInstanceId")]
            [Validation(Required=false)]
            public string RenderingInstanceId { get; set; }

            /// <summary>
            /// <para>The size of the data package.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

            /// <summary>
            /// <para>The status of the data package. Valid values:
            /// available: available for binding
            /// packing: in progress
            /// failed: failed
            /// bonded: bound</para>
            /// 
            /// <b>Example:</b>
            /// <para>available</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The update time. The time is displayed in UTC and follows the ISO 8601 standard in the YYYY-MM-DDTHH:mm:ssZ format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-12-06T02:03:59Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>BEA5625F-8FCF-48F4-851B-CA63946DA664</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of cloud rendering instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
