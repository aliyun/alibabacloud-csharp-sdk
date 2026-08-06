// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIRegistry20260317.Models
{
    public class GetPromptVersionResponseBody : TeaModel {
        /// <summary>
        /// <para>Query result</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetPromptVersionResponseBodyData Data { get; set; }
        public class GetPromptVersionResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Commit message of this version</para>
            /// 
            /// <b>Example:</b>
            /// <para>This is a test version</para>
            /// </summary>
            [NameInMap("CommitMsg")]
            [Validation(Required=false)]
            public string CommitMsg { get; set; }

            /// <summary>
            /// <para>Last modified time of the prompt</para>
            /// 
            /// <b>Example:</b>
            /// <para>1605345828000</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// <para>MD5 hash of the prompt content for this version</para>
            /// 
            /// <b>Example:</b>
            /// <para>93EF3AC0C56DDACB5A9E528BB1C825C8</para>
            /// </summary>
            [NameInMap("Md5")]
            [Validation(Required=false)]
            public string Md5 { get; set; }

            /// <summary>
            /// <para>Unique identifier of the prompt</para>
            /// 
            /// <b>Example:</b>
            /// <para>customer-service-qa</para>
            /// </summary>
            [NameInMap("PromptKey")]
            [Validation(Required=false)]
            public string PromptKey { get; set; }

            /// <summary>
            /// <para>Creator of this version</para>
            /// 
            /// <b>Example:</b>
            /// <para>admin</para>
            /// </summary>
            [NameInMap("SrcUser")]
            [Validation(Required=false)]
            public string SrcUser { get; set; }

            /// <summary>
            /// <para>Version status. Draft: draft / Published: online</para>
            /// 
            /// <b>Example:</b>
            /// <para>online</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Template content of the prompt version</para>
            /// 
            /// <b>Example:</b>
            /// <para>You are a {{domain}} expert.</para>
            /// </summary>
            [NameInMap("Template")]
            [Validation(Required=false)]
            public string Template { get; set; }

            /// <summary>
            /// <para>List of variables for this version</para>
            /// </summary>
            [NameInMap("Variables")]
            [Validation(Required=false)]
            public List<GetPromptVersionResponseBodyDataVariables> Variables { get; set; }
            public class GetPromptVersionResponseBodyDataVariables : TeaModel {
                /// <summary>
                /// <para>Default value</para>
                /// 
                /// <b>Example:</b>
                /// <para>code</para>
                /// </summary>
                [NameInMap("DefaultValue")]
                [Validation(Required=false)]
                public string DefaultValue { get; set; }

                /// <summary>
                /// <para>Variable description</para>
                /// 
                /// <b>Example:</b>
                /// <para>domain</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Variable name</para>
                /// 
                /// <b>Example:</b>
                /// <para>domain</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>Version number</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0.1</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>D9E87E66-9EF0-5C10-A5E6-924020A0C9B7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
