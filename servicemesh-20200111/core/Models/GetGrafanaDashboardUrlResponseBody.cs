// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class GetGrafanaDashboardUrlResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the dashboard.</para>
        /// </summary>
        [NameInMap("Dashboards")]
        [Validation(Required=false)]
        public List<GetGrafanaDashboardUrlResponseBodyDashboards> Dashboards { get; set; }
        public class GetGrafanaDashboardUrlResponseBodyDashboards : TeaModel {
            /// <summary>
            /// <para>The name of the dashboard.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Cloud ASM Istio Http Gateway</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <para>The URL of the dashboard.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://g.console.aliyun.com/d/181863583797****-14651340-200-2/alibaba-cloud-mesh-service?orgId=32****&refresh=60s">https://g.console.aliyun.com/d/181863583797****-14651340-200-2/alibaba-cloud-mesh-service?orgId=32****&amp;refresh=60s</a></para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>76DBB8A0-5AA6-5A56-9A8A-****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
