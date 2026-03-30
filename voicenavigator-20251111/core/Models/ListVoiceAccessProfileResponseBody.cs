// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20251111.Models
{
    public class ListVoiceAccessProfileResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListVoiceAccessProfileResponseBodyData Data { get; set; }
        public class ListVoiceAccessProfileResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

            [NameInMap("VoiceAccessProfiles")]
            [Validation(Required=false)]
            public List<ListVoiceAccessProfileResponseBodyDataVoiceAccessProfiles> VoiceAccessProfiles { get; set; }
            public class ListVoiceAccessProfileResponseBodyDataVoiceAccessProfiles : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>af81a389-91f0-4157-8d82-720edd02b66b</para>
                /// </summary>
                [NameInMap("AccessProfileId")]
                [Validation(Required=false)]
                public string AccessProfileId { get; set; }

                [NameInMap("Capabilities")]
                [Validation(Required=false)]
                public List<string> Capabilities { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1747620752000</para>
                /// </summary>
                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public long? CreatedTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>af81a389-91f0-4157-8d82-720edd02b66a</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>VOLC</para>
                /// </summary>
                [NameInMap("NlsEngine")]
                [Validation(Required=false)]
                public string NlsEngine { get; set; }

                [NameInMap("NlsEngineName")]
                [Validation(Required=false)]
                public string NlsEngineName { get; set; }

                [NameInMap("Profile")]
                [Validation(Required=false)]
                public ListVoiceAccessProfileResponseBodyDataVoiceAccessProfilesProfile Profile { get; set; }
                public class ListVoiceAccessProfileResponseBodyDataVoiceAccessProfilesProfile : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>HwRnTXgwnQOlsj68URDS5_VMm4Wtapq9</para>
                    /// </summary>
                    [NameInMap("AccessKey")]
                    [Validation(Required=false)]
                    public string AccessKey { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>sk-12341e259b1049e8872b47981e545f78</para>
                    /// </summary>
                    [NameInMap("ApiKey")]
                    [Validation(Required=false)]
                    public string ApiKey { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>c0358c6e51c1013b446fdeb21a3a1234</para>
                    /// </summary>
                    [NameInMap("ApiSecret")]
                    [Validation(Required=false)]
                    public string ApiSecret { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>5b123bfb</para>
                    /// </summary>
                    [NameInMap("AppId")]
                    [Validation(Required=false)]
                    public string AppId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2541370123</para>
                    /// </summary>
                    [NameInMap("AppKey")]
                    [Validation(Required=false)]
                    public string AppKey { get; set; }

                    [NameInMap("AsrAppKey")]
                    [Validation(Required=false)]
                    public string AsrAppKey { get; set; }

                    [NameInMap("TtsApiKey")]
                    [Validation(Required=false)]
                    public string TtsApiKey { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1747620752000</para>
                /// </summary>
                [NameInMap("UpdatedTime")]
                [Validation(Required=false)]
                public long? UpdatedTime { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Instance af81a389-91f0-4157-8d82-720edd02b66a
        ///  does not exist.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<string> Params { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>C1788610-93C9-574C-AF2D-C053A50C3894</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
