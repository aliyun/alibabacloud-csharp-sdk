// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class ListSmartAGByAccessPointResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AE203140-5D0C-4B4D-88D1-D008206B3A01</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the SAG instance.</para>
        /// </summary>
        [NameInMap("SmartAccessGateways")]
        [Validation(Required=false)]
        public List<ListSmartAGByAccessPointResponseBodySmartAccessGateways> SmartAccessGateways { get; set; }
        public class ListSmartAGByAccessPointResponseBodySmartAccessGateways : TeaModel {
            /// <summary>
            /// <para>The ID of the Cloud Connect Network (CCN) instance with which the SAG instance is associated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ccn-l42qf3vpvb****</para>
            /// </summary>
            [NameInMap("AssociatedCcnId")]
            [Validation(Required=false)]
            public string AssociatedCcnId { get; set; }

            /// <summary>
            /// <para>The model of the SAG device with which the SAG instance is associated. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>sag-1000</b>.</description></item>
            /// <item><description><b>sag-100WM</b>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>sag-1000</para>
            /// </summary>
            [NameInMap("HardwareVersion")]
            [Validation(Required=false)]
            public string HardwareVersion { get; set; }

            /// <summary>
            /// <para>The method that the SAG instance uses to synchronize Alibaba Cloud-facing routes. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>static</b>: static routing.</description></item>
            /// <item><description><b>dynamic</b>: dynamic routing.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>static</para>
            /// </summary>
            [NameInMap("RoutingStrategy")]
            [Validation(Required=false)]
            public string RoutingStrategy { get; set; }

            /// <summary>
            /// <para>The description of the SAG instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("SmartAGDescription")]
            [Validation(Required=false)]
            public string SmartAGDescription { get; set; }

            /// <summary>
            /// <para>The ID of the SAG instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sag-p86e06z4geaji1****</para>
            /// </summary>
            [NameInMap("SmartAGId")]
            [Validation(Required=false)]
            public string SmartAGId { get; set; }

            /// <summary>
            /// <para>The name of the SAG instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("SmartAGName")]
            [Validation(Required=false)]
            public string SmartAGName { get; set; }

            /// <summary>
            /// <para>The status of the SAG instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Active</b>: The SAG device is connected to Alibaba Cloud.</description></item>
            /// <item><description><b>offline</b>: The SAG device is disconnected from Alibaba Cloud.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Active</para>
            /// </summary>
            [NameInMap("SmartAGStatus")]
            [Validation(Required=false)]
            public string SmartAGStatus { get; set; }

        }

        /// <summary>
        /// <para>The number of SAG instances within the access point.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
