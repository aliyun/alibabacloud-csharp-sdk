// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class AddKnowledgeTagsResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public AddKnowledgeTagsResponseBodyData Data { get; set; }
        public class AddKnowledgeTagsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The location of the knowledge base file.</para>
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
            /// <para>1 tag skipped</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The number of tags that were successfully updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Replaced")]
            [Validation(Required=false)]
            public int? Replaced { get; set; }

            /// <summary>
            /// <para>The list of skipped tags.</para>
            /// </summary>
            [NameInMap("Skipped")]
            [Validation(Required=false)]
            public List<AddKnowledgeTagsResponseBodyDataSkipped> Skipped { get; set; }
            public class AddKnowledgeTagsResponseBodyDataSkipped : TeaModel {
                /// <summary>
                /// <para>The reason why the tag was skipped.</para>
                /// 
                /// <b>Example:</b>
                /// <para>conflict</para>
                /// </summary>
                [NameInMap("Reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

                /// <summary>
                /// <para>The key of the tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>skipKey</para>
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <para>The value of the tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>skipValue</para>
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

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
            /// <para>The number of tags that were successfully added.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
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
