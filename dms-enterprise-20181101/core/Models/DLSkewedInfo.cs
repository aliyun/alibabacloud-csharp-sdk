// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class DLSkewedInfo : TeaModel {
        /// <summary>
        /// <para>The list of skewed column names.</para>
        /// </summary>
        [NameInMap("SkewedColNames")]
        [Validation(Required=false)]
        public List<string> SkewedColNames { get; set; }

        /// <summary>
        /// <para>The mappings between skewed values and columns.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{“col1”:&quot;val1&quot;}</para>
        /// </summary>
        [NameInMap("SkewedColValueLocationMaps")]
        [Validation(Required=false)]
        public Dictionary<string, object> SkewedColValueLocationMaps { get; set; }

        /// <summary>
        /// <para>The lists of skewed column values. Each list provides a set of associated values.</para>
        /// </summary>
        [NameInMap("SkewedColValues")]
        [Validation(Required=false)]
        public List<List<string>> SkewedColValues { get; set; }

    }

}
