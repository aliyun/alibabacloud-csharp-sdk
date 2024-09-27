// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class ReplaceCloudGtmAddressPoolAddressResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the address pool. This ID uniquely identifies the address pool.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pool-89618921167339**24</para>
        /// </summary>
        [NameInMap("AddressPoolId")]
        [Validation(Required=false)]
        public string AddressPoolId { get; set; }

        /// <summary>
        /// <para>Unique request identification code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B57C121B-A45F-44D8-A9B2-13E5A5044195</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation was successful:</para>
        /// <list type="bullet">
        /// <item><description>true: Successful. - false: Failed.</description></item>
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
