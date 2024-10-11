// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class ModifyRDSToClickhouseDbResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public long? ErrorCode { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description>If the value <b>1</b> is returned for the <b>Status</b> parameter, the system does not return the ErrorMsg parameter.</description></item>
        /// <item><description>If the value <b>0</b> is returned for the <b>Status</b> parameter, the ErrorMsg parameter returns the cause for the modification failure.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ClickHouse exception, code: 49, host: 100.100.118.132, port: 49670; Code: 49, e.displayText() = DB::Exception: Logical error: there is no global context (version 20.8.17.25)n</para>
        /// </summary>
        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>746CD303-0B82-5E8D-886D-93A9FAF3A876</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the modification was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: The modification was successful.</description></item>
        /// <item><description><b>0</b>: The modification failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public long? Status { get; set; }

    }

}
