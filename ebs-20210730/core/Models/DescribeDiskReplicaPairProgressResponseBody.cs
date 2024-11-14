// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class DescribeDiskReplicaPairProgressResponseBody : TeaModel {
        /// <summary>
        /// <para>The replication progress of the replication pair.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Progress")]
        [Validation(Required=false)]
        public int? Progress { get; set; }

        /// <summary>
        /// <para>The timestamp that indicates the last recovery point in time. The value is returned only after the replication pair works for replicating data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1661917424</para>
        /// </summary>
        [NameInMap("RecoverPoint")]
        [Validation(Required=false)]
        public long? RecoverPoint { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAA478A0-BEE6-1D42-BEB6-A9CFEAD6****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
