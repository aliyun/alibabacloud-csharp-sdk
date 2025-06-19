// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class StartRenderingSessionResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-xxx.ecr.aliyuncs.com</para>
        /// </summary>
        [NameInMap("Hostname")]
        [Validation(Required=false)]
        public string Hostname { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsRepeatedRequest")]
        [Validation(Required=false)]
        public bool? IsRepeatedRequest { get; set; }

        [NameInMap("Location")]
        [Validation(Required=false)]
        public StartRenderingSessionResponseBodyLocation Location { get; set; }
        public class StartRenderingSessionResponseBodyLocation : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>610000</para>
            /// </summary>
            [NameInMap("ProvinceCode")]
            [Validation(Required=false)]
            public string ProvinceCode { get; set; }

        }

        [NameInMap("PortMappings")]
        [Validation(Required=false)]
        public List<StartRenderingSessionResponseBodyPortMappings> PortMappings { get; set; }
        public class StartRenderingSessionResponseBodyPortMappings : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>10013/10020</para>
            /// </summary>
            [NameInMap("ExternalPort")]
            [Validation(Required=false)]
            public string ExternalPort { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>49008/49015</para>
            /// </summary>
            [NameInMap("InternalPort")]
            [Validation(Required=false)]
            public string InternalPort { get; set; }

        }

        [NameInMap("RenderingInstanceId")]
        [Validation(Required=false)]
        public string RenderingInstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>BEA5625F-8FCF-48F4-851B-CA63946DA664</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>session-i205217481741918129226</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        [NameInMap("StateInfo")]
        [Validation(Required=false)]
        public StartRenderingSessionResponseBodyStateInfo StateInfo { get; set; }
        public class StartRenderingSessionResponseBodyStateInfo : TeaModel {
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SessionStarting</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-05-06T06:37Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

    }

}
