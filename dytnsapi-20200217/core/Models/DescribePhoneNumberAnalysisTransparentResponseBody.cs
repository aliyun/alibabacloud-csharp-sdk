// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class DescribePhoneNumberAnalysisTransparentResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribePhoneNumberAnalysisTransparentResponseBodyData Data { get; set; }
        public class DescribePhoneNumberAnalysisTransparentResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值示例值示例值</para>
            /// </summary>
            [NameInMap("Device_risk")]
            [Validation(Required=false)]
            public string DeviceRisk { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值示例值</para>
            /// </summary>
            [NameInMap("Ip_risk")]
            [Validation(Required=false)]
            public string IpRisk { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.6</para>
            /// </summary>
            [NameInMap("Score1")]
            [Validation(Required=false)]
            public string Score1 { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.2</para>
            /// </summary>
            [NameInMap("Score2")]
            [Validation(Required=false)]
            public string Score2 { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.8</para>
            /// </summary>
            [NameInMap("Score3")]
            [Validation(Required=false)]
            public string Score3 { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CC3BB6D2-2FDF-4321-9DCE-B38165CE4C47</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
