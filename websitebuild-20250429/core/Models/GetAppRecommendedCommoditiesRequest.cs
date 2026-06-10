// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class GetAppRecommendedCommoditiesRequest : TeaModel {
        /// <summary>
        /// <para>Application instance business ID (required in scenario 1, used to filter instance versions during query)</para>
        /// 
        /// <b>Example:</b>
        /// <para>WD20250703155602000001</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("Extend")]
        [Validation(Required=false)]
        public string Extend { get; set; }

        [NameInMap("ResourceConditions")]
        [Validation(Required=false)]
        public string ResourceConditions { get; set; }

        /// <summary>
        /// <para>Scenarios: ai_chat | inspiration</para>
        /// 
        /// <b>Example:</b>
        /// <para>DataworksManualTask</para>
        /// </summary>
        [NameInMap("Scene")]
        [Validation(Required=false)]
        public string Scene { get; set; }

    }

}
