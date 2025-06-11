// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class ListDirectoriesResponseBody : TeaModel {
        /// <summary>
        /// <para>The directories.</para>
        /// </summary>
        [NameInMap("Directories")]
        [Validation(Required=false)]
        public List<ListDirectoriesResponseBodyDirectories> Directories { get; set; }
        public class ListDirectoriesResponseBodyDirectories : TeaModel {
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9A504392-F06D-5029-AB64-6654CB9F1DC1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of directories.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCounts")]
        [Validation(Required=false)]
        public int? TotalCounts { get; set; }

    }

}
