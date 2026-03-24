// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListIntegrationPolicyDashboardsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of dashboards.</para>
        /// </summary>
        [NameInMap("dashboards")]
        [Validation(Required=false)]
        public List<ListIntegrationPolicyDashboardsResponseBodyDashboards> Dashboards { get; set; }
        public class ListIntegrationPolicyDashboardsResponseBodyDashboards : TeaModel {
            /// <summary>
            /// <para>The dashboard engine. Valid values:
            /// grafana: shared Grafana.
            /// cms: the self-developed dashboard engine of CloudMonitor.</para>
            /// 
            /// <b>Example:</b>
            /// <para>grafana</para>
            /// </summary>
            [NameInMap("engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            /// <summary>
            /// <para>The UID of the dashboard folder.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Env-AAA</para>
            /// </summary>
            [NameInMap("folderUid")]
            [Validation(Required=false)]
            public string FolderUid { get; set; }

            /// <summary>
            /// <para>The dashboard name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>k8s-pod</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hongkong</para>
            /// </summary>
            [NameInMap("region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The list of tags.</para>
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<string> Tags { get; set; }

            /// <summary>
            /// <para>The title of the UI module. This is different from the name parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <para>The ID of the current Alibaba Cloud account. This parameter is read-only.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1258199346721590</para>
            /// </summary>
            [NameInMap("uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

            /// <summary>
            /// <para>The webhook URL for PagerDuty integration. V1 and V2 are supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://agi.alicdn.com/user/0/0_0_5255362686.png?x-oss-process=image/quality,q_75/format,jpg&file=1734574878007.jpg">https://agi.alicdn.com/user/0/0_0_5255362686.png?x-oss-process=image/quality,q_75/format,jpg&amp;file=1734574878007.jpg</a></para>
            /// </summary>
            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>CD8BA7D6-995D-578D-9941-78B0FECD14B5</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of components.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
