// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class DeleteFaceRecordV2ResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>5E63B760-0ECB-5C07-8503-A65C27876968</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The response result.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public DeleteFaceRecordV2ResponseBodyResult Result { get; set; }
        public class DeleteFaceRecordV2ResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The deletion result. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Y: Succeeded.</description></item>
            /// <item><description>N: Failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Y</para>
            /// </summary>
            [NameInMap("Deleted")]
            [Validation(Required=false)]
            public string Deleted { get; set; }

            /// <summary>
            /// <para>The list of face group codes from which the face data was actually deleted (comma-separated). This parameter is returned with all deleted group codes when FaceGroupCode is not specified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>wqe***,dsa***</para>
            /// </summary>
            [NameInMap("DeletedGroupCodes")]
            [Validation(Required=false)]
            public string DeletedGroupCodes { get; set; }

        }

    }

}
