// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListApplicationSupportedProvisionProtocolTypesResponseBody : TeaModel {
        /// <summary>
        /// <para>The supported synchronization protocols for the application.</para>
        /// </summary>
        [NameInMap("ApplicationSupportedProvisionProtocolType")]
        [Validation(Required=false)]
        public ListApplicationSupportedProvisionProtocolTypesResponseBodyApplicationSupportedProvisionProtocolType ApplicationSupportedProvisionProtocolType { get; set; }
        public class ListApplicationSupportedProvisionProtocolTypesResponseBodyApplicationSupportedProvisionProtocolType : TeaModel {
            /// <summary>
            /// <para>The account synchronization protocols that the application supports. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>idaas_callback: event callback.</para>
            /// </description></item>
            /// <item><description><para>scim2: System for Cross-domain Identity Management (SCIM) protocol.</para>
            /// </description></item>
            /// </list>
            /// </summary>
            [NameInMap("ProvisionProtocolType")]
            [Validation(Required=false)]
            public List<string> ProvisionProtocolType { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
