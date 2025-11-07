// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DeleteBlackListStrategyRequest : TeaModel {
        /// <summary>
        /// <para>Rule ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>38</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>Product Name:</para>
        /// <list type="bullet">
        /// <item><description><b>id2meta</b>: ID card two-factor verification</description></item>
        /// <item><description><b>mobile3Meta</b>: Mobile phone number factor verification</description></item>
        /// <item><description><b>bankcardMeta</b>: Bank card factor verification</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>id2meta</para>
        /// </summary>
        [NameInMap("ProductName")]
        [Validation(Required=false)]
        public string ProductName { get; set; }

        /// <summary>
        /// <para>Region ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
