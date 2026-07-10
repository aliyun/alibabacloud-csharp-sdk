// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DeleteBlackListStrategyRequest : TeaModel {
        /// <summary>
        /// <para>The rule ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>38</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The product name. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>id2meta</b>: ID card two-element verification.</description></item>
        /// <item><description><b>mobile3Meta</b>: Mobile number element verification.</description></item>
        /// <item><description><b>bankcardMeta</b>: Bank card element verification.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>id2meta</para>
        /// </summary>
        [NameInMap("ProductName")]
        [Validation(Required=false)]
        public string ProductName { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
