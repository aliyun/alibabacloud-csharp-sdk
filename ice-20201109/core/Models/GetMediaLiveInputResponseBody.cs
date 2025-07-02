// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetMediaLiveInputResponseBody : TeaModel {
        /// <summary>
        /// <para>The input information.</para>
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public GetMediaLiveInputResponseBodyInput Input { get; set; }
        public class GetMediaLiveInputResponseBodyInput : TeaModel {
            /// <summary>
            /// <para>The IDs of the channels associated with the input.</para>
            /// </summary>
            [NameInMap("ChannelIds")]
            [Validation(Required=false)]
            public List<string> ChannelIds { get; set; }

            /// <summary>
            /// <para>The time when the input was created. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-12-03T06:56:42Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The ID of the input.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SEGK5KA6KYKAWQQH</para>
            /// </summary>
            [NameInMap("InputId")]
            [Validation(Required=false)]
            public string InputId { get; set; }

            /// <summary>
            /// <para>The input configurations.</para>
            /// </summary>
            [NameInMap("InputInfos")]
            [Validation(Required=false)]
            public List<GetMediaLiveInputResponseBodyInputInputInfos> InputInfos { get; set; }
            public class GetMediaLiveInputResponseBodyInputInputInfos : TeaModel {
                /// <summary>
                /// <para>The endpoint that the stream is pushed to. This parameter is returned for PUSH inputs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rtmp://domain/app/stream</para>
                /// </summary>
                [NameInMap("DestHost")]
                [Validation(Required=false)]
                public string DestHost { get; set; }

                /// <summary>
                /// <para>The ID of the flow from MediaConnect.</para>
                /// 
                /// <b>Example:</b>
                /// <para><b><b><b>81-9693-40dc-bbab-db5e49</b></b></b></para>
                /// </summary>
                [NameInMap("FlowId")]
                [Validation(Required=false)]
                public string FlowId { get; set; }

                /// <summary>
                /// <para>The output name of the MediaConnect flow.</para>
                /// 
                /// <b>Example:</b>
                /// <para>myFlowOutputName</para>
                /// </summary>
                [NameInMap("FlowOutputName")]
                [Validation(Required=false)]
                public string FlowOutputName { get; set; }

                /// <summary>
                /// <para>The URL for input monitoring.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rtmp://domain/app/stream_for_monitor</para>
                /// </summary>
                [NameInMap("MonitorUrl")]
                [Validation(Required=false)]
                public string MonitorUrl { get; set; }

                /// <summary>
                /// <para>The source URL where the stream is pulled from. This parameter is returned for PULL inputs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rtmp://domain/app/stream</para>
                /// </summary>
                [NameInMap("SourceUrl")]
                [Validation(Required=false)]
                public string SourceUrl { get; set; }

                /// <summary>
                /// <para>The name of the pushed stream. This parameter is returned for PUSH inputs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mystream</para>
                /// </summary>
                [NameInMap("StreamName")]
                [Validation(Required=false)]
                public string StreamName { get; set; }

            }

            /// <summary>
            /// <para>The name of the input.</para>
            /// 
            /// <b>Example:</b>
            /// <para>myinput</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The IDs of the security groups associated with the input.</para>
            /// </summary>
            [NameInMap("SecurityGroupIds")]
            [Validation(Required=false)]
            public List<string> SecurityGroupIds { get; set; }

            /// <summary>
            /// <para>The input type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RTMP_PUSH</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>11-DB8D-4A9A-875B-275798</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
