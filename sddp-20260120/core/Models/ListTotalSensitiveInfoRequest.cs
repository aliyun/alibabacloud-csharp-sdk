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
        /// <item><description>41: overview.</description></item>
        /// <item><description>42: data catalog statistics by product.</description></item>
        /// <item><description>43: region and template summary by product.</description></item>
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
        /// <para>The code of the cloud service. Column encryption supports RDS, POLARDB, and PolarDBX2. If you also specify ProductId, the two values must correspond to each other.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RDS</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>Multiple product codes separated by commas (,). This parameter is used when CountType is set to 43 and ProductCode is not specified. The results are merged by region and template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RDS,POLARDB,PolarDBX2</para>
        /// </summary>
        [NameInMap("ProductCodeList")]
        [Validation(Required=false)]
        public string ProductCodeList { get; set; }

        /// <summary>
        /// <para>The ID of the data classification template. You can obtain this value from Items[].Id in the response of the ListTemplates operation. The value must be consistent with the selected sensitivity level and detection model.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public long? TemplateId { get; set; }

    }

}
