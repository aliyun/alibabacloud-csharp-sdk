// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class ListServiceInstanceFaultInjectionInfoResponseBody : TeaModel {
        [NameInMap("FaultInfoList")]
        [Validation(Required=false)]
        public List<ListServiceInstanceFaultInjectionInfoResponseBodyFaultInfoList> FaultInfoList { get; set; }
        public class ListServiceInstanceFaultInjectionInfoResponseBodyFaultInfoList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>{
            ///   &quot;FaultType&quot;: &quot;DiskBurnTask&quot;,
            ///   &quot;FaultArgs&quot;: {
            ///     &quot;FaultAction&quot;: &quot;burn&quot;,
            ///     &quot;Read&quot;: true,
            ///     &quot;Write&quot;: true,
            ///     &quot;Size&quot;: 100
            ///   }
            /// }</para>
            /// </summary>
            [NameInMap("FaultArgs")]
            [Validation(Required=false)]
            public object FaultArgs { get; set; }

            [NameInMap("FaultStatus")]
            [Validation(Required=false)]
            public ListServiceInstanceFaultInjectionInfoResponseBodyFaultInfoListFaultStatus FaultStatus { get; set; }
            public class ListServiceInstanceFaultInjectionInfoResponseBodyFaultInfoListFaultStatus : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>FaultInjectedSuccess</para>
                /// </summary>
                [NameInMap("FaultStatus")]
                [Validation(Required=false)]
                public string FaultStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Network interface not found</para>
                /// </summary>
                [NameInMap("FaultStatusMessage")]
                [Validation(Required=false)]
                public string FaultStatusMessage { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>DiskFillTask</para>
            /// </summary>
            [NameInMap("FaultType")]
            [Validation(Required=false)]
            public string FaultType { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>40325405-579C-4D82****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
