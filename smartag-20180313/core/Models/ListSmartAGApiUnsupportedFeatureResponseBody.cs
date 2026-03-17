// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class ListSmartAGApiUnsupportedFeatureResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of unsupported features.</para>
        /// </summary>
        [NameInMap("Features")]
        [Validation(Required=false)]
        public List<ListSmartAGApiUnsupportedFeatureResponseBodyFeatures> Features { get; set; }
        public class ListSmartAGApiUnsupportedFeatureResponseBodyFeatures : TeaModel {
            /// <summary>
            /// <para>The unsupported feature.</para>
            /// <para>For more information about the description of each feature, see the related API reference.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ISP</para>
            /// </summary>
            [NameInMap("Feature")]
            [Validation(Required=false)]
            public string Feature { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7459545D-2F0D-43E6-9957-CB7E0223332B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
