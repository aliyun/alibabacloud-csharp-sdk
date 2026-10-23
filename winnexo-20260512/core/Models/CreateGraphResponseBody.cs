// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class CreateGraphResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data source ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>198001</para>
        /// </summary>
        [NameInMap("dataSourceId")]
        [Validation(Required=false)]
        public long? DataSourceId { get; set; }

        /// <summary>
        /// <para>The graph name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>crm_graph</para>
        /// </summary>
        [NameInMap("graphName")]
        [Validation(Required=false)]
        public string GraphName { get; set; }

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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.0.0</para>
        /// </summary>
        [NameInMap("schemaVersion")]
        [Validation(Required=false)]
        public string SchemaVersion { get; set; }

        /// <summary>
        /// <para>The OSS synchronization and extraction status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>-1: Not set (default).</description></item>
        /// <item><description>0: Disabled.</description></item>
        /// <item><description>1: Enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("syncStatus")]
        [Validation(Required=false)]
        public string SyncStatus { get; set; }

    }

}
