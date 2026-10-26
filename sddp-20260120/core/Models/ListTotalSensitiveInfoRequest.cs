// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20260120.Models
{
    public class ListTotalSensitiveInfoRequest : TeaModel {
        /// <summary>
        /// <para>The statistics scenario. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>41: Overview.</description></item>
        /// <item><description>42: Query data catalog statistics by product.</description></item>
        /// <item><description>43: Query region and template summaries by product.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>43</para>
        /// </summary>
        [NameInMap("CountType")]
        [Validation(Required=false)]
        public int? CountType { get; set; }

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
        /// <para>The code of the cloud service. Column encryption supports RDS, POLARDB, and PolarDBX2. If ProductId is also specified, the two parameters must match.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RDS</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The codes of multiple cloud services, separated by commas (,). This parameter is used when CountType is set to 43 and ProductCode is not specified. The results are aggregated by region and template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RDS,POLARDB,PolarDBX2</para>
        /// </summary>
        [NameInMap("ProductCodeList")]
        [Validation(Required=false)]
        public string ProductCodeList { get; set; }

        /// <summary>
        /// <para>The ID of the data classification template. You can obtain the ID from the Items[].Id parameter in the response of the ListTemplates operation. The template must be consistent with the selected sensitivity level and detection model.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public long? TemplateId { get; set; }

    }

}
