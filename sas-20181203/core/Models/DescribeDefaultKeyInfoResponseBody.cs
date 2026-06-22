// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeDefaultKeyInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of domain names.</para>
        /// </summary>
        [NameInMap("DomainList")]
        [Validation(Required=false)]
        public List<string> DomainList { get; set; }

        /// <summary>
        /// <para>The company names.</para>
        /// 
        /// <b>Example:</b>
        /// <para>****技术股份有限公司</para>
        /// </summary>
        [NameInMap("Names")]
        [Validation(Required=false)]
        public string Names { get; set; }

        /// <summary>
        /// <para>The ID of the request. The ID is a unique identifier that Alibaba Cloud generates for the request. You can use the ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BE120DAB-F4E7-4C53-ADC3-A97578A****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
