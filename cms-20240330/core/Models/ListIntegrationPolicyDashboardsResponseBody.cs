// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListIntegrationPolicyDashboardsResponseBody : TeaModel {
        /// <summary>
        /// <para>List of dashboards.</para>
        /// </summary>
        [NameInMap("dashboards")]
        [Validation(Required=false)]
        public List<ListIntegrationPolicyDashboardsResponseBodyDashboards> Dashboards { get; set; }
        public class ListIntegrationPolicyDashboardsResponseBodyDashboards : TeaModel {
            /// <summary>
            /// <para>Dashboard engine:
            /// grafana: shared grafana.
            /// cms: cms self-developed dashboard engine.</para>
            /// 
            /// <b>Example:</b>
            /// <para>grafana</para>
            /// </summary>
            [NameInMap("engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            /// <summary>
            /// <para>UID of the dashboard folder.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Env-AAA</para>
            /// </summary>
            [NameInMap("folderUid")]
            [Validation(Required=false)]
            public string FolderUid { get; set; }

            /// <summary>
            /// <para>Dashboard name</para>
            /// 
            /// <b>Example:</b>
            /// <para>k8s-pod</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Region</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hongkong</para>
            /// </summary>
            [NameInMap("region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>List of tags.</para>
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<string> Tags { get; set; }

            /// <summary>
            /// <para>Title of the UI module (not name)</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <para>ID of the current Alibaba Cloud primary account, read-only</para>
            /// 
            /// <b>Example:</b>
            /// <para>1258199346721590</para>
            /// </summary>
            [NameInMap("uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

            /// <summary>
            /// <para>pagerDuty integration webhook. Supports V1 and V2 versions</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://agi.alicdn.com/user/0/0_0_5255362686.png?x-oss-process=image/quality,q_75/format,jpg&file=1734574878007.jpg">https://agi.alicdn.com/user/0/0_0_5255362686.png?x-oss-process=image/quality,q_75/format,jpg&amp;file=1734574878007.jpg</a></para>
            /// </summary>
            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <para>ID of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>CD8BA7D6-995D-578D-9941-78B0FECD14B5</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Number of components.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
