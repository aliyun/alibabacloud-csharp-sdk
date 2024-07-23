// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeImagePermissionResponseBody : TeaModel {
        /// <summary>
        /// <para>The IDs of the Alibaba Cloud accounts with which the image is shared.</para>
        /// </summary>
        [NameInMap("AliUids")]
        [Validation(Required=false)]
        public List<string> AliUids { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
