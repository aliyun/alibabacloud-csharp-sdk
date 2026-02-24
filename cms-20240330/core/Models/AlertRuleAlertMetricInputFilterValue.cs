// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class AlertRuleAlertMetricInputFilterValue : TeaModel {
        /// <summary>
        /// <para>Dimension of the filter condition.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rootIp</para>
        /// </summary>
        [NameInMap("dim")]
        [Validation(Required=false)]
        public string Dim { get; set; }

        /// <summary>
        /// <para>Filter Condition Operator.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALL</para>
        /// </summary>
        [NameInMap("opt")]
        [Validation(Required=false)]
        public string Opt { get; set; }

        /// <summary>
        /// <para>Filter Condition Value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>127.0.0.1</para>
        /// </summary>
        [NameInMap("value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
