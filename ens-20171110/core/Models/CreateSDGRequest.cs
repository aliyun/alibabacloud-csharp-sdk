// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateSDGRequest : TeaModel {
        [NameInMap("BillingCycle")]
        [Validation(Required=false)]
        public string BillingCycle { get; set; }

        /// <summary>
        /// <para>The description of the SDG.</para>
        /// <remarks>
        /// <para> We recommend that you specify this parameter in details for subsequent queries.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Testing SDGs</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("DiskType")]
        [Validation(Required=false)]
        public string DiskType { get; set; }

        /// <summary>
        /// <para>The ID of the SDG from which you want to create an SDG.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>The first time you create an SDG, the <b>FromSDGId</b> parameter is empty.</para>
        /// </description></item>
        /// <item><description><para>If the value of the <b>FromSDGId</b> parameter is invalid or does not correspond to an original disk, an error is reported.</para>
        /// </description></item>
        /// <item><description><para>If the value of the <b>FromSDGId</b> parameter is not empty, you have created an SDG, and the operation is performed on the existing SDG.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>sdg-xxxxx</para>
        /// </summary>
        [NameInMap("FromSDGId")]
        [Validation(Required=false)]
        public string FromSDGId { get; set; }

        /// <summary>
        /// <para>The ID of the AIC instance. You can call the <a href="~~DescribeARMServerInstances~~">DescribeARMServerInstances</a> operation to query the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aic-xxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("PerformanceLevel")]
        [Validation(Required=false)]
        public long? PerformanceLevel { get; set; }

        /// <summary>
        /// <para>The maximum capacity of the SDG. Unit: GB.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>To save costs, we recommend that you specify this parameter based on your business requirements.</para>
        /// </description></item>
        /// <item><description><para>The first time that you create an SDG, the <b>Size</b> parameter is required.</para>
        /// </description></item>
        /// <item><description><para>When the amount of data increases, you can pass a new <b>Size</b> parameter for resizing. If the value of the new <b>Size</b> parameter is greater than the value of the old <b>Size</b> parameter, the disk size of the SDG is increased to the size that is specified by the new <b>Size</b> parameter. If the value of the new <b>Size</b> parameter is empty or smaller than that of the old <b>Size</b> parameter, no operation is performed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public string Size { get; set; }

    }

}
