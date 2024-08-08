// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiAutoML20220828.Models
{
    public class ListHpoExperimentsResponseBody : TeaModel {
        /// <summary>
        /// Error code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// Extra error information.
        /// </summary>
        [NameInMap("Detail")]
        [Validation(Required=false)]
        public Dictionary<string, string> Detail { get; set; }

        /// <summary>
        /// experiment array.
        /// </summary>
        [NameInMap("Experiments")]
        [Validation(Required=false)]
        public List<ListHpoExperimentsResponseBodyExperiments> Experiments { get; set; }
        public class ListHpoExperimentsResponseBodyExperiments : TeaModel {
            /// <summary>
            /// Experiment accessibility, private or public.
            /// </summary>
            [NameInMap("Accessibility")]
            [Validation(Required=false)]
            public string Accessibility { get; set; }

            /// <summary>
            /// Experiment job run environment configurations.
            /// </summary>
            [NameInMap("ConfigIni")]
            [Validation(Required=false)]
            public string ConfigIni { get; set; }

            /// <summary>
            /// HPO experiment run configuration.
            /// </summary>
            [NameInMap("ConfigYml")]
            [Validation(Required=false)]
            public string ConfigYml { get; set; }

            /// <summary>
            /// The one who created the experiment.
            /// </summary>
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// If the experiment is deleted.
            /// </summary>
            [NameInMap("Deleted")]
            [Validation(Required=false)]
            public bool? Deleted { get; set; }

            /// <summary>
            /// The description of the experiment.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// Experiment ID.
            /// </summary>
            [NameInMap("ExperimentId")]
            [Validation(Required=false)]
            public string ExperimentId { get; set; }

            /// <summary>
            /// Experiment Create Time.
            /// </summary>
            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public string GmtCreateTime { get; set; }

            /// <summary>
            /// Last modified time.
            /// </summary>
            [NameInMap("GmtModifiedTime")]
            [Validation(Required=false)]
            public string GmtModifiedTime { get; set; }

            /// <summary>
            /// Experimetn job type.
            /// </summary>
            [NameInMap("JobType")]
            [Validation(Required=false)]
            public string JobType { get; set; }

            /// <summary>
            /// Experiment name
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// Experiment hyperparameter search space.
            /// </summary>
            [NameInMap("SearchSpace")]
            [Validation(Required=false)]
            public string SearchSpace { get; set; }

            /// <summary>
            /// Experiment status.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// How many trials the experiment have.
            /// </summary>
            [NameInMap("TrialCount")]
            [Validation(Required=false)]
            public int? TrialCount { get; set; }

            /// <summary>
            /// Trial status map.
            /// </summary>
            [NameInMap("TrialStatus")]
            [Validation(Required=false)]
            public Dictionary<string, string> TrialStatus { get; set; }

            /// <summary>
            /// The ID of the AI workspace.
            /// </summary>
            [NameInMap("WorkspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

        /// <summary>
        /// Error message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Total qualified experiment count.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
