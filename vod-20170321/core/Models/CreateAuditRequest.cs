// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class CreateAuditRequest : TeaModel {
        /// <summary>
        /// <para>The review content. You can specify up to <b>100</b> audio or video files in a request. The value must be converted to a string.\
        /// For more information about this parameter, see the <b>AuditContent</b> section of this topic.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;VideoId&quot;:&quot;93ab850b4f<em><b><b>b54b6e91d24d81d4&quot;,&quot;Status&quot;:&quot;Normal&quot;},{&quot;VideoId&quot;:&quot;f867fbfb58</b></b></em>8bbab65c4480ae1d&quot;,&quot;Status&quot;:&quot;Blocked&quot;,&quot;Reason&quot;:&quot;porn video&quot;,&quot;Comment&quot;:&quot;porn video&quot;}]</para>
        /// </summary>
        [NameInMap("AuditContent")]
        [Validation(Required=false)]
        public string AuditContent { get; set; }

    }

}
