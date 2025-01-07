// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class RemoveCheckResultWhiteListRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Deprecated</para>
        /// </summary>
        [NameInMap("CheckGroupId")]
        [Validation(Required=false)]
        public string CheckGroupId { get; set; }

        /// <summary>
        /// <para>The IDs of the check items.</para>
        /// </summary>
        [NameInMap("CheckIds")]
        [Validation(Required=false)]
        public List<long?> CheckIds { get; set; }

        /// <summary>
        /// <para>The ID of the whitelist rule.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~ListCheckResult~~">ListCheckResult</a> operation to query the IDs of whitelist rules.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>22</para>
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public long? RuleId { get; set; }

        /// <summary>
        /// <para>This parameter is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Deprecated</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
