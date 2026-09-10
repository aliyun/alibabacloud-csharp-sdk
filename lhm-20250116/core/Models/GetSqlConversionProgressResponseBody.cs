// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LHM20250116.Models
{
    public class GetSqlConversionProgressResponseBody : TeaModel {
        /// <summary>
        /// <para>The data body returned by the operation. For the field structure, see the child field descriptions.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetSqlConversionProgressResponseBodyData Data { get; set; }
        public class GetSqlConversionProgressResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The number of failed scripts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("fail")]
            [Validation(Required=false)]
            public long? Fail { get; set; }

            /// <summary>
            /// <para>The number of completed scripts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("finish")]
            [Validation(Required=false)]
            public long? Finish { get; set; }

            /// <summary>
            /// <para>The completion percentage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>66.67</para>
            /// </summary>
            [NameInMap("percent")]
            [Validation(Required=false)]
            public double? Percent { get; set; }

            /// <summary>
            /// <para>The number of scripts being converted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("running")]
            [Validation(Required=false)]
            public long? Running { get; set; }

            /// <summary>
            /// <para>The total number of scripts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

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
        /// <para>The request ID, which is used to locate and troubleshoot issues with this call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4C467B38-3910-4477-9B0B-6963D83B4E72</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The call is successful.</description></item>
        /// <item><description>false: The call failed. Check errCode and errMessage for troubleshooting.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
