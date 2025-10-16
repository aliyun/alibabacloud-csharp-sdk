// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeAccessInstanceRegionListRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ready</para>
        /// </summary>
        [NameInMap("AccessInstanceStatus")]
        [Validation(Required=false)]
        public string AccessInstanceStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AckClusterConnector</para>
        /// </summary>
        [NameInMap("AccessInstanceType")]
        [Validation(Required=false)]
        public string AccessInstanceType { get; set; }

    }

}
