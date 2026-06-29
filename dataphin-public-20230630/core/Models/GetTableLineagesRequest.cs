// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetTableLineagesRequest : TeaModel {
        /// <summary>
        /// <para>The filter conditions.</para>
        /// </summary>
        [NameInMap("FilterQuery")]
        [Validation(Required=false)]
        public GetTableLineagesRequestFilterQuery FilterQuery { get; set; }
        public class GetTableLineagesRequestFilterQuery : TeaModel {
            /// <summary>
            /// <para>Specifies whether to query downstream lineage. Default value: false.</para>
            /// </summary>
            [NameInMap("NeedDownstream")]
            [Validation(Required=false)]
            public bool? NeedDownstream { get; set; }

            /// <summary>
            /// <para>Specifies whether to return tables that do not exist in the asset list. Default value: false.</para>
            /// </summary>
            [NameInMap("NeedNotExistObject")]
            [Validation(Required=false)]
            public bool? NeedNotExistObject { get; set; }

            /// <summary>
            /// <para>Specifies whether to query upstream lineage. Default value: false.</para>
            /// </summary>
            [NameInMap("NeedUpstream")]
            [Validation(Required=false)]
            public bool? NeedUpstream { get; set; }

            /// <summary>
            /// <para>The environment to which the task belongs. This parameter is used for filtering. Valid values: dev and prod.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dev</para>
            /// </summary>
            [NameInMap("NodeEnv")]
            [Validation(Required=false)]
            public string NodeEnv { get; set; }

            /// <summary>
            /// <para>The list of task IDs used for filtering.</para>
            /// </summary>
            [NameInMap("NodeIdList")]
            [Validation(Required=false)]
            public List<string> NodeIdList { get; set; }

        }

        /// <summary>
        /// <para>Tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <para>The GUID of the table, which is the unique identifier of each asset.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1121</para>
        /// </summary>
        [NameInMap("TableGuid")]
        [Validation(Required=false)]
        public string TableGuid { get; set; }

    }

}
