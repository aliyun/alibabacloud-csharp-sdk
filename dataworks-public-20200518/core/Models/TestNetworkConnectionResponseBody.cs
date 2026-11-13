// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class TestNetworkConnectionResponseBody : TeaModel {
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
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request is successful.</description></item>
        /// <item><description>false: The request fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The results of the network connectivity test between the data source and the resource group.</para>
        /// </summary>
        [NameInMap("TaskList")]
        [Validation(Required=false)]
        public TestNetworkConnectionResponseBodyTaskList TaskList { get; set; }
        public class TestNetworkConnectionResponseBodyTaskList : TeaModel {
            /// <summary>
            /// <para>The cause of the failure if the network connectivity test between the destination data source and the resource group fails. If the test is successful, this parameter is left empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Connectable</para>
            /// </summary>
            [NameInMap("ConnectMessage")]
            [Validation(Required=false)]
            public string ConnectMessage { get; set; }

            /// <summary>
            /// <para>The result of the network connectivity test between the destination data source and the resource group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The network connectivity test is successful.</description></item>
            /// <item><description>false: The network connectivity test fails. You can check the ConnectMessage parameter to locate the cause of the failure.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ConnectStatus")]
            [Validation(Required=false)]
            public bool? ConnectStatus { get; set; }

        }

    }

}
