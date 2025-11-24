// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeClusterGrafanaResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about Grafana dashboards.</para>
        /// </summary>
        [NameInMap("Dashboards")]
        [Validation(Required=false)]
        public List<DescribeClusterGrafanaResponseBodyDashboards> Dashboards { get; set; }
        public class DescribeClusterGrafanaResponseBodyDashboards : TeaModel {
            /// <summary>
            /// <para>The title of the Grafana dashboard.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <para>The endpoint of the Grafana dashboard.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test.com</para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BD65C0AD-D3C6-48D3-8D93-38D2015C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
