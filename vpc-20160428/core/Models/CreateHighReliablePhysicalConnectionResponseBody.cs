// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateHighReliablePhysicalConnectionResponseBody : TeaModel {
        [NameInMap("ErrorInfoList")]
        [Validation(Required=false)]
        public CreateHighReliablePhysicalConnectionResponseBodyErrorInfoList ErrorInfoList { get; set; }
        public class CreateHighReliablePhysicalConnectionResponseBodyErrorInfoList : TeaModel {
            [NameInMap("errorInfoList")]
            [Validation(Required=false)]
            public List<CreateHighReliablePhysicalConnectionResponseBodyErrorInfoListErrorInfoList> ErrorInfoList { get; set; }
            public class CreateHighReliablePhysicalConnectionResponseBodyErrorInfoListErrorInfoList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>pconn.high.reliable.dryrun.error.disable.outbound.data.transfer.billing</para>
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>pconn.high.reliable.dryrun.error.disable.outbound.data.transfer.billing</para>
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>pc-j5e5qqo616p81ncspbll1</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

            }

        }

        [NameInMap("PhysicalConnectionList")]
        [Validation(Required=false)]
        public CreateHighReliablePhysicalConnectionResponseBodyPhysicalConnectionList PhysicalConnectionList { get; set; }
        public class CreateHighReliablePhysicalConnectionResponseBodyPhysicalConnectionList : TeaModel {
            [NameInMap("physicalConnectionList")]
            [Validation(Required=false)]
            public List<CreateHighReliablePhysicalConnectionResponseBodyPhysicalConnectionListPhysicalConnectionList> PhysicalConnectionList { get; set; }
            public class CreateHighReliablePhysicalConnectionResponseBodyPhysicalConnectionListPhysicalConnectionList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>pc-j5e5qqo616p81ncspbll1</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-shanghai</para>
                /// </summary>
                [NameInMap("RegionNo")]
                [Validation(Required=false)]
                public string RegionNo { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0ED8D006-F706-4D23-88ED-E11ED28DCAC0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
