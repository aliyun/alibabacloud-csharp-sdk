// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class CreateSlrAndSlsProjectResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fe33a379-5053-4f22-a73c-826e2b44355d</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about Log Service.</para>
        /// </summary>
        [NameInMap("SlsInfo")]
        [Validation(Required=false)]
        public CreateSlrAndSlsProjectResponseBodySlsInfo SlsInfo { get; set; }
        public class CreateSlrAndSlsProjectResponseBodySlsInfo : TeaModel {
            /// <summary>
            /// <para>The endpoint of Log Service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai.log.*.com</para>
            /// </summary>
            [NameInMap("EndPoint")]
            [Validation(Required=false)]
            public string EndPoint { get; set; }

            /// <summary>
            /// <para>The Logstore of Log Service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dcdn-edge-trlog</para>
            /// </summary>
            [NameInMap("LogStore")]
            [Validation(Required=false)]
            public string LogStore { get; set; }

            /// <summary>
            /// <para>The project of Log Service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dcdn-edge-rtlog-cn-cfc7****</para>
            /// </summary>
            [NameInMap("Project")]
            [Validation(Required=false)]
            public string Project { get; set; }

            /// <summary>
            /// <para>The region where Log Service resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

        }

    }

}
