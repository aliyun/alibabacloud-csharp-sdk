// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyConsumerGroupRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the consumer group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cg-xxxxxx</para>
        /// </summary>
        [NameInMap("ConsumerGroupName")]
        [Validation(Required=false)]
        public string ConsumerGroupName { get; set; }

        /// <summary>
        /// <para>The ID of the gateway instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pg-xxxxxxxx</para>
        /// </summary>
        [NameInMap("GwClusterId")]
        [Validation(Required=false)]
        public string GwClusterId { get; set; }

        /// <summary>
        /// <para>Indicates whether the consumer group is the default group. Valid values: <c>0</c> (false) and <c>1</c> (true).</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("IsDefault")]
        [Validation(Required=false)]
        public string IsDefault { get; set; }

        /// <summary>
        /// <para>The nickname of the consumer group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yonghu</para>
        /// </summary>
        [NameInMap("NickName")]
        [Validation(Required=false)]
        public string NickName { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
