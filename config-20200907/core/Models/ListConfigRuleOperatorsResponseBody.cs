// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListConfigRuleOperatorsResponseBody : TeaModel {
        [NameInMap("Operators")]
        [Validation(Required=false)]
        public List<ListConfigRuleOperatorsResponseBodyOperators> Operators { get; set; }
        public class ListConfigRuleOperatorsResponseBodyOperators : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>String</para>
            /// </summary>
            [NameInMap("DataType")]
            [Validation(Required=false)]
            public string DataType { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>StringEquals</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>StringEquals</para>
            /// </summary>
            [NameInMap("Operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>A68DD98C-DE65-46AC-B2D2-04A4A9AB5B99</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
