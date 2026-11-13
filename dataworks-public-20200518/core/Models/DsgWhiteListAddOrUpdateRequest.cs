// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DsgWhiteListAddOrUpdateRequest : TeaModel {
        /// <summary>
        /// <para>The whitelist collection.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("WhiteLists")]
        [Validation(Required=false)]
        public List<DsgWhiteListAddOrUpdateRequestWhiteLists> WhiteLists { get; set; }
        public class DsgWhiteListAddOrUpdateRequestWhiteLists : TeaModel {
            /// <summary>
            /// <para>The expiration time of the data masking whitelist. The format is <c>yyyy-MM-dd HH:mm:ss</c>. Specify null to make the whitelist permanently effective.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The ID of the data masking whitelist.</para>
            /// <list type="bullet">
            /// <item><description>If you do not specify this parameter, a data masking whitelist is created.</description></item>
            /// <item><description>If you specify this parameter, the specified data masking whitelist is modified. You can call the <a href="https://help.aliyun.com/document_detail/2786508.html">DsgWhiteListQueryList</a> operation to query the whitelist ID.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public int? Id { get; set; }

            /// <summary>
            /// <para>The ID of the data masking rule. Initialize the data classification template in the Data Security Guard console, call the DsgDesensPlanAddOrUpdate operation to create a data masking rule, and then call the DsgDesensPlanQueryList operation to obtain the RuleId.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public int? RuleId { get; set; }

            /// <summary>
            /// <para>The effective start time of the data masking whitelist.</para>
            /// <para>The format is <c>yyyy-MM-dd HH:mm:ss</c>, such as <c>2024-04-10 00:00:00</c>.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-04-10 00:00:00</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The collection of user group IDs.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("UserGroupIds")]
            [Validation(Required=false)]
            public List<int?> UserGroupIds { get; set; }

        }

    }

}
