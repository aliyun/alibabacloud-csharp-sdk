// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenITag20220616.Models
{
    public class UserStatistic : TeaModel {
        /// <summary>
        /// <para>Quantity of Data items passed</para>
        /// 
        /// <b>Example:</b>
        /// <para>172</para>
        /// </summary>
        [NameInMap("AcceptedMarkItemsCount")]
        [Validation(Required=false)]
        public float? AcceptedMarkItemsCount { get; set; }

        /// <summary>
        /// <para>Total inspection count</para>
        /// 
        /// <b>Example:</b>
        /// <para>140</para>
        /// </summary>
        [NameInMap("CheckCount")]
        [Validation(Required=false)]
        public float? CheckCount { get; set; }

        /// <summary>
        /// <para>Quantity passed in inspection</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("CheckedAcceptedCount")]
        [Validation(Required=false)]
        public float? CheckedAcceptedCount { get; set; }

        /// <summary>
        /// <para>Inspection accuracy.<br>Inspection accuracy = Number Of Error inspected / Quantity inspected</para>
        /// 
        /// <b>Example:</b>
        /// <para>95.33</para>
        /// </summary>
        [NameInMap("CheckedAccuracy")]
        [Validation(Required=false)]
        public float? CheckedAccuracy { get; set; }

        /// <summary>
        /// <para>Annotation efficiency. Unit: items/hour<br>Annotation efficiency = Quantity annotated / Annotation duration (including rejections)</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.1</para>
        /// </summary>
        [NameInMap("MarkEfficiency")]
        [Validation(Required=false)]
        public float? MarkEfficiency { get; set; }

        /// <summary>
        /// <para>Annotation duration. Unit: hours</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.1</para>
        /// </summary>
        [NameInMap("MarkTime")]
        [Validation(Required=false)]
        public float? MarkTime { get; set; }

        /// <summary>
        /// <para>Sampling accuracy.<br>Validated accuracy = Number Of Error validated / Quantity validated</para>
        /// 
        /// <b>Example:</b>
        /// <para>84.92</para>
        /// </summary>
        [NameInMap("SamplingAccuracy")]
        [Validation(Required=false)]
        public float? SamplingAccuracy { get; set; }

        /// <summary>
        /// <para>Total sampling quantity</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SamplingCount")]
        [Validation(Required=false)]
        public float? SamplingCount { get; set; }

        /// <summary>
        /// <para>Number Of Error in sampling</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SamplingErrorCount")]
        [Validation(Required=false)]
        public float? SamplingErrorCount { get; set; }

        /// <summary>
        /// <para>Total Data items</para>
        /// 
        /// <b>Example:</b>
        /// <para>172</para>
        /// </summary>
        [NameInMap("TotalMarkItemsCount")]
        [Validation(Required=false)]
        public float? TotalMarkItemsCount { get; set; }

        /// <summary>
        /// <para>User ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>166***9980757311</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
