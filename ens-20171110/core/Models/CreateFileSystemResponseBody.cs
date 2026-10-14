// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateFileSystemResponseBody : TeaModel {
        /// <summary>
        /// <para>The file systems that are created.</para>
        /// </summary>
        [NameInMap("AllocationId")]
        [Validation(Required=false)]
        public List<string> AllocationId { get; set; }

        /// <summary>
        /// <para>The list of instance allocation information for the file system across ENS edge zones.</para>
        /// </summary>
        [NameInMap("AllocationIds")]
        [Validation(Required=false)]
        public List<CreateFileSystemResponseBodyAllocationIds> AllocationIds { get; set; }
        public class CreateFileSystemResponseBodyAllocationIds : TeaModel {
            /// <summary>
            /// <para>The ENS edge zone ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-cm</para>
            /// </summary>
            [NameInMap("EnsRegionId")]
            [Validation(Required=false)]
            public string EnsRegionId { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-5s7xxxxxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

        }

        /// <summary>
        /// <para>The status code that indicates the result. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description>PartSuccess: partially successful.</description></item>
        /// <item><description>AllSuccess: all successful.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PartSuccess</para>
        /// </summary>
        [NameInMap("BizStatusCode")]
        [Validation(Required=false)]
        public string BizStatusCode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4EC47282-1B74-4534-BD0E-403F3EE64CAF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The file systems that failed to be created.</para>
        /// </summary>
        [NameInMap("UnAllocationId")]
        [Validation(Required=false)]
        public List<string> UnAllocationId { get; set; }

    }

}
