// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class GetResourceGroupRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsAIWorkspaceDataEnabled")]
        [Validation(Required=false)]
        public bool? IsAIWorkspaceDataEnabled { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<GetResourceGroupRequestTag> Tag { get; set; }
        public class GetResourceGroupRequestTag : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
