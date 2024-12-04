// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ConsumerGroupUpdateCheckPointRequest : TeaModel {
        /// <summary>
        /// <para>The value of the checkpoint.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MTUyNDE1NTM3OTM3MzkwODQ5Ng==</para>
        /// </summary>
        [NameInMap("checkpoint")]
        [Validation(Required=false)]
        public string Checkpoint { get; set; }

        /// <summary>
        /// <para>The ID of the shard.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("shard")]
        [Validation(Required=false)]
        public int? Shard { get; set; }

        /// <summary>
        /// <para>The consumer.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>consumer_1</para>
        /// </summary>
        [NameInMap("consumer")]
        [Validation(Required=false)]
        public string Consumer { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable forceful updates. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("forceSuccess")]
        [Validation(Required=false)]
        public bool? ForceSuccess { get; set; }

    }

}
