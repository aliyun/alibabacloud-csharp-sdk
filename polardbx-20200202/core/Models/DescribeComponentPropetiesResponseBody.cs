// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeComponentPropetiesResponseBody : TeaModel {
        /// <summary>
        /// <para>The export parameters of the exception event.</para>
        /// </summary>
        [NameInMap("Properties")]
        [Validation(Required=false)]
        public List<DescribeComponentPropetiesResponseBodyProperties> Properties { get; set; }
        public class DescribeComponentPropetiesResponseBodyProperties : TeaModel {
            /// <summary>
            /// <para>The name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4核32G</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The display order of the commodity module property.</para>
            /// <para>The returned content varies depending on the commodity module.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("OrderIndex")]
            [Validation(Required=false)]
            public string OrderIndex { get; set; }

            /// <summary>
            /// <para>The commodity module.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dn_node_spec</para>
            /// </summary>
            [NameInMap("PropertyCode")]
            [Validation(Required=false)]
            public string PropertyCode { get; set; }

            /// <summary>
            /// <para>The label value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.27.35.</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>A501A191-BD70-5E50-98A9-C2A486A82****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
