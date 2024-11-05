// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeRoleZoneInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>728B9A96-E262-4AE5-915E-3A51CCE2FDA9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information of nodes in the zone.</para>
        /// </summary>
        [NameInMap("ZoneInfos")]
        [Validation(Required=false)]
        public DescribeRoleZoneInfoResponseBodyZoneInfos ZoneInfos { get; set; }
        public class DescribeRoleZoneInfoResponseBodyZoneInfos : TeaModel {
            [NameInMap("ZoneInfo")]
            [Validation(Required=false)]
            public List<DescribeRoleZoneInfoResponseBodyZoneInfosZoneInfo> ZoneInfo { get; set; }
            public class DescribeRoleZoneInfoResponseBodyZoneInfosZoneInfo : TeaModel {
                /// <summary>
                /// <para>The ID of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dds-bpxxxxxxxx</para>
                /// </summary>
                [NameInMap("InsName")]
                [Validation(Required=false)]
                public string InsName { get; set; }

                /// <summary>
                /// <para>The type of the node. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>normal</b></description></item>
                /// <item><description><b>configServer</b></description></item>
                /// <item><description><b>shard</b></description></item>
                /// <item><description><b>mongos</b></description></item>
                /// </list>
                /// <remarks>
                /// <para>Valid value for replica set instances: <b>normal</b>. Valid values for sharded cluster instances: <b>configServer</b>, <b>shard</b>, and <b>mongos</b>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>normal</para>
                /// </summary>
                [NameInMap("NodeType")]
                [Validation(Required=false)]
                public string NodeType { get; set; }

                /// <summary>
                /// <para>The role ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>83xxxxx</para>
                /// </summary>
                [NameInMap("RoleId")]
                [Validation(Required=false)]
                public string RoleId { get; set; }

                /// <summary>
                /// <para>The role of the node. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Primary</b></description></item>
                /// <item><description><b>Secondary</b></description></item>
                /// <item><description><b>Hidden</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Primary</para>
                /// </summary>
                [NameInMap("RoleType")]
                [Validation(Required=false)]
                public string RoleType { get; set; }

                /// <summary>
                /// <para>The zone ID of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-e</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

    }

}
