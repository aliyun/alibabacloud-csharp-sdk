// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class DescribeDeductLogsShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the instance for which the billing is deducted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs-******</para>
        /// </summary>
        [NameInMap("BillInstanceId")]
        [Validation(Required=false)]
        public string BillInstanceId { get; set; }

        /// <summary>
        /// <para>The commodity code for deduction.</para>
        /// 
        /// <b>Example:</b>
        /// <para>snapshot</para>
        /// </summary>
        [NameInMap("BillingCommodityCode")]
        [Validation(Required=false)]
        public string BillingCommodityCode { get; set; }

        /// <summary>
        /// <para>The billing end time. The value is a UNIX timestamp in milliseconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1679068799999</para>
        /// </summary>
        [NameInMap("BillingEndTime")]
        [Validation(Required=false)]
        public long? BillingEndTime { get; set; }

        /// <summary>
        /// <para>The billing start time. The value is a UNIX timestamp in milliseconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1647446400000</para>
        /// </summary>
        [NameInMap("BillingStartTime")]
        [Validation(Required=false)]
        public long? BillingStartTime { get; set; }

        /// <summary>
        /// <para>The commodity code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ossbag</para>
        /// </summary>
        [NameInMap("CommodityCode")]
        [Validation(Required=false)]
        public string CommodityCode { get; set; }

        /// <summary>
        /// <para>The list of enterprises and accounts. If this parameter is left empty, the current account is queried.</para>
        /// </summary>
        [NameInMap("EcIdAccountIds")]
        [Validation(Required=false)]
        public string EcIdAccountIdsShrink { get; set; }

        /// <summary>
        /// <para>The resource dimension.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss_rc</para>
        /// </summary>
        [NameInMap("Group")]
        [Validation(Required=false)]
        public string Group { get; set; }

        /// <summary>
        /// <para>The instance name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OSSBAG-cn******</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The level-1 marketplace ID. If this parameter is left empty, the marketplace ID of the current user is used by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2684201000001</para>
        /// </summary>
        [NameInMap("Nbid")]
        [Validation(Required=false)]
        public string Nbid { get; set; }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The list of accounts for deduction.</para>
        /// </summary>
        [NameInMap("RelationAccountIds")]
        [Validation(Required=false)]
        public string RelationAccountIdsShrink { get; set; }

    }

}
