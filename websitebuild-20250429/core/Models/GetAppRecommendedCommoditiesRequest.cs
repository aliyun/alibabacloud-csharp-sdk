// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class GetAppRecommendedCommoditiesRequest : TeaModel {
        /// <summary>
        /// <para>The business ID of the application instance. This parameter is required in Scenario 1 and is used to filter instance versions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WD20250703155602000001</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <para>The extended information.</para>
        /// </summary>
        [NameInMap("Extend")]
        [Validation(Required=false)]
        public string Extend { get; set; }

        /// <summary>
        /// <para>The resource filtering conditions.</para>
        /// </summary>
        [NameInMap("ResourceConditions")]
        [Validation(Required=false)]
        public string ResourceConditions { get; set; }

        /// <summary>
        /// <para>The scenarios. Valid values: ai_chat and inspiration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DataworksManualTask</para>
        /// </summary>
        [NameInMap("Scene")]
        [Validation(Required=false)]
        public string Scene { get; set; }

    }

}
