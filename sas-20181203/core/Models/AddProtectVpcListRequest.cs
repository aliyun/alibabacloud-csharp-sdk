// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class AddProtectVpcListRequest : TeaModel {
        /// <summary>
        /// <para>Collection of new VPC instance IDs.</para>
        /// <remarks>
        /// <para>Call the <a href="~~Describevpclist~~">Describevpclist</a> interface to obtain this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;vpc-bp1vnpgotyzay6p5i****&quot;,&quot;vpc-bp1vnpgotyzay6p5i****&quot;]</para>
        /// </summary>
        [NameInMap("AddVpcInstanceIdList")]
        [Validation(Required=false)]
        public string AddVpcInstanceIdList { get; set; }

        /// <summary>
        /// <para>Collection of VPC instance IDs to be deleted.</para>
        /// <remarks>
        /// <para>Call the <a href="~~Describevpclist~~">Describevpclist</a> interface to obtain this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;vpc-bp1vnpgotyzay6p5i****&quot;,&quot;vpc-bp1vnpgotyzay6p5i****&quot;]</para>
        /// </summary>
        [NameInMap("DelVpcInstanceIdList")]
        [Validation(Required=false)]
        public string DelVpcInstanceIdList { get; set; }

    }

}
