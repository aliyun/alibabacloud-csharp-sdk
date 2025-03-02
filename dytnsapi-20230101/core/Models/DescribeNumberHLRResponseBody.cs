// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20230101.Models
{
    public class DescribeNumberHLRResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>None</para>
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
        public DescribeNumberHLRResponseBodyData Data { get; set; }
        public class DescribeNumberHLRResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值示例值</para>
            /// </summary>
            [NameInMap("Blocked")]
            [Validation(Required=false)]
            public string Blocked { get; set; }

            [NameInMap("Call")]
            [Validation(Required=false)]
            public DescribeNumberHLRResponseBodyDataCall Call { get; set; }
            public class DescribeNumberHLRResponseBodyDataCall : TeaModel {
                /// <summary>
                /// <para>call</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值</para>
                /// </summary>
                [NameInMap("CleansedCode")]
                [Validation(Required=false)]
                public string CleansedCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>22</para>
                /// </summary>
                [NameInMap("MaxLength")]
                [Validation(Required=false)]
                public long? MaxLength { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>21</para>
                /// </summary>
                [NameInMap("MinLength")]
                [Validation(Required=false)]
                public long? MinLength { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值示例值示例值</para>
            /// </summary>
            [NameInMap("Carrier")]
            [Validation(Required=false)]
            public string Carrier { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值示例值</para>
            /// </summary>
            [NameInMap("City")]
            [Validation(Required=false)]
            public string City { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值示例值</para>
            /// </summary>
            [NameInMap("CountryIso3")]
            [Validation(Required=false)]
            public string CountryIso3 { get; set; }

            [NameInMap("Live")]
            [Validation(Required=false)]
            public DescribeNumberHLRResponseBodyDataLive Live { get; set; }
            public class DescribeNumberHLRResponseBodyDataLive : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>示例值</para>
                /// </summary>
                [NameInMap("DeviceStatus")]
                [Validation(Required=false)]
                public string DeviceStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>示例值示例值</para>
                /// </summary>
                [NameInMap("Roaming")]
                [Validation(Required=false)]
                public string Roaming { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>示例值</para>
                /// </summary>
                [NameInMap("RoamingCountry")]
                [Validation(Required=false)]
                public string RoamingCountry { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>示例值</para>
                /// </summary>
                [NameInMap("SubscriberStatus")]
                [Validation(Required=false)]
                public string SubscriberStatus { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值示例值</para>
            /// </summary>
            [NameInMap("PhoneType")]
            [Validation(Required=false)]
            public string PhoneType { get; set; }

            [NameInMap("Sms")]
            [Validation(Required=false)]
            public DescribeNumberHLRResponseBodyDataSms Sms { get; set; }
            public class DescribeNumberHLRResponseBodyDataSms : TeaModel {
                /// <summary>
                /// <para>sms</para>
                /// 
                /// <b>Example:</b>
                /// <para>58</para>
                /// </summary>
                [NameInMap("CleansedCode")]
                [Validation(Required=false)]
                public long? CleansedCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>59</para>
                /// </summary>
                [NameInMap("MaxLength")]
                [Validation(Required=false)]
                public long? MaxLength { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("MinLength")]
                [Validation(Required=false)]
                public long? MinLength { get; set; }

            }

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
        /// <para>1C3B8084-3A7D-570B-BC84-BF945A9CF65E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
