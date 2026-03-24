// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribePocFunctionsResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of the POC feature details.</para>
        /// </summary>
        [NameInMap("Functions")]
        [Validation(Required=false)]
        public List<DescribePocFunctionsResponseBodyFunctions> Functions { get; set; }
        public class DescribePocFunctionsResponseBodyFunctions : TeaModel {
            /// <summary>
            /// <para>The expiration time of the POC feature trial. This value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1760581677000</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public long? ExpireTime { get; set; }

            /// <summary>
            /// <para>The type of the POC feature trial. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>apisec</b>: API security.</para>
            /// </description></item>
            /// <item><description><para><b>botWeb</b>: bot management for websites.</para>
            /// </description></item>
            /// <item><description><para><b>botApp</b>: bot management for apps.</para>
            /// </description></item>
            /// <item><description><para><b>largeLanguageModel</b>: AI-powered application protection.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>botWeb</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1557B42F-B889-460A-B17F-1DE5C5AD7FF2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
