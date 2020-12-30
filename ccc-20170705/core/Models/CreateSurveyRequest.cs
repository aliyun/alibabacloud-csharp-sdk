// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class CreateSurveyRequest : TeaModel {
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("ScenarioId")]
        [Validation(Required=false)]
        public string ScenarioId { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("FlowJson")]
        [Validation(Required=false)]
        public string FlowJson { get; set; }

        [NameInMap("Corpora")]
        [Validation(Required=false)]
        public string Corpora { get; set; }

        [NameInMap("SpeechOptimizationParam")]
        [Validation(Required=false)]
        public string SpeechOptimizationParam { get; set; }

        [NameInMap("GlobalQuestions")]
        [Validation(Required=false)]
        public string GlobalQuestions { get; set; }

        [NameInMap("Role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        [NameInMap("Round")]
        [Validation(Required=false)]
        public int? Round { get; set; }

    }

}
