// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListAlertNotificationsResponseBody : TeaModel {
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

        [NameInMap("ListResult")]
        [Validation(Required=false)]
        public ListAlertNotificationsResponseBodyListResult ListResult { get; set; }
        public class ListAlertNotificationsResponseBodyListResult : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<ListAlertNotificationsResponseBodyListResultData> Data { get; set; }
            public class ListAlertNotificationsResponseBodyListResultData : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>12345</para>
                /// </summary>
                [NameInMap("AlertEventId")]
                [Validation(Required=false)]
                public string AlertEventId { get; set; }

                [NameInMap("AlertObject")]
                [Validation(Required=false)]
                public ListAlertNotificationsResponseBodyListResultDataAlertObject AlertObject { get; set; }
                public class ListAlertNotificationsResponseBodyListResultDataAlertObject : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>VDM_BATCH</para>
                    /// </summary>
                    [NameInMap("SourceSystemType")]
                    [Validation(Required=false)]
                    public string SourceSystemType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>VDM_BATCH_SHELL</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                [NameInMap("AlertReason")]
                [Validation(Required=false)]
                public ListAlertNotificationsResponseBodyListResultDataAlertReason AlertReason { get; set; }
                public class ListAlertNotificationsResponseBodyListResultDataAlertReason : TeaModel {
                    [NameInMap("AlertReasonParamList")]
                    [Validation(Required=false)]
                    public List<ListAlertNotificationsResponseBodyListResultDataAlertReasonAlertReasonParamList> AlertReasonParamList { get; set; }
                    public class ListAlertNotificationsResponseBodyListResultDataAlertReasonAlertReasonParamList : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>biz_date</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>2024-11-24 00:00:00</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>20241125</para>
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
                    /// <para>123456</para>
                    /// </summary>
                    [NameInMap("UniqueKey")]
                    [Validation(Required=false)]
                    public string UniqueKey { get; set; }

                }

                [NameInMap("AlertReceiver")]
                [Validation(Required=false)]
                public ListAlertNotificationsResponseBodyListResultDataAlertReceiver AlertReceiver { get; set; }
                public class ListAlertNotificationsResponseBodyListResultDataAlertReceiver : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>SMS</para>
                    /// </summary>
                    [NameInMap("AlertChannelType")]
                    [Validation(Required=false)]
                    public string AlertChannelType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>123456</para>
                    /// </summary>
                    [NameInMap("CustomAlertChannelId")]
                    [Validation(Required=false)]
                    public string CustomAlertChannelId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>12345</para>
                    /// </summary>
                    [NameInMap("OnCallTableId")]
                    [Validation(Required=false)]
                    public string OnCallTableId { get; set; }

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

                    [NameInMap("User")]
                    [Validation(Required=false)]
                    public ListAlertNotificationsResponseBodyListResultDataAlertReceiverUser User { get; set; }
                    public class ListAlertNotificationsResponseBodyListResultDataAlertReceiverUser : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>ADMIN</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                }

                [NameInMap("AlertSend")]
                [Validation(Required=false)]
                public ListAlertNotificationsResponseBodyListResultDataAlertSend AlertSend { get; set; }
                public class ListAlertNotificationsResponseBodyListResultDataAlertSend : TeaModel {
                    [NameInMap("FailReason")]
                    [Validation(Required=false)]
                    public string FailReason { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("SendContent")]
                    [Validation(Required=false)]
                    public string SendContent { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2024-11-25 10:02:47</para>
                    /// </summary>
                    [NameInMap("SendTime")]
                    [Validation(Required=false)]
                    public string SendTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>SUCCESS</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

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
