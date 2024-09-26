// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class TestNetworkConnectionResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID. You can locate logs and troubleshoot issues based on the ID.</para>
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

        /// <summary>
        /// <para>The information about the connectivity test.</para>
        /// </summary>
        [NameInMap("TaskList")]
        [Validation(Required=false)]
        public TestNetworkConnectionResponseBodyTaskList TaskList { get; set; }
        public class TestNetworkConnectionResponseBodyTaskList : TeaModel {
            /// <summary>
            /// <para>The reason why the data source and resource group failed the connectivity test. If data source and the resource group passed the connectivity test, this parameter is left empty.</para>
            /// </summary>
            [NameInMap("ConnectMessage")]
            [Validation(Required=false)]
            public string ConnectMessage { get; set; }

            /// <summary>
            /// <para>The result of the connectivity test. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The data source and the resource group passed the connectivity test.</description></item>
            /// <item><description>false: The data source and the resource group failed the connectivity test. You can troubleshoot issues based on the ConnectMessage parameter.</description></item>
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
