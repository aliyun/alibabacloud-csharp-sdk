// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeRenderingSessionResponseBody : TeaModel {
        [NameInMap("AdditionalIngresses")]
        [Validation(Required=false)]
        public List<DescribeRenderingSessionResponseBodyAdditionalIngresses> AdditionalIngresses { get; set; }
        public class DescribeRenderingSessionResponseBodyAdditionalIngresses : TeaModel {
            [NameInMap("Hostname")]
            [Validation(Required=false)]
            public string Hostname { get; set; }

            [NameInMap("Isp")]
            [Validation(Required=false)]
            public string Isp { get; set; }

            [NameInMap("PortMappings")]
            [Validation(Required=false)]
            public List<DescribeRenderingSessionResponseBodyAdditionalIngressesPortMappings> PortMappings { get; set; }
            public class DescribeRenderingSessionResponseBodyAdditionalIngressesPortMappings : TeaModel {
                [NameInMap("ExternalPort")]
                [Validation(Required=false)]
                public string ExternalPort { get; set; }

                [NameInMap("InternalPort")]
                [Validation(Required=false)]
                public string InternalPort { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cap-b06b26edfhytbn b94a75ae1a79efc90eb</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>c91263a0-f9ac-45bd-bbe9-6e293ad32d91</para>
        /// </summary>
        [NameInMap("ClientId")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>111.45.29.96</para>
        /// </summary>
        [NameInMap("Hostname")]
        [Validation(Required=false)]
        public string Hostname { get; set; }

        [NameInMap("Isp")]
        [Validation(Required=false)]
        public string Isp { get; set; }

        [NameInMap("Location")]
        [Validation(Required=false)]
        public DescribeRenderingSessionResponseBodyLocation Location { get; set; }
        public class DescribeRenderingSessionResponseBodyLocation : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>310000</para>
            /// </summary>
            [NameInMap("ProvinceCode")]
            [Validation(Required=false)]
            public string ProvinceCode { get; set; }

        }

        [NameInMap("PortMappings")]
        [Validation(Required=false)]
        public List<DescribeRenderingSessionResponseBodyPortMappings> PortMappings { get; set; }
        public class DescribeRenderingSessionResponseBodyPortMappings : TeaModel {
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

        /// <summary>
        /// <b>Example:</b>
        /// <para>2025-05-18T02:20:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("StateInfo")]
        [Validation(Required=false)]
        public DescribeRenderingSessionResponseBodyStateInfo StateInfo { get; set; }
        public class DescribeRenderingSessionResponseBodyStateInfo : TeaModel {
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SessionStarted</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-10-15T10:05:20+08:00</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

    }

}
