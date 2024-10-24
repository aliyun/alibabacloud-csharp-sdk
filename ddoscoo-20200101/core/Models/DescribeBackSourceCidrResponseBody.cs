// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeBackSourceCidrResponseBody : TeaModel {
        /// <summary>
        /// <para>An array that consists of the back-to-origin CIDR blocks of the instance.</para>
        /// </summary>
        [NameInMap("Cidrs")]
        [Validation(Required=false)]
        public List<string> Cidrs { get; set; }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0bcf28g5-d57c-11e7-9bs0-d89d6717dxbc</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
