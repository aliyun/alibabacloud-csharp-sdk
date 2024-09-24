// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeContainerServiceK8sClusterKritisStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The Kritis status of the ACK cluster.</para>
        /// </summary>
        [NameInMap("KritisStatus")]
        [Validation(Required=false)]
        public DescribeContainerServiceK8sClusterKritisStatusResponseBodyKritisStatus KritisStatus { get; set; }
        public class DescribeContainerServiceK8sClusterKritisStatusResponseBodyKritisStatus : TeaModel {
            /// <summary>
            /// <para>Indicates whether Kritis is installed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Install")]
            [Validation(Required=false)]
            public bool? Install { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BE120DAB-F4E7-4C53-ADC3-A97578AB****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
