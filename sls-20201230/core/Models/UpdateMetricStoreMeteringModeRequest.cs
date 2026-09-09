// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class UpdateMetricStoreMeteringModeRequest : TeaModel {
        /// <summary>
        /// <para>The billing mode to switch to. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ChargeByFunction: <a href="https://help.aliyun.com/document_detail/48220.html">pay-by-feature</a>.</description></item>
        /// <item><description>ChargeByDataIngest: <a href="https://help.aliyun.com/document_detail/2365756.html">pay-by-ingested-data</a>.</description></item>
        /// </list>
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
