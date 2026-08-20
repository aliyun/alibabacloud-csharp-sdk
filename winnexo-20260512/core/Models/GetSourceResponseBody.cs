// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class GetSourceResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The completion time, in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-10-01T12:00:00Z</para>
        /// </summary>
        [NameInMap("completionTime")]
        [Validation(Required=false)]
        public string CompletionTime { get; set; }

        /// <summary>
        /// <para>The description of the to-do card type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sample description</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("gmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// <para>The last modification time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("gmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// <para>Indicates whether notes exist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("hasNotes")]
        [Validation(Required=false)]
        public bool? HasNotes { get; set; }

        /// <summary>
        /// <para>Indicates whether settings configuration exists.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("hasSettings")]
        [Validation(Required=false)]
        public bool? HasSettings { get; set; }

        /// <summary>
        /// <para>Indicates whether structured tables exist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("hasStructuredTables")]
        [Validation(Required=false)]
        public bool? HasStructuredTables { get; set; }

        /// <summary>
        /// <para>Indicates whether unstructured documents exist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("hasUnstructuredDocs")]
        [Validation(Required=false)]
        public bool? HasUnstructuredDocs { get; set; }

        /// <summary>
        /// <para>The status code description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The username.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SampleName.pdf</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The meeting notes content (optional), which participates in auxiliary analysis.</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("notes")]
        [Validation(Required=false)]
        public string Notes { get; set; }

        /// <summary>
        /// <para>The object bindings.</para>
        /// </summary>
        [NameInMap("objectBindings")]
        [Validation(Required=false)]
        public List<GetSourceResponseBodyObjectBindings> ObjectBindings { get; set; }
        public class GetSourceResponseBodyObjectBindings : TeaModel {
            /// <summary>
            /// <para>The semantic graph name to which the object belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("graphName")]
            [Validation(Required=false)]
            public string GraphName { get; set; }

            /// <summary>
            /// <para>The ID of the recommended item, which can be a <b>feedId</b> or a micro-application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>exampleObjectId</para>
            /// </summary>
            [NameInMap("objectId")]
            [Validation(Required=false)]
            public string ObjectId { get; set; }

            /// <summary>
            /// <para>The object type, such as customer. This field has a value when type is set to mention.</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("objectType")]
            [Validation(Required=false)]
            public string ObjectType { get; set; }

        }

        /// <summary>
        /// <para>The associated variable ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleObjectId</para>
        /// </summary>
        [NameInMap("objectId")]
        [Validation(Required=false)]
        public string ObjectId { get; set; }

        /// <summary>
        /// <para>The object type, such as customer. This field has a value when type is set to mention.</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("objectType")]
        [Validation(Required=false)]
        public string ObjectType { get; set; }

        /// <summary>
        /// <para>The digital employee name (operating object name, optional).</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("operatingObjectName")]
        [Validation(Required=false)]
        public string OperatingObjectName { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The task scope.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PERSONAL</para>
        /// </summary>
        [NameInMap("scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        /// <summary>
        /// <para>The user profile card settings.</para>
        /// </summary>
        [NameInMap("settings")]
        [Validation(Required=false)]
        public Dictionary<string, object> Settings { get; set; }

        /// <summary>
        /// <para>The skill output ID (carried when the output is saved as a resource).</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleSkillOutputId</para>
        /// </summary>
        [NameInMap("skillOutputId")]
        [Validation(Required=false)]
        public string SkillOutputId { get; set; }

        /// <summary>
        /// <para>The data source ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleSourceId</para>
        /// </summary>
        [NameInMap("sourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

        /// <summary>
        /// <para>The knowledge base affiliation type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>aliding_kb_doc: DingTalk knowledge base document.</description></item>
        /// <item><description>normal: common knowledge.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("sourceKind")]
        [Validation(Required=false)]
        public string SourceKind { get; set; }

        /// <summary>
        /// <para>The resource tags (optional, a JSON string list such as [&quot;tagA&quot;,&quot;tagB&quot;]).</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("sourceTags")]
        [Validation(Required=false)]
        public string SourceTags { get; set; }

        /// <summary>
        /// <para>The resource type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("sourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The final status of the message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>READY</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>structuredTables</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("structuredTables")]
        [Validation(Required=false)]
        public List<string> StructuredTables { get; set; }

        /// <summary>
        /// <para>The unstructured documents.</para>
        /// </summary>
        [NameInMap("unstructuredDocs")]
        [Validation(Required=false)]
        public List<GetSourceResponseBodyUnstructuredDocs> UnstructuredDocs { get; set; }
        public class GetSourceResponseBodyUnstructuredDocs : TeaModel {
            /// <summary>
            /// <para>The completion time, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-10-01T12:00:00Z</para>
            /// </summary>
            [NameInMap("completionTime")]
            [Validation(Required=false)]
            public string CompletionTime { get; set; }

            /// <summary>
            /// <para>The file name, including the file name extension.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.pdf</para>
            /// </summary>
            [NameInMap("fileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <para>The file record ID (optional, corresponding to settings.file_record_id).</para>
            /// 
            /// <b>Example:</b>
            /// <para>exampleFileRecordId</para>
            /// </summary>
            [NameInMap("fileRecordId")]
            [Validation(Required=false)]
            public string FileRecordId { get; set; }

            /// <summary>
            /// <para>The file type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>file</b>: file.</description></item>
            /// <item><description><b>folder</b>: folder.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>pdf</para>
            /// </summary>
            [NameInMap("fileType")]
            [Validation(Required=false)]
            public string FileType { get; set; }

            /// <summary>
            /// <para>The session analysis result in OSS URL format. The URL expires in one hour.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.com/winnexo/resource">https://example.com/winnexo/resource</a></para>
            /// </summary>
            [NameInMap("ossUrl")]
            [Validation(Required=false)]
            public string OssUrl { get; set; }

            /// <summary>
            /// <para>The DocumentAgent semantic ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>exampleSemanticsId</para>
            /// </summary>
            [NameInMap("semanticsId")]
            [Validation(Required=false)]
            public string SemanticsId { get; set; }

        }

    }

}
