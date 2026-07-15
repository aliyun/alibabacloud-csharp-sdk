// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeRoleTagStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>69D55DEC-B219-569F-A686-AC2F67A1****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The tag status of the ReplicaSet node. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The tag is created.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The tag is not created.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If the instance is a sharded cluster, this parameter returns false.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("RoleTagStatus")]
        [Validation(Required=false)]
        public string RoleTagStatus { get; set; }

        /// <summary>
        /// <para>The tag status of each node in the sharded cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The tag is created.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The tag is not created.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;d-2ze204b4db58****&quot;: &quot;false&quot;,
        ///     &quot;d-2zeb9716646e***&quot;: &quot;false&quot;
        /// }</para>
        /// </summary>
        [NameInMap("ShardRoleTagStatus")]
        [Validation(Required=false)]
        public Dictionary<string, object> ShardRoleTagStatus { get; set; }

    }

}
