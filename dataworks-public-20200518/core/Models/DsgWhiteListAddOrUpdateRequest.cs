// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DsgWhiteListAddOrUpdateRequest : TeaModel {
        /// <summary>
        /// <para>A collection of whitelists.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("WhiteLists")]
        [Validation(Required=false)]
        public List<DsgWhiteListAddOrUpdateRequestWhiteLists> WhiteLists { get; set; }
        public class DsgWhiteListAddOrUpdateRequestWhiteLists : TeaModel {
            /// <summary>
            /// <para>The end of the time range to query. If you enter null, the whitelist is valid permanently.</para>
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
            /// <item><description>If you do not configure this parameter, the current operation is to add a data masking whitelist.</description></item>
            /// <item><description>If you configure this parameter, the current operation is to modify a data masking whitelist. You can call the <a href="https://help.aliyun.com/document_detail/2786508.html">DsgWhiteListQueryList</a> operation to query the whitelist ID.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public int? Id { get; set; }

            /// <summary>
            /// <para>The ID of the data masking rule. You can call the <a href="https://help.aliyun.com/document_detail/2786578.html">DsgDesensPlanQueryList</a> operation to query the ID of the data masking rule.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public int? RuleId { get; set; }

            /// <summary>
            /// <para>The beginning of the time range to query.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-04-10 00:00:00</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>A collection of user group IDs.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("UserGroupIds")]
            [Validation(Required=false)]
            public List<int?> UserGroupIds { get; set; }

        }

    }

}
