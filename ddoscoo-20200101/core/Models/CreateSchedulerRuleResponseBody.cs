// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class CreateSchedulerRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The CNAME assigned by Sec-Traffic Manager for the rule.</para>
        /// <remarks>
        /// <para>You must map your service domain name to the CNAME of Sec-Traffic Manager to enable the rule.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>48k7b372gpl4****.aliyunddos0001.com</para>
        /// </summary>
        [NameInMap("Cname")]
        [Validation(Required=false)]
        public string Cname { get; set; }

        /// <summary>
        /// <para>The ID of the request. The value is a unique identifier that Alibaba Cloud generates for the request. You can use this ID to troubleshoot issues.</para>
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
