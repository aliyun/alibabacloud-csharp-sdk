// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class UpdateDataServiceAppRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UpdateCommand")]
        [Validation(Required=false)]
        public UpdateDataServiceAppRequestUpdateCommand UpdateCommand { get; set; }
        public class UpdateDataServiceAppRequestUpdateCommand : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>200000000</para>
            /// </summary>
            [NameInMap("AppGroupId")]
            [Validation(Required=false)]
            public int? AppGroupId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12345</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public int? AppId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>默认应用</para>
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            [NameInMap("OwnerIds")]
            [Validation(Required=false)]
            public List<string> OwnerIds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>数据分析</para>
            /// </summary>
            [NameInMap("Scenarios")]
            [Validation(Required=false)]
            public string Scenarios { get; set; }

        }

    }

}
