// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeRoleTagStatusResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>69D55DEC-B219-569F-A686-AC2F67A1****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("RoleTagStatus")]
        [Validation(Required=false)]
        public string RoleTagStatus { get; set; }

        /// <summary>
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
