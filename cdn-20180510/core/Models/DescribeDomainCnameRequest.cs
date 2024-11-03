// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeDomainCnameRequest : TeaModel {
        /// <summary>
        /// <para>The accelerated domain name that you want to query. Separate multiple domain names with commas (,). This parameter cannot be left empty.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pay.slci6c.mbolsos.com,mch.b7r2v7.mbolsos.com,p.h99e.mbolsos.com,p.xmko.mbolsos.com,p.f2kd.mbolsos.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

    }

}
