// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class CreateAnswerLibRequest : TeaModel {
        /// <summary>
        /// <para>The name of the proxy answer library.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试代答库</para>
        /// </summary>
        [NameInMap("LibName")]
        [Validation(Required=false)]
        public string LibName { get; set; }

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
        /// <para>The name of the storage space.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss-cip-shanghai</para>
        /// </summary>
        [NameInMap("SampleBucket")]
        [Validation(Required=false)]
        public string SampleBucket { get; set; }

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
