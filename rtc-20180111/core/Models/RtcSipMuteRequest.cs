// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class RtcSipMuteRequest : TeaModel {
        /// <summary>
        /// <para>The application ID. You can create and query the ID in the console. Only a single ID is supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eo85****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The ID of an existing channel. Only a single ID is supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testid</para>
        /// </summary>
        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public string ChannelId { get; set; }

        /// <summary>
        /// <para>The operations.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Operations")]
        [Validation(Required=false)]
        public List<RtcSipMuteRequestOperations> Operations { get; set; }
        public class RtcSipMuteRequestOperations : TeaModel {
            /// <summary>
            /// <para>The list of user IDs.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Ids")]
            [Validation(Required=false)]
            public List<string> Ids { get; set; }

            /// <summary>
            /// <para>The operation type.</para>
            /// <list type="bullet">
            /// <item><description>replace</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>replace</para>
            /// </summary>
            [NameInMap("Op")]
            [Validation(Required=false)]
            public string Op { get; set; }

            /// <summary>
            /// <para>The operation ID. If some operations fail, you can use this ID for troubleshooting.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12122121</para>
            /// </summary>
            [NameInMap("OperationId")]
            [Validation(Required=false)]
            public string OperationId { get; set; }

            /// <summary>
            /// <para>The operation scope.</para>
            /// <list type="bullet">
            /// <item><description>/media/audio/status: Modifies the audio stream status of the user.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/media/audio/status</para>
            /// </summary>
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            /// <summary>
            /// <para>The operation value.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public RtcSipMuteRequestOperationsValue Value { get; set; }
            public class RtcSipMuteRequestOperationsValue : TeaModel {
                /// <summary>
                /// <para>The actual value.</para>
                /// <list type="bullet">
                /// <item><description>active: Unmutes the microphone.</description></item>
                /// <item><description>inactive: Mutes the microphone.</description></item>
                /// </list>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>inactive</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

    }

}
