// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo20220530.Models
{
    public class UnAssociateVpdCidrBlockRequest : TeaModel {
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
        /// <para>The additional CIDR block.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.0.0/16</para>
        /// </summary>
        [NameInMap("SecondaryCidrBlock")]
        [Validation(Required=false)]
        public string SecondaryCidrBlock { get; set; }

        /// <summary>
        /// <para>The ID of the Lingjun CIDR block.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpd-aof7dat1</para>
        /// </summary>
        [NameInMap("VpdId")]
        [Validation(Required=false)]
        public string VpdId { get; set; }

    }

}
