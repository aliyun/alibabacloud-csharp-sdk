// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Market20151101.Models
{
    public class ResumeProjectRequest : TeaModel {
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
        /// <para>The ID of the operation flow node.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1922</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public long? NodeId { get; set; }

        /// <summary>
        /// <para>The reason for the remark.</para>
        /// 
        /// <b>Example:</b>
        /// <para>仓库库存已补充，可安排发货。</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

    }

}
