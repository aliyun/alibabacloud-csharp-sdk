// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class RemoveKnowledgeUploadUserResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RemoveKnowledgeUploadUserResponseBodyData Data { get; set; }
        public class RemoveKnowledgeUploadUserResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The address of the knowledge base file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://bucketName/path/to/file.pdf</para>
            /// </summary>
            [NameInMap("FileLocation")]
            [Validation(Required=false)]
            public string FileLocation { get; set; }

            /// <summary>
            /// <para>The message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Successful</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The number of successfully deleted users.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Removed")]
            [Validation(Required=false)]
            public int? Removed { get; set; }

            /// <summary>
            /// <para>Indicates whether the request is successful. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Successful.</description></item>
            /// <item><description><b>false</b>: Failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

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
