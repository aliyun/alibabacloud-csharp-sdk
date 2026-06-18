// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class UpdateTableFromAuthorizedOssResponseBody : TeaModel {
        /// <summary>
        /// <para>Error status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DataCenter.FileTooLarge</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Data field of the response.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public UpdateTableFromAuthorizedOssResponseBodyData Data { get; set; }
        public class UpdateTableFromAuthorizedOssResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Current table status. After upload, the status usually changes to TO_IMPORT. This means the system has accepted the uploaded file and is waiting to schedule it into the data table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TO_IMPORT</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Same as the input TableId parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>table_df96ebd5da8640e5a0991b3d15f39d4d_12792097</para>
            /// </summary>
            [NameInMap("TableId")]
            [Validation(Required=false)]
            public string TableId { get; set; }

        }

        /// <summary>
        /// <para>Error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Required parameter(%s) missing or invalid, please check the request parameters.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7BA8ADD9-53D6-53F0-918F-A1E776AD230E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Status code returned by the operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation succeeded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
