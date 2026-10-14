// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateSDGRequest : TeaModel {
        /// <summary>
        /// <para>The billing logic for SDG child disks. This parameter specifies the billing method for the RBD child disks produced by this SDG. This parameter does not apply to standard cloud disks.
        /// Optional parameter values:</para>
        /// <list type="bullet">
        /// <item><description><para>Hour.</para>
        /// </description></item>
        /// <item><description><para>Day. This is the default value.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Parameter description: The longer the cycle, the lower the cost. If the disk is released before the billing cycle ends, a service fee is charged.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Day</para>
        /// </summary>
        [NameInMap("BillingCycle")]
        [Validation(Required=false)]
        public string BillingCycle { get; set; }

        /// <summary>
        /// <para>The description of the SDG.</para>
        /// <remarks>
        /// <para>Provide a detailed description for easier future queries.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Test SDG</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The type of the source disk.
        /// Optional parameter values:</para>
        /// <list type="bullet">
        /// <item><description>standard: standard cloud disk. This is the default value.</description></item>
        /// <item><description>rbd: RBD disk.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Limits: RBD disk SDGs and standard disk SDGs cannot inherit from each other.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>standard</para>
        /// </summary>
        [NameInMap("DiskType")]
        [Validation(Required=false)]
        public string DiskType { get; set; }

        /// <summary>
        /// <para>The ID of an existing SDG.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If you are creating an SDG for the first time, leave <b>FromSDGId</b> empty.</description></item>
        /// <item><description>If <b>FromSDGId</b> is invalid or the corresponding raw cloud disk cannot be found, an error is returned.</description></item>
        /// <item><description>If <b>FromSDGId</b> is not empty, this indicates that you are operating on an existing SDG rather than creating one for the first time.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>sdg-xxxxx</para>
        /// </summary>
        [NameInMap("FromSDGId")]
        [Validation(Required=false)]
        public string FromSDGId { get; set; }

        /// <summary>
        /// <para>The AIC instance ID. You can call the <a href="~~DescribeARMServerInstances~~">DescribeARMServerInstances</a> operation to obtain the InstanceId value.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aic-xxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The SDG sharing ratio parameter. This parameter supports cloud disks with different maximum sharing ratios.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("PerformanceLevel")]
        [Validation(Required=false)]
        public long? PerformanceLevel { get; set; }

        /// <summary>
        /// <para>The maximum capacity of the SDG. Unit: GB.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>To reduce costs, evaluate the required capacity as needed.</description></item>
        /// <item><description>If you are creating an SDG for the first time, <b>Size</b> is required.</description></item>
        /// <item><description>If the data volume increases later, pass a new <b>Size</b> value to expand the capacity. If <b>Size</b> is not empty and is greater than the original <b>Size</b> value of the SDG, the raw cloud disk of the SDG is expanded to the specified <b>Size</b>. If <b>Size</b> is empty or the specified <b>Size</b> is less than the original <b>Size</b> value of the SDG, no action is taken.</description></item>
        /// </list>
        /// </remarks>
        /// <para>The minimum tested usable value is 150 GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>150</para>
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public string Size { get; set; }

    }

}
