// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class HandleActiveSQLRecordResponseBody : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gp-bp***************</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABB39CC3-4488-4857-905D-2E4A051D0521</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The processing results of the active queries.</para>
        /// </summary>
        [NameInMap("Results")]
        [Validation(Required=false)]
        public List<HandleActiveSQLRecordResponseBodyResults> Results { get; set; }
        public class HandleActiveSQLRecordResponseBodyResults : TeaModel {
            /// <summary>
            /// <para>The process ID, which is the unique identifier of the active query SQL statement.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3003925</para>
            /// </summary>
            [NameInMap("Pid")]
            [Validation(Required=false)]
            public string Pid { get; set; }

            /// <summary>
            /// <para>The status of the processing result. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>false</b>: The processing failed.</description></item>
            /// <item><description><b>true</b>: The processing succeeded.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The execution status of the API operation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b>: The execution failed.</description></item>
        /// <item><description><b>true</b>: The execution succeeded.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
