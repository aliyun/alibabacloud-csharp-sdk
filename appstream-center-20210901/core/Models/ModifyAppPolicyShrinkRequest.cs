// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ModifyAppPolicyShrinkRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pg-ee2znjktwgxu2****</para>
        /// </summary>
        [NameInMap("AppPolicyId")]
        [Validation(Required=false)]
        public string AppPolicyId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CloudApp</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        [NameInMap("VideoPolicy")]
        [Validation(Required=false)]
        public string VideoPolicyShrink { get; set; }

    }

}
