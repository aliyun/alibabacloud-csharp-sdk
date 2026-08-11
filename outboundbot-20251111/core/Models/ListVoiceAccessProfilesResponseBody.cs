// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20251111.Models
{
    public class ListVoiceAccessProfilesResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListVoiceAccessProfilesResponseBodyData Data { get; set; }
        public class ListVoiceAccessProfilesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The page number, starting from 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of records per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of records that match the conditions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

            /// <summary>
            /// <para>The data list.</para>
            /// </summary>
            [NameInMap("VoiceAccessProfiles")]
            [Validation(Required=false)]
            public List<ListVoiceAccessProfilesResponseBodyDataVoiceAccessProfiles> VoiceAccessProfiles { get; set; }
            public class ListVoiceAccessProfilesResponseBodyDataVoiceAccessProfiles : TeaModel {
                /// <summary>
                /// <para>The access profile ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4f9a8e2b-6c1d-4a7e-9b3f-2d5c8a1e7b15</para>
                /// </summary>
                [NameInMap("AccessProfileId")]
                [Validation(Required=false)]
                public string AccessProfileId { get; set; }

                /// <summary>
                /// <para>The list of supported capabilities.</para>
                /// </summary>
                [NameInMap("Capabilities")]
                [Validation(Required=false)]
                public List<string> Capabilities { get; set; }

                /// <summary>
                /// <para>The creation time, in millisecond-level timestamp.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1735660800000</para>
                /// </summary>
                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public long? CreatedTime { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4f9a8e2b-6c1d-4a7e-9b3f-2d5c8a1e7b04</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The voice engine vendor. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>BAILIAN: Bailian.</description></item>
                /// <item><description>VOLC: Doubao.</description></item>
                /// <item><description>IFLYTEK: iFLYTEK.</description></item>
                /// <item><description>TENCENT: Tencent.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>BAILIAN</para>
                /// </summary>
                [NameInMap("NlsEngine")]
                [Validation(Required=false)]
                public string NlsEngine { get; set; }

                /// <summary>
                /// <para>The display name of the voice engine vendor.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Bailian</para>
                /// </summary>
                [NameInMap("NlsEngineName")]
                [Validation(Required=false)]
                public string NlsEngineName { get; set; }

                /// <summary>
                /// <para>The configuration.</para>
                /// </summary>
                [NameInMap("Profile")]
                [Validation(Required=false)]
                public ListVoiceAccessProfilesResponseBodyDataVoiceAccessProfilesProfile Profile { get; set; }
                public class ListVoiceAccessProfilesResponseBodyDataVoiceAccessProfilesProfile : TeaModel {
                    /// <summary>
                    /// <para>Required when NlsEngine=VOLC.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <hr>
                    /// </summary>
                    [NameInMap("AccessKey")]
                    [Validation(Required=false)]
                    public string AccessKey { get; set; }

                    /// <summary>
                    /// <para>Required when NlsEngine=IFLYTEK or NlsEngine=BAILIAN.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>a9872e2342952e248727798f642936c7</para>
                    /// </summary>
                    [NameInMap("ApiKey")]
                    [Validation(Required=false)]
                    public string ApiKey { get; set; }

                    /// <summary>
                    /// <para>Required when NlsEngine=IFLYTEK.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>c0358c6e51c1013b446fdeb21a3a5d2e</para>
                    /// </summary>
                    [NameInMap("ApiSecret")]
                    [Validation(Required=false)]
                    public string ApiSecret { get; set; }

                    /// <summary>
                    /// <para>Required when NlsEngine=IFLYTEK or NlsEngine=TENCENT.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>9479688350</para>
                    /// </summary>
                    [NameInMap("AppId")]
                    [Validation(Required=false)]
                    public string AppId { get; set; }

                    /// <summary>
                    /// <para>Required when NlsEngine=VOLC.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>DW0yKRHQEe1nAd8c</para>
                    /// </summary>
                    [NameInMap("AppKey")]
                    [Validation(Required=false)]
                    public string AppKey { get; set; }

                    /// <summary>
                    /// <para>Not currently in use.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Not currently in use</para>
                    /// </summary>
                    [NameInMap("AsrAppKey")]
                    [Validation(Required=false)]
                    public string AsrAppKey { get; set; }

                    /// <summary>
                    /// <para>Required when NlsEngine=TENCENT.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>sci_r3b3e62udqcujnkerrorqztnpu</para>
                    /// </summary>
                    [NameInMap("SecretId")]
                    [Validation(Required=false)]
                    public string SecretId { get; set; }

                    /// <summary>
                    /// <para>Required when NlsEngine=TENCENT.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>y5MZfFdW6yBZgJdKonHZBA</para>
                    /// </summary>
                    [NameInMap("SecretKey")]
                    [Validation(Required=false)]
                    public string SecretKey { get; set; }

                    /// <summary>
                    /// <para>Not currently in use.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Not currently in use</para>
                    /// </summary>
                    [NameInMap("TtsApiKey")]
                    [Validation(Required=false)]
                    public string TtsApiKey { get; set; }

                }

                /// <summary>
                /// <para>The update time, in millisecond-level timestamp.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1735660800000</para>
                /// </summary>
                [NameInMap("UpdatedTime")]
                [Validation(Required=false)]
                public long? UpdatedTime { get; set; }

            }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Instance does not exist. Instance=outb001,.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The list of variable values in the error message.</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<string> Params { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FDAC7-13C5-1B64-A853-999DF105B9EF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
