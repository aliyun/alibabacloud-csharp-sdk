// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class TrainingSpecification : TeaModel {
        [NameInMap("DatasetName")]
        [Validation(Required=false)]
        public string DatasetName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Endpoint")]
        [Validation(Required=false)]
        public string Endpoint { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ModelSpecification")]
        [Validation(Required=false)]
        public ModelSpecification ModelSpecification { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Runtime")]
        [Validation(Required=false)]
        public Runtime Runtime { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("SourceURI")]
        [Validation(Required=false)]
        public string SourceURI { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("TargetURI")]
        [Validation(Required=false)]
        public string TargetURI { get; set; }

        [NameInMap("Transforms")]
        [Validation(Required=false)]
        public List<CustomParams> Transforms { get; set; }

        [NameInMap("ValidationSourceURI")]
        [Validation(Required=false)]
        public string ValidationSourceURI { get; set; }

        [NameInMap("ValidationSplit")]
        [Validation(Required=false)]
        public float? ValidationSplit { get; set; }

    }

}
