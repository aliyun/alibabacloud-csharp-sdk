// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListDagsRequest : TeaModel {
        /// <summary>
        /// <para>The unique identifier of the data backfill instance. You can call the <a href="https://help.aliyun.com/document_detail/189753.html">GetDag</a> operation to obtain this value.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("OpSeq")]
        [Validation(Required=false)]
        public long? OpSeq { get; set; }

        /// <summary>
        /// <para>The identifier of the scheduling O&amp;M environment. PROD indicates the production environment, and DEV indicates the development environment.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PROD</para>
        /// </summary>
        [NameInMap("ProjectEnv")]
        [Validation(Required=false)]
        public string ProjectEnv { get; set; }

    }

}
