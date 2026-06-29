// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class CheckComputeSourceConnectivityRequest : TeaModel {
        /// <summary>
        /// <para>The check command.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CheckCommand")]
        [Validation(Required=false)]
        public CheckComputeSourceConnectivityRequestCheckCommand CheckCommand { get; set; }
        public class CheckComputeSourceConnectivityRequestCheckCommand : TeaModel {
            /// <summary>
            /// <para>The connection configuration items.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("ConfigList")]
            [Validation(Required=false)]
            public List<CheckComputeSourceConnectivityRequestCheckCommandConfigList> ConfigList { get; set; }
            public class CheckComputeSourceConnectivityRequestCheckCommandConfigList : TeaModel {
                /// <summary>
                /// <para>The configuration item.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>k1</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The value of the configuration item.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v1</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The compute source type.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MAX_COMPUTE</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

    }

}
