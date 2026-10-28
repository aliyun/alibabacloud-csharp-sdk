// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class SetWarningThresholdRequest : TeaModel {
        /// <summary>
        /// <para>The UID of the reseller customer account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1792155717328010</para>
        /// </summary>
        [NameInMap("Uid")]
        [Validation(Required=false)]
        public long? Uid { get; set; }

        /// <summary>
        /// <para>The percentage value. Valid values: 1 to 100. When the available credit drops below this percentage of the total credit limit, an alert email is sent to the reseller partner account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("WarningValue")]
        [Validation(Required=false)]
        public string WarningValue { get; set; }

    }

}
