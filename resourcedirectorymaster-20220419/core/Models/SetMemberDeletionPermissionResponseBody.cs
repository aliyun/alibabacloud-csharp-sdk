// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class SetMemberDeletionPermissionResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the management account of the resource directory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>151266687691****</para>
        /// </summary>
        [NameInMap("ManagementAccountId")]
        [Validation(Required=false)]
        public string ManagementAccountId { get; set; }

        /// <summary>
        /// <para>The status of the member deletion feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Enabled: The feature is enabled.</description></item>
        /// <item><description>Disabled: The feature is disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("MemberDeletionStatus")]
        [Validation(Required=false)]
        public string MemberDeletionStatus { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C55A4CAA-9039-1DDF-91CE-FCC134513D29</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the resource directory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rd-3G****</para>
        /// </summary>
        [NameInMap("ResourceDirectoryId")]
        [Validation(Required=false)]
        public string ResourceDirectoryId { get; set; }

    }

}
