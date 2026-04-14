// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class AddIpfilterResponseBody : TeaModel {
        /// <summary>
        /// <para>ID corresponding to the IP</para>
        /// 
        /// <b>Example:</b>
        /// <para>10795</para>
        /// </summary>
        [NameInMap("IpFilterId")]
        [Validation(Required=false)]
        public string IpFilterId { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>0E9282E8-DC08-5445-8FB0-B9F0CA28B249</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
