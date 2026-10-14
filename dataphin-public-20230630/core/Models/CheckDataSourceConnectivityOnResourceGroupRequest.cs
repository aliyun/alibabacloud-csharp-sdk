// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class CheckDataSourceConnectivityOnResourceGroupRequest : TeaModel {
        /// <summary>
        /// <para>The check object.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CheckCommand")]
        [Validation(Required=false)]
        public CheckDataSourceConnectivityOnResourceGroupRequestCheckCommand CheckCommand { get; set; }
        public class CheckDataSourceConnectivityOnResourceGroupRequestCheckCommand : TeaModel {
            /// <summary>
            /// <para>The connection configuration items. If DataSourceId is specified, this parameter is optional and the saved configurations of the data source are used by default.</para>
            /// </summary>
            [NameInMap("ConfigItemList")]
            [Validation(Required=false)]
            public List<CheckDataSourceConnectivityOnResourceGroupRequestCheckCommandConfigItemList> ConfigItemList { get; set; }
            public class CheckDataSourceConnectivityOnResourceGroupRequestCheckCommandConfigItemList : TeaModel {
                /// <summary>
                /// <para>The key of the configuration item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>jdbc.url</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The configuration value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>jdbc:mysql://host:port/database</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The data source ID. This parameter is optional. If specified, the check result is associated with the data source and visible on the data source page, and the old check records of the data source on the target resource group are cleared first. If Type and ConfigItemList are not specified, the saved type and configurations of the data source are used for the check.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("DataSourceId")]
            [Validation(Required=false)]
            public string DataSourceId { get; set; }

            /// <summary>
            /// <para>The ID of the schedule resource group. The connectivity check task is executed on this resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg_269xxxxx</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The data source type. If DataSourceId is specified, this parameter is optional and the saved type of the data source is used by default.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MYSQL</para>
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
        /// <para>The ID of the operator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
