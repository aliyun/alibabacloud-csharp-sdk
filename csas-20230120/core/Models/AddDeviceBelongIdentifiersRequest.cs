// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class AddDeviceBelongIdentifiersRequest : TeaModel {
        /// <summary>
        /// <para>The list of device ownership identifiers to add. Each batch supports 1 to 1,000 items. Each item must include IdentifierType and IdentifierValue.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Identifiers")]
        [Validation(Required=false)]
        public List<AddDeviceBelongIdentifiersRequestIdentifiers> Identifiers { get; set; }
        public class AddDeviceBelongIdentifiersRequestIdentifiers : TeaModel {
            /// <summary>
            /// <para>The identifier type. MAC indicates a network interface controller (NIC) MAC address, SystemSN indicates a system serial number, and BIOSSN indicates a BIOS serial number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MAC</para>
            /// </summary>
            [NameInMap("IdentifierType")]
            [Validation(Required=false)]
            public string IdentifierType { get; set; }

            /// <summary>
            /// <para>The identifier value. A MAC address must be a 6-byte address. A system serial number accepts 1 to 64 characters, and a BIOS serial number accepts 1 to 128 characters. MAC addresses are converted to the lowercase colon-separated format when stored, while system serial numbers and BIOS serial numbers retain their original values.</para>
            /// 
            /// <b>Example:</b>
            /// <para>02:00:00:00:00:01</para>
            /// </summary>
            [NameInMap("IdentifierValue")]
            [Validation(Required=false)]
            public string IdentifierValue { get; set; }

        }

    }

}
