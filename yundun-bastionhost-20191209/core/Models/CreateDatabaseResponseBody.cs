// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class CreateDatabaseResponseBody : TeaModel {
        /// <summary>
        /// <para>The database ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>334</para>
        /// </summary>
        [NameInMap("DatabaseId")]
        [Validation(Required=false)]
        public string DatabaseId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>98EDD923-236C-5A88-88E7-4979A91B9325</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
