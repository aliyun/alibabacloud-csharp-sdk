// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class GetGroupSourceResponseBody : TeaModel {
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
        /// <para>The pipeline description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>recorder function</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The time when the resource was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-08-26T10:00:00+08:00</para>
        /// </summary>
        [NameInMap("gmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// <para>The time when the resource was last modified, in ISO 8601 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-08-20T14:00:00+08:00</para>
        /// </summary>
        [NameInMap("gmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// <para>The project group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleGroupId</para>
        /// </summary>
        [NameInMap("groupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The description of the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SampleName.pdf</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The request trace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The permission scope.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GROUP</para>
        /// </summary>
        [NameInMap("scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

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
        /// <para>The knowledge base ownership type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>aliding_kb_doc: DingTalk knowledge base document.</description></item>
        /// <item><description>normal: Common knowledge.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("sourceKind")]
        [Validation(Required=false)]
        public string SourceKind { get; set; }

        /// <summary>
        /// <para>The resource tags. This parameter is optional. The value is a JSON string list, such as [&quot;tagA&quot;,&quot;tagB&quot;].</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;Important&quot;,&quot;Document&quot;]</para>
        /// </summary>
        [NameInMap("sourceTags")]
        [Validation(Required=false)]
        public string SourceTags { get; set; }

        /// <summary>
        /// <para>The type of the resource source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ExportTaskId: The resource export ID.</description></item>
        /// <item><description>TaskId: The module execution task ID.</description></item>
        /// <item><description>StatePath: The OSS path where the resource state is stored.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("sourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The resource status. The initial status during the creation process is typically PENDING. If the on_create operation fails, the status is FAILED.</para>
        /// 
        /// <b>Example:</b>
        /// <para>READY</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
