// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyVpcHoneyPotRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable or disable the honeypot. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>disable</b></description></item>
        /// <item><description><b>enable</b></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>disable</para>
        /// </summary>
        [NameInMap("HoneyPotAction")]
        [Validation(Required=false)]
        public string HoneyPotAction { get; set; }

        /// <summary>
        /// <para>The ID of the virtual private cloud (VPC) on which the honeypot is deployed.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~DescribeVpcHoneyPotList~~">DescribeVpcHoneyPotList</a> operation to query the IDs of VPCs.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-d7o009q63fqy21r8u****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
