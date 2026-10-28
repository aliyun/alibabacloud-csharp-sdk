// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class ListTier2CouponApprovalRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application form.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d54ca949-9b88-4514-add3-c6029c4027f4</para>
        /// </summary>
        [NameInMap("ApplicationSheetId")]
        [Validation(Required=false)]
        public string ApplicationSheetId { get; set; }

        /// <summary>
        /// <para>The approval status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: Revoked.</description></item>
        /// <item><description>2: Under review.</description></item>
        /// <item><description>3: Rejected.</description></item>
        /// <item><description>4: Approved.</description></item>
        /// <item><description>5: Approved but issuance failed.</description></item>
        /// <item><description>8: Pending.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ApprovalStatus")]
        [Validation(Required=false)]
        public string ApprovalStatus { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from 1.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The name of the secondary distributor.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test account</para>
        /// </summary>
        [NameInMap("T2PartnerName")]
        [Validation(Required=false)]
        public string T2PartnerName { get; set; }

        /// <summary>
        /// <para>The UID of the secondary distributor.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5248516956402795</para>
        /// </summary>
        [NameInMap("T2PartnerUid")]
        [Validation(Required=false)]
        public long? T2PartnerUid { get; set; }

    }

}
