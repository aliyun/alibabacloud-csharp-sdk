// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class GetSearchCodePreviewResponseBody : TeaModel {
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
        /// <para>A7586FEB-E48D-5579-983F-74981FBFF627</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public GetSearchCodePreviewResponseBodyResult Result { get; set; }
        public class GetSearchCodePreviewResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("docId")]
            [Validation(Required=false)]
            public string DocId { get; set; }

            [NameInMap("highlightTextMap")]
            [Validation(Required=false)]
            public GetSearchCodePreviewResponseBodyResultHighlightTextMap HighlightTextMap { get; set; }
            public class GetSearchCodePreviewResponseBodyResultHighlightTextMap : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("clob")]
                [Validation(Required=false)]
                public string Clob { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test.rb</para>
                /// </summary>
                [NameInMap("fileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5ffd468b1e45db3c1cc26ad6</para>
                /// </summary>
                [NameInMap("organizationId")]
                [Validation(Required=false)]
                public string OrganizationId { get; set; }

            }

            [NameInMap("source")]
            [Validation(Required=false)]
            public GetSearchCodePreviewResponseBodyResultSource Source { get; set; }
            public class GetSearchCodePreviewResponseBodyResultSource : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>master</para>
                /// </summary>
                [NameInMap("branch")]
                [Validation(Required=false)]
                public string Branch { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-12-12 12:12:12</para>
                /// </summary>
                [NameInMap("checkinDate")]
                [Validation(Required=false)]
                public string CheckinDate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test.rb</para>
                /// </summary>
                [NameInMap("fileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>config/environments/test.rb</para>
                /// </summary>
                [NameInMap("filePath")]
                [Validation(Required=false)]
                public string FilePath { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Ruby</para>
                /// </summary>
                [NameInMap("language")]
                [Validation(Required=false)]
                public string Language { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5f9f9f6122a8c7ff3934f99a</para>
                /// </summary>
                [NameInMap("organizationId")]
                [Validation(Required=false)]
                public string OrganizationId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>codeup/test-repo</para>
                /// </summary>
                [NameInMap("repoPath")]
                [Validation(Required=false)]
                public string RepoPath { get; set; }

            }

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
