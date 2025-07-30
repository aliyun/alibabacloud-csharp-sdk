// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class CreateGroupRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ENTERPRISE</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>root</para>
        /// </summary>
        [NameInMap("ParentGroupId")]
        [Validation(Required=false)]
        public string ParentGroupId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>co-0esnf80jab***</para>
        /// </summary>
        [NameInMap("SolutionId")]
        [Validation(Required=false)]
        public string SolutionId { get; set; }

    }

}
