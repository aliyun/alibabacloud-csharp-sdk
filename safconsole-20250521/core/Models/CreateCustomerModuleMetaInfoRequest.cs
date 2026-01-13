// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Safconsole20250521.Models
{
    public class CreateCustomerModuleMetaInfoRequest : TeaModel {
        /// <summary>
        /// <para>Customer model ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CustomerModuleId")]
        [Validation(Required=false)]
        public int? CustomerModuleId { get; set; }

        /// <summary>
        /// <para>A string representation of List<Object>, where Object has the following structure:
        /// {
        /// &quot;mappingName&quot;: &quot;xxx&quot;
        /// }</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;mappingName\&quot;:\&quot;f1\&quot;,\&quot;fieldName\&quot;:\&quot;saf_shanghai_new.f1\&quot;,\&quot;valueType\&quot;:\&quot;DOUBLE\&quot;,\&quot;defaultValue\&quot;:\&quot;\&quot;}</para>
        /// </summary>
        [NameInMap("FeatureString")]
        [Validation(Required=false)]
        public string FeatureString { get; set; }

        /// <summary>
        /// <para>Version of the feature adopted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FINANCE_51</para>
        /// </summary>
        [NameInMap("FeatureTemplate")]
        [Validation(Required=false)]
        public string FeatureTemplate { get; set; }

    }

}
