// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class ListChatMessagesResponseBody : TeaModel {
        /// <summary>
        /// <para>A compatibility field. The V2 response does not return MaxResults.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>A compatibility field. The V2 response does not return a message array.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("Messages")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> Messages { get; set; }

        /// <summary>
        /// <para>A compatibility field. The V2 response does not return NextToken.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CAES...</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The pre-signed download URL for the Pipeline file a2a-snapshot.json. The URL is valid for 1800 seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://oss.example/a2a-snapshot.json?signature=REDACTED">https://oss.example/a2a-snapshot.json?signature=REDACTED</a></para>
        /// </summary>
        [NameInMap("PipelineSnapshotDownloadUrl")]
        [Validation(Required=false)]
        public string PipelineSnapshotDownloadUrl { get; set; }

        /// <summary>
        /// <para>The OpenAPI request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4C68F7A5-2D16-5C8F-A4B1-01E9C6A9B0D2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The pre-signed download URL for the session messages file session.jsonl. The URL is valid for 1800 seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://oss.example/session.jsonl?signature=REDACTED">https://oss.example/session.jsonl?signature=REDACTED</a></para>
        /// </summary>
        [NameInMap("SessionMessagesDownloadUrl")]
        [Validation(Required=false)]
        public string SessionMessagesDownloadUrl { get; set; }

        /// <summary>
        /// <para>The session title. This value may be empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Create VPC template</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
