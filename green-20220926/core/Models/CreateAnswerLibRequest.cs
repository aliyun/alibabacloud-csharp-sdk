// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class CreateAnswerLibRequest : TeaModel {
        [NameInMap("LibName")]
        [Validation(Required=false)]
        public string LibName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>oss-cip-shanghai</para>
        /// </summary>
        [NameInMap("SampleBucket")]
        [Validation(Required=false)]
        public string SampleBucket { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>data/xxx.xlsx</para>
        /// </summary>
        [NameInMap("SampleObject")]
        [Validation(Required=false)]
        public string SampleObject { get; set; }

        [NameInMap("Samples")]
        [Validation(Required=false)]
        public string Samples { get; set; }

    }

}
