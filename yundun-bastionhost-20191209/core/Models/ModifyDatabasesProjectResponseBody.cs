// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ModifyDatabasesProjectResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EC9BF0F4-8983-491A-BC8C-1B4DD94976DE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The call results.</para>
        /// </summary>
        [NameInMap("Results")]
        [Validation(Required=false)]
        public List<ModifyDatabasesProjectResponseBodyResults> Results { get; set; }
        public class ModifyDatabasesProjectResponseBodyResults : TeaModel {
            /// <summary>
            /// <para>The instance ID of the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>53</para>
            /// </summary>
            [NameInMap("AssetId")]
            [Validation(Required=false)]
            public string AssetId { get; set; }

            /// <summary>
            /// <para>The error code. A value of <b>200</b> indicates that the operation is successful. Other values indicate that the operation failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The result message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

        }

        /// <summary>
        /// <para>The number of database instances that are moved.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("SuccessCount")]
        [Validation(Required=false)]
        public long? SuccessCount { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
