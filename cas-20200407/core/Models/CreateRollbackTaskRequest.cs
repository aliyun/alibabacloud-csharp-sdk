// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class CreateRollbackTaskRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the deployment task.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>436493</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public long? JobId { get; set; }

        /// <summary>
        /// <para>The ID of the deployment worker.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4197913</para>
        /// </summary>
        [NameInMap("WorkerId")]
        [Validation(Required=false)]
        public long? WorkerId { get; set; }

    }

}
