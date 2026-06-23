// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp_open20191212.Models
{
    public class ListInstanceWhiteListRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the instance whose whitelist to query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rabbitmq-cn-xxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The type of whitelist to query.</para>
        /// <para>VPC whitelists apply only to instances whose VPC endpoint is of the <c>anytunnel</c> type. The latest instance versions use a <c>PrivateLink</c> VPC endpoint and do not support VPC whitelists.</para>
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
