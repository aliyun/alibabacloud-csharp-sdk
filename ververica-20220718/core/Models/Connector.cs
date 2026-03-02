// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class Connector : TeaModel {
        /// <summary>
        /// <para>The ID of the user who creates the connector.</para>
        /// 
        /// <b>Example:</b>
        /// <para>183899668*******</para>
        /// </summary>
        [NameInMap("creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        /// <summary>
        /// <para>The nickname of the user who creates the connector.</para>
        /// 
        /// <b>Example:</b>
        /// <para>userA</para>
        /// </summary>
        [NameInMap("creatorName")]
        [Validation(Required=false)]
        public string CreatorName { get; set; }

        /// <summary>
        /// <para>The additional dependency files.</para>
        /// </summary>
        [NameInMap("dependencies")]
        [Validation(Required=false)]
        public List<string> Dependencies { get; set; }

        /// <summary>
        /// <para>Indicates whether the connector can be used as a lookup table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("lookup")]
        [Validation(Required=false)]
        public bool? Lookup { get; set; }

        /// <summary>
        /// <para>The ID of the user who modifies the connector.</para>
        /// 
        /// <b>Example:</b>
        /// <para>183899668*******</para>
        /// </summary>
        [NameInMap("modifier")]
        [Validation(Required=false)]
        public string Modifier { get; set; }

        /// <summary>
        /// <para>The nickname of the user who modifies the connector.</para>
        /// 
        /// <b>Example:</b>
        /// <para>userA</para>
        /// </summary>
        [NameInMap("modifierName")]
        [Validation(Required=false)]
        public string ModifierName { get; set; }

        /// <summary>
        /// <para>The name of the connector.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mysql-test</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The parameter configurations.</para>
        /// </summary>
        [NameInMap("properties")]
        [Validation(Required=false)]
        public List<Property> Properties { get; set; }

        /// <summary>
        /// <para>Indicates whether the connector can be used as the sink.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("sink")]
        [Validation(Required=false)]
        public bool? Sink { get; set; }

        /// <summary>
        /// <para>Indicates whether the connector can be used as the source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>flase</para>
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public bool? Source { get; set; }

        /// <summary>
        /// <para>The array of formats that are supported by the connector.</para>
        /// </summary>
        [NameInMap("supportedFormats")]
        [Validation(Required=false)]
        public List<string> SupportedFormats { get; set; }

        /// <summary>
        /// <para>The type of the connector.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mysql-test</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
