// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListESAIPInfoRequest : TeaModel {
        /// <summary>
        /// <para>You can enter IPv4 or IPv6 addresses. Separate multiple IP addresses with commas (,). You can enter up to 20 IP addresses at a time.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.0.0.24,2408:8740:41FF:2:23::7FE,0.0.0.0,abcd</para>
        /// </summary>
        [NameInMap("VipInfo")]
        [Validation(Required=false)]
        public string VipInfo { get; set; }

    }

}
