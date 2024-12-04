// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ConsumerGroupHeartBeatRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of shards whose data is being consumed.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public List<int?> Body { get; set; }

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

    }

}
