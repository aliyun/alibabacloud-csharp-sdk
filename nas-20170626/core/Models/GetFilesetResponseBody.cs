// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class GetFilesetResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetFilesetResponseBodyData Data { get; set; }
        public class GetFilesetResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-11-21 12:49:25</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("DeletionProtection")]
            [Validation(Required=false)]
            public bool? DeletionProtection { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("FileCountUsage")]
            [Validation(Required=false)]
            public long? FileCountUsage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cpfs-0244729a8ef8****</para>
            /// </summary>
            [NameInMap("FileSystemId")]
            [Validation(Required=false)]
            public string FileSystemId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pathtoroot/fset/</para>
            /// </summary>
            [NameInMap("FileSystemPath")]
            [Validation(Required=false)]
            public string FileSystemPath { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>fset-03250e8fe78d****</para>
            /// </summary>
            [NameInMap("FsetId")]
            [Validation(Required=false)]
            public string FsetId { get; set; }

            [NameInMap("Quota")]
            [Validation(Required=false)]
            public GetFilesetResponseBodyDataQuota Quota { get; set; }
            public class GetFilesetResponseBodyDataQuota : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>10001</para>
                /// </summary>
                [NameInMap("FileCountLimit")]
                [Validation(Required=false)]
                public long? FileCountLimit { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10,737,418,240</para>
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
            /// <para>CREATED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-11-22 12:49:25</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>BC7C825C-5F65-4B56-BEF6-98C56C7C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
