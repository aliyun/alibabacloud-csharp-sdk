// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20260120.Models
{
    public class ListIdentifyModelsRequest : TeaModel {
        /// <summary>
        /// <para>A reserved feature type parameter. This parameter is not used to filter results in the current query. You do not need to specify this parameter for column encryption calls.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("FeatureType")]
        [Validation(Required=false)]
        public int? FeatureType { get; set; }

        /// <summary>
        /// <para>Specifies whether to return only detection models supported in audit scenarios. If this parameter is set to true, only audit-supported models such as phone number, ID card, and bank card models are returned. You do not need to specify this parameter for column encryption scenarios.</para>
        /// </summary>
        [NameInMap("FilterAuditModel")]
        [Validation(Required=false)]
        public bool? FilterAuditModel { get; set; }

        /// <summary>
        /// <para>The language of the response description. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh: Chinese.</description></item>
        /// <item><description>en: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The ID of the data classification template. You can obtain this value from Items[].Id in the response of the ListTemplates operation. The template must be consistent with the selected sensitivity level and detection models.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public long? TemplateId { get; set; }

    }

}
