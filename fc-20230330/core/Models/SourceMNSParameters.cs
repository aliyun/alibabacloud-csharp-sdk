// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class SourceMNSParameters : TeaModel {
        /// <summary>
        /// <para>Specify whether to enable Base64 encoding. Default value: true. Valid values: true false</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsBase64Decode")]
        [Validation(Required=false)]
        public bool? IsBase64Decode { get; set; }

        /// <summary>
        /// <para>The name of the queue of Simple Message Queue (formerly MNS).</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo</para>
        /// </summary>
        [NameInMap("QueueName")]
        [Validation(Required=false)]
        public string QueueName { get; set; }

        /// <summary>
        /// <para>The region to which the queue of Simple Message Queue (formerly MNS) belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
