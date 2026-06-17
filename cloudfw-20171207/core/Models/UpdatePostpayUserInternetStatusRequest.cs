// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class UpdatePostpayUserInternetStatusRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Cloud Firewall instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cfw_elasticity_public_cn-zsk39m******</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The language of the response messages. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b> (default): Chinese</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English</para>
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
        /// <para>The type of operation. Currently, only the \<c>open\\</c> operation is supported.</para>
        /// <list type="bullet">
        /// <item><description>open: enables the firewall.</description></item>
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
