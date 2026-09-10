// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class MeasureList : TeaModel {
        /// <summary>
        /// <para>The grouping dimension.</para>
        /// </summary>
        [NameInMap("groupBy")]
        [Validation(Required=false)]
        public List<string> GroupBy { get; set; }

        /// <summary>
        /// <para>The metric code.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cpu_usage</para>
        /// </summary>
        [NameInMap("measureCode")]
        [Validation(Required=false)]
        public string MeasureCode { get; set; }

        /// <summary>
        /// <para>The query time window, in seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("windowSecs")]
        [Validation(Required=false)]
        public int? WindowSecs { get; set; }

    }

}
