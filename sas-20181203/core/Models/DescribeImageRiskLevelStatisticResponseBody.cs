// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageRiskLevelStatisticResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about risks at the image level. The risks include vulnerabilities, baselines risks, and malicious file risks.</para>
        /// </summary>
        [NameInMap("ImageRiskLevelList")]
        [Validation(Required=false)]
        public List<DescribeImageRiskLevelStatisticResponseBodyImageRiskLevelList> ImageRiskLevelList { get; set; }
        public class DescribeImageRiskLevelStatisticResponseBodyImageRiskLevelList : TeaModel {
            /// <summary>
            /// <para>The number of images at the risk level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("Cnt")]
            [Validation(Required=false)]
            public int? Cnt { get; set; }

            /// <summary>
            /// <para>The risk level of the image. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>3</b>: high risk.</description></item>
            /// <item><description><b>2</b>: medium risk.</description></item>
            /// <item><description><b>1</b>: low risk.</description></item>
            /// <item><description><b>0</b>: no risk.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ImageRiskLevel")]
            [Validation(Required=false)]
            public string ImageRiskLevel { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A60DA4EC-7CD8-577D-AD73-******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
