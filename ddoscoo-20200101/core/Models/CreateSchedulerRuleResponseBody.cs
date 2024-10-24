// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class CreateSchedulerRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The CNAME that is assigned by Sec-Traffic Manager for the scheduling rule.</para>
        /// <remarks>
        /// <para>To enable the scheduling rule, you must map the domain name of the service to the CNAME.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>48k7b372gpl4****.aliyunddos0001.com</para>
        /// </summary>
        [NameInMap("Cname")]
        [Validation(Required=false)]
        public string Cname { get; set; }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8DFB602D-1AAC-46C4-90F2-C84086E7A6E4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The name of the rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testrule</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

    }

}
