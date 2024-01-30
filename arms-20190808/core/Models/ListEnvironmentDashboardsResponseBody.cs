// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListEnvironmentDashboardsResponseBody : TeaModel {
        /// <summary>
        /// Status code: 200 indicates success.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The returned struct.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListEnvironmentDashboardsResponseBodyData Data { get; set; }
        public class ListEnvironmentDashboardsResponseBodyData : TeaModel {
            /// <summary>
            /// List of dashboard.
            /// </summary>
            [NameInMap("Dashboards")]
            [Validation(Required=false)]
            public List<ListEnvironmentDashboardsResponseBodyDataDashboards> Dashboards { get; set; }
            public class ListEnvironmentDashboardsResponseBodyDataDashboards : TeaModel {
                /// <summary>
                /// Dashboard folder UID.
                /// </summary>
                [NameInMap("FolderUid")]
                [Validation(Required=false)]
                public string FolderUid { get; set; }

                /// <summary>
                /// The region ID.
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// List of tabs on the dashboard.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<string> Tags { get; set; }

                /// <summary>
                /// The title on the dashboard.
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// The UID on the dashboard.
                /// </summary>
                [NameInMap("Uid")]
                [Validation(Required=false)]
                public string Uid { get; set; }

                /// <summary>
                /// The URL on the dashboard.
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// Totle of the dashboards.
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the call was successful. Valid values:
        /// 
        /// *   `true`: The call was successful.
        /// *   `false`: The call failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
