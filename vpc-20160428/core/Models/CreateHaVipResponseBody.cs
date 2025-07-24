// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateHaVipResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the HaVip.</para>
        /// 
        /// <b>Example:</b>
        /// <para>havip-2zeo05qre24nhrqpy****</para>
        /// </summary>
        [NameInMap("HaVipId")]
        [Validation(Required=false)]
        public string HaVipId { get; set; }

        /// <summary>
        /// <para>The IP address of the HaVip.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.XX.XX.10</para>
        /// </summary>
        [NameInMap("IpAddress")]
        [Validation(Required=false)]
        public string IpAddress { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C44F62BE-9CE7-4277-B117-69243F3988BF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
