// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class CheckZoneNameResponseBody : TeaModel {
        /// <summary>
        /// <para>The result of the check. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The zone name can be added.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The zone name cannot be added.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Check")]
        [Validation(Required=false)]
        public bool? Check { get; set; }

        /// <summary>
        /// <para>The unique ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CA29B88F-A571-4123-80D5-768AC2F7F806</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
