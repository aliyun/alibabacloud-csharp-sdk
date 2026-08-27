// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class GetScheduledTaskPushOptionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of notification channels.</para>
        /// </summary>
        [NameInMap("channels")]
        [Validation(Required=false)]
        public List<GetScheduledTaskPushOptionsResponseBodyChannels> Channels { get; set; }
        public class GetScheduledTaskPushOptionsResponseBodyChannels : TeaModel {
            /// <summary>
            /// <para>The channel name.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DingTalk</para>
            /// </summary>
            [NameInMap("channelName")]
            [Validation(Required=false)]
            public string ChannelName { get; set; }

            /// <summary>
            /// <para>The notification method. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>hdm_alarm_sms</b>: SMS.</description></item>
            /// <item><description><b>dingtalk</b>: DingTalk chatbot.</description></item>
            /// <item><description><b>hdm_alarm_sms_and_email</b>: SMS and email.</description></item>
            /// <item><description><b>hdm_alarm_sms,dingtalk</b>: SMS and DingTalk chatbot.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DINGTALK</para>
            /// </summary>
            [NameInMap("channelType")]
            [Validation(Required=false)]
            public string ChannelType { get; set; }

            /// <summary>
            /// <para>The optional IM groups bound to this channel for the collaboration group. This value is empty when querying personal tasks.</para>
            /// </summary>
            [NameInMap("imGroups")]
            [Validation(Required=false)]
            public List<GetScheduledTaskPushOptionsResponseBodyChannelsImGroups> ImGroups { get; set; }
            public class GetScheduledTaskPushOptionsResponseBodyChannelsImGroups : TeaModel {
                /// <summary>
                /// <para>The external IM group ID.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cidExample</para>
                /// </summary>
                [NameInMap("imGroupId")]
                [Validation(Required=false)]
                public string ImGroupId { get; set; }

                /// <summary>
                /// <para>The external IM group name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Project collaboration group</para>
                /// </summary>
                [NameInMap("imGroupName")]
                [Validation(Required=false)]
                public string ImGroupName { get; set; }

                /// <summary>
                /// <para>The binding record ID of the IM group.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>101</para>
                /// </summary>
                [NameInMap("mappingId")]
                [Validation(Required=false)]
                public long? MappingId { get; set; }

            }

            /// <summary>
            /// <para>The supported methods: HEAD, GET, POST, PUT, DELETE, PATCH, OPTIONS.</para>
            /// </summary>
            [NameInMap("methods")]
            [Validation(Required=false)]
            public List<GetScheduledTaskPushOptionsResponseBodyChannelsMethods> Methods { get; set; }
            public class GetScheduledTaskPushOptionsResponseBodyChannelsMethods : TeaModel {
                /// <summary>
                /// <para>The reason why the option is grayed out.</para>
                /// 
                /// <b>Example:</b>
                /// <para>No push channel is bound</para>
                /// </summary>
                [NameInMap("disabledReason")]
                [Validation(Required=false)]
                public string DisabledReason { get; set; }

                /// <summary>
                /// <para>The feature switch. This parameter is optional when type is set to web_search.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                /// <summary>
                /// <para>The method.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>channel_bot</para>
                /// </summary>
                [NameInMap("method")]
                [Validation(Required=false)]
                public string Method { get; set; }

                /// <summary>
                /// <para>The name.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Group chatbot</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

        }

        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The prompt displayed when no third-party accounts are bound.</para>
        /// 
        /// <b>Example:</b>
        /// <para>No push channels available</para>
        /// </summary>
        [NameInMap("emptyHint")]
        [Validation(Required=false)]
        public string EmptyHint { get; set; }

        /// <summary>
        /// <para>The prompt message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
