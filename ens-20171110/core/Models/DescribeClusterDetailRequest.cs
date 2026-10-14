// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeClusterDetailRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>Only ECK cluster IDs with the eck- prefix are accepted. Legacy short hexadecimal cluster IDs are not supported. Call DescribeClustersV1 to obtain the ID. When listing clusters, pass in the Name parameter.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eck-11111111</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

    }

}
