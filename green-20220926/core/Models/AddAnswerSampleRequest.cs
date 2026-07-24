// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class AddAnswerSampleRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the proxy answer library.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alxxxx</para>
        /// </summary>
        [NameInMap("LibId")]
        [Validation(Required=false)]
        public string LibId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The file name of the proxy answer sample to be added.</para>
        /// 
        /// <b>Example:</b>
        /// <para>data/xxx.xlsx</para>
        /// </summary>
        [NameInMap("SampleObject")]
        [Validation(Required=false)]
        public string SampleObject { get; set; }

        /// <summary>
        /// <para>The samples to be added.</para>
        /// 
        /// <b>Example:</b>
        /// <para>代答答案1\n代答答案2</para>
        /// </summary>
        [NameInMap("Samples")]
        [Validation(Required=false)]
        public string Samples { get; set; }

    }

}
