// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeCategoryTemplateListRequest : TeaModel {
        /// <summary>
        /// <para>The page number in a paged query. Default value: 1.</para>
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
        /// <para>The language of the request and response. Default value: <b>zh_cn</b>.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh_cn</b>: Simplified Chinese.</description></item>
        /// <item><description><b>en_us</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh_cn</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The number of entries per page in a paged query. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The scenario in which the API is called. Default value: <b>null</b>.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>null</b>: legacy version.</description></item>
        /// <item><description><b>0</b>: legacy version.</description></item>
        /// <item><description><b>1</b>: new version.</description></item>
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
