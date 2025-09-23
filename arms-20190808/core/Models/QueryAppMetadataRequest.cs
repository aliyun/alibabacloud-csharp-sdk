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
        /// <para>The metadata IDs. Separate multiple IDs with commas (,).</para>
        /// <para>You can obtain the exception ID on the <b>Exception Analysis</b> page of your application in the ARMS console.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4c9dd447,3c76c565</para>
        /// </summary>
        [NameInMap("MetaIds")]
        [Validation(Required=false)]
        public string MetaIds { get; set; }

        /// <summary>
        /// <para>The metadata type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>sql: obtains an SQL statement based on sqlId.</description></item>
        /// <item><description>exception: obtains the exception stack based on exceptionId.</description></item>
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
        /// <para>The process identifier (PID) of the application. You can obtain the PID of an application by calling the <b>ListTraceApps</b> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ggxw4lnjuz@54364d85b97dc56</para>
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
