// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Schedulerx220190430.Models
{
    public class CreateAppGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The information about the job group.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateAppGroupResponseBodyData Data { get; set; }
        public class CreateAppGroupResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The job group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6607</para>
            /// </summary>
            [NameInMap("AppGroupId")]
            [Validation(Required=false)]
            public long? AppGroupId { get; set; }

            /// <summary>
            /// <para>The AppKey for the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>adcExHZviL******</para>
            /// </summary>
            [NameInMap("AppKey")]
            [Validation(Required=false)]
            public string AppKey { get; set; }

        }

        /// <summary>
        /// <para>The error message that is returned only if the corresponding error occurs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Your request is denied as lack of ssl protect.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>883AFE93-FB03-4FA9-A958-E750C6DE120C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the application was created. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
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
