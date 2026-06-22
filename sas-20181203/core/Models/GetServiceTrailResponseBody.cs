// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetServiceTrailResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request. The system generates a unique identifier for each request. You can use the ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C699E4E4-F2F4-58FC-A949-457FFE59****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The service trail configuration.</para>
        /// </summary>
        [NameInMap("ServiceTrail")]
        [Validation(Required=false)]
        public GetServiceTrailResponseBodyServiceTrail ServiceTrail { get; set; }
        public class GetServiceTrailResponseBodyServiceTrail : TeaModel {
            /// <summary>
            /// <para>The enabling status of the service trail. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>on</b>: Enabled.</description></item>
            /// <item><description><b>off</b>: Shutdown.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            /// <summary>
            /// <para>The timestamp when the service trail was created. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1687250241000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The timestamp when the service trail was last updated. Unit: milliseconds.</para>
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
