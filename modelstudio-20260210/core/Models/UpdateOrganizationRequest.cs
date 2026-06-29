// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ModelStudio20260210.Models
{
    public class UpdateOrganizationRequest : TeaModel {
        /// <summary>
        /// <para>The organization description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>新的组织描述</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The organization name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>新的组织名称</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
