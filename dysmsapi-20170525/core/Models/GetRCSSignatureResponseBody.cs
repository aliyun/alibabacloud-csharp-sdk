// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class GetRCSSignatureResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>示例值示例值</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetRCSSignatureResponseBodyData Data { get; set; }
        public class GetRCSSignatureResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值</para>
            /// </summary>
            [NameInMap("BackgroundImage")]
            [Validation(Required=false)]
            public string BackgroundImage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值</para>
            /// </summary>
            [NameInMap("BubbleColor")]
            [Validation(Required=false)]
            public string BubbleColor { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>90</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public long? Category { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值示例值示例值</para>
            /// </summary>
            [NameInMap("ChatbotCode")]
            [Validation(Required=false)]
            public string ChatbotCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值示例值</para>
            /// </summary>
            [NameInMap("ChatbotName")]
            [Validation(Required=false)]
            public string ChatbotName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值示例值示例值</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值示例值</para>
            /// </summary>
            [NameInMap("Latitude")]
            [Validation(Required=false)]
            public string Latitude { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值示例值</para>
            /// </summary>
            [NameInMap("Logo")]
            [Validation(Required=false)]
            public string Logo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值示例值示例值</para>
            /// </summary>
            [NameInMap("Longitude")]
            [Validation(Required=false)]
            public string Longitude { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值示例值示例值</para>
            /// </summary>
            [NameInMap("OfficeAddress")]
            [Validation(Required=false)]
            public string OfficeAddress { get; set; }

            [NameInMap("RegisterResultList")]
            [Validation(Required=false)]
            public List<GetRCSSignatureResponseBodyDataRegisterResultList> RegisterResultList { get; set; }
            public class GetRCSSignatureResponseBodyDataRegisterResultList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>示例值示例值</para>
                /// </summary>
                [NameInMap("OperatorCode")]
                [Validation(Required=false)]
                public string OperatorCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>46</para>
                /// </summary>
                [NameInMap("ProductType")]
                [Validation(Required=false)]
                public long? ProductType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>示例值示例值示例值</para>
                /// </summary>
                [NameInMap("RegisterCompleteTime")]
                [Validation(Required=false)]
                public string RegisterCompleteTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>72</para>
                /// </summary>
                [NameInMap("RegisterStatus")]
                [Validation(Required=false)]
                public long? RegisterStatus { get; set; }

                [NameInMap("RegisterStatusReasons")]
                [Validation(Required=false)]
                public List<GetRCSSignatureResponseBodyDataRegisterResultListRegisterStatusReasons> RegisterStatusReasons { get; set; }
                public class GetRCSSignatureResponseBodyDataRegisterResultListRegisterStatusReasons : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>示例值示例值</para>
                    /// </summary>
                    [NameInMap("ReasonCode")]
                    [Validation(Required=false)]
                    public string ReasonCode { get; set; }

                    [NameInMap("ReasonDescList")]
                    [Validation(Required=false)]
                    public List<string> ReasonDescList { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值</para>
            /// </summary>
            [NameInMap("ServiceEmail")]
            [Validation(Required=false)]
            public string ServiceEmail { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值示例值示例值</para>
            /// </summary>
            [NameInMap("ServicePhone")]
            [Validation(Required=false)]
            public string ServicePhone { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值示例值示例值</para>
            /// </summary>
            [NameInMap("ServiceTerms")]
            [Validation(Required=false)]
            public string ServiceTerms { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值示例值</para>
            /// </summary>
            [NameInMap("ServiceWebsite")]
            [Validation(Required=false)]
            public string ServiceWebsite { get; set; }

            [NameInMap("ShelfResultList")]
            [Validation(Required=false)]
            public List<GetRCSSignatureResponseBodyDataShelfResultList> ShelfResultList { get; set; }
            public class GetRCSSignatureResponseBodyDataShelfResultList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>示例值示例值</para>
                /// </summary>
                [NameInMap("OperatorCode")]
                [Validation(Required=false)]
                public string OperatorCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>81</para>
                /// </summary>
                [NameInMap("ProductType")]
                [Validation(Required=false)]
                public long? ProductType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>51</para>
                /// </summary>
                [NameInMap("ShelfStatus")]
                [Validation(Required=false)]
                public long? ShelfStatus { get; set; }

                [NameInMap("ShelfStatusReasons")]
                [Validation(Required=false)]
                public List<GetRCSSignatureResponseBodyDataShelfResultListShelfStatusReasons> ShelfStatusReasons { get; set; }
                public class GetRCSSignatureResponseBodyDataShelfResultListShelfStatusReasons : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>示例值示例值示例值</para>
                    /// </summary>
                    [NameInMap("ReasonCode")]
                    [Validation(Required=false)]
                    public string ReasonCode { get; set; }

                    [NameInMap("ReasonDescList")]
                    [Validation(Required=false)]
                    public List<string> ReasonDescList { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>32</para>
            /// </summary>
            [NameInMap("SignId")]
            [Validation(Required=false)]
            public long? SignId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值示例值</para>
            /// </summary>
            [NameInMap("SignName")]
            [Validation(Required=false)]
            public string SignName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>示例值示例值</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>示例值示例值</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
