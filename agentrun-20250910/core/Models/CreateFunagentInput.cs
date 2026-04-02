// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class CreateFunagentInput : TeaModel {
        /// <summary>
        /// <para><c>string</c>，必填</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("adminName")]
        [Validation(Required=false)]
        public string AdminName { get; set; }

        /// <summary>
        /// <para><c>string</c>，必填</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("adminSecret")]
        [Validation(Required=false)]
        public string AdminSecret { get; set; }

        /// <summary>
        /// <para><c>float64</c>，必填</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("cpu")]
        [Validation(Required=false)]
        public float? Cpu { get; set; }

        /// <summary>
        /// <para><c>int32</c>，必填</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("dbConnections")]
        [Validation(Required=false)]
        public int? DbConnections { get; set; }

        /// <summary>
        /// <para><c>string</c>，必填</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("dbHost")]
        [Validation(Required=false)]
        public string DbHost { get; set; }

        /// <summary>
        /// <para><c>string</c>，必填</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("dbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        /// <summary>
        /// <para><c>string</c>，必填</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("dbPassword")]
        [Validation(Required=false)]
        public string DbPassword { get; set; }

        /// <summary>
        /// <para><c>int32</c>，必填</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("dbPort")]
        [Validation(Required=false)]
        public int? DbPort { get; set; }

        /// <summary>
        /// <para><c>string</c>，必填</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("dbType")]
        [Validation(Required=false)]
        public string DbType { get; set; }

        /// <summary>
        /// <para><c>string</c>，必填</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("dbUsername")]
        [Validation(Required=false)]
        public string DbUsername { get; set; }

        /// <summary>
        /// <para><c>string</c>，必填</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para><c>string</c>，必填</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("funAgentName")]
        [Validation(Required=false)]
        public string FunAgentName { get; set; }

        /// <summary>
        /// <para><c>int32</c>，必填</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("memory")]
        [Validation(Required=false)]
        public int? Memory { get; set; }

        /// <summary>
        /// <para>可选； <c>omitempty</c></para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para><c>int32</c>，必填</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("replicas")]
        [Validation(Required=false)]
        public int? Replicas { get; set; }

        /// <summary>
        /// <para><c>string</c>，必填</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("securityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para><c>string</c>，必填</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("vpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para><c>string</c>，必填；JSON 数组 [{vswitchId, zoneId}]（core 解码为 <c>*string</c> 但校验非空）</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("vswitchIds")]
        [Validation(Required=false)]
        public string VswitchIds { get; set; }

    }

}
