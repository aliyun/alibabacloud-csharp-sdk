// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyImageFixCycleConfigRequest : TeaModel {
        /// <summary>
        /// <para>The cycle of the scheduled fix. Unit: day.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("ImageFixCycle")]
        [Validation(Required=false)]
        public int? ImageFixCycle { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the schedule image fix.</para>
        /// <list type="bullet">
        /// <item><description><b>on</b>: enable</description></item>
        /// <item><description><b>off</b>: disable</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("ImageFixSwitch")]
        [Validation(Required=false)]
        public string ImageFixSwitch { get; set; }

        /// <summary>
        /// <para>The range of the scheduled fix. The value of this parameter is in the JSON format and contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><b>type</b>: The type of the image. The value is fixed to repo.</description></item>
        /// <item><description><b>target</b>: The content of the image. The value is in the format of Namespace/Image repository.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;type\&quot;:\&quot;repo\&quot;,\&quot;target\&quot;:[\&quot;cdp-uat/zentao\&quot;,\&quot;qa-dac/yyuan9\&quot;,\&quot;cafdms-qa/xxl-job-admin\&quot;]}</para>
        /// </summary>
        [NameInMap("ImageFixTarget")]
        [Validation(Required=false)]
        public string ImageFixTarget { get; set; }

        /// <summary>
        /// <para>The time range during which the image was modified. Unit: day.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("ImageTimeRange")]
        [Validation(Required=false)]
        public int? ImageTimeRange { get; set; }

    }

}
