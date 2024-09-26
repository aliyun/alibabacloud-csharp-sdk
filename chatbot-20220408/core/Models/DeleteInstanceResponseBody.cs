// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class DeleteInstanceResponseBody : TeaModel {
        [NameInMap("BizTypeList")]
        [Validation(Required=false)]
        public List<string> BizTypeList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-09-11T09:26:14Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9052</para>
        /// </summary>
        [NameInMap("CreateUserId")]
        [Validation(Required=false)]
        public long? CreateUserId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xuqiang_test</para>
        /// </summary>
        [NameInMap("CreateUserName")]
        [Validation(Required=false)]
        public string CreateUserName { get; set; }

        [NameInMap("Error")]
        [Validation(Required=false)]
        public string Error { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8521</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5CBF0581-EAE7-1DC4-95C6-A089656A1E2D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8521</para>
        /// </summary>
        [NameInMap("Response")]
        [Validation(Required=false)]
        public long? Response { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>FE_RUNNING</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
