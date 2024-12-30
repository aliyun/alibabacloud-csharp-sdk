// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateHighReliablePhysicalConnectionResponseBody : TeaModel {
        /// <summary>
        /// <para>If the request fails the dry run, the following error codes and error messages may be returned:</para>
        /// <list type="bullet">
        /// <item><description>pconn.high.reliable.dryrun.error.disable.outbound.data.transfer.billing. Billing for outbound data transfer is not enabled.</description></item>
        /// <item><description>pconn.high.reliable.dryrun.error.incompatable.device.capacity. No device in the access point supports advanced features.</description></item>
        /// <item><description>pconn.high.reliable.dryrun.error.quota.exceeded. The quota is insufficient.</description></item>
        /// <item><description>pconn.high.reliable.dryrun.error.not.enough.resource. The access point resources are insufficient.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("ErrorInfoList")]
        [Validation(Required=false)]
        public CreateHighReliablePhysicalConnectionResponseBodyErrorInfoList ErrorInfoList { get; set; }
        public class CreateHighReliablePhysicalConnectionResponseBodyErrorInfoList : TeaModel {
            [NameInMap("errorInfoList")]
            [Validation(Required=false)]
            public List<CreateHighReliablePhysicalConnectionResponseBodyErrorInfoListErrorInfoList> ErrorInfoList { get; set; }
            public class CreateHighReliablePhysicalConnectionResponseBodyErrorInfoListErrorInfoList : TeaModel {
                /// <summary>
                /// <para>Error codes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pconn.high.reliable.dryrun.error.disable.outbound.data.transfer.billing</para>
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// <para>The returned error message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pconn.high.reliable.dryrun.error.disable.outbound.data.transfer.billing</para>
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// <para>The ID of the Express Connect circuit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pc-j5e5qqo616p81ncspbll1</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

            }

        }

        /// <summary>
        /// <para>The Express Connect circuits.</para>
        /// </summary>
        [NameInMap("PhysicalConnectionList")]
        [Validation(Required=false)]
        public CreateHighReliablePhysicalConnectionResponseBodyPhysicalConnectionList PhysicalConnectionList { get; set; }
        public class CreateHighReliablePhysicalConnectionResponseBodyPhysicalConnectionList : TeaModel {
            [NameInMap("physicalConnectionList")]
            [Validation(Required=false)]
            public List<CreateHighReliablePhysicalConnectionResponseBodyPhysicalConnectionListPhysicalConnectionList> PhysicalConnectionList { get; set; }
            public class CreateHighReliablePhysicalConnectionResponseBodyPhysicalConnectionListPhysicalConnectionList : TeaModel {
                /// <summary>
                /// <para>The ID of the Express Connect circuit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pc-j5e5qqo616p81ncspbll1</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The region ID of the Express Connect circuit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-shanghai</para>
                /// </summary>
                [NameInMap("RegionNo")]
                [Validation(Required=false)]
                public string RegionNo { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0ED8D006-F706-4D23-88ED-E11ED28DCAC0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
