// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class QueryChatappPhoneNumbersResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about the access denial.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The request status code.</para>
        /// <list type="bullet">
        /// <item><description><para>A value of OK indicates that the request was successful.</para>
        /// </description></item>
        /// <item><description><para>For other error codes, see <a href="https://help.aliyun.com/document_detail/196974.html">Error codes</a>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>示例值示例值</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The list of phone numbers.</para>
        /// </summary>
        [NameInMap("PhoneNumbers")]
        [Validation(Required=false)]
        public List<QueryChatappPhoneNumbersResponseBodyPhoneNumbers> PhoneNumbers { get; set; }
        public class QueryChatappPhoneNumbersResponseBodyPhoneNumbers : TeaModel {
            [NameInMap("CallingConfigure")]
            [Validation(Required=false)]
            public QueryChatappPhoneNumbersResponseBodyPhoneNumbersCallingConfigure CallingConfigure { get; set; }
            public class QueryChatappPhoneNumbersResponseBodyPhoneNumbersCallingConfigure : TeaModel {
                [NameInMap("Calling")]
                [Validation(Required=false)]
                public QueryChatappPhoneNumbersResponseBodyPhoneNumbersCallingConfigureCalling Calling { get; set; }
                public class QueryChatappPhoneNumbersResponseBodyPhoneNumbersCallingConfigureCalling : TeaModel {
                    [NameInMap("CallHours")]
                    [Validation(Required=false)]
                    public QueryChatappPhoneNumbersResponseBodyPhoneNumbersCallingConfigureCallingCallHours CallHours { get; set; }
                    public class QueryChatappPhoneNumbersResponseBodyPhoneNumbersCallingConfigureCallingCallHours : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>DEFAULT</para>
                        /// </summary>
                        [NameInMap("CallIconVisibility")]
                        [Validation(Required=false)]
                        public string CallIconVisibility { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>ENABLED</para>
                        /// </summary>
                        [NameInMap("CallbackPermissionStatus")]
                        [Validation(Required=false)]
                        public string CallbackPermissionStatus { get; set; }

                        [NameInMap("HolidaySchedule")]
                        [Validation(Required=false)]
                        public List<QueryChatappPhoneNumbersResponseBodyPhoneNumbersCallingConfigureCallingCallHoursHolidaySchedule> HolidaySchedule { get; set; }
                        public class QueryChatappPhoneNumbersResponseBodyPhoneNumbersCallingConfigureCallingCallHoursHolidaySchedule : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>2026-01-01</para>
                            /// </summary>
                            [NameInMap("Date")]
                            [Validation(Required=false)]
                            public string Date { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>2359</para>
                            /// </summary>
                            [NameInMap("EndTime")]
                            [Validation(Required=false)]
                            public string EndTime { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>0000</para>
                            /// </summary>
                            [NameInMap("StartTime")]
                            [Validation(Required=false)]
                            public string StartTime { get; set; }

                        }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>ENABLED</para>
                        /// </summary>
                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>Asia/Shanghai</para>
                        /// </summary>
                        [NameInMap("TimezoneId")]
                        [Validation(Required=false)]
                        public string TimezoneId { get; set; }

                        [NameInMap("WeeklyOperatingHours")]
                        [Validation(Required=false)]
                        public List<QueryChatappPhoneNumbersResponseBodyPhoneNumbersCallingConfigureCallingCallHoursWeeklyOperatingHours> WeeklyOperatingHours { get; set; }
                        public class QueryChatappPhoneNumbersResponseBodyPhoneNumbersCallingConfigureCallingCallHoursWeeklyOperatingHours : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>2359</para>
                            /// </summary>
                            [NameInMap("CloseTime")]
                            [Validation(Required=false)]
                            public string CloseTime { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>示例值示例值示例值</para>
                            /// </summary>
                            [NameInMap("DayOfWeek")]
                            [Validation(Required=false)]
                            public string DayOfWeek { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>0000</para>
                            /// </summary>
                            [NameInMap("OpenTime")]
                            [Validation(Required=false)]
                            public string OpenTime { get; set; }

                        }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>ENABLED</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://aliyun.com">https://aliyun.com</a></para>
                /// </summary>
                [NameInMap("CallingCallbackUrl")]
                [Validation(Required=false)]
                public string CallingCallbackUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("MaxTalkTime")]
                [Validation(Required=false)]
                public long? MaxTalkTime { get; set; }

            }

            /// <summary>
            /// <para>The verification status of the phone number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>VERIFIED</para>
            /// </summary>
            [NameInMap("CodeVerificationStatus")]
            [Validation(Required=false)]
            public string CodeVerificationStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>N</para>
            /// </summary>
            [NameInMap("IsOfficial")]
            [Validation(Required=false)]
            public string IsOfficial { get; set; }

            /// <summary>
            /// <para>The messaging limit tier of the phone number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TIER_10K</para>
            /// </summary>
            [NameInMap("MessagingLimitTier")]
            [Validation(Required=false)]
            public string MessagingLimitTier { get; set; }

            /// <summary>
            /// <para>The status of the name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Approval</para>
            /// </summary>
            [NameInMap("NameStatus")]
            [Validation(Required=false)]
            public string NameStatus { get; set; }

            /// <summary>
            /// <para>The review status of the new name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Approval</para>
            /// </summary>
            [NameInMap("NewNameStatus")]
            [Validation(Required=false)]
            public string NewNameStatus { get; set; }

            /// <summary>
            /// <para>The phone number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>861380000****</para>
            /// </summary>
            [NameInMap("PhoneNumber")]
            [Validation(Required=false)]
            public string PhoneNumber { get; set; }

            /// <summary>
            /// <para>The quality rating of the phone number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GREEN</para>
            /// </summary>
            [NameInMap("QualityRating")]
            [Validation(Required=false)]
            public string QualityRating { get; set; }

            /// <summary>
            /// <para>The status of the phone number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CONNECTED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The callback URL for delivery receipts.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://ali.com/status">https://ali.com/status</a></para>
            /// </summary>
            [NameInMap("StatusCallbackUrl")]
            [Validation(Required=false)]
            public string StatusCallbackUrl { get; set; }

            /// <summary>
            /// <para>The queue for delivery receipts of mobile terminated messages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Alicom-Queue-****-ChatAppStatus</para>
            /// </summary>
            [NameInMap("StatusQueue")]
            [Validation(Required=false)]
            public string StatusQueue { get; set; }

            /// <summary>
            /// <para>The callback URL for mobile originated messages.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://ali.com/inbound">https://ali.com/inbound</a></para>
            /// </summary>
            [NameInMap("UpCallbackUrl")]
            [Validation(Required=false)]
            public string UpCallbackUrl { get; set; }

            /// <summary>
            /// <para>The queue for mobile originated messages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Alicom-Queue-****-ChatAppInbound</para>
            /// </summary>
            [NameInMap("UpQueue")]
            [Validation(Required=false)]
            public string UpQueue { get; set; }

            /// <summary>
            /// <para>The name used for the request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Alibaba</para>
            /// </summary>
            [NameInMap("VerifiedName")]
            [Validation(Required=false)]
            public string VerifiedName { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>90E63D28-E31D-1EB2-8939-A94866411B2O</para>
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
