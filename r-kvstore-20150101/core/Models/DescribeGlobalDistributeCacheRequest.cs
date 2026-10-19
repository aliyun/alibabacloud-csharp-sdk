// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeGlobalDistributeCacheRequest : TeaModel {
        /// <summary>
        /// <para>The distributed instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gr-bp14rkqrhac****</para>
        /// </summary>
        [NameInMap("GlobalInstanceId")]
        [Validation(Required=false)]
        public string GlobalInstanceId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number. Set the value to a number that is greater than <b>0</b> and does not exceed the maximum value of the Integer data type. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The child instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gr-bp1zcjlobkyrq****</para>
        /// </summary>
        [NameInMap("SubInstanceId")]
        [Validation(Required=false)]
        public string SubInstanceId { get; set; }

    }

}
