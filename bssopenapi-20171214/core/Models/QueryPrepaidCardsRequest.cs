// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryPrepaidCardsRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether the card package is effective. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Effective.</description></item>
        /// <item><description>false: Ineffective.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EffectiveOrNot")]
        [Validation(Required=false)]
        public bool? EffectiveOrNot { get; set; }

        /// <summary>
        /// <para>The end time of card package expiration. Format: yyyy-MM-dd HH:mm:ss.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-08-01 00:00:00</para>
        /// </summary>
        [NameInMap("ExpiryTimeEnd")]
        [Validation(Required=false)]
        public string ExpiryTimeEnd { get; set; }

        /// <summary>
        /// <para>The start time of card package expiration. Format: yyyy-MM-dd.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-08-01 00:00:00</para>
        /// </summary>
        [NameInMap("ExpiryTimeStart")]
        [Validation(Required=false)]
        public string ExpiryTimeStart { get; set; }

    }

}
