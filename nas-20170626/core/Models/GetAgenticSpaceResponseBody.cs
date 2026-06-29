// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class GetAgenticSpaceResponseBody : TeaModel {
        [NameInMap("AgenticSpace")]
        [Validation(Required=false)]
        public GetAgenticSpaceResponseBodyAgenticSpace AgenticSpace { get; set; }
        public class GetAgenticSpaceResponseBodyAgenticSpace : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>agentic-229oypxjgpau2****</para>
            /// </summary>
            [NameInMap("AgenticSpaceId")]
            [Validation(Required=false)]
            public string AgenticSpaceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou-i</para>
            /// </summary>
            [NameInMap("Azone")]
            [Validation(Required=false)]
            public string Azone { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2026-06-10T10:08:08Z</para>
            /// </summary>
            [NameInMap("CreateTimeUtc")]
            [Validation(Required=false)]
            public string CreateTimeUtc { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>AgenticSpace Description。</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("FileCountUsage")]
            [Validation(Required=false)]
            public long? FileCountUsage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>06229oypxjgox0u****</para>
            /// </summary>
            [NameInMap("FileSystemId")]
            [Validation(Required=false)]
            public string FileSystemId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>/test/</para>
            /// </summary>
            [NameInMap("FileSystemPath")]
            [Validation(Required=false)]
            public string FileSystemPath { get; set; }

            [NameInMap("Quota")]
            [Validation(Required=false)]
            public GetAgenticSpaceResponseBodyAgenticSpaceQuota Quota { get; set; }
            public class GetAgenticSpaceResponseBodyAgenticSpaceQuota : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>10000000</para>
                /// </summary>
                [NameInMap("FileCountLimit")]
                [Validation(Required=false)]
                public long? FileCountLimit { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10737418240</para>
                /// </summary>
                [NameInMap("SizeLimit")]
                [Validation(Required=false)]
                public long? SizeLimit { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("SpaceUsage")]
            [Validation(Required=false)]
            public long? SpaceUsage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2026-06-10T10:08:08Z</para>
            /// </summary>
            [NameInMap("UpdateTimeUtc")]
            [Validation(Required=false)]
            public string UpdateTimeUtc { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0D****3E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
