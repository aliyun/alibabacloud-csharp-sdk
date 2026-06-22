// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UpdatePublishGraySwitchRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the canary release feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: enabled.</para>
        /// </description></item>
        /// <item><description><para><b>0</b>: disabled.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("GraySwitchStatus")]
        [Validation(Required=false)]
        public int? GraySwitchStatus { get; set; }

    }

}
