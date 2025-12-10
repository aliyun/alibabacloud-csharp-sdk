// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20210202.Models
{
    public class GetExperimentStatusResponseBody : TeaModel {
        [NameInMap("Nodes")]
        [Validation(Required=false)]
        public List<GetExperimentStatusResponseBodyNodes> Nodes { get; set; }
        public class GetExperimentStatusResponseBodyNodes : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-01-21T18:12:35.232Z</para>
            /// </summary>
            [NameInMap("FinishedAt")]
            [Validation(Required=false)]
            public string FinishedAt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>job-mewqhd72nsrqujn1px</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>id-2317-1608984201281-74996</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>flow-wayrh3k605s7i51wey</para>
            /// </summary>
            [NameInMap("RunId")]
            [Validation(Required=false)]
            public string RunId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>node-6hc0eocnmzf4pk9njc</para>
            /// </summary>
            [NameInMap("RunNodeId")]
            [Validation(Required=false)]
            public string RunNodeId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-01-21T17:12:35.232Z</para>
            /// </summary>
            [NameInMap("StartedAt")]
            [Validation(Required=false)]
            public string StartedAt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>18D5A1C6-14B8-545E-8408-0A7DDB4C6B5E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
