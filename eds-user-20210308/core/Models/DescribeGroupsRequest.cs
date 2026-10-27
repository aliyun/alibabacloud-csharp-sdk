// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class DescribeGroupsRequest : TeaModel {
        /// <summary>
        /// <remarks>
        /// <para>This parameter is not publicly available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ENTERPRISE</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        /// <summary>
        /// <para>The business channel.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ENTERPRISE</para>
        /// </summary>
        [NameInMap("BusinessChannel")]
        [Validation(Required=false)]
        public string BusinessChannel { get; set; }

        /// <summary>
        /// <para>Specifies whether to exclude user groups that are associated with logon policies.</para>
        /// </summary>
        [NameInMap("ExcludeAttachedLoginPolicyGroups")]
        [Validation(Required=false)]
        public bool? ExcludeAttachedLoginPolicyGroups { get; set; }

        /// <summary>
        /// <para>The ID of the user group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ug-16nf7xxh4o9gc****</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The name of the user group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestGroup</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>Filters user groups by the identity provider ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idp-hlyexfvwert9m8****</para>
        /// </summary>
        [NameInMap("IdpId")]
        [Validation(Required=false)]
        public string IdpId { get; set; }

        /// <summary>
        /// <para>Specifies the ID of the associated logon policy for filtering.</para>
        /// </summary>
        [NameInMap("LoginPolicyId")]
        [Validation(Required=false)]
        public string LoginPolicyId { get; set; }

        /// <summary>
        /// <para>The page number for paging in the paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page for paging in the paged query Settings. Maximum value: 100. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This parameter is not publicly available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>co-0esnf80jab***</para>
        /// </summary>
        [NameInMap("SolutionId")]
        [Validation(Required=false)]
        public string SolutionId { get; set; }

        /// <summary>
        /// <para>Specifies whether file approval is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("TransferFileNeedApproval")]
        [Validation(Required=false)]
        public bool? TransferFileNeedApproval { get; set; }

    }

}
