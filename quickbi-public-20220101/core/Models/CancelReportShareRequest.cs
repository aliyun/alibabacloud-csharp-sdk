// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class CancelReportShareRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the work. The works here include BI portal, dashboards, spreadsheets, and self-service access.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6b407e50-e774-406b-9956-da2425c2****</para>
        /// </summary>
        [NameInMap("ReportId")]
        [Validation(Required=false)]
        public string ReportId { get; set; }

        /// <summary>
        /// <para>The ID of the person to be shared, which may be the user ID of the Quick BI or the user group ID.</para>
        /// <list type="bullet">
        /// <item><description>If ShareToType is 0 (user), ShareTo is the user ID.</description></item>
        /// <item><description>When ShareToType is set to 1 (user group), ShareTo is the user group ID.</description></item>
        /// <item><description>When ShareToType=2 (organization), ShareTo is the ID of the organization.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>de4bc5f9429141cc8091cdd1c15b****</para>
        /// </summary>
        [NameInMap("ShareToIds")]
        [Validation(Required=false)]
        public string ShareToIds { get; set; }

        /// <summary>
        /// <para>The deletion method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: Delete by user</description></item>
        /// <item><description>1: Delete by user group</description></item>
        /// <item><description>2: Delete by organization</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ShareToType")]
        [Validation(Required=false)]
        public int? ShareToType { get; set; }

    }

}
