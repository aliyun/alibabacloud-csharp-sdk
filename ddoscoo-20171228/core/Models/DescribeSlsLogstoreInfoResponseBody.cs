// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20171228.Models
{
    public class DescribeSlsLogstoreInfoResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ddoscoo-logstore</para>
        /// </summary>
        [NameInMap("LogStore")]
        [Validation(Required=false)]
        public string LogStore { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ddoscoo-project-xxxx-cn-hangzhou</para>
        /// </summary>
        [NameInMap("Project")]
        [Validation(Required=false)]
        public string Project { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5497558138880</para>
        /// </summary>
        [NameInMap("Quota")]
        [Validation(Required=false)]
        public long? Quota { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CF33B4C3-196E-4015-AADD-5CAD00057B80</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Ttl")]
        [Validation(Required=false)]
        public int? Ttl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Used")]
        [Validation(Required=false)]
        public long? Used { get; set; }

    }

}
