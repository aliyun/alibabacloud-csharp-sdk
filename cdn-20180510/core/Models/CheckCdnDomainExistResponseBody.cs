// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class CheckCdnDomainExistResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>64D28B53-5902-409B-94F6-FD46680144FE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of the domain name. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>DomainNotExist</b>: The domain name is not added.</description></item>
        /// <item><description><b>DomainExistOtherUser</b>: The domain name has been added by another account.</description></item>
        /// <item><description><b>DomainExistCdnProduct</b>: The domain name has been added to Alibaba Cloud CDN.</description></item>
        /// <item><description><b>DomainExistDcdnProduct</b>: The domain name has been added to Dynamic Content Delivery Network (DCDN).</description></item>
        /// <item><description><b>DomainExistScdnProduct</b>: The domain name has been added to Secure CDN (SCDN).</description></item>
        /// <item><description><b>DomainExistVodProduct</b>: The domain name has been added to ApsaraVideo VOD.</description></item>
        /// <item><description><b>DomainExistLiveProduct</b>: The domain name has been added to ApsaraVideo Live.</description></item>
        /// <item><description><b>DomainExistDcdnipaProduct</b>: The domain name has been added to DCDN IP Application Accelerator (IPA).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DomainNotExist</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
