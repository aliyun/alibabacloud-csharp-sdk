// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetAlertEventResponseBody : TeaModel {
        [NameInMap("AlertEventInfo")]
        [Validation(Required=false)]
        public GetAlertEventResponseBodyAlertEventInfo AlertEventInfo { get; set; }
        public class GetAlertEventResponseBodyAlertEventInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>ONCE</para>
            /// </summary>
            [NameInMap("AlertFrequency")]
            [Validation(Required=false)]
            public string AlertFrequency { get; set; }

            [NameInMap("AlertObject")]
            [Validation(Required=false)]
            public GetAlertEventResponseBodyAlertEventInfoAlertObject AlertObject { get; set; }
            public class GetAlertEventResponseBodyAlertEventInfoAlertObject : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ALL</para>
                /// </summary>
                [NameInMap("SourceSystemType")]
                [Validation(Required=false)]
                public string SourceSystemType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>VDM_BATCH_PYTHON37</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("AlertReason")]
            [Validation(Required=false)]
            public GetAlertEventResponseBodyAlertEventInfoAlertReason AlertReason { get; set; }
            public class GetAlertEventResponseBodyAlertEventInfoAlertReason : TeaModel {
                [NameInMap("AlertReasonParamList")]
                [Validation(Required=false)]
                public List<GetAlertEventResponseBodyAlertEventInfoAlertReasonAlertReasonParamList> AlertReasonParamList { get; set; }
                public class GetAlertEventResponseBodyAlertEventInfoAlertReasonAlertReasonParamList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>biz_date</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2024-11-04 00:00:00</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-11-05 16:19:32</para>
                /// </summary>
                [NameInMap("BizDate")]
                [Validation(Required=false)]
                public string BizDate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>VDM_BATCH_FINISH</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>t_6340131422711644160_20241104_6340142</para>
                /// </summary>
                [NameInMap("UniqueKey")]
                [Validation(Required=false)]
                public string UniqueKey { get; set; }

            }

            [NameInMap("AlertReceiverList")]
            [Validation(Required=false)]
            public List<GetAlertEventResponseBodyAlertEventInfoAlertReceiverList> AlertReceiverList { get; set; }
            public class GetAlertEventResponseBodyAlertEventInfoAlertReceiverList : TeaModel {
                [NameInMap("AlertChannelTypeList")]
                [Validation(Required=false)]
                public List<string> AlertChannelTypeList { get; set; }

                [NameInMap("CustomAlertChannelIdList")]
                [Validation(Required=false)]
                public List<string> CustomAlertChannelIdList { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("OnCallTableName")]
                [Validation(Required=false)]
                public string OnCallTableName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>OWNER</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("UserList")]
                [Validation(Required=false)]
                public List<GetAlertEventResponseBodyAlertEventInfoAlertReceiverListUserList> UserList { get; set; }
                public class GetAlertEventResponseBodyAlertEventInfoAlertReceiverListUserList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Admin</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

            }

            [NameInMap("BelongProject")]
            [Validation(Required=false)]
            public GetAlertEventResponseBodyAlertEventInfoBelongProject BelongProject { get; set; }
            public class GetAlertEventResponseBodyAlertEventInfoBelongProject : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>biz_1</para>
                /// </summary>
                [NameInMap("BizName")]
                [Validation(Required=false)]
                public string BizName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>project_1</para>
                /// </summary>
                [NameInMap("ProjectName")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-11-05 00:00:00</para>
            /// </summary>
            [NameInMap("DoNotDisturbEndTime")]
            [Validation(Required=false)]
            public string DoNotDisturbEndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-11-05 16:19:33</para>
            /// </summary>
            [NameInMap("FirstAlertTime")]
            [Validation(Required=false)]
            public string FirstAlertTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12345</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-11-05 16:19:33</para>
            /// </summary>
            [NameInMap("LatestAlertTime")]
            [Validation(Required=false)]
            public string LatestAlertTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>FINISH</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalAlertTimes")]
            [Validation(Required=false)]
            public long? TotalAlertTimes { get; set; }

            [NameInMap("UrlConfig")]
            [Validation(Required=false)]
            public GetAlertEventResponseBodyAlertEventInfoUrlConfig UrlConfig { get; set; }
            public class GetAlertEventResponseBodyAlertEventInfoUrlConfig : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://dataphin.com/ops/test3">https://dataphin.com/ops/test3</a></para>
                /// </summary>
                [NameInMap("AlertConfigUrl")]
                [Validation(Required=false)]
                public string AlertConfigUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://dataphin.com/ops/test2">https://dataphin.com/ops/test2</a></para>
                /// </summary>
                [NameInMap("LogUrl")]
                [Validation(Required=false)]
                public string LogUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://dataphin.com/ops/test1">https://dataphin.com/ops/test1</a></para>
                /// </summary>
                [NameInMap("ObjectUrl")]
                [Validation(Required=false)]
                public string ObjectUrl { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>75DD06F8-1661-5A6E-B0A6-7E23133BDC60</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
