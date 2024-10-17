// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class QueryMediaIndexJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The indexing jobs enabled for the media asset.</para>
        /// </summary>
        [NameInMap("IndexJobInfoList")]
        [Validation(Required=false)]
        public List<QueryMediaIndexJobResponseBodyIndexJobInfoList> IndexJobInfoList { get; set; }
        public class QueryMediaIndexJobResponseBodyIndexJobInfoList : TeaModel {
            /// <summary>
            /// <para>The end time of the indexing job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-11-21 11:33:51</para>
            /// </summary>
            [NameInMap("GmtFinish")]
            [Validation(Required=false)]
            public string GmtFinish { get; set; }

            /// <summary>
            /// <para>The time when the index job was submitted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-11-21 11:33:50</para>
            /// </summary>
            [NameInMap("GmtSubmit")]
            [Validation(Required=false)]
            public string GmtSubmit { get; set; }

            /// <summary>
            /// <para>The index type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>mm: large visual model.</description></item>
            /// <item><description>face: face recognition.</description></item>
            /// <item><description>aiLabel: smart tagging.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>mm</para>
            /// </summary>
            [NameInMap("IndexType")]
            [Validation(Required=false)]
            public string IndexType { get; set; }

            /// <summary>
            /// <para>The job status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Running</description></item>
            /// <item><description>Success</description></item>
            /// <item><description>Fail</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4E84BE44-58A7-<b><b>-</b></b>-FBEBEA16EF94</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
