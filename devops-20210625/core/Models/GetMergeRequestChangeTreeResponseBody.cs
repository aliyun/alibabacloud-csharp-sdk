// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class GetMergeRequestChangeTreeResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>SYSTEM_UNKNOWN_ERROR</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>HC93CE1A-8D7A-13A9-8306-7465DE2E5C0F</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public GetMergeRequestChangeTreeResponseBodyResult Result { get; set; }
        public class GetMergeRequestChangeTreeResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("changedFilesCount")]
            [Validation(Required=false)]
            public long? ChangedFilesCount { get; set; }

            [NameInMap("changedFilesInfos")]
            [Validation(Required=false)]
            public List<GetMergeRequestChangeTreeResponseBodyResultChangedFilesInfos> ChangedFilesInfos { get; set; }
            public class GetMergeRequestChangeTreeResponseBodyResultChangedFilesInfos : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("addLines")]
                [Validation(Required=false)]
                public long? AddLines { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("binaryFile")]
                [Validation(Required=false)]
                public bool? BinaryFile { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("delLines")]
                [Validation(Required=false)]
                public long? DelLines { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("deletedFile")]
                [Validation(Required=false)]
                public bool? DeletedFile { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("newFile")]
                [Validation(Required=false)]
                public bool? NewFile { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test.txt</para>
                /// </summary>
                [NameInMap("newPath")]
                [Validation(Required=false)]
                public string NewPath { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test.txt</para>
                /// </summary>
                [NameInMap("oldPath")]
                [Validation(Required=false)]
                public string OldPath { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("renamedFile")]
                [Validation(Required=false)]
                public bool? RenamedFile { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("totalAddLines")]
            [Validation(Required=false)]
            public long? TotalAddLines { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("totalDelLines")]
            [Validation(Required=false)]
            public long? TotalDelLines { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
