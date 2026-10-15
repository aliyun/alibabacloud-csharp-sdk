// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class AddShareReportRequest : TeaModel {
        /// <summary>
        /// <para>The authorization type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: View only.</description></item>
        /// <item><description>3: View and export.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("AuthPoint")]
        [Validation(Required=false)]
        public int? AuthPoint { get; set; }

        /// <summary>
        /// <para>The expiration time of the sharing, in millisecond-level UNIX timestamp format.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1608202110838</para>
        /// </summary>
        [NameInMap("ExpireDate")]
        [Validation(Required=false)]
        public long? ExpireDate { get; set; }

        /// <summary>
        /// <para>The ID of the share recipient. The value can be a Quick BI user ID or a user group ID.</para>
        /// <list type="bullet">
        /// <item><description>ShareToType=0 (user): ShareTo is the user ID.</description></item>
        /// <item><description>ShareToType=1 (user group): ShareTo is the user group ID.</description></item>
        /// <item><description>ShareToType=2 (organization): ShareTo is the organization ID.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>de4bc5f9429141cc8091cdd1c15b****</para>
        /// </summary>
        [NameInMap("ShareToId")]
        [Validation(Required=false)]
        public string ShareToId { get; set; }

        /// <summary>
        /// <para>The sharing type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: user</description></item>
        /// <item><description>1: user group</description></item>
        /// <item><description>2: organization</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ShareToType")]
        [Validation(Required=false)]
        public int? ShareToType { get; set; }

        /// <summary>
        /// <para>The ID of the work to share. Works include data portals, dashboards, workbooks, and ad hoc queries.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6b407e50-e774-406b-9956-da2425c2****</para>
        /// </summary>
        [NameInMap("WorksId")]
        [Validation(Required=false)]
        public string WorksId { get; set; }

    }

}
