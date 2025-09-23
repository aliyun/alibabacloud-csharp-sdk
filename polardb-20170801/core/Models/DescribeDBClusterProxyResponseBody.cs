// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDBClusterProxyResponseBody : TeaModel {
        [NameInMap("ChildInstances")]
        [Validation(Required=false)]
        public List<DescribeDBClusterProxyResponseBodyChildInstances> ChildInstances { get; set; }
        public class DescribeDBClusterProxyResponseBodyChildInstances : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>polar.mysql.g4.medium</para>
            /// </summary>
            [NameInMap("DBNodeClass")]
            [Validation(Required=false)]
            public string DBNodeClass { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10.*.*10</para>
            /// </summary>
            [NameInMap("DBNodeIP")]
            [Validation(Required=false)]
            public string DBNodeIP { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pi-wz97h479y364g9du7</para>
            /// </summary>
            [NameInMap("DBNodeId")]
            [Validation(Required=false)]
            public string DBNodeId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2450</para>
            /// </summary>
            [NameInMap("DBNodePort")]
            [Validation(Required=false)]
            public string DBNodePort { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("DBNodeStatus")]
            [Validation(Required=false)]
            public string DBNodeStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>sh-lsf01-144-37</para>
            /// </summary>
            [NameInMap("HostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>pe-xxxxxxxxx</para>
        /// </summary>
        [NameInMap("DBProxyClusterId")]
        [Validation(Required=false)]
        public string DBProxyClusterId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("DBProxyClusterNum")]
        [Validation(Required=false)]
        public long? DBProxyClusterNum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ClassChanging</para>
        /// </summary>
        [NameInMap("DBProxyClusterStatus")]
        [Validation(Required=false)]
        public string DBProxyClusterStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30E11ED2-C922-5B96-BCC6-11EE8C484AC6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
