// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class AddAnswerSampleRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>alxxxx</para>
        /// </summary>
        [NameInMap("LibId")]
        [Validation(Required=false)]
        public string LibId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

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
