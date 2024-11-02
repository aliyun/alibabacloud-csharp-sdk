// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribeFieldResponseBody : TeaModel {
        /// <summary>
        /// <para>The configuration content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;ip&quot;,&quot;name&quot;,&quot;hostinfo&quot;,&quot;md5&quot;]</para>
        /// </summary>
        [NameInMap("Fields")]
        [Validation(Required=false)]
        public string Fields { get; set; }

        /// <summary>
        /// <para>The name of the global configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>soar_filed_tags</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BCDE6498-83CC-50A1-8307-3D5A539C42F8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
