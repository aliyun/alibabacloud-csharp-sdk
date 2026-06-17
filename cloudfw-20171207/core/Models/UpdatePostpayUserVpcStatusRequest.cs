// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class UpdatePostpayUserVpcStatusRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Cloud Firewall instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cfw_elasticity_public_cn-************</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The language of the request and response.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b> (default): Chinese</para>
        /// </description></item>
        /// <item><description><para>en: English</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The operation to perform. Currently, only the open operation is supported.</para>
        /// <list type="bullet">
        /// <item><description>open: Enables the VPC border firewall.</description></item>
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
