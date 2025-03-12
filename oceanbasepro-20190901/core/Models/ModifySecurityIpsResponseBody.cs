// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class ModifySecurityIpsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EE205C00-30E4-XXXX-XXXX-87E3A8A2AA0C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Example 1</para>
        /// </summary>
        [NameInMap("SecurityIpGroup")]
        [Validation(Required=false)]
        public ModifySecurityIpsResponseBodySecurityIpGroup SecurityIpGroup { get; set; }
        public class ModifySecurityIpsResponseBodySecurityIpGroup : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>ob317v4uif****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>online_paycore</para>
            /// </summary>
            [NameInMap("SecurityIpGroupName")]
            [Validation(Required=false)]
            public string SecurityIpGroupName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>121.41.106.33,100.104.7.0/26</para>
            /// </summary>
            [NameInMap("SecurityIps")]
            [Validation(Required=false)]
            public string SecurityIps { get; set; }

        }

    }

}
