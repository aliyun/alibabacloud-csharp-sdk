// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class CreateDirectoryResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the directory.</para>
        /// </summary>
        [NameInMap("Directory")]
        [Validation(Required=false)]
        public CreateDirectoryResponseBodyDirectory Directory { get; set; }
        public class CreateDirectoryResponseBodyDirectory : TeaModel {
            /// <summary>
            /// <para>The time when the directory was created. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-10-10T04:04:04Z</para>
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
            /// <para>example</para>
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
            /// <para>The time when the directory was modified. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-10-10T04:04:04Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ADADC31D-90EE-5459-99B0-D83DF07769A3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
