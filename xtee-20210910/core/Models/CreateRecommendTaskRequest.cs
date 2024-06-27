// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class CreateRecommendTaskRequest : TeaModel {
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("regId")]
        [Validation(Required=false)]
        public string RegId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("sampleId")]
        [Validation(Required=false)]
        public long? SampleId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("variablesStr")]
        [Validation(Required=false)]
        public string VariablesStr { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("velocitiesStr")]
        [Validation(Required=false)]
        public string VelocitiesStr { get; set; }

    }

}
