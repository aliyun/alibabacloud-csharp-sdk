// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeSearchModifyParameterLogResponseBody : TeaModel {
        /// <summary>
        /// <para>The type of the Search engine.</para>
        /// 
        /// <b>Example:</b>
        /// <para>polardb_search</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>The DPI engine version of Search. This is not the MySQL version of the primary cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3.0</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// <para>The parameter modification history. The records are returned in descending order of record ID.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeSearchModifyParameterLogResponseBodyItems> Items { get; set; }
        public class DescribeSearchModifyParameterLogResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The time when the parameter was modified in UTC. Format: yyyy-MM-ddTHH:mm:ssZ.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-14T07:04:29Z</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// <para>The parameter value after the modification.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("NewParameterValue")]
            [Validation(Required=false)]
            public string NewParameterValue { get; set; }

            /// <summary>
            /// <para>The parameter value before the modification.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("OldParameterValue")]
            [Validation(Required=false)]
            public string OldParameterValue { get; set; }

            /// <summary>
            /// <para>The name of the parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>http.compression_level</para>
            /// </summary>
            [NameInMap("ParameterName")]
            [Validation(Required=false)]
            public string ParameterName { get; set; }

            /// <summary>
            /// <para>The modification status. A value of Syncing indicates that the modification has not taken effect. A value of Applied indicates that the modification has taken effect.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Applied</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e3a24663-eee5-4009-b635-2e9e8d052e74</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
