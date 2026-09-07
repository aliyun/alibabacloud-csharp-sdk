// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class QueryAppMetadataRequest : TeaModel {
        [NameInMap("EndTimeMs")]
        [Validation(Required=false)]
        public long? EndTimeMs { get; set; }

        /// <summary>
        /// <para>The metadata IDs. Use a comma (,) to separate multiple IDs.</para>
        /// <para>You can obtain the exception ID on the <b>exception analysis</b> page of the target application in the ARMS console.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4c9dd447,3c76c565</para>
        /// </summary>
        [NameInMap("MetaIds")]
        [Validation(Required=false)]
        public string MetaIds { get; set; }

        /// <summary>
        /// <para>The type of the metadata. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>sql: Retrieves the SQL statement by sqlId.</para>
        /// </description></item>
        /// <item><description><para>exception: Retrieves the exception stack by exceptionId.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sql</para>
        /// </summary>
        [NameInMap("MetaType")]
        [Validation(Required=false)]
        public string MetaType { get; set; }

        /// <summary>
        /// <para>The application ID. To obtain the ID, call the <b>ListTraceApps</b> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ggxw4lnjuz@54364d85b******</para>
        /// </summary>
        [NameInMap("Pid")]
        [Validation(Required=false)]
        public string Pid { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("StartTimeMs")]
        [Validation(Required=false)]
        public long? StartTimeMs { get; set; }

    }

}
