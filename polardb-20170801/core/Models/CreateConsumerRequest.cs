// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreateConsumerRequest : TeaModel {
        /// <summary>
        /// <para>The consumer group name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cg-p3gk2oh55c**</para>
        /// </summary>
        [NameInMap("ConsumerGroupName")]
        [Validation(Required=false)]
        public string ConsumerGroupName { get; set; }

        /// <summary>
        /// <para>The gateway instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pg-xxxxxxxxxx</para>
        /// </summary>
        [NameInMap("GwClusterId")]
        [Validation(Required=false)]
        public string GwClusterId { get; set; }

        /// <summary>
        /// <para>The key type. The only supported value is ApiKey.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ApiKey</para>
        /// </summary>
        [NameInMap("KeyType")]
        [Validation(Required=false)]
        public string KeyType { get; set; }

        /// <summary>
        /// <para>The user name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The user nickname.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
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
