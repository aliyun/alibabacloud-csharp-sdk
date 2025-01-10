// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo20220530.Models
{
    public class UpdateVpdRequest : TeaModel {
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
        /// <para>The ID of the VPD instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpd-omqutbff</para>
        /// </summary>
        [NameInMap("VpdId")]
        [Validation(Required=false)]
        public string VpdId { get; set; }

        /// <summary>
        /// <para>The name of the VPD instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpd-lingjun</para>
        /// </summary>
        [NameInMap("VpdName")]
        [Validation(Required=false)]
        public string VpdName { get; set; }

    }

}
