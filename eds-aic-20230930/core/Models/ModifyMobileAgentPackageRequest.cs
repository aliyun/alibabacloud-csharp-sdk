// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class ModifyMobileAgentPackageRequest : TeaModel {
        /// <summary>
        /// <para>The package ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cmag-xxxx</para>
        /// </summary>
        [NameInMap("PackageId")]
        [Validation(Required=false)]
        public string PackageId { get; set; }

        /// <summary>
        /// <para>The list of tags. You can specify 1 to 20 tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ModifyMobileAgentPackageRequestTag> Tag { get; set; }
        public class ModifyMobileAgentPackageRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. If you specify this parameter, it cannot be an empty string. The tag key can be up to 128 characters in length and cannot start with aliyun or acs:. It cannot contain http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>keyname</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. It can be an empty string. The tag value can be up to 128 characters in length and cannot start with acs:. It cannot contain http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>value</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
