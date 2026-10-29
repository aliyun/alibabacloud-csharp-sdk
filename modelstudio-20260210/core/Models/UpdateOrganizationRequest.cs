// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ModelStudio20260210.Models
{
    public class UpdateOrganizationRequest : TeaModel {
        /// <summary>
        /// <para>The description of the organization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>New organization description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the organization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>New organization name</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
