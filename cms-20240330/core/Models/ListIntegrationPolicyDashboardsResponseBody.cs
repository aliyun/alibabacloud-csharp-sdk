// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListIntegrationPolicyDashboardsResponseBody : TeaModel {
        [NameInMap("dashboards")]
        [Validation(Required=false)]
        public List<ListIntegrationPolicyDashboardsResponseBodyDashboards> Dashboards { get; set; }
        public class ListIntegrationPolicyDashboardsResponseBodyDashboards : TeaModel {
            [NameInMap("engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            [NameInMap("folderUid")]
            [Validation(Required=false)]
            public string FolderUid { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<string> Tags { get; set; }

            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            [NameInMap("uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

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
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
