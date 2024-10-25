// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateFileSystemResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the file system that was created.</para>
        /// </summary>
        [NameInMap("AllocationId")]
        [Validation(Required=false)]
        public List<string> AllocationId { get; set; }

        /// <summary>
        /// <para>The status code for successful operations. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PartSuccess: The operation is partially successful.</description></item>
        /// <item><description>AllSuccess: The operation is successful.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PartSuccess</para>
        /// </summary>
        [NameInMap("BizStatusCode")]
        [Validation(Required=false)]
        public string BizStatusCode { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4EC47282-1B74-4534-BD0E-403F3EE64CAF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the file system that failed to be created.</para>
        /// </summary>
        [NameInMap("UnAllocationId")]
        [Validation(Required=false)]
        public List<string> UnAllocationId { get; set; }

    }

}
