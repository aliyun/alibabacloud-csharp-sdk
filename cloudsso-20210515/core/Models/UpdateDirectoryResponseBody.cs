// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class UpdateDirectoryResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the directory.</para>
        /// </summary>
        [NameInMap("Directory")]
        [Validation(Required=false)]
        public UpdateDirectoryResponseBodyDirectory Directory { get; set; }
        public class UpdateDirectoryResponseBodyDirectory : TeaModel {
            /// <summary>
            /// <para>The time when the directory was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-06-30T08:35:26Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The ID of the directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d-00fc2p61****</para>
            /// </summary>
            [NameInMap("DirectoryId")]
            [Validation(Required=false)]
            public string DirectoryId { get; set; }

            /// <summary>
            /// <para>The name of the directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>new-example</para>
            /// </summary>
            [NameInMap("DirectoryName")]
            [Validation(Required=false)]
            public string DirectoryName { get; set; }

            /// <summary>
            /// <para>The region ID of the directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The time when the directory was modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-10-25T09:13:24Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B182C041-8C64-5F2F-A07B-FC67FAF89CF9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
