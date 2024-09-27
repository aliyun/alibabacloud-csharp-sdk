// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class RunClusterCheckResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the cluster check task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1697100584236600453-ce0da5a1d627e4e9e9f96cae8ad07****-clustercheck-lboto</para>
        /// </summary>
        [NameInMap("check_id")]
        [Validation(Required=false)]
        public string CheckId { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>F04DF81D-5C12-1524-B36A-86E02526****</para>
        /// </summary>
        [NameInMap("request_id")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
