// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EhpcInstant20230701.Models
{
    public class UpdateJobRecordDurationRequest : TeaModel {
        /// <summary>
        /// <para>The job record duration, in days. The value must be an integer from 1 to 30. Default value: 30.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("JobRecordDuration")]
        [Validation(Required=false)]
        public long? JobRecordDuration { get; set; }

    }

}
