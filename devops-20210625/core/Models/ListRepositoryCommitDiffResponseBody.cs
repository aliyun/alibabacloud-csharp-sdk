// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListRepositoryCommitDiffResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
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
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>0EE38A4E-8991-532A-8E8B-5C22B5D2E058</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListRepositoryCommitDiffResponseBodyResult> Result { get; set; }
        public class ListRepositoryCommitDiffResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>100644</para>
            /// </summary>
            [NameInMap("aMode")]
            [Validation(Required=false)]
            public string AMode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100755</para>
            /// </summary>
            [NameInMap("bMode")]
            [Validation(Required=false)]
            public string BMode { get; set; }

            [NameInMap("deletedFile")]
            [Validation(Required=false)]
            public bool? DeletedFile { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>--- /dev/null\n+++ b/src/test/java/com/aliyun/codeupdemo/CodeupDemoApplicationTests.java\n@@ -0,0 +1,13 @@\n+package com.aliyun.codeupdemo;\n+\n+import org.junit.jupiter.api.Test;\n+import org.springframework.boot.test.context.SpringBootTest;\n+\n+@SpringBootTest\n+class CodeupDemoApplicationTest {\n+\n+ @Test\n+ void contextLoads() {\n+ }\n+\n+}\n</para>
            /// </summary>
            [NameInMap("diff")]
            [Validation(Required=false)]
            public string Diff { get; set; }

            [NameInMap("isBinary")]
            [Validation(Required=false)]
            public bool? IsBinary { get; set; }

            [NameInMap("isNewLfs")]
            [Validation(Required=false)]
            public bool? IsNewLfs { get; set; }

            [NameInMap("isOldLfs")]
            [Validation(Required=false)]
            public bool? IsOldLfs { get; set; }

            [NameInMap("newFile")]
            [Validation(Required=false)]
            public bool? NewFile { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>6c268061a546378276559c713d0ad377d4xxxxxx</para>
            /// </summary>
            [NameInMap("newId")]
            [Validation(Required=false)]
            public string NewId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>src/test/java/com/aliyun/codeupdemo/CodeupDemoApplicationTests.java</para>
            /// </summary>
            [NameInMap("newPath")]
            [Validation(Required=false)]
            public string NewPath { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0000000000000000000000000000000000000000</para>
            /// </summary>
            [NameInMap("oldId")]
            [Validation(Required=false)]
            public string OldId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>src/test/java/com/aliyun/codeupdemo/CodeupDemoApplicationTests.java</para>
            /// </summary>
            [NameInMap("oldPath")]
            [Validation(Required=false)]
            public string OldPath { get; set; }

            [NameInMap("renamedFile")]
            [Validation(Required=false)]
            public bool? RenamedFile { get; set; }

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
