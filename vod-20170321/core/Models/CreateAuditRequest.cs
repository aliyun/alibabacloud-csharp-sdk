// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class CreateAuditRequest : TeaModel {
        /// <summary>
        /// <para>The array of review content. A maximum of <b>100</b> audio or video review items are supported at a time. You must convert the array to a string and use it as the parameter value. For the specific parameter structure, see the <b>AuditContent</b> table below.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;VideoId&quot;:&quot;93ab850b4f<em><b><b>b54b6e91d24d81d4&quot;,&quot;Status&quot;:&quot;Normal&quot;},{&quot;VideoId&quot;:&quot;f867fbfb58</b></b></em>8bbab65c4480ae1d&quot;,&quot;Status&quot;:&quot;Blocked&quot;,&quot;Reason&quot;:&quot;Pornographic video&quot;,&quot;Comment&quot;:&quot;Contains nudity&quot;}]</para>
        /// </summary>
        [NameInMap("AuditContent")]
        [Validation(Required=false)]
        public string AuditContent { get; set; }

    }

}
