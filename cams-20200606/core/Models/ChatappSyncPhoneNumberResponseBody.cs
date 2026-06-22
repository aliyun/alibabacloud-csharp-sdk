// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class ChatappSyncPhoneNumberResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the access denial.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The HTTP status code returned.</para>
        /// <list type="bullet">
        /// <item><description><para>A value of OK indicates that the call is successful.</para>
        /// </description></item>
        /// <item><description><para>Other values indicate that the call fails. For more information, see <a href="https://help.aliyun.com/document_detail/196974.html">Error codes</a>.</para>
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
        /// <para>The error message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The phone numbers.</para>
        /// </summary>
        [NameInMap("PhoneNumbers")]
        [Validation(Required=false)]
        public List<ChatappSyncPhoneNumberResponseBodyPhoneNumbers> PhoneNumbers { get; set; }
        public class ChatappSyncPhoneNumberResponseBodyPhoneNumbers : TeaModel {
            [NameInMap("CallingConfigure")]
            [Validation(Required=false)]
            public ChatappSyncPhoneNumberResponseBodyPhoneNumbersCallingConfigure CallingConfigure { get; set; }
            public class ChatappSyncPhoneNumberResponseBodyPhoneNumbersCallingConfigure : TeaModel {
                [NameInMap("Calling")]
                [Validation(Required=false)]
                public ChatappSyncPhoneNumberResponseBodyPhoneNumbersCallingConfigureCalling Calling { get; set; }
                public class ChatappSyncPhoneNumberResponseBodyPhoneNumbersCallingConfigureCalling : TeaModel {
                    [NameInMap("CallHours")]
                    [Validation(Required=false)]
                    public ChatappSyncPhoneNumberResponseBodyPhoneNumbersCallingConfigureCallingCallHours CallHours { get; set; }
                    public class ChatappSyncPhoneNumberResponseBodyPhoneNumbersCallingConfigureCallingCallHours : TeaModel {
                        [NameInMap("HolidaySchedule")]
                        [Validation(Required=false)]
                        public List<ChatappSyncPhoneNumberResponseBodyPhoneNumbersCallingConfigureCallingCallHoursHolidaySchedule> HolidaySchedule { get; set; }
                        public class ChatappSyncPhoneNumberResponseBodyPhoneNumbersCallingConfigureCallingCallHoursHolidaySchedule : TeaModel {
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
                        public List<ChatappSyncPhoneNumberResponseBodyPhoneNumbersCallingConfigureCallingCallHoursWeeklyOperatingHours> WeeklyOperatingHours { get; set; }
                        public class ChatappSyncPhoneNumberResponseBodyPhoneNumbersCallingConfigureCallingCallHoursWeeklyOperatingHours : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>2359</para>
                            /// </summary>
                            [NameInMap("CloseTime")]
                            [Validation(Required=false)]
                            public string CloseTime { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>MONDAY</para>
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
                    /// <para>DEFAULT</para>
                    /// </summary>
                    [NameInMap("CallIconVisibility")]
                    [Validation(Required=false)]
                    public string CallIconVisibility { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>示例值示例值示例值</para>
                    /// </summary>
                    [NameInMap("CallbackPermissionStatus")]
                    [Validation(Required=false)]
                    public string CallbackPermissionStatus { get; set; }

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
                /// <para><a href="http://aliyun.com">http://aliyun.com</a></para>
                /// </summary>
                [NameInMap("CallingCallbackUrl")]
                [Validation(Required=false)]
                public string CallingCallbackUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("MaxTalkTime")]
                [Validation(Required=false)]
                public long? MaxTalkTime { get; set; }

            }

            /// <summary>
            /// <para>The verification state of the phone number.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>REVOKED: The review application is revoked.</para>
            /// </description></item>
            /// <item><description><para>MORE_INFORMATION_REQUESTED: More information needs to be provided.</para>
            /// </description></item>
            /// <item><description><para>VERIFIED: The phone number passes the verification.</para>
            /// </description></item>
            /// <item><description><para>REJECTED: The phone number fails to pass the verification.</para>
            /// </description></item>
            /// </list>
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
            /// <para>The number of phone numbers to which messages can be sent in a day.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TIER_10K</para>
            /// </summary>
            [NameInMap("MessagingLimitTier")]
            [Validation(Required=false)]
            public string MessagingLimitTier { get; set; }

            /// <summary>
            /// <para>The review status of the business display name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Approval</para>
            /// </summary>
            [NameInMap("NameStatus")]
            [Validation(Required=false)]
            public string NameStatus { get; set; }

            /// <summary>
            /// <para>The review status of the new business display name.</para>
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
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>RED</para>
            /// </description></item>
            /// <item><description><para>YELLOW</para>
            /// </description></item>
            /// <item><description><para>GREEN</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>GREEN</para>
            /// </summary>
            [NameInMap("QualityRating")]
            [Validation(Required=false)]
            public string QualityRating { get; set; }

            /// <summary>
            /// <para>The state of the phone number.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>MIGRATED</para>
            /// </description></item>
            /// <item><description><para>FLAGGED</para>
            /// </description></item>
            /// <item><description><para>DISCONNECTED</para>
            /// </description></item>
            /// <item><description><para>UNVERIFIED</para>
            /// </description></item>
            /// <item><description><para>BANNED</para>
            /// </description></item>
            /// <item><description><para>RATE_LIMITED</para>
            /// </description></item>
            /// <item><description><para>PENDING</para>
            /// </description></item>
            /// <item><description><para>CONNECTED</para>
            /// </description></item>
            /// <item><description><para>UNKNOWN</para>
            /// </description></item>
            /// <item><description><para>DELETED</para>
            /// </description></item>
            /// <item><description><para>RESTRICTED</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PENDING</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The callback URL to which status reports are sent by using HTTP callbacks.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://www.alibaba.com/status">https://www.alibaba.com/status</a></para>
            /// </summary>
            [NameInMap("StatusCallbackUrl")]
            [Validation(Required=false)]
            public string StatusCallbackUrl { get; set; }

            /// <summary>
            /// <para>The status report queue.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alicom-0939****-queue</para>
            /// </summary>
            [NameInMap("StatusQueue")]
            [Validation(Required=false)]
            public string StatusQueue { get; set; }

            /// <summary>
            /// <para>The URL that receives the MO messages.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://www.alibaba.com/inbound">https://www.alibaba.com/inbound</a></para>
            /// </summary>
            [NameInMap("UpCallbackUrl")]
            [Validation(Required=false)]
            public string UpCallbackUrl { get; set; }

            /// <summary>
            /// <para>The mobile originated (MO) message queue.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alicom-0939****-queue</para>
            /// </summary>
            [NameInMap("UpQueue")]
            [Validation(Required=false)]
            public string UpQueue { get; set; }

            /// <summary>
            /// <para>The display name of the business to which the phone number belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Alibaba</para>
            /// </summary>
            [NameInMap("VerifiedName")]
            [Validation(Required=false)]
            public string VerifiedName { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>90E63D28-E31D-1EB2-8939-A94866411B2O</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The call was successful.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The call failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
