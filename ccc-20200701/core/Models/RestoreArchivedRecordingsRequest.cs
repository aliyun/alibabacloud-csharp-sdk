// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class RestoreArchivedRecordingsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>[\&quot;job-216750038017142784\&quot;]</para>
        /// </summary>
        [NameInMap("ContactIds")]
        [Validation(Required=false)]
        public string ContactIds { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc-test</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
