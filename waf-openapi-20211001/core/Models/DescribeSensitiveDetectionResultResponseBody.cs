// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeSensitiveDetectionResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned for the compliance detection results.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeSensitiveDetectionResultResponseBodyData Data { get; set; }
        public class DescribeSensitiveDetectionResultResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The compliance detection results for sensitive data.</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<DescribeSensitiveDetectionResultResponseBodyDataResult> Result { get; set; }
            public class DescribeSensitiveDetectionResultResponseBodyDataResult : TeaModel {
                /// <summary>
                /// <para>The result of the compliance detection. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>report</b>: A risk of outbound data transfer is detected.</para>
                /// </description></item>
                /// <item><description><para><b>none</b>: No risk of outbound data transfer is detected.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>report</para>
                /// </summary>
                [NameInMap("DetectionResult")]
                [Validation(Required=false)]
                public string DetectionResult { get; set; }

                /// <summary>
                /// <para>The detection results for each sensitive data type.</para>
                /// </summary>
                [NameInMap("List")]
                [Validation(Required=false)]
                public List<DescribeSensitiveDetectionResultResponseBodyDataResultList> List { get; set; }
                public class DescribeSensitiveDetectionResultResponseBodyDataResultList : TeaModel {
                    /// <summary>
                    /// <para>The number of personal information items.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>11</para>
                    /// </summary>
                    [NameInMap("InfoCount")]
                    [Validation(Required=false)]
                    public long? InfoCount { get; set; }

                    /// <summary>
                    /// <para>The number of outbound transfers of personal information.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>6</para>
                    /// </summary>
                    [NameInMap("OutboundCount")]
                    [Validation(Required=false)]
                    public long? OutboundCount { get; set; }

                    /// <summary>
                    /// <para>The code of the sensitive data type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1002</para>
                    /// </summary>
                    [NameInMap("SensitiveCode")]
                    [Validation(Required=false)]
                    public long? SensitiveCode { get; set; }

                }

                /// <summary>
                /// <para>The statistics for the most frequently detected sensitive data type.</para>
                /// </summary>
                [NameInMap("Max")]
                [Validation(Required=false)]
                public DescribeSensitiveDetectionResultResponseBodyDataResultMax Max { get; set; }
                public class DescribeSensitiveDetectionResultResponseBodyDataResultMax : TeaModel {
                    /// <summary>
                    /// <para>The number of personal information items for the most frequently detected sensitive data type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>187</para>
                    /// </summary>
                    [NameInMap("InfoCount")]
                    [Validation(Required=false)]
                    public long? InfoCount { get; set; }

                    /// <summary>
                    /// <para>The number of outbound transfers of personal information for the most frequently detected sensitive data type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>54</para>
                    /// </summary>
                    [NameInMap("OutboundCount")]
                    [Validation(Required=false)]
                    public long? OutboundCount { get; set; }

                    /// <summary>
                    /// <para>The code of the sensitive data type that is most frequently detected.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1003</para>
                    /// </summary>
                    [NameInMap("SensitiveCode")]
                    [Validation(Required=false)]
                    public long? SensitiveCode { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D7861F61-5B61-46CE-A47C-6B19160D5EB0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
