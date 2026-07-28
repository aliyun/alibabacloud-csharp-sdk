// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Milvus20231012.Models
{
    public class UpdateInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable automatic backup.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("autoBackup")]
        [Validation(Required=false)]
        public bool? AutoBackup { get; set; }

        [NameInMap("autoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>The component information.</para>
        /// </summary>
        [NameInMap("components")]
        [Validation(Required=false)]
        public List<UpdateInstanceRequestComponents> Components { get; set; }
        public class UpdateInstanceRequestComponents : TeaModel {
            /// <summary>
            /// <para>The number of compute units (CUs).</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("cuNum")]
            [Validation(Required=false)]
            public int? CuNum { get; set; }

            [NameInMap("cuType")]
            [Validation(Required=false)]
            public string CuType { get; set; }

            [NameInMap("dataDisk")]
            [Validation(Required=false)]
            public UpdateInstanceRequestComponentsDataDisk DataDisk { get; set; }
            public class UpdateInstanceRequestComponentsDataDisk : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>PL1</para>
                /// </summary>
                [NameInMap("performanceLevel")]
                [Validation(Required=false)]
                public string PerformanceLevel { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("size")]
                [Validation(Required=false)]
                public int? Size { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>alicloud-disk-essd-pl1</para>
                /// </summary>
                [NameInMap("storageClass")]
                [Validation(Required=false)]
                public string StorageClass { get; set; }

            }

            [NameInMap("payType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

            /// <summary>
            /// <para>The number of replicas.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("replica")]
            [Validation(Required=false)]
            public int? Replica { get; set; }

            /// <summary>
            /// <para>The component type.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>standalone</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The configuration information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rootCoord:\n  maxDatabaseNum: 64</para>
        /// </summary>
        [NameInMap("configuration")]
        [Validation(Required=false)]
        public string Configuration { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable high availability.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ha")]
        [Validation(Required=false)]
        public bool? Ha { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-xxxx</para>
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The instance name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>milvus-test</para>
        /// </summary>
        [NameInMap("instanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. This parameter value is generated by the client and must be unique among different requests. The value can be up to 64 ASCII characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
