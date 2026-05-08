// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeGatewayAttributeResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>polar.app.g2.medium</para>
        /// </summary>
        [NameInMap("ClassCode")]
        [Validation(Required=false)]
        public string ClassCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2020-02-24T11:57:54Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("CurrentVersion")]
        [Validation(Required=false)]
        public string CurrentVersion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("DbType")]
        [Validation(Required=false)]
        public string DbType { get; set; }

        [NameInMap("Endpoints")]
        [Validation(Required=false)]
        public List<DescribeGatewayAttributeResponseBodyEndpoints> Endpoints { get; set; }
        public class DescribeGatewayAttributeResponseBodyEndpoints : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>pg-xxxxx.polardbaigateway.pre.rds.aliyuncs.com</para>
            /// </summary>
            [NameInMap("Address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("EndpointId")]
            [Validation(Required=false)]
            public string EndpointId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pg-xxxxxxx</para>
            /// </summary>
            [NameInMap("GwClusterId")]
            [Validation(Required=false)]
            public string GwClusterId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Public</para>
            /// </summary>
            [NameInMap("NetType")]
            [Validation(Required=false)]
            public string NetType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>8080</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1874631</para>
            /// </summary>
            [NameInMap("TunnelId")]
            [Validation(Required=false)]
            public string TunnelId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vpc-*************</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        [NameInMap("Expired")]
        [Validation(Required=false)]
        public bool? Expired { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>pg-xxxxxxx</para>
        /// </summary>
        [NameInMap("GwClusterId")]
        [Validation(Required=false)]
        public string GwClusterId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("GwDescription")]
        [Validation(Required=false)]
        public string GwDescription { get; set; }

        [NameInMap("LatestVersion")]
        [Validation(Required=false)]
        public string LatestVersion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2025-10-07T02:19:55Z</para>
        /// </summary>
        [NameInMap("ModifyTime")]
        [Validation(Required=false)]
        public string ModifyTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Postpaid</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>3E5CD764-FCCA-5C9C-838E-20E0DE84B2AF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RunningVersion")]
        [Validation(Required=false)]
        public string RunningVersion { get; set; }

        [NameInMap("SecurityIPArrays")]
        [Validation(Required=false)]
        public List<DescribeGatewayAttributeResponseBodySecurityIPArrays> SecurityIPArrays { get; set; }
        public class DescribeGatewayAttributeResponseBodySecurityIPArrays : TeaModel {
            [NameInMap("SecurityIPArrayName")]
            [Validation(Required=false)]
            public string SecurityIPArrayName { get; set; }

            [NameInMap("SecurityIPArrayTag")]
            [Validation(Required=false)]
            public string SecurityIPArrayTag { get; set; }

            [NameInMap("SecurityIPList")]
            [Validation(Required=false)]
            public string SecurityIPList { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ACTIVATION</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>vsw-*********************</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>vpc-*************</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
