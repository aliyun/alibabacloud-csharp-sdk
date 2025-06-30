// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeCategoryTemplateListRequest : TeaModel {
        /// <summary>
        /// <para>Page number for paginated queries. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>This parameter is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("FeatureType")]
        [Validation(Required=false)]
        public int? FeatureType { get; set; }

        /// <summary>
        /// <para>Set the language type for the request and response messages, default is <b>zh_cn</b>.
        /// Values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh_cn</b>: Chinese (Simplified)</description></item>
        /// <item><description><b>en_us</b>: English (United States)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh_cn</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>When performing a paginated query, set the number of items per page. Default value is <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>API call scenario, default is <b>null</b>.
        /// Values:</para>
        /// <list type="bullet">
        /// <item><description><b>null</b>: Old version</description></item>
        /// <item><description><b>0</b>: Old version</description></item>
        /// <item><description><b>1</b>: New version</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UsageScenario")]
        [Validation(Required=false)]
        public int? UsageScenario { get; set; }

    }

}
