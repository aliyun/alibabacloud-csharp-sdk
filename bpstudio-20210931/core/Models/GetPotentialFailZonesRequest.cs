// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BPStudio20210931.Models
{
    public class GetPotentialFailZonesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether the value of this parameter is the ID of a disaster recovery set.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsPlanId")]
        [Validation(Required=false)]
        public bool? IsPlanId { get; set; }

        /// <summary>
        /// <para>If you set IsPlanId to false, specify the ID of a disaster recovery application. If you set IsPlanId to true, specify the ID of a disaster recovery set.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FS3ATPTOSC4SE1GG</para>
        /// </summary>
        [NameInMap("ObjectId")]
        [Validation(Required=false)]
        public string ObjectId { get; set; }

    }

}
