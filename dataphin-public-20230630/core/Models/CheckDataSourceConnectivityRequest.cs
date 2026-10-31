// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class CheckDataSourceConnectivityRequest : TeaModel {
        /// <summary>
        /// <para>The check target.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CheckCommand")]
        [Validation(Required=false)]
        public CheckDataSourceConnectivityRequestCheckCommand CheckCommand { get; set; }
        public class CheckDataSourceConnectivityRequestCheckCommand : TeaModel {
            /// <summary>
            /// <para>The connection configuration items.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("ConfigItemList")]
            [Validation(Required=false)]
            public List<CheckDataSourceConnectivityRequestCheckCommandConfigItemList> ConfigItemList { get; set; }
            public class CheckDataSourceConnectivityRequestCheckCommandConfigItemList : TeaModel {
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
                /// <para>The configuration value.</para>
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
            /// <para>The datasource type. For supported datasources, see Create a datasource.</para>
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

        /// <summary>
        /// <para>The operator ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
