// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetAdvancedSearchFileResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9366FE45-3C83-54FB-8BB1-44176B200706</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the resource file.</para>
        /// </summary>
        [NameInMap("ResourceSearch")]
        [Validation(Required=false)]
        public GetAdvancedSearchFileResponseBodyResourceSearch ResourceSearch { get; set; }
        public class GetAdvancedSearchFileResponseBodyResourceSearch : TeaModel {
            /// <summary>
            /// <para>The download URL of the resource file.</para>
            /// </summary>
            [NameInMap("DownloadUrl")]
            [Validation(Required=false)]
            public string DownloadUrl { get; set; }

            /// <summary>
            /// <para>The time when the resource file was generated. The value is a timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1688281755480</para>
            /// </summary>
            [NameInMap("ResourceInventoryGenerateTime")]
            [Validation(Required=false)]
            public long? ResourceInventoryGenerateTime { get; set; }

            /// <summary>
            /// <para>The generation status of the resource file. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CREATING: The resource file is being generated.</description></item>
            /// <item><description>COMPLETE: The resource file is generated.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>COMPLETE</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
