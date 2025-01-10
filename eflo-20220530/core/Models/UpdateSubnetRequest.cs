// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo20220530.Models
{
    public class UpdateSubnetRequest : TeaModel {
        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-wulanchabu</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The subnet instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>subnet-f3zfzmnc</para>
        /// </summary>
        [NameInMap("SubnetId")]
        [Validation(Required=false)]
        public string SubnetId { get; set; }

        /// <summary>
        /// <para>The new name for the subnet instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>subnet-1</para>
        /// </summary>
        [NameInMap("SubnetName")]
        [Validation(Required=false)]
        public string SubnetName { get; set; }

        /// <summary>
        /// <para>The ID of the VPD to which the subnet belongs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpd-aof7dat1</para>
        /// </summary>
        [NameInMap("VpdId")]
        [Validation(Required=false)]
        public string VpdId { get; set; }

        /// <summary>
        /// <para>The zone ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-wulanchabu-a</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
