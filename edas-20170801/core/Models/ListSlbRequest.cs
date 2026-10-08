// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListSlbRequest : TeaModel {
        /// <summary>
        /// <para>The address type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Internet: public address.</description></item>
        /// <item><description>Intranet: private network address.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>internet</para>
        /// </summary>
        [NameInMap("AddressType")]
        [Validation(Required=false)]
        public string AddressType { get; set; }

        /// <summary>
        /// <para>The SLB type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>clb: classic load balancing.</description></item>
        /// <item><description>alb: application load balancing.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>clb</para>
        /// </summary>
        [NameInMap("SlbType")]
        [Validation(Required=false)]
        public string SlbType { get; set; }

        /// <summary>
        /// <para>The VPC ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1f90rfybszjogyw****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
