// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class MoveCdsFileResponseBody : TeaModel {
        /// <summary>
        /// <para>The result of the modification. A value of success indicates that the modification is successful. If the modification failed, an error message is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The error message that is returned. This parameter is not returned if the value of Code is success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The response object when you move a file.</para>
        /// </summary>
        [NameInMap("MoveCdsFileModel")]
        [Validation(Required=false)]
        public MoveCdsFileResponseBodyMoveCdsFileModel MoveCdsFileModel { get; set; }
        public class MoveCdsFileResponseBodyMoveCdsFileModel : TeaModel {
            /// <summary>
            /// <para>The ID of the asynchronous task. This parameter is not returned if you copy files. This parameter is returned if you copy folders in the backend in an asynchronous manner. You can call the GetAsyncTask operation to obtain the ID and details of an asynchronous task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fe307518-825a-4c8b-a69c-958f0e8a****</para>
            /// </summary>
            [NameInMap("AsyncTaskId")]
            [Validation(Required=false)]
            public string AsyncTaskId { get; set; }

            /// <summary>
            /// <para>Indicates whether the file exists.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><!-- -->
            /// 
            /// <para>true</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// </description></item>
            /// <item><description><!-- -->
            /// 
            /// <para>false</para>
            /// <!-- -->
            /// 
            /// <!-- --></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Exist")]
            [Validation(Required=false)]
            public bool? Exist { get; set; }

            /// <summary>
            /// <para>The ID of the file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>63636837e47e5a24a8a940218bef395c210e****</para>
            /// </summary>
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><!-- -->
        /// 
        /// <para>true</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><!-- -->
        /// 
        /// <para>false</para>
        /// <!-- -->
        /// 
        /// <!-- --></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
