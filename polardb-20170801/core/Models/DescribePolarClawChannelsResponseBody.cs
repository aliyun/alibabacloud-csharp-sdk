// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribePolarClawChannelsResponseBody : TeaModel {
        /// <summary>
        /// <para>The application ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pa-**************</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <para>A list of PolarClaw channel objects.</para>
        /// </summary>
        [NameInMap("Channels")]
        [Validation(Required=false)]
        public List<DescribePolarClawChannelsResponseBodyChannels> Channels { get; set; }
        public class DescribePolarClawChannelsResponseBodyChannels : TeaModel {
            /// <summary>
            /// <para>A list of account objects for the channel.</para>
            /// </summary>
            [NameInMap("Accounts")]
            [Validation(Required=false)]
            public List<DescribePolarClawChannelsResponseBodyChannelsAccounts> Accounts { get; set; }
            public class DescribePolarClawChannelsResponseBodyChannelsAccounts : TeaModel {
                /// <summary>
                /// <para>The account ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("AccountId")]
                [Validation(Required=false)]
                public string AccountId { get; set; }

                /// <summary>
                /// <para>Indicates whether the account is configured.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Configured")]
                [Validation(Required=false)]
                public bool? Configured { get; set; }

                /// <summary>
                /// <para>Indicates whether the account is connected.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Connected")]
                [Validation(Required=false)]
                public bool? Connected { get; set; }

                /// <summary>
                /// <para>Indicates whether the account is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                /// <summary>
                /// <para>A list of issues related to the account.</para>
                /// </summary>
                [NameInMap("Issues")]
                [Validation(Required=false)]
                public List<string> Issues { get; set; }

                /// <summary>
                /// <para>The timestamp (in milliseconds) of the last inbound message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("LastInboundAt")]
                [Validation(Required=false)]
                public long? LastInboundAt { get; set; }

                /// <summary>
                /// <para>The timestamp (in milliseconds) of the last outbound message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("LastOutboundAt")]
                [Validation(Required=false)]
                public long? LastOutboundAt { get; set; }

            }

            /// <summary>
            /// <para>The channel ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>feishu</para>
            /// </summary>
            [NameInMap("ChannelId")]
            [Validation(Required=false)]
            public string ChannelId { get; set; }

            /// <summary>
            /// <para>Indicates whether the channel is configured.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Configured")]
            [Validation(Required=false)]
            public bool? Configured { get; set; }

            /// <summary>
            /// <para>The default account ID for the channel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("DefaultAccountId")]
            [Validation(Required=false)]
            public string DefaultAccountId { get; set; }

            /// <summary>
            /// <para>Indicates whether the channel is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

        }

        /// <summary>
        /// <para>The returned status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The response message. A value of <c>successful</c> indicates that the request succeeded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2281C6C9-CBAB-1AFD-8400-670750CF6025_2212</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
