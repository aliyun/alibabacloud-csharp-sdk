// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class CreateRDSToClickhouseDbResponseBody : TeaModel {
        /// <summary>
        /// <para>If -1 is returned for the <b>Status</b> parameter, the cause of the creation failure is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ClickHouse exception, code: 49, host: 100.100.79.102, port: 14540; Code: 49, e.displayText() = DB::Exception: Logical error: there is no global context (version 20.8.17.25)n</para>
        /// </summary>
        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <para>Duplicate tables in the synchronization task.</para>
        /// </summary>
        [NameInMap("RepeatedDbs")]
        [Validation(Required=false)]
        public List<string> RepeatedDbs { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>66676F54-1994-5DCF-993F-74536649628A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the synchronization task was created. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Created.</description></item>
        /// <item><description><b>0</b>: Creation failed. The tables in the synchronization task are duplicate. The duplicate tables are returned for the <b>RepeatedDbs</b> parameter.</description></item>
        /// <item><description><b>-1</b>: Creation failed. The cause why the creation failed is returned for the <b>ErrorMsg</b> parameter.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public long? Status { get; set; }

    }

}
