// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiAutoML20220828.Models
{
    public class GetHpoExperimentResponseBody : TeaModel {
        /// <summary>
        /// Accessibility of expriment, public or private.
        /// </summary>
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        /// <summary>
        /// Error when the API call is not success.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// Experiment run environment configurations.
        /// </summary>
        [NameInMap("ConfigIni")]
        [Validation(Required=false)]
        public string ConfigIni { get; set; }

        /// <summary>
        /// HPO search config yaml.
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
        /// If the Experiment if deleted.
        /// </summary>
        [NameInMap("Deleted")]
        [Validation(Required=false)]
        public bool? Deleted { get; set; }

        /// <summary>
        /// Description of the experiment.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// Extra error message info.
        /// </summary>
        [NameInMap("Detail")]
        [Validation(Required=false)]
        public Dictionary<string, object> Detail { get; set; }

        /// <summary>
        /// Experiment ID.
        /// </summary>
        [NameInMap("ExperimentId")]
        [Validation(Required=false)]
        public string ExperimentId { get; set; }

        /// <summary>
        /// Experiment create time.
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// Experiment last update time.
        /// </summary>
        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        /// <summary>
        /// Experiment configuration in json format.
        /// </summary>
        [NameInMap("HpoExperimentConfiguration")]
        [Validation(Required=false)]
        public Dictionary<string, object> HpoExperimentConfiguration { get; set; }

        /// <summary>
        /// Experiment  Job type.
        /// </summary>
        [NameInMap("JobType")]
        [Validation(Required=false)]
        public string JobType { get; set; }

        /// <summary>
        /// Error message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// Experiment name.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// HPO hyperparameter search space.
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
        /// Trials amount run till now.
        /// </summary>
        [NameInMap("TrialCount")]
        [Validation(Required=false)]
        public int? TrialCount { get; set; }

        /// <summary>
        /// Status if a trial
        /// </summary>
        [NameInMap("TrialStatus")]
        [Validation(Required=false)]
        public Dictionary<string, string> TrialStatus { get; set; }

        /// <summary>
        /// AI Workspace ID.
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
