// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class DescribeDiskEventsResponseBody : TeaModel {
        /// <summary>
        /// <para>The risk events of the disk.</para>
        /// </summary>
        [NameInMap("DiskEvents")]
        [Validation(Required=false)]
        public List<DescribeDiskEventsResponseBodyDiskEvents> DiskEvents { get; set; }
        public class DescribeDiskEventsResponseBodyDiskEvents : TeaModel {
            /// <summary>
            /// <para>The description of the event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This is description.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The ID of the disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d-bp1bq5g3dxxo1x4o****</para>
            /// </summary>
            [NameInMap("DiskId")]
            [Validation(Required=false)]
            public string DiskId { get; set; }

            /// <summary>
            /// <para>The recommended action after the event occurred. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Resize: resizes the disk.</description></item>
            /// <item><description>ModifyDiskSpec: changes the category of the disk.</description></item>
            /// <item><description>NoAction: performs no operation.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NoAction</para>
            /// </summary>
            [NameInMap("RecommendAction")]
            [Validation(Required=false)]
            public string RecommendAction { get; set; }

            /// <summary>
            /// <para>The region ID of the disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The state of the event. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Solved</description></item>
            /// <item><description>UnSolved</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Solved</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The time when the event occurred. The time follows the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-06-01T08:00:00Z</para>
            /// </summary>
            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public string Timestamp { get; set; }

            /// <summary>
            /// <para>The type of the event. Only DataNeedProtect can be returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DataNeedProtect</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
