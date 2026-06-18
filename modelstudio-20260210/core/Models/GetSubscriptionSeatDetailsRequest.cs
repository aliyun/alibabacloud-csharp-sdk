// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ModelStudio20260210.Models
{
    public class GetSubscriptionSeatDetailsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the caller account that initiates this call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acc_123456789</para>
        /// </summary>
        [NameInMap("CallerUacAccountId")]
        [Validation(Required=false)]
        public string CallerUacAccountId { get; set; }

        /// <summary>
        /// <para>The product namespace ID. For the TokenPlan product, this field is fixed to namespace-1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>namespace-1</para>
        /// </summary>
        [NameInMap("NamespaceId")]
        [Validation(Required=false)]
        public string NamespaceId { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1. Valid values: positive integers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The seat assignment status filter. Set to true for assigned seats, false for unassigned seats, or null for all seats.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("QueryAssigned")]
        [Validation(Required=false)]
        public bool? QueryAssigned { get; set; }

        /// <summary>
        /// <para>The seat ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>seat-123456</para>
        /// </summary>
        [NameInMap("SeatId")]
        [Validation(Required=false)]
        public string SeatId { get; set; }

        /// <summary>
        /// <para>The seat type (specType). Valid values:</para>
        /// <list type="bullet">
        /// <item><description>standard</description></item>
        /// <item><description>pro</description></item>
        /// <item><description>max.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>standard</para>
        /// </summary>
        [NameInMap("SeatType")]
        [Validation(Required=false)]
        public string SeatType { get; set; }

        /// <summary>
        /// <para>The list of seat statuses used for filtering.</para>
        /// </summary>
        [NameInMap("StatusList")]
        [Validation(Required=false)]
        public List<string> StatusList { get; set; }

        /// <summary>
        /// <para>The string form of StatusList.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[\&quot;CREATING\&quot;,\&quot;NORMAL\&quot;]</para>
        /// </summary>
        [NameInMap("StatusListStr")]
        [Validation(Required=false)]
        public string StatusListStr { get; set; }

    }

}
