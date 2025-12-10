// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20210202.Models
{
    public class ListRecentExperimentsResponseBody : TeaModel {
        [NameInMap("Experiments")]
        [Validation(Required=false)]
        public List<ListRecentExperimentsResponseBodyExperiments> Experiments { get; set; }
        public class ListRecentExperimentsResponseBodyExperiments : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>Pipeline draft description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>draft-76p70ye0gwv3vbur55</para>
            /// </summary>
            [NameInMap("ExperimentId")]
            [Validation(Required=false)]
            public string ExperimentId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("ModifyCnt")]
            [Validation(Required=false)]
            public long? ModifyCnt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Pipeline draft name</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-01-30T12:51:33.028Z</para>
            /// </summary>
            [NameInMap("RecentGmtModifiedTime")]
            [Validation(Required=false)]
            public string RecentGmtModifiedTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>PaiStudio</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>15821</para>
            /// </summary>
            [NameInMap("WorkspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Workspace name</para>
            /// </summary>
            [NameInMap("WorkspaceName")]
            [Validation(Required=false)]
            public string WorkspaceName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>23</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
