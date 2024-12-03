// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class CreateResourcePackageRequest : TeaModel {
        /// <summary>
        /// <para>The validity period of the resource plan.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public int? Duration { get; set; }

        /// <summary>
        /// <para>The time when the resource plan takes effect. If you leave this parameter empty, the resource plan immediately takes effect by default.</para>
        /// <para>Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-03-03T12:00:00Z</para>
        /// </summary>
        [NameInMap("EffectiveDate")]
        [Validation(Required=false)]
        public string EffectiveDate { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The type of the resource plan. Set this parameter to the code of the <b>resource plan</b> returned by calling the <b>DescribeResourcePackageProduct</b> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FPT_ossbag_absolute_Storage_sh</para>
        /// </summary>
        [NameInMap("PackageType")]
        [Validation(Required=false)]
        public string PackageType { get; set; }

        /// <summary>
        /// <para>The unit of the validity period of the resource plan. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Month</description></item>
        /// <item><description>Year</description></item>
        /// </list>
        /// <para>Default value: Month.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PricingCycle")]
        [Validation(Required=false)]
        public string PricingCycle { get; set; }

        /// <summary>
        /// <para>The code of the service. You can query the code by calling the <b>QueryProductList</b> operation or viewing <b>Codes of Alibaba Cloud services</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ossbag</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The specifications of the resource plan. Set this parameter to the value of the <b>specifications</b> returned by calling the <b>DescribeResourcePackageProduct</b> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40</para>
        /// </summary>
        [NameInMap("Specification")]
        [Validation(Required=false)]
        public string Specification { get; set; }

    }

}
