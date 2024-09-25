// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ConvertBandwidthPackageResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the Internet Shared Bandwidth instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bwp-s6lmotmkkf567b****</para>
        /// </summary>
        [NameInMap("ConvertInstanceId")]
        [Validation(Required=false)]
        public string ConvertInstanceId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>455AC20C-7061-446A-BDBD-B3BEE0856304</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
