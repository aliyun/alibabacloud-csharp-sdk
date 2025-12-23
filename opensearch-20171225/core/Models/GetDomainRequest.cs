// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class GetDomainRequest : TeaModel {
        /// <summary>
        /// <para>The name or ID of the application.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_app_group_name</para>
        /// </summary>
        [NameInMap("appGroupIdentity")]
        [Validation(Required=false)]
        public string AppGroupIdentity { get; set; }

    }

}
