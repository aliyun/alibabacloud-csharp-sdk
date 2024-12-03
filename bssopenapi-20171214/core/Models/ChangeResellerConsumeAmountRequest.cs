// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class ChangeResellerConsumeAmountRequest : TeaModel {
        /// <summary>
        /// <para>The type of the consumption amount adjustment. Valid values: increase: The consumption amount increases because new consumption occurs. decrease: The consumption amount decreases because funds are added to the account. This parameter is required.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>increase/decrease</para>
        /// </summary>
        [NameInMap("AdjustType")]
        [Validation(Required=false)]
        public string AdjustType { get; set; }

        /// <summary>
        /// <para>The amount to be adjusted. Unit: CNY</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.00</para>
        /// </summary>
        [NameInMap("Amount")]
        [Validation(Required=false)]
        public string Amount { get; set; }

        /// <summary>
        /// <para>The type of the business.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>quota_amount_adjust</para>
        /// </summary>
        [NameInMap("BusinessType")]
        [Validation(Required=false)]
        public string BusinessType { get; set; }

        /// <summary>
        /// <para>The type of the currency.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CNY</para>
        /// </summary>
        [NameInMap("Currency")]
        [Validation(Required=false)]
        public string Currency { get; set; }

        /// <summary>
        /// <para>The extended field of a message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("ExtendMap")]
        [Validation(Required=false)]
        public string ExtendMap { get; set; }

        /// <summary>
        /// <para>The ID of the primary key for external business. The ID is used for idempotence verification.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1647396865</para>
        /// </summary>
        [NameInMap("OutBizId")]
        [Validation(Required=false)]
        public string OutBizId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The source of the request. Specify the system name for the parameter.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>system</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

    }

}
