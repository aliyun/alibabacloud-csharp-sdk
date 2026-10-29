// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class StartRenderingSessionResponseBody : TeaModel {
        /// <summary>
        /// <para>The instance hostname. The default value is the access elastic IP address (EIP).</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-xxx.ecr.aliyuncs.com</para>
        /// </summary>
        [NameInMap("Hostname")]
        [Validation(Required=false)]
        public string Hostname { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is a repeated request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsRepeatedRequest")]
        [Validation(Required=false)]
        public bool? IsRepeatedRequest { get; set; }

        /// <summary>
        /// <para>The location information of the cloud application service instance.</para>
        /// </summary>
        [NameInMap("Location")]
        [Validation(Required=false)]
        public StartRenderingSessionResponseBodyLocation Location { get; set; }
        public class StartRenderingSessionResponseBodyLocation : TeaModel {
            /// <summary>
            /// <para>The province code of the cloud application service instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>610000</para>
            /// </summary>
            [NameInMap("ProvinceCode")]
            [Validation(Required=false)]
            public string ProvinceCode { get; set; }

        }

        /// <summary>
        /// <para>The port mapping information.</para>
        /// </summary>
        [NameInMap("PortMappings")]
        [Validation(Required=false)]
        public List<StartRenderingSessionResponseBodyPortMappings> PortMappings { get; set; }
        public class StartRenderingSessionResponseBodyPortMappings : TeaModel {
            /// <summary>
            /// <para>The public port or port range, such as 22. For a port range, separate the start port and end port with a forward slash (/), for example, 10/20.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10013/10020</para>
            /// </summary>
            [NameInMap("ExternalPort")]
            [Validation(Required=false)]
            public string ExternalPort { get; set; }

            /// <summary>
            /// <para>The internal port or port range. The internal port corresponds to the public port on a one-to-one basis. For a port range, separate the start port and end port with a forward slash (/), for example, 10/20.</para>
            /// 
            /// <b>Example:</b>
            /// <para>49008/49015</para>
            /// </summary>
            [NameInMap("InternalPort")]
            [Validation(Required=false)]
            public string InternalPort { get; set; }

        }

        /// <summary>
        /// <para>The cloud application service instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>render-9f8c57355d224ad7beaf95e145f22111</para>
        /// </summary>
        [NameInMap("RenderingInstanceId")]
        [Validation(Required=false)]
        public string RenderingInstanceId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BEA5625F-8FCF-48F4-851B-CA63946DA664</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The session ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>session-i205217481741918129226</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>The session state information.</para>
        /// </summary>
        [NameInMap("StateInfo")]
        [Validation(Required=false)]
        public StartRenderingSessionResponseBodyStateInfo StateInfo { get; set; }
        public class StartRenderingSessionResponseBodyStateInfo : TeaModel {
            /// <summary>
            /// <para>The state description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Session starting</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>The session state.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SessionStarting</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The time when the state was last updated. The value is a UTC time in the YYYY-MM-DDTHH:mmZ format based on the ISO 8601 standard.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-05-06T06:37Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

    }

}
