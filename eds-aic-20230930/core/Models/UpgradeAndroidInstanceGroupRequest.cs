// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class UpgradeAndroidInstanceGroupRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("IncreaseNumberOfInstance")]
        [Validation(Required=false)]
        public int? IncreaseNumberOfInstance { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ag-asguicdjh****</para>
        /// </summary>
        [NameInMap("InstanceGroupId")]
        [Validation(Required=false)]
        public string InstanceGroupId { get; set; }

    }

}
