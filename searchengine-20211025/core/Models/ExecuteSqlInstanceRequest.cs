// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ExecuteSqlInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The combined parameters.</para>
        /// </summary>
        [NameInMap("combineParam")]
        [Validation(Required=false)]
        public Dictionary<string, object> CombineParam { get; set; }

        /// <summary>
        /// <para>The SQL content.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>select * from test</para>
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The data source server room.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc_hz_domain_1</para>
        /// </summary>
        [NameInMap("domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The dynamic parameters.</para>
        /// </summary>
        [NameInMap("dynamicParam")]
        [Validation(Required=false)]
        public Dictionary<string, object> DynamicParam { get; set; }

        /// <summary>
        /// <para>The key-value struct.</para>
        /// </summary>
        [NameInMap("kvpair")]
        [Validation(Required=false)]
        public Dictionary<string, object> Kvpair { get; set; }

        /// <summary>
        /// <para>The SQL execution parameters.</para>
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
