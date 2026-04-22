// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class MarkOssV2ResultRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2023-10-21 16:08:38 +0800</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ACL</para>
        /// </summary>
        [NameInMap("FreezeType")]
        [Validation(Required=false)]
        public string FreezeType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>freeze</para>
        /// </summary>
        [NameInMap("Operation")]
        [Validation(Required=false)]
        public string Operation { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AAAAAA-BBBB-CCCCC-DDDD-EEEEEEEE****</para>
        /// </summary>
        [NameInMap("RequestIds")]
        [Validation(Required=false)]
        public string RequestIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2023-08-21 16:08:38 +0800</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
