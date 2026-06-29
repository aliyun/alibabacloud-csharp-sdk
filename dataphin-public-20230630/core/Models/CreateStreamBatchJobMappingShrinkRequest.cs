// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class CreateStreamBatchJobMappingShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <para>The stream-batch integrated node information.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("StreamBatchJobMappingCreateCommand")]
        [Validation(Required=false)]
        public string StreamBatchJobMappingCreateCommandShrink { get; set; }

    }

}
