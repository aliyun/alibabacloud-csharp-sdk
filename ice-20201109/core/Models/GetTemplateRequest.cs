// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetTemplateRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to return the information about the associated materials. Default value: 0. Valid values: 0 and 1. A value of 1 specifies that the information about the associated materials is returned. This parameter is valid only for regular templates.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RelatedMediaidFlag")]
        [Validation(Required=false)]
        public string RelatedMediaidFlag { get; set; }

        /// <summary>
        /// <para>The template ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>20b48fb04483915d4f2cd8ac</b></b></para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}
