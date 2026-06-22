// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageFixCycleConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeImageFixCycleConfigResponseBodyData Data { get; set; }
        public class DescribeImageFixCycleConfigResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The scheduled fix cycle. Unit: days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("ImageFixCycle")]
            [Validation(Required=false)]
            public int? ImageFixCycle { get; set; }

            /// <summary>
            /// <para>The scheduled image fix switch. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>on</b>: Enabled.</description></item>
            /// <item><description><b>off</b>: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("ImageFixSwitch")]
            [Validation(Required=false)]
            public string ImageFixSwitch { get; set; }

            /// <summary>
            /// <para>The scope of the scheduled image fix. This parameter is in JSON format and contains the following fields:</para>
            /// <list type="bullet">
            /// <item><description><b>type</b>: The target type. The value is fixed as repo.</description></item>
            /// <item><description><b>target</b>: The target content. Format: namespace/image repository.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;type\&quot;:\&quot;repo\&quot;,\&quot;target\&quot;:[\&quot;qa-dac/yyuan9\&quot;,\&quot;cdp-uat/zentao\&quot;,\&quot;cafdms-qa/xxl-job-admin\&quot;,\&quot;cafdms-qa/utils/jdk\&quot;,\&quot;cafmfbi/ui\&quot;,\&quot;cdp-uat/tradingdesk-webapp\&quot;]}</para>
            /// </summary>
            [NameInMap("ImageFixTarget")]
            [Validation(Required=false)]
            public string ImageFixTarget { get; set; }

            /// <summary>
            /// <para>The time range during which the image was modified. Unit: days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("ImageTimeRange")]
            [Validation(Required=false)]
            public int? ImageTimeRange { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D65AADFC-1D20-5A6A-8F6A-9FA53C0D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
