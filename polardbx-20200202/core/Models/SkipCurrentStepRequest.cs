// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class SkipCurrentStepRequest : TeaModel {
        /// <summary>
        /// <para>The current operation step of the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PRE_CHECK</para>
        /// </summary>
        [NameInMap("CurrentStep")]
        [Validation(Required=false)]
        public string CurrentStep { get; set; }

        /// <summary>
        /// <para>The region where the instance is located.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The import task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>etx-szr2rr6i*****</para>
        /// </summary>
        [NameInMap("SlinkTaskId")]
        [Validation(Required=false)]
        public string SlinkTaskId { get; set; }

    }

}
