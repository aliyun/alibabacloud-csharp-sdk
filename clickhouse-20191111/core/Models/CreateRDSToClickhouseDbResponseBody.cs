// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class CreateRDSToClickhouseDbResponseBody : TeaModel {
        /// <summary>
        /// <para>The reason for the creation failure. This parameter is returned only if the value of the Status parameter is <b>-1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ClickHouse exception, code: 49, host: 100.100.79.102, port: 14540; Code: 49, e.displayText() = DB::Exception: Logical error: there is no global context (version 20.8.17.25)n</para>
        /// </summary>
        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <para>The duplicate tables in the sync task.</para>
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
        /// <para>Indicates whether the task was created. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: The task was created.</para>
        /// </description></item>
        /// <item><description><para><b>0</b>: The task failed to be created because of duplicate tables. The duplicate tables are returned in the <b>RepeatedDbs</b> parameter.</para>
        /// </description></item>
        /// <item><description><para><b>-1</b>: The task failed to be created. The error message is returned in the <b>ErrorMsg</b> parameter.</para>
        /// </description></item>
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
