// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class DescribeGroupUserRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ENTERPRISE</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ug-12341234****</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>co-0esnf80jab***</para>
        /// </summary>
        [NameInMap("SolutionId")]
        [Validation(Required=false)]
        public string SolutionId { get; set; }

    }

}
