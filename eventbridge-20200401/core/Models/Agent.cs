// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class Agent : TeaModel {
        /// <summary>
        /// <para>The creation time in UNIX milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1717200000000</para>
        /// </summary>
        [NameInMap("CreatedAt")]
        [Validation(Required=false)]
        public long? CreatedAt { get; set; }

        /// <summary>
        /// <para>The description of the agent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IoT device data query agent</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the MCP server associated with the agent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8vHW4mDRxxxxx</para>
        /// </summary>
        [NameInMap("McpServerId")]
        [Validation(Required=false)]
        public string McpServerId { get; set; }

        /// <summary>
        /// <para>The name of the MCP server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>data-analyze-agent</para>
        /// </summary>
        [NameInMap("McpServerName")]
        [Validation(Required=false)]
        public string McpServerName { get; set; }

        /// <summary>
        /// <para>The associated table metadata.</para>
        /// </summary>
        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public Metadata Metadata { get; set; }

        /// <summary>
        /// <para>The name of the agent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-agent</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The custom prompt.</para>
        /// 
        /// <b>Example:</b>
        /// <para>You are an IoT data analytics assistant...</para>
        /// </summary>
        [NameInMap("Prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

        /// <summary>
        /// <para>The update time in UNIX milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1717200000000</para>
        /// </summary>
        [NameInMap("UpdatedAt")]
        [Validation(Required=false)]
        public long? UpdatedAt { get; set; }

    }

}
