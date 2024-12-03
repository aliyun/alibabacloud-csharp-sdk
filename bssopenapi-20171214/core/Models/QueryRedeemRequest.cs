// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryRedeemRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether the redemption coupon takes effect. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EffectiveOrNot")]
        [Validation(Required=false)]
        public bool? EffectiveOrNot { get; set; }

        /// <summary>
        /// <para>The end time when the redemption coupon expires. The value must be in the yyyy-MM-ddTHH:mm:ssZ format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-08-01T00:00:00Z</para>
        /// </summary>
        [NameInMap("ExpiryTimeEnd")]
        [Validation(Required=false)]
        public string ExpiryTimeEnd { get; set; }

        /// <summary>
        /// <para>The start time when the redemption coupon expires. The value must be in the yyyy-MM-ddTHH:mm:ssZ format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-08-01T00:00:00Z</para>
        /// </summary>
        [NameInMap("ExpiryTimeStart")]
        [Validation(Required=false)]
        public string ExpiryTimeStart { get; set; }

        /// <summary>
        /// <para>The number of the page to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
