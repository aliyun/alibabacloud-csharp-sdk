// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeComputeResourceResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried specifications of computing resources.</para>
        /// </summary>
        [NameInMap("ComputeResource")]
        [Validation(Required=false)]
        public List<DescribeComputeResourceResponseBodyComputeResource> ComputeResource { get; set; }
        public class DescribeComputeResourceResponseBodyComputeResource : TeaModel {
            /// <summary>
            /// <para>The specifications of computing resources displayed in the console.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8 Core 32 GB（单机版）</para>
            /// </summary>
            [NameInMap("DisplayValue")]
            [Validation(Required=false)]
            public string DisplayValue { get; set; }

            /// <summary>
            /// <para>The actual specifications of computing resources.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8 Core 32 GB</para>
            /// </summary>
            [NameInMap("RealValue")]
            [Validation(Required=false)]
            public string RealValue { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1AD222E9-E606-4A42-BF6D-8A4442913CEAW</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
