// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LHM20250116.Models
{
    public class GetSqlTableLineageResponseBody : TeaModel {
        /// <summary>
        /// <para>The data body returned by the operation. For the field structure, see the child parameters.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetSqlTableLineageResponseBodyData Data { get; set; }
        public class GetSqlTableLineageResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of downstream tables.</para>
            /// </summary>
            [NameInMap("downstreamTables")]
            [Validation(Required=false)]
            public List<string> DownstreamTables { get; set; }

            /// <summary>
            /// <para>The error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>connection timeout</para>
            /// </summary>
            [NameInMap("errorMsg")]
            [Validation(Required=false)]
            public string ErrorMsg { get; set; }

            /// <summary>
            /// <para>Indicates whether the call was successful. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Successful.</description></item>
            /// <item><description>false: Failed. Use errCode and errMessage to troubleshoot the issue.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

            /// <summary>
            /// <para>The list of upstream tables.</para>
            /// </summary>
            [NameInMap("upstreamTables")]
            [Validation(Required=false)]
            public List<string> UpstreamTables { get; set; }

        }

        /// <summary>
        /// <para>The error code. An empty string is returned if the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message. An empty string is returned if the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("errMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The request ID, which is used to locate and troubleshoot issues with the current call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4C467B38-3910-4477-9B0B-6963D83B4E72</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Successful.</description></item>
        /// <item><description>false: Failed. Use errCode and errMessage to troubleshoot the issue.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
