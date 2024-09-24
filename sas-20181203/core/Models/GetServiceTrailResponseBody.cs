// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetServiceTrailResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C699E4E4-F2F4-58FC-A949-457FFE59****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The configurations of the service trail.</para>
        /// </summary>
        [NameInMap("ServiceTrail")]
        [Validation(Required=false)]
        public GetServiceTrailResponseBodyServiceTrail ServiceTrail { get; set; }
        public class GetServiceTrailResponseBodyServiceTrail : TeaModel {
            /// <summary>
            /// <para>The status of the service trail. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>on:</b></description></item>
            /// <item><description><b>off:</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            /// <summary>
            /// <para>The timestamp generated when the service trail was created. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1687250241000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The timestamp generated when the service trail was last updated. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1687250241000</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

    }

}
