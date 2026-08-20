// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Market20151101.Models
{
    public class RollbackCurrentProjectNodeRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID of the Alibaba Cloud Marketplace order.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4****89</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the current process node.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1925</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public long? NodeId { get; set; }

        /// <summary>
        /// <para>The remarks for the rejection reason.</para>
        /// 
        /// <b>Example:</b>
        /// <para>尊敬的顾客您好，您提交的收货地址存在多个匹配结果，请您核对后再重新提交。</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

    }

}
