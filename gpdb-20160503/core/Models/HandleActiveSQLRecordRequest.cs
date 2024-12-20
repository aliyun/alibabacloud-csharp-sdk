// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class HandleActiveSQLRecordRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gp-bp***************</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The type of the operation on the process ID. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: cancel.</description></item>
        /// <item><description><b>1</b>: terminate.</description></item>
        /// <item><description><b>2</b>: forcefully terminate.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("OperateType")]
        [Validation(Required=false)]
        public int? OperateType { get; set; }

        /// <summary>
        /// <para>The process IDs. A process ID is a unique identifier of a query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;3003925,3003928&quot;</para>
        /// </summary>
        [NameInMap("Pids")]
        [Validation(Required=false)]
        public string Pids { get; set; }

    }

}
