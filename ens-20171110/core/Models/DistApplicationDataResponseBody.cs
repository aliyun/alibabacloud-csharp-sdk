// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DistApplicationDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of ENS instance IDs.</para>
        /// </summary>
        [NameInMap("DistInstanceIds")]
        [Validation(Required=false)]
        public DistApplicationDataResponseBodyDistInstanceIds DistInstanceIds { get; set; }
        public class DistApplicationDataResponseBodyDistInstanceIds : TeaModel {
            [NameInMap("DistInstanceId")]
            [Validation(Required=false)]
            public List<string> DistInstanceId { get; set; }

        }

        /// <summary>
        /// <para>The total number of ENS instance IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("DistInstanceTotalCount")]
        [Validation(Required=false)]
        public int? DistInstanceTotalCount { get; set; }

        /// <summary>
        /// <para>The distribution result of the data file.</para>
        /// </summary>
        [NameInMap("DistResults")]
        [Validation(Required=false)]
        public DistApplicationDataResponseBodyDistResults DistResults { get; set; }
        public class DistApplicationDataResponseBodyDistResults : TeaModel {
            [NameInMap("DistResult")]
            [Validation(Required=false)]
            public List<DistApplicationDataResponseBodyDistResultsDistResult> DistResult { get; set; }
            public class DistApplicationDataResponseBodyDistResultsDistResult : TeaModel {
                /// <summary>
                /// <para>The name of the data file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gcs-prod-websocket-eip-unicom</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The error code. The value is of the enumerated data type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>400</para>
                /// </summary>
                [NameInMap("ResultCode")]
                [Validation(Required=false)]
                public int? ResultCode { get; set; }

                /// <summary>
                /// <para>The description of the distribution result.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Success</para>
                /// </summary>
                [NameInMap("ResultDescrip")]
                [Validation(Required=false)]
                public string ResultDescrip { get; set; }

                /// <summary>
                /// <para>The version number of the data file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>standard</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
