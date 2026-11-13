// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class UpdatePostpayUserVpcStatusRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Cloud Firewall instance. This parameter is required. If you do not specify this parameter, the API returns a 400 error. You can call the DescribeUserBuyVersion operation to obtain the Cloud Firewall instance ID of the current account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cfw_elasticity_public_cn-************</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The language of the request and response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b> (default): Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The operation type. Only the enable operation is supported. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>open: Enables the module.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>open</para>
        /// </summary>
        [NameInMap("Operate")]
        [Validation(Required=false)]
        public string Operate { get; set; }

    }

}
