// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class CreateCloudGtmAddressResponseBody : TeaModel {
        /// <summary>
        /// <para>The address ID. This ID uniquely identifies the address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>addr-8951821811436**192</para>
        /// </summary>
        [NameInMap("AddressId")]
        [Validation(Required=false)]
        public string AddressId { get; set; }

        /// <summary>
        /// <para>Unique request identification code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>46973D4C-E3E4-4ABA-9190-9A9DE406C7E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the address creation operation is successful:</para>
        /// <list type="bullet">
        /// <item><description>true: Operation was successful</description></item>
        /// <item><description>false: Operation was failed</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
