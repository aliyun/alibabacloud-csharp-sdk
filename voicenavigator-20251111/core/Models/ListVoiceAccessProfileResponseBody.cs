// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20251111.Models
{
    public class ListVoiceAccessProfileResponseBody : TeaModel {
        /// <summary>
        /// <para>The internal error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The paginated results of third-party voice configurations.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListVoiceAccessProfileResponseBodyData Data { get; set; }
        public class ListVoiceAccessProfileResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

            /// <summary>
            /// <para>The list of third-party voice configurations.</para>
            /// </summary>
            [NameInMap("VoiceAccessProfiles")]
            [Validation(Required=false)]
            public List<ListVoiceAccessProfileResponseBodyDataVoiceAccessProfiles> VoiceAccessProfiles { get; set; }
            public class ListVoiceAccessProfileResponseBodyDataVoiceAccessProfiles : TeaModel {
                /// <summary>
                /// <para>The configuration ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>af81a389-91f0-4157-8d82-720edd02b66b</para>
                /// </summary>
                [NameInMap("AccessProfileId")]
                [Validation(Required=false)]
                public string AccessProfileId { get; set; }

                /// <summary>
                /// <para>The list of voice engine capabilities.</para>
                /// </summary>
                [NameInMap("Capabilities")]
                [Validation(Required=false)]
                public List<string> Capabilities { get; set; }

                /// <summary>
                /// <para>The creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1747620752000</para>
                /// </summary>
                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public long? CreatedTime { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>af81a389-91f0-4157-8d82-720edd02b66a</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The voice engine.</para>
                /// 
                /// <b>Example:</b>
                /// <para>VOLC</para>
                /// </summary>
                [NameInMap("NlsEngine")]
                [Validation(Required=false)]
                public string NlsEngine { get; set; }

                /// <summary>
                /// <para>The display name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Doubao</para>
                /// </summary>
                [NameInMap("NlsEngineName")]
                [Validation(Required=false)]
                public string NlsEngineName { get; set; }

                /// <summary>
                /// <para>The parameter settings.</para>
                /// </summary>
                [NameInMap("Profile")]
                [Validation(Required=false)]
                public ListVoiceAccessProfileResponseBodyDataVoiceAccessProfilesProfile Profile { get; set; }
                public class ListVoiceAccessProfileResponseBodyDataVoiceAccessProfilesProfile : TeaModel {
                    /// <summary>
                    /// <para>The AccessKey for Doubao API calls.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HwRnTXgwnQOlsj68URDS5_VMm4Wtapq9</para>
                    /// </summary>
                    [NameInMap("AccessKey")]
                    [Validation(Required=false)]
                    public string AccessKey { get; set; }

                    /// <summary>
                    /// <para>The ApiKey for Alibaba Cloud Bailian and iFLYTEK API calls.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>sk-12341e259b1049e8872b47981e545f78</para>
                    /// </summary>
                    [NameInMap("ApiKey")]
                    [Validation(Required=false)]
                    public string ApiKey { get; set; }

                    /// <summary>
                    /// <para>The ApiSecret for iFLYTEK API calls.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>c0358c6e51c1013b446fdeb21a3a1234</para>
                    /// </summary>
                    [NameInMap("ApiSecret")]
                    [Validation(Required=false)]
                    public string ApiSecret { get; set; }

                    /// <summary>
                    /// <para>The AppId for iFLYTEK API calls.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5b123bfb</para>
                    /// </summary>
                    [NameInMap("AppId")]
                    [Validation(Required=false)]
                    public string AppId { get; set; }

                    /// <summary>
                    /// <para>The AppKey for Doubao API calls.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2541370123</para>
                    /// </summary>
                    [NameInMap("AppKey")]
                    [Validation(Required=false)]
                    public string AppKey { get; set; }

                    /// <summary>
                    /// <para>This parameter is not in use.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Not in use</para>
                    /// </summary>
                    [NameInMap("AsrAppKey")]
                    [Validation(Required=false)]
                    public string AsrAppKey { get; set; }

                    /// <summary>
                    /// <para>This parameter is not in use.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Not in use</para>
                    /// </summary>
                    [NameInMap("TtsApiKey")]
                    [Validation(Required=false)]
                    public string TtsApiKey { get; set; }

                }

                /// <summary>
                /// <para>The update time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1747620752000</para>
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
        /// <para>Instance af81a389-91f0-4157-8d82-720edd02b66a
        ///  does not exist.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The list of dynamic error parameters.</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<string> Params { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C1788610-93C9-574C-AF2D-C053A50C3894</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
