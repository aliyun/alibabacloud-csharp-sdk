// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class QueryTaskInfoHistoryRequest : TeaModel {
        /// <summary>
        /// <para>Start time of the creation date range for the query, expressed as the number of milliseconds since 00:00 UTC on January 1, 1970. Currently supports queries by day only.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1522080000000</para>
        /// </summary>
        [NameInMap("BeginCreateTime")]
        [Validation(Required=false)]
        public long? BeginCreateTime { get; set; }

        /// <summary>
        /// <para>Cursor for creation date (technical parameter).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1522080000000</para>
        /// </summary>
        [NameInMap("CreateTimeCursor")]
        [Validation(Required=false)]
        public long? CreateTimeCursor { get; set; }

        /// <summary>
        /// <para>End time of the creation date range for the query, expressed as the number of milliseconds since 00:00 UTC on January 1, 1970. Currently supports queries by day only.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1522080000000</para>
        /// </summary>
        [NameInMap("EndCreateTime")]
        [Validation(Required=false)]
        public long? EndCreateTime { get; set; }

        /// <summary>
        /// <para>Language for API error messages. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese  </description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// <para>Default value is <b>en</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>Page size.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Job cursor; pass in the job number from the corresponding page cursor during pagination (technical parameter).</para>
        /// 
        /// <b>Example:</b>
        /// <para>aa634d3f-927e-4d17-9d2c-test</para>
        /// </summary>
        [NameInMap("TaskNoCursor")]
        [Validation(Required=false)]
        public string TaskNoCursor { get; set; }

        /// <summary>
        /// <para>User IP address, which can be set to <b>127.0.0.1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>127.0.0.1</para>
        /// </summary>
        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

    }

}
