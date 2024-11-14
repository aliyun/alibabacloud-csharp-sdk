// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeSensitiveDetectionResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The compliance check results.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeSensitiveDetectionResultResponseBodyData Data { get; set; }
        public class DescribeSensitiveDetectionResultResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The compliance checks.</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<DescribeSensitiveDetectionResultResponseBodyDataResult> Result { get; set; }
            public class DescribeSensitiveDetectionResultResponseBodyDataResult : TeaModel {
                /// <summary>
                /// <para>The compliance check results. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>report</b>: Risks exist in cross-border data transfer.</description></item>
                /// <item><description><b>none</b>: No risks exist in cross-border data transfer.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>report</para>
                /// </summary>
                [NameInMap("DetectionResult")]
                [Validation(Required=false)]
                public string DetectionResult { get; set; }

                /// <summary>
                /// <para>The sensitive information check results by sensitive data type.</para>
                /// </summary>
                [NameInMap("List")]
                [Validation(Required=false)]
                public List<DescribeSensitiveDetectionResultResponseBodyDataResultList> List { get; set; }
                public class DescribeSensitiveDetectionResultResponseBodyDataResultList : TeaModel {
                    /// <summary>
                    /// <para>The number of personal information records.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>11</para>
                    /// </summary>
                    [NameInMap("InfoCount")]
                    [Validation(Required=false)]
                    public long? InfoCount { get; set; }

                    /// <summary>
                    /// <para>The number of sensitive personal information records that are involved in cross-border data transfer.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>6</para>
                    /// </summary>
                    [NameInMap("OutboundCount")]
                    [Validation(Required=false)]
                    public long? OutboundCount { get; set; }

                    /// <summary>
                    /// <para>The sensitive data type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1002</para>
                    /// </summary>
                    [NameInMap("SensitiveCode")]
                    [Validation(Required=false)]
                    public long? SensitiveCode { get; set; }

                }

                /// <summary>
                /// <para>The maximum values in the statistics of sensitive data types.</para>
                /// </summary>
                [NameInMap("Max")]
                [Validation(Required=false)]
                public DescribeSensitiveDetectionResultResponseBodyDataResultMax Max { get; set; }
                public class DescribeSensitiveDetectionResultResponseBodyDataResultMax : TeaModel {
                    /// <summary>
                    /// <para>The number of sensitive personal information records that are of the most frequent sensitive data type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>187</para>
                    /// </summary>
                    [NameInMap("InfoCount")]
                    [Validation(Required=false)]
                    public long? InfoCount { get; set; }

                    /// <summary>
                    /// <para>The number of sensitive personal information records that are of the most frequent sensitive data type and are involved in cross-border data transfer.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>54</para>
                    /// </summary>
                    [NameInMap("OutboundCount")]
                    [Validation(Required=false)]
                    public long? OutboundCount { get; set; }

                    /// <summary>
                    /// <para>The most frequent sensitive data type.</para>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D7861F61-5B61-46CE-A47C-6B19160D5EB0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
