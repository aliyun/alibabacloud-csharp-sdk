// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyResourcePackageRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoQuota")]
        [Validation(Required=false)]
        public bool? AutoQuota { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pm-bp11b0i9389******</para>
        /// </summary>
        [NameInMap("ResourcePackageId")]
        [Validation(Required=false)]
        public string ResourcePackageId { get; set; }

    }

}
