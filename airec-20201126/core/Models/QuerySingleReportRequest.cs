// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20201126.Models
{
    public class QuerySingleReportRequest : TeaModel {
        /// <summary>
        /// <para>The type of the single table report. This parameter is required.</para>
        /// <para>Valid values: typeItemValidScene,</para>
        /// <para>typeItemTag,</para>
        /// <para>typeItemTagScene,</para>
        /// <para>typeItemWeightScene,</para>
        /// <para>typeItemRawScene, and</para>
        /// <para>typeItemExpireScene</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>typeItemTagScene</para>
        /// </summary>
        [NameInMap("reportType")]
        [Validation(Required=false)]
        public string ReportType { get; set; }

    }

}
