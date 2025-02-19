// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Umeng_apm20220214.Models
{
    public class UpdateAlertPlanRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5fb6001a73749c24fd9cb356</para>
        /// </summary>
        [NameInMap("dataSourceId")]
        [Validation(Required=false)]
        public string DataSourceId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>18288</para>
        /// </summary>
        [NameInMap("planId")]
        [Validation(Required=false)]
        public long? PlanId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;1.1.0,1.2.0,1.3.0&quot;</para>
        /// </summary>
        [NameInMap("versions")]
        [Validation(Required=false)]
        public string Versions { get; set; }

    }

}
