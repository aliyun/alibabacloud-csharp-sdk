// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeClusterResponseBody : TeaModel {
        [NameInMap("Clusters")]
        [Validation(Required=false)]
        public List<DescribeClusterResponseBodyClusters> Clusters { get; set; }
        public class DescribeClusterResponseBodyClusters : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>c8f0377146d104687ac562eef9403****</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1.18.8</para>
            /// </summary>
            [NameInMap("CurrentVersion")]
            [Validation(Required=false)]
            public string CurrentVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vc-a622bb**</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1.20.8</para>
            /// </summary>
            [NameInMap("NextVersion")]
            [Validation(Required=false)]
            public string NextVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>healthy</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CEF72CEB-54B6-4AE8-B225-F876FF7BA984</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
