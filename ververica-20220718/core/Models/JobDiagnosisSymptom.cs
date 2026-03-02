// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class JobDiagnosisSymptom : TeaModel {
        /// <summary>
        /// <para>The diagnostic result.</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The diagnostic task name.</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The fixing suggestions.</para>
        /// </summary>
        [NameInMap("recommendation")]
        [Validation(Required=false)]
        public string Recommendation { get; set; }

    }

}
