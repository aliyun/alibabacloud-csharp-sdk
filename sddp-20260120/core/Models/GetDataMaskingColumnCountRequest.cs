// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20260120.Models
{
    public class GetDataMaskingColumnCountRequest : TeaModel {
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
        /// <para>The list of cloud product type identifiers. Separate multiple values with commas (,). For column encryption scenarios, the values correspond to 5 (ApsaraDB RDS), 8 (PolarDB), and 27 (PolarDB-X).</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ProductIds")]
        [Validation(Required=false)]
        public string ProductIds { get; set; }

        /// <summary>
        /// <para>The data classification template ID. You can obtain the ID from the Items[].Id parameter in the ListTemplates response. The ID must be consistent with the selected sensitivity level and detection model.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public long? TemplateId { get; set; }

    }

}
