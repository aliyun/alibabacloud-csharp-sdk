// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class StartRenderingSessionResponseBody : TeaModel {
        /// <summary>
        /// <para>Instance hostname. By default, this is the EIP used for access.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-xxx.ecr.aliyuncs.com</para>
        /// </summary>
        [NameInMap("Hostname")]
        [Validation(Required=false)]
        public string Hostname { get; set; }

        /// <summary>
        /// <para>Is this a repeated request</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsRepeatedRequest")]
        [Validation(Required=false)]
        public bool? IsRepeatedRequest { get; set; }

        /// <summary>
        /// <para>Cloud application service instance location information</para>
        /// </summary>
        [NameInMap("Location")]
        [Validation(Required=false)]
        public StartRenderingSessionResponseBodyLocation Location { get; set; }
        public class StartRenderingSessionResponseBodyLocation : TeaModel {
            /// <summary>
            /// <para>Province code of the cloud application service instance</para>
            /// 
            /// <b>Example:</b>
            /// <para>610000</para>
            /// </summary>
            [NameInMap("ProvinceCode")]
            [Validation(Required=false)]
            public string ProvinceCode { get; set; }

        }

        /// <summary>
        /// <para>Port mapping information</para>
        /// </summary>
        [NameInMap("PortMappings")]
        [Validation(Required=false)]
        public List<StartRenderingSessionResponseBodyPortMappings> PortMappings { get; set; }
        public class StartRenderingSessionResponseBodyPortMappings : TeaModel {
            /// <summary>
            /// <para>External port or port range, such as 22. For a port range, separate the start and end ports with a forward slash (/), for example, 10/20.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10013/10020</para>
            /// </summary>
            [NameInMap("ExternalPort")]
            [Validation(Required=false)]
            public string ExternalPort { get; set; }

            /// <summary>
            /// <para>Internal port or port range. Ports correspond one-to-one with external ports. For a port range, separate the start and end ports with a forward slash (/), for example, 10/20.</para>
            /// 
            /// <b>Example:</b>
            /// <para>49008/49015</para>
            /// </summary>
            [NameInMap("InternalPort")]
            [Validation(Required=false)]
            public string InternalPort { get; set; }

        }

        /// <summary>
        /// <para>Cloud application service instance ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>render-9f8c57355d224ad7beaf95e145f22111</para>
        /// </summary>
        [NameInMap("RenderingInstanceId")]
        [Validation(Required=false)]
        public string RenderingInstanceId { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>BEA5625F-8FCF-48F4-851B-CA63946DA664</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Session ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>session-i205217481741918129226</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>Session state information</para>
        /// </summary>
        [NameInMap("StateInfo")]
        [Validation(Required=false)]
        public StartRenderingSessionResponseBodyStateInfo StateInfo { get; set; }
        public class StartRenderingSessionResponseBodyStateInfo : TeaModel {
            /// <summary>
            /// <para>State description</para>
            /// 
            /// <b>Example:</b>
            /// <para>会话启动中</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>Session state</para>
            /// 
            /// <b>Example:</b>
            /// <para>SessionStarting</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>Last update time of the state</para>
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
