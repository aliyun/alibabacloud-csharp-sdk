// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class UpdateSqlInstanceParamsRequest : TeaModel {
        /// <summary>
        /// <para>The combined parameters.</para>
        /// </summary>
        [NameInMap("combineParam")]
        [Validation(Required=false)]
        public Dictionary<string, object> CombineParam { get; set; }

        /// <summary>
        /// <para>The dynamic parameters.</para>
        /// </summary>
        [NameInMap("dynamicParam")]
        [Validation(Required=false)]
        public Dictionary<string, object> DynamicParam { get; set; }

        /// <summary>
        /// <para>The key-value (KV) configuration of the instance.</para>
        /// </summary>
        [NameInMap("kvpair")]
        [Validation(Required=false)]
        public Dictionary<string, object> Kvpair { get; set; }

        /// <summary>
        /// <para>The parameters to modify.</para>
        /// </summary>
        [NameInMap("params")]
        [Validation(Required=false)]
        public Dictionary<string, object> Params { get; set; }

        /// <summary>
        /// <para>The static parameters.</para>
        /// </summary>
        [NameInMap("staticParam")]
        [Validation(Required=false)]
        public Dictionary<string, object> StaticParam { get; set; }

    }

}
