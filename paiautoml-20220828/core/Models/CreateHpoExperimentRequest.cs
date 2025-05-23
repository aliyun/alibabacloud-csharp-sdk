// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiAutoML20220828.Models
{
    public class CreateHpoExperimentRequest : TeaModel {
        /// <summary>
        /// Experiment accesibility, public or private.
        /// </summary>
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        /// <summary>
        /// Experiment description.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The config object of the expriment.
        /// </summary>
        [NameInMap("HpoExperimentConfiguration")]
        [Validation(Required=false)]
        public HpoExperimentConfig HpoExperimentConfiguration { get; set; }

        /// <summary>
        /// Experiment Name
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// AI Workspace ID
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
