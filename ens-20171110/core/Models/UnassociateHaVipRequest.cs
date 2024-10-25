// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class UnassociateHaVipRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the HAVIP that you want to disassociate.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>havip-5p14t****</para>
        /// </summary>
        [NameInMap("HaVipId")]
        [Validation(Required=false)]
        public string HaVipId { get; set; }

        /// <summary>
        /// <para>The ID of the ENS instance or ENI that you want to disassociate from the HAVIP.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-5ecpqvk****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
