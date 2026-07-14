// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class AddAddressRecoverSuspendRequest : TeaModel {
        /// <summary>
        /// <para>The audit record.</para>
        /// </summary>
        [NameInMap("AuditRecord")]
        [Validation(Required=false)]
        public AddAddressRecoverSuspendRequestAuditRecord AuditRecord { get; set; }
        public class AddAddressRecoverSuspendRequestAuditRecord : TeaModel {
            /// <summary>
            /// <para>The reason for the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>示例值示例值示例值</para>
            /// </summary>
            [NameInMap("ApplyReason")]
            [Validation(Required=false)]
            public string ApplyReason { get; set; }

            /// <summary>
            /// <para>The list of destination countries for messages.</para>
            /// </summary>
            [NameInMap("MessageDestinationCountry")]
            [Validation(Required=false)]
            public List<string> MessageDestinationCountry { get; set; }

            /// <summary>
            /// <para>The list of international destination countries for messages.</para>
            /// </summary>
            [NameInMap("MessageDestinationInternationalCountry")]
            [Validation(Required=false)]
            public List<string> MessageDestinationInternationalCountry { get; set; }

            /// <summary>
            /// <para>The recovery date.</para>
            /// 
            /// <b>Example:</b>
            /// <para>示例值示例值</para>
            /// </summary>
            [NameInMap("RecoveryDate")]
            [Validation(Required=false)]
            public string RecoveryDate { get; set; }

            /// <summary>
            /// <para>The suspension date.</para>
            /// 
            /// <b>Example:</b>
            /// <para>示例值示例值</para>
            /// </summary>
            [NameInMap("SuspensionDate")]
            [Validation(Required=false)]
            public string SuspensionDate { get; set; }

        }

        /// <summary>
        /// <para>The customer space ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值示例值示例值</para>
        /// </summary>
        [NameInMap("CustSpaceId")]
        [Validation(Required=false)]
        public string CustSpaceId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The request type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值</para>
        /// </summary>
        [NameInMap("RequestType")]
        [Validation(Required=false)]
        public string RequestType { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
