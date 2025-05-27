// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class GetCapacityResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the storage capacity.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetCapacityResponseBodyData Data { get; set; }
        public class GetCapacityResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether the Logstores for the threat analysis feature exist on the user side. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The logs are in the normal state. The log analysis feature is available.</description></item>
            /// <item><description>false: The logs are being cleared. The log analysis feature is unavailable.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ExistLogStore")]
            [Validation(Required=false)]
            public bool? ExistLogStore { get; set; }

            /// <summary>
            /// <para>The purchased storage capacity of the threat analysis feature. Unit: GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9000</para>
            /// </summary>
            [NameInMap("PreservedCapacity")]
            [Validation(Required=false)]
            public long? PreservedCapacity { get; set; }

            /// <summary>
            /// <para>The billable storage capacity of the threat analysis feature. Unit: GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("UsedCapacity")]
            [Validation(Required=false)]
            public double? UsedCapacity { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>27D27DCB-D76B-5064-8B3B-0900DEF7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
