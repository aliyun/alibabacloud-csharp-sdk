// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class AddKnowledgeUploadUserResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public AddKnowledgeUploadUserResponseBodyData Data { get; set; }
        public class AddKnowledgeUploadUserResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The location of the knowledge base file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://bucketName/path/to/file.pfg</para>
            /// </summary>
            [NameInMap("FileLocation")]
            [Validation(Required=false)]
            public string FileLocation { get; set; }

            /// <summary>
            /// <para>The prompt message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Successful</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The list of skipped users.</para>
            /// </summary>
            [NameInMap("Skipped")]
            [Validation(Required=false)]
            public List<AddKnowledgeUploadUserResponseBodyDataSkipped> Skipped { get; set; }
            public class AddKnowledgeUploadUserResponseBodyDataSkipped : TeaModel {
                /// <summary>
                /// <para>The reason why the user was skipped.</para>
                /// 
                /// <b>Example:</b>
                /// <para>conflicts error</para>
                /// </summary>
                [NameInMap("Reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

                /// <summary>
                /// <para>The username of the authorized user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_user</para>
                /// </summary>
                [NameInMap("User")]
                [Validation(Required=false)]
                public string User { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether the request was successful. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: The request was successful.</description></item>
            /// <item><description><b>false</b>: The request failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

            /// <summary>
            /// <para>The number of users that were successfully added.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Written")]
            [Validation(Required=false)]
            public int? Written { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>1AD222E9-E606-4A42-BF6D-8A4442913CEF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
