// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class CreateOrgRequest : TeaModel {
        /// <summary>
        /// <para>The name of the organization.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("OrgName")]
        [Validation(Required=false)]
        public string OrgName { get; set; }

        /// <summary>
        /// <para>The ID of the parent organization.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>org-evk12ozjvmlxl****</para>
        /// </summary>
        [NameInMap("ParentOrgId")]
        [Validation(Required=false)]
        public string ParentOrgId { get; set; }

    }

}
