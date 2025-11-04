// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class AddStreamTagToSearchLibRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the media asset.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>b48fb04483915d4f2cd8</b></b></b></para>
        /// </summary>
        [NameInMap("MediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

        /// <summary>
        /// <para>The message body.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;startTime&quot;:1657684600793,&quot;endTime&quot;:1657684600793,&quot;userData&quot;:&quot;{}&quot;}</para>
        /// </summary>
        [NameInMap("MsgBody")]
        [Validation(Required=false)]
        public string MsgBody { get; set; }

        /// <summary>
        /// <para>The namespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>name-1</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The search library.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Stream_xxx</para>
        /// </summary>
        [NameInMap("SearchLibName")]
        [Validation(Required=false)]
        public string SearchLibName { get; set; }

    }

}
