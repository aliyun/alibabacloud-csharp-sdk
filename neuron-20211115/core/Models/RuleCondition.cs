// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class RuleCondition : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>userId</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>header</para>
        /// </summary>
        [NameInMap("position")]
        [Validation(Required=false)]
        public string Position { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>==</para>
        /// </summary>
        [NameInMap("relation")]
        [Validation(Required=false)]
        public string Relation { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("value")]
        [Validation(Required=false)]
        public string Value { get; set; }

        [NameInMap("valueType")]
        [Validation(Required=false)]
        public string ValueType { get; set; }

    }

}
