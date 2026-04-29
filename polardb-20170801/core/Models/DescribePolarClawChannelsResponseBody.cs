// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribePolarClawChannelsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>pa-**************</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        [NameInMap("Channels")]
        [Validation(Required=false)]
        public List<DescribePolarClawChannelsResponseBodyChannels> Channels { get; set; }
        public class DescribePolarClawChannelsResponseBodyChannels : TeaModel {
            [NameInMap("Accounts")]
            [Validation(Required=false)]
            public List<DescribePolarClawChannelsResponseBodyChannelsAccounts> Accounts { get; set; }
            public class DescribePolarClawChannelsResponseBodyChannelsAccounts : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("AccountId")]
                [Validation(Required=false)]
                public string AccountId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Configured")]
                [Validation(Required=false)]
                public bool? Configured { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Connected")]
                [Validation(Required=false)]
                public bool? Connected { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                [NameInMap("Issues")]
                [Validation(Required=false)]
                public List<string> Issues { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("LastInboundAt")]
                [Validation(Required=false)]
                public long? LastInboundAt { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("LastOutboundAt")]
                [Validation(Required=false)]
                public long? LastOutboundAt { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>feishu</para>
            /// </summary>
            [NameInMap("ChannelId")]
            [Validation(Required=false)]
            public string ChannelId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Configured")]
            [Validation(Required=false)]
            public bool? Configured { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("DefaultAccountId")]
            [Validation(Required=false)]
            public string DefaultAccountId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2281C6C9-CBAB-1AFD-8400-670750CF6025_2212</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
