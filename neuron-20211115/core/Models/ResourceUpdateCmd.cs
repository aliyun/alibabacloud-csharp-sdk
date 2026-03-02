// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class ResourceUpdateCmd : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>http://</para>
        /// </summary>
        [NameInMap("address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        [NameInMap("configuration")]
        [Validation(Required=false)]
        public string Configuration { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{ak:xxxx,sk:xxx}</para>
        /// </summary>
        [NameInMap("credentials")]
        [Validation(Required=false)]
        public string Credentials { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>用于统一管理资源</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Inner</para>
        /// </summary>
        [NameInMap("useScope")]
        [Validation(Required=false)]
        public string UseScope { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Share</para>
        /// </summary>
        [NameInMap("useType")]
        [Validation(Required=false)]
        public string UseType { get; set; }

    }

}
