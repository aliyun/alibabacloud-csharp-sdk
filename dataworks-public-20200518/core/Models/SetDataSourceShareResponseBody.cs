// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class SetDataSourceShareResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the sharing operation.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public SetDataSourceShareResponseBodyData Data { get; set; }
        public class SetDataSourceShareResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The reason why the data source failed to be shared. If the data source is successfully shared, the value of this parameter is an empty string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>datasource is wrong</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>Indicates whether the data source was shared. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>success.</description></item>
            /// <item><description>fail. You can view the value of the Message parameter to identify the cause of the failure.</description></item>
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
        /// <para>The request ID.</para>
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
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
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
