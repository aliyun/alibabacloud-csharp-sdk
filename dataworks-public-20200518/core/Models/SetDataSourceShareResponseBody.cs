// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class SetDataSourceShareResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data for sharing the target data source.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public SetDataSourceShareResponseBodyData Data { get; set; }
        public class SetDataSourceShareResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The description of the cause for the failure to share the target data source. If the target data source is shared, the value of this parameter is empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>datasource is wrong</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The result status of sharing the target data source. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>success: The target data source was shared.</description></item>
            /// <item><description>fail: The target data source failed to be shared. You can check the Message parameter to locate the cause of the failure.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The unique ID of the request. You can use the ID to locate logs and troubleshoot issues when an error occurs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0000-ABCD-EFG</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request was successful.</description></item>
        /// <item><description>false: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
