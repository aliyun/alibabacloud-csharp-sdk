// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class UpdateMetricStoreMeteringModeRequest : TeaModel {
        /// <summary>
        /// <para>The billing mode. Default value: ChargeByFunction. Valid values: ChargeByFunction and ChargeByDataIngest.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ChargeByFunction</para>
        /// </summary>
        [NameInMap("meteringMode")]
        [Validation(Required=false)]
        public string MeteringMode { get; set; }

    }

}
