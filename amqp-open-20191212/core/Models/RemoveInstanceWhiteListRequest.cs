// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp_open20191212.Models
{
    public class RemoveInstanceWhiteListRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the instance from which to remove a whitelist entry.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amqp-cn-5yd3aw******</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Call the ListInstanceWhiteList operation to obtain this ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>420</para>
        /// </summary>
        [NameInMap("whiteListItemId")]
        [Validation(Required=false)]
        public long? WhiteListItemId { get; set; }

        /// <summary>
        /// <para>The type of the whitelist item. Specify 2 for an IP address or 1 for a VPC ID.</para>
        /// <para>A VPC whitelist only applies to instances with the anytunnel VPC endpoint type. Newer instances use PrivateLink for their VPC endpoints and do not support VPC whitelists.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("whiteListType")]
        [Validation(Required=false)]
        public int? WhiteListType { get; set; }

    }

}
