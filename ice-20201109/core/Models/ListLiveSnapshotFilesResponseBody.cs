// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListLiveSnapshotFilesResponseBody : TeaModel {
        [NameInMap("FileList")]
        [Validation(Required=false)]
        public List<ListLiveSnapshotFilesResponseBodyFileList> FileList { get; set; }
        public class ListLiveSnapshotFilesResponseBodyFileList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-02-02T22:22:22Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1619503516000</para>
            /// </summary>
            [NameInMap("CreateTimestamp")]
            [Validation(Required=false)]
            public long? CreateTimestamp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsOverlay")]
            [Validation(Required=false)]
            public bool? IsOverlay { get; set; }

            /// <summary>
            /// <para>OSS bucket。</para>
            /// 
            /// <b>Example:</b>
            /// <para>testbucket</para>
            /// </summary>
            [NameInMap("OssBucket")]
            [Validation(Required=false)]
            public string OssBucket { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>oss-cn-shanghai.aliyuncs.com</para>
            /// </summary>
            [NameInMap("OssEndpoint")]
            [Validation(Required=false)]
            public string OssEndpoint { get; set; }

            [NameInMap("OssObject")]
            [Validation(Required=false)]
            public string OssObject { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2022-02-02T22:22:22Z</para>
        /// </summary>
        [NameInMap("NextStartTime")]
        [Validation(Required=false)]
        public string NextStartTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><b><b><b>11-DB8D-4A9A-875B-275798</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
