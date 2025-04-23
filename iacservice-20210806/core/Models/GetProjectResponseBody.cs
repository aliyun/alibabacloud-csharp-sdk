// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class GetProjectResponseBody : TeaModel {
        [NameInMap("project")]
        [Validation(Required=false)]
        public GetProjectResponseBodyProject Project { get; set; }
        public class GetProjectResponseBodyProject : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-09-06T06:11:27Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>p-433aead7560572f8d95b25775c</para>
            /// </summary>
            [NameInMap("projectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("taskCnt")]
            [Validation(Required=false)]
            public long? TaskCnt { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>7FA0FF4A-ABD4-54F6-BEAC-B4273EBA10A2</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
