// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class AssociateHaVipRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the HaVip instance to be associated.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>havip-5p14t****</para>
        /// </summary>
        [NameInMap("HaVipId")]
        [Validation(Required=false)]
        public string HaVipId { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-50c4****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The type of the instance with which you want to associate the HaVip. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>EnsInstance: ENS instance. This is the default value.</description></item>
        /// <item><description>NetworkInterface: elastic network interface controller (NIC). If the instance with which you want to associate the HaVip is an elastic network interface controller (NIC), you must specify this parameter.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>EnsInstance</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

    }

}
