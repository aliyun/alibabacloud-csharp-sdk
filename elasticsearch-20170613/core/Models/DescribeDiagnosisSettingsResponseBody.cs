// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class DescribeDiagnosisSettingsResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5E82B8A8-EED7-4557-A6E9-D1AD3E58****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The return results.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeDiagnosisSettingsResponseBodyResult Result { get; set; }
        public class DescribeDiagnosisSettingsResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Scenarios of intelligent maintenance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Business Search</para>
            /// </summary>
            [NameInMap("scene")]
            [Validation(Required=false)]
            public string Scene { get; set; }

            /// <summary>
            /// <para>The timestamp of the last update for Intelligent Maintenance scenarios.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1588994035385</para>
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

    }

}
