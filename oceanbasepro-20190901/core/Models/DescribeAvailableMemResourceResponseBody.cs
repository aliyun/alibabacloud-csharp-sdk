// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeAvailableMemResourceResponseBody : TeaModel {
        /// <summary>
        /// <para>The available memory size.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeAvailableMemResourceResponseBodyData Data { get; set; }
        public class DescribeAvailableMemResourceResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The maximum memory size for each resource unit, in GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("MaxMem")]
            [Validation(Required=false)]
            public long? MaxMem { get; set; }

            /// <summary>
            /// <para>The minimum memory size required for each resource unit, in GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("MinMem")]
            [Validation(Required=false)]
            public long? MinMem { get; set; }

            /// <summary>
            /// <para>The maximum allowed memory usage, in GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0</para>
            /// </summary>
            [NameInMap("SafeMem")]
            [Validation(Required=false)]
            public string SafeMem { get; set; }

            /// <summary>
            /// <para>The number of resource units in the tenant.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("UsedMem")]
            [Validation(Required=false)]
            public long? UsedMem { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EE205C00-30E4-<b><b>-</b></b>-87E3A8A2AA0C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
