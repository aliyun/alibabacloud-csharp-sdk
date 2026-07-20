// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20250227.Models
{
    public class CustomerNoteCreateRequest : TeaModel {
        /// <summary>
        /// <para>The contact information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>13833333333</para>
        /// </summary>
        [NameInMap("ContactInformation")]
        [Validation(Required=false)]
        public string ContactInformation { get; set; }

        /// <summary>
        /// <para>The name of the contact.</para>
        /// 
        /// <b>Example:</b>
        /// <para>张三</para>
        /// </summary>
        [NameInMap("ContactName")]
        [Validation(Required=false)]
        public string ContactName { get; set; }

        /// <summary>
        /// <para>The name of the customer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>XXXX有限公司</para>
        /// </summary>
        [NameInMap("CustomerName")]
        [Validation(Required=false)]
        public string CustomerName { get; set; }

        /// <summary>
        /// <para>The UID of the customer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1647796581073291</para>
        /// </summary>
        [NameInMap("CustomerUid")]
        [Validation(Required=false)]
        public string CustomerUid { get; set; }

        /// <summary>
        /// <para>The content of the note.</para>
        /// 
        /// <b>Example:</b>
        /// <para>日常拜访客户，讨论客户agent建设方案</para>
        /// </summary>
        [NameInMap("NoteContent")]
        [Validation(Required=false)]
        public string NoteContent { get; set; }

        /// <summary>
        /// <para>The touch time. This value is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1784266662000</para>
        /// </summary>
        [NameInMap("TouchDate")]
        [Validation(Required=false)]
        public long? TouchDate { get; set; }

    }

}
