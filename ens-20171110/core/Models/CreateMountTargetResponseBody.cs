// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateMountTargetResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>70EACC9C-D07A-4A34-ADA4-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The state of the mount target. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>active</description></item>
        /// <item><description>inactive</description></item>
        /// <item><description>pending</description></item>
        /// <item><description>deleting</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>pending</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
