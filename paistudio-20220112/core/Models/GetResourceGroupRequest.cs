// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class GetResourceGroupRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable AI workspace data. This parameter is optional. Default value: true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsAIWorkspaceDataEnabled")]
        [Validation(Required=false)]
        public bool? IsAIWorkspaceDataEnabled { get; set; }

        /// <summary>
        /// <para>The list of tags to be added. A maximum of 20 tags can be added.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<GetResourceGroupRequestTag> Tag { get; set; }
        public class GetResourceGroupRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the instance. Valid values of N: 1 to 20.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the instance. Valid values of N: 1 to 20.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
