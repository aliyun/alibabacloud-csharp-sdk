// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListSearchSourceCodeResponseBody : TeaModel {
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
        /// <para>ASSDS-ASSASX-XSAXSA-XSAXSAXS</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListSearchSourceCodeResponseBodyResult> Result { get; set; }
        public class ListSearchSourceCodeResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>60d54f3daccf2bbd6659f3ad/gitlabhq/master/spec/frontend/snippets/test_utils.js</para>
            /// </summary>
            [NameInMap("docId")]
            [Validation(Required=false)]
            public string DocId { get; set; }

            [NameInMap("highlightTextMap")]
            [Validation(Required=false)]
            public ListSearchSourceCodeResponseBodyResultHighlightTextMap HighlightTextMap { get; set; }
            public class ListSearchSourceCodeResponseBodyResultHighlightTextMap : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("clob")]
                [Validation(Required=false)]
                public string Clob { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test.java</para>
                /// </summary>
                [NameInMap("fileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>java</para>
                /// </summary>
                [NameInMap("language")]
                [Validation(Required=false)]
                public string Language { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>60de7a6852743a5162b5f957</para>
                /// </summary>
                [NameInMap("organizationId")]
                [Validation(Required=false)]
                public string OrganizationId { get; set; }

            }

            [NameInMap("source")]
            [Validation(Required=false)]
            public ListSearchSourceCodeResponseBodyResultSource Source { get; set; }
            public class ListSearchSourceCodeResponseBodyResultSource : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>master</para>
                /// </summary>
                [NameInMap("branch")]
                [Validation(Required=false)]
                public string Branch { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-10-10 10:00:00</para>
                /// </summary>
                [NameInMap("checkinDate")]
                [Validation(Required=false)]
                public string CheckinDate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test_utils.js</para>
                /// </summary>
                [NameInMap("fileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>spec/frontend/snippets/test_utils.js</para>
                /// </summary>
                [NameInMap("filePath")]
                [Validation(Required=false)]
                public string FilePath { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>JavaScript</para>
                /// </summary>
                [NameInMap("language")]
                [Validation(Required=false)]
                public string Language { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>60de7a6852743a5162b5f957</para>
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

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
