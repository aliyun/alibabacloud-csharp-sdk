// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class AddSnatEntryResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the SNAT instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>snat-m2obgkt5ya1puz****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>56BF6C79-C77D-41A0-86DD-A4B156E784EA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
