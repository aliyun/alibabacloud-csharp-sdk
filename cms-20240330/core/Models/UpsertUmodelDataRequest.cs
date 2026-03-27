// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class UpsertUmodelDataRequest : TeaModel {
        /// <summary>
        /// <para>Element content</para>
        /// </summary>
        [NameInMap("elements")]
        [Validation(Required=false)]
        public List<object> Elements { get; set; }

        /// <summary>
        /// <para>Method</para>
        /// 
        /// <b>Example:</b>
        /// <para>Upsert</para>
        /// </summary>
        [NameInMap("method")]
        [Validation(Required=false)]
        public string Method { get; set; }

    }

}
