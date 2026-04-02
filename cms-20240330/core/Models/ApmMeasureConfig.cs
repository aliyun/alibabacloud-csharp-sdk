// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ApmMeasureConfig : TeaModel {
        /// <summary>
        /// <para>分组维度</para>
        /// </summary>
        [NameInMap("groupBy")]
        [Validation(Required=false)]
        public List<string> GroupBy { get; set; }

        /// <summary>
        /// <para>指标代码</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("measureCode")]
        [Validation(Required=false)]
        public string MeasureCode { get; set; }

        /// <summary>
        /// <para>查询时间窗口（秒）</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("windowSecs")]
        [Validation(Required=false)]
        public int? WindowSecs { get; set; }

    }

}
