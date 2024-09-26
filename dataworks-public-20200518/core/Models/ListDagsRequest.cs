// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListDagsRequest : TeaModel {
        /// <summary>
        /// <para>The sequence number that uniquely identifies the data backfill operation. You can call the <a href="https://help.aliyun.com/document_detail/189753.html">GetDag</a> operation to query the sequence number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("OpSeq")]
        [Validation(Required=false)]
        public long? OpSeq { get; set; }

        /// <summary>
        /// <para>The environment of the workspace. Valid values: PROD and DEV. The value PROD indicates the production environment, and the value DEV indicates the development environment.</para>
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
