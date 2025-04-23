// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class DescribeOrgByLayerRequest : TeaModel {
        [NameInMap("OrgName")]
        [Validation(Required=false)]
        public string OrgName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>org-11fs****</para>
        /// </summary>
        [NameInMap("ParentOrgId")]
        [Validation(Required=false)]
        public string ParentOrgId { get; set; }

    }

}
