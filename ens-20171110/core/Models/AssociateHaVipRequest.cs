// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class AssociateHaVipRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the HAVIP.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>havip-5p14t****</para>
        /// </summary>
        [NameInMap("HaVipId")]
        [Validation(Required=false)]
        public string HaVipId { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-50c4****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The type of the instance to be associated with the HAVIP. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>EnsInstance (default): ENS instance.</description></item>
        /// <item><description>NetworkInterface: ENI. If you want to associate the HAVIP with an ENI, this parameter is required.</description></item>
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
