// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class GetAgenticSpaceResponseBody : TeaModel {
        /// <summary>
        /// <para>The Agentic space information.</para>
        /// </summary>
        [NameInMap("AgenticSpace")]
        [Validation(Required=false)]
        public GetAgenticSpaceResponseBodyAgenticSpace AgenticSpace { get; set; }
        public class GetAgenticSpaceResponseBodyAgenticSpace : TeaModel {
            /// <summary>
            /// <para>The AgenticSpace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>agentic-229oypxjgpau2****</para>
            /// </summary>
            [NameInMap("AgenticSpaceId")]
            [Validation(Required=false)]
            public string AgenticSpaceId { get; set; }

            /// <summary>
            /// <para>The zone ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-i</para>
            /// </summary>
            [NameInMap("Azone")]
            [Validation(Required=false)]
            public string Azone { get; set; }

            /// <summary>
            /// <para>The time when the Agentic space was created. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-06-10T10:08:08Z</para>
            /// </summary>
            [NameInMap("CreateTimeUtc")]
            [Validation(Required=false)]
            public string CreateTimeUtc { get; set; }

            /// <summary>
            /// <para>The description of the AgenticSpace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AgenticSpace Description。</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The number of files used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("FileCountUsage")]
            [Validation(Required=false)]
            public long? FileCountUsage { get; set; }

            /// <summary>
            /// <para>The ID of the file system.</para>
            /// 
            /// <b>Example:</b>
            /// <para>06229oypxjgox0u****</para>
            /// </summary>
            [NameInMap("FileSystemId")]
            [Validation(Required=false)]
            public string FileSystemId { get; set; }

            /// <summary>
            /// <para>The absolute path of the file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/test/</para>
            /// </summary>
            [NameInMap("FileSystemPath")]
            [Validation(Required=false)]
            public string FileSystemPath { get; set; }

            /// <summary>
            /// <para>The quota information.</para>
            /// </summary>
            [NameInMap("Quota")]
            [Validation(Required=false)]
            public GetAgenticSpaceResponseBodyAgenticSpaceQuota Quota { get; set; }
            public class GetAgenticSpaceResponseBodyAgenticSpaceQuota : TeaModel {
                /// <summary>
                /// <para>The file count limit of the quota. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>Minimum value: 10,000.</para>
                /// </description></item>
                /// <item><description><para>Maximum value: 100,000,000.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>10000000</para>
                /// </summary>
                [NameInMap("FileCountLimit")]
                [Validation(Required=false)]
                public long? FileCountLimit { get; set; }

                /// <summary>
                /// <para>The total capacity limit of the quota. Unit: bytes.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Minimum value: 10,737,418,240 (10 GiB).</description></item>
                /// <item><description>Maximum value: 1,099,511,627,776,000 (1,024,000 GiB).</description></item>
                /// <item><description>Step size: 1,073,741,824 (1 GiB).</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>10737418240</para>
                /// </summary>
                [NameInMap("SizeLimit")]
                [Validation(Required=false)]
                public long? SizeLimit { get; set; }

            }

            /// <summary>
            /// <para>The used capacity. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("SpaceUsage")]
            [Validation(Required=false)]
            public long? SpaceUsage { get; set; }

            /// <summary>
            /// <para>The status of the Agentic space. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Running: The space is running.</description></item>
            /// <item><description>Deleted: The space is deleted.</description></item>
            /// <item><description>Creating: The space is being created.</description></item>
            /// <item><description>Deleting: The space is being deleted.</description></item>
            /// <item><description>CreateFailed: The space failed to be created.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The time when the Agentic space was updated. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-06-10T10:08:08Z</para>
            /// </summary>
            [NameInMap("UpdateTimeUtc")]
            [Validation(Required=false)]
            public string UpdateTimeUtc { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0D****3E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
