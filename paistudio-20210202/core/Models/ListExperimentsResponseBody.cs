// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20210202.Models
{
    public class ListExperimentsResponseBody : TeaModel {
        [NameInMap("Experiments")]
        [Validation(Required=false)]
        public List<ListExperimentsResponseBodyExperiments> Experiments { get; set; }
        public class ListExperimentsResponseBodyExperiments : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>PUBLIC</para>
            /// </summary>
            [NameInMap("Accessibility")]
            [Validation(Required=false)]
            public string Accessibility { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1326*******76250</para>
            /// </summary>
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Pipeline draft description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>draft-rbvg5wzljzjhc9ks92</para>
            /// </summary>
            [NameInMap("ExperimentId")]
            [Validation(Required=false)]
            public string ExperimentId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-01-30T12:51:33.028Z</para>
            /// </summary>
            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public string GmtCreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-01-30T12:51:33.028Z</para>
            /// </summary>
            [NameInMap("GmtModifiedTime")]
            [Validation(Required=false)]
            public string GmtModifiedTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Pipeline draft name</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>PaiStudio</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public long? Version { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>23487</para>
            /// </summary>
            [NameInMap("WorkspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9708FB85-232F-5F9A-9D67-7F9CCCE20E06</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
