// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20260120.Models
{
    public class ListIdentifyModelsRequest : TeaModel {
        /// <summary>
        /// <para>The reserved feature type parameter. This parameter is not used to filter results in the current query and is not required for column encryption calls.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("FeatureType")]
        [Validation(Required=false)]
        public int? FeatureType { get; set; }

        /// <summary>
        /// <para>Specifies whether to restrict the results to detection models supported in audit scenarios. If you set this parameter to true, only models supported for auditing, such as mobile phone numbers, ID cards, and bank cards, are returned. This parameter is optional for column encryption scenarios.</para>
        /// </summary>
        [NameInMap("FilterAuditModel")]
        [Validation(Required=false)]
        public bool? FilterAuditModel { get; set; }

        /// <summary>
        /// <para>The language of the response description. Valid values: zh: Chinese. en: English.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The ID of the data classification template. You can obtain the ID from Items[].Id returned by ListTemplates. The template must be consistent with the selected sensitivity level and detection model.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public long? TemplateId { get; set; }

    }

}
