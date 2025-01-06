// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20180601.Models
{
    public class GetDataServiceApiContextRequest : TeaModel {
        /// <summary>
        /// <para>apiId</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("ApiId")]
        [Validation(Required=false)]
        public long? ApiId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ApiStatus")]
        [Validation(Required=false)]
        public int? ApiStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>abc-124</para>
        /// </summary>
        [NameInMap("CacheKey")]
        [Validation(Required=false)]
        public string CacheKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ForPrivateResGroup")]
        [Validation(Required=false)]
        public bool? ForPrivateResGroup { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Verbose")]
        [Validation(Required=false)]
        public bool? Verbose { get; set; }

    }

}
