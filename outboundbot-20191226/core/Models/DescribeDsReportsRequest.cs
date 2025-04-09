// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class DescribeDsReportsRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a4274627-265f-4e14-b2d6-4ee7d4f8593e</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9eb8fe4f-b286-4834-9688-2c9b171e223e</para>
        /// </summary>
        [NameInMap("JobGroupId")]
        [Validation(Required=false)]
        public string JobGroupId { get; set; }

    }

}
