// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateStorageGatewayResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of created nodes.</para>
        /// </summary>
        [NameInMap("AllocationId")]
        [Validation(Required=false)]
        public List<CreateStorageGatewayResponseBodyAllocationId> AllocationId { get; set; }
        public class CreateStorageGatewayResponseBodyAllocationId : TeaModel {
            /// <summary>
            /// <para>The ID of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-chengdu-telecom-4</para>
            /// </summary>
            [NameInMap("EnsRegionId")]
            [Validation(Required=false)]
            public string EnsRegionId { get; set; }

            /// <summary>
            /// <para>The ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>e426409223</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

        }

        /// <summary>
        /// <para>The success status code.</para>
        /// <list type="bullet">
        /// <item><description><b>PartSuccess</b>: partially succeeded.</description></item>
        /// <item><description><b>AllSuccess</b>: all succeeded.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AllSuccess</para>
        /// </summary>
        [NameInMap("BizStatusCode")]
        [Validation(Required=false)]
        public string BizStatusCode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EA3758E0-8899-17D3-9526-5F62CF33A586</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of nodes that are not created.</para>
        /// </summary>
        [NameInMap("UnAllocationId")]
        [Validation(Required=false)]
        public List<CreateStorageGatewayResponseBodyUnAllocationId> UnAllocationId { get; set; }
        public class CreateStorageGatewayResponseBodyUnAllocationId : TeaModel {
            /// <summary>
            /// <para>The ID of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-chengdu-26</para>
            /// </summary>
            [NameInMap("EnsRegionId")]
            [Validation(Required=false)]
            public string EnsRegionId { get; set; }

            /// <summary>
            /// <para>The ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>e426409258</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

        }

    }

}
