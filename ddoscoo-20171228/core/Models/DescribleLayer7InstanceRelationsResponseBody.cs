// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20171228.Models
{
    public class DescribleLayer7InstanceRelationsResponseBody : TeaModel {
        [NameInMap("Layer7InstanceRelations")]
        [Validation(Required=false)]
        public List<DescribleLayer7InstanceRelationsResponseBodyLayer7InstanceRelations> Layer7InstanceRelations { get; set; }
        public class DescribleLayer7InstanceRelationsResponseBodyLayer7InstanceRelations : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://www.aliyun.com">www.aliyun.com</a></para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            [NameInMap("InstanceDetails")]
            [Validation(Required=false)]
            public List<DescribleLayer7InstanceRelationsResponseBodyLayer7InstanceRelationsInstanceDetails> InstanceDetails { get; set; }
            public class DescribleLayer7InstanceRelationsResponseBodyLayer7InstanceRelationsInstanceDetails : TeaModel {
                [NameInMap("EipList")]
                [Validation(Required=false)]
                public List<string> EipList { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("FunctionVersion")]
                [Validation(Required=false)]
                public string FunctionVersion { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ddoscoo-cn-XXXXX</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("IpMode")]
                [Validation(Required=false)]
                public string IpMode { get; set; }

                [NameInMap("IpVersion")]
                [Validation(Required=false)]
                public string IpVersion { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CF33B4C3-196E-4015-AADD-5CAD00057B80</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
