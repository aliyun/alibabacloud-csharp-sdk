// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class GetSourceResponseBody : TeaModel {
        /// <summary>
        /// <para>业务状态码：成功为 200，失败为后端错误码（ERR.* / InvalidParameter.*）</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>DocumentAgent 解析完成时间，ISO8601 格式</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-10-01T12:00:00Z</para>
        /// </summary>
        [NameInMap("completionTime")]
        [Validation(Required=false)]
        public string CompletionTime { get; set; }

        /// <summary>
        /// <para>数据源描述</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例描述</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>创建时间，ISO8601 格式</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("gmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// <para>修改时间，ISO8601 格式</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("gmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// <para>是否存在备注</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("hasNotes")]
        [Validation(Required=false)]
        public bool? HasNotes { get; set; }

        /// <summary>
        /// <para>是否存在 settings 配置</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("hasSettings")]
        [Validation(Required=false)]
        public bool? HasSettings { get; set; }

        /// <summary>
        /// <para>是否存在结构化表</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("hasStructuredTables")]
        [Validation(Required=false)]
        public bool? HasStructuredTables { get; set; }

        /// <summary>
        /// <para>是否存在非结构化文档</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("hasUnstructuredDocs")]
        [Validation(Required=false)]
        public bool? HasUnstructuredDocs { get; set; }

        /// <summary>
        /// <para>错误描述，成功时为空</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>文件名</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例名称.pdf</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>备注（仅 includeDetails=True）</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("notes")]
        [Validation(Required=false)]
        public string Notes { get; set; }

        [NameInMap("objectBindings")]
        [Validation(Required=false)]
        public List<GetSourceResponseBodyObjectBindings> ObjectBindings { get; set; }
        public class GetSourceResponseBodyObjectBindings : TeaModel {
            /// <summary>
            /// <para>对象归属的语义图谱名</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("graphName")]
            [Validation(Required=false)]
            public string GraphName { get; set; }

            /// <summary>
            /// <para>对象 ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>exampleObjectId</para>
            /// </summary>
            [NameInMap("objectId")]
            [Validation(Required=false)]
            public string ObjectId { get; set; }

            /// <summary>
            /// <para>对象类型</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("objectType")]
            [Validation(Required=false)]
            public string ObjectType { get; set; }

        }

        /// <summary>
        /// <para>主对象 ID（兼容字段）</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleObjectId</para>
        /// </summary>
        [NameInMap("objectId")]
        [Validation(Required=false)]
        public string ObjectId { get; set; }

        /// <summary>
        /// <para>主对象类型（兼容字段）</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("objectType")]
        [Validation(Required=false)]
        public string ObjectType { get; set; }

        /// <summary>
        /// <para>运营对象名称</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("operatingObjectName")]
        [Validation(Required=false)]
        public string OperatingObjectName { get; set; }

        /// <summary>
        /// <para>请求追踪 ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>可见范围：PERSONAL / TENANT</para>
        /// 
        /// <b>Example:</b>
        /// <para>PERSONAL</para>
        /// </summary>
        [NameInMap("scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        [NameInMap("settings")]
        [Validation(Required=false)]
        public Dictionary<string, object> Settings { get; set; }

        /// <summary>
        /// <para>技能产出 ID（由产出保存为资源时携带）</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleSkillOutputId</para>
        /// </summary>
        [NameInMap("skillOutputId")]
        [Validation(Required=false)]
        public string SkillOutputId { get; set; }

        /// <summary>
        /// <para>数据源 ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleSourceId</para>
        /// </summary>
        [NameInMap("sourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

        /// <summary>
        /// <para>数据源归属类型：normal / aliding_kb_doc</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("sourceKind")]
        [Validation(Required=false)]
        public string SourceKind { get; set; }

        /// <summary>
        /// <para>资源标签 JSON 字符串</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("sourceTags")]
        [Validation(Required=false)]
        public string SourceTags { get; set; }

        /// <summary>
        /// <para>数据源类型</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("sourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>数据源状态</para>
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

        [NameInMap("unstructuredDocs")]
        [Validation(Required=false)]
        public List<GetSourceResponseBodyUnstructuredDocs> UnstructuredDocs { get; set; }
        public class GetSourceResponseBodyUnstructuredDocs : TeaModel {
            /// <summary>
            /// <para>DocumentAgent 解析完成时间，ISO8601 格式</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-10-01T12:00:00Z</para>
            /// </summary>
            [NameInMap("completionTime")]
            [Validation(Required=false)]
            public string CompletionTime { get; set; }

            /// <summary>
            /// <para>文件名</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.pdf</para>
            /// </summary>
            [NameInMap("fileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <para>文件记录 ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>exampleFileRecordId</para>
            /// </summary>
            [NameInMap("fileRecordId")]
            [Validation(Required=false)]
            public string FileRecordId { get; set; }

            /// <summary>
            /// <para>文件类型</para>
            /// 
            /// <b>Example:</b>
            /// <para>pdf</para>
            /// </summary>
            [NameInMap("fileType")]
            [Validation(Required=false)]
            public string FileType { get; set; }

            /// <summary>
            /// <para>OSS 远程 URL</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.com/winnexo/resource">https://example.com/winnexo/resource</a></para>
            /// </summary>
            [NameInMap("ossUrl")]
            [Validation(Required=false)]
            public string OssUrl { get; set; }

            /// <summary>
            /// <para>DocumentAgent 语义 ID</para>
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
