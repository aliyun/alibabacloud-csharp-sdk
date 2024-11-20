// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetTemplateMaterialsRequest : TeaModel {
        /// <summary>
        /// <para>The materials that you want to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;music.mp3&quot;,&quot;config.json&quot;,&quot;assets/1.jpg&quot;]</para>
        /// </summary>
        [NameInMap("FileList")]
        [Validation(Required=false)]
        public string FileList { get; set; }

        /// <summary>
        /// <para>The template ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>20b48fb04483915d4f2cd8ac</b></b></para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}
