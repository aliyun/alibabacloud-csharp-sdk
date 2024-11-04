// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class AlertRuleAlertMetricInputFilterValue : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("dim")]
        [Validation(Required=false)]
        public string Dim { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("opt")]
        [Validation(Required=false)]
        public string Opt { get; set; }

        [NameInMap("value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
