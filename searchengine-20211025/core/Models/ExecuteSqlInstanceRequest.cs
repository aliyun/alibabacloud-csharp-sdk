// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ExecuteSqlInstanceRequest : TeaModel {
        [NameInMap("combineParam")]
        [Validation(Required=false)]
        public Dictionary<string, object> CombineParam { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>select * from test</para>
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>vpc_hz_domain_1</para>
        /// </summary>
        [NameInMap("domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        [NameInMap("dynamicParam")]
        [Validation(Required=false)]
        public Dictionary<string, object> DynamicParam { get; set; }

        [NameInMap("kvpair")]
        [Validation(Required=false)]
        public Dictionary<string, object> Kvpair { get; set; }

        [NameInMap("params")]
        [Validation(Required=false)]
        public Dictionary<string, object> Params { get; set; }

        [NameInMap("staticParam")]
        [Validation(Required=false)]
        public Dictionary<string, object> StaticParam { get; set; }

    }

}
